namespace LaPaz.Win.Forms.OrdenesPagos
{
    partial class FrmDetalleEliminarDetalle
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
            this.DtpFechaPago = new Telerik.WinControls.UI.RadDateTimePicker();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.BtnEliminar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.TxtEfectivo = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtImportePagado = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEfectivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImportePagado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // DtpFechaPago
            // 
            this.DtpFechaPago.Enabled = false;
            this.DtpFechaPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaPago.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaPago.Location = new System.Drawing.Point(142, 17);
            this.DtpFechaPago.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaPago.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaPago.Name = "DtpFechaPago";
            this.DtpFechaPago.NullableValue = new System.DateTime(2014, 11, 25, 20, 7, 31, 826);
            this.DtpFechaPago.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaPago.Size = new System.Drawing.Size(100, 29);
            this.DtpFechaPago.TabIndex = 1;
            this.DtpFechaPago.TabStop = false;
            this.DtpFechaPago.Text = "25/11/2014";
            this.DtpFechaPago.ThemeName = "TelerikMetroBlue";
            this.DtpFechaPago.Value = new System.DateTime(2014, 11, 25, 20, 7, 31, 826);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(12, 19);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 24);
            this.metroLabel4.TabIndex = 103;
            this.metroLabel4.Text = "Fecha de Pago:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnEliminar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminar.Location = new System.Drawing.Point(101, 153);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(100, 30);
            this.BtnEliminar.TabIndex = 8;
            this.BtnEliminar.Text = "Anular";
            this.BtnEliminar.ThemeName = "TelerikMetroBlue";
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(12, 61);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(65, 24);
            this.radLabel2.TabIndex = 100;
            this.radLabel2.Text = "Importe:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(214, 153);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 9;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // TxtEfectivo
            // 
            this.TxtEfectivo.AceptaNegativos = false;
            this.TxtEfectivo.Enabled = false;
            this.TxtEfectivo.Location = new System.Drawing.Point(142, 100);
            this.TxtEfectivo.Name = "TxtEfectivo";
            this.TxtEfectivo.Size = new System.Drawing.Size(170, 31);
            this.TxtEfectivo.TabIndex = 3;
            this.TxtEfectivo.TabStop = false;
            this.TxtEfectivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtEfectivo.ThemeName = "TelerikMetroBlue";
            // 
            // TxtImportePagado
            // 
            this.TxtImportePagado.AceptaNegativos = false;
            this.TxtImportePagado.Enabled = false;
            this.TxtImportePagado.Location = new System.Drawing.Point(142, 58);
            this.TxtImportePagado.Name = "TxtImportePagado";
            this.TxtImportePagado.Size = new System.Drawing.Size(170, 31);
            this.TxtImportePagado.TabIndex = 2;
            this.TxtImportePagado.TabStop = false;
            this.TxtImportePagado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtImportePagado.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(12, 103);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(64, 24);
            this.radLabel5.TabIndex = 92;
            this.radLabel5.Text = "Efectivo:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // FrmDetalleEliminarDetalle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 204);
            this.Controls.Add(this.DtpFechaPago);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.TxtEfectivo);
            this.Controls.Add(this.TxtImportePagado);
            this.Controls.Add(this.radLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDetalleEliminarDetalle";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Pago";
            this.Load += new System.EventHandler(this.FrmCrearEditarDetalle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnEliminar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEfectivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImportePagado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnEliminar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtEfectivo;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtImportePagado;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaPago;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
    }
}