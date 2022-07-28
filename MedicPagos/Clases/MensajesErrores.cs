using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicPagos
{
    class MensajesErrores
    {
        public void MensajeSeleccion()
        {
            MessageBox.Show("No hay ninguna seleccion", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeCompletarCampos()
        {
            MessageBox.Show("COMPLETAR campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeNoExisteAgre()
        {
            MessageBox.Show("No EXISTE, agreguelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeNoExisteEstu()
        {
            MessageBox.Show("No EXISTE el ESTUDIO, agreguelo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeNoExiste()
        {
            MessageBox.Show("No EXISTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeExiste()
        {
            MessageBox.Show("Ya EXISTE", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeAgregar()
        {
            MessageBox.Show("Agregado con EXITO", "Agregar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeNoAgrego()
        {
            MessageBox.Show("NO se agrego", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeGuardar()
        {
            MessageBox.Show("Guardado con EXITO", "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeNoGuardar()
        {
            MessageBox.Show("NO se guardado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeModificar()
        {
            MessageBox.Show("Modificado con EXITO", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeEliminar()
        {
            MessageBox.Show("Eliminado con EXITO", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeNoEliminar()
        {
            MessageBox.Show("No se puede Eliminar, esta asignado", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void MensajeLinceVencida()
        {
            MessageBox.Show("LICENCIA VENCIDA, comuniquese con el Administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void MensajeVencida()
        {
            MessageBox.Show("LICENCIA VENCIDA, FALLA DE INTEGRIDAD", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
