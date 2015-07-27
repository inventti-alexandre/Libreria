namespace LaPaz.Win.Forms.OrdenesPagos
{
    partial class FrmPagosProgramadosListado
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
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor1 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucFiltrosPagoProgramados = new LaPaz.Win.Forms.OrdenesPagos.UcFiltrosPagoProgramados();
            this.PagosPager = new Framework.WinForm.Controls.MetroPager();
            this.ucProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridPagos = new Telerik.WinControls.UI.RadGridView();
            this.ordenesPagoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesPagoDtoBindingSource)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.ucFiltrosPagoProgramados);
            this.splitContainer1.Panel1.Controls.Add(this.PagosPager);
            this.splitContainer1.Panel1.Controls.Add(this.ucProgressSpinner);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridPagos);
            this.splitContainer1.Size = new System.Drawing.Size(1367, 780);
            this.splitContainer1.SplitterDistance = 135;
            this.splitContainer1.TabIndex = 0;
            // 
            // ucFiltrosPagoProgramados
            // 
            this.ucFiltrosPagoProgramados.Location = new System.Drawing.Point(0, 0);
            this.ucFiltrosPagoProgramados.Name = "ucFiltrosPagoProgramados";
            this.ucFiltrosPagoProgramados.Size = new System.Drawing.Size(628, 132);
            this.ucFiltrosPagoProgramados.TabIndex = 15;
            // 
            // PagosPager
            // 
            this.PagosPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PagosPager.CurrentPage = 1;
            this.PagosPager.Location = new System.Drawing.Point(983, 93);
            this.PagosPager.Margin = new System.Windows.Forms.Padding(94, 3, 3, 3);
            this.PagosPager.Name = "PagosPager";
            this.PagosPager.PageSize = 50;
            this.PagosPager.PageTotal = 1;
            this.PagosPager.RefreshAction = null;
            this.PagosPager.RefreshActionAsync = null;
            this.PagosPager.Size = new System.Drawing.Size(381, 39);
            this.PagosPager.TabIndex = 12;
            // 
            // ucProgressSpinner
            // 
            this.ucProgressSpinner.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner.Location = new System.Drawing.Point(1180, 14);
            this.ucProgressSpinner.Name = "ucProgressSpinner";
            this.ucProgressSpinner.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner.TabIndex = 14;
            // 
            // GridPagos
            // 
            this.GridPagos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPagos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridPagos.Location = new System.Drawing.Point(0, 0);
            // 
            // GridPagos
            // 
            this.GridPagos.MasterTemplate.AllowAddNewRow = false;
            this.GridPagos.MasterTemplate.AllowColumnChooser = false;
            this.GridPagos.MasterTemplate.AllowColumnReorder = false;
            this.GridPagos.MasterTemplate.AllowDeleteRow = false;
            this.GridPagos.MasterTemplate.AllowDragToGroup = false;
            this.GridPagos.MasterTemplate.AutoGenerateColumns = false;
            this.GridPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(System.Guid);
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 10;
            gridViewTextBoxColumn2.FieldName = "OrdenPagoId";
            gridViewTextBoxColumn2.HeaderText = "OrdenPagoId";
            gridViewTextBoxColumn2.IsVisible = false;
            gridViewTextBoxColumn2.Name = "OrdenPagoId";
            gridViewTextBoxColumn2.Width = 49;
            gridViewTextBoxColumn3.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn3.FieldName = "FechaPago";
            gridViewTextBoxColumn3.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn3.HeaderText = "Fecha Pago";
            gridViewTextBoxColumn3.Name = "FechaPago";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 97;
            gridViewTextBoxColumn4.FieldName = "FechaAnulacion";
            gridViewTextBoxColumn4.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn4.HeaderText = "Fecha Anulación";
            gridViewTextBoxColumn4.Name = "FechaAnulacion";
            gridViewTextBoxColumn4.Width = 124;
            gridViewTextBoxColumn5.FieldName = "OrdenesPagoConcepto";
            gridViewTextBoxColumn5.HeaderText = "Orden Concepto";
            gridViewTextBoxColumn5.Name = "OrdenesPagoConcepto";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 323;
            gridViewTextBoxColumn6.FieldName = "NumeroLinea";
            filterDescriptor1.IsFilterEditor = true;
            filterDescriptor1.PropertyName = "NumeroLinea";
            gridViewTextBoxColumn6.FilterDescriptor = filterDescriptor1;
            gridViewTextBoxColumn6.HeaderText = "Nro. Linea";
            gridViewTextBoxColumn6.Name = "NumeroLinea";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 88;
            gridViewTextBoxColumn7.DataType = typeof(System.Nullable<decimal>);
            gridViewTextBoxColumn7.FieldName = "ImportePagado";
            gridViewTextBoxColumn7.FormatString = "{0:c2}";
            gridViewTextBoxColumn7.HeaderText = "Importe Pagado";
            gridViewTextBoxColumn7.Name = "ImportePagado";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Width = 128;
            gridViewTextBoxColumn8.DataType = typeof(decimal);
            gridViewTextBoxColumn8.FieldName = "Descuento";
            gridViewTextBoxColumn8.FormatString = "{0:c2}";
            gridViewTextBoxColumn8.HeaderText = "Descuento";
            gridViewTextBoxColumn8.Name = "Descuento";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn8.Width = 97;
            gridViewTextBoxColumn9.DataType = typeof(System.Nullable<decimal>);
            gridViewTextBoxColumn9.FieldName = "Efectivo";
            gridViewTextBoxColumn9.FormatString = "{0:c2}";
            gridViewTextBoxColumn9.HeaderText = "Efectivo";
            gridViewTextBoxColumn9.Name = "Efectivo";
            gridViewTextBoxColumn9.ReadOnly = true;
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Width = 139;
            gridViewTextBoxColumn10.DataType = typeof(decimal);
            gridViewTextBoxColumn10.FieldName = "Cheques";
            gridViewTextBoxColumn10.FormatString = "{0:c2}";
            gridViewTextBoxColumn10.HeaderText = "Cheques";
            gridViewTextBoxColumn10.Name = "Cheques";
            gridViewTextBoxColumn10.ReadOnly = true;
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn10.Width = 133;
            gridViewTextBoxColumn11.FieldName = "Deposito";
            gridViewTextBoxColumn11.FormatString = "{0:c2}";
            gridViewTextBoxColumn11.HeaderText = "Depósito";
            gridViewTextBoxColumn11.Name = "Deposito";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn11.Width = 103;
            gridViewTextBoxColumn12.FieldName = "DepositoEfectivo";
            gridViewTextBoxColumn12.FormatString = "{0:c2}";
            gridViewTextBoxColumn12.HeaderText = "Dep. Etvo.";
            gridViewTextBoxColumn12.Name = "DepositoEfectivo";
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn12.Width = 64;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Pagar;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaPagar";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "ColumnaEliminar";
            gridViewCommandColumn2.Width = 30;
            this.GridPagos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewCommandColumn2});
            this.GridPagos.MasterTemplate.EnableGrouping = false;
            this.GridPagos.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1});
            this.GridPagos.Name = "GridPagos";
            this.GridPagos.ReadOnly = true;
            this.GridPagos.Size = new System.Drawing.Size(1367, 641);
            this.GridPagos.TabIndex = 13;
            this.GridPagos.ThemeName = "TelerikMetroBlue";
            this.GridPagos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridPagos_CommandCellClick);
            // 
            // ordenesPagoDtoBindingSource
            // 
            this.ordenesPagoDtoBindingSource.DataSource = typeof(LaPaz.Entidades.Dto.OrdenesPagoDto);
            // 
            // FrmPagosProgramadosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1367, 780);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPagosProgramadosListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Pagos Programados";
            this.Load += new System.EventHandler(this.FrmPagosProgramadosListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPagos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesPagoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private Telerik.WinControls.UI.RadGridView GridOrdenesPagos;
        private System.Windows.Forms.BindingSource ordenesPagoDtoBindingSource;
        private Telerik.WinControls.UI.RadGridView GridPagos;
        private Framework.WinForm.Controls.MetroPager PagosPager;
        private Util.UcProgressSpinner ucProgressSpinner;
        private UcFiltrosPagoProgramados ucFiltrosPagoProgramados;
    }
}