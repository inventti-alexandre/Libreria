namespace LaPaz.Win.Forms.Ventas
{
    partial class UcTotalesVenta
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.TxtSubtotal = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTotalPagar = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.GrillaPagos = new Telerik.WinControls.UI.RadGridView();
            this.Eliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.BtnAgregarPago = new Telerik.WinControls.UI.RadButton();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.TxtCreditosDevolucion = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtSenas = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtFaltaPagar = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtDesc = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.txtRecargo = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.TxtSenasDisp = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtCreditosDisp = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditosDevolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaltaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenasDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditosDisp)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(189, 6);
            this.TxtSubtotal.MaxLength = 11;
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(141, 26);
            this.TxtSubtotal.TabIndex = 1;
            this.TxtSubtotal.TabStop = false;
            this.TxtSubtotal.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(8, 7);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 24);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Sub Total:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(8, 38);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 24);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Señas:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(8, 68);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(176, 24);
            this.metroLabel2.TabIndex = 36;
            this.metroLabel2.Text = "Créditos por Devolución:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Enabled = false;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(189, 164);
            this.TxtTotalPagar.MaxLength = 11;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(142, 26);
            this.TxtTotalPagar.TabIndex = 5;
            this.TxtTotalPagar.TabStop = false;
            this.TxtTotalPagar.ThemeName = "TelerikMetroBlue";
            this.TxtTotalPagar.TextChanged += new System.EventHandler(this.TxtTotalPagar_TextChanged);
            this.TxtTotalPagar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTotalPagar_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(11, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 24);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Total a Pagar:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaPagos.Location = new System.Drawing.Point(11, 228);
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TipoPago";
            gridViewTextBoxColumn1.HeaderText = "Tipo Pago";
            gridViewTextBoxColumn1.Name = "TipoPago";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 79;
            gridViewTextBoxColumn2.FieldName = "Descripcion";
            gridViewTextBoxColumn2.HeaderText = "Descripción";
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 89;
            gridViewTextBoxColumn3.FieldName = "Importe";
            gridViewTextBoxColumn3.HeaderText = "Importe";
            gridViewTextBoxColumn3.Name = "Importe";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.Width = 102;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn1.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Eliminar";
            gridViewCommandColumn1.Width = 30;
            this.GrillaPagos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewCommandColumn1});
            this.GrillaPagos.MasterTemplate.EnableGrouping = false;
            this.GrillaPagos.Name = "GrillaPagos";
            this.GrillaPagos.ReadOnly = true;
            this.GrillaPagos.Size = new System.Drawing.Size(319, 137);
            this.GrillaPagos.TabIndex = 6;
            this.GrillaPagos.ThemeName = "TelerikMetroBlue";
            this.GrillaPagos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaPagos_CommandCellClick);
            this.GrillaPagos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrillaPagos_KeyUp);
            // 
            // Eliminar
            // 
            this.Eliminar.FillWeight = 25F;
            this.Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Eliminar.HeaderText = "";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Eliminar.Width = 30;
            // 
            // BtnAgregarPago
            // 
            this.BtnAgregarPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPago.Location = new System.Drawing.Point(255, 196);
            this.BtnAgregarPago.Name = "BtnAgregarPago";
            this.BtnAgregarPago.Size = new System.Drawing.Size(75, 29);
            this.BtnAgregarPago.TabIndex = 6;
            this.BtnAgregarPago.Text = "Agregar";
            this.BtnAgregarPago.ThemeName = "TelerikMetroBlue";
            this.BtnAgregarPago.Click += new System.EventHandler(this.BtnAgregarPago_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(8, 98);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 24);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Descuento (%):";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCreditosDevolucion
            // 
            this.TxtCreditosDevolucion.AceptaNegativos = false;
            this.TxtCreditosDevolucion.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditosDevolucion.Location = new System.Drawing.Point(270, 70);
            this.TxtCreditosDevolucion.Name = "TxtCreditosDevolucion";
            this.TxtCreditosDevolucion.Size = new System.Drawing.Size(60, 26);
            this.TxtCreditosDevolucion.TabIndex = 3;
            this.TxtCreditosDevolucion.TabStop = false;
            this.TxtCreditosDevolucion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCreditosDevolucion.ThemeName = "TelerikMetroBlue";
            this.TxtCreditosDevolucion.TextChanged += new System.EventHandler(this.TxtCreditosDevolucion_TextChanged);
            // 
            // TxtSenas
            // 
            this.TxtSenas.AceptaNegativos = false;
            this.TxtSenas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenas.Location = new System.Drawing.Point(269, 38);
            this.TxtSenas.Name = "TxtSenas";
            this.TxtSenas.Size = new System.Drawing.Size(61, 26);
            this.TxtSenas.TabIndex = 2;
            this.TxtSenas.TabStop = false;
            this.TxtSenas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSenas.ThemeName = "TelerikMetroBlue";
            this.TxtSenas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSenas_KeyUp);
            // 
            // TxtFaltaPagar
            // 
            this.TxtFaltaPagar.Enabled = false;
            this.TxtFaltaPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFaltaPagar.Location = new System.Drawing.Point(189, 371);
            this.TxtFaltaPagar.MaxLength = 11;
            this.TxtFaltaPagar.Name = "TxtFaltaPagar";
            this.TxtFaltaPagar.Size = new System.Drawing.Size(141, 26);
            this.TxtFaltaPagar.TabIndex = 7;
            this.TxtFaltaPagar.TabStop = false;
            this.TxtFaltaPagar.ThemeName = "TelerikMetroBlue";
            this.TxtFaltaPagar.TextChanged += new System.EventHandler(this.TxtFaltaPagar_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 372);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 24);
            this.radLabel1.TabIndex = 44;
            this.radLabel1.Text = "Falta Pagar:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(189, 102);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(141, 25);
            this.txtDesc.TabIndex = 4;
            this.txtDesc.TabStop = false;
            this.txtDesc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtDesc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDesc_KeyUp);
            // 
            // txtRecargo
            // 
            this.txtRecargo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecargo.Location = new System.Drawing.Point(189, 133);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(142, 25);
            this.txtRecargo.TabIndex = 5;
            this.txtRecargo.TabStop = false;
            this.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecargo.TextChanged += new System.EventHandler(this.txtRecargo_TextChanged);
            this.txtRecargo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecargo_KeyUp);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(11, 128);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 24);
            this.radLabel2.TabIndex = 43;
            this.radLabel2.Text = "Recargo (%):";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtSenasDisp
            // 
            this.TxtSenasDisp.AceptaNegativos = false;
            this.TxtSenasDisp.Enabled = false;
            this.TxtSenasDisp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenasDisp.Location = new System.Drawing.Point(189, 38);
            this.TxtSenasDisp.Name = "TxtSenasDisp";
            this.TxtSenasDisp.Size = new System.Drawing.Size(62, 26);
            this.TxtSenasDisp.TabIndex = 3;
            this.TxtSenasDisp.TabStop = false;
            this.TxtSenasDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSenasDisp.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCreditosDisp
            // 
            this.TxtCreditosDisp.AceptaNegativos = false;
            this.TxtCreditosDisp.Enabled = false;
            this.TxtCreditosDisp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditosDisp.Location = new System.Drawing.Point(189, 70);
            this.TxtCreditosDisp.Name = "TxtCreditosDisp";
            this.TxtCreditosDisp.Size = new System.Drawing.Size(62, 26);
            this.TxtCreditosDisp.TabIndex = 4;
            this.TxtCreditosDisp.TabStop = false;
            this.TxtCreditosDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCreditosDisp.ThemeName = "TelerikMetroBlue";
            // 
            // UcTotalesVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCreditosDisp);
            this.Controls.Add(this.TxtSenasDisp);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtRecargo);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.TxtFaltaPagar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtSenas);
            this.Controls.Add(this.TxtCreditosDevolucion);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.BtnAgregarPago);
            this.Controls.Add(this.GrillaPagos);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcTotalesVenta";
            this.Size = new System.Drawing.Size(340, 405);
            this.Load += new System.EventHandler(this.UcTotalesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditosDevolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaltaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenasDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditosDisp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtSubtotal;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Telerik.WinControls.UI.RadTextBox TxtTotalPagar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadButton BtnAgregarPago;
        private Telerik.WinControls.UI.RadGridView GrillaPagos;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoPago;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descripcion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Importe;
        private Controls.DeleteCell.DeleteColumn Eliminar;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtCreditosDevolucion;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtSenas;
        private Telerik.WinControls.UI.RadTextBox TxtFaltaPagar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox txtDesc;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox txtRecargo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtSenasDisp;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtCreditosDisp;
    }
}
