namespace Framework.WinForm.Controls
{
    partial class MetroPager
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
            Telerik.WinControls.UI.RadListDataItem radListDataItem1 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem2 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem3 = new Telerik.WinControls.UI.RadListDataItem();
            Telerik.WinControls.UI.RadListDataItem radListDataItem4 = new Telerik.WinControls.UI.RadListDataItem();
            this.CbxPageSize = new Telerik.WinControls.UI.RadDropDownList();
            this.LblOf = new Telerik.WinControls.UI.RadLabel();
            this.TxtPageTotal = new Telerik.WinControls.UI.RadTextBox();
            this.MetroBlueTheme = new Telerik.WinControls.Themes.TelerikMetroBlueTheme();
            this.BtnLastPage = new Telerik.WinControls.UI.RadButton();
            this.BtnNextPage = new Telerik.WinControls.UI.RadButton();
            this.BtnPreviousPage = new Telerik.WinControls.UI.RadButton();
            this.BtnFirstPage = new Telerik.WinControls.UI.RadButton();
            this.TxtCurrentPage = new Framework.WinForm.Controls.CustomControls.IntegerTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CbxPageSize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblOf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPageTotal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLastPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNextPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPreviousPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFirstPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCurrentPage)).BeginInit();
            this.SuspendLayout();
            // 
            // CbxPageSize
            // 
            this.CbxPageSize.DropDownAnimationEnabled = true;
            this.CbxPageSize.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList;
            this.CbxPageSize.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            radListDataItem1.Text = "10";
            radListDataItem1.TextWrap = true;
            radListDataItem2.Text = "20";
            radListDataItem2.TextWrap = true;
            radListDataItem3.Text = "50";
            radListDataItem3.TextWrap = true;
            radListDataItem4.Text = "100";
            radListDataItem4.TextWrap = true;
            this.CbxPageSize.Items.Add(radListDataItem1);
            this.CbxPageSize.Items.Add(radListDataItem2);
            this.CbxPageSize.Items.Add(radListDataItem3);
            this.CbxPageSize.Items.Add(radListDataItem4);
            this.CbxPageSize.Location = new System.Drawing.Point(317, 9);
            this.CbxPageSize.MaxDropDownItems = 0;
            this.CbxPageSize.Name = "CbxPageSize";
            this.CbxPageSize.ShowImageInEditorArea = true;
            this.CbxPageSize.Size = new System.Drawing.Size(59, 27);
            this.CbxPageSize.TabIndex = 6;
            this.CbxPageSize.ThemeName = "TelerikMetroBlue";
            // 
            // LblOf
            // 
            this.LblOf.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOf.Location = new System.Drawing.Point(145, 10);
            this.LblOf.Name = "LblOf";
            this.LblOf.Size = new System.Drawing.Size(26, 24);
            this.LblOf.TabIndex = 6;
            this.LblOf.Text = "De";
            this.LblOf.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPageTotal
            // 
            this.TxtPageTotal.Enabled = false;
            this.TxtPageTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPageTotal.Location = new System.Drawing.Point(176, 9);
            this.TxtPageTotal.Name = "TxtPageTotal";
            this.TxtPageTotal.Size = new System.Drawing.Size(55, 26);
            this.TxtPageTotal.TabIndex = 3;
            this.TxtPageTotal.TabStop = false;
            this.TxtPageTotal.Text = "1";
            this.TxtPageTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPageTotal.ThemeName = "TelerikMetroBlue";
            // 
            // BtnLastPage
            // 
            this.BtnLastPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLastPage.Image = global::Framework.WinForm.Controls.Properties.Resources.pager_last;
            this.BtnLastPage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnLastPage.Location = new System.Drawing.Point(277, 8);
            this.BtnLastPage.Name = "BtnLastPage";
            this.BtnLastPage.Size = new System.Drawing.Size(34, 29);
            this.BtnLastPage.TabIndex = 5;
            this.BtnLastPage.ThemeName = "TelerikMetroBlue";
            // 
            // BtnNextPage
            // 
            this.BtnNextPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNextPage.Image = global::Framework.WinForm.Controls.Properties.Resources.pager_next;
            this.BtnNextPage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnNextPage.Location = new System.Drawing.Point(237, 8);
            this.BtnNextPage.Name = "BtnNextPage";
            this.BtnNextPage.Size = new System.Drawing.Size(34, 29);
            this.BtnNextPage.TabIndex = 4;
            this.BtnNextPage.ThemeName = "TelerikMetroBlue";
            // 
            // BtnPreviousPage
            // 
            this.BtnPreviousPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPreviousPage.Image = global::Framework.WinForm.Controls.Properties.Resources.pager_previous;
            this.BtnPreviousPage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPreviousPage.Location = new System.Drawing.Point(48, 8);
            this.BtnPreviousPage.Name = "BtnPreviousPage";
            this.BtnPreviousPage.Size = new System.Drawing.Size(34, 29);
            this.BtnPreviousPage.TabIndex = 1;
            this.BtnPreviousPage.ThemeName = "TelerikMetroBlue";
            // 
            // BtnFirstPage
            // 
            this.BtnFirstPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFirstPage.Image = global::Framework.WinForm.Controls.Properties.Resources.pager_first;
            this.BtnFirstPage.ImageAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnFirstPage.Location = new System.Drawing.Point(8, 8);
            this.BtnFirstPage.Name = "BtnFirstPage";
            this.BtnFirstPage.Size = new System.Drawing.Size(34, 29);
            this.BtnFirstPage.TabIndex = 0;
            this.BtnFirstPage.ThemeName = "TelerikMetroBlue";
            // 
            // TxtCurrentPage
            // 
            this.TxtCurrentPage.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCurrentPage.Location = new System.Drawing.Point(88, 9);
            this.TxtCurrentPage.Name = "TxtCurrentPage";
            this.TxtCurrentPage.Size = new System.Drawing.Size(55, 26);
            this.TxtCurrentPage.TabIndex = 7;
            this.TxtCurrentPage.TabStop = false;
            this.TxtCurrentPage.Text = "1";
            this.TxtCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCurrentPage.ThemeName = "TelerikMetroBlue";
            // 
            // MetroPager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TxtCurrentPage);
            this.Controls.Add(this.TxtPageTotal);
            this.Controls.Add(this.LblOf);
            this.Controls.Add(this.CbxPageSize);
            this.Controls.Add(this.BtnLastPage);
            this.Controls.Add(this.BtnNextPage);
            this.Controls.Add(this.BtnPreviousPage);
            this.Controls.Add(this.BtnFirstPage);
            this.Name = "MetroPager";
            this.Size = new System.Drawing.Size(386, 42);
            ((System.ComponentModel.ISupportInitialize)(this.CbxPageSize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LblOf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPageTotal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLastPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNextPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnPreviousPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnFirstPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCurrentPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnFirstPage;
        private Telerik.WinControls.UI.RadButton BtnPreviousPage;
        private Telerik.WinControls.UI.RadButton BtnNextPage;
        private Telerik.WinControls.UI.RadButton BtnLastPage;
        private Telerik.WinControls.UI.RadDropDownList CbxPageSize;
        private Telerik.WinControls.UI.RadLabel LblOf;
        private Telerik.WinControls.UI.RadTextBox TxtPageTotal;
        private CustomControls.IntegerTextBox TxtCurrentPage;
        private Telerik.WinControls.Themes.TelerikMetroBlueTheme MetroBlueTheme;

    }
}
