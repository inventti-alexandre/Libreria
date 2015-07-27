using System.Windows.Forms;

namespace LaPaz.Win.Forms.Seguridad
{
    partial class FrmAsignarFuncionesARoles
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
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.LbAllItems = new Telerik.WinControls.UI.RadListControl();
            this.LbSelectedItems = new Telerik.WinControls.UI.RadListControl();
            this.BtnMoveToRight = new Telerik.WinControls.UI.RadButton();
            this.BtnMoveAllToLeft = new Telerik.WinControls.UI.RadButton();
            this.BtnMoveAllToRight = new Telerik.WinControls.UI.RadButton();
            this.BtnMoveToLeft = new Telerik.WinControls.UI.RadButton();
            this.UcRoles = new LaPaz.Win.Forms.Util.UcRoles();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbAllItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbSelectedItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveAllToLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveAllToRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveToLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(339, 356);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 28;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(445, 356);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 27;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // LbAllItems
            // 
            this.LbAllItems.CaseSensitiveSort = true;
            this.LbAllItems.ItemHeight = 18;
            this.LbAllItems.Location = new System.Drawing.Point(30, 74);
            this.LbAllItems.Name = "LbAllItems";
            this.LbAllItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbAllItems.Size = new System.Drawing.Size(202, 251);
            this.LbAllItems.TabIndex = 29;
            ((Telerik.WinControls.UI.RadListElement)(this.LbAllItems.GetChildAt(0))).CaseSensitiveSort = true;
            ((Telerik.WinControls.UI.RadScrollBarElement)(this.LbAllItems.GetChildAt(0).GetChildAt(1))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LbAllItems.GetChildAt(0).GetChildAt(1).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LbAllItems.GetChildAt(0).GetChildAt(1).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            ((Telerik.WinControls.UI.RadScrollBarElement)(this.LbAllItems.GetChildAt(0).GetChildAt(2))).Visibility = Telerik.WinControls.ElementVisibility.Collapsed;
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LbAllItems.GetChildAt(0).GetChildAt(2).GetChildAt(1))).BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(238)))), ((int)(((byte)(250)))));
            ((Telerik.WinControls.Primitives.FillPrimitive)(this.LbAllItems.GetChildAt(0).GetChildAt(2).GetChildAt(1))).SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            // 
            // LbSelectedItems
            // 
            this.LbSelectedItems.CaseSensitiveSort = true;
            this.LbSelectedItems.ItemHeight = 18;
            this.LbSelectedItems.Location = new System.Drawing.Point(339, 74);
            this.LbSelectedItems.Name = "LbSelectedItems";
            this.LbSelectedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbSelectedItems.Size = new System.Drawing.Size(202, 251);
            this.LbSelectedItems.TabIndex = 30;
            // 
            // BtnMoveToRight
            // 
            this.BtnMoveToRight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveToRight.Location = new System.Drawing.Point(249, 203);
            this.BtnMoveToRight.Name = "BtnMoveToRight";
            this.BtnMoveToRight.Size = new System.Drawing.Size(72, 30);
            this.BtnMoveToRight.TabIndex = 29;
            this.BtnMoveToRight.Text = ">";
            this.BtnMoveToRight.ThemeName = "TelerikMetroBlue";
            this.BtnMoveToRight.Click += new System.EventHandler(this.BtnMoveToRight_Click);
            // 
            // BtnMoveAllToLeft
            // 
            this.BtnMoveAllToLeft.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveAllToLeft.Location = new System.Drawing.Point(249, 154);
            this.BtnMoveAllToLeft.Name = "BtnMoveAllToLeft";
            this.BtnMoveAllToLeft.Size = new System.Drawing.Size(72, 30);
            this.BtnMoveAllToLeft.TabIndex = 30;
            this.BtnMoveAllToLeft.Text = "<<";
            this.BtnMoveAllToLeft.ThemeName = "TelerikMetroBlue";
            this.BtnMoveAllToLeft.Click += new System.EventHandler(this.BtnMoveAllToLeft_Click);
            // 
            // BtnMoveAllToRight
            // 
            this.BtnMoveAllToRight.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveAllToRight.Location = new System.Drawing.Point(249, 106);
            this.BtnMoveAllToRight.Name = "BtnMoveAllToRight";
            this.BtnMoveAllToRight.Size = new System.Drawing.Size(72, 30);
            this.BtnMoveAllToRight.TabIndex = 31;
            this.BtnMoveAllToRight.Text = ">>";
            this.BtnMoveAllToRight.ThemeName = "TelerikMetroBlue";
            this.BtnMoveAllToRight.Click += new System.EventHandler(this.BtnMoveAllToRight_Click);
            // 
            // BtnMoveToLeft
            // 
            this.BtnMoveToLeft.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMoveToLeft.Location = new System.Drawing.Point(249, 253);
            this.BtnMoveToLeft.Name = "BtnMoveToLeft";
            this.BtnMoveToLeft.Size = new System.Drawing.Size(72, 30);
            this.BtnMoveToLeft.TabIndex = 30;
            this.BtnMoveToLeft.Text = "<";
            this.BtnMoveToLeft.ThemeName = "TelerikMetroBlue";
            this.BtnMoveToLeft.Click += new System.EventHandler(this.BtnMoveToLeft_Click);
            // 
            // UcRoles
            // 
            this.UcRoles.Location = new System.Drawing.Point(71, 30);
            this.UcRoles.Name = "UcRoles";
            this.UcRoles.RoleId = null;
            this.UcRoles.Size = new System.Drawing.Size(277, 27);
            this.UcRoles.TabIndex = 32;
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(30, 31);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(33, 24);
            this.metroLabel1.TabIndex = 83;
            this.metroLabel1.Text = "Rol:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // FrmAsignarFuncionesARoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.BtnCancelar;
            this.ClientSize = new System.Drawing.Size(576, 398);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.UcRoles);
            this.Controls.Add(this.BtnMoveToLeft);
            this.Controls.Add(this.BtnMoveAllToRight);
            this.Controls.Add(this.BtnMoveAllToLeft);
            this.Controls.Add(this.BtnMoveToRight);
            this.Controls.Add(this.LbSelectedItems);
            this.Controls.Add(this.LbAllItems);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAsignarFuncionesARoles";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Asignar Funciones";
            this.Load += new System.EventHandler(this.FrmAsignarFuncionesARoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbAllItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbSelectedItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveAllToLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveAllToRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMoveToLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadListControl LbAllItems;
        private Telerik.WinControls.UI.RadListControl LbSelectedItems;
        private Telerik.WinControls.UI.RadButton BtnMoveToRight;
        private Telerik.WinControls.UI.RadButton BtnMoveAllToLeft;
        private Telerik.WinControls.UI.RadButton BtnMoveAllToRight;
        private Telerik.WinControls.UI.RadButton BtnMoveToLeft;
        private Util.UcRoles UcRoles;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
    }
}