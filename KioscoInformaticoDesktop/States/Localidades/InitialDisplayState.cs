using Desktop.Interfaces;
using KioscoInformaticoDesktop.Views;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Localidades
{
    public class InitialDisplayState : IFormState
    {
        private LocalidadesView _form;

        public InitialDisplayState(LocalidadesView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser nulo.");
        }
        public async void LoadGrid()
        {
            _form.listaLocalidades.DataSource = await _form.localidadService.GetAllAsync();
            _form.dataGridLocalidades.DataSource = _form.listaLocalidades;
        }

        public void OnAgregar()
        {
            _form.SetState(_form.addState);
            _form.currentState.OnAgregar();
        }

        public async void OnBuscar(string texto)
        {
            _form.listaLocalidades.DataSource = await _form.localidadService.GetAllAsync(_form.txtFiltro.Text);
            _form.dataGridLocalidades.DataSource = _form.listaLocalidades;
        }

        public void OnCancelar() {}

        public void OnEliminar()
        {
            _form.SetState(_form.deleteState);
            _form.currentState.OnEliminar();
        }

        public void OnGuardar() {}

        public void OnModificar()
        {
            _form.SetState(_form.editState);
            _form.currentState.OnModificar();
        }

        public void OnSalir()
        {
            _form.Close();
        }

        public void UpdateUI()
        {
            this.LoadGrid();
        }
    }
}
