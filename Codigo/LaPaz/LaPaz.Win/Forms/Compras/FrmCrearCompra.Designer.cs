using Framework.WinForm.Comun.Notification;

namespace LaPaz.Win.Forms.Compras
{
    partial class FrmCrearCompra
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.ucTitulosCompra = new LaPaz.Win.Forms.Compras.UcTitulosCompra();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.ucBuscadorProveedor = new LaPaz.Win.Forms.Compras.UcBuscadorProveedor();
            this.ucTipoCompra = new LaPaz.Win.Forms.Compras.UcTipoCompra();
            this.DtpFechaEmision = new Telerik.WinControls.UI.RadDateTimePicker();
            this.RpFecha = new Telerik.WinControls.UI.RadPanel();
            this.RpRemito = new Telerik.WinControls.UI.RadPanel();
            this.TxtRemito2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtRemito1 = new Telerik.WinControls.UI.RadTextBox();
            this.RpProveedor = new Telerik.WinControls.UI.RadPanel();
            this.RpFactura = new Telerik.WinControls.UI.RadPanel();
            this.DdlFacturaTipo = new Telerik.WinControls.UI.RadDropDownList();
            this.TxtFactura2 = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtFactura1 = new Telerik.WinControls.UI.RadTextBox();
            this.RpFechaVencimiento = new Telerik.WinControls.UI.RadPanel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFechaVencimiento = new Telerik.WinControls.UI.RadDateTimePicker();
            this.TxtObservaciones = new Telerik.WinControls.UI.RadTextBox();
            this.RpObservaciones = new Telerik.WinControls.UI.RadPanel();
            this.ucCuentaCorrienteCompra = new LaPaz.Win.Forms.Compras.UcCuentaCorrienteCompra();
            this.ucTotalesCompraSeña1 = new LaPaz.Win.Forms.Compras.UcTotalesCompraSeña();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaEmision)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpFecha)).BeginInit();
            this.RpFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RpRemito)).BeginInit();
            this.RpRemito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRemito2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRemito1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpProveedor)).BeginInit();
            this.RpProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RpFactura)).BeginInit();
            this.RpFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DdlFacturaTipo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFactura2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFactura1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpFechaVencimiento)).BeginInit();
            this.RpFechaVencimiento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpObservaciones)).BeginInit();
            this.RpObservaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucTitulosCompra
            // 
            this.ucTitulosCompra.Location = new System.Drawing.Point(12, 192);
            this.ucTitulosCompra.Name = "ucTitulosCompra";
            this.ucTitulosCompra.Size = new System.Drawing.Size(764, 227);
            this.ucTitulosCompra.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(227, 455);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 29);
            this.BtnGuardar.TabIndex = 5;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // ucBuscadorProveedor
            // 
            this.ucBuscadorProveedor.Location = new System.Drawing.Point(3, 18);
            this.ucBuscadorProveedor.Name = "ucBuscadorProveedor";
            this.ucBuscadorProveedor.Size = new System.Drawing.Size(755, 44);
            this.ucBuscadorProveedor.TabIndex = 6;
            // 
            // ucTipoCompra
            // 
            this.ucTipoCompra.Location = new System.Drawing.Point(12, 12);
            this.ucTipoCompra.Name = "ucTipoCompra";
            this.ucTipoCompra.Size = new System.Drawing.Size(764, 38);
            this.ucTipoCompra.TabIndex = 8;
            // 
            // DtpFechaEmision
            // 
            this.DtpFechaEmision.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaEmision.Location = new System.Drawing.Point(10, 18);
            this.DtpFechaEmision.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaEmision.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaEmision.Name = "DtpFechaEmision";
            this.DtpFechaEmision.NullableValue = new System.DateTime(2014, 11, 25, 0, 0, 0, 0);
            this.DtpFechaEmision.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaEmision.Size = new System.Drawing.Size(130, 29);
            this.DtpFechaEmision.TabIndex = 9;
            this.DtpFechaEmision.TabStop = false;
            this.DtpFechaEmision.Text = "25/11/2014";
            this.DtpFechaEmision.ThemeName = "TelerikMetroBlue";
            this.DtpFechaEmision.Value = new System.DateTime(2014, 11, 25, 0, 0, 0, 0);
            // 
            // RpFecha
            // 
            this.RpFecha.Controls.Add(this.DtpFechaEmision);
            this.RpFecha.Location = new System.Drawing.Point(12, 56);
            this.RpFecha.Name = "RpFecha";
            this.RpFecha.Size = new System.Drawing.Size(150, 53);
            this.RpFecha.TabIndex = 10;
            this.RpFecha.Text = "Fecha emisión:";
            this.RpFecha.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RpFecha.ThemeName = "TelerikMetroBlue";
            // 
            // RpRemito
            // 
            this.RpRemito.Controls.Add(this.TxtRemito2);
            this.RpRemito.Controls.Add(this.radLabel1);
            this.RpRemito.Controls.Add(this.TxtRemito1);
            this.RpRemito.Location = new System.Drawing.Point(168, 56);
            this.RpRemito.Name = "RpRemito";
            this.RpRemito.Size = new System.Drawing.Size(301, 53);
            this.RpRemito.TabIndex = 11;
            this.RpRemito.Text = "Remito:";
            this.RpRemito.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RpRemito.ThemeName = "TelerikMetroBlue";
            // 
            // TxtRemito2
            // 
            this.TxtRemito2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRemito2.Location = new System.Drawing.Point(130, 21);
            this.TxtRemito2.MaxLength = 9;
            this.TxtRemito2.Name = "TxtRemito2";
            this.TxtRemito2.Size = new System.Drawing.Size(157, 26);
            this.TxtRemito2.TabIndex = 1;
            this.TxtRemito2.TabStop = false;
            this.TxtRemito2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 23);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(37, 24);
            this.radLabel1.TabIndex = 1;
            this.radLabel1.Text = "Nro:";
            // 
            // TxtRemito1
            // 
            this.TxtRemito1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRemito1.Location = new System.Drawing.Point(51, 21);
            this.TxtRemito1.MaxLength = 4;
            this.TxtRemito1.Name = "TxtRemito1";
            this.TxtRemito1.Size = new System.Drawing.Size(73, 26);
            this.TxtRemito1.TabIndex = 0;
            this.TxtRemito1.TabStop = false;
            this.TxtRemito1.ThemeName = "TelerikMetroBlue";
            this.TxtRemito1.TextChanged += new System.EventHandler(this.TxtRemito1_TextChanged);
            // 
            // RpProveedor
            // 
            this.RpProveedor.Controls.Add(this.ucBuscadorProveedor);
            this.RpProveedor.Location = new System.Drawing.Point(12, 115);
            this.RpProveedor.Name = "RpProveedor";
            this.RpProveedor.Size = new System.Drawing.Size(764, 74);
            this.RpProveedor.TabIndex = 12;
            this.RpProveedor.Text = "Proveedor:";
            this.RpProveedor.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RpProveedor.ThemeName = "TelerikMetroBlue";
            // 
            // RpFactura
            // 
            this.RpFactura.Controls.Add(this.DdlFacturaTipo);
            this.RpFactura.Controls.Add(this.TxtFactura2);
            this.RpFactura.Controls.Add(this.radLabel2);
            this.RpFactura.Controls.Add(this.TxtFactura1);
            this.RpFactura.Location = new System.Drawing.Point(475, 56);
            this.RpFactura.Name = "RpFactura";
            this.RpFactura.Size = new System.Drawing.Size(301, 53);
            this.RpFactura.TabIndex = 12;
            this.RpFactura.Text = "Factura:";
            this.RpFactura.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RpFactura.ThemeName = "TelerikMetroBlue";
            // 
            // DdlFacturaTipo
            // 
            this.DdlFacturaTipo.DropDownAnimationEnabled = true;
            this.DdlFacturaTipo.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.DdlFacturaTipo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "A";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "B";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "C";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "X";
            radListDataItem4.TextWrap = true;
            this.DdlFacturaTipo.Items.Add(radListDataItem1);
            this.DdlFacturaTipo.Items.Add(radListDataItem2);
            this.DdlFacturaTipo.Items.Add(radListDataItem3);
            this.DdlFacturaTipo.Items.Add(radListDataItem4);
            this.DdlFacturaTipo.Location = new System.Drawing.Point(259, 21);
            this.DdlFacturaTipo.MaxDropDownItems = 0;
            this.DdlFacturaTipo.Name = "DdlFacturaTipo";
            this.DdlFacturaTipo.ShowImageInEditorArea = true;
            this.DdlFacturaTipo.Size = new System.Drawing.Size(36, 27);
            this.DdlFacturaTipo.TabIndex = 2;
            this.DdlFacturaTipo.ThemeName = "TelerikMetroBlue";
            // 
            // TxtFactura2
            // 
            this.TxtFactura2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactura2.Location = new System.Drawing.Point(114, 21);
            this.TxtFactura2.MaxLength = 9;
            this.TxtFactura2.Name = "TxtFactura2";
            this.TxtFactura2.Size = new System.Drawing.Size(138, 26);
            this.TxtFactura2.TabIndex = 1;
            this.TxtFactura2.TabStop = false;
            this.TxtFactura2.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(8, 23);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(37, 24);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Nro:";
            // 
            // TxtFactura1
            // 
            this.TxtFactura1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFactura1.Location = new System.Drawing.Point(51, 21);
            this.TxtFactura1.MaxLength = 4;
            this.TxtFactura1.Name = "TxtFactura1";
            this.TxtFactura1.Size = new System.Drawing.Size(57, 26);
            this.TxtFactura1.TabIndex = 0;
            this.TxtFactura1.TabStop = false;
            this.TxtFactura1.ThemeName = "TelerikMetroBlue";
            this.TxtFactura1.TextChanged += new System.EventHandler(this.TxtFactura1_TextChanged);
            // 
            // RpFechaVencimiento
            // 
            this.RpFechaVencimiento.Controls.Add(this.radLabel3);
            this.RpFechaVencimiento.Controls.Add(this.DtpFechaVencimiento);
            this.RpFechaVencimiento.Location = new System.Drawing.Point(475, 56);
            this.RpFechaVencimiento.Name = "RpFechaVencimiento";
            this.RpFechaVencimiento.Size = new System.Drawing.Size(298, 50);
            this.RpFechaVencimiento.TabIndex = 11;
            this.RpFechaVencimiento.Text = "Consignaciones:";
            this.RpFechaVencimiento.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.RpFechaVencimiento.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(3, 20);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(96, 24);
            this.radLabel3.TabIndex = 10;
            this.radLabel3.Text = "Vencimiento:";
            // 
            // DtpFechaVencimiento
            // 
            this.DtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVencimiento.Location = new System.Drawing.Point(105, 18);
            this.DtpFechaVencimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaVencimiento.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            this.DtpFechaVencimiento.NullableValue = new System.DateTime(2014, 11, 25, 0, 0, 0, 0);
            this.DtpFechaVencimiento.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaVencimiento.Size = new System.Drawing.Size(130, 29);
            this.DtpFechaVencimiento.TabIndex = 9;
            this.DtpFechaVencimiento.TabStop = false;
            this.DtpFechaVencimiento.Text = "25/11/2014";
            this.DtpFechaVencimiento.ThemeName = "TelerikMetroBlue";
            this.DtpFechaVencimiento.Value = new System.DateTime(2014, 11, 25, 0, 0, 0, 0);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Location = new System.Drawing.Point(14, 21);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            // 
            // 
            // 
            this.TxtObservaciones.RootElement.StretchVertically = true;
            this.TxtObservaciones.Size = new System.Drawing.Size(733, 46);
            this.TxtObservaciones.TabIndex = 13;
            this.TxtObservaciones.TabStop = false;
            this.TxtObservaciones.ThemeName = "TelerikMetroBlue";
            // 
            // RpObservaciones
            // 
            this.RpObservaciones.Controls.Add(this.TxtObservaciones);
            this.RpObservaciones.Location = new System.Drawing.Point(12, 415);
            this.RpObservaciones.Name = "RpObservaciones";
            this.RpObservaciones.Size = new System.Drawing.Size(764, 81);
            this.RpObservaciones.TabIndex = 15;
            this.RpObservaciones.Text = "Observaciones:";
            this.RpObservaciones.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // ucCuentaCorrienteCompra
            // 
            this.ucCuentaCorrienteCompra.Adeuda = null;
            this.ucCuentaCorrienteCompra.Anticipo = null;
            this.ucCuentaCorrienteCompra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ucCuentaCorrienteCompra.Cuotas = 1;
            this.ucCuentaCorrienteCompra.Location = new System.Drawing.Point(12, 502);
            this.ucCuentaCorrienteCompra.Montocuota = null;
            this.ucCuentaCorrienteCompra.Name = "ucCuentaCorrienteCompra";
            this.ucCuentaCorrienteCompra.Size = new System.Drawing.Size(764, 66);
            this.ucCuentaCorrienteCompra.SubTotal = null;
            this.ucCuentaCorrienteCompra.TabIndex = 16;
            this.ucCuentaCorrienteCompra.Total = null;
            this.ucCuentaCorrienteCompra.Vencimiento = new System.DateTime(2015, 10, 26, 0, 0, 0, 0);
            // 
            // ucTotalesCompraSeña1
            // 
            this.ucTotalesCompraSeña1.Creditos = null;
            this.ucTotalesCompraSeña1.CreditosDisp = null;
            this.ucTotalesCompraSeña1.Egresos = null;
            this.ucTotalesCompraSeña1.EgresosDisp = null;
            this.ucTotalesCompraSeña1.FaltaPagar = null;
            this.ucTotalesCompraSeña1.Location = new System.Drawing.Point(799, 56);
            this.ucTotalesCompraSeña1.Name = "ucTotalesCompraSeña1";
            this.ucTotalesCompraSeña1.Senas = null;
            this.ucTotalesCompraSeña1.SenasDisp = null;
            this.ucTotalesCompraSeña1.Size = new System.Drawing.Size(340, 405);
            this.ucTotalesCompraSeña1.SubTotal = null;
            this.ucTotalesCompraSeña1.TabIndex = 17;
            this.ucTotalesCompraSeña1.TotalPagar = null;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.BtnGuardar);
            this.radPanel1.Location = new System.Drawing.Point(795, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(349, 556);
            this.radPanel1.TabIndex = 18;
            // 
            // FrmCrearCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1242, 820);
            this.Controls.Add(this.ucTotalesCompraSeña1);
            this.Controls.Add(this.ucCuentaCorrienteCompra);
            this.Controls.Add(this.RpFactura);
            this.Controls.Add(this.RpFechaVencimiento);
            this.Controls.Add(this.RpObservaciones);
            this.Controls.Add(this.RpProveedor);
            this.Controls.Add(this.RpRemito);
            this.Controls.Add(this.RpFecha);
            this.Controls.Add(this.ucTipoCompra);
            this.Controls.Add(this.ucTitulosCompra);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCrearCompra";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.FrmCrearCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaEmision)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpFecha)).EndInit();
            this.RpFecha.ResumeLayout(false);
            this.RpFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RpRemito)).EndInit();
            this.RpRemito.ResumeLayout(false);
            this.RpRemito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRemito2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtRemito1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpProveedor)).EndInit();
            this.RpProveedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RpFactura)).EndInit();
            this.RpFactura.ResumeLayout(false);
            this.RpFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DdlFacturaTipo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFactura2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFactura1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpFechaVencimiento)).EndInit();
            this.RpFechaVencimiento.ResumeLayout(false);
            this.RpFechaVencimiento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RpObservaciones)).EndInit();
            this.RpObservaciones.ResumeLayout(false);
            this.RpObservaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion


        private UcTitulosCompra ucTitulosCompra;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private UcBuscadorProveedor ucBuscadorProveedor;
        private UcTipoCompra ucTipoCompra;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaEmision;
        private Telerik.WinControls.UI.RadPanel RpFecha;
        private Telerik.WinControls.UI.RadPanel RpRemito;
        private Telerik.WinControls.UI.RadPanel RpProveedor;
        private Telerik.WinControls.UI.RadTextBox TxtRemito1;
        private Telerik.WinControls.UI.RadTextBox TxtRemito2;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel RpFactura;
        private Telerik.WinControls.UI.RadTextBox TxtFactura2;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtFactura1;
        private Telerik.WinControls.UI.RadPanel RpFechaVencimiento;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaVencimiento;
        private Telerik.WinControls.UI.RadDropDownList DdlFacturaTipo;
        private Telerik.WinControls.UI.RadTextBox TxtObservaciones;
        private Telerik.WinControls.UI.RadPanel RpObservaciones;
        private UcCuentaCorrienteCompra ucCuentaCorrienteCompra;
        private UcTotalesCompraSeña ucTotalesCompraSeña1;
        private Telerik.WinControls.UI.RadPanel radPanel1;

    }
}