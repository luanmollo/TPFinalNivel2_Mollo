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
    public partial class frmListaArticulos : Form
    {
        private List<Articulo> listaArticulos;

        public frmListaArticulos()
        {
            InitializeComponent();
        }

        private void frmListaArticulos_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Cargar()
        {
            ArticuloServicios servicio = new ArticuloServicios();

            try
            {
                listaArticulos = servicio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                OcultarColumnas();
            }
            catch (Exception ex)
            {

                throw ex;
                //MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();

        }
    }
}
