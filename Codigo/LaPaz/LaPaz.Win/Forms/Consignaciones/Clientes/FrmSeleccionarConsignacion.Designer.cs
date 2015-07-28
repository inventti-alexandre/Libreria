namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class FrmSeleccionarConsignacion
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.GrillaSeleccionarCliente = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionarCliente.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaSeleccionarCliente
            // 
            this.GrillaSeleccionarCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaSeleccionarCliente.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaSeleccionarCliente.Location = new System.Drawing.Point(12, 12);
            // 
            // GrillaSeleccionarCliente
            // 
            this.GrillaSeleccionarCliente.MasterTemplate.AllowAddNewRow = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AllowColumnReorder = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AllowColumnResize = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AllowDeleteRow = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AllowDragToGroup = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AllowEditRow = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AllowRowResize = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaSeleccionarCliente.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "FechaComprobante";
            gridViewTextBoxColumn1.FormatString = "{0:dd/MM/yyyy}";
            gridViewTextBoxColumn1.HeaderText = "Fecha Comprobante ";
            gridViewTextBoxColumn1.MaxWidth = 137;
            gridViewTextBoxColumn1.MinWidth = 137;
            gridViewTextBoxColumn1.Name = "FechaComprobante ";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 137;
            gridViewTextBoxColumn2.FieldName = "NumeroComprobante";
            gridViewTextBoxColumn2.HeaderText = "Nro";
            gridViewTextBoxColumn2.Name = "Nro";
            gridViewTextBoxColumn2.Width = 44;
            gridViewTextBoxColumn3.FieldName = "Concepto";
            gridViewTextBoxColumn3.HeaderText = "Concepto";
            gridViewTextBoxColumn3.MaxWidth = 250;
            gridViewTextBoxColumn3.MinWidth = 170;
            gridViewTextBoxColumn3.Name = "Concepto";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 221;
            gridViewTextBoxColumn4.FieldName = "ImporteNeto";
            gridViewTextBoxColumn4.FormatString = "{0:N2}";
            gridViewTextBoxColumn4.HeaderText = "Importe Neto";
            gridViewTextBoxColumn4.MaxWidth = 96;
            gridViewTextBoxColumn4.MinWidth = 96;
            gridViewTextBoxColumn4.Name = "ImporteNeto";
            gridViewTextBoxColumn4.Width = 96;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.FieldName = "Seleccionar";
            gridViewCommandColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.MinWidth = 100;
            gridViewCommandColumn1.Name = "Seleccionar";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 104;
            this.GrillaSeleccionarCliente.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewCommandColumn1});
            this.GrillaSeleccionarCliente.MasterTemplate.EnableGrouping = false;
            this.GrillaSeleccionarCliente.Name = "GrillaSeleccionarCliente";
            this.GrillaSeleccionarCliente.ReadOnly = true;
            this.GrillaSeleccionarCliente.Size = new System.Drawing.Size(620, 231);
            this.GrillaSeleccionarCliente.TabIndex = 41;
            this.GrillaSeleccionarCliente.ThemeName = "TelerikMetroBlue";
            this.GrillaSeleccionarCliente.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaSeleccionarCliente_CommandCellClick);
            this.GrillaSeleccionarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrillaSeleccionarCliente_KeyUp);
            // 
            // FrmSeleccionarConsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 255);
            this.Controls.Add(this.GrillaSeleccionarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionarConsignacion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Consignación";
            this.Load += new System.EventHandler(this.FrmSeleccionarConsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionarCliente.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaSeleccionarCliente;
    }
}