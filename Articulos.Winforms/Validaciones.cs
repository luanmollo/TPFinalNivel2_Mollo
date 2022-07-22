using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
