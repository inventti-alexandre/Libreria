using LaPaz.Win.Forms.Proveedores;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Ventas
{
    partial class FrmVentasListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ProveedoresPager = new Framework.WinForm.Controls.MetroPager();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UcFiltrosVentas = new LaPaz.Win.Forms.Ventas.UcFiltrosVentas();
            this.UcProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridVentas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentas.MasterTemplate)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.GridVentas);
            this.splitContainer1.Size = new System.Drawing.Size(1728, 1013);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.ProveedoresPager, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1728, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ProveedoresPager
            // 
            this.ProveedoresPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProveedoresPager.CurrentPage = 1;
            this.ProveedoresPager.Location = new System.Drawing.Point(1219, 185);
            this.ProveedoresPager.Margin = new System.Windows.Forms.Padding(5);
            this.ProveedoresPager.Name = "ProveedoresPager";
            this.ProveedoresPager.PageSize = 50;
            this.ProveedoresPager.PageTotal = 1;
            this.ProveedoresPager.RefreshAction = null;
            this.ProveedoresPager.RefreshActionAsync = null;
            this.ProveedoresPager.Size = new System.Drawing.Size(504, 48);
            this.ProveedoresPager.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.UcFiltrosVentas, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UcProgressSpinner, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1720, 172);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // UcFiltrosVentas
            // 
            this.UcFiltrosVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosVentas.Location = new System.Drawing.Point(5, 5);
            this.UcFiltrosVentas.Margin = new System.Windows.Forms.Padding(5);
            this.UcFiltrosVentas.Name = "UcFiltrosVentas";
            this.UcFiltrosVentas.NumeroComprobante = null;
            this.UcFiltrosVentas.Size = new System.Drawing.Size(1366, 165);
            this.UcFiltrosVentas.TabIndex = 13;
            this.UcFiltrosVentas.TextoABuscar = "";
            // 
            // UcProgressSpinner
            // 
            this.UcProgressSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcProgressSpinner.Location = new System.Drawing.Point(1499, 5);
            this.UcProgressSpinner.Margin = new System.Windows.Forms.Padding(5);
            this.UcProgressSpinner.Name = "UcProgressSpinner";
            this.UcProgressSpinner.Size = new System.Drawing.Size(216, 33);
            this.UcProgressSpinner.TabIndex = 11;
            // 
            // GridVentas
            // 
            this.GridVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridVentas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridVentas.Location = new System.Drawing.Point(0, 0);
            this.GridVentas.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // GridVentas
            // 
            this.GridVentas.MasterTemplate.AllowAddNewRow = false;
            this.GridVentas.MasterTemplate.AllowColumnReorder = false;
            this.GridVentas.MasterTemplate.AllowDeleteRow = false;
            this.GridVentas.MasterTemplate.AllowDragToGroup = false;
            this.GridVentas.MasterTemplate.AllowEditRow = false;
            this.GridVentas.MasterTemplate.AllowRowResize = false;
            this.GridVentas.MasterTemplate.AutoGenerateColumns = false;
            this.GridVentas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn1.HeaderText = "Fecha Alta";
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "FechaAlta";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 262;
            gridViewTextBoxColumn2.FieldName = "LCN";
            gridViewTextBoxColumn2.HeaderText = "LCN";
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 257;
            gridViewTextBoxColumn3.FieldName = "EstadosVentaAbreviatura";
            gridViewTextBoxColumn3.HeaderText = "Estado";
            gridViewTextBoxColumn3.IsVisible = false;
            gridViewTextBoxColumn3.MinWidth = 80;
            gridViewTextBoxColumn3.Name = "EstadosVentaAbreviatura";
            gridViewTextBoxColumn3.Width = 80;
            gridViewTextBoxColumn4.FieldName = "TiposComprobanteAbreviatura";
            gridViewTextBoxColumn4.HeaderText = "Tpo. Comp.";
            gridViewTextBoxColumn4.IsVisible = false;
            gridViewTextBoxColumn4.MinWidth = 80;
            gridViewTextBoxColumn4.Name = "TiposComprobanteAbreviatura";
            gridViewTextBoxColumn4.Width = 80;
            gridViewTextBoxColumn5.FieldName = "ClienteDenominacion";
            gridViewTextBoxColumn5.HeaderText = "Cliente";
            gridViewTextBoxColumn5.MinWidth = 200;
            gridViewTextBoxColumn5.Name = "ClienteDenominacion";
            gridViewTextBoxColumn5.Width = 428;
            gridViewTextBoxColumn6.FieldName = "LetraComprobante";
            gridViewTextBoxColumn6.HeaderText = "Lta. Comp.";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.MaxWidth = 80;
            gridViewTextBoxColumn6.MinWidth = 80;
            gridViewTextBoxColumn6.Name = "LetraComprobante";
            gridViewTextBoxColumn6.Width = 80;
            gridViewTextBoxColumn7.FieldName = "NumeroComprobante";
            gridViewTextBoxColumn7.HeaderText = "Nro Comp.";
            gridViewTextBoxColumn7.MinWidth = 80;
            gridViewTextBoxColumn7.Name = "NumeroComprobante";
            gridViewTextBoxColumn7.Width = 211;
            gridViewTextBoxColumn8.FieldName = "CondicionesVentaDescripcion";
            gridViewTextBoxColumn8.HeaderText = "Cond. Vta.";
            gridViewTextBoxColumn8.IsVisible = false;
            gridViewTextBoxColumn8.MinWidth = 80;
            gridViewTextBoxColumn8.Name = "CondicionesVentaDescripcion";
            gridViewTextBoxColumn8.Width = 101;
            gridViewTextBoxColumn9.FieldName = "Concepto";
            gridViewTextBoxColumn9.HeaderText = "Concepto";
            gridViewTextBoxColumn9.MinWidth = 130;
            gridViewTextBoxColumn9.Name = "Concepto";
            gridViewTextBoxColumn9.Width = 340;
            gridViewTextBoxColumn10.FieldName = "ImporteNeto";
            gridViewTextBoxColumn10.FormatString = "{0:N2}";
            gridViewTextBoxColumn10.HeaderText = "Importe Neto";
            gridViewTextBoxColumn10.MinWidth = 100;
            gridViewTextBoxColumn10.Name = "ImporteNeto";
            gridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn10.Width = 136;
            gridViewTextBoxColumn11.FieldName = "ImporteIva";
            gridViewTextBoxColumn11.FormatString = "{0:N2}";
            gridViewTextBoxColumn11.HeaderText = "Importe Iva";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.MinWidth = 100;
            gridViewTextBoxColumn11.Name = "ImporteIva";
            gridViewTextBoxColumn11.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn11.Width = 152;
            gridViewTextBoxColumn12.FieldName = "ImporteSena";
            gridViewTextBoxColumn12.FormatString = "{0:N2}";
            gridViewTextBoxColumn12.HeaderText = "Importe Seña";
            gridViewTextBoxColumn12.IsVisible = false;
            gridViewTextBoxColumn12.MinWidth = 100;
            gridViewTextBoxColumn12.Name = "ImporteSena";
            gridViewTextBoxColumn12.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn12.Width = 173;
            gridViewTextBoxColumn13.FieldName = "TotalPagado";
            gridViewTextBoxColumn13.FormatString = "{0:N2}";
            gridViewTextBoxColumn13.HeaderText = "Total Pagado";
            gridViewTextBoxColumn13.IsVisible = false;
            gridViewTextBoxColumn13.MinWidth = 100;
            gridViewTextBoxColumn13.Name = "TotalPagado";
            gridViewTextBoxColumn13.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn13.Width = 127;
            gridViewTextBoxColumn14.FieldName = "FechaUltimoPago";
            gridViewTextBoxColumn14.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn14.HeaderText = "F. Ultimo Pago";
            gridViewTextBoxColumn14.IsVisible = false;
            gridViewTextBoxColumn14.MinWidth = 100;
            gridViewTextBoxColumn14.Name = "FechaUltimoPago";
            gridViewTextBoxColumn14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn14.Width = 115;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Print_16x16;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Imprimir";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Name = "column1";
            gridViewCommandColumn2.Width = 49;
            this.GridVentas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
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
            gridViewTextBoxColumn13,
            gridViewTextBoxColumn14,
            gridViewCommandColumn1,
            gridViewCommandColumn2});
            this.GridVentas.MasterTemplate.EnableGrouping = false;
            this.GridVentas.Name = "GridVentas";
            this.GridVentas.ReadOnly = true;
            this.GridVentas.Size = new System.Drawing.Size(1728, 789);
            this.GridVentas.TabIndex = 8;
            this.GridVentas.ThemeName = "TelerikMetroBlue";
            this.GridVentas.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridProveedores_CommandCellClick);
            // 
            // FrmVentasListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1728, 1013);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmVentasListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Ventas Historial";
            this.Load += new System.EventHandler(this.FrmVentasListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridVentas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.GridViewTextBoxColumn provinciaIdDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn comentariosDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn sucursalAltaIdDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn fechaAltaDataGridViewTextBoxColumn;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuenta;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Denominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Domicilio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Telefono;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Celular;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Contacto;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
        private Telerik.WinControls.UI.GridViewTextBoxColumn ProvinciaNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn LocalidadNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn CondicionCompraNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn PorcentajeDescuento;
        private Telerik.WinControls.UI.GridViewTextBoxColumn BancoNombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn CBU;
        private Telerik.WinControls.UI.GridViewTextBoxColumn EmailPedido;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Framework.WinForm.Controls.MetroPager ProveedoresPager;
        private RadGridView GridVentas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UcFiltrosVentas UcFiltrosVentas;
        private Util.UcProgressSpinner UcProgressSpinner;
    }
}