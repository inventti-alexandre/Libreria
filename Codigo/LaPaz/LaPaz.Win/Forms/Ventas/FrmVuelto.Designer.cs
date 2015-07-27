namespace LaPaz.Win.Forms.Ventas
{
    partial class FrmVuelto
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnCerrar = new Telerik.WinControls.UI.RadButton();
            this.DTxtPaga = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.DtxtVuelto = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.DtxtAPagar = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTxtPaga)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtxtVuelto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtxtAPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(39, 31);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(68, 25);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "A Pagar:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(39, 74);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(47, 25);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Paga:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(39, 125);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(59, 25);
            this.radLabel3.TabIndex = 2;
            this.radLabel3.Text = "Vuelto:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCerrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCerrar.Location = new System.Drawing.Point(173, 199);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(130, 33);
            this.BtnCerrar.TabIndex = 3;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.ThemeName = "TelerikMetroBlue";
            // 
            // DTxtPaga
            // 
            this.DTxtPaga.AceptaNegativos = false;
            this.DTxtPaga.Location = new System.Drawing.Point(113, 74);
            this.DTxtPaga.Name = "DTxtPaga";
            this.DTxtPaga.Size = new System.Drawing.Size(190, 30);
            this.DTxtPaga.TabIndex = 1;
            this.DTxtPaga.TabStop = false;
            this.DTxtPaga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DTxtPaga.TextChanged += new System.EventHandler(this.DTxtPaga_TextChanged);
            this.DTxtPaga.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DTxtPaga_KeyDown);
            // 
            // DtxtVuelto
            // 
            this.DtxtVuelto.AceptaNegativos = false;
            this.DtxtVuelto.Location = new System.Drawing.Point(113, 120);
            this.DtxtVuelto.Name = "DtxtVuelto";
            this.DtxtVuelto.Size = new System.Drawing.Size(190, 30);
            this.DtxtVuelto.TabIndex = 2;
            this.DtxtVuelto.TabStop = false;
            this.DtxtVuelto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DtxtVuelto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.DtxtVuelto_KeyUp);
            // 
            // DtxtAPagar
            // 
            this.DtxtAPagar.AceptaNegativos = false;
            this.DtxtAPagar.Location = new System.Drawing.Point(113, 31);
            this.DtxtAPagar.Name = "DtxtAPagar";
            this.DtxtAPagar.Size = new System.Drawing.Size(190, 30);
            this.DtxtAPagar.TabIndex = 4;
            this.DtxtAPagar.TabStop = false;
            this.DtxtAPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DtxtAPagar.TextChanged += new System.EventHandler(this.DtxtAPagar_TextChanged);
            this.DtxtAPagar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DtxtAPagar_KeyDown);
            // 
            // FrmVuelto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCerrar;
            this.ClientSize = new System.Drawing.Size(333, 257);
            this.Controls.Add(this.DtxtAPagar);
            this.Controls.Add(this.DtxtVuelto);
            this.Controls.Add(this.DTxtPaga);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "FrmVuelto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Vuelto";
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTxtPaga)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtxtVuelto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtxtAPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadButton BtnCerrar;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox DTxtPaga;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox DtxtVuelto;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox DtxtAPagar;
    }
}