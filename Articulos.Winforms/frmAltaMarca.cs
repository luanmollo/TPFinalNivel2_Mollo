using Articulos.Modelo;
using Articulos.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Articulos.Winforms
{
    public partial class frmAltaMarca : Form
    {
        private string btnNombre;
        public frmAltaMarca(string btnNombre)
        {
            this.btnNombre = btnNombre;
            InitializeComponent();

            switch (btnNombre)
            {
                case "btnAgregarMarca":
                    Text = "Nueva Marca";
                    break;

                case "btnAgregarCategoria":
                    Text = "Nueva Categoría";
                    break;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if(!(string.IsNullOrEmpty(txtDescripcion.Text)))
                {
                    switch (btnNombre)
                    {
                        case "btnAgregarMarca":
                            MarcaServicios marcaServicio = new MarcaServicios();
                            Marca marca = new Marca();
                            marca.Descripcion = txtDescripcion.Text;
                            marcaServicio.Agregar(marca);
                            break;

                        case "btnAgregarCategoria":
                            CategoriaServicios categoriaServicio = new CategoriaServicios();
                            Categoria categoria = new Categoria();
                            categoria.Descripcion = txtDescripcion.Text;
                            categoriaServicio.Agregar(categoria);
                            break;
                    }

                    MessageBox.Show("Agregada exitosamente");

                    Close();
                }
                else
                {
                    MessageBox.Show("Debes completar todos los campos");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
