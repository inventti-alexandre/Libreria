namespace LaPaz.Win.Forms.Util
{
    partial class UcMessage
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
            this.LbMessage = new Telerik.WinControls.UI.RadLabel();
            this.PnMessage = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LbMessage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnMessage)).BeginInit();
            this.PnMessage.SuspendLayout();
            this.SuspendLayout();
            // 
            // LbMessage
            // 
            this.LbMessage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMessage.Location = new System.Drawing.Point(10, 10);
            this.LbMessage.Name = "LbMessage";
            this.LbMessage.Size = new System.Drawing.Size(83, 24);
            this.LbMessage.TabIndex = 0;
            this.LbMessage.Text = "{{Mensaje}}";
            // 
            // PnMessage
            // 
            this.PnMessage.Controls.Add(this.LbMessage);
            this.PnMessage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnMessage.Location = new System.Drawing.Point(0, 0);
            this.PnMessage.Name = "PnMessage";
            this.PnMessage.Size = new System.Drawing.Size(381, 43);
            this.PnMessage.TabIndex = 1;
            // 
            // UcMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PnMessage);
            this.Name = "UcMessage";
            this.Size = new System.Drawing.Size(381, 43);
            ((System.ComponentModel.ISupportInitialize)(this.LbMessage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnMessage)).EndInit();
            this.PnMessage.ResumeLayout(false);
            this.PnMessage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel LbMessage;
        private Telerik.WinControls.UI.RadPanel PnMessage;
    }
}
