namespace LaPaz.Win.Forms.Compras
{
    partial class UcTotalesSeña
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
            this.GrillaPagos = new Telerik.WinControls.UI.RadGridView();
            this.Eliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.BtnAgregarPago = new Telerik.WinControls.UI.RadButton();
            this.TxtTotal = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarPago)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrillaPagos.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GrillaPagos.Location = new System.Drawing.Point(11, 38);
            // 
            // GrillaPagos
            // 
            this.GrillaPagos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TipoPago";
            gridViewTextBoxColumn1.HeaderText = "Tipo Pago";
            gridViewTextBoxColumn1.Name = "TipoPago";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 174;
            gridViewTextBoxColumn2.FieldName = "Descripcion";
            gridViewTextBoxColumn2.HeaderText = "Descripción";
            gridViewTextBoxColumn2.Name = "Descripcion";
            gridViewTextBoxColumn2.ReadOnly = true;
            gridViewTextBoxColumn2.Width = 196;
            gridViewTextBoxColumn3.FieldName = "Importe";
            gridViewTextBoxColumn3.FormatString = "{0:c2}";
            gridViewTextBoxColumn3.HeaderText = "Importe";
            gridViewTextBoxColumn3.Name = "Importe";
            gridViewTextBoxColumn3.ReadOnly = true;
            gridViewTextBoxColumn3.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn3.Width = 226;
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
            this.GrillaPagos.Size = new System.Drawing.Size(645, 171);
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
            this.BtnAgregarPago.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAgregarPago.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarPago.Location = new System.Drawing.Point(581, 3);
            this.BtnAgregarPago.Name = "BtnAgregarPago";
            this.BtnAgregarPago.Size = new System.Drawing.Size(75, 29);
            this.BtnAgregarPago.TabIndex = 5;
            this.BtnAgregarPago.Text = "Agregar";
            this.BtnAgregarPago.ThemeName = "TelerikMetroBlue";
            this.BtnAgregarPago.Click += new System.EventHandler(this.BtnAgregarPago_Click);
            // 
            // TxtTotal
            // 
            this.TxtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTotal.Enabled = false;
            this.TxtTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotal.Location = new System.Drawing.Point(515, 227);
            this.TxtTotal.MaxLength = 11;
            this.TxtTotal.Name = "TxtTotal";
            this.TxtTotal.Size = new System.Drawing.Size(141, 26);
            this.TxtTotal.TabIndex = 43;
            this.TxtTotal.TabStop = false;
            this.TxtTotal.ThemeName = "TelerikMetroBlue";
            this.TxtTotal.TextChanged += new System.EventHandler(this.TxtTotal_TextChanged);
            // 
            // radLabel1
            // 
            this.radLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(464, 229);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(45, 24);
            this.radLabel1.TabIndex = 44;
            this.radLabel1.Text = "Total:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // UcTotalesSeña
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtTotal);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.BtnAgregarPago);
            this.Controls.Add(this.GrillaPagos);
            this.Name = "UcTotalesSeña";
            this.Size = new System.Drawing.Size(659, 263);
            this.Load += new System.EventHandler(this.UcTotalesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaPagos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarPago)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnAgregarPago;
        private Telerik.WinControls.UI.RadGridView GrillaPagos;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoPago;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descripcion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Importe;
        private Controls.DeleteCell.DeleteColumn Eliminar;
        private Telerik.WinControls.UI.RadTextBox TxtTotal;
        private Telerik.WinControls.UI.RadLabel radLabel1;
    }
}
