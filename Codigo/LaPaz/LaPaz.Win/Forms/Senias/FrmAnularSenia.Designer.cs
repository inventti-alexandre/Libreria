namespace LaPaz.Win.Forms.Senias
{
    partial class FrmAnularSenia
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
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnAnular = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.TxtImporte = new Framework.WinForm.Controls.CustomControls.NumericTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(26, 26);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(124, 24);
            this.metroLabel3.TabIndex = 69;
            this.metroLabel3.Text = "Importe a anular:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // BtnAnular
            // 
            this.BtnAnular.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnAnular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAnular.Location = new System.Drawing.Point(112, 69);
            this.BtnAnular.Name = "BtnAnular";
            this.BtnAnular.Size = new System.Drawing.Size(100, 30);
            this.BtnAnular.TabIndex = 2;
            this.BtnAnular.Text = "Anular";
            this.BtnAnular.ThemeName = "TelerikMetroBlue";
            this.BtnAnular.Click += new System.EventHandler(this.BtnAnular_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(218, 69);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 3;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // TxtImporte
            // 
            this.TxtImporte.DecimalNumbers = 2;
            this.TxtImporte.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtImporte.ForeColor = System.Drawing.Color.Black;
            this.TxtImporte.Format = "^(\\-?)(\\d*)(\\,?)(\\d?)(\\d?)$";
            this.TxtImporte.HasNegatives = true;
            this.TxtImporte.Location = new System.Drawing.Point(168, 21);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(150, 31);
            this.TxtImporte.TabIndex = 70;
            this.TxtImporte.TabStop = false;
            this.TxtImporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtImporte.ThemeName = "TelerikMetroBlue";
            // 
            // FrmAnularSenia
            // 
            this.AcceptButton = this.BtnAnular;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(354, 128);
            this.Controls.Add(this.TxtImporte);
            this.Controls.Add(this.BtnAnular);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.metroLabel3);
            this.Name = "FrmAnularSenia";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Anular Seña de Proveedor";
            this.Load += new System.EventHandler(this.FrmAnularSenia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAnular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadButton BtnAnular;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Framework.WinForm.Controls.CustomControls.NumericTextBox TxtImporte;
    }
}
