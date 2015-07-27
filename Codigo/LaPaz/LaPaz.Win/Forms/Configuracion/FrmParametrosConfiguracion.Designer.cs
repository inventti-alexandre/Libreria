namespace LaPaz.Win.Forms.Configuracion
{
    partial class FrmParametrosConfiguracion
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
            this.components = new System.ComponentModel.Container();
            this.epvConfiguracion = new System.Windows.Forms.ErrorProvider(this.components);
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.txtMaximoImporteVenta = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.txtPorcentajeDescuentoVenta = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.txtNroLineasPorVenta = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epvConfiguracion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximoImporteVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuentoVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroLineasPorVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // epvConfiguracion
            // 
            this.epvConfiguracion.ContainerControl = this;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(41, 118);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(355, 24);
            this.metroLabel1.TabIndex = 62;
            this.metroLabel1.Text = "Porcentaje de Descuento en Venta sin Autorización";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(41, 35);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(307, 24);
            this.radLabel1.TabIndex = 64;
            this.radLabel1.Text = "Maximo Importe de Venta para Cuenta. Cte.";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(41, 299);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 65;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(147, 299);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 66;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // txtMaximoImporteVenta
            // 
            this.txtMaximoImporteVenta.AceptaNegativos = false;
            this.txtMaximoImporteVenta.Location = new System.Drawing.Point(41, 64);
            this.txtMaximoImporteVenta.Name = "txtMaximoImporteVenta";
            this.txtMaximoImporteVenta.Size = new System.Drawing.Size(118, 30);
            this.txtMaximoImporteVenta.TabIndex = 68;
            this.txtMaximoImporteVenta.TabStop = false;
            this.txtMaximoImporteVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPorcentajeDescuentoVenta
            // 
            this.txtPorcentajeDescuentoVenta.AceptaNegativos = false;
            this.txtPorcentajeDescuentoVenta.Location = new System.Drawing.Point(41, 148);
            this.txtPorcentajeDescuentoVenta.Name = "txtPorcentajeDescuentoVenta";
            this.txtPorcentajeDescuentoVenta.Size = new System.Drawing.Size(118, 30);
            this.txtPorcentajeDescuentoVenta.TabIndex = 69;
            this.txtPorcentajeDescuentoVenta.TabStop = false;
            this.txtPorcentajeDescuentoVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(41, 203);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(258, 24);
            this.radLabel2.TabIndex = 70;
            this.radLabel2.Text = "Número máximo de líneas por Venta";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // txtNroLineasPorVenta
            // 
            this.txtNroLineasPorVenta.Location = new System.Drawing.Point(41, 233);
            this.txtNroLineasPorVenta.Name = "txtNroLineasPorVenta";
            this.txtNroLineasPorVenta.Size = new System.Drawing.Size(118, 30);
            this.txtNroLineasPorVenta.TabIndex = 71;
            this.txtNroLineasPorVenta.TabStop = false;
            // 
            // FrmParametrosConfiguracion
            // 
            this.AcceptButton = this.BtnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(426, 357);
            this.Controls.Add(this.txtNroLineasPorVenta);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtPorcentajeDescuentoVenta);
            this.Controls.Add(this.txtMaximoImporteVenta);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.metroLabel1);
            this.Name = "FrmParametrosConfiguracion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parámetros de Configuración";
            this.Load += new System.EventHandler(this.FrmParametrosConfiguracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epvConfiguracion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMaximoImporteVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPorcentajeDescuentoVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNroLineasPorVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider epvConfiguracion;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox txtPorcentajeDescuentoVenta;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox txtMaximoImporteVenta;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox txtNroLineasPorVenta;
    }
}