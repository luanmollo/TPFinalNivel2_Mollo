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
    public partial class frmBajaMarca : Form
    {
        private string btnNombre;
        public frmBajaMarca(string btnNombre)
        {
            this.btnNombre = btnNombre;
            InitializeComponent();

            switch (btnNombre)
            {
                case "btnEliminarMarca":
                    Text = "Eliminar Marca";
                    break;

                case "btnEliminarCategoria":
                    Text = "Eliminar Categoría";
                    break;
            }
        }

        private void frmBajaMarca_Load(object sender, EventArgs e)
        {
            switch (btnNombre)
            {
                case "btnEliminarMarca":
                    lblEliminar.Text = "Seleccione una marca";
                    MarcaServicios marcaServicio = new MarcaServicios();
                    cbEliminar.DataSource = marcaServicio.Listar();
                    break;
                case "btnEliminarCategoria":
                    lblEliminar.Text = "Seleccione una categoría";
                    CategoriaServicios categoriaServicio = new CategoriaServicios();
                    cbEliminar.DataSource = categoriaServicio.Listar();
                    break;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            DialogResult respuesta = MessageBox.Show("¿Estás seguro de eliminar?", "¿Eliminar?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(respuesta == DialogResult.Yes)
            {
                switch (btnNombre)
                {
                    case "btnEliminarMarca":

                        if (Validaciones.ValidarEliminacionMarca((Marca)cbEliminar.SelectedItem))
                            return;

                        Marca marca = new Marca();
                        MarcaServicios marcaServicio = new MarcaServicios();
                        marca = (Marca)cbEliminar.SelectedItem;

                        marcaServicio.Eliminar(marca.Id);
                        break;

                    case "btnEliminarCategoria":

                        if (Validaciones.ValidarEliminacionCategoria((Categoria)cbEliminar.SelectedItem))
                            return;

                        Categoria categoria = new Categoria();
                        CategoriaServicios categoriaServicio = new CategoriaServicios();
                        categoria = (Categoria)cbEliminar.SelectedItem;

                        categoriaServicio.Eliminar(categoria.Id);
                        break;
                }

                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
