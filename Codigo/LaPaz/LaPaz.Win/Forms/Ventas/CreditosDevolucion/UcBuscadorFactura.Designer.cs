namespace LaPaz.Win.Forms.Ventas.CreditosDevolucion
{
    partial class UcBuscadorFactura
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtSucursal = new Telerik.WinControls.UI.RadTextBox();
            this.TxtNroFactura = new Telerik.WinControls.UI.RadTextBox();
            this.BtnBuscarFactura = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarFactura)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(13, 18);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(91, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Factura Nro:";
            // 
            // TxtSucursal
            // 
            this.TxtSucursal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSucursal.Location = new System.Drawing.Point(110, 18);
            this.TxtSucursal.Name = "TxtSucursal";
            this.TxtSucursal.Size = new System.Drawing.Size(43, 26);
            this.TxtSucursal.TabIndex = 1;
            this.TxtSucursal.TabStop = false;
            this.TxtSucursal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSucursal.ThemeName = "TelerikMetroBlue";
            // 
            // TxtNroFactura
            // 
            this.TxtNroFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroFactura.Location = new System.Drawing.Point(160, 18);
            this.TxtNroFactura.Name = "TxtNroFactura";
            this.TxtNroFactura.Size = new System.Drawing.Size(184, 26);
            this.TxtNroFactura.TabIndex = 2;
            this.TxtNroFactura.TabStop = false;
            this.TxtNroFactura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtNroFactura.ThemeName = "TelerikMetroBlue";
            this.TxtNroFactura.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtNroFactura_KeyUp);
            // 
            // BtnBuscarFactura
            // 
            this.BtnBuscarFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarFactura.Location = new System.Drawing.Point(350, 16);
            this.BtnBuscarFactura.Name = "BtnBuscarFactura";
            this.BtnBuscarFactura.Size = new System.Drawing.Size(123, 29);
            this.BtnBuscarFactura.TabIndex = 3;
            this.BtnBuscarFactura.Text = "Buscar";
            this.BtnBuscarFactura.ThemeName = "TelerikMetroBlue";
            this.BtnBuscarFactura.Click += new System.EventHandler(this.BtnBuscarFactura_Click);
            // 
            // UcBuscadorFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnBuscarFactura);
            this.Controls.Add(this.TxtNroFactura);
            this.Controls.Add(this.TxtSucursal);
            this.Controls.Add(this.radLabel1);
            this.Name = "UcBuscadorFactura";
            this.Size = new System.Drawing.Size(491, 58);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarFactura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtSucursal;
        private Telerik.WinControls.UI.RadTextBox TxtNroFactura;
        private Telerik.WinControls.UI.RadButton BtnBuscarFactura;
    }
}
