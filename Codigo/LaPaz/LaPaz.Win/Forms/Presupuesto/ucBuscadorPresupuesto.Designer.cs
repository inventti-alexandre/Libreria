namespace LaPaz.Win.Forms.Presupuesto
{
    partial class ucBuscadorPresupuesto
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
            this.TxtBuscarCliente = new Telerik.WinControls.UI.RadTextBox();
            this.BtnBuscarCliente = new Telerik.WinControls.UI.RadButton();
            this.TxtTextoBuscar = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscarPresupuesto = new Telerik.WinControls.UI.RadButton();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtBuscarCliente
            // 
            this.TxtBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarCliente.Location = new System.Drawing.Point(205, 66);
            this.TxtBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.TxtBuscarCliente.Name = "TxtBuscarCliente";
            this.TxtBuscarCliente.Size = new System.Drawing.Size(223, 31);
            this.TxtBuscarCliente.TabIndex = 9;
            this.TxtBuscarCliente.TabStop = false;
            this.TxtBuscarCliente.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(437, 64);
            this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(137, 36);
            this.BtnBuscarCliente.TabIndex = 10;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTextoBuscar
            // 
            this.TxtTextoBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTextoBuscar.Location = new System.Drawing.Point(205, 21);
            this.TxtTextoBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.TxtTextoBuscar.Name = "TxtTextoBuscar";
            this.TxtTextoBuscar.Size = new System.Drawing.Size(223, 28);
            this.TxtTextoBuscar.TabIndex = 7;
            this.TxtTextoBuscar.TabStop = false;
            this.TxtTextoBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtTextoBuscar.ThemeName = "TelerikMetroBlue";
            this.TxtTextoBuscar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTextoBuscar_KeyUp);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(16, 67);
            this.radLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(72, 29);
            this.radLabel1.TabIndex = 5;
            this.radLabel1.Text = "Cliente:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscarPresupuesto
            // 
            this.BtnBuscarPresupuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarPresupuesto.Location = new System.Drawing.Point(437, 18);
            this.BtnBuscarPresupuesto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnBuscarPresupuesto.Name = "BtnBuscarPresupuesto";
            this.BtnBuscarPresupuesto.Size = new System.Drawing.Size(137, 36);
            this.BtnBuscarPresupuesto.TabIndex = 8;
            this.BtnBuscarPresupuesto.Text = "Buscar";
            this.BtnBuscarPresupuesto.ThemeName = "TelerikMetroBlue";
            this.BtnBuscarPresupuesto.Click += new System.EventHandler(this.BtnBuscarPresupuesto_Click);
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(16, 20);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(4);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(160, 29);
            this.metroLabel7.TabIndex = 6;
            this.metroLabel7.Text = "Nro. Presupuesto:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // ucBuscadorPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtBuscarCliente);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtTextoBuscar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.BtnBuscarPresupuesto);
            this.Controls.Add(this.metroLabel7);
            this.Name = "ucBuscadorPresupuesto";
            this.Size = new System.Drawing.Size(588, 118);
            ((System.ComponentModel.ISupportInitialize)(this.TxtBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtBuscarCliente;
        private Telerik.WinControls.UI.RadButton BtnBuscarCliente;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtTextoBuscar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadButton BtnBuscarPresupuesto;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
    }
}
