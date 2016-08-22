namespace LaPaz.Win.Forms.Presupuesto
{
    partial class FrmFacturarPresupuesto
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
            this.ucBuscadorPresupuesto = new LaPaz.Win.Forms.Presupuesto.ucBuscadorPresupuesto();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.UcClienteDetalle = new LaPaz.Win.Forms.Ventas.UcClienteDetalle();
            this.radPanel4 = new Telerik.WinControls.UI.RadPanel();
            this.ucTitulosPresupuesto = new LaPaz.Win.Forms.Presupuesto.UcTitulosPresupuesto();
            this.LblFechaPresupuesto = new System.Windows.Forms.Label();
            this.RPCtaccte = new Telerik.WinControls.UI.RadPanel();
            this.UcCuentaCorrienteInfo = new LaPaz.Win.Forms.Ventas.UcCuentaCorrienteInfo();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.UcTotalesVenta = new LaPaz.Win.Forms.Ventas.UcTotalesVenta();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ChkVuelto = new Telerik.WinControls.UI.RadCheckBox();
            this.ChkImprimir = new Telerik.WinControls.UI.RadCheckBox();
            this.BtnReservarFactura = new Telerik.WinControls.UI.RadButton();
            this.BtnFacturar = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).BeginInit();
            this.radPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPCtaccte)).BeginInit();
            this.RPCtaccte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkVuelto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReservarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBuscadorPresupuesto
            // 
            this.ucBuscadorPresupuesto.Location = new System.Drawing.Point(3, 3);
            this.ucBuscadorPresupuesto.Name = "ucBuscadorPresupuesto";
            this.ucBuscadorPresupuesto.Size = new System.Drawing.Size(588, 118);
            this.ucBuscadorPresupuesto.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucBuscadorPresupuesto);
            this.radPanel1.Location = new System.Drawing.Point(871, 15);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(612, 144);
            this.radPanel1.TabIndex = 1;
            this.radPanel1.Text = "radPanel1";
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.pictureBox1);
            this.radPanel2.Location = new System.Drawing.Point(12, 12);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(853, 144);
            this.radPanel2.TabIndex = 2;
            this.radPanel2.Text = "radPanel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaPaz.Win.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 90);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.UcClienteDetalle);
            this.radPanel3.Location = new System.Drawing.Point(12, 163);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(853, 164);
            this.radPanel3.TabIndex = 3;
            // 
            // UcClienteDetalle
            // 
            this.UcClienteDetalle.ClienteNombre = "";
            this.UcClienteDetalle.Cuit = "";
            this.UcClienteDetalle.Domicilio = "";
            this.UcClienteDetalle.FormaPago = "";
            this.UcClienteDetalle.Localidad = "";
            this.UcClienteDetalle.Location = new System.Drawing.Point(8, 4);
            this.UcClienteDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcClienteDetalle.Name = "UcClienteDetalle";
            this.UcClienteDetalle.Provincia = "";
            this.UcClienteDetalle.Size = new System.Drawing.Size(841, 138);
            this.UcClienteDetalle.TabIndex = 0;
            // 
            // radPanel4
            // 
            this.radPanel4.Controls.Add(this.ucTitulosPresupuesto);
            this.radPanel4.Controls.Add(this.LblFechaPresupuesto);
            this.radPanel4.Location = new System.Drawing.Point(12, 334);
            this.radPanel4.Name = "radPanel4";
            this.radPanel4.Size = new System.Drawing.Size(853, 404);
            this.radPanel4.TabIndex = 4;
            this.radPanel4.Text = "Libros a Facturar";
            // 
            // ucTitulosPresupuesto
            // 
            this.ucTitulosPresupuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTitulosPresupuesto.Location = new System.Drawing.Point(8, 18);
            this.ucTitulosPresupuesto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTitulosPresupuesto.Name = "ucTitulosPresupuesto";
            this.ucTitulosPresupuesto.Size = new System.Drawing.Size(823, 236);
            this.ucTitulosPresupuesto.TabIndex = 4;
            // 
            // LblFechaPresupuesto
            // 
            this.LblFechaPresupuesto.AutoSize = true;
            this.LblFechaPresupuesto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFechaPresupuesto.Location = new System.Drawing.Point(3, 368);
            this.LblFechaPresupuesto.Name = "LblFechaPresupuesto";
            this.LblFechaPresupuesto.Size = new System.Drawing.Size(200, 25);
            this.LblFechaPresupuesto.TabIndex = 3;
            this.LblFechaPresupuesto.Text = "Fecha de Presupuesto:";
            // 
            // RPCtaccte
            // 
            this.RPCtaccte.Controls.Add(this.UcCuentaCorrienteInfo);
            this.RPCtaccte.Location = new System.Drawing.Point(1348, 173);
            this.RPCtaccte.Name = "RPCtaccte";
            this.RPCtaccte.Size = new System.Drawing.Size(135, 568);
            this.RPCtaccte.TabIndex = 13;
            this.RPCtaccte.Visible = false;
            // 
            // UcCuentaCorrienteInfo
            // 
            this.UcCuentaCorrienteInfo.Adeuda = null;
            this.UcCuentaCorrienteInfo.Anticipo = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.UcCuentaCorrienteInfo.Cuotas = 1;
            this.UcCuentaCorrienteInfo.Location = new System.Drawing.Point(2, 3);
            this.UcCuentaCorrienteInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcCuentaCorrienteInfo.Montocuota = null;
            this.UcCuentaCorrienteInfo.Name = "UcCuentaCorrienteInfo";
            this.UcCuentaCorrienteInfo.Size = new System.Drawing.Size(121, 483);
            this.UcCuentaCorrienteInfo.SubTotal = null;
            this.UcCuentaCorrienteInfo.TabIndex = 4;
            this.UcCuentaCorrienteInfo.Total = null;
            this.UcCuentaCorrienteInfo.Vencimiento = new System.DateTime(2016, 9, 9, 0, 0, 0, 0);
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.UcTotalesVenta);
            this.radPanel5.Location = new System.Drawing.Point(874, 170);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(468, 489);
            this.radPanel5.TabIndex = 12;
            // 
            // UcTotalesVenta
            // 
            this.UcTotalesVenta.CreditosDevolucion = null;
            this.UcTotalesVenta.CreditosDevolucionDisp = null;
            this.UcTotalesVenta.Descuento = null;
            this.UcTotalesVenta.FaltaPagar = null;
            this.UcTotalesVenta.Location = new System.Drawing.Point(3, 3);
            this.UcTotalesVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcTotalesVenta.Name = "UcTotalesVenta";
            this.UcTotalesVenta.Recargo = null;
            this.UcTotalesVenta.Senas = null;
            this.UcTotalesVenta.SenasDisp = null;
            this.UcTotalesVenta.Size = new System.Drawing.Size(452, 481);
            this.UcTotalesVenta.SubTotal = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.UcTotalesVenta.TabIndex = 2;
            this.UcTotalesVenta.TotalPagar = null;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ChkVuelto);
            this.metroPanel1.Controls.Add(this.ChkImprimir);
            this.metroPanel1.Controls.Add(this.BtnReservarFactura);
            this.metroPanel1.Controls.Add(this.BtnFacturar);
            this.metroPanel1.Location = new System.Drawing.Point(874, 661);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(468, 80);
            this.metroPanel1.TabIndex = 11;
            // 
            // ChkVuelto
            // 
            this.ChkVuelto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkVuelto.Location = new System.Drawing.Point(25, 27);
            this.ChkVuelto.Name = "ChkVuelto";
            this.ChkVuelto.Size = new System.Drawing.Size(81, 29);
            this.ChkVuelto.TabIndex = 5;
            this.ChkVuelto.Text = "Vuelto";
            this.ChkVuelto.ThemeName = "TelerikMetroBlue";
            this.ChkVuelto.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            // 
            // ChkImprimir
            // 
            this.ChkImprimir.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkImprimir.Location = new System.Drawing.Point(25, 3);
            this.ChkImprimir.Name = "ChkImprimir";
            this.ChkImprimir.Size = new System.Drawing.Size(98, 29);
            this.ChkImprimir.TabIndex = 4;
            this.ChkImprimir.Text = "Imprimir";
            this.ChkImprimir.ThemeName = "TelerikMetroBlue";
            // 
            // BtnReservarFactura
            // 
            this.BtnReservarFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservarFactura.Location = new System.Drawing.Point(271, 39);
            this.BtnReservarFactura.Name = "BtnReservarFactura";
            this.BtnReservarFactura.Size = new System.Drawing.Size(186, 30);
            this.BtnReservarFactura.TabIndex = 3;
            this.BtnReservarFactura.Text = "Reservar Factura";
            this.BtnReservarFactura.ThemeName = "TelerikMetroBlue";
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.Location = new System.Drawing.Point(271, 3);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(186, 30);
            this.BtnFacturar.TabIndex = 2;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.ThemeName = "TelerikMetroBlue";
            // 
            // FrmFacturarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 750);
            this.ControlBox = false;
            this.Controls.Add(this.RPCtaccte);
            this.Controls.Add(this.radPanel5);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.radPanel4);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Name = "FrmFacturarPresupuesto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Facturar Presupuesto";
            this.Load += new System.EventHandler(this.FrmFacturarPresupuesto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel4)).EndInit();
            this.radPanel4.ResumeLayout(false);
            this.radPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPCtaccte)).EndInit();
            this.RPCtaccte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkVuelto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReservarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ucBuscadorPresupuesto ucBuscadorPresupuesto;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel radPanel4;
        private System.Windows.Forms.Label LblFechaPresupuesto;
        private Ventas.UcClienteDetalle UcClienteDetalle;
        private Telerik.WinControls.UI.RadPanel RPCtaccte;
        private Ventas.UcCuentaCorrienteInfo UcCuentaCorrienteInfo;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Ventas.UcTotalesVenta UcTotalesVenta;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadCheckBox ChkVuelto;
        private Telerik.WinControls.UI.RadCheckBox ChkImprimir;
        private Telerik.WinControls.UI.RadButton BtnReservarFactura;
        private Telerik.WinControls.UI.RadButton BtnFacturar;
        private UcTitulosPresupuesto ucTitulosPresupuesto;
    }
}