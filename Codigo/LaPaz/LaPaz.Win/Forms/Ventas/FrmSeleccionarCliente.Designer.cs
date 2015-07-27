namespace LaPaz.Win.Forms.Ventas
{
    partial class FrmSeleccionarCliente
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
            this.GrillaSeleccionarCliente.Location = new System.Drawing.Point(23, 12);
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
            gridViewTextBoxColumn1.FieldName = "Denominacion";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.Name = "Nombre";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 184;
            gridViewTextBoxColumn2.FieldName = "Cuit";
            gridViewTextBoxColumn2.HeaderText = "DNI";
            gridViewTextBoxColumn2.Name = "Cuit";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 129;
            gridViewCommandColumn1.DefaultText = "Seleccionar";
            gridViewCommandColumn1.FieldName = "Seleccionar";
            gridViewCommandColumn1.FormatInfo = new System.Globalization.CultureInfo("");
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.MinWidth = 100;
            gridViewCommandColumn1.Name = "Seleccionar";
            gridViewCommandColumn1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            gridViewCommandColumn1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            gridViewCommandColumn1.UseDefaultText = true;
            gridViewCommandColumn1.Width = 100;
            this.GrillaSeleccionarCliente.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1});
            this.GrillaSeleccionarCliente.MasterTemplate.EnableGrouping = false;
            this.GrillaSeleccionarCliente.Name = "GrillaSeleccionarCliente";
            this.GrillaSeleccionarCliente.ReadOnly = true;
            this.GrillaSeleccionarCliente.Size = new System.Drawing.Size(433, 417);
            this.GrillaSeleccionarCliente.TabIndex = 40;
            this.GrillaSeleccionarCliente.ThemeName = "TelerikMetroBlue";
            this.GrillaSeleccionarCliente.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaSeleccionarCliente_CommandCellClick);
            this.GrillaSeleccionarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrillaSeleccionarCliente_KeyUp);
            // 
            // FrmSeleccionarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 441);
            this.Controls.Add(this.GrillaSeleccionarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSeleccionarCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Seleccionar Cliente";
            this.Load += new System.EventHandler(this.FrmSeleccionarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionarCliente.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaSeleccionarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaSeleccionarCliente;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Nombre;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
    }
}