namespace LaPaz.Win.Forms.Presupuesto
{
    partial class UcTotalesPresupuesto
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
            this.TxtSubtotal = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTotalPagar = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.Eliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.txtDesc = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.txtRecargo = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPagar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // TxtSubtotal
            // 
            this.TxtSubtotal.Enabled = false;
            this.TxtSubtotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSubtotal.Location = new System.Drawing.Point(159, 11);
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
            this.metroLabel7.Location = new System.Drawing.Point(8, 12);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(75, 24);
            this.metroLabel7.TabIndex = 32;
            this.metroLabel7.Text = "Sub Total:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTotalPagar
            // 
            this.TxtTotalPagar.Enabled = false;
            this.TxtTotalPagar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTotalPagar.Location = new System.Drawing.Point(160, 108);
            this.TxtTotalPagar.MaxLength = 11;
            this.TxtTotalPagar.Name = "TxtTotalPagar";
            this.TxtTotalPagar.Size = new System.Drawing.Size(141, 26);
            this.TxtTotalPagar.TabIndex = 5;
            this.TxtTotalPagar.TabStop = false;
            this.TxtTotalPagar.ThemeName = "TelerikMetroBlue";
            this.TxtTotalPagar.TextChanged += new System.EventHandler(this.TxtTotalPagar_TextChanged);
            this.TxtTotalPagar.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtTotalPagar_KeyUp);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(11, 108);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(100, 24);
            this.metroLabel3.TabIndex = 38;
            this.metroLabel3.Text = "Total a Pagar:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
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
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(8, 42);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(110, 24);
            this.metroLabel4.TabIndex = 42;
            this.metroLabel4.Text = "Descuento (%):";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // txtDesc
            // 
            this.txtDesc.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesc.Location = new System.Drawing.Point(159, 46);
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
            this.txtRecargo.Location = new System.Drawing.Point(160, 77);
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(141, 25);
            this.txtRecargo.TabIndex = 5;
            this.txtRecargo.TabStop = false;
            this.txtRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtRecargo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRecargo_KeyUp);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(11, 72);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(93, 24);
            this.radLabel2.TabIndex = 43;
            this.radLabel2.Text = "Recargo (%):";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // UcTotalesPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.txtRecargo);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.TxtTotalPagar);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.TxtSubtotal);
            this.Controls.Add(this.metroLabel7);
            this.Name = "UcTotalesPresupuesto";
            this.Size = new System.Drawing.Size(316, 156);
            this.Load += new System.EventHandler(this.UcTotalesVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TxtSubtotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTotalPagar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDesc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRecargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadTextBox TxtSubtotal;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadTextBox TxtTotalPagar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoPago;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Descripcion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Importe;
        private Controls.DeleteCell.DeleteColumn Eliminar;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox txtDesc;
        private Framework.WinForm.Controls.CustomControls.IntegerTextBox txtRecargo;
        private Telerik.WinControls.UI.RadLabel radLabel2;
    }
}
