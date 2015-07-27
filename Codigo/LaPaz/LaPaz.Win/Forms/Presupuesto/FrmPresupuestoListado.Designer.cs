using LaPaz.Win.Forms.Ventas;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Presupuesto
{
    partial class FrmPresupuestoListado
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PresupuestoPager = new Framework.WinForm.Controls.MetroPager();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.UcFiltrosPresupuesto = new LaPaz.Win.Forms.Presupuesto.UcFiltrosPresupuesto();
            this.UcProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.GridPresupuestos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridPresupuestos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPresupuestos.MasterTemplate)).BeginInit();
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
            this.splitContainer1.Panel2.Controls.Add(this.GridPresupuestos);
            this.splitContainer1.Size = new System.Drawing.Size(1506, 920);
            this.splitContainer1.SplitterDistance = 220;
            this.splitContainer1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.PresupuestoPager, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1506, 220);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // PresupuestoPager
            // 
            this.PresupuestoPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PresupuestoPager.CurrentPage = 1;
            this.PresupuestoPager.Location = new System.Drawing.Point(1125, 163);
            this.PresupuestoPager.Name = "PresupuestoPager";
            this.PresupuestoPager.PageSize = 50;
            this.PresupuestoPager.PageTotal = 1;
            this.PresupuestoPager.RefreshAction = null;
            this.PresupuestoPager.RefreshActionAsync = null;
            this.PresupuestoPager.Size = new System.Drawing.Size(378, 39);
            this.PresupuestoPager.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.UcFiltrosPresupuesto, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.UcProgressSpinner, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1500, 140);
            this.tableLayoutPanel2.TabIndex = 12;
            // 
            // UcFiltrosPresupuesto
            // 
            this.UcFiltrosPresupuesto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UcFiltrosPresupuesto.Location = new System.Drawing.Point(3, 3);
            this.UcFiltrosPresupuesto.Name = "UcFiltrosPresupuesto";
            this.UcFiltrosPresupuesto.Size = new System.Drawing.Size(1194, 134);
            this.UcFiltrosPresupuesto.TabIndex = 13;
            this.UcFiltrosPresupuesto.TextoABuscar = "";
            // 
            // UcProgressSpinner
            // 
            this.UcProgressSpinner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.UcProgressSpinner.Location = new System.Drawing.Point(1335, 3);
            this.UcProgressSpinner.Name = "UcProgressSpinner";
            this.UcProgressSpinner.Size = new System.Drawing.Size(162, 27);
            this.UcProgressSpinner.TabIndex = 11;
            // 
            // GridPresupuestos
            // 
            this.GridPresupuestos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridPresupuestos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridPresupuestos.Location = new System.Drawing.Point(0, 0);
            this.GridPresupuestos.Margin = new System.Windows.Forms.Padding(5);
            // 
            // GridPresupuestos
            // 
            this.GridPresupuestos.MasterTemplate.AllowAddNewRow = false;
            this.GridPresupuestos.MasterTemplate.AllowColumnReorder = false;
            this.GridPresupuestos.MasterTemplate.AllowDeleteRow = false;
            this.GridPresupuestos.MasterTemplate.AllowDragToGroup = false;
            this.GridPresupuestos.MasterTemplate.AllowEditRow = false;
            this.GridPresupuestos.MasterTemplate.AllowRowResize = false;
            this.GridPresupuestos.MasterTemplate.AutoGenerateColumns = false;
            this.GridPresupuestos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn1.HeaderText = "Fecha Alta";
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "FechaAlta";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 218;
            gridViewTextBoxColumn2.FieldName = "LCN";
            gridViewTextBoxColumn2.HeaderText = "LCN";
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 105;
            gridViewTextBoxColumn3.FieldName = "ClienteDenominacion";
            gridViewTextBoxColumn3.HeaderText = "Cliente";
            gridViewTextBoxColumn3.MinWidth = 200;
            gridViewTextBoxColumn3.Name = "ClienteDenominacion";
            gridViewTextBoxColumn3.Width = 422;
            gridViewTextBoxColumn4.FieldName = "Concepto";
            gridViewTextBoxColumn4.HeaderText = "Concepto";
            gridViewTextBoxColumn4.MinWidth = 130;
            gridViewTextBoxColumn4.Name = "Concepto";
            gridViewTextBoxColumn4.Width = 279;
            gridViewTextBoxColumn5.FieldName = "Descuento";
            gridViewTextBoxColumn5.FormatString = "{0:N2}";
            gridViewTextBoxColumn5.HeaderText = "Descuento";
            gridViewTextBoxColumn5.MinWidth = 100;
            gridViewTextBoxColumn5.Name = "Descuento";
            gridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn5.Width = 218;
            gridViewTextBoxColumn6.FieldName = "Total";
            gridViewTextBoxColumn6.FormatString = "{0:N2}";
            gridViewTextBoxColumn6.HeaderText = "Total";
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "Total";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 218;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Print_16x16;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Imprimir";
            gridViewCommandColumn1.Width = 30;
            this.GridPresupuestos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1});
            this.GridPresupuestos.MasterTemplate.EnableGrouping = false;
            this.GridPresupuestos.Name = "GridPresupuestos";
            this.GridPresupuestos.ReadOnly = true;
            this.GridPresupuestos.Size = new System.Drawing.Size(1506, 696);
            this.GridPresupuestos.TabIndex = 8;
            this.GridPresupuestos.ThemeName = "TelerikMetroBlue";
            this.GridPresupuestos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridPresupuestos_CommandCellClick);
            // 
            // FrmPresupuestoListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1506, 920);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPresupuestoListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Presupuestos Historial";
            this.Load += new System.EventHandler(this.FrmVentasListado_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridPresupuestos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridPresupuestos)).EndInit();
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
        private Framework.WinForm.Controls.MetroPager PresupuestoPager;
        private RadGridView GridPresupuestos;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private UcFiltrosPresupuesto UcFiltrosPresupuesto;
        private Util.UcProgressSpinner UcProgressSpinner;
    }
}