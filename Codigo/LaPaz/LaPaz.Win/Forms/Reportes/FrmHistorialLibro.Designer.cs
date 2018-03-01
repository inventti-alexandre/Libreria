namespace LaPaz.Win.Forms.Reportes
{
    partial class FrmHistorialLibro
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.TxtCodigo2 = new Telerik.WinControls.UI.RadTextBox();
            this.TxtCodigo1 = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.BtnVerInforme = new Telerik.WinControls.UI.RadButton();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerInforme)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.97248F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.02752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1154, 436);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 322F));
            this.tableLayoutPanel2.Controls.Add(this.TxtCodigo2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.TxtCodigo1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.metroLabel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.BtnVerInforme, 3, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(712, 67);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // TxtCodigo2
            // 
            this.TxtCodigo2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo2.Location = new System.Drawing.Point(179, 4);
            this.TxtCodigo2.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo2.MaxLength = 13;
            this.TxtCodigo2.Name = "TxtCodigo2";
            this.TxtCodigo2.Size = new System.Drawing.Size(204, 31);
            this.TxtCodigo2.TabIndex = 37;
            this.TxtCodigo2.TabStop = false;
            this.TxtCodigo2.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCodigo1
            // 
            this.TxtCodigo1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo1.Location = new System.Drawing.Point(102, 4);
            this.TxtCodigo1.Margin = new System.Windows.Forms.Padding(4);
            this.TxtCodigo1.MaxLength = 4;
            this.TxtCodigo1.Name = "TxtCodigo1";
            this.TxtCodigo1.Size = new System.Drawing.Size(68, 31);
            this.TxtCodigo1.TabIndex = 36;
            this.TxtCodigo1.TabStop = false;
            this.TxtCodigo1.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(75, 29);
            this.metroLabel1.TabIndex = 38;
            this.metroLabel1.Text = "Código:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // BtnVerInforme
            // 
            this.BtnVerInforme.Location = new System.Drawing.Point(392, 3);
            this.BtnVerInforme.Name = "BtnVerInforme";
            this.BtnVerInforme.Size = new System.Drawing.Size(185, 32);
            this.BtnVerInforme.TabIndex = 39;
            this.BtnVerInforme.Text = "Ver informe";
            this.BtnVerInforme.ThemeName = "TelerikMetroBlue";
            this.BtnVerInforme.Click += new System.EventHandler(this.BtnVerInforme_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 77);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1148, 356);
            this.reportViewer1.TabIndex = 1;
            // 
            // FrmHistorialLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 460);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "FrmHistorialLibro";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Historial Movimientos de Titulo";
            this.Load += new System.EventHandler(this.FrmHistorialLibro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCodigo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnVerInforme)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo2;
        private Telerik.WinControls.UI.RadTextBox TxtCodigo1;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadButton BtnVerInforme;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;

    }
}