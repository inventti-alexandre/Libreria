namespace LaPaz.Win.Forms.Bancos
{
    partial class UcFiltrosBancos
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
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtTextoBuscar = new Telerik.WinControls.UI.RadTextBox();
            this.BtnBuscarCliente = new Telerik.WinControls.UI.RadButton();
            this.BtnLimpiarFiltros = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(5, 28);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 24);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "Nombre:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtTextoBuscar
            // 
            this.TxtTextoBuscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtTextoBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTextoBuscar.Location = new System.Drawing.Point(81, 27);
            this.TxtTextoBuscar.Name = "TxtTextoBuscar";
            this.TxtTextoBuscar.Size = new System.Drawing.Size(277, 26);
            this.TxtTextoBuscar.TabIndex = 1;
            this.TxtTextoBuscar.TabStop = false;
            this.TxtTextoBuscar.ThemeName = "TelerikMetroBlue";
            this.TxtTextoBuscar.TextChanged += new System.EventHandler(this.TxtTextoBuscar_TextChanged);
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarCliente.Location = new System.Drawing.Point(123, 93);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscarCliente.TabIndex = 2;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.ThemeName = "TelerikMetroBlue";
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // BtnLimpiarFiltros
            // 
            this.BtnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarFiltros.Location = new System.Drawing.Point(5, 93);
            this.BtnLimpiarFiltros.Name = "BtnLimpiarFiltros";
            this.BtnLimpiarFiltros.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiarFiltros.TabIndex = 35;
            this.BtnLimpiarFiltros.Text = "Limpiar Filtros";
            this.BtnLimpiarFiltros.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
            // 
            // UcFiltrosBancos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnLimpiarFiltros);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtTextoBuscar);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UcFiltrosBancos";
            this.Size = new System.Drawing.Size(711, 123);
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtTextoBuscar;
        private Telerik.WinControls.UI.RadButton BtnBuscarCliente;
        private Telerik.WinControls.UI.RadButton BtnLimpiarFiltros;
    }
}
