namespace LaPaz.Win.Reportes
{
    partial class FrmFacturaVenta
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
            this.RptFacturaVenta = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RptFacturaVenta
            // 
            this.RptFacturaVenta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptFacturaVenta.Location = new System.Drawing.Point(0, 0);
            this.RptFacturaVenta.Name = "RptFacturaVenta";
            this.RptFacturaVenta.Size = new System.Drawing.Size(878, 373);
            this.RptFacturaVenta.TabIndex = 0;
            // 
            // FrmFacturaVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 373);
            this.Controls.Add(this.RptFacturaVenta);
            this.Name = "FrmFacturaVenta";
            this.Text = "Factura Venta";
            this.Load += new System.EventHandler(this.FormFacturaVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptFacturaVenta;
    }
}