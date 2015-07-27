namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class UcBuscadorConsignacion
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
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscarConsignacion = new Telerik.WinControls.UI.RadButton();
            this.TxtTextoBuscar = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.RdbCuentaCorriente = new Telerik.WinControls.UI.RadRadioButton();
            this.RdbContado = new Telerik.WinControls.UI.RadRadioButton();
            this.BtnBuscarCliente = new Telerik.WinControls.UI.RadButton();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtBuscarCliente = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarConsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdbCuentaCorriente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbContado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(3, 9);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(136, 24);
            this.metroLabel7.TabIndex = 0;
            this.metroLabel7.Text = "Nro. Consignación:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscarConsignacion
            // 
            this.BtnBuscarConsignacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarConsignacion.Location = new System.Drawing.Point(319, 7);
            this.BtnBuscarConsignacion.Name = "BtnBuscarConsignacion";
            this.BtnBuscarConsignacion.Size = new System.Drawing.Size(103, 29);
            this.BtnBuscarConsignacion.TabIndex = 2;
            this.BtnBuscarConsignacion.Text = "Buscar";
            this.BtnBuscarConsignacion.ThemeName = "TelerikMetroBlue";
            this.BtnBuscarConsignacion.Click += new System.EventHandler(this.BtnBuscarConsignacion_Click);
            // 
            // TxtTextoBuscar
            // 
            this.TxtTextoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTextoBuscar.Location = new System.Drawing.Point(145, 10);
            this.TxtTextoBuscar.Name = "TxtTextoBuscar";
            this.TxtTextoBuscar.Size = new System.Drawing.Size(167, 23);
            this.TxtTextoBuscar.TabIndex = 1;
            this.TxtTextoBuscar.TabStop = false;
            this.TxtTextoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTextoBuscar.ThemeName = "TelerikMetroBlue";
            this.TxtTextoBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTextoBuscar_KeyUp);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.RdbCuentaCorriente);
            this.metroPanel1.Controls.Add(this.RdbContado);
            this.metroPanel1.Location = new System.Drawing.Point(3, 77);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(419, 43);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // RdbCuentaCorriente
            // 
            this.RdbCuentaCorriente.AutoSize = true;
            this.RdbCuentaCorriente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCuentaCorriente.Location = new System.Drawing.Point(170, 11);
            this.RdbCuentaCorriente.Name = "RdbCuentaCorriente";
            this.RdbCuentaCorriente.Size = new System.Drawing.Size(139, 24);
            this.RdbCuentaCorriente.TabIndex = 1;
            this.RdbCuentaCorriente.Text = "Cuenta Corriente";
            this.RdbCuentaCorriente.ThemeName = "TelerikMetroBlue";
            this.RdbCuentaCorriente.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbCuentaCorriente_ToggleStateChanged);
            // 
            // RdbContado
            // 
            this.RdbContado.AutoSize = true;
            this.RdbContado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbContado.Location = new System.Drawing.Point(17, 11);
            this.RdbContado.Name = "RdbContado";
            this.RdbContado.Size = new System.Drawing.Size(82, 24);
            this.RdbContado.TabIndex = 0;
            this.RdbContado.Text = "Contado";
            this.RdbContado.ThemeName = "TelerikMetroBlue";
            this.RdbContado.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RdbContado_ToggleStateChanged);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(319, 45);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(103, 29);
            this.BtnBuscarCliente.TabIndex = 4;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.ThemeName = "TelerikMetroBlue";
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(3, 47);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(58, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Cliente:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCliente.Location = new System.Drawing.Point(145, 46);
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.Size = new System.Drawing.Size(167, 26);
            this.TxtBuscarCliente.TabIndex = 3;
            this.TxtBuscarCliente.TabStop = false;
            this.TxtBuscarCliente.ThemeName = "TelerikMetroBlue";
            this.TxtBuscarCliente.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBuscarCliente_KeyUp);
            // 
            // UcBuscadorConsignacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtTextoBuscar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.BtnBuscarConsignacion);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcBuscadorConsignacion";
            this.Size = new System.Drawing.Size(428, 123);
            this.Load += new System.EventHandler(this.UcBuscadorConsignacion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarConsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RdbCuentaCorriente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RdbContado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadButton BtnBuscarConsignacion;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtTextoBuscar;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadRadioButton RdbCuentaCorriente;
        private Telerik.WinControls.UI.RadRadioButton RdbContado;
        private Telerik.WinControls.UI.RadButton BtnBuscarCliente;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtBuscarCliente;
    }
}
