using Service.Services;
using Service.Interfaces;
using Service.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KioscoInformaticoDesktop.Views
{
    public partial class LocalidadesView : Form
    {
        ILocalidadService localidadService = new LocalidadService();
        BindingSource listaLocalidades = new BindingSource();
        Localidad localidadCurrent;

        State _state;

        private async Task SetStateAsync(State state)
        {
            _state = state;
            await state.Enter();
        }

        public LocalidadesView()
        {
            InitializeComponent();
            dataGridLocalidades.DataSource = listaLocalidades;
            _state = new ListState(this);
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            listaLocalidades.DataSource = await localidadService.GetAllAsync();
        }

        private async void btnAgregar_Click(object sender, EventArgs e)
        {
            await SetStateAsync(new AddState(this));
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (_state != null)
            {
                await _state.SaveAsync();
            }
        }

        private async void btnModificar_Click(object sender, EventArgs e)
        {
            var localidad = (Localidad)listaLocalidades.Current;
            if (localidad != null)
            {
                await SetStateAsync(new EditState(this, localidad));
            }
        }
        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)listaLocalidades.Current;
            var result = MessageBox.Show($"¿Está seguro que desea eliminar la localidad {localidadCurrent.Nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await localidadService.DeleteAsync(localidadCurrent.Id);
                await CargarGrilla();
            }
            localidadCurrent = null;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            if (_state != null)
            {
                await _state.CancelAsync();
            }
        }
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            FiltrarLocalidades();
        }

        private async void FiltrarLocalidades()
        {
            listaLocalidades.DataSource = await localidadService.GetAllAsync(txtFiltro.Text);
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
        }

        private abstract class State
        {
            protected LocalidadesView view;
            protected State(LocalidadesView view) { this.view = view; }
            public virtual Task Enter() { return Task.CompletedTask; }
            public virtual Task SaveAsync() { return Task.CompletedTask; }
            public virtual Task CancelAsync() { return Task.CompletedTask; }
        }

        private class ListState : State
        {
            public ListState(LocalidadesView view) : base(view) { }
            public override async Task Enter()
            {
                await view.CargarGrilla();
                view.txtNombre.Text = string.Empty;
                view.localidadCurrent = null;
                view.tabControl.SelectTab(view.tabPageLista);
            }
        }

        private class AddState : State
        {
            public AddState(LocalidadesView view) : base(view) { }
            public override Task Enter()
            {
                view.txtNombre.Text = string.Empty;
                view.localidadCurrent = null;
                view.tabControl.SelectTab(view.tabPageAgregarEditar);
                return Task.CompletedTask;
            }
            public override async Task SaveAsync()
            {
                var localidad = new Localidad
                {
                    Nombre = view.txtNombre.Text
                };
                await view.localidadService.AddAsync(localidad);
                await view.SetStateAsync(new ListState(view));
            }
            public override async Task CancelAsync()
            {
                await view.SetStateAsync(new ListState(view));
            }
        }

        private class EditState : State
        {
            public EditState(LocalidadesView view, Localidad localidad) : base(view)
            {
                view.localidadCurrent = localidad;
            }
            public override Task Enter()
            {
                view.txtNombre.Text = view.localidadCurrent.Nombre;
                view.tabControl.SelectTab(view.tabPageAgregarEditar);
                return Task.CompletedTask;
            }
            public override async Task SaveAsync()
            {
                view.localidadCurrent.Nombre = view.txtNombre.Text;
                await view.localidadService.UpdateAsync(view.localidadCurrent);
                view.localidadCurrent = null;
                await view.SetStateAsync(new ListState(view));
            }
            public override async Task CancelAsync()
            {
                view.localidadCurrent = null;
                await view.SetStateAsync(new ListState(view));
            }
        }
    }
}
