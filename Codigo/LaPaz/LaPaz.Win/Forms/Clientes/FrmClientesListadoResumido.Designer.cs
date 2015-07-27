namespace LaPaz.Win.Forms.Clientes
{
    partial class FrmClientesListadoResumido
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
            this.GrillaClientes = new Telerik.WinControls.UI.RadGridView();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaClientes.Location = new System.Drawing.Point(12, 25);
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.MasterTemplate.AllowAddNewRow = false;
            this.GrillaClientes.MasterTemplate.AllowDeleteRow = false;
            this.GrillaClientes.MasterTemplate.AllowDragToGroup = false;
            this.GrillaClientes.MasterTemplate.AllowEditRow = false;
            this.GrillaClientes.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaClientes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Denominacion";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.MinWidth = 300;
            gridViewTextBoxColumn1.Name = "ColumnaNombre";
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.FieldName = "Cuit";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "DNI";
            gridViewTextBoxColumn2.MinWidth = 100;
            gridViewTextBoxColumn2.Name = "ColumnaDNI";
            gridViewTextBoxColumn2.Width = 182;
            gridViewTextBoxColumn3.HeaderText = "Teléfono";
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "ColumnaTelefono";
            gridViewTextBoxColumn3.FieldName = "Telefono";
            gridViewTextBoxColumn3.Width = 100;
            this.GrillaClientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3});
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ShowGroupPanel = false;
            this.GrillaClientes.Size = new System.Drawing.Size(602, 312);
            this.GrillaClientes.TabIndex = 0;
            this.GrillaClientes.Text = "GrillaClientes";
            this.GrillaClientes.ThemeName = "TelerikMetroBlue";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(514, 343);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 41;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // FrmClientesListadoResumido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 380);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.GrillaClientes);
            this.Name = "FrmClientesListadoResumido";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaClientes;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
    }
}