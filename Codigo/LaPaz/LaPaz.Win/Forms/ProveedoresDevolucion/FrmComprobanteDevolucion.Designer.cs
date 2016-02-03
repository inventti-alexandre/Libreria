namespace LaPaz.Win.ProveedoresDevolucion
{
    partial class FrmComprobanteDevolucion
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
            this.RptComprobante = new Microsoft.Reporting.WinForms.ReportViewer();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // RptComprobante
            // 
            this.RptComprobante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RptComprobante.Location = new System.Drawing.Point(0, 0);
            this.RptComprobante.Name = "RptComprobante";
            this.RptComprobante.Size = new System.Drawing.Size(1168, 465);
            this.RptComprobante.TabIndex = 0;
            // 
            // FrmComprobanteDevolucion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 465);
            this.Controls.Add(this.RptComprobante);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmComprobanteDevolucion";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Devolucion";
            this.Load += new System.EventHandler(this.FormFacturaVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer RptComprobante;
    }
}