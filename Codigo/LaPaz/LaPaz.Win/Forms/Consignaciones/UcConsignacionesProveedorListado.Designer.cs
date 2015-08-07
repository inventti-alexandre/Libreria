namespace LaPaz.Win.Forms.Consignaciones
{
    partial class UcConsignacionesProveedorListado
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

        #region Component Designer generated code

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
            this.GridConsignaciones = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // GridConsignaciones
            // 
            this.GridConsignaciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridConsignaciones.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridConsignaciones.Location = new System.Drawing.Point(0, 0);
            // 
            // GridConsignaciones
            // 
            this.GridConsignaciones.MasterTemplate.AllowAddNewRow = false;
            this.GridConsignaciones.MasterTemplate.AllowEditRow = false;
            this.GridConsignaciones.MasterTemplate.AutoGenerateColumns = false;
            this.GridConsignaciones.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "ProveedorDenominacion";
            gridViewTextBoxColumn1.HeaderText = "Proveedor";
            gridViewTextBoxColumn1.Name = "ProveedorDenominacion";
            gridViewTextBoxColumn1.Width = 232;
            gridViewTextBoxColumn2.FieldName = "LCN";
            gridViewTextBoxColumn2.HeaderText = "LCN";
            gridViewTextBoxColumn2.MinWidth = 120;
            gridViewTextBoxColumn2.Name = "LCN";
            gridViewTextBoxColumn2.Width = 120;
            gridViewTextBoxColumn3.FieldName = "FechaConsignacion";
            gridViewTextBoxColumn3.HeaderText = "Fecha Consig,";
            gridViewTextBoxColumn3.MinWidth = 120;
            gridViewTextBoxColumn3.Name = "FechaConsignacion";
            gridViewTextBoxColumn3.Width = 120;
            gridViewTextBoxColumn4.FieldName = "Importe";
            gridViewTextBoxColumn4.HeaderText = "Importe";
            gridViewTextBoxColumn4.MinWidth = 150;
            gridViewTextBoxColumn4.Name = "Importe";
            gridViewTextBoxColumn4.Width = 150;
            gridViewTextBoxColumn5.FieldName = "Pagado";
            gridViewTextBoxColumn5.HeaderText = "Pagado ";
            gridViewTextBoxColumn5.MinWidth = 150;
            gridViewTextBoxColumn5.Name = "Pagado";
            gridViewTextBoxColumn5.Width = 150;
            gridViewTextBoxColumn6.FieldName = "UltimaFechaPago";
            gridViewTextBoxColumn6.HeaderText = "Ultima Fecha Pago ";
            gridViewTextBoxColumn6.MinWidth = 130;
            gridViewTextBoxColumn6.Name = "UltimaFechaPago";
            gridViewTextBoxColumn6.Width = 130;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.Name = "ColumnaDetalle";
            gridViewCommandColumn1.Width = 14;
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
            this.GridConsignaciones.Size = new System.Drawing.Size(931, 111);
            this.GridConsignaciones.TabIndex = 14;
            this.GridConsignaciones.ThemeName = "TelerikMetroBlue";
            this.GridConsignaciones.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridConsignaciones_CommandCellClick);
            // 
            // UcConsignacionesProveedorListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GridConsignaciones);
            this.Name = "UcConsignacionesProveedorListado";
            this.Size = new System.Drawing.Size(931, 111);
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridConsignaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GridConsignaciones;
    }
}
