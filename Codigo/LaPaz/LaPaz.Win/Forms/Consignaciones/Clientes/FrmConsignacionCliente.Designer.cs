using LaPaz.Win.Model;
namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    partial class FrmConsignacionCliente
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.DtpFechaVencimiento = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnRecargarNroFactura = new Telerik.WinControls.UI.RadButton();
            this.ucBuscadorClienteConsignacion = new LaPaz.Win.Forms.Consignaciones.Clientes.UcBuscadorClienteConsignacion();
            this.TxtNroConsignacion = new Telerik.WinControls.UI.RadTextBox();
            this.TxtFecha = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnConsignar = new Telerik.WinControls.UI.RadButton();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ucClienteDetalle = new LaPaz.Win.Forms.Ventas.UcClienteDetalle();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.ucTitulosVenta = new LaPaz.Win.Forms.Ventas.UcTitulosVenta();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtObservacion = new Telerik.WinControls.UI.RadTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel2)).BeginInit();
            this.metroPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaVencimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRecargarNroFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroConsignacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsignar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.DtpFechaVencimiento);
            this.metroPanel2.Controls.Add(this.radLabel1);
            this.metroPanel2.Controls.Add(this.BtnRecargarNroFactura);
            this.metroPanel2.Controls.Add(this.ucBuscadorClienteConsignacion);
            this.metroPanel2.Controls.Add(this.TxtNroConsignacion);
            this.metroPanel2.Controls.Add(this.TxtFecha);
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Controls.Add(this.metroLabel1);
            this.metroPanel2.Controls.Add(this.pictureBox1);
            this.metroPanel2.Location = new System.Drawing.Point(2, 5);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(904, 100);
            this.metroPanel2.TabIndex = 6;
            // 
            // DtpFechaVencimiento
            // 
            this.DtpFechaVencimiento.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVencimiento.Location = new System.Drawing.Point(332, 36);
            this.DtpFechaVencimiento.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaVencimiento.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaVencimiento.Name = "DtpFechaVencimiento";
            this.DtpFechaVencimiento.NullableValue = new System.DateTime(2015, 7, 17, 0, 0, 0, 0);
            this.DtpFechaVencimiento.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaVencimiento.Size = new System.Drawing.Size(112, 29);
            this.DtpFechaVencimiento.TabIndex = 7;
            this.DtpFechaVencimiento.TabStop = false;
            this.DtpFechaVencimiento.Text = "17/07/2015";
            this.DtpFechaVencimiento.ThemeName = "TelerikMetroBlue";
            this.DtpFechaVencimiento.Value = new System.DateTime(2015, 7, 17, 0, 0, 0, 0);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(168, 38);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(161, 24);
            this.radLabel1.TabIndex = 4;
            this.radLabel1.Text = "Fecha de Vencimiento:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnRecargarNroFactura
            // 
            this.BtnRecargarNroFactura.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRecargarNroFactura.Image = global::LaPaz.Win.Properties.Resources.Reload_16x16;
            this.BtnRecargarNroFactura.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRecargarNroFactura.Location = new System.Drawing.Point(792, 6);
            this.BtnRecargarNroFactura.Name = "BtnRecargarNroFactura";
            this.BtnRecargarNroFactura.Size = new System.Drawing.Size(32, 26);
            this.BtnRecargarNroFactura.TabIndex = 3;
            this.BtnRecargarNroFactura.ThemeName = "TelerikMetroBlue";
            this.BtnRecargarNroFactura.Click += new System.EventHandler(this.BtnRecargarNroFactura_Click);
            // 
            // ucBuscadorClienteConsignacion
            // 
            this.ucBuscadorClienteConsignacion.Cuit = "";
            this.ucBuscadorClienteConsignacion.Location = new System.Drawing.Point(558, 34);
            this.ucBuscadorClienteConsignacion.Name = "ucBuscadorClienteConsignacion";
            this.ucBuscadorClienteConsignacion.Size = new System.Drawing.Size(340, 40);
            this.ucBuscadorClienteConsignacion.TabIndex = 4;
            // 
            // TxtNroConsignacion
            // 
            this.TxtNroConsignacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroConsignacion.Location = new System.Drawing.Point(619, 6);
            this.TxtNroConsignacion.Name = "TxtNroConsignacion";
            this.TxtNroConsignacion.Size = new System.Drawing.Size(165, 26);
            this.TxtNroConsignacion.TabIndex = 6;
            this.TxtNroConsignacion.TabStop = false;
            this.TxtNroConsignacion.ThemeName = "TelerikMetroBlue";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(332, 6);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(112, 26);
            this.TxtFecha.TabIndex = 5;
            this.TxtFecha.TabStop = false;
            this.TxtFecha.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(483, 7);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(133, 24);
            this.metroLabel2.TabIndex = 4;
            this.metroLabel2.Text = "Nro Consignación:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(279, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 24);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Fecha:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LaPaz.Win.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(3, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(163, 90);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // BtnConsignar
            // 
            this.BtnConsignar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsignar.Location = new System.Drawing.Point(768, 12);
            this.BtnConsignar.Name = "BtnConsignar";
            this.BtnConsignar.Size = new System.Drawing.Size(103, 30);
            this.BtnConsignar.TabIndex = 4;
            this.BtnConsignar.Text = "Consignar";
            this.BtnConsignar.ThemeName = "TelerikMetroBlue";
            this.BtnConsignar.Click += new System.EventHandler(this.BtnConsignar_Click);
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucClienteDetalle);
            this.radPanel1.Location = new System.Drawing.Point(2, 107);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(904, 192);
            this.radPanel1.TabIndex = 10;
            // 
            // ucClienteDetalle
            // 
            this.ucClienteDetalle.ClienteNombre = "";
            this.ucClienteDetalle.Cuit = "";
            this.ucClienteDetalle.Domicilio = "";
            this.ucClienteDetalle.FormaPago = "";
            this.ucClienteDetalle.Localidad = "";
            this.ucClienteDetalle.Location = new System.Drawing.Point(10, 4);
            this.ucClienteDetalle.Name = "ucClienteDetalle";
            this.ucClienteDetalle.Provincia = "";
            this.ucClienteDetalle.Size = new System.Drawing.Size(824, 181);
            this.ucClienteDetalle.TabIndex = 4;
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucTitulosVenta);
            this.radPanel2.Location = new System.Drawing.Point(2, 305);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(904, 254);
            this.radPanel2.TabIndex = 11;
            // 
            // ucTitulosVenta
            // 
            this.ucTitulosVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucTitulosVenta.Location = new System.Drawing.Point(11, 5);
            this.ucTitulosVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTitulosVenta.Name = "ucTitulosVenta";
            this.ucTitulosVenta.Size = new System.Drawing.Size(887, 236);
            this.ucTitulosVenta.TabIndex = 9;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.radLabel2);
            this.radPanel3.Controls.Add(this.TxtObservacion);
            this.radPanel3.Controls.Add(this.BtnConsignar);
            this.radPanel3.Location = new System.Drawing.Point(2, 565);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(904, 76);
            this.radPanel3.TabIndex = 12;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(33, 12);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(96, 24);
            this.radLabel2.TabIndex = 11;
            this.radLabel2.Text = "Observacion:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtObservacion
            // 
            this.TxtObservacion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservacion.Location = new System.Drawing.Point(135, 12);
            this.TxtObservacion.Multiline = true;
            this.TxtObservacion.Name = "TxtObservacion";
            // 
            // 
            // 
            this.TxtObservacion.RootElement.StretchVertically = true;
            this.TxtObservacion.Size = new System.Drawing.Size(525, 48);
            this.TxtObservacion.TabIndex = 10;
            this.TxtObservacion.TabStop = false;
            this.TxtObservacion.ThemeName = "TelerikMetroBlue";
            // 
            // FrmConsignacionCliente
            // 
            this.ClientSize = new System.Drawing.Size(972, 644);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.metroPanel2);
            this.Controls.Add(this.radPanel3);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmConsignacionCliente";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmConsignacionCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroPanel2)).EndInit();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaVencimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnRecargarNroFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroConsignacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnConsignar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            this.radPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnConsignar;
        private UcBuscadorClienteConsignacion ucBuscadorClienteConsignacion;
        private Telerik.WinControls.UI.RadPanel metroPanel2;
        private Telerik.WinControls.UI.RadButton BtnRecargarNroFactura;
        private Telerik.WinControls.UI.RadTextBox TxtNroConsignacion;
        private Telerik.WinControls.UI.RadTextBox TxtFecha;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaVencimiento;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Ventas.UcClienteDetalle ucClienteDetalle;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Ventas.UcTitulosVenta ucTitulosVenta;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtObservacion;
        
    }
}
