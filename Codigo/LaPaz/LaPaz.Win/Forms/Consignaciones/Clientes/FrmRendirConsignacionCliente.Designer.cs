using LaPaz.Win.Forms.Ventas;
namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class FrmRendirConsignacionCliente
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
            this.metroPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.BtnRecargarNroFactura = new Telerik.WinControls.UI.RadButton();
            this.TxtNroFactura = new Telerik.WinControls.UI.RadTextBox();
            this.TxtFecha = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UcCuentaCorrienteInfo = new LaPaz.Win.Forms.Ventas.UcCuentaCorrienteInfo();
            this.metroPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ChkVuelto = new Telerik.WinControls.UI.RadCheckBox();
            this.ChkImprimir = new Telerik.WinControls.UI.RadCheckBox();
            this.BtnReservarFactura = new Telerik.WinControls.UI.RadButton();
            this.BtnFacturar = new Telerik.WinControls.UI.RadButton();
            this.UcTotalesVenta = new LaPaz.Win.Forms.Ventas.UcTotalesVenta();
            this.UcClienteDetalle = new LaPaz.Win.Forms.Ventas.UcClienteDetalle();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.UcBuscadorConsignacion = new LaPaz.Win.Forms.Consignaciones.Clientes.UcBuscadorConsignacion();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.RPCtaccte = new Telerik.WinControls.UI.RadPanel();
            this.radPanel5 = new Telerik.WinControls.UI.RadPanel();
            this.UcTitulosConsignacionVenta = new LaPaz.Win.Forms.Consignaciones.Clientes.UcTitulosConsignacionVenta();
            this.ucTitulosConsignacionVenta1 = new LaPaz.Win.Forms.Consignaciones.Clientes.UcTitulosConsignacionVenta();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel2)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRecargarNroFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkVuelto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkImprimir)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReservarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFacturar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RPCtaccte)).BeginInit();
            this.RPCtaccte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).BeginInit();
            this.radPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.BtnRecargarNroFactura);
            this.metroPanel2.Controls.Add(this.TxtNroFactura);
            this.metroPanel2.Controls.Add(this.TxtFecha);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Location = new System.Drawing.Point(4, 3);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(791, 131);
            this.metroPanel2.TabIndex = 5;
            // 
            // BtnRecargarNroFactura
            // 
            this.BtnRecargarNroFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecargarNroFactura.Image = global::LaPaz.Win.Properties.Resources.Reload_16x16;
            this.BtnRecargarNroFactura.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRecargarNroFactura.Location = new System.Drawing.Point(650, 50);
            this.BtnRecargarNroFactura.Name = "BtnRecargarNroFactura";
            this.BtnRecargarNroFactura.Size = new System.Drawing.Size(32, 26);
            this.BtnRecargarNroFactura.TabIndex = 3;
            this.BtnRecargarNroFactura.ThemeName = "TelerikMetroBlue";
            this.BtnRecargarNroFactura.Click += new System.EventHandler(this.BtnRecargarNroFactura_Click);
            // 
            // TxtNroFactura
            // 
            this.TxtNroFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroFactura.Location = new System.Drawing.Point(440, 50);
            this.TxtNroFactura.Name = "TxtNroFactura";
            this.TxtNroFactura.Size = new System.Drawing.Size(206, 26);
            this.TxtNroFactura.TabIndex = 6;
            this.TxtNroFactura.TabStop = false;
            this.TxtNroFactura.ThemeName = "TelerikMetroBlue";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(440, 18);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(206, 26);
            this.TxtFecha.TabIndex = 5;
            this.TxtFecha.TabStop = false;
            this.TxtFecha.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(351, 51);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(91, 24);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nro Factura:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(387, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 24);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Fecha:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaPaz.Win.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
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
            this.UcCuentaCorrienteInfo.Montocuota = null;
            this.UcCuentaCorrienteInfo.Name = "UcCuentaCorrienteInfo";
            this.UcCuentaCorrienteInfo.Size = new System.Drawing.Size(121, 406);
            this.UcCuentaCorrienteInfo.SubTotal = null;
            this.UcCuentaCorrienteInfo.TabIndex = 4;
            this.UcCuentaCorrienteInfo.Total = null;
            this.UcCuentaCorrienteInfo.Vencimiento = new System.DateTime(2015, 8, 15, 0, 0, 0, 0);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.ChkVuelto);
            this.metroPanel1.Controls.Add(this.ChkImprimir);
            this.metroPanel1.Controls.Add(this.BtnReservarFactura);
            this.metroPanel1.Controls.Add(this.BtnFacturar);
            this.metroPanel1.Location = new System.Drawing.Point(801, 555);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(344, 80);
            this.metroPanel1.TabIndex = 3;
            // 
            // ChkVuelto
            // 
            this.ChkVuelto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChkVuelto.Location = new System.Drawing.Point(25, 27);
            this.ChkVuelto.Name = "ChkVuelto";
            this.ChkVuelto.Size = new System.Drawing.Size(69, 24);
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
            this.ChkImprimir.Size = new System.Drawing.Size(83, 24);
            this.ChkImprimir.TabIndex = 4;
            this.ChkImprimir.Text = "Imprimir";
            this.ChkImprimir.ThemeName = "TelerikMetroBlue";
            // 
            // BtnReservarFactura
            // 
            this.BtnReservarFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnReservarFactura.Location = new System.Drawing.Point(226, 41);
            this.BtnReservarFactura.Name = "BtnReservarFactura";
            this.BtnReservarFactura.Size = new System.Drawing.Size(103, 30);
            this.BtnReservarFactura.TabIndex = 3;
            this.BtnReservarFactura.Text = "Reservar Factura";
            this.BtnReservarFactura.ThemeName = "TelerikMetroBlue";
            this.BtnReservarFactura.Click += new System.EventHandler(this.BtnReservarFactura_Click);
            // 
            // BtnFacturar
            // 
            this.BtnFacturar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacturar.Location = new System.Drawing.Point(226, 5);
            this.BtnFacturar.Name = "BtnFacturar";
            this.BtnFacturar.Size = new System.Drawing.Size(103, 30);
            this.BtnFacturar.TabIndex = 2;
            this.BtnFacturar.Text = "Facturar";
            this.BtnFacturar.ThemeName = "TelerikMetroBlue";
            this.BtnFacturar.Click += new System.EventHandler(this.BtnRendirConsignacion_Click);
            // 
            // UcTotalesVenta
            // 
            this.UcTotalesVenta.CreditosDevolucion = null;
            this.UcTotalesVenta.CreditosDevolucionDisp = null;
            this.UcTotalesVenta.Descuento = null;
            this.UcTotalesVenta.FaltaPagar = null;
            this.UcTotalesVenta.Location = new System.Drawing.Point(3, 3);
            this.UcTotalesVenta.Name = "UcTotalesVenta";
            this.UcTotalesVenta.Recargo = null;
            this.UcTotalesVenta.Senas = null;
            this.UcTotalesVenta.SenasDisp = null;
            this.UcTotalesVenta.Size = new System.Drawing.Size(338, 406);
            this.UcTotalesVenta.SubTotal = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.UcTotalesVenta.TabIndex = 2;
            this.UcTotalesVenta.TotalPagar = null;
            // 
            // UcClienteDetalle
            // 
            this.UcClienteDetalle.ClienteNombre = "";
            this.UcClienteDetalle.Cuit = "";
            this.UcClienteDetalle.Domicilio = "";
            this.UcClienteDetalle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UcClienteDetalle.FormaPago = "";
            this.UcClienteDetalle.Localidad = "";
            this.UcClienteDetalle.Location = new System.Drawing.Point(4, 2);
            this.UcClienteDetalle.Name = "UcClienteDetalle";
            this.UcClienteDetalle.Provincia = "";
            this.UcClienteDetalle.Size = new System.Drawing.Size(746, 181);
            this.UcClienteDetalle.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.UcBuscadorConsignacion);
            this.radPanel1.Location = new System.Drawing.Point(801, 3);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(483, 131);
            this.radPanel1.TabIndex = 7;
            // 
            // UcBuscadorConsignacion
            // 
            this.UcBuscadorConsignacion.Cuit = "";
            this.UcBuscadorConsignacion.Location = new System.Drawing.Point(6, 4);
            this.UcBuscadorConsignacion.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.UcBuscadorConsignacion.Name = "UcBuscadorConsignacion";
            this.UcBuscadorConsignacion.Size = new System.Drawing.Size(437, 125);
            this.UcBuscadorConsignacion.TabIndex = 0;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.UcClienteDetalle);
            this.radPanel2.Location = new System.Drawing.Point(4, 140);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(791, 187);
            this.radPanel2.TabIndex = 8;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.UcTotalesVenta);
            this.radPanel3.Location = new System.Drawing.Point(801, 140);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(344, 412);
            this.radPanel3.TabIndex = 9;
            // 
            // RPCtaccte
            // 
            this.RPCtaccte.Controls.Add(this.UcCuentaCorrienteInfo);
            this.RPCtaccte.Location = new System.Drawing.Point(1149, 140);
            this.RPCtaccte.Name = "RPCtaccte";
            this.RPCtaccte.Size = new System.Drawing.Size(135, 412);
            this.RPCtaccte.TabIndex = 10;
            this.RPCtaccte.Visible = false;
            // 
            // radPanel5
            // 
            this.radPanel5.Controls.Add(this.UcTitulosConsignacionVenta);
            this.radPanel5.Location = new System.Drawing.Point(4, 329);
            this.radPanel5.Name = "radPanel5";
            this.radPanel5.Size = new System.Drawing.Size(791, 306);
            this.radPanel5.TabIndex = 11;
            // 
            // UcTitulosConsignacionVenta
            // 
            this.UcTitulosConsignacionVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcTitulosConsignacionVenta.Location = new System.Drawing.Point(8, 6);
            this.UcTitulosConsignacionVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UcTitulosConsignacionVenta.Name = "UcTitulosConsignacionVenta";
            this.UcTitulosConsignacionVenta.Size = new System.Drawing.Size(779, 255);
            this.UcTitulosConsignacionVenta.TabIndex = 1;
            // 
            // ucTitulosConsignacionVenta1
            // 
            this.ucTitulosConsignacionVenta1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTitulosConsignacionVenta1.Location = new System.Drawing.Point(0, 0);
            this.ucTitulosConsignacionVenta1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTitulosConsignacionVenta1.Name = "ucTitulosConsignacionVenta1";
            this.ucTitulosConsignacionVenta1.Size = new System.Drawing.Size(667, 236);
            this.ucTitulosConsignacionVenta1.TabIndex = 0;
            // 
            // FrmRendirConsignacionCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1307, 860);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel5);
            this.Controls.Add(this.RPCtaccte);
            this.Controls.Add(this.radPanel3);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmRendirConsignacionCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Venta";
            this.Load += new System.EventHandler(this.FrmRendirConsignacionCliente_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCrearVenta_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel2)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRecargarNroFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChkVuelto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkImprimir)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnReservarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFacturar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RPCtaccte)).EndInit();
            this.RPCtaccte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel5)).EndInit();
            this.radPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UcClienteDetalle UcClienteDetalle;
        private UcTotalesVenta UcTotalesVenta;
        private Telerik.WinControls.UI.RadPanel metroPanel1;
        private Telerik.WinControls.UI.RadCheckBox ChkVuelto;
        private Telerik.WinControls.UI.RadCheckBox ChkImprimir;
        private Telerik.WinControls.UI.RadButton BtnReservarFactura;
        private Telerik.WinControls.UI.RadButton BtnFacturar;
        private UcCuentaCorrienteInfo UcCuentaCorrienteInfo;
        private Telerik.WinControls.UI.RadPanel metroPanel2;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadTextBox TxtNroFactura;
        private Telerik.WinControls.UI.RadTextBox TxtFecha;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadPanel RPCtaccte;
        private Telerik.WinControls.UI.RadPanel radPanel5;
        private Telerik.WinControls.UI.RadButton BtnRecargarNroFactura;
        private UcBuscadorConsignacion UcBuscadorConsignacion;
        private UcTitulosConsignacionVenta ucTitulosConsignacionVenta1;
        private UcTitulosConsignacionVenta UcTitulosConsignacionVenta;

    }
}