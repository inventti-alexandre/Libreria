namespace LaPaz.Win.Forms.FrmProveedoresDevolucion
{
    partial class FrmProveedoresDevolucion
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
            this.radTextBox1 = new Telerik.WinControls.UI.RadTextBox();
            this.radTextBox2 = new Telerik.WinControls.UI.RadTextBox();
            this.LabelImporte = new Telerik.WinControls.UI.RadLabel();
            this.PnlProveedor = new Telerik.WinControls.UI.RadPanel();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.ucFiltroProveedor1 = new LaPaz.Win.Forms.Util.UcFiltroProveedor();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.radPanel3 = new Telerik.WinControls.UI.RadPanel();
            this.RbEgreso = new Telerik.WinControls.UI.RadRadioButton();
            this.RbNotaCredito = new Telerik.WinControls.UI.RadRadioButton();
            this.TxtObservaciones = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.TxtConcepto = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.LblImporte = new Telerik.WinControls.UI.RadLabel();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            this.ucTitulosDevolucion = new LaPaz.Win.Forms.Compras.UcTitulosCompra();
            this.ucTitulosCompra1 = new LaPaz.Win.Forms.Compras.UcTitulosCompra();
            this.ucTitulosCompra2 = new LaPaz.Win.Forms.Compras.UcTitulosCompra();
            this.ucTitulosCompra3 = new LaPaz.Win.Forms.Compras.UcTitulosCompra();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlProveedor)).BeginInit();
            this.PnlProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).BeginInit();
            this.radPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RbEgreso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RbNotaCredito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTextBox1
            // 
            this.radTextBox1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox1.Location = new System.Drawing.Point(160, 20);
            this.radTextBox1.Name = "radTextBox1";
            this.radTextBox1.Size = new System.Drawing.Size(1091, 29);
            this.radTextBox1.TabIndex = 11;
            this.radTextBox1.TabStop = false;
            // 
            // radTextBox2
            // 
            this.radTextBox2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radTextBox2.Location = new System.Drawing.Point(160, 60);
            this.radTextBox2.Name = "radTextBox2";
            this.radTextBox2.Size = new System.Drawing.Size(1093, 29);
            this.radTextBox2.TabIndex = 13;
            this.radTextBox2.TabStop = false;
            // 
            // LabelImporte
            // 
            this.LabelImporte.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelImporte.Location = new System.Drawing.Point(105, 84);
            this.LabelImporte.Name = "LabelImporte";
            this.LabelImporte.Size = new System.Drawing.Size(18, 28);
            this.LabelImporte.TabIndex = 10;
            this.LabelImporte.Text = "0";
            // 
            // PnlProveedor
            // 
            this.PnlProveedor.Controls.Add(this.radLabel1);
            this.PnlProveedor.Controls.Add(this.ucFiltroProveedor1);
            this.PnlProveedor.Controls.Add(this.ucProgressSpinner1);
            this.PnlProveedor.Location = new System.Drawing.Point(12, 5);
            this.PnlProveedor.Name = "PnlProveedor";
            this.PnlProveedor.Size = new System.Drawing.Size(1110, 59);
            this.PnlProveedor.TabIndex = 3;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(3, 13);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(96, 29);
            this.radLabel1.TabIndex = 2;
            this.radLabel1.Text = "Proveedor";
            // 
            // ucFiltroProveedor1
            // 
            this.ucFiltroProveedor1.EsGasto = false;
            this.ucFiltroProveedor1.Location = new System.Drawing.Point(101, 10);
            this.ucFiltroProveedor1.Margin = new System.Windows.Forms.Padding(4);
            this.ucFiltroProveedor1.Name = "ucFiltroProveedor1";
            this.ucFiltroProveedor1.ProveedorId = null;
            this.ucFiltroProveedor1.Size = new System.Drawing.Size(351, 27);
            this.ucFiltroProveedor1.TabIndex = 0;
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Location = new System.Drawing.Point(710, 8);
            this.ucProgressSpinner1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 0;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel3);
            this.radPanel1.Controls.Add(this.TxtObservaciones);
            this.radPanel1.Controls.Add(this.radLabel5);
            this.radPanel1.Controls.Add(this.TxtConcepto);
            this.radPanel1.Controls.Add(this.radLabel4);
            this.radPanel1.Controls.Add(this.radLabel2);
            this.radPanel1.Controls.Add(this.LblImporte);
            this.radPanel1.Controls.Add(this.BtnGuardar);
            this.radPanel1.Location = new System.Drawing.Point(12, 413);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(1110, 127);
            this.radPanel1.TabIndex = 10;
            // 
            // radPanel3
            // 
            this.radPanel3.Controls.Add(this.RbEgreso);
            this.radPanel3.Controls.Add(this.RbNotaCredito);
            this.radPanel3.Location = new System.Drawing.Point(759, 16);
            this.radPanel3.Name = "radPanel3";
            this.radPanel3.Size = new System.Drawing.Size(167, 56);
            this.radPanel3.TabIndex = 14;
            // 
            // RbEgreso
            // 
            this.RbEgreso.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbEgreso.Location = new System.Drawing.Point(14, 34);
            this.RbEgreso.Name = "RbEgreso";
            this.RbEgreso.Size = new System.Drawing.Size(140, 18);
            this.RbEgreso.TabIndex = 1;
            this.RbEgreso.Text = "Egreso";
            this.RbEgreso.ThemeName = "TelerikMetroBlue";
            this.RbEgreso.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RbEgreso_ToggleStateChanged);
            // 
            // RbNotaCredito
            // 
            this.RbNotaCredito.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNotaCredito.Location = new System.Drawing.Point(14, 7);
            this.RbNotaCredito.Name = "RbNotaCredito";
            this.RbNotaCredito.Size = new System.Drawing.Size(140, 18);
            this.RbNotaCredito.TabIndex = 0;
            this.RbNotaCredito.TabStop = true;
            this.RbNotaCredito.Text = "Nota de crédito";
            this.RbNotaCredito.ThemeName = "TelerikMetroBlue";
            this.RbNotaCredito.ToggleState = Telerik.WinControls.Enumerations.ToggleState.On;
            this.RbNotaCredito.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.RbNotaCredito_ToggleStateChanged);
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(160, 47);
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(554, 29);
            this.TxtObservaciones.TabIndex = 13;
            this.TxtObservaciones.TabStop = false;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(33, 49);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(132, 28);
            this.radLabel5.TabIndex = 12;
            this.radLabel5.Text = "Observaciones:";
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConcepto.Location = new System.Drawing.Point(160, 16);
            this.TxtConcepto.Name = "TxtConcepto";
            this.TxtConcepto.Size = new System.Drawing.Size(554, 29);
            this.TxtConcepto.TabIndex = 11;
            this.TxtConcepto.TabStop = false;
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(33, 20);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(92, 28);
            this.radLabel4.TabIndex = 10;
            this.radLabel4.Text = "Concepto:";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(33, 78);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(61, 29);
            this.radLabel2.TabIndex = 9;
            this.radLabel2.Text = "Total:";
            // 
            // LblImporte
            // 
            this.LblImporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblImporte.Location = new System.Drawing.Point(160, 78);
            this.LblImporte.Name = "LblImporte";
            this.LblImporte.Size = new System.Drawing.Size(20, 29);
            this.LblImporte.TabIndex = 10;
            this.LblImporte.Text = "0";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(824, 78);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(102, 29);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.ucTitulosDevolucion);
            this.radPanel2.Location = new System.Drawing.Point(12, 71);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(1110, 336);
            this.radPanel2.TabIndex = 11;
            this.radPanel2.Text = "radPanel2";
            // 
            // ucTitulosDevolucion
            // 
            this.ucTitulosDevolucion.Location = new System.Drawing.Point(4, 1);
            this.ucTitulosDevolucion.Margin = new System.Windows.Forms.Padding(4);
            this.ucTitulosDevolucion.Name = "ucTitulosDevolucion";
            this.ucTitulosDevolucion.Size = new System.Drawing.Size(1090, 331);
            this.ucTitulosDevolucion.TabIndex = 9;
            // 
            // ucTitulosCompra1
            // 
            this.ucTitulosCompra1.Location = new System.Drawing.Point(0, 0);
            this.ucTitulosCompra1.Margin = new System.Windows.Forms.Padding(4);
            this.ucTitulosCompra1.Name = "ucTitulosCompra1";
            this.ucTitulosCompra1.Size = new System.Drawing.Size(889, 290);
            this.ucTitulosCompra1.TabIndex = 0;
            // 
            // ucTitulosCompra2
            // 
            this.ucTitulosCompra2.Location = new System.Drawing.Point(0, 0);
            this.ucTitulosCompra2.Margin = new System.Windows.Forms.Padding(4);
            this.ucTitulosCompra2.Name = "ucTitulosCompra2";
            this.ucTitulosCompra2.Size = new System.Drawing.Size(889, 290);
            this.ucTitulosCompra2.TabIndex = 0;
            // 
            // ucTitulosCompra3
            // 
            this.ucTitulosCompra3.Location = new System.Drawing.Point(0, 0);
            this.ucTitulosCompra3.Margin = new System.Windows.Forms.Padding(4);
            this.ucTitulosCompra3.Name = "ucTitulosCompra3";
            this.ucTitulosCompra3.Size = new System.Drawing.Size(889, 290);
            this.ucTitulosCompra3.TabIndex = 0;
            // 
            // FrmProveedoresDevolucion
            // 
            this.ClientSize = new System.Drawing.Size(1162, 699);
            this.ControlBox = false;
            this.Controls.Add(this.PnlProveedor);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radPanel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedoresDevolucion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Devolucion de Libros";
            this.Load += new System.EventHandler(this.FrmProveedoresDevolucion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radTextBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LabelImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlProveedor)).EndInit();
            this.PnlProveedor.ResumeLayout(false);
            this.PnlProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            this.radPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel3)).EndInit();
            this.radPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.RbEgreso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RbNotaCredito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtObservaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Util.UcFiltroProveedor ucFiltroProveedor1;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadPanel PnlProveedor;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Compras.UcTitulosCompra ucTitulosCompra1;
        private Compras.UcTitulosCompra ucTitulosCompra2;
        private Compras.UcTitulosCompra ucTitulosCompra3;
        private Compras.UcTitulosCompra ucTitulosDevolucion;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
        private Telerik.WinControls.UI.RadLabel LblImporte;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtObservaciones;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadTextBox TxtConcepto;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadTextBox radTextBox1;
        private Telerik.WinControls.UI.RadTextBox radTextBox2;
        private Telerik.WinControls.UI.RadLabel LabelImporte;
        private Telerik.WinControls.UI.RadPanel radPanel3;
        private Telerik.WinControls.UI.RadRadioButton RbEgreso;
        private Telerik.WinControls.UI.RadRadioButton RbNotaCredito;
    }
}
