using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Interfaces
{
    public interface IFormState
    {
        void LoadGrid();
        void OnBuscar(string texto);
        void OnAgregar();
        void OnModificar();
        void OnEliminar();
        void OnGuardar();
        void OnCancelar();
        void OnSalir();
        void UpdateUI();
    }
}
