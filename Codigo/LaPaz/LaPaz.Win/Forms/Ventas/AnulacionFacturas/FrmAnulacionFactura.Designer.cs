namespace LaPaz.Win.Forms.Ventas.AnulacionFacturas
{
    partial class FrmAnulacionFactura
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.ucBuscadorFactura = new LaPaz.Win.Forms.Ventas.CreditosDevolucion.UcBuscadorFactura();
            this.PnlFactura = new Telerik.WinControls.UI.RadPanel();
            this.TxtImporte = new Telerik.WinControls.UI.RadTextBox();
            this.TxtFecha = new Telerik.WinControls.UI.RadTextBox();
            this.TxtConcepto = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCliente = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel9 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.GrillaLineasFactura = new Telerik.WinControls.UI.RadGridView();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PnlFactura)).BeginInit();
            this.PnlFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).BeginInit();
            this.radLabel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            this.radLabel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            this.radLabel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.radLabel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLineasFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLineasFactura.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            this.radPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ucBuscadorFactura
            // 
            this.ucBuscadorFactura.Location = new System.Drawing.Point(11, 3);
            this.ucBuscadorFactura.Name = "ucBuscadorFactura";
            this.ucBuscadorFactura.Size = new System.Drawing.Size(491, 58);
            this.ucBuscadorFactura.TabIndex = 0;
            this.ucBuscadorFactura.Load += new System.EventHandler(this.ucBuscadorFactura1_Load);
            // 
            // PnlFactura
            // 
            this.PnlFactura.Controls.Add(this.TxtImporte);
            this.PnlFactura.Controls.Add(this.TxtFecha);
            this.PnlFactura.Controls.Add(this.TxtConcepto);
            this.PnlFactura.Controls.Add(this.TxtCliente);
            this.PnlFactura.Controls.Add(this.radLabel8);
            this.PnlFactura.Controls.Add(this.radLabel4);
            this.PnlFactura.Controls.Add(this.radLabel6);
            this.PnlFactura.Controls.Add(this.radLabel2);
            this.PnlFactura.Location = new System.Drawing.Point(27, 86);
            this.PnlFactura.Name = "PnlFactura";
            this.PnlFactura.Size = new System.Drawing.Size(545, 114);
            this.PnlFactura.TabIndex = 5;
            // 
            // TxtImporte
            // 
            this.TxtImporte.Enabled = false;
            this.TxtImporte.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtImporte.Location = new System.Drawing.Point(354, 77);
            this.TxtImporte.Name = "TxtImporte";
            this.TxtImporte.Size = new System.Drawing.Size(148, 26);
            this.TxtImporte.TabIndex = 8;
            this.TxtImporte.TabStop = false;
            this.TxtImporte.ThemeName = "TelerikMetroBlue";
            // 
            // TxtFecha
            // 
            this.TxtFecha.Enabled = false;
            this.TxtFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(96, 78);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(182, 26);
            this.TxtFecha.TabIndex = 7;
            this.TxtFecha.TabStop = false;
            this.TxtFecha.ThemeName = "TelerikMetroBlue";
            // 
            // TxtConcepto
            // 
            this.TxtConcepto.Enabled = false;
            this.TxtConcepto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConcepto.Location = new System.Drawing.Point(96, 46);
            this.TxtConcepto.Name = "TxtConcepto";
            this.TxtConcepto.Size = new System.Drawing.Size(406, 26);
            this.TxtConcepto.TabIndex = 6;
            this.TxtConcepto.TabStop = false;
            this.TxtConcepto.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCliente
            // 
            this.TxtCliente.Enabled = false;
            this.TxtCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCliente.Location = new System.Drawing.Point(96, 14);
            this.TxtCliente.Name = "TxtCliente";
            this.TxtCliente.Size = new System.Drawing.Size(406, 26);
            this.TxtCliente.TabIndex = 5;
            this.TxtCliente.TabStop = false;
            this.TxtCliente.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel8
            // 
            this.radLabel8.Controls.Add(this.radLabel9);
            this.radLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel8.Location = new System.Drawing.Point(284, 79);
            this.radLabel8.Name = "radLabel8";
            this.radLabel8.Size = new System.Drawing.Size(65, 24);
            this.radLabel8.TabIndex = 4;
            this.radLabel8.Text = "Importe:";
            // 
            // radLabel9
            // 
            this.radLabel9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel9.Location = new System.Drawing.Point(3, 30);
            this.radLabel9.Name = "radLabel9";
            this.radLabel9.Size = new System.Drawing.Size(58, 24);
            this.radLabel9.TabIndex = 1;
            this.radLabel9.Text = "Cliente:";
            // 
            // radLabel4
            // 
            this.radLabel4.Controls.Add(this.radLabel5);
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(13, 79);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(50, 24);
            this.radLabel4.TabIndex = 3;
            this.radLabel4.Text = "Fecha:";
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(3, 30);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(58, 24);
            this.radLabel5.TabIndex = 1;
            this.radLabel5.Text = "Cliente:";
            // 
            // radLabel6
            // 
            this.radLabel6.Controls.Add(this.radLabel7);
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(13, 47);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(77, 24);
            this.radLabel6.TabIndex = 2;
            this.radLabel6.Text = "Concepto:";
            // 
            // radLabel7
            // 
            this.radLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel7.Location = new System.Drawing.Point(3, 30);
            this.radLabel7.Name = "radLabel7";
            this.radLabel7.Size = new System.Drawing.Size(58, 24);
            this.radLabel7.TabIndex = 1;
            this.radLabel7.Text = "Cliente:";
            // 
            // radLabel2
            // 
            this.radLabel2.Controls.Add(this.radLabel3);
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(13, 15);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(58, 24);
            this.radLabel2.TabIndex = 0;
            this.radLabel2.Text = "Cliente:";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(3, 30);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(58, 24);
            this.radLabel3.TabIndex = 1;
            this.radLabel3.Text = "Cliente:";
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ucBuscadorFactura);
            this.radPanel1.Location = new System.Drawing.Point(27, 12);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(545, 68);
            this.radPanel1.TabIndex = 6;
            // 
            // GrillaLineasFactura
            // 
            this.GrillaLineasFactura.Location = new System.Drawing.Point(3, 14);
            // 
            // GrillaLineasFactura
            // 
            this.GrillaLineasFactura.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TituloNombreTitulo";
            gridViewTextBoxColumn1.HeaderText = "Titulo";
            gridViewTextBoxColumn1.Name = "Titulo";
            gridViewTextBoxColumn1.Width = 265;
            gridViewTextBoxColumn2.FieldName = "CantidadAuditada";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Cantidad";
            gridViewTextBoxColumn2.MaxWidth = 75;
            gridViewTextBoxColumn2.MinWidth = 75;
            gridViewTextBoxColumn2.Name = "Cantidad";
            gridViewTextBoxColumn2.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn2.Width = 75;
            gridViewTextBoxColumn3.Expression = "IIF(Descuento>0,  PrecioBase -(PrecioBase * Descuento / 100), PrecioBase)";
            gridViewTextBoxColumn3.HeaderText = "Precio";
            gridViewTextBoxColumn3.Name = "PrecioUnitario";
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 104;
            gridViewTextBoxColumn4.Expression = "";
            gridViewTextBoxColumn4.FieldName = "Precio";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "Total";
            gridViewTextBoxColumn4.MaxWidth = 75;
            gridViewTextBoxColumn4.MinWidth = 75;
            gridViewTextBoxColumn4.Name = "Precio";
            gridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn4.Width = 75;
            gridViewTextBoxColumn5.FieldName = "PrecioBase";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "PrecioBase";
            gridViewTextBoxColumn5.IsVisible = false;
            gridViewTextBoxColumn5.MaxWidth = 75;
            gridViewTextBoxColumn5.MinWidth = 75;
            gridViewTextBoxColumn5.Name = "PrecioBase";
            gridViewTextBoxColumn5.Width = 75;
            gridViewTextBoxColumn6.FieldName = "Descuento";
            gridViewTextBoxColumn6.FormatString = "";
            gridViewTextBoxColumn6.HeaderText = "Descuento";
            gridViewTextBoxColumn6.IsVisible = false;
            gridViewTextBoxColumn6.MaxWidth = 75;
            gridViewTextBoxColumn6.MinWidth = 75;
            gridViewTextBoxColumn6.Name = "Descuento";
            gridViewTextBoxColumn6.Width = 75;
            gridViewTextBoxColumn7.Expression = "Id";
            gridViewTextBoxColumn7.HeaderText = "Id";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "Id";
            gridViewTextBoxColumn7.Width = 44;
            this.GrillaLineasFactura.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7});
            this.GrillaLineasFactura.MasterTemplate.EnableGrouping = false;
            this.GrillaLineasFactura.Name = "GrillaLineasFactura";
            this.GrillaLineasFactura.ReadOnly = true;
            this.GrillaLineasFactura.Size = new System.Drawing.Size(538, 232);
            this.GrillaLineasFactura.TabIndex = 7;
            this.GrillaLineasFactura.Text = "radGridView1";
            this.GrillaLineasFactura.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(447, 492);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(123, 29);
            this.BtnGuardar.TabIndex = 8;
            this.BtnGuardar.Text = "Anular";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // radPanel2
            // 
            this.radPanel2.Controls.Add(this.GrillaLineasFactura);
            this.radPanel2.Location = new System.Drawing.Point(27, 206);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(545, 280);
            this.radPanel2.TabIndex = 9;
            // 
            // FrmAnulacionFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 526);
            this.Controls.Add(this.radPanel2);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.PnlFactura);
            this.Name = "FrmAnulacionFactura";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmAnulacionFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PnlFactura)).EndInit();
            this.PnlFactura.ResumeLayout(false);
            this.PnlFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConcepto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel8)).EndInit();
            this.radLabel8.ResumeLayout(false);
            this.radLabel8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            this.radLabel4.ResumeLayout(false);
            this.radLabel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            this.radLabel6.ResumeLayout(false);
            this.radLabel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.radLabel2.ResumeLayout(false);
            this.radLabel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLineasFactura.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLineasFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            this.radPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CreditosDevolucion.UcBuscadorFactura ucBuscadorFactura;
        private Telerik.WinControls.UI.RadPanel PnlFactura;
        private Telerik.WinControls.UI.RadTextBox TxtImporte;
        private Telerik.WinControls.UI.RadTextBox TxtFecha;
        private Telerik.WinControls.UI.RadTextBox TxtConcepto;
        private Telerik.WinControls.UI.RadTextBox TxtCliente;
        private Telerik.WinControls.UI.RadLabel radLabel8;
        private Telerik.WinControls.UI.RadLabel radLabel9;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Telerik.WinControls.UI.RadLabel radLabel7;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView GrillaLineasFactura;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}