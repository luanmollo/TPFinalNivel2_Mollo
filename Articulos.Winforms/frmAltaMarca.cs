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
        public frmAltaMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MarcaServicios servicio = new MarcaServicios();

            try
            {
                if(!(string.IsNullOrEmpty(txtDescripcion.Text)))
                {
                    Marca marca = new Marca();

                    marca.Descripcion = txtDescripcion.Text;
                    servicio.Agregar(marca);
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
