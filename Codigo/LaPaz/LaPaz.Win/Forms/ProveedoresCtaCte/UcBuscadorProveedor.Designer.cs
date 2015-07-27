namespace LaPaz.Win.Forms.ProveedoresCtaCte
{
    partial class UcBuscadorProveedor
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
            this.ComboProveedores = new Telerik.WinControls.UI.RadDropDownList();
            this.BtnSeleccionar = new Telerik.WinControls.UI.RadButton();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CbxCuentasProveedor = new LaPaz.Win.Forms.Util.UcFiltroCuentasProveedor();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            this.SuspendLayout();
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(3, 9);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(81, 24);
            this.radLabel1.TabIndex = 0;
            this.radLabel1.Text = "Proveedor:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // ComboProveedores
            // 
            this.ComboProveedores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.ComboProveedores.DropDownAnimationEnabled = true;
            this.ComboProveedores.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboProveedores.Location = new System.Drawing.Point(90, 8);
            this.ComboProveedores.MaxDropDownItems = 0;
            this.ComboProveedores.Name = "ComboProveedores";
            this.ComboProveedores.ShowImageInEditorArea = true;
            this.ComboProveedores.Size = new System.Drawing.Size(277, 27);
            this.ComboProveedores.TabIndex = 1;
            this.ComboProveedores.ThemeName = "TelerikMetroBlue";
            this.ComboProveedores.SelectedValueChanged += new System.EventHandler(this.ComboProveedores_SelectedValueChanged);
            // 
            // BtnSeleccionar
            // 
            this.BtnSeleccionar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSeleccionar.Location = new System.Drawing.Point(373, 7);
            this.BtnSeleccionar.Name = "BtnSeleccionar";
            this.BtnSeleccionar.Size = new System.Drawing.Size(103, 29);
            this.BtnSeleccionar.TabIndex = 2;
            this.BtnSeleccionar.Text = "Seleccionar";
            this.BtnSeleccionar.ThemeName = "TelerikMetroBlue";
            this.BtnSeleccionar.Visible = false;
            this.BtnSeleccionar.Click += new System.EventHandler(this.BtnSeleccionar_Click_1);
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(482, 9);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(37, 24);
            this.radLabel2.TabIndex = 3;
            this.radLabel2.Text = "Nro:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // CbxCuentasProveedor
            // 
            this.CbxCuentasProveedor.EsGasto = false;
            this.CbxCuentasProveedor.Location = new System.Drawing.Point(525, 9);
            this.CbxCuentasProveedor.Name = "CbxCuentasProveedor";
            this.CbxCuentasProveedor.ProveedorId = null;
            this.CbxCuentasProveedor.Size = new System.Drawing.Size(204, 27);
            this.CbxCuentasProveedor.TabIndex = 4;
            // 
            // UcBuscadorProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbxCuentasProveedor);
            this.Controls.Add(this.radLabel2);
            this.Controls.Add(this.BtnSeleccionar);
            this.Controls.Add(this.ComboProveedores);
            this.Controls.Add(this.radLabel1);
            this.Name = "UcBuscadorProveedor";
            this.Size = new System.Drawing.Size(749, 44);
            this.Load += new System.EventHandler(this.UcBuscadorProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ComboProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSeleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadDropDownList ComboProveedores;
        private Telerik.WinControls.UI.RadButton BtnSeleccionar;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Util.UcFiltroCuentasProveedor CbxCuentasProveedor;
    }
}
