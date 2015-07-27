namespace LaPaz.Win.Forms.CierreCaja
{
    partial class FrmCerrarCaja
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
                _cajaNegocio.Dispose();
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
            this.BtnCerrarCaja = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.LbConfirmacionCerrarCaja = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbConfirmacionCerrarCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCerrarCaja
            // 
            this.BtnCerrarCaja.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnCerrarCaja.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrarCaja.Location = new System.Drawing.Point(210, 130);
            this.BtnCerrarCaja.Name = "BtnCerrarCaja";
            this.BtnCerrarCaja.Size = new System.Drawing.Size(100, 30);
            this.BtnCerrarCaja.TabIndex = 86;
            this.BtnCerrarCaja.Text = "Cerrar";
            this.BtnCerrarCaja.ThemeName = "TelerikMetroBlue";
            this.BtnCerrarCaja.Click += new System.EventHandler(this.BtnIngresar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(323, 130);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 85;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // LbConfirmacionCerrarCaja
            // 
            this.LbConfirmacionCerrarCaja.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConfirmacionCerrarCaja.Location = new System.Drawing.Point(155, 5);
            this.LbConfirmacionCerrarCaja.MaximumSize = new System.Drawing.Size(268, 100);
            this.LbConfirmacionCerrarCaja.Name = "LbConfirmacionCerrarCaja";
            // 
            // 
            // 
            this.LbConfirmacionCerrarCaja.RootElement.MaxSize = new System.Drawing.Size(268, 100);
            this.LbConfirmacionCerrarCaja.Size = new System.Drawing.Size(176, 24);
            this.LbConfirmacionCerrarCaja.TabIndex = 87;
            this.LbConfirmacionCerrarCaja.Text = "{{Mensaje confirmacion}}";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaPaz.Win.Properties.Resources.Counting_Machine;
            this.pictureBox1.Location = new System.Drawing.Point(12, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 132);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmCerrarCaja
            // 
            this.AcceptButton = this.BtnCerrarCaja;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(440, 171);
            this.Controls.Add(this.LbConfirmacionCerrarCaja);
            this.Controls.Add(this.BtnCerrarCaja);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmCerrarCaja";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Cerrar Caja";
            this.Load += new System.EventHandler(this.FrmCerrarCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrarCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbConfirmacionCerrarCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton BtnCerrarCaja;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel LbConfirmacionCerrarCaja;
    }
}