﻿namespace LaPaz.Win.Forms.Presupuesto
{
    partial class FrmSeleccionarLibroPresupuesto
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.GridTitulos = new Telerik.WinControls.UI.RadGridView();
            this.TitulosPager = new Framework.WinForm.Controls.MetroPager();
            this.BtnSeleccionar = new Telerik.WinControls.UI.RadButton();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtConsignado = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtSubtotal = new Telerik.WinControls.UI.RadTextBox();
            this.TxtDescuento = new Telerik.WinControls.UI.RadTextBox();
            this.TxtPropio = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCantidad = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPrecioVenta = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.UcFiltrosLibros = new LaPaz.Win.Forms.Libros.UcFiltrosLibros();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPropio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTitulos
            // 
            this.GridTitulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTitulos.Location = new System.Drawing.Point(3, 166);
            // 
            // GridTitulos
            // 
            this.GridTitulos.MasterTemplate.AllowAddNewRow = false;
            this.GridTitulos.MasterTemplate.AllowColumnReorder = false;
            this.GridTitulos.MasterTemplate.AllowDeleteRow = false;
            this.GridTitulos.MasterTemplate.AllowDragToGroup = false;
            this.GridTitulos.MasterTemplate.AllowEditRow = false;
            this.GridTitulos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Cod";
            gridViewTextBoxColumn1.HeaderText = "Código";
            gridViewTextBoxColumn1.Name = "Codigo";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 130;
            gridViewTextBoxColumn2.FieldName = "NombreTitulo";
            gridViewTextBoxColumn2.HeaderText = "Título";
            gridViewTextBoxColumn2.Name = "Titulo";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 293;
            gridViewTextBoxColumn3.FieldName = "AutorNombre";
            gridViewTextBoxColumn3.HeaderText = "Autor";
            gridViewTextBoxColumn3.Name = "Autor";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "EditorialNombre";
            gridViewTextBoxColumn4.HeaderText = "Editorial";
            gridViewTextBoxColumn4.Name = "EditorialNombre";
            gridViewTextBoxColumn4.Width = 100;
            gridViewTextBoxColumn5.FieldName = "PrecioVentaTitulo";
            gridViewTextBoxColumn5.FormatString = "{0:c2}";
            gridViewTextBoxColumn5.HeaderText = "Precio";
            gridViewTextBoxColumn5.Name = "PVenta";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 60;
            gridViewTextBoxColumn6.FieldName = "FechaModificacion";
            gridViewTextBoxColumn6.HeaderText = "Modificacion";
            gridViewTextBoxColumn6.Name = "FModificacion";
            gridViewTextBoxColumn6.Width = 70;
            gridViewTextBoxColumn7.FieldName = "UsuarioUltimoPrecio";
            gridViewTextBoxColumn7.HeaderText = "Operador";
            gridViewTextBoxColumn7.Name = "UsuarioUltimoPrecio";
            gridViewTextBoxColumn7.Width = 96;
            gridViewTextBoxColumn8.FieldName = "TituloStockStkPr";
            gridViewTextBoxColumn8.HeaderText = "St. Pr.";
            gridViewTextBoxColumn8.Name = "TituloStockStkPr";
            gridViewTextBoxColumn9.FieldName = "TituloStockStkCn";
            gridViewTextBoxColumn9.HeaderText = "St. Cn.";
            gridViewTextBoxColumn9.Name = "TituloStockStkCn";
            gridViewTextBoxColumn10.FieldName = "TituloStockStkPrViejo";
            gridViewTextBoxColumn10.HeaderText = "PR 8";
            gridViewTextBoxColumn10.Name = "TituloStockStkPrViejo";
            gridViewTextBoxColumn11.FieldName = "TituloStockStkCnViejo";
            gridViewTextBoxColumn11.HeaderText = "CN 8";
            gridViewTextBoxColumn11.Name = "TituloStockStkCnViejo";
            this.GridTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.GridTitulos.MasterTemplate.EnableGrouping = false;
            this.GridTitulos.Name = "GridTitulos";
            this.GridTitulos.ReadOnly = true;
            this.GridTitulos.Size = new System.Drawing.Size(1061, 308);
            this.GridTitulos.TabIndex = 2;
            this.GridTitulos.ThemeName = "TelerikMetroBlue";
            this.GridTitulos.SelectionChanged += new System.EventHandler(this.GridTitulos_SelectionChanged);
            this.GridTitulos.Click += new System.EventHandler(this.GridTitulos_DoubleClick);
            this.GridTitulos.DoubleClick += new System.EventHandler(this.GridTitulos_DoubleClick);
            // 
            // TitulosPager
            // 
            this.TitulosPager.CurrentPage = 1;
            this.TitulosPager.Location = new System.Drawing.Point(327, 480);
            this.TitulosPager.Name = "TitulosPager";
            this.TitulosPager.PageSize = 50;
            this.TitulosPager.PageTotal = 1;
            this.TitulosPager.RefreshAction = null;
            this.TitulosPager.RefreshActionAsync = null;
            this.TitulosPager.Size = new System.Drawing.Size(383, 42);
            this.TitulosPager.TabIndex = 9;
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(55, 261);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(121, 31);
            this.BtnSeleccionar.TabIndex = 6;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.ThemeName = "TelerikMetroBlue";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.radLabel5);
            this.metroPanel1.Controls.Add(this.TxtConsignado);
            this.metroPanel1.Controls.Add(this.radLabel1);
            this.metroPanel1.Controls.Add(this.TxtSubtotal);
            this.metroPanel1.Controls.Add(this.BtnSeleccionar);
            this.metroPanel1.Controls.Add(this.TxtDescuento);
            this.metroPanel1.Controls.Add(this.TxtPropio);
            this.metroPanel1.Controls.Add(this.TxtCantidad);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.TxtPrecioVenta);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Location = new System.Drawing.Point(1070, 166);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(185, 308);
            this.metroPanel1.TabIndex = 11;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(11, 3);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(115, 24);
            this.radLabel5.TabIndex = 5;
            this.radLabel5.Text = "Stock en nuevo:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // TxtConsignado
            // 
            this.TxtConsignado.Enabled = false;
            this.TxtConsignado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConsignado.Location = new System.Drawing.Point(126, 27);
            this.TxtConsignado.Name = "TxtConsignado";
            this.TxtConsignado.Size = new System.Drawing.Size(44, 26);
            this.TxtConsignado.TabIndex = 11;
            this.TxtConsignado.TabStop = false;
            this.TxtConsignado.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(96, 29);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(29, 24);
            this.radLabel1.TabIndex = 10;
            this.radLabel1.Text = "Cn:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(108, 146);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(62, 26);
            this.TxtSubtotal.TabIndex = 11;
            this.TxtSubtotal.TabStop = false;
            this.TxtSubtotal.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(108, 117);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(62, 26);
            this.TxtDescuento.TabIndex = 5;
            this.TxtDescuento.TabStop = false;
            this.TxtDescuento.ThemeName = "TelerikMetroBlue";
            this.TxtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            // 
            // TxtPropio
            // 
            this.TxtPropio.Enabled = false;
            this.TxtPropio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPropio.Location = new System.Drawing.Point(42, 27);
            this.TxtPropio.Name = "TxtPropio";
            this.TxtPropio.Size = new System.Drawing.Size(44, 26);
            this.TxtPropio.TabIndex = 9;
            this.TxtPropio.TabStop = false;
            this.TxtPropio.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(108, 59);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(62, 26);
            this.TxtCantidad.TabIndex = 3;
            this.TxtCantidad.TabStop = false;
            this.TxtCantidad.ThemeName = "TelerikMetroBlue";
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(11, 148);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 24);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Subtotal:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(11, 119);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 24);
            this.metroLabel4.TabIndex = 6;
            this.metroLabel4.Text = "Descuento:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(11, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(94, 24);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Precio venta:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(11, 61);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 24);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Cantidad:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(108, 88);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(62, 26);
            this.TxtPrecioVenta.TabIndex = 4;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.ThemeName = "TelerikMetroBlue";
            this.TxtPrecioVenta.TextChanged += new System.EventHandler(this.TxtPrecioVenta_TextChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(11, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(25, 24);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Pr:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // UcFiltrosLibros
            // 
            this.UcFiltrosLibros.Activos = true;
            this.UcFiltrosLibros.AutorNombre = "";
            this.UcFiltrosLibros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.UcFiltrosLibros.CodigoBarra = "";
            this.UcFiltrosLibros.CodigoLibroCompleto = null;
            this.UcFiltrosLibros.CodigoProveedor = null;
            this.UcFiltrosLibros.ConStock = null;
            this.UcFiltrosLibros.EditorialId = null;
            this.UcFiltrosLibros.ISBN = "";
            this.UcFiltrosLibros.Location = new System.Drawing.Point(3, 1);
            this.UcFiltrosLibros.Name = "UcFiltrosLibros";
            this.UcFiltrosLibros.NombreTitulo = "";
            this.UcFiltrosLibros.OchoDeMarzo = null;
            this.UcFiltrosLibros.ProveedorId = null;
            this.UcFiltrosLibros.Size = new System.Drawing.Size(1252, 159);
            this.UcFiltrosLibros.TabIndex = 1;
            this.UcFiltrosLibros.TemaId = null;
            // 
            // FrmSeleccionarLibroPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 524);
            this.Controls.Add(this.UcFiltrosLibros);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TitulosPager);
            this.Controls.Add(this.GridTitulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionarLibroPresupuesto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Libro";
            this.Load += new System.EventHandler(this.FrmSeleccionarLibro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSeleccionarLibroPresupuesto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPropio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private UcBuscadorLibro UcBuscadorLibro;
        private Telerik.WinControls.UI.RadGridView GridTitulos;
        private Framework.WinForm.Controls.MetroPager TitulosPager;
        private Telerik.WinControls.UI.RadButton BtnSeleccionar;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadTextBox TxtSubtotal;
        private Telerik.WinControls.UI.RadTextBox TxtPropio;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Codigo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Titulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Autor;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PVenta;
        private Libros.UcFiltrosLibros UcFiltrosLibros;
        private Telerik.WinControls.UI.RadTextBox TxtConsignado;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox TxtDescuento;
        private Telerik.WinControls.UI.RadTextBox TxtCantidad;
        private Telerik.WinControls.UI.RadTextBox TxtPrecioVenta;
    }
}