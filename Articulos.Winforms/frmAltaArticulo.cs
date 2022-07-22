using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Articulos.Modelo;
using Articulos.Servicios;

namespace Articulos.Winforms
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaServicios marcaServicio = new MarcaServicios();
            CategoriaServicios categoriaServicio = new CategoriaServicios();

            try
            {
                cbMarca.DataSource = marcaServicio.Listar();
                cbMarca.ValueMember = "Id";
                cbMarca.DisplayMember = "Descripcion";

                cbCategoria.DataSource = categoriaServicio.Listar();
                cbCategoria.ValueMember = "Id";
                cbCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private bool ValidarAltaArticulo()
        {
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtDescripcion.Text) || string.IsNullOrEmpty(txtImagen.Text) || string.IsNullOrEmpty(txtPrecio.Text)){
                MessageBox.Show("Debes completar todos los campos");
                return true;
            }

            if (!(Validaciones.ValidarSoloNumeros(txtPrecio.Text)))
            {
                MessageBox.Show("Debes ingresar sólo números en el campo 'Precio'");
                return true;
            }
            

            return false;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloServicios articuloServicio = new ArticuloServicios();

            try
            {
                if (ValidarAltaArticulo())
                    return;

                Articulo articulo = new Articulo();

                articulo.Codigo = txtCodigo.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbCategoria.SelectedItem;
                articulo.UrlImagen = txtImagen.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);


                articuloServicio.Agregar(articulo);

                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbArticulo.Load(imagen);
            }
            catch (Exception ex)
            {

                pbArticulo.Load("https://www.sinrumbofijo.com/wp-content/uploads/2016/05/default-placeholder.png");
            }
        }

        private void txtImagen_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtImagen.Text);
        }
    }
}
