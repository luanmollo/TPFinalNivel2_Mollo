﻿using Articulos.Modelo;
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
            cbCampo.Items.Add("Código");
            cbCampo.Items.Add("Nombre");
            cbCampo.Items.Add("Descripción");
            cbCampo.Items.Add("Marca");
            cbCampo.Items.Add("Categoría");
            cbCampo.Items.Add("Precio");

        }

        private void Cargar()
        {
            ArticuloServicios servicio = new ArticuloServicios();

            try
            {
                listaArticulos = servicio.Listar();
                dgvArticulos.DataSource = listaArticulos;
                OcultarColumnas();
                CargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
            dgvArticulos.Columns["UrlImagen"].Visible = false;
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


        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.UrlImagen);
            }
        }
        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();

        }

        private void cbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cbCampo.SelectedItem.ToString();

            if(opcion == "Precio")
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Mayor a");
                cbCriterio.Items.Add("Menor a");
                cbCriterio.Items.Add("Igual a");
            }
            else
            {
                cbCriterio.Items.Clear();
                cbCriterio.Items.Add("Empieza con");
                cbCriterio.Items.Add("Termina con");
                cbCriterio.Items.Add("Contiene");
            }
        }

        private bool ValidarBusquedaAvanzada()
        {
            if(cbCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar un campo");
                return true;
            }

            if(cbCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Debes seleccionar un criterio");
                return true;
            }

            if(cbCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltro.Text))
                {
                    MessageBox.Show("Debes ingresar un filtro");
                    return true;
                }

                if (!(Validaciones.ValidarSoloNumeros(txtFiltro.Text)))
                {
                    MessageBox.Show("Debes ingresar sólo números");
                    return true;
                }
            }

            return false;
        }


        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            ArticuloServicios servicio = new ArticuloServicios();

            try
            {

                if (ValidarBusquedaAvanzada())
                    return;
                
                string campo = cbCampo.SelectedItem.ToString();
                string criterio = cbCriterio.SelectedItem.ToString();
                string filtro = txtFiltro.Text;

                dgvArticulos.DataSource = servicio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (Validaciones.ValidarSeleccionFila(dgvArticulos))
                return;

            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }
    }
}
