namespace LaPaz.Win.Forms.Libros
{
    partial class FrmLibrosListado
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
            this.components = new System.ComponentModel.Container();
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn4 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn5 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UcFiltrosLibros = new LaPaz.Win.Forms.Libros.UcFiltrosLibros();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearProveedor = new Telerik.WinControls.UI.RadButton();
            this.UcProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ucEstadoTitulos1 = new LaPaz.Win.Forms.Libros.UcEstadoTitulos();
            this.TitulosPager = new Framework.WinForm.Controls.MetroPager();
            this.GridLibros = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearProveedor)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridLibros);
            this.splitContainer1.Size = new System.Drawing.Size(1380, 920);
            this.splitContainer1.SplitterDistance = 250;
            this.splitContainer1.TabIndex = 9;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.UcFiltrosLibros, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1380, 250);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UcFiltrosLibros
            // 
            this.UcFiltrosLibros.Activos = true;
            this.UcFiltrosLibros.AutorNombre = "";
            this.UcFiltrosLibros.BtnBuscarTexto = "Buscar";
            this.UcFiltrosLibros.CodigoBarra = "";
            this.UcFiltrosLibros.CodigoLibroCompleto = null;
            this.UcFiltrosLibros.CodigoProveedor = null;
            this.UcFiltrosLibros.ConStock = null;
            this.UcFiltrosLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosLibros.EditorialId = null;
            this.UcFiltrosLibros.ISBN = "";
            this.UcFiltrosLibros.Location = new System.Drawing.Point(3, 43);
            this.UcFiltrosLibros.Name = "UcFiltrosLibros";
            this.UcFiltrosLibros.NombreTitulo = "";
            this.UcFiltrosLibros.OchoDeMarzo = null;
            this.UcFiltrosLibros.ProveedorId = null;
            this.UcFiltrosLibros.Size = new System.Drawing.Size(1374, 154);
            this.UcFiltrosLibros.TabIndex = 16;
            this.UcFiltrosLibros.TemaId = null;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearProveedor, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UcProgressSpinner, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1374, 34);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // BtnCrearProveedor
            // 
            this.BtnCrearProveedor.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearProveedor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnCrearProveedor.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearProveedor.Name = "BtnCrearProveedor";
            this.BtnCrearProveedor.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearProveedor.TabIndex = 16;
            this.BtnCrearProveedor.Text = "Crear";
            this.BtnCrearProveedor.ThemeName = "TelerikMetroBlue";
            this.BtnCrearProveedor.Click += new System.EventHandler(this.BtnCrearLibro_Click);
            // 
            // UcProgressSpinner
            // 
            this.UcProgressSpinner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.UcProgressSpinner.Location = new System.Drawing.Point(1209, 3);
            this.UcProgressSpinner.Name = "UcProgressSpinner";
            this.UcProgressSpinner.Size = new System.Drawing.Size(162, 27);
            this.UcProgressSpinner.TabIndex = 17;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ucEstadoTitulos1, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.TitulosPager, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 203);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1374, 44);
            this.tableLayoutPanel3.TabIndex = 18;
            // 
            // ucEstadoTitulos1
            // 
            this.ucEstadoTitulos1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ucEstadoTitulos1.Location = new System.Drawing.Point(3, 10);
            this.ucEstadoTitulos1.Name = "ucEstadoTitulos1";
            this.ucEstadoTitulos1.Size = new System.Drawing.Size(266, 24);
            this.ucEstadoTitulos1.TabIndex = 0;
            // 
            // TitulosPager
            // 
            this.TitulosPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TitulosPager.CurrentPage = 1;
            this.TitulosPager.Location = new System.Drawing.Point(993, 3);
            this.TitulosPager.Name = "TitulosPager";
            this.TitulosPager.PageSize = 50;
            this.TitulosPager.PageTotal = 1;
            this.TitulosPager.RefreshAction = null;
            this.TitulosPager.RefreshActionAsync = null;
            this.TitulosPager.Size = new System.Drawing.Size(378, 38);
            this.TitulosPager.TabIndex = 14;
            // 
            // GridLibros
            // 
            this.GridLibros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridLibros.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridLibros.Location = new System.Drawing.Point(0, 0);
            // 
            // GridLibros
            // 
            this.GridLibros.MasterTemplate.AutoGenerateColumns = false;
            this.GridLibros.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 136;
            gridViewTextBoxColumn2.FieldName = "Cod";
            gridViewTextBoxColumn2.HeaderText = "Código";
            gridViewTextBoxColumn2.Name = "Codigo";
            gridViewTextBoxColumn2.Width = 142;
            gridViewTextBoxColumn3.FieldName = "NombreTitulo";
            gridViewTextBoxColumn3.HeaderText = "Título";
            gridViewTextBoxColumn3.Name = "NombreTitulo";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 247;
            gridViewTextBoxColumn4.FieldName = "AutorNombre";
            gridViewTextBoxColumn4.HeaderText = "Autor";
            gridViewTextBoxColumn4.Name = "AutorNombre";
            gridViewTextBoxColumn4.Width = 140;
            gridViewTextBoxColumn5.FieldName = "EditorialNombre";
            gridViewTextBoxColumn5.HeaderText = "Editorial";
            gridViewTextBoxColumn5.Name = "EditorialNombre";
            gridViewTextBoxColumn5.Width = 124;
            gridViewTextBoxColumn6.FieldName = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.FormatString = "{0:c2}";
            gridViewTextBoxColumn6.HeaderText = "Precio";
            gridViewTextBoxColumn6.Name = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 117;
            gridViewTextBoxColumn7.FieldName = "FechaModificacion";
            gridViewTextBoxColumn7.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn7.HeaderText = "Modificación";
            gridViewTextBoxColumn7.Name = "FechaModificacion";
            gridViewTextBoxColumn7.Width = 26;
            gridViewTextBoxColumn8.FieldName = "UsuarioUltimoPrecio";
            gridViewTextBoxColumn8.HeaderText = "Operador";
            gridViewTextBoxColumn8.Name = "UsuarioUltimoPrecio";
            gridViewTextBoxColumn8.Width = 113;
            gridViewTextBoxColumn9.FieldName = "TituloStockStkPr";
            gridViewTextBoxColumn9.HeaderText = "St. Pr.";
            gridViewTextBoxColumn9.Name = "StockPropio";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.Width = 67;
            gridViewTextBoxColumn10.FieldName = "TituloStockStkCn";
            gridViewTextBoxColumn10.HeaderText = "St. Cn.";
            gridViewTextBoxColumn10.Name = "StockConsignado";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.Width = 67;
            gridViewTextBoxColumn11.FieldName = "TituloStockStkPrViejo";
            gridViewTextBoxColumn11.HeaderText = "PR 8";
            gridViewTextBoxColumn11.Name = "StockPropioViejo";
            gridViewTextBoxColumn11.Width = 67;
            gridViewTextBoxColumn12.FieldName = "TituloStockStkCnViejo";
            gridViewTextBoxColumn12.HeaderText = "CN 8";
            gridViewTextBoxColumn12.Name = "StockConsignadoViejo";
            gridViewTextBoxColumn12.Width = 113;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaDetalle";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "ColumnaEditar";
            gridViewCommandColumn2.Width = 30;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.HeaderTextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.Width = 30;
            gridViewCommandColumn4.HeaderText = "";
            gridViewCommandColumn4.Image = global::LaPaz.Win.Properties.Resources.Data_Files;
            gridViewCommandColumn4.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn4.MaxWidth = 30;
            gridViewCommandColumn4.MinWidth = 30;
            gridViewCommandColumn4.Name = "ColumnaStock";
            gridViewCommandColumn4.Width = 30;
            gridViewCommandColumn5.HeaderText = "";
            gridViewCommandColumn5.Image = global::LaPaz.Win.Properties.Resources.reporte;
            gridViewCommandColumn5.MaxWidth = 30;
            gridViewCommandColumn5.MinWidth = 30;
            gridViewCommandColumn5.Name = "ColumnaReporte";
            gridViewCommandColumn5.Width = 30;
            this.GridLibros.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewTextBoxColumn12,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3,
            gridViewCommandColumn4,
            gridViewCommandColumn5});
            this.GridLibros.MasterTemplate.EnableGrouping = false;
            this.GridLibros.Name = "GridLibros";
            this.GridLibros.ReadOnly = true;
            this.GridLibros.Size = new System.Drawing.Size(1380, 666);
            this.GridLibros.TabIndex = 12;
            this.GridLibros.ThemeName = "TelerikMetroBlue";
            this.GridLibros.RowFormatting += new Telerik.WinControls.UI.RowFormattingEventHandler(this.GridLibros_RowFormatting);
            this.GridLibros.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridLibros_CommandCellClick);
            this.GridLibros.ContextMenuOpening += new Telerik.WinControls.UI.ContextMenuOpeningEventHandler(this.GridLibros_ContextMenuOpening);
            // 
            // FrmLibrosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 920);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmLibrosListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FrmLibrosListado_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLibrosListado_KeyDown);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearProveedor)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridLibros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn NombreTitulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn ISBN;
        private Telerik.WinControls.UI.GridViewTextBoxColumn ProveedorDenominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TemaNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PrecioVentaTitulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PrecioCompraTitulo;
        private Telerik.WinControls.UI.GridViewTextBoxColumn StockPropio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn StockConsignado;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Framework.WinForm.Controls.MetroPager TitulosPager;
        private UcFiltrosLibros UcFiltrosLibros;
        private Telerik.WinControls.UI.RadGridView GridLibros;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearProveedor;
        private Util.UcProgressSpinner UcProgressSpinner;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private UcEstadoTitulos ucEstadoTitulos1;
    }
}