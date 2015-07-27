namespace Framework.WinForm.Controls.CustomControls
{
    partial class StyledComboBox
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
            this.ComboBoxEstilo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ComboBoxEstilo
            // 
            this.ComboBoxEstilo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboBoxEstilo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ComboBoxEstilo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxEstilo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.ComboBoxEstilo.FormattingEnabled = true;
            this.ComboBoxEstilo.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxEstilo.MaxDropDownItems = 15;
            this.ComboBoxEstilo.Name = "ComboBoxEstilo";
            this.ComboBoxEstilo.Size = new System.Drawing.Size(193, 28);
            this.ComboBoxEstilo.TabIndex = 64;
            // 
            // StyledComboBox
            // 
            this.Controls.Add(this.ComboBoxEstilo);
            this.Size = new System.Drawing.Size(199, 21);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox ComboBoxEstilo;
    }
}
