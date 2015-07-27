namespace LaPaz.Win.Forms.CierreCaja
{
    partial class FrmAbrirCaja
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAbrirCaja = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.LbConfirmacionAbrirCaja = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrirCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbConfirmacionAbrirCaja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
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
            // BtnAbrirCaja
            // 
            this.BtnAbrirCaja.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAbrirCaja.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAbrirCaja.Location = new System.Drawing.Point(210, 130);
            this.BtnAbrirCaja.Name = "BtnAbrirCaja";
            this.BtnAbrirCaja.Size = new System.Drawing.Size(100, 30);
            this.BtnAbrirCaja.TabIndex = 86;
            this.BtnAbrirCaja.Text = "Abrir";
            this.BtnAbrirCaja.ThemeName = "TelerikMetroBlue";
            this.BtnAbrirCaja.Click += new System.EventHandler(this.BtnIngresar_Click);
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
            // LbConfirmacionAbrirCaja
            // 
            this.LbConfirmacionAbrirCaja.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbConfirmacionAbrirCaja.Location = new System.Drawing.Point(155, 5);
            this.LbConfirmacionAbrirCaja.MaximumSize = new System.Drawing.Size(250, 150);
            this.LbConfirmacionAbrirCaja.Name = "LbConfirmacionAbrirCaja";
            // 
            // 
            // 
            this.LbConfirmacionAbrirCaja.RootElement.MaxSize = new System.Drawing.Size(250, 150);
            this.LbConfirmacionAbrirCaja.RootElement.MinSize = new System.Drawing.Size(0, 0);
            this.LbConfirmacionAbrirCaja.Size = new System.Drawing.Size(176, 24);
            this.LbConfirmacionAbrirCaja.TabIndex = 87;
            this.LbConfirmacionAbrirCaja.Text = "{{Mensaje confirmacion}}";
            // 
            // FrmAbrirCaja
            // 
            this.AcceptButton = this.BtnAbrirCaja;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(440, 171);
            this.Controls.Add(this.LbConfirmacionAbrirCaja);
            this.Controls.Add(this.BtnAbrirCaja);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmAbrirCaja";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Abrir Caja";
            this.Load += new System.EventHandler(this.FrmAbrirCaja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAbrirCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbConfirmacionAbrirCaja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadButton BtnAbrirCaja;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadLabel LbConfirmacionAbrirCaja;
    }
}