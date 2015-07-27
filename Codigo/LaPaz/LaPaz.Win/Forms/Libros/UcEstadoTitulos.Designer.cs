namespace LaPaz.Win.Forms.Libros
{
    partial class UcEstadoTitulos
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
            this.TitulosConsignadosPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitulosConsignadosPanel
            // 
            this.TitulosConsignadosPanel.Location = new System.Drawing.Point(3, 4);
            this.TitulosConsignadosPanel.Name = "TitulosConsignadosPanel";
            this.TitulosConsignadosPanel.Size = new System.Drawing.Size(19, 17);
            this.TitulosConsignadosPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Libros Consignados a Clientes";
            // 
            // UcEstadoTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TitulosConsignadosPanel);
            this.Name = "UcEstadoTitulos";
            this.Size = new System.Drawing.Size(266, 24);
            this.Load += new System.EventHandler(this.UcEstadoTitulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TitulosConsignadosPanel;
        private System.Windows.Forms.Label label1;
    }
}
