using Desktop.Interfaces;
using KioscoInformaticoDesktop.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.States.Localidades
{
    public class DeleteState : IFormState
    {
        private LocalidadesView _form;

        public DeleteState(LocalidadesView form)
        {
            _form = form ?? throw new ArgumentNullException(nameof(form), "El formulario no puede ser nulo.");
        }
        public void LoadGrid()
        {
            throw new NotImplementedException();
        }

        public void OnAgregar()
        {
            throw new NotImplementedException();
        }

        public void OnBuscar(string texto)
        {
            throw new NotImplementedException();
        }

        public void OnCancelar()
        {
            throw new NotImplementedException();
        }

        public void OnEliminar()
        {
            throw new NotImplementedException();
        }

        public void OnGuardar()
        {
            throw new NotImplementedException();
        }

        public void OnModificar()
        {
            throw new NotImplementedException();
        }

        public void OnSalir()
        {
            throw new NotImplementedException();
        }

        public void UpdateUI()
        {
            throw new NotImplementedException();
        }
    }
}
