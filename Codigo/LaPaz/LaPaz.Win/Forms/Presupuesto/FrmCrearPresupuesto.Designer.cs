namespace LaPaz.Win.Forms.Presupuesto
{
    partial class FrmCrearPresupuesto
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
            this.UcBuscadorCliente = new LaPaz.Win.Forms.Ventas.UcBuscadorCliente();
            this.UcClienteDetalle = new LaPaz.Win.Forms.Ventas.UcClienteDetalle();
            this.pnlFecha = new Telerik.WinControls.UI.RadPanel();
            this.TxtNroPresupuesto = new Telerik.WinControls.UI.RadTextBox();
            this.TxtFecha = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlClienteDetalle = new Telerik.WinControls.UI.RadPanel();
            this.pnlBuscador = new Telerik.WinControls.UI.RadPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pnlTotales = new Telerik.WinControls.UI.RadPanel();
            this.BtnPresupuestar = new Telerik.WinControls.UI.RadButton();
            this.UcTotalesPresupuesto = new LaPaz.Win.Forms.Presupuesto.UcTotalesPresupuesto();
            this.pnlTitulos = new Telerik.WinControls.UI.RadPanel();
            this.UcTitulosVenta = new LaPaz.Win.Forms.Ventas.UcTitulosVenta();
            ((System.ComponentModel.ISupportInitialize)(this.pnlFecha)).BeginInit();
            this.pnlFecha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlClienteDetalle)).BeginInit();
            this.pnlClienteDetalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlBuscador)).BeginInit();
            this.pnlBuscador.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTotales)).BeginInit();
            this.pnlTotales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPresupuestar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulos)).BeginInit();
            this.pnlTitulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // UcBuscadorCliente
            // 
            this.UcBuscadorCliente.Cuit = "";
            this.UcBuscadorCliente.Location = new System.Drawing.Point(3, 1);
            this.UcBuscadorCliente.Name = "UcBuscadorCliente";
            this.UcBuscadorCliente.Size = new System.Drawing.Size(340, 96);
            this.UcBuscadorCliente.TabIndex = 1;
            // 
            // UcClienteDetalle
            // 
            this.UcClienteDetalle.ClienteNombre = "";
            this.UcClienteDetalle.Cuit = "";
            this.UcClienteDetalle.Domicilio = "";
            this.UcClienteDetalle.FormaPago = "";
            this.UcClienteDetalle.Localidad = "";
            this.UcClienteDetalle.Location = new System.Drawing.Point(3, 4);
            this.UcClienteDetalle.Name = "UcClienteDetalle";
            this.UcClienteDetalle.Provincia = "";
            this.UcClienteDetalle.Size = new System.Drawing.Size(674, 181);
            this.UcClienteDetalle.TabIndex = 2;
            // 
            // pnlFecha
            // 
            this.pnlFecha.Controls.Add(this.TxtNroPresupuesto);
            this.pnlFecha.Controls.Add(this.TxtFecha);
            this.pnlFecha.Controls.Add(this.metroLabel2);
            this.pnlFecha.Controls.Add(this.metroLabel1);
            this.pnlFecha.Controls.Add(this.pictureBox1);
            this.pnlFecha.Location = new System.Drawing.Point(12, 0);
            this.pnlFecha.Name = "pnlFecha";
            this.pnlFecha.Size = new System.Drawing.Size(682, 100);
            this.pnlFecha.TabIndex = 3;
            // 
            // TxtNroPresupuesto
            // 
            this.TxtNroPresupuesto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNroPresupuesto.Location = new System.Drawing.Point(453, 53);
            this.TxtNroPresupuesto.Name = "TxtNroPresupuesto";
            this.TxtNroPresupuesto.Size = new System.Drawing.Size(206, 26);
            this.TxtNroPresupuesto.TabIndex = 10;
            this.TxtNroPresupuesto.TabStop = false;
            this.TxtNroPresupuesto.ThemeName = "TelerikMetroBlue";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(453, 21);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(206, 26);
            this.TxtFecha.TabIndex = 9;
            this.TxtFecha.TabStop = false;
            this.TxtFecha.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(322, 52);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 24);
            this.metroLabel2.TabIndex = 8;
            this.metroLabel2.Text = "Presupuesto Nro:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(400, 22);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 24);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Fecha:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
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
            // pnlClienteDetalle
            // 
            this.pnlClienteDetalle.Controls.Add(this.UcClienteDetalle);
            this.pnlClienteDetalle.Location = new System.Drawing.Point(12, 106);
            this.pnlClienteDetalle.Name = "pnlClienteDetalle";
            this.pnlClienteDetalle.Size = new System.Drawing.Size(682, 188);
            this.pnlClienteDetalle.TabIndex = 4;
            // 
            // pnlBuscador
            // 
            this.pnlBuscador.Controls.Add(this.UcBuscadorCliente);
            this.pnlBuscador.Location = new System.Drawing.Point(700, 0);
            this.pnlBuscador.Name = "pnlBuscador";
            this.pnlBuscador.Size = new System.Drawing.Size(349, 100);
            this.pnlBuscador.TabIndex = 5;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pnlTotales
            // 
            this.pnlTotales.Controls.Add(this.BtnPresupuestar);
            this.pnlTotales.Controls.Add(this.UcTotalesPresupuesto);
            this.pnlTotales.Location = new System.Drawing.Point(701, 107);
            this.pnlTotales.Name = "pnlTotales";
            this.pnlTotales.Size = new System.Drawing.Size(348, 187);
            this.pnlTotales.TabIndex = 6;
            // 
            // BtnPresupuestar
            // 
            this.BtnPresupuestar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnPresupuestar.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.BtnPresupuestar.Location = new System.Drawing.Point(224, 154);
            this.BtnPresupuestar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnPresupuestar.Name = "BtnPresupuestar";
            this.BtnPresupuestar.Size = new System.Drawing.Size(100, 28);
            this.BtnPresupuestar.TabIndex = 42;
            this.BtnPresupuestar.Text = "Presupuestar";
            this.BtnPresupuestar.ThemeName = "TelerikMetroBlue";
            this.BtnPresupuestar.Click += new System.EventHandler(this.BtnPresupuestar_Click);
            // 
            // UcTotalesPresupuesto
            // 
            this.UcTotalesPresupuesto.Descuento = null;
            this.UcTotalesPresupuesto.Location = new System.Drawing.Point(13, 3);
            this.UcTotalesPresupuesto.Name = "UcTotalesPresupuesto";
            this.UcTotalesPresupuesto.Recargo = null;
            this.UcTotalesPresupuesto.Size = new System.Drawing.Size(311, 156);
            this.UcTotalesPresupuesto.SubTotal = new decimal(new int[] {
            0,
            0,
            0,
            131072});
            this.UcTotalesPresupuesto.TabIndex = 0;
            this.UcTotalesPresupuesto.TotalPagar = null;
            // 
            // pnlTitulos
            // 
            this.pnlTitulos.Controls.Add(this.UcTitulosVenta);
            this.pnlTitulos.Location = new System.Drawing.Point(12, 301);
            this.pnlTitulos.Name = "pnlTitulos";
            this.pnlTitulos.Size = new System.Drawing.Size(682, 339);
            this.pnlTitulos.TabIndex = 7;
            // 
            // UcTitulosVenta
            // 
            this.UcTitulosVenta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcTitulosVenta.Location = new System.Drawing.Point(4, 5);
            this.UcTitulosVenta.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UcTitulosVenta.Name = "UcTitulosVenta";
            this.UcTitulosVenta.Size = new System.Drawing.Size(667, 329);
            this.UcTitulosVenta.TabIndex = 0;
            // 
            // FrmCrearPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 858);
            this.Controls.Add(this.pnlTitulos);
            this.Controls.Add(this.pnlTotales);
            this.Controls.Add(this.pnlBuscador);
            this.Controls.Add(this.pnlClienteDetalle);
            this.Controls.Add(this.pnlFecha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "FrmCrearPresupuesto";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmCrearPresupuesto_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmCrearPresupuesto_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pnlFecha)).EndInit();
            this.pnlFecha.ResumeLayout(false);
            this.pnlFecha.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNroPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlClienteDetalle)).EndInit();
            this.pnlClienteDetalle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlBuscador)).EndInit();
            this.pnlBuscador.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pnlTotales)).EndInit();
            this.pnlTotales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnPresupuestar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pnlTitulos)).EndInit();
            this.pnlTitulos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Ventas.UcBuscadorCliente UcBuscadorCliente;
        private Ventas.UcClienteDetalle UcClienteDetalle;
        private Telerik.WinControls.UI.RadPanel pnlFecha;
        private Telerik.WinControls.UI.RadPanel pnlClienteDetalle;
        private Telerik.WinControls.UI.RadPanel pnlBuscador;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Telerik.WinControls.UI.RadTextBox TxtNroPresupuesto;
        private Telerik.WinControls.UI.RadTextBox TxtFecha;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadPanel pnlTotales;
        private UcTotalesPresupuesto UcTotalesPresupuesto;
        private Telerik.WinControls.UI.RadPanel pnlTitulos;
        private Ventas.UcTitulosVenta UcTitulosVenta;
        private Telerik.WinControls.UI.RadButton BtnPresupuestar;
    }
}