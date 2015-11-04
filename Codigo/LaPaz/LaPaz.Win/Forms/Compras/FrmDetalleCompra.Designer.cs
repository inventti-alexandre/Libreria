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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn13 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn14 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn15 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn16 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn17 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
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
            this.ucProgressSpinner.Location = new System.Drawing.Point(245, 3);
            this.ucProgressSpinner.Name = "ucProgressSpinner";
            this.ucProgressSpinner.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner.TabIndex = 2;
            // 
            // ListadoPager
            // 
            this.ListadoPager.CurrentPage = 1;
            this.ListadoPager.Location = new System.Drawing.Point(405, 0);
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
            this.Tabs.SelectedPage = this.pageCompraDetalle;
            this.Tabs.Size = new System.Drawing.Size(804, 445);
            this.Tabs.TabIndex = 0;
            this.Tabs.Text = "Detalle";
            this.Tabs.ThemeName = "TelerikMetroBlue";
            this.Tabs.SelectedPageChanged += new System.EventHandler(this.radPageView1_SelectedPageChanged);
            // 
            // pageCompraDetalle
            // 
            this.pageCompraDetalle.Controls.Add(this.ucProgressSpinner);
            this.pageCompraDetalle.Controls.Add(this.GridCompraDetalle);
            this.pageCompraDetalle.Controls.Add(this.ListadoPager);
            this.pageCompraDetalle.Location = new System.Drawing.Point(5, 31);
            this.pageCompraDetalle.Name = "pageCompraDetalle";
            this.pageCompraDetalle.Size = new System.Drawing.Size(794, 409);
            this.pageCompraDetalle.Text = "Detalle";
            // 
            // GridCompraDetalle
            // 
            this.GridCompraDetalle.AllowDrop = true;
            this.GridCompraDetalle.Location = new System.Drawing.Point(0, 51);
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
            gridViewTextBoxColumn1.Expression = "";
            gridViewTextBoxColumn1.FieldName = "TituloNombreTitulo";
            gridViewTextBoxColumn1.HeaderText = "Titulo";
            gridViewTextBoxColumn1.Name = "Titulo";
            gridViewTextBoxColumn1.Width = 316;
            gridViewTextBoxColumn2.FieldName = "CntPr";
            gridViewTextBoxColumn2.HeaderText = "Propia";
            gridViewTextBoxColumn2.Name = "Propia";
            gridViewTextBoxColumn2.Width = 108;
            gridViewTextBoxColumn3.FieldName = "CntCn";
            gridViewTextBoxColumn3.HeaderText = "Consignada";
            gridViewTextBoxColumn3.Name = "Consignada";
            gridViewTextBoxColumn3.Width = 108;
            gridViewTextBoxColumn4.FieldName = "PrecioCompra";
            gridViewTextBoxColumn4.HeaderText = "PrecioCompra";
            gridViewTextBoxColumn4.Name = "PrecioCompra";
            gridViewTextBoxColumn4.Width = 108;
            gridViewTextBoxColumn5.FieldName = "PrecioVenta";
            gridViewTextBoxColumn5.HeaderText = "PrecioVenta";
            gridViewTextBoxColumn5.Name = "PrecioVenta";
            gridViewTextBoxColumn5.Width = 133;
            this.GridCompraDetalle.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5});
            this.GridCompraDetalle.Name = "GridCompraDetalle";
            this.GridCompraDetalle.ReadOnly = true;
            this.GridCompraDetalle.Size = new System.Drawing.Size(791, 355);
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
            gridViewTextBoxColumn6.FieldName = "Cuota";
            gridViewTextBoxColumn6.HeaderText = "Cuota";
            gridViewTextBoxColumn6.Name = "Cuota";
            gridViewTextBoxColumn6.Width = 178;
            gridViewTextBoxColumn7.Expression = "";
            gridViewTextBoxColumn7.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn7.HeaderText = "Vencimiento";
            gridViewTextBoxColumn7.Name = "FechaVencimiento";
            gridViewTextBoxColumn7.Width = 178;
            gridViewTextBoxColumn8.FieldName = "Importe";
            gridViewTextBoxColumn8.HeaderText = "Importe";
            gridViewTextBoxColumn8.Name = "Importe";
            gridViewTextBoxColumn8.Width = 178;
            gridViewTextBoxColumn9.FieldName = "Pagado";
            gridViewTextBoxColumn9.HeaderText = "Pagado";
            gridViewTextBoxColumn9.Name = "Pagado";
            gridViewTextBoxColumn9.Width = 176;
            this.GridCuotas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9});
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
            // 
            // 
            this.GrillaPagos.MasterTemplate.AllowAddNewRow = false;
            this.GrillaPagos.MasterTemplate.AllowColumnReorder = false;
            this.GrillaPagos.MasterTemplate.AllowDeleteRow = false;
            this.GrillaPagos.MasterTemplate.AllowDragToGroup = false;
            this.GrillaPagos.MasterTemplate.AllowEditRow = false;
            this.GrillaPagos.MasterTemplate.AllowRowResize = false;
            this.GrillaPagos.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn10.FieldName = "ImpFac";
            gridViewTextBoxColumn10.HeaderText = "Imp. Factura";
            gridViewTextBoxColumn10.Name = "ImpFac";
            gridViewTextBoxColumn10.Width = 97;
            gridViewTextBoxColumn11.FieldName = "Importe";
            gridViewTextBoxColumn11.HeaderText = "Importe";
            gridViewTextBoxColumn11.Name = "Importe";
            gridViewTextBoxColumn11.Width = 78;
            gridViewTextBoxColumn12.FieldName = "Efectivo";
            gridViewTextBoxColumn12.HeaderText = "Efectivo";
            gridViewTextBoxColumn12.Name = "Efectivo";
            gridViewTextBoxColumn12.Width = 78;
            gridViewTextBoxColumn13.FieldName = "Tarjeta";
            gridViewTextBoxColumn13.HeaderText = "Tarjeta";
            gridViewTextBoxColumn13.Name = "Tarjeta";
            gridViewTextBoxColumn13.Width = 78;
            gridViewTextBoxColumn14.FieldName = "Deposito";
            gridViewTextBoxColumn14.HeaderText = "Deposito";
            gridViewTextBoxColumn14.Name = "Deposito";
            gridViewTextBoxColumn14.Width = 78;
            gridViewTextBoxColumn15.FieldName = "Cheque";
            gridViewTextBoxColumn15.HeaderText = "Cheque";
            gridViewTextBoxColumn15.Name = "Cheque";
            gridViewTextBoxColumn15.Width = 79;
            gridViewTextBoxColumn16.FieldName = "Transferencia";
            gridViewTextBoxColumn16.HeaderText = "Transferencia";
            gridViewTextBoxColumn16.Name = "Transferencia";
            gridViewTextBoxColumn16.Width = 78;
            gridViewTextBoxColumn17.FieldName = "TipoMovimientoCajaId";
            gridViewTextBoxColumn17.HeaderText = "TipoMovimiento";
            gridViewTextBoxColumn17.Name = "TipoMovimiento";
            gridViewTextBoxColumn17.Width = 213;
            this.GrillaPagos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12,
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewTextBoxColumn15,
            gridViewTextBoxColumn16,
            gridViewTextBoxColumn17});
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