namespace LaPaz.Win.Forms.Ventas
{
    partial class UcBuscadorCliente
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
            this.TxtTextoBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.RdbContado = new Telerik.WinControls.UI.RadRadioButton();
            this.RdbCuentaCorriente = new Telerik.WinControls.UI.RadRadioButton();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.BtnBuscarCliente = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbContado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbCuentaCorriente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtTextoBuscar
            // 
            this.TxtTextoBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTextoBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTextoBuscar.Location = new System.Drawing.Point(60, 9);
            this.TxtTextoBuscar.MaxLength = 250;
            this.TxtTextoBuscar.Name = "TxtTextoBuscar";
            this.TxtTextoBuscar.Size = new System.Drawing.Size(166, 26);
            this.TxtTextoBuscar.TabIndex = 1;
            this.TxtTextoBuscar.TabStop = false;
            this.TxtTextoBuscar.ThemeName = "TelerikMetroBlue";
            this.TxtTextoBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTextoBuscar_KeyUp);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(3, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(58, 24);
            this.metroLabel7.TabIndex = 34;
            this.metroLabel7.Text = "Cliente:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // RdbContado
            // 
            this.RdbContado.AutoSize = true;
            this.RdbContado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbContado.Location = new System.Drawing.Point(17, 11);
            this.RdbContado.Name = "RdbContado";
            this.RdbContado.Size = new System.Drawing.Size(82, 24);
            this.RdbContado.TabIndex = 35;
            this.RdbContado.TabStop = true;
            this.RdbContado.Text = "Contado";
            this.RdbContado.ThemeName = "TelerikMetroBlue";
            this.RdbContado.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.RdbContado.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbContado_ToggleStateChanged);
            // 
            // RdbCuentaCorriente
            // 
            this.RdbCuentaCorriente.AutoSize = true;
            this.RdbCuentaCorriente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCuentaCorriente.Location = new System.Drawing.Point(170, 11);
            this.RdbCuentaCorriente.Name = "RdbCuentaCorriente";
            this.RdbCuentaCorriente.Size = new System.Drawing.Size(139, 24);
            this.RdbCuentaCorriente.TabIndex = 36;
            this.RdbCuentaCorriente.Text = "Cuenta Corriente";
            this.RdbCuentaCorriente.ThemeName = "TelerikMetroBlue";
            this.RdbCuentaCorriente.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbCuentaCorriente_ToggleStateChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RdbCuentaCorriente);
            this.metroPanel1.Controls.Add(this.RdbContado);
            this.metroPanel1.Location = new System.Drawing.Point(6, 44);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(331, 43);
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(233, 7);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(103, 29);
            this.BtnBuscarCliente.TabIndex = 38;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.ThemeName = "TelerikMetroBlue";
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // UcBuscadorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.TxtTextoBuscar);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcBuscadorCliente";
            this.Size = new System.Drawing.Size(340, 96);
            this.Load += new System.EventHandler(this.UcBuscadorCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbContado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbCuentaCorriente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtTextoBuscar;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadRadioButton RdbContado;
        private Telerik.WinControls.UI.RadRadioButton RdbCuentaCorriente;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadButton BtnBuscarCliente;
    }
}
