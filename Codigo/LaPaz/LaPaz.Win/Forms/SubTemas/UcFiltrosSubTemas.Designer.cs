using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.SubTemas
{
    partial class UcFiltrosSubTemas
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
            this.BtnLimpiar = new Telerik.WinControls.UI.RadButton();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.CbxTemas = new LaPaz.Win.Forms.Util.UcFiltroTemas();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(5, 58);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiar.TabIndex = 46;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(95, 14);
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(301, 26);
            this.TxtNombre.TabIndex = 43;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.ThemeName = "TelerikMetroBlue";
            this.TxtNombre.TextChanged += new System.EventHandler(this.TxtNombre_TextChanged);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(5, 15);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 24);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Nombre:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(124, 58);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 37;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ucProgressSpinner1.Location = new System.Drawing.Point(830, 15);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 49;
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(429, 15);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(48, 24);
            this.radLabel1.TabIndex = 50;
            this.radLabel1.Text = "Tema:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // CbxTemas
            // 
            this.CbxTemas.Location = new System.Drawing.Point(477, 14);
            this.CbxTemas.Name = "CbxTemas";
            this.CbxTemas.Size = new System.Drawing.Size(277, 27);
            this.CbxTemas.TabIndex = 51;
            this.CbxTemas.TemaId = null;
            // 
            // UcFiltrosSubTemas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CbxTemas);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.ucProgressSpinner1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "UcFiltrosSubTemas";
            this.Size = new System.Drawing.Size(987, 110);
            this.Load += new System.EventHandler(this.UcFiltrosSubTema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnLimpiar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private RadLabel radLabel1;
        private Util.UcFiltroTemas CbxTemas;
    }
}
