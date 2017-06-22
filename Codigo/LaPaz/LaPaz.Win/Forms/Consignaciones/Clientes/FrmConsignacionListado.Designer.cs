namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class FrmConsignacionListado
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ucBuscadorConsignacion1 = new LaPaz.Win.Forms.Consignaciones.Clientes.UcBuscadorConsignacion();
            this.GridConsignaciones = new Telerik.WinControls.UI.RadGridView();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.39503F));
            this.tableLayoutPanel1.Controls.Add(this.ucBuscadorConsignacion1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.GridConsignaciones, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80.15873F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.84127F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 462F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1329, 589);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // ucBuscadorConsignacion1
            // 
            this.ucBuscadorConsignacion1.Consignacion = "";
            this.ucBuscadorConsignacion1.Cuit = "";
            this.ucBuscadorConsignacion1.Location = new System.Drawing.Point(4, 4);
            this.ucBuscadorConsignacion1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucBuscadorConsignacion1.Name = "ucBuscadorConsignacion1";
            this.ucBuscadorConsignacion1.Size = new System.Drawing.Size(571, 93);
            this.ucBuscadorConsignacion1.TabIndex = 0;
            // 
            // GridConsignaciones
            // 
            this.GridConsignaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridConsignaciones.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridConsignaciones.Location = new System.Drawing.Point(7, 132);
            this.GridConsignaciones.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            // 
            // GridConsignaciones
            // 
            this.GridConsignaciones.MasterTemplate.AllowAddNewRow = false;
            this.GridConsignaciones.MasterTemplate.AllowColumnReorder = false;
            this.GridConsignaciones.MasterTemplate.AllowDeleteRow = false;
            this.GridConsignaciones.MasterTemplate.AllowDragToGroup = false;
            this.GridConsignaciones.MasterTemplate.AllowEditRow = false;
            this.GridConsignaciones.MasterTemplate.AllowRowResize = false;
            this.GridConsignaciones.MasterTemplate.AutoGenerateColumns = false;
            this.GridConsignaciones.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaAlta";
            gridViewTextBoxColumn1.FormatString = "{0: dd/M/yyyy}";
            gridViewTextBoxColumn1.HeaderText = "Fecha Alta";
            gridViewTextBoxColumn1.MinWidth = 100;
            gridViewTextBoxColumn1.Name = "FechaAlta";
            gridViewTextBoxColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewTextBoxColumn1.Width = 197;
            gridViewTextBoxColumn2.FieldName = "LCN";
            gridViewTextBoxColumn2.HeaderText = "LCN";
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 194;
            gridViewTextBoxColumn3.FieldName = "ClienteConsignadoDenominacion";
            gridViewTextBoxColumn3.HeaderText = "Cliente";
            gridViewTextBoxColumn3.MinWidth = 200;
            gridViewTextBoxColumn3.Name = "ClienteConsignadoDenominacion";
            gridViewTextBoxColumn3.Width = 324;
            gridViewTextBoxColumn4.FieldName = "NumeroComprobante";
            gridViewTextBoxColumn4.HeaderText = "Nro Comp.";
            gridViewTextBoxColumn4.MinWidth = 80;
            gridViewTextBoxColumn4.Name = "NumeroComprobante";
            gridViewTextBoxColumn4.Width = 160;
            gridViewTextBoxColumn5.FieldName = "Concepto";
            gridViewTextBoxColumn5.HeaderText = "Concepto";
            gridViewTextBoxColumn5.MinWidth = 130;
            gridViewTextBoxColumn5.Name = "Concepto";
            gridViewTextBoxColumn5.Width = 257;
            gridViewTextBoxColumn6.FieldName = "ImporteNeto";
            gridViewTextBoxColumn6.FormatString = "{0:N2}";
            gridViewTextBoxColumn6.HeaderText = "Importe Neto";
            gridViewTextBoxColumn6.MinWidth = 100;
            gridViewTextBoxColumn6.Name = "ImporteNeto";
            gridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn6.Width = 137;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Print_16x16;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Imprimir";
            gridViewCommandColumn1.Width = 30;
            this.GridConsignaciones.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn1});
            this.GridConsignaciones.MasterTemplate.EnableGrouping = false;
            this.GridConsignaciones.Name = "GridConsignaciones";
            this.GridConsignaciones.ReadOnly = true;
            this.GridConsignaciones.Size = new System.Drawing.Size(1315, 451);
            this.GridConsignaciones.TabIndex = 9;
            this.GridConsignaciones.ThemeName = "TelerikMetroBlue";
            this.GridConsignaciones.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridConsignaciones_CommandCellClick);
            // 
            // FrmConsignacionListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1324, 601);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmConsignacionListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Historial Consignaciones Clientes";
            this.Load += new System.EventHandler(this.FrmConsignacionListado_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private UcBuscadorConsignacion ucBuscadorConsignacion1;
        private Telerik.WinControls.UI.RadGridView GridConsignaciones;
    }
}