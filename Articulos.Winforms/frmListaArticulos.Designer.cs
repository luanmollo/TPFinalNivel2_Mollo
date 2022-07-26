﻿namespace Articulos.Winforms
{
    partial class frmListaArticulos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbArticulo = new System.Windows.Forms.PictureBox();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnBusquedaAvanzada = new System.Windows.Forms.Button();
            this.gbBusquedaAvanzada = new System.Windows.Forms.GroupBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblCampo = new System.Windows.Forms.Label();
            this.linklblLimpiarFiltros = new System.Windows.Forms.LinkLabel();
            this.gbArticulo = new System.Windows.Forms.GroupBox();
            this.gbMarca = new System.Windows.Forms.GroupBox();
            this.btnEliminarMarca = new System.Windows.Forms.Button();
            this.btnAgregarMarca = new System.Windows.Forms.Button();
            this.gbCategoria = new System.Windows.Forms.GroupBox();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.gbBusquedaGrupo = new System.Windows.Forms.GroupBox();
            this.btnBusquedaGrupo = new System.Windows.Forms.Button();
            this.cbValor = new System.Windows.Forms.ComboBox();
            this.cbGrupo = new System.Windows.Forms.ComboBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblGrupo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).BeginInit();
            this.gbBusquedaAvanzada.SuspendLayout();
            this.gbArticulo.SuspendLayout();
            this.gbMarca.SuspendLayout();
            this.gbCategoria.SuspendLayout();
            this.gbBusquedaGrupo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(21, 12);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.ReadOnly = true;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(606, 221);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellDoubleClick);
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(19, 16);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 23);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(172, 16);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(111, 23);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(325, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbArticulo
            // 
            this.pbArticulo.Location = new System.Drawing.Point(678, 12);
            this.pbArticulo.Name = "pbArticulo";
            this.pbArticulo.Size = new System.Drawing.Size(221, 221);
            this.pbArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulo.TabIndex = 5;
            this.pbArticulo.TabStop = false;
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(19, 38);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(111, 21);
            this.cbCampo.TabIndex = 0;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(172, 38);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(111, 21);
            this.cbCriterio.TabIndex = 1;
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(325, 38);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(111, 20);
            this.txtFiltro.TabIndex = 2;
            // 
            // btnBusquedaAvanzada
            // 
            this.btnBusquedaAvanzada.Location = new System.Drawing.Point(478, 37);
            this.btnBusquedaAvanzada.Name = "btnBusquedaAvanzada";
            this.btnBusquedaAvanzada.Size = new System.Drawing.Size(111, 23);
            this.btnBusquedaAvanzada.TabIndex = 3;
            this.btnBusquedaAvanzada.Text = "Buscar";
            this.btnBusquedaAvanzada.UseVisualStyleBackColor = true;
            this.btnBusquedaAvanzada.Click += new System.EventHandler(this.btnBusquedaAvanzada_Click);
            // 
            // gbBusquedaAvanzada
            // 
            this.gbBusquedaAvanzada.Controls.Add(this.lblFiltro);
            this.gbBusquedaAvanzada.Controls.Add(this.lblCriterio);
            this.gbBusquedaAvanzada.Controls.Add(this.lblCampo);
            this.gbBusquedaAvanzada.Controls.Add(this.txtFiltro);
            this.gbBusquedaAvanzada.Controls.Add(this.btnBusquedaAvanzada);
            this.gbBusquedaAvanzada.Controls.Add(this.cbCampo);
            this.gbBusquedaAvanzada.Controls.Add(this.cbCriterio);
            this.gbBusquedaAvanzada.Location = new System.Drawing.Point(21, 368);
            this.gbBusquedaAvanzada.Name = "gbBusquedaAvanzada";
            this.gbBusquedaAvanzada.Size = new System.Drawing.Size(606, 74);
            this.gbBusquedaAvanzada.TabIndex = 10;
            this.gbBusquedaAvanzada.TabStop = false;
            this.gbBusquedaAvanzada.Text = "Búsqueda avanzada";
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(322, 20);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(32, 13);
            this.lblFiltro.TabIndex = 12;
            this.lblFiltro.Text = "Filtro:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(169, 22);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 11;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(19, 20);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 10;
            this.lblCampo.Text = "Campo:";
            // 
            // linklblLimpiarFiltros
            // 
            this.linklblLimpiarFiltros.AutoSize = true;
            this.linklblLimpiarFiltros.Location = new System.Drawing.Point(560, 236);
            this.linklblLimpiarFiltros.Name = "linklblLimpiarFiltros";
            this.linklblLimpiarFiltros.Size = new System.Drawing.Size(67, 13);
            this.linklblLimpiarFiltros.TabIndex = 13;
            this.linklblLimpiarFiltros.TabStop = true;
            this.linklblLimpiarFiltros.Text = "Limpiar filtros";
            this.linklblLimpiarFiltros.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linklblLimpiarFiltros_LinkClicked);
            // 
            // gbArticulo
            // 
            this.gbArticulo.Controls.Add(this.btnEliminar);
            this.gbArticulo.Controls.Add(this.btnAgregar);
            this.gbArticulo.Controls.Add(this.btnModificar);
            this.gbArticulo.Location = new System.Drawing.Point(21, 252);
            this.gbArticulo.Name = "gbArticulo";
            this.gbArticulo.Size = new System.Drawing.Size(606, 52);
            this.gbArticulo.TabIndex = 11;
            this.gbArticulo.TabStop = false;
            this.gbArticulo.Text = "Articulo";
            // 
            // gbMarca
            // 
            this.gbMarca.Controls.Add(this.btnEliminarMarca);
            this.gbMarca.Controls.Add(this.btnAgregarMarca);
            this.gbMarca.Location = new System.Drawing.Point(21, 310);
            this.gbMarca.Name = "gbMarca";
            this.gbMarca.Size = new System.Drawing.Size(302, 52);
            this.gbMarca.TabIndex = 12;
            this.gbMarca.TabStop = false;
            this.gbMarca.Text = "Marca";
            // 
            // btnEliminarMarca
            // 
            this.btnEliminarMarca.Location = new System.Drawing.Point(172, 19);
            this.btnEliminarMarca.Name = "btnEliminarMarca";
            this.btnEliminarMarca.Size = new System.Drawing.Size(111, 23);
            this.btnEliminarMarca.TabIndex = 1;
            this.btnEliminarMarca.Text = "Eliminar";
            this.btnEliminarMarca.UseVisualStyleBackColor = true;
            this.btnEliminarMarca.Click += new System.EventHandler(this.btnEliminarMarca_Click);
            // 
            // btnAgregarMarca
            // 
            this.btnAgregarMarca.Location = new System.Drawing.Point(22, 20);
            this.btnAgregarMarca.Name = "btnAgregarMarca";
            this.btnAgregarMarca.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarMarca.TabIndex = 0;
            this.btnAgregarMarca.Text = "Agregar";
            this.btnAgregarMarca.UseVisualStyleBackColor = true;
            this.btnAgregarMarca.Click += new System.EventHandler(this.btnAgregarMarca_Click);
            // 
            // gbCategoria
            // 
            this.gbCategoria.Controls.Add(this.btnEliminarCategoria);
            this.gbCategoria.Controls.Add(this.btnAgregarCategoria);
            this.gbCategoria.Location = new System.Drawing.Point(325, 310);
            this.gbCategoria.Name = "gbCategoria";
            this.gbCategoria.Size = new System.Drawing.Size(302, 52);
            this.gbCategoria.TabIndex = 13;
            this.gbCategoria.TabStop = false;
            this.gbCategoria.Text = "Categoría";
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(174, 19);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(111, 23);
            this.btnEliminarCategoria.TabIndex = 1;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(21, 19);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(111, 23);
            this.btnAgregarCategoria.TabIndex = 0;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // gbBusquedaGrupo
            // 
            this.gbBusquedaGrupo.Controls.Add(this.btnBusquedaGrupo);
            this.gbBusquedaGrupo.Controls.Add(this.cbValor);
            this.gbBusquedaGrupo.Controls.Add(this.cbGrupo);
            this.gbBusquedaGrupo.Controls.Add(this.lblValor);
            this.gbBusquedaGrupo.Controls.Add(this.lblGrupo);
            this.gbBusquedaGrupo.Location = new System.Drawing.Point(21, 449);
            this.gbBusquedaGrupo.Name = "gbBusquedaGrupo";
            this.gbBusquedaGrupo.Size = new System.Drawing.Size(606, 74);
            this.gbBusquedaGrupo.TabIndex = 14;
            this.gbBusquedaGrupo.TabStop = false;
            this.gbBusquedaGrupo.Text = "Búsqueda por grupo";
            // 
            // btnBusquedaGrupo
            // 
            this.btnBusquedaGrupo.Location = new System.Drawing.Point(325, 37);
            this.btnBusquedaGrupo.Name = "btnBusquedaGrupo";
            this.btnBusquedaGrupo.Size = new System.Drawing.Size(111, 23);
            this.btnBusquedaGrupo.TabIndex = 2;
            this.btnBusquedaGrupo.Text = "Buscar";
            this.btnBusquedaGrupo.UseVisualStyleBackColor = true;
            this.btnBusquedaGrupo.Click += new System.EventHandler(this.btnBusquedaGrupo_Click);
            // 
            // cbValor
            // 
            this.cbValor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbValor.FormattingEnabled = true;
            this.cbValor.Location = new System.Drawing.Point(172, 37);
            this.cbValor.Name = "cbValor";
            this.cbValor.Size = new System.Drawing.Size(111, 21);
            this.cbValor.TabIndex = 1;
            // 
            // cbGrupo
            // 
            this.cbGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGrupo.FormattingEnabled = true;
            this.cbGrupo.Location = new System.Drawing.Point(19, 37);
            this.cbGrupo.Name = "cbGrupo";
            this.cbGrupo.Size = new System.Drawing.Size(111, 21);
            this.cbGrupo.TabIndex = 0;
            this.cbGrupo.SelectedIndexChanged += new System.EventHandler(this.cbGrupo_SelectedIndexChanged);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.Location = new System.Drawing.Point(169, 20);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(31, 13);
            this.lblValor.TabIndex = 1;
            this.lblValor.Text = "Valor";
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Location = new System.Drawing.Point(19, 20);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(36, 13);
            this.lblGrupo.TabIndex = 0;
            this.lblGrupo.Text = "Grupo";
            // 
            // frmListaArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 533);
            this.Controls.Add(this.linklblLimpiarFiltros);
            this.Controls.Add(this.gbBusquedaGrupo);
            this.Controls.Add(this.gbCategoria);
            this.Controls.Add(this.gbMarca);
            this.Controls.Add(this.gbArticulo);
            this.Controls.Add(this.gbBusquedaAvanzada);
            this.Controls.Add(this.pbArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Name = "frmListaArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mis articulos";
            this.Load += new System.EventHandler(this.frmListaArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulo)).EndInit();
            this.gbBusquedaAvanzada.ResumeLayout(false);
            this.gbBusquedaAvanzada.PerformLayout();
            this.gbArticulo.ResumeLayout(false);
            this.gbMarca.ResumeLayout(false);
            this.gbCategoria.ResumeLayout(false);
            this.gbBusquedaGrupo.ResumeLayout(false);
            this.gbBusquedaGrupo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnBusquedaAvanzada;
        private System.Windows.Forms.GroupBox gbBusquedaAvanzada;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblCampo;
        internal System.Windows.Forms.PictureBox pbArticulo;
        private System.Windows.Forms.LinkLabel linklblLimpiarFiltros;
        private System.Windows.Forms.GroupBox gbArticulo;
        private System.Windows.Forms.GroupBox gbMarca;
        private System.Windows.Forms.Button btnAgregarMarca;
        private System.Windows.Forms.GroupBox gbCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnEliminarMarca;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.GroupBox gbBusquedaGrupo;
        private System.Windows.Forms.ComboBox cbValor;
        private System.Windows.Forms.ComboBox cbGrupo;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.Button btnBusquedaGrupo;
    }
}

