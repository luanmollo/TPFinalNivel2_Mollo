using Articulos.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articulos.Winforms
{
    public static class Validaciones
    {
        public static bool ValidarSoloNumeros(string cadena)
        {
            foreach (char c in cadena)
            {
                if (!(char.IsNumber(c)))
                    return false;
            }

            return true;
        }

        
        public static bool ValidarSeleccionFila(DataGridView dgv)
        {

            if (dgv.CurrentRow == null)
            {
                MessageBox.Show("No hay un artículo seleccionado");
                return true;
            }

            return false;
        }
        
    }
}
