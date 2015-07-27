namespace LaPaz.Win.Forms.Util
{
    partial class UcFiltroDesdeHasta
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
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFechaDesde = new Telerik.WinControls.UI.RadDateTimePicker();
            this.DtpFechaHasta = new Telerik.WinControls.UI.RadDateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaDesde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaHasta)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(0, 0);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(53, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Desde:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(191, 0);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(49, 24);
            this.radLabel2.TabIndex = 1;
            this.radLabel2.Text = "Hasta:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFechaDesde
            // 
            this.DtpFechaDesde.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaDesde.Location = new System.Drawing.Point(53, 0);
            this.DtpFechaDesde.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaDesde.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaDesde.Name = "DtpFechaDesde";
            this.DtpFechaDesde.NullableValue = new System.DateTime(2014, 12, 13, 14, 10, 3, 548);
            this.DtpFechaDesde.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaDesde.Size = new System.Drawing.Size(113, 25);
            this.DtpFechaDesde.TabIndex = 2;
            this.DtpFechaDesde.TabStop = false;
            this.DtpFechaDesde.Text = "13/12/2014";
            this.DtpFechaDesde.Value = new System.DateTime(2014, 12, 13, 14, 10, 3, 548);
            this.DtpFechaDesde.ValueChanged += new System.EventHandler(this.DtpFechaDesde_ValueChanged);
            // 
            // DtpFechaHasta
            // 
            this.DtpFechaHasta.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaHasta.Location = new System.Drawing.Point(240, 0);
            this.DtpFechaHasta.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaHasta.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaHasta.Name = "DtpFechaHasta";
            this.DtpFechaHasta.NullableValue = new System.DateTime(2014, 12, 13, 14, 10, 3, 548);
            this.DtpFechaHasta.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaHasta.Size = new System.Drawing.Size(113, 25);
            this.DtpFechaHasta.TabIndex = 3;
            this.DtpFechaHasta.TabStop = false;
            this.DtpFechaHasta.Text = "13/12/2014";
            this.DtpFechaHasta.Value = new System.DateTime(2014, 12, 13, 14, 10, 3, 548);
            this.DtpFechaHasta.ValueChanged += new System.EventHandler(this.DtpFechaHasta_ValueChanged);
            // 
            // UcFiltroDesdeHasta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DtpFechaHasta);
            this.Controls.Add(this.DtpFechaDesde);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.radLabel1);
            this.Name = "UcFiltroDesdeHasta";
            this.Size = new System.Drawing.Size(356, 27);
            this.Load += new System.EventHandler(this.ucFiltroDesdeHasta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaDesde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaDesde;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaHasta;


    }
}
