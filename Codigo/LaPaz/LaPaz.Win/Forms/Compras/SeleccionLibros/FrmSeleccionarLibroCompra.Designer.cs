namespace LaPaz.Win.Forms.Compras
{
    partial class FrmSeleccionarLibroCompra
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.GridTitulos = new Telerik.WinControls.UI.RadGridView();
            this.TitulosPager = new Framework.WinForm.Controls.MetroPager();
            this.BtnSeleccionar = new Telerik.WinControls.UI.RadButton();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.TxtCantidad = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtDescuento = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtSubtotal = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtPrecioCompra = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtPrecioVenta = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.BtnNuevoLibro = new Telerik.WinControls.UI.RadButton();
            this.ChkCalcular = new Telerik.WinControls.UI.RadCheckBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.UcFiltrosLibros = new LaPaz.Win.Forms.Libros.UcFiltrosLibros();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevoLibro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCalcular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.radLabel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GridTitulos
            // 
            this.GridTitulos.BackColor = System.Drawing.Color.White;
            this.GridTitulos.Cursor = System.Windows.Forms.Cursors.Default;
            this.GridTitulos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTitulos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GridTitulos.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.GridTitulos.Location = new System.Drawing.Point(3, 174);
            // 
            // GridTitulos
            // 
            this.GridTitulos.MasterTemplate.AllowAddNewRow = false;
            this.GridTitulos.MasterTemplate.AllowColumnReorder = false;
            this.GridTitulos.MasterTemplate.AllowDeleteRow = false;
            this.GridTitulos.MasterTemplate.AllowDragToGroup = false;
            this.GridTitulos.MasterTemplate.AllowEditRow = false;
            this.GridTitulos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.EnableExpressionEditor = false;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.Width = 34;
            gridViewTextBoxColumn2.EnableExpressionEditor = false;
            gridViewTextBoxColumn2.FieldName = "Cod";
            gridViewTextBoxColumn2.HeaderText = "Codigo";
            gridViewTextBoxColumn2.Name = "Codigo";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 127;
            gridViewTextBoxColumn3.EnableExpressionEditor = false;
            gridViewTextBoxColumn3.FieldName = "NombreTitulo";
            gridViewTextBoxColumn3.HeaderText = "Titulo";
            gridViewTextBoxColumn3.Name = "Titulo";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 282;
            gridViewTextBoxColumn4.EnableExpressionEditor = false;
            gridViewTextBoxColumn4.FieldName = "AutorNombre";
            gridViewTextBoxColumn4.HeaderText = "Autor";
            gridViewTextBoxColumn4.Name = "Autor";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 101;
            gridViewTextBoxColumn5.FieldName = "EditorialNombre";
            gridViewTextBoxColumn5.HeaderText = "Editorial";
            gridViewTextBoxColumn5.Name = "EditorialNombre";
            gridViewTextBoxColumn5.Width = 101;
            gridViewTextBoxColumn6.EnableExpressionEditor = false;
            gridViewTextBoxColumn6.FieldName = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.HeaderText = "Precio";
            gridViewTextBoxColumn6.Name = "PVenta";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 60;
            gridViewTextBoxColumn7.Expression = "";
            gridViewTextBoxColumn7.FieldName = "FechaModificacion";
            gridViewTextBoxColumn7.HeaderText = "Modificacion";
            gridViewTextBoxColumn7.Name = "FModificacion";
            gridViewTextBoxColumn7.Width = 69;
            gridViewTextBoxColumn8.FieldName = "UsuarioUltimoPrecio";
            gridViewTextBoxColumn8.HeaderText = "Operador";
            gridViewTextBoxColumn8.Name = "UsuarioUltimoPrecio";
            gridViewTextBoxColumn8.Width = 69;
            gridViewTextBoxColumn9.FieldName = "TituloStockStkPr";
            gridViewTextBoxColumn9.HeaderText = "St. Pr.";
            gridViewTextBoxColumn9.Name = "TituloStockStkPr";
            gridViewTextBoxColumn10.FieldName = "TituloStockStkCn";
            gridViewTextBoxColumn10.HeaderText = "St. Cn.";
            gridViewTextBoxColumn10.Name = "TituloStockStkCn";
            gridViewTextBoxColumn11.FieldName = "TituloStockStkPrViejo";
            gridViewTextBoxColumn11.HeaderText = "PR 8";
            gridViewTextBoxColumn11.Name = "TituloStockStkPrViejo";
            gridViewTextBoxColumn12.FieldName = "TituloStockStkCnViejo";
            gridViewTextBoxColumn12.HeaderText = "CN 8";
            gridViewTextBoxColumn12.Name = "TituloStockStkCnViejo";
            gridViewTextBoxColumn12.Width = 52;
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
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.GridTitulos.Name = "GridTitulos";
            this.GridTitulos.ReadOnly = true;
            this.GridTitulos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.GridTitulos.Size = new System.Drawing.Size(1023, 308);
            this.GridTitulos.TabIndex = 1;
            this.GridTitulos.ThemeName = "TelerikMetroBlue";
            this.GridTitulos.SelectionChanged += new System.EventHandler(this.GridTitulos_SelectionChanged);
            this.GridTitulos.Click += new System.EventHandler(this.GridTitulos_DoubleClick);
            this.GridTitulos.DoubleClick += new System.EventHandler(this.GridTitulos_DoubleClick);
            // 
            // TitulosPager
            // 
            this.TitulosPager.CurrentPage = 1;
            this.TitulosPager.Location = new System.Drawing.Point(398, 485);
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
            this.BtnSeleccionar.Location = new System.Drawing.Point(47, 265);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(121, 31);
            this.BtnSeleccionar.TabIndex = 25;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.ThemeName = "TelerikMetroBlue";
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.TxtCantidad);
            this.metroPanel1.Controls.Add(this.TxtDescuento);
            this.metroPanel1.Controls.Add(this.TxtSubtotal);
            this.metroPanel1.Controls.Add(this.TxtPrecioCompra);
            this.metroPanel1.Controls.Add(this.TxtPrecioVenta);
            this.metroPanel1.Controls.Add(this.BtnNuevoLibro);
            this.metroPanel1.Controls.Add(this.ChkCalcular);
            this.metroPanel1.Controls.Add(this.radLabel2);
            this.metroPanel1.Controls.Add(this.radLabel1);
            this.metroPanel1.Controls.Add(this.BtnSeleccionar);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Location = new System.Drawing.Point(1032, 174);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(193, 308);
            this.metroPanel1.TabIndex = 11;
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.ForeColor = System.Drawing.Color.Black;
            this.TxtCantidad.Location = new System.Drawing.Point(119, 187);
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(71, 25);
            this.TxtCantidad.TabIndex = 24;
            this.TxtCantidad.TabStop = false;
            this.TxtCantidad.Text = "0";
            this.TxtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCantidad.TextChanged += new System.EventHandler(this.TxtCantidad_TextChanged_1);
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.ForeColor = System.Drawing.Color.Black;
            this.TxtDescuento.Location = new System.Drawing.Point(119, 91);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(71, 25);
            this.TxtDescuento.TabIndex = 21;
            this.TxtDescuento.TabStop = false;
            this.TxtDescuento.Text = "0";
            this.TxtDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDescuento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtDescuento_KeyUp);
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.AceptaNegativos = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(90, 219);
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(100, 25);
            this.TxtSubtotal.TabIndex = 20;
            this.TxtSubtotal.TabStop = false;
            this.TxtSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TxtPrecioCompra
            // 
            this.TxtPrecioCompra.AceptaNegativos = false;
            this.TxtPrecioCompra.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioCompra.Location = new System.Drawing.Point(119, 155);
            this.TxtPrecioCompra.Name = "TxtPrecioCompra";
            this.TxtPrecioCompra.Size = new System.Drawing.Size(71, 25);
            this.TxtPrecioCompra.TabIndex = 23;
            this.TxtPrecioCompra.TabStop = false;
            this.TxtPrecioCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioCompra.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrecioCompra_KeyUp);
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.AceptaNegativos = false;
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(119, 125);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(71, 25);
            this.TxtPrecioVenta.TabIndex = 22;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioVenta.ThemeName = "ControlDefault";
            this.TxtPrecioVenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrecioVenta_KeyUp);
            // 
            // BtnNuevoLibro
            // 
            this.BtnNuevoLibro.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevoLibro.Location = new System.Drawing.Point(61, 12);
            this.BtnNuevoLibro.Name = "BtnNuevoLibro";
            this.BtnNuevoLibro.Size = new System.Drawing.Size(121, 31);
            this.BtnNuevoLibro.TabIndex = 15;
            this.BtnNuevoLibro.Text = "Nuevo";
            this.BtnNuevoLibro.ThemeName = "TelerikMetroBlue";
            this.BtnNuevoLibro.Click += new System.EventHandler(this.BtnNuevoLibro_Click);
            // 
            // ChkCalcular
            // 
            this.ChkCalcular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkCalcular.Location = new System.Drawing.Point(7, 58);
            this.ChkCalcular.Name = "ChkCalcular";
            this.ChkCalcular.Size = new System.Drawing.Size(79, 24);
            this.ChkCalcular.TabIndex = 14;
            this.ChkCalcular.Text = "Calcular";
            this.ChkCalcular.ThemeName = "TelerikMetroBlue";
            this.ChkCalcular.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.ChkCalcular_ToggleStateChanged);
            // 
            // radLabel2
            // 
            this.radLabel2.Controls.Add(this.radTextBox1);
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(5, 123);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(94, 24);
            this.radLabel2.TabIndex = 13;
            this.radLabel2.Text = "Precio venta:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(97, 2);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(80, 26);
            this.radTextBox1.TabIndex = 4;
            this.radTextBox1.TabStop = false;
            this.radTextBox1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(5, 91);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(83, 24);
            this.radLabel1.TabIndex = 12;
            this.radLabel1.Text = "Descuento:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(5, 219);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(68, 24);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Subtotal:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(5, 155);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(109, 24);
            this.metroLabel3.TabIndex = 5;
            this.metroLabel3.Text = "Precio compra:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(5, 187);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(72, 24);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Cantidad:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
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
            this.UcFiltrosLibros.Location = new System.Drawing.Point(3, 2);
            this.UcFiltrosLibros.Name = "UcFiltrosLibros";
            this.UcFiltrosLibros.NombreTitulo = "";
            this.UcFiltrosLibros.OchoDeMarzo = null;
            this.UcFiltrosLibros.ProveedorId = null;
            this.UcFiltrosLibros.Size = new System.Drawing.Size(1222, 166);
            this.UcFiltrosLibros.TabIndex = 1;
            this.UcFiltrosLibros.TemaId = null;
            // 
            // FrmSeleccionarLibroCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1239, 539);
            this.Controls.Add(this.UcFiltrosLibros);
            this.Controls.Add(this.TitulosPager);
            this.Controls.Add(this.GridTitulos);
            this.Controls.Add(this.metroPanel1);
            this.KeyPreview = true;
            this.Name = "FrmSeleccionarLibroCompra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Libro";
            this.Load += new System.EventHandler(this.FrmSeleccionarLibro_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSeleccionarLibroCompra_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevoLibro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkCalcular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.radLabel2.ResumeLayout(false);
            this.radLabel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private UcBuscadorLibro UcBuscadorLibro;
        private Telerik.WinControls.UI.RadGridView GridTitulos;
        private Framework.WinForm.Controls.MetroPager TitulosPager;
        private Telerik.WinControls.UI.RadButton BtnSeleccionar;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Codigo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Titulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Autor;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PVenta;
        private Libros.UcFiltrosLibros UcFiltrosLibros;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadCheckBox ChkCalcular;
        private Telerik.WinControls.UI.RadButton BtnNuevoLibro;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioVenta;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioCompra;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtSubtotal;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtDescuento;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCantidad;
       }
}