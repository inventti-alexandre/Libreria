namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class FrmModificarConsignacionVenta
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
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnAceptar = new Telerik.WinControls.UI.RadButton();
            this.TxtPrecioVenta = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtPrecioActual = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtPrecioConsignado = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCntDevuelta = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtCntVendida = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtCntConsignada = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.TxtCntPropia = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.TxtDescuento = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAceptar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioConsignado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntDevuelta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntVendida)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntConsignada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntPropia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(394, 241);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(103, 30);
            this.BtnCancelar.TabIndex = 10;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptar.Location = new System.Drawing.Point(258, 241);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(103, 30);
            this.BtnAceptar.TabIndex = 9;
            this.BtnAceptar.Text = "Aceptar";
            this.BtnAceptar.ThemeName = "TelerikMetroBlue";
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // TxtPrecioVenta
            // 
            this.TxtPrecioVenta.AceptaNegativos = false;
            this.TxtPrecioVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioVenta.Location = new System.Drawing.Point(151, 183);
            this.TxtPrecioVenta.Name = "TxtPrecioVenta";
            this.TxtPrecioVenta.Size = new System.Drawing.Size(100, 26);
            this.TxtPrecioVenta.TabIndex = 8;
            this.TxtPrecioVenta.TabStop = false;
            this.TxtPrecioVenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioVenta.ThemeName = "TelerikMetroBlue";
            this.TxtPrecioVenta.TextChanged += new System.EventHandler(this.TxtPrecioVenta_TextChanged);
            this.TxtPrecioVenta.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtPrecioVenta_KeyUp);
            // 
            // TxtPrecioActual
            // 
            this.TxtPrecioActual.AceptaNegativos = false;
            this.TxtPrecioActual.Enabled = false;
            this.TxtPrecioActual.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioActual.Location = new System.Drawing.Point(369, 133);
            this.TxtPrecioActual.Name = "TxtPrecioActual";
            this.TxtPrecioActual.Size = new System.Drawing.Size(100, 26);
            this.TxtPrecioActual.TabIndex = 7;
            this.TxtPrecioActual.TabStop = false;
            this.TxtPrecioActual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioActual.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPrecioConsignado
            // 
            this.TxtPrecioConsignado.AceptaNegativos = false;
            this.TxtPrecioConsignado.Enabled = false;
            this.TxtPrecioConsignado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrecioConsignado.Location = new System.Drawing.Point(151, 133);
            this.TxtPrecioConsignado.Name = "TxtPrecioConsignado";
            this.TxtPrecioConsignado.Size = new System.Drawing.Size(100, 26);
            this.TxtPrecioConsignado.TabIndex = 6;
            this.TxtPrecioConsignado.TabStop = false;
            this.TxtPrecioConsignado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPrecioConsignado.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(12, 185);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(97, 24);
            this.radLabel7.TabIndex = 3;
            this.radLabel7.Text = "Precio Venta:";
            this.radLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCntDevuelta
            // 
            this.TxtCntDevuelta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCntDevuelta.Location = new System.Drawing.Point(369, 71);
            this.TxtCntDevuelta.Name = "TxtCntDevuelta";
            this.TxtCntDevuelta.Size = new System.Drawing.Size(100, 26);
            this.TxtCntDevuelta.TabIndex = 5;
            this.TxtCntDevuelta.TabStop = false;
            this.TxtCntDevuelta.ThemeName = "TelerikMetroBlue";
            this.TxtCntDevuelta.TextChanged += new System.EventHandler(this.TxtCntDevuelta_TextChanged);
            // 
            // TxtCntVendida
            // 
            this.TxtCntVendida.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCntVendida.Location = new System.Drawing.Point(118, 71);
            this.TxtCntVendida.Name = "TxtCntVendida";
            this.TxtCntVendida.Size = new System.Drawing.Size(100, 26);
            this.TxtCntVendida.TabIndex = 4;
            this.TxtCntVendida.TabStop = false;
            this.TxtCntVendida.ThemeName = "TelerikMetroBlue";
            this.TxtCntVendida.TextChanged += new System.EventHandler(this.TxtCntVendida_TextChanged);
            // 
            // TxtCntConsignada
            // 
            this.TxtCntConsignada.Enabled = false;
            this.TxtCntConsignada.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCntConsignada.Location = new System.Drawing.Point(369, 27);
            this.TxtCntConsignada.Name = "TxtCntConsignada";
            this.TxtCntConsignada.Size = new System.Drawing.Size(100, 26);
            this.TxtCntConsignada.TabIndex = 4;
            this.TxtCntConsignada.TabStop = false;
            this.TxtCntConsignada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCntConsignada.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCntPropia
            // 
            this.TxtCntPropia.Enabled = false;
            this.TxtCntPropia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCntPropia.Location = new System.Drawing.Point(118, 27);
            this.TxtCntPropia.Name = "TxtCntPropia";
            this.TxtCntPropia.Size = new System.Drawing.Size(100, 26);
            this.TxtCntPropia.TabIndex = 3;
            this.TxtCntPropia.TabStop = false;
            this.TxtCntPropia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCntPropia.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(263, 133);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(100, 24);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "Precio Actual:";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(12, 133);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(139, 24);
            this.radLabel5.TabIndex = 2;
            this.radLabel5.Text = "Precio Consignado:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(239, 71);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(110, 24);
            this.radLabel4.TabIndex = 1;
            this.radLabel4.Text = "Cant. Devuelta:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(12, 71);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(106, 24);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Cant. Vendida:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(239, 27);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(130, 24);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Cant. Consignada:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(12, 28);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(94, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Cant. Propia:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radPanel1
            // 
            this.radPanel1.Location = new System.Drawing.Point(4, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(495, 101);
            this.radPanel1.TabIndex = 11;
            this.radPanel1.ThemeName = "TelerikMetroBlue";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.TxtDescuento);
            this.radPanel2.Controls.Add(this.radLabel8);
            this.radPanel2.Location = new System.Drawing.Point(4, 119);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(495, 101);
            this.radPanel2.TabIndex = 12;
            this.radPanel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtDescuento
            // 
            this.TxtDescuento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDescuento.Location = new System.Drawing.Point(365, 62);
            this.TxtDescuento.Name = "TxtDescuento";
            this.TxtDescuento.Size = new System.Drawing.Size(100, 26);
            this.TxtDescuento.TabIndex = 5;
            this.TxtDescuento.TabStop = false;
            this.TxtDescuento.ThemeName = "TelerikMetroBlue";
            this.TxtDescuento.TextChanged += new System.EventHandler(this.TxtDescuento_TextChanged);
            // 
            // radLabel8
            // 
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(259, 64);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(83, 24);
            this.radLabel8.TabIndex = 3;
            this.radLabel8.Text = "Descuento:";
            this.radLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // FrmModificarConsignacionVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 283);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptar);
            this.Controls.Add(this.TxtPrecioVenta);
            this.Controls.Add(this.TxtPrecioActual);
            this.Controls.Add(this.TxtPrecioConsignado);
            this.Controls.Add(this.radLabel7);
            this.Controls.Add(this.TxtCntDevuelta);
            this.Controls.Add(this.TxtCntVendida);
            this.Controls.Add(this.TxtCntConsignada);
            this.Controls.Add(this.TxtCntPropia);
            this.Controls.Add(this.radLabel6);
            this.Controls.Add(this.radLabel5);
            this.Controls.Add(this.radLabel4);
            this.Controls.Add(this.radLabel3);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FrmModificarConsignacionVenta";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Modificar cantidades y precio";
            this.Load += new System.EventHandler(this.FrmModificarConsignacionVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAceptar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPrecioConsignado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntDevuelta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntVendida)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntConsignada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCntPropia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            this.radPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescuento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCntPropia;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCntConsignada;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCntVendida;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtCntDevuelta;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioConsignado;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioActual;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtPrecioVenta;
        private Telerik.WinControls.UI.RadButton BtnAceptar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox TxtDescuento;
        private Telerik.WinControls.UI.RadLabel radLabel8;
    }
}