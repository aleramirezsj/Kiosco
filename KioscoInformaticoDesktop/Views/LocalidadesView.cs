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
using Desktop.Interfaces;
using Desktop.States.Localidades;

namespace KioscoInformaticoDesktop.Views
{
    public partial class LocalidadesView : Form
    {
        public IFormState initialDisplayState;
        public IFormState addState;
        public IFormState editState;
        public IFormState deleteState;

        public IFormState currentState;

        public ILocalidadService localidadService = new LocalidadService();
        public BindingSource listaLocalidades = new BindingSource();
        public Localidad localidadCurrent;

        public LocalidadesView()
        {
            InitializeComponent();
            initialDisplayState = new InitialDisplayState(this);
            addState = new AddState(this);
            editState = new EditState(this);
            deleteState = new DeleteState(this);

            currentState = initialDisplayState;

            dataGridLocalidades.DataSource = listaLocalidades;
            CargarGrilla();
        }

        public void SetState(IFormState state)
        {
            currentState = state ?? throw new ArgumentNullException(nameof(state), "El estado no puede ser nulo.");
        }

        private async Task CargarGrilla()
        {
            listaLocalidades.DataSource = await localidadService.GetAllAsync();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            tabControl.SelectTab(tabPageAgregarEditar);
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombre.Text))
            {
                MessageBox.Show("El nombre de la localidad es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (localidadCurrent != null)
            {
                localidadCurrent.Nombre = txtNombre.Text;
                await localidadService.UpdateAsync(localidadCurrent);
                localidadCurrent = null;
            }
            else
            {
                var localidad = new Localidad
                {
                    Nombre = txtNombre.Text
                };
                await localidadService.AddAsync(localidad);
            }
            await CargarGrilla();
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            localidadCurrent = (Localidad)listaLocalidades.Current;
            txtNombre.Text = localidadCurrent.Nombre;
            tabControl.SelectTab(tabPageAgregarEditar);
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            localidadCurrent = null;
            txtNombre.Text = string.Empty;
            tabControl.SelectTab(tabPageLista);

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
    }
}
