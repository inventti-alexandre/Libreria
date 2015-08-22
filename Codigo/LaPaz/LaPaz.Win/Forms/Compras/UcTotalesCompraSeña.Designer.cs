namespace LaPaz.Win.Forms.Compras
{
    partial class UcTotalesCompraSeña
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.TxtSenas = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtFaltaPagar = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtSenasDisp = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.BtnAgregarPago = new Telerik.WinControls.UI.RadButton();
            this.GrillaPagos = new Telerik.WinControls.UI.RadGridView();
            this.TxtTotalPagar = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtSubtotal = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.Eliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.TxtCreditos = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.TxtCreditoDisp = new Framework.WinForm.Controls.CustomControls.DecimalTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaltaPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenasDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditoDisp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSenas
            // 
            this.TxtSenas.AceptaNegativos = false;
            this.TxtSenas.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenas.Location = new System.Drawing.Point(264, 43);
            this.TxtSenas.Name = "TxtSenas";
            this.TxtSenas.Size = new System.Drawing.Size(66, 26);
            this.TxtSenas.TabIndex = 2;
            this.TxtSenas.TabStop = false;
            this.TxtSenas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSenas.ThemeName = "TelerikMetroBlue";
            this.TxtSenas.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtSenas_KeyUp_1);
            // 
            // TxtFaltaPagar
            // 
            this.TxtFaltaPagar.Enabled = false;
            this.TxtFaltaPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFaltaPagar.Location = new System.Drawing.Point(189, 330);
            this.TxtFaltaPagar.MaxLength = 11;
            this.TxtFaltaPagar.Name = "TxtFaltaPagar";
            this.TxtFaltaPagar.Size = new System.Drawing.Size(141, 26);
            this.TxtFaltaPagar.TabIndex = 43;
            this.TxtFaltaPagar.TabStop = false;
            this.TxtFaltaPagar.ThemeName = "TelerikMetroBlue";
            this.TxtFaltaPagar.TextChanged += new System.EventHandler(this.TxtFaltaPagar_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(8, 331);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(86, 24);
            this.radLabel1.TabIndex = 44;
            this.radLabel1.Text = "Falta Pagar:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtSenasDisp
            // 
            this.TxtSenasDisp.AceptaNegativos = false;
            this.TxtSenasDisp.Enabled = false;
            this.TxtSenasDisp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSenasDisp.Location = new System.Drawing.Point(189, 43);
            this.TxtSenasDisp.Name = "TxtSenasDisp";
            this.TxtSenasDisp.Size = new System.Drawing.Size(66, 26);
            this.TxtSenasDisp.TabIndex = 1;
            this.TxtSenasDisp.TabStop = false;
            this.TxtSenasDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtSenasDisp.ThemeName = "TelerikMetroBlue";
            this.TxtSenasDisp.TextChanged += new System.EventHandler(this.TxtSenas_TextChanged);
            // 
            // BtnAgregarPago
            // 
            this.BtnAgregarPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPago.Location = new System.Drawing.Point(255, 140);
            this.BtnAgregarPago.Name = "BtnAgregarPago";
            this.BtnAgregarPago.Size = new System.Drawing.Size(75, 29);
            this.BtnAgregarPago.TabIndex = 5;
            this.BtnAgregarPago.Text = "Agregar";
            this.BtnAgregarPago.ThemeName = "TelerikMetroBlue";
            this.BtnAgregarPago.Click += new System.EventHandler(this.BtnAgregarPago_Click);
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaPagos.Location = new System.Drawing.Point(8, 175);
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn4.FieldName = "TipoPago";
            gridViewTextBoxColumn4.HeaderText = "Tipo Pago";
            gridViewTextBoxColumn4.Name = "TipoPago";
            gridViewTextBoxColumn4.ReadOnly = true;
            gridViewTextBoxColumn4.Width = 79;
            gridViewTextBoxColumn5.FieldName = "Descripcion";
            gridViewTextBoxColumn5.HeaderText = "Descripción";
            gridViewTextBoxColumn5.Name = "Descripcion";
            gridViewTextBoxColumn5.ReadOnly = true;
            gridViewTextBoxColumn5.Width = 89;
            gridViewTextBoxColumn6.FieldName = "Importe";
            gridViewTextBoxColumn6.HeaderText = "Importe";
            gridViewTextBoxColumn6.Name = "Importe";
            gridViewTextBoxColumn6.ReadOnly = true;
            gridViewTextBoxColumn6.Width = 102;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn2.ImageLayout = System.Windows.Forms.ImageLayout.Center;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "Eliminar";
            gridViewCommandColumn2.Width = 30;
            this.GrillaPagos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewCommandColumn2});
            this.GrillaPagos.MasterTemplate.EnableGrouping = false;
            this.GrillaPagos.Name = "GrillaPagos";
            this.GrillaPagos.ReadOnly = true;
            this.GrillaPagos.Size = new System.Drawing.Size(319, 150);
            this.GrillaPagos.TabIndex = 6;
            this.GrillaPagos.ThemeName = "TelerikMetroBlue";
            this.GrillaPagos.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaPagos_CommandCellClick);
            this.GrillaPagos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GrillaPagos_KeyUp);
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Enabled = false;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(189, 107);
            this.TxtTotalPagar.MaxLength = 11;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(141, 26);
            this.TxtTotalPagar.TabIndex = 4;
            this.TxtTotalPagar.TabStop = false;
            this.TxtTotalPagar.ThemeName = "TelerikMetroBlue";
            this.TxtTotalPagar.TextChanged += new System.EventHandler(this.TxtTotalPagar_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(8, 109);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 24);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Total a Pagar:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(8, 45);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(50, 24);
            this.metroLabel1.TabIndex = 34;
            this.metroLabel1.Text = "Señas:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(189, 11);
            this.TxtSubtotal.MaxLength = 11;
            this.TxtSubtotal.Name = "TxtSubtotal";
            this.TxtSubtotal.Size = new System.Drawing.Size(141, 26);
            this.TxtSubtotal.TabIndex = 0;
            this.TxtSubtotal.TabStop = false;
            this.TxtSubtotal.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(8, 12);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 24);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Sub Total:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
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
            // TxtCreditos
            // 
            this.TxtCreditos.AceptaNegativos = false;
            this.TxtCreditos.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditos.Location = new System.Drawing.Point(264, 75);
            this.TxtCreditos.Name = "TxtCreditos";
            this.TxtCreditos.Size = new System.Drawing.Size(66, 26);
            this.TxtCreditos.TabIndex = 36;
            this.TxtCreditos.TabStop = false;
            this.TxtCreditos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCreditos.ThemeName = "TelerikMetroBlue";
            this.TxtCreditos.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtCreditos_KeyUp);
            // 
            // TxtCreditoDisp
            // 
            this.TxtCreditoDisp.AceptaNegativos = false;
            this.TxtCreditoDisp.Enabled = false;
            this.TxtCreditoDisp.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCreditoDisp.Location = new System.Drawing.Point(189, 75);
            this.TxtCreditoDisp.Name = "TxtCreditoDisp";
            this.TxtCreditoDisp.Size = new System.Drawing.Size(66, 26);
            this.TxtCreditoDisp.TabIndex = 35;
            this.TxtCreditoDisp.TabStop = false;
            this.TxtCreditoDisp.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtCreditoDisp.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(8, 77);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(68, 24);
            this.radLabel2.TabIndex = 37;
            this.radLabel2.Text = "Créditos:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // UcTotalesCompraSeña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCreditos);
            this.Controls.Add(this.TxtSenas);
            this.Controls.Add(this.TxtCreditoDisp);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.TxtFaltaPagar);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.TxtSenasDisp);
            this.Controls.Add(this.BtnAgregarPago);
            this.Controls.Add(this.GrillaPagos);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcTotalesCompraSeña";
            this.Size = new System.Drawing.Size(340, 407);
            this.Load += new System.EventHandler(this.UcTotalesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtFaltaPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSenasDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCreditoDisp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtSubtotal;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtTotalPagar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadButton BtnAgregarPago;
        private Telerik.WinControls.UI.RadGridView GrillaPagos;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoPago;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descripcion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Importe;
        private Controls.DeleteCell.DeleteColumn Eliminar;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtSenasDisp;
        private Telerik.WinControls.UI.RadTextBox TxtFaltaPagar;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtSenas;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtCreditos;
        private Framework.WinForm.Controls.CustomControls.DecimalTextBox TxtCreditoDisp;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
