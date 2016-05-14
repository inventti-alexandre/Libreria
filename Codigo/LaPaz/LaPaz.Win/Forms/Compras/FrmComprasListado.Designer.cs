namespace LaPaz.Win.Forms.Compras
{
    partial class FrmComprasListado
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ucFiltrosCompras = new LaPaz.Win.Forms.Compras.UcFiltrosCompras();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.pnlCompras = new Telerik.WinControls.UI.RadPanel();
            this.TxtCompras = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCantidad = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ComprasPager = new Framework.WinForm.Controls.MetroPager();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridCompras = new Telerik.WinControls.UI.RadGridView();
            this.MovimientosProveedores = new Telerik.WinControls.UI.RadGridView();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlCompras)).BeginInit();
            this.pnlCompras.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosProveedores.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucFiltrosCompras
            // 
            this.ucFiltrosCompras.FechaHasta = new System.DateTime(2015, 2, 4, 17, 33, 8, 710);
            this.ucFiltrosCompras.FechaInicio = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.ucFiltrosCompras.Location = new System.Drawing.Point(10, 6);
            this.ucFiltrosCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucFiltrosCompras.Name = "ucFiltrosCompras";
            this.ucFiltrosCompras.NroComprobante = "";
            this.ucFiltrosCompras.ProveedorId = null;
            this.ucFiltrosCompras.Size = new System.Drawing.Size(1045, 88);
            this.ucFiltrosCompras.TabIndex = 0;
            this.ucFiltrosCompras.TipoId = null;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucFiltrosCompras);
            this.radPanel1.Location = new System.Drawing.Point(12, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1071, 100);
            this.radPanel1.TabIndex = 1;
            // 
            // pnlCompras
            // 
            this.pnlCompras.Controls.Add(this.TxtCompras);
            this.pnlCompras.Controls.Add(this.TxtCantidad);
            this.pnlCompras.Controls.Add(this.radLabel1);
            this.pnlCompras.Controls.Add(this.metroLabel4);
            this.pnlCompras.Controls.Add(this.ComprasPager);
            this.pnlCompras.Controls.Add(this.ucProgressSpinner1);
            this.pnlCompras.Controls.Add(this.GridCompras);
            this.pnlCompras.Location = new System.Drawing.Point(12, 118);
            this.pnlCompras.Name = "pnlCompras";
            this.pnlCompras.Size = new System.Drawing.Size(1071, 426);
            this.pnlCompras.TabIndex = 2;
            // 
            // TxtCompras
            // 
            this.TxtCompras.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCompras.Location = new System.Drawing.Point(210, 56);
            this.TxtCompras.MaxLength = 11;
            this.TxtCompras.Name = "TxtCompras";
            this.TxtCompras.Size = new System.Drawing.Size(127, 31);
            this.TxtCompras.TabIndex = 46;
            this.TxtCompras.TabStop = false;
            this.TxtCompras.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCantidad
            // 
            this.TxtCantidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCantidad.Location = new System.Drawing.Point(210, 19);
            this.TxtCantidad.MaxLength = 11;
            this.TxtCantidad.Name = "TxtCantidad";
            this.TxtCantidad.Size = new System.Drawing.Size(127, 31);
            this.TxtCantidad.TabIndex = 45;
            this.TxtCantidad.TabStop = false;
            this.TxtCantidad.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(44, 58);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(160, 29);
            this.radLabel1.TabIndex = 42;
            this.radLabel1.Text = "Total de compras:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(10, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(194, 29);
            this.metroLabel4.TabIndex = 41;
            this.metroLabel4.Text = "Cantidad de compras:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // ComprasPager
            // 
            this.ComprasPager.CurrentPage = 1;
            this.ComprasPager.Location = new System.Drawing.Point(518, 33);
            this.ComprasPager.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ComprasPager.Name = "ComprasPager";
            this.ComprasPager.PageSize = 50;
            this.ComprasPager.PageTotal = 1;
            this.ComprasPager.RefreshAction = null;
            this.ComprasPager.RefreshActionAsync = null;
            this.ComprasPager.Size = new System.Drawing.Size(511, 54);
            this.ComprasPager.TabIndex = 2;
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Location = new System.Drawing.Point(865, 7);
            this.ucProgressSpinner1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 1;
            // 
            // GridCompras
            // 
            this.GridCompras.AllowDrop = true;
            this.GridCompras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridCompras.AutoScroll = true;
            this.GridCompras.Location = new System.Drawing.Point(10, 109);
            // 
            // GridCompras
            // 
            this.GridCompras.MasterTemplate.AllowAddNewRow = false;
            this.GridCompras.MasterTemplate.AllowColumnReorder = false;
            this.GridCompras.MasterTemplate.AllowDeleteRow = false;
            this.GridCompras.MasterTemplate.AllowDragToGroup = false;
            this.GridCompras.MasterTemplate.AllowEditRow = false;
            this.GridCompras.MasterTemplate.AllowRowResize = false;
            this.GridCompras.MasterTemplate.AutoGenerateColumns = false;
            this.GridCompras.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProveedorDenominacion";
            gridViewTextBoxColumn1.HeaderText = "Proveedor";
            gridViewTextBoxColumn1.Name = "Proveedor";
            gridViewTextBoxColumn1.Width = 303;
            gridViewTextBoxColumn2.FieldName = "TipoComprobanteId";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Tipo";
            gridViewTextBoxColumn2.Name = "TipoComprobanteId";
            gridViewTextBoxColumn2.Width = 195;
            gridViewTextBoxColumn3.FieldName = "Observaciones";
            gridViewTextBoxColumn3.HeaderText = "Observaciones";
            gridViewTextBoxColumn3.Name = "Observaciones";
            gridViewTextBoxColumn3.Width = 252;
            gridViewTextBoxColumn4.FieldName = "FechaAlta";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Fecha";
            gridViewTextBoxColumn4.Name = "FechaAlta";
            gridViewTextBoxColumn4.Width = 133;
            gridViewTextBoxColumn5.FieldName = "LCN";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "LCN";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.Name = "LCN";
            gridViewTextBoxColumn5.Width = 116;
            gridViewTextBoxColumn6.FieldName = "ImporteNeto";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Importe";
            gridViewTextBoxColumn6.Name = "ImporteNeto";
            gridViewTextBoxColumn6.Width = 114;
            gridViewTextBoxColumn7.FieldName = "FechaVencimiento";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Vencimiento";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "FechaVencimiento";
            gridViewTextBoxColumn7.Width = 328;
            gridViewCommandColumn1.FormatString = "";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Detalle";
            gridViewCommandColumn1.Width = 30;
            this.GridCompras.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCommandColumn1});
            this.GridCompras.Name = "GridCompras";
            this.GridCompras.ReadOnly = true;
            this.GridCompras.Size = new System.Drawing.Size(1044, 298);
            this.GridCompras.TabIndex = 0;
            this.GridCompras.ThemeName = "TelerikMetroBlue";
            this.GridCompras.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridCompras_CommandCellClick);
            this.GridCompras.DoubleClick += new System.EventHandler(this.GridCompras_DoubleClick);
            // 
            // MovimientosProveedores
            // 
            this.MovimientosProveedores.Location = new System.Drawing.Point(10, 12);
            // 
            // MovimientosProveedores
            // 
            this.MovimientosProveedores.MasterTemplate.AllowAddNewRow = false;
            this.MovimientosProveedores.MasterTemplate.AllowColumnReorder = false;
            this.MovimientosProveedores.MasterTemplate.AllowDragToGroup = false;
            this.MovimientosProveedores.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn8.FieldName = "Fecha";
            gridViewTextBoxColumn8.FormatString = "";
            gridViewTextBoxColumn8.HeaderText = "Fecha";
            gridViewTextBoxColumn8.Name = "Fecha";
            gridViewTextBoxColumn8.Width = 368;
            gridViewTextBoxColumn9.FieldName = "Concepto";
            gridViewTextBoxColumn9.FormatString = "";
            gridViewTextBoxColumn9.HeaderText = "Concepto";
            gridViewTextBoxColumn9.Name = "Concepto";
            gridViewTextBoxColumn9.Width = 368;
            gridViewTextBoxColumn10.FieldName = "Importe";
            gridViewTextBoxColumn10.FormatString = "";
            gridViewTextBoxColumn10.HeaderText = "Importe";
            gridViewTextBoxColumn10.Name = "Importe";
            gridViewTextBoxColumn10.Width = 147;
            gridViewTextBoxColumn11.FieldName = "Pagos";
            gridViewTextBoxColumn11.FormatString = "";
            gridViewTextBoxColumn11.HeaderText = "Pagos";
            gridViewTextBoxColumn11.Name = "Pagos";
            gridViewTextBoxColumn11.Width = 143;
            this.MovimientosProveedores.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.MovimientosProveedores.Name = "MovimientosProveedores";
            this.MovimientosProveedores.ReadOnly = true;
            this.MovimientosProveedores.Size = new System.Drawing.Size(1045, 284);
            this.MovimientosProveedores.TabIndex = 48;
            this.MovimientosProveedores.Text = "radGridView1";
            this.MovimientosProveedores.ThemeName = "TelerikMetroBlue";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.MovimientosProveedores);
            this.radPanel2.Location = new System.Drawing.Point(12, 550);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1071, 307);
            this.radPanel2.TabIndex = 49;
            // 
            // FrmComprasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1563, 1065);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.pnlCompras);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmComprasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Listado de Compras";
            this.Load += new System.EventHandler(this.FrmListadoCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlCompras)).EndInit();
            this.pnlCompras.ResumeLayout(false);
            this.pnlCompras.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridCompras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosProveedores.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MovimientosProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcFiltrosCompras ucFiltrosCompras;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel pnlCompras;
        private Telerik.WinControls.UI.RadGridView GridCompras;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private Framework.WinForm.Controls.MetroPager ComprasPager;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadTextBox TxtCompras;
        private Telerik.WinControls.UI.RadTextBox TxtCantidad;
        private Telerik.WinControls.UI.RadGridView MovimientosProveedores;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}