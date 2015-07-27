namespace LaPaz.Win.Forms.Compras
{
    partial class FrmDetalleCompra
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn18 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn19 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn20 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn21 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn22 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn23 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn24 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn25 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn26 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn27 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn28 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn29 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn30 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn31 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn32 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn33 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn34 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ucProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.ListadoPager = new Framework.WinForm.Controls.MetroPager();
            this.Tabs = new Telerik.WinControls.UI.RadPageView();
            this.pageCompraDetalle = new Telerik.WinControls.UI.RadPageViewPage();
            this.GridCompraDetalle = new Telerik.WinControls.UI.RadGridView();
            this.pageCuotas = new Telerik.WinControls.UI.RadPageViewPage();
            this.GridCuotas = new Telerik.WinControls.UI.RadGridView();
            this.PagePagos = new Telerik.WinControls.UI.RadPageViewPage();
            this.GrillaPagos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).BeginInit();
            this.Tabs.SuspendLayout();
            this.pageCompraDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle.MasterTemplate)).BeginInit();
            this.pageCuotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).BeginInit();
            this.PagePagos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucProgressSpinner
            // 
            this.ucProgressSpinner.Location = new System.Drawing.Point(270, 48);
            this.ucProgressSpinner.Name = "ucProgressSpinner";
            this.ucProgressSpinner.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner.TabIndex = 2;
            // 
            // ListadoPager
            // 
            this.ListadoPager.CurrentPage = 1;
            this.ListadoPager.Location = new System.Drawing.Point(430, 33);
            this.ListadoPager.Name = "ListadoPager";
            this.ListadoPager.PageSize = 50;
            this.ListadoPager.PageTotal = 1;
            this.ListadoPager.RefreshAction = null;
            this.ListadoPager.RefreshActionAsync = null;
            this.ListadoPager.Size = new System.Drawing.Size(386, 42);
            this.ListadoPager.TabIndex = 1;
            // 
            // Tabs
            // 
            this.Tabs.Controls.Add(this.pageCompraDetalle);
            this.Tabs.Controls.Add(this.pageCuotas);
            this.Tabs.Controls.Add(this.PagePagos);
            this.Tabs.Location = new System.Drawing.Point(12, 81);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedPage = this.PagePagos;
            this.Tabs.Size = new System.Drawing.Size(804, 342);
            this.Tabs.TabIndex = 0;
            this.Tabs.Text = "Detalle";
            this.Tabs.ThemeName = "TelerikMetroBlue";
            this.Tabs.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            // 
            // pageCompraDetalle
            // 
            this.pageCompraDetalle.Controls.Add(this.GridCompraDetalle);
            this.pageCompraDetalle.Location = new System.Drawing.Point(5, 31);
            this.pageCompraDetalle.Name = "pageCompraDetalle";
            this.pageCompraDetalle.Size = new System.Drawing.Size(794, 306);
            this.pageCompraDetalle.Text = "Detalle";
            // 
            // GridCompraDetalle
            // 
            this.GridCompraDetalle.AllowDrop = true;
            this.GridCompraDetalle.Location = new System.Drawing.Point(0, 16);
            // 
            // GridCompraDetalle
            // 
            this.GridCompraDetalle.MasterTemplate.AllowAddNewRow = false;
            this.GridCompraDetalle.MasterTemplate.AllowColumnReorder = false;
            this.GridCompraDetalle.MasterTemplate.AllowDeleteRow = false;
            this.GridCompraDetalle.MasterTemplate.AllowDragToGroup = false;
            this.GridCompraDetalle.MasterTemplate.AllowEditRow = false;
            this.GridCompraDetalle.MasterTemplate.AllowRowResize = false;
            this.GridCompraDetalle.MasterTemplate.AutoGenerateColumns = false;
            this.GridCompraDetalle.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn18.Expression = "";
            gridViewTextBoxColumn18.FieldName = "TituloNombreTitulo";
            gridViewTextBoxColumn18.HeaderText = "Titulo";
            gridViewTextBoxColumn18.Name = "Titulo";
            gridViewTextBoxColumn18.Width = 291;
            gridViewTextBoxColumn19.FieldName = "CntPr";
            gridViewTextBoxColumn19.HeaderText = "Propia";
            gridViewTextBoxColumn19.Name = "Propia";
            gridViewTextBoxColumn19.Width = 99;
            gridViewTextBoxColumn20.FieldName = "CntCn";
            gridViewTextBoxColumn20.HeaderText = "Consignada";
            gridViewTextBoxColumn20.Name = "Consignada";
            gridViewTextBoxColumn20.Width = 99;
            gridViewTextBoxColumn21.FieldName = "PrecioCompra";
            gridViewTextBoxColumn21.HeaderText = "PrecioCompra";
            gridViewTextBoxColumn21.Name = "PrecioCompra";
            gridViewTextBoxColumn21.Width = 99;
            gridViewTextBoxColumn22.FieldName = "PrecioVenta";
            gridViewTextBoxColumn22.HeaderText = "PrecioVenta";
            gridViewTextBoxColumn22.Name = "PrecioVenta";
            gridViewTextBoxColumn22.Width = 123;
            this.GridCompraDetalle.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn18,
            gridViewTextBoxColumn19,
            gridViewTextBoxColumn20,
            gridViewTextBoxColumn21,
            gridViewTextBoxColumn22});
            this.GridCompraDetalle.Name = "GridCompraDetalle";
            this.GridCompraDetalle.ReadOnly = true;
            this.GridCompraDetalle.Size = new System.Drawing.Size(729, 287);
            this.GridCompraDetalle.TabIndex = 0;
            this.GridCompraDetalle.Text = "radGridView1";
            this.GridCompraDetalle.ThemeName = "TelerikMetroBlue";
            // 
            // pageCuotas
            // 
            this.pageCuotas.Controls.Add(this.GridCuotas);
            this.pageCuotas.Location = new System.Drawing.Point(5, 31);
            this.pageCuotas.Name = "pageCuotas";
            this.pageCuotas.Size = new System.Drawing.Size(794, 306);
            this.pageCuotas.Text = "Cuotas";
            // 
            // GridCuotas
            // 
            this.GridCuotas.Location = new System.Drawing.Point(3, 17);
            // 
            // 
            // 
            this.GridCuotas.MasterTemplate.AllowAddNewRow = false;
            this.GridCuotas.MasterTemplate.AllowColumnReorder = false;
            this.GridCuotas.MasterTemplate.AllowDragToGroup = false;
            this.GridCuotas.MasterTemplate.AllowEditRow = false;
            this.GridCuotas.MasterTemplate.AllowRowResize = false;
            this.GridCuotas.MasterTemplate.AutoGenerateColumns = false;
            this.GridCuotas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn23.FieldName = "Cuota";
            gridViewTextBoxColumn23.HeaderText = "Cuota";
            gridViewTextBoxColumn23.Name = "Cuota";
            gridViewTextBoxColumn23.Width = 178;
            gridViewTextBoxColumn24.Expression = "";
            gridViewTextBoxColumn24.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn24.HeaderText = "Vencimiento";
            gridViewTextBoxColumn24.Name = "FechaVencimiento";
            gridViewTextBoxColumn24.Width = 178;
            gridViewTextBoxColumn25.FieldName = "Importe";
            gridViewTextBoxColumn25.HeaderText = "Importe";
            gridViewTextBoxColumn25.Name = "Importe";
            gridViewTextBoxColumn25.Width = 178;
            gridViewTextBoxColumn26.FieldName = "Pagado";
            gridViewTextBoxColumn26.HeaderText = "Pagado";
            gridViewTextBoxColumn26.Name = "Pagado";
            gridViewTextBoxColumn26.Width = 176;
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn23,
            gridViewTextBoxColumn24,
            gridViewTextBoxColumn25,
            gridViewTextBoxColumn26});
            this.GridCuotas.Name = "GridCuotas";
            this.GridCuotas.ReadOnly = true;
            this.GridCuotas.Size = new System.Drawing.Size(729, 287);
            this.GridCuotas.TabIndex = 0;
            this.GridCuotas.ThemeName = "TelerikMetroBlue";
            // 
            // PagePagos
            // 
            this.PagePagos.Controls.Add(this.GrillaPagos);
            this.PagePagos.Location = new System.Drawing.Point(5, 31);
            this.PagePagos.Name = "PagePagos";
            this.PagePagos.Size = new System.Drawing.Size(794, 306);
            this.PagePagos.Text = "Pagos";
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.AllowDrop = true;
            this.GrillaPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrillaPagos.Location = new System.Drawing.Point(0, 0);
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.MasterTemplate.AllowAddNewRow = false;
            this.GrillaPagos.MasterTemplate.AllowColumnReorder = false;
            this.GrillaPagos.MasterTemplate.AllowDeleteRow = false;
            this.GrillaPagos.MasterTemplate.AllowDragToGroup = false;
            this.GrillaPagos.MasterTemplate.AllowEditRow = false;
            this.GrillaPagos.MasterTemplate.AllowRowResize = false;
            this.GrillaPagos.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn27.FieldName = "ImpFac";
            gridViewTextBoxColumn27.HeaderText = "Imp. Factura";
            gridViewTextBoxColumn27.Name = "ImpFac";
            gridViewTextBoxColumn27.Width = 97;
            gridViewTextBoxColumn28.FieldName = "Importe";
            gridViewTextBoxColumn28.HeaderText = "Importe";
            gridViewTextBoxColumn28.Name = "Importe";
            gridViewTextBoxColumn28.Width = 78;
            gridViewTextBoxColumn29.FieldName = "Efectivo";
            gridViewTextBoxColumn29.HeaderText = "Efectivo";
            gridViewTextBoxColumn29.Name = "Efectivo";
            gridViewTextBoxColumn29.Width = 78;
            gridViewTextBoxColumn30.FieldName = "Tarjeta";
            gridViewTextBoxColumn30.HeaderText = "Tarjeta";
            gridViewTextBoxColumn30.Name = "Tarjeta";
            gridViewTextBoxColumn30.Width = 78;
            gridViewTextBoxColumn31.FieldName = "Deposito";
            gridViewTextBoxColumn31.HeaderText = "Deposito";
            gridViewTextBoxColumn31.Name = "Deposito";
            gridViewTextBoxColumn31.Width = 78;
            gridViewTextBoxColumn32.FieldName = "Cheque";
            gridViewTextBoxColumn32.HeaderText = "Cheque";
            gridViewTextBoxColumn32.Name = "Cheque";
            gridViewTextBoxColumn32.Width = 79;
            gridViewTextBoxColumn33.FieldName = "Transferencia";
            gridViewTextBoxColumn33.HeaderText = "Transferencia";
            gridViewTextBoxColumn33.Name = "Transferencia";
            gridViewTextBoxColumn33.Width = 78;
            gridViewTextBoxColumn34.FieldName = "TipoMovimientoCajaId";
            gridViewTextBoxColumn34.HeaderText = "TipoMovimiento";
            gridViewTextBoxColumn34.Name = "TipoMovimiento";
            gridViewTextBoxColumn34.Width = 213;
            this.GrillaPagos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn27,
            gridViewTextBoxColumn28,
            gridViewTextBoxColumn29,
            gridViewTextBoxColumn30,
            gridViewTextBoxColumn31,
            gridViewTextBoxColumn32,
            gridViewTextBoxColumn33,
            gridViewTextBoxColumn34});
            this.GrillaPagos.Name = "GrillaPagos";
            this.GrillaPagos.ReadOnly = true;
            this.GrillaPagos.Size = new System.Drawing.Size(794, 306);
            this.GrillaPagos.TabIndex = 0;
            this.GrillaPagos.ThemeName = "TelerikMetroBlue";
            // 
            // FrmDetalleCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 608);
            this.Controls.Add(this.ucProgressSpinner);
            this.Controls.Add(this.ListadoPager);
            this.Controls.Add(this.Tabs);
            this.Name = "FrmDetalleCompra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Detalle de Compra";
            this.Load += new System.EventHandler(this.FrmDetalleCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tabs)).EndInit();
            this.Tabs.ResumeLayout(false);
            this.pageCompraDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompraDetalle)).EndInit();
            this.pageCuotas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCuotas)).EndInit();
            this.PagePagos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPageView Tabs;
        private Telerik.WinControls.UI.RadPageViewPage pageCompraDetalle;
        private Telerik.WinControls.UI.RadGridView GridCompraDetalle;
        private Framework.WinForm.Controls.MetroPager ListadoPager;
        private Util.UcProgressSpinner ucProgressSpinner;
        private Telerik.WinControls.UI.RadPageViewPage pageCuotas;
        private Telerik.WinControls.UI.RadGridView GridCuotas;
        private Telerik.WinControls.UI.RadPageViewPage PagePagos;
        private Telerik.WinControls.UI.RadGridView GrillaPagos;
    }
}