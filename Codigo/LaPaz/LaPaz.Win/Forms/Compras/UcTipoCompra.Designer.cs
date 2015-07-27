namespace LaPaz.Win.Forms.Compras
{
    partial class UcTipoCompra
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
            this.RdbContado = new Telerik.WinControls.UI.RadRadioButton();
            this.RdbCuentaCorriente = new Telerik.WinControls.UI.RadRadioButton();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.RdbAnular = new Telerik.WinControls.UI.RadRadioButton();
            this.RdbProduccion = new Telerik.WinControls.UI.RadRadioButton();
            this.RdbConsignacion = new Telerik.WinControls.UI.RadRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.RdbContado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbCuentaCorriente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdbAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbProduccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbConsignacion)).BeginInit();
            this.SuspendLayout();
            // 
            // RdbContado
            // 
            this.RdbContado.AutoSize = true;
            this.RdbContado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbContado.Location = new System.Drawing.Point(3, 3);
            this.RdbContado.Name = "RdbContado";
            this.RdbContado.Size = new System.Drawing.Size(82, 24);
            this.RdbContado.TabIndex = 35;
            this.RdbContado.Text = "Contado";
            this.RdbContado.ThemeName = "TelerikMetroBlue";
            this.RdbContado.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbContado_ToggleStateChanged);
            // 
            // RdbCuentaCorriente
            // 
            this.RdbCuentaCorriente.AutoSize = true;
            this.RdbCuentaCorriente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCuentaCorriente.Location = new System.Drawing.Point(106, 3);
            this.RdbCuentaCorriente.Name = "RdbCuentaCorriente";
            this.RdbCuentaCorriente.Size = new System.Drawing.Size(139, 24);
            this.RdbCuentaCorriente.TabIndex = 36;
            this.RdbCuentaCorriente.Text = "Cuenta Corriente";
            this.RdbCuentaCorriente.ThemeName = "TelerikMetroBlue";
            this.RdbCuentaCorriente.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbCuentaCorriente_ToggleStateChanged);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.RdbAnular);
            this.metroPanel1.Controls.Add(this.RdbProduccion);
            this.metroPanel1.Controls.Add(this.RdbConsignacion);
            this.metroPanel1.Controls.Add(this.RdbCuentaCorriente);
            this.metroPanel1.Controls.Add(this.RdbContado);
            this.metroPanel1.Location = new System.Drawing.Point(0, 3);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(753, 30);
            this.metroPanel1.TabIndex = 37;
            this.metroPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // RdbAnular
            // 
            this.RdbAnular.AutoSize = true;
            this.RdbAnular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbAnular.Location = new System.Drawing.Point(524, 3);
            this.RdbAnular.Name = "RdbAnular";
            this.RdbAnular.Size = new System.Drawing.Size(164, 24);
            this.RdbAnular.TabIndex = 38;
            this.RdbAnular.Text = "Anular Consignacion";
            this.RdbAnular.ThemeName = "TelerikMetroBlue";
            this.RdbAnular.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbAnular_ToggleStateChanged);
            // 
            // RdbProduccion
            // 
            this.RdbProduccion.AutoSize = true;
            this.RdbProduccion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbProduccion.Location = new System.Drawing.Point(403, 3);
            this.RdbProduccion.Name = "RdbProduccion";
            this.RdbProduccion.Size = new System.Drawing.Size(100, 24);
            this.RdbProduccion.TabIndex = 37;
            this.RdbProduccion.Text = "Produccion";
            this.RdbProduccion.ThemeName = "TelerikMetroBlue";
            this.RdbProduccion.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbProduccion_ToggleStateChanged);
            // 
            // RdbConsignacion
            // 
            this.RdbConsignacion.AutoSize = true;
            this.RdbConsignacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbConsignacion.Location = new System.Drawing.Point(266, 3);
            this.RdbConsignacion.Name = "RdbConsignacion";
            this.RdbConsignacion.Size = new System.Drawing.Size(116, 24);
            this.RdbConsignacion.TabIndex = 37;
            this.RdbConsignacion.Text = "Consignacion";
            this.RdbConsignacion.ThemeName = "TelerikMetroBlue";
            this.RdbConsignacion.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbConsignacion_ToggleStateChanged);
            // 
            // UcTipoCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "UcTipoCompra";
            this.Size = new System.Drawing.Size(753, 36);
            ((System.ComponentModel.ISupportInitialize)(this.RdbContado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbCuentaCorriente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdbAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbProduccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbConsignacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadRadioButton RdbContado;
        private Telerik.WinControls.UI.RadRadioButton RdbCuentaCorriente;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadRadioButton RdbAnular;
        private Telerik.WinControls.UI.RadRadioButton RdbProduccion;
        private Telerik.WinControls.UI.RadRadioButton RdbConsignacion;
    }
}
