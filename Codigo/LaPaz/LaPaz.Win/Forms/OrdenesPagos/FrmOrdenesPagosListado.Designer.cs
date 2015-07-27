namespace LaPaz.Win.Forms.OrdenesPagos
{
    partial class FrmOrdenesPagosListado
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
            Telerik.WinControls.Data.FilterDescriptor filterDescriptor1 = new Telerik.WinControls.Data.FilterDescriptor();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.OrdenesPagoPager = new Framework.WinForm.Controls.MetroPager();
            this.UcFiltrosOrdenesPago = new LaPaz.Win.Forms.OrdenesPagos.UcFiltrosOrdenesPago();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnCrearCliente = new Telerik.WinControls.UI.RadButton();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridOrdenesPago = new Telerik.WinControls.UI.RadGridView();
            this.ordenesPagoDtoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrdenesPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrdenesPago.MasterTemplate)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridOrdenesPago);
            this.splitContainer1.Size = new System.Drawing.Size(1335, 788);
            this.splitContainer1.SplitterDistance = 290;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.OrdenesPagoPager, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.UcFiltrosOrdenesPago, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1335, 290);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // OrdenesPagoPager
            // 
            this.OrdenesPagoPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.OrdenesPagoPager.CurrentPage = 1;
            this.OrdenesPagoPager.Location = new System.Drawing.Point(951, 248);
            this.OrdenesPagoPager.Margin = new System.Windows.Forms.Padding(94, 3, 3, 3);
            this.OrdenesPagoPager.Name = "OrdenesPagoPager";
            this.OrdenesPagoPager.PageSize = 50;
            this.OrdenesPagoPager.PageTotal = 1;
            this.OrdenesPagoPager.RefreshAction = null;
            this.OrdenesPagoPager.RefreshActionAsync = null;
            this.OrdenesPagoPager.Size = new System.Drawing.Size(381, 39);
            this.OrdenesPagoPager.TabIndex = 11;
            // 
            // UcFiltrosOrdenesPago
            // 
            this.UcFiltrosOrdenesPago.Concepto = "";
            this.UcFiltrosOrdenesPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosOrdenesPago.Location = new System.Drawing.Point(3, 43);
            this.UcFiltrosOrdenesPago.Name = "UcFiltrosOrdenesPago";
            this.UcFiltrosOrdenesPago.NroComprobante = "";
            this.UcFiltrosOrdenesPago.Size = new System.Drawing.Size(1329, 199);
            this.UcFiltrosOrdenesPago.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.BtnCrearCliente, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.ucProgressSpinner1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1329, 34);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // BtnCrearCliente
            // 
            this.BtnCrearCliente.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.BtnCrearCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrearCliente.Location = new System.Drawing.Point(3, 3);
            this.BtnCrearCliente.Margin = new System.Windows.Forms.Padding(3, 3, 40, 3);
            this.BtnCrearCliente.Name = "BtnCrearCliente";
            this.BtnCrearCliente.Size = new System.Drawing.Size(75, 28);
            this.BtnCrearCliente.TabIndex = 14;
            this.BtnCrearCliente.Text = "Crear";
            this.BtnCrearCliente.ThemeName = "TelerikMetroBlue";
            this.BtnCrearCliente.Click += new System.EventHandler(this.BtnCrearOrdenPago_Click);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ucProgressSpinner1.Location = new System.Drawing.Point(1164, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(162, 27);
            this.ucProgressSpinner1.TabIndex = 0;
            // 
            // GridOrdenesPago
            // 
            this.GridOrdenesPago.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridOrdenesPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridOrdenesPago.Location = new System.Drawing.Point(0, 0);
            // 
            // GridOrdenesPago
            // 
            this.GridOrdenesPago.MasterTemplate.AllowAddNewRow = false;
            this.GridOrdenesPago.MasterTemplate.AllowColumnChooser = false;
            this.GridOrdenesPago.MasterTemplate.AllowColumnReorder = false;
            this.GridOrdenesPago.MasterTemplate.AllowDeleteRow = false;
            this.GridOrdenesPago.MasterTemplate.AllowDragToGroup = false;
            this.GridOrdenesPago.MasterTemplate.AutoGenerateColumns = false;
            this.GridOrdenesPago.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.DataType = typeof(System.Guid);
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 10;
            gridViewTextBoxColumn2.DataType = typeof(System.DateTime);
            gridViewTextBoxColumn2.FieldName = "Fecha";
            gridViewTextBoxColumn2.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn2.HeaderText = "Fecha";
            gridViewTextBoxColumn2.Name = "Fecha";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 91;
            gridViewTextBoxColumn3.FieldName = "LCN";
            gridViewTextBoxColumn3.HeaderText = "LCN";
            gridViewTextBoxColumn3.Name = "LCN";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 131;
            gridViewTextBoxColumn4.FieldName = "NumeroComprobante";
            filterDescriptor1.IsFilterEditor = true;
            filterDescriptor1.PropertyName = "NumeroComprobante";
            gridViewTextBoxColumn4.FilterDescriptor = filterDescriptor1;
            gridViewTextBoxColumn4.HeaderText = "Nro. Comprobante";
            gridViewTextBoxColumn4.Name = "NumeroComprobante";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 144;
            gridViewTextBoxColumn5.FieldName = "ProveedorDenominacion";
            gridViewTextBoxColumn5.HeaderText = "Proveedor";
            gridViewTextBoxColumn5.Name = "ProveedorDenominacion";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 286;
            gridViewTextBoxColumn6.DataType = typeof(decimal);
            gridViewTextBoxColumn6.FieldName = "SubTotal";
            gridViewTextBoxColumn6.FormatString = "{0:c2}";
            gridViewTextBoxColumn6.HeaderText = "Sub Total";
            gridViewTextBoxColumn6.Name = "SubTotal";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 121;
            gridViewTextBoxColumn7.DataType = typeof(System.Nullable<decimal>);
            gridViewTextBoxColumn7.FieldName = "Recargo";
            gridViewTextBoxColumn7.FormatString = "{0:c2}";
            gridViewTextBoxColumn7.HeaderText = "Recargo";
            gridViewTextBoxColumn7.Name = "Recargo";
            gridViewTextBoxColumn7.ReadOnly = true;
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Width = 104;
            gridViewTextBoxColumn8.DataType = typeof(decimal);
            gridViewTextBoxColumn8.FieldName = "Importe";
            gridViewTextBoxColumn8.FormatString = "{0:c2}";
            gridViewTextBoxColumn8.HeaderText = "Importe";
            gridViewTextBoxColumn8.Name = "Importe";
            gridViewTextBoxColumn8.ReadOnly = true;
            gridViewTextBoxColumn8.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn8.Width = 124;
            gridViewTextBoxColumn9.DataType = typeof(System.Nullable<decimal>);
            gridViewTextBoxColumn9.FieldName = "ImportePagado";
            gridViewTextBoxColumn9.FormatString = "{0:c2}";
            gridViewTextBoxColumn9.HeaderText = "Pagado";
            gridViewTextBoxColumn9.Name = "ImportePagado";
            gridViewTextBoxColumn9.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn9.Width = 123;
            gridViewTextBoxColumn10.AllowFiltering = false;
            gridViewTextBoxColumn10.AllowGroup = false;
            gridViewTextBoxColumn10.AllowReorder = false;
            gridViewTextBoxColumn10.AllowSort = false;
            gridViewTextBoxColumn10.FieldName = "ImporteDebe";
            gridViewTextBoxColumn10.FormatString = "{0:c2}";
            gridViewTextBoxColumn10.HeaderText = "Debe";
            gridViewTextBoxColumn10.Name = "ImporteDebe";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn10.Width = 110;
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
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.Width = 30;
            this.GridOrdenesPago.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.GridOrdenesPago.MasterTemplate.EnableGrouping = false;
            this.GridOrdenesPago.MasterTemplate.FilterDescriptors.AddRange(new Telerik.WinControls.Data.FilterDescriptor[] {
            filterDescriptor1});
            this.GridOrdenesPago.Name = "GridOrdenesPago";
            this.GridOrdenesPago.ReadOnly = true;
            this.GridOrdenesPago.Size = new System.Drawing.Size(1335, 494);
            this.GridOrdenesPago.TabIndex = 13;
            this.GridOrdenesPago.ThemeName = "TelerikMetroBlue";
            this.GridOrdenesPago.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridOrdenesPagos_CommandCellClick);
            // 
            // ordenesPagoDtoBindingSource
            // 
            this.ordenesPagoDtoBindingSource.DataSource = typeof(LaPaz.Entidades.Dto.OrdenesPagoDto);
            // 
            // FrmOrdenesPagosListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 788);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmOrdenesPagosListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ordenes de Pago";
            this.Load += new System.EventHandler(this.FrmOrdenesPagosListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrearCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrdenesPago.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridOrdenesPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenesPagoDtoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Framework.WinForm.Controls.MetroPager OrdenesPagoPager;
        private Telerik.WinControls.UI.RadGridView GridOrdenesPagos;
        private System.Windows.Forms.BindingSource ordenesPagoDtoBindingSource;
        private Telerik.WinControls.UI.RadGridView GridOrdenesPago;
        private UcFiltrosOrdenesPago UcFiltrosOrdenesPago;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadButton BtnCrearCliente;
        private Util.UcProgressSpinner ucProgressSpinner1;
    }
}