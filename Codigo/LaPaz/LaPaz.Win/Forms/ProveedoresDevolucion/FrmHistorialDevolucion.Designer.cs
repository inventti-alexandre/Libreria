namespace LaPaz.Win.Forms.ProveedoresDevolucion
{
    partial class FrmHistorialDevolucion
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.UcFiltrosCompras = new LaPaz.Win.Forms.Compras.UcFiltrosCompras();
            this.GridDevoluciones = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridDevoluciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDevoluciones.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.UcFiltrosCompras, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridDevoluciones, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.37563F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 74.62437F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1253, 599);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // UcFiltrosCompras
            // 
            this.UcFiltrosCompras.FechaHasta = new System.DateTime(2015, 2, 4, 17, 33, 8, 710);
            this.UcFiltrosCompras.FechaInicio = new System.DateTime(2015, 1, 19, 0, 0, 0, 0);
            this.UcFiltrosCompras.Location = new System.Drawing.Point(4, 4);
            this.UcFiltrosCompras.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcFiltrosCompras.Name = "UcFiltrosCompras";
            this.UcFiltrosCompras.NroComprobante = "";
            this.UcFiltrosCompras.ProveedorId = null;
            this.UcFiltrosCompras.Size = new System.Drawing.Size(1087, 122);
            this.UcFiltrosCompras.TabIndex = 0;
            this.UcFiltrosCompras.TipoId = null;
            // 
            // GridDevoluciones
            // 
            this.GridDevoluciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridDevoluciones.Location = new System.Drawing.Point(3, 155);
            // 
            // GridDevoluciones
            // 
            this.GridDevoluciones.MasterTemplate.AllowAddNewRow = false;
            this.GridDevoluciones.MasterTemplate.AllowColumnReorder = false;
            this.GridDevoluciones.MasterTemplate.AllowDragToGroup = false;
            this.GridDevoluciones.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.HeaderText = "FechaAlta";
            gridViewTextBoxColumn1.Name = "FechaAlta";
            gridViewTextBoxColumn1.Width = 406;
            gridViewTextBoxColumn2.FieldName = "LCN";
            gridViewTextBoxColumn2.HeaderText = "Numero";
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 350;
            gridViewTextBoxColumn3.FieldName = "ProveedoreDenominacion";
            gridViewTextBoxColumn3.HeaderText = "Proveedor";
            gridViewTextBoxColumn3.Name = "Proveedor";
            gridViewTextBoxColumn3.Width = 442;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Print_16x16;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Imprimir";
            gridViewCommandColumn1.Width = 30;
            this.GridDevoluciones.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.GridDevoluciones.Name = "GridDevoluciones";
            this.GridDevoluciones.ReadOnly = true;
            this.GridDevoluciones.Size = new System.Drawing.Size(1247, 441);
            this.GridDevoluciones.TabIndex = 1;
            this.GridDevoluciones.ThemeName = "TelerikMetroBlue";
            this.GridDevoluciones.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridDevoluciones_CommandCellClick);
            // 
            // FrmHistorialDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1277, 623);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmHistorialDevolucion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Historial Devoluciones";
            this.Load += new System.EventHandler(this.FrmHistorialDevolucion_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridDevoluciones.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridDevoluciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Compras.UcFiltrosCompras UcFiltrosCompras;
        private Telerik.WinControls.UI.RadGridView GridDevoluciones;
    }
}