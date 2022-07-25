using Articulos.Modelo;
using Articulos.Servicios;
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

        public static bool ValidarEliminacionMarca(Marca marca)
        {
            ArticuloServicios servicio = new ArticuloServicios();
            List<Articulo> lista = servicio.Listar();

            foreach (Articulo a in lista)
            {
                if(a.Marca.Id == marca.Id)
                {
                    MessageBox.Show("No se puede eliminar " + a.Marca.Descripcion + " porque hay al menos 1 articulo asociado. Elimine primero dichos articulos.");
                    return true;
                }
            }

            return false;
        }

        public static bool ValidarEliminacionCategoria(Categoria categoria)
        {
            ArticuloServicios servicio = new ArticuloServicios();
            List<Articulo> lista = servicio.Listar();

            foreach (Articulo a in lista)
            {
                if (a.Categoria.Id == categoria.Id)
                {
                    MessageBox.Show("No se puede eliminar " + a.Categoria.Descripcion + " porque hay al menos 1 articulo asociado. Elimine primero dichos articulos.");
                    return true;
                }
            }

            return false;
        }
    }
}
