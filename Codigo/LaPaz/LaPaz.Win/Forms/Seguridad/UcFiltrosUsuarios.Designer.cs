﻿namespace LaPaz.Win.Forms.Seguridad
{
    partial class UcFiltrosUsuarios
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
            this.TxtCuit = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.UcHabilitado = new LaPaz.Win.Forms.Util.UcFiltroSiNo();
            this.LbHabilitado = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbHabilitado)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(5, 15);
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
            this.TxtTextoBuscar.Location = new System.Drawing.Point(81, 15);
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
            // TxtCuit
            // 
            this.TxtCuit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuit.Location = new System.Drawing.Point(81, 53);
            this.TxtCuit.Name = "TxtCuit";
            this.TxtCuit.Size = new System.Drawing.Size(277, 26);
            this.TxtCuit.TabIndex = 36;
            this.TxtCuit.TabStop = false;
            this.TxtCuit.ThemeName = "TelerikMetroBlue";
            this.TxtCuit.TextChanged += new System.EventHandler(this.TxtCuit_TextChanged);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel2.Location = new System.Drawing.Point(5, 54);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(76, 24);
            this.metroLabel2.TabIndex = 37;
            this.metroLabel2.Text = "CUIT/DNI:";
            this.metroLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // UcHabilitado
            // 
            this.UcHabilitado.Value = 0;
            this.UcHabilitado.Location = new System.Drawing.Point(469, 14);
            this.UcHabilitado.Name = "UcHabilitado";
            this.UcHabilitado.Size = new System.Drawing.Size(201, 27);
            this.UcHabilitado.TabIndex = 38;
            // 
            // LbHabilitado
            // 
            this.LbHabilitado.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbHabilitado.Location = new System.Drawing.Point(383, 15);
            this.LbHabilitado.Name = "LbHabilitado";
            this.LbHabilitado.Size = new System.Drawing.Size(81, 24);
            this.LbHabilitado.TabIndex = 1;
            this.LbHabilitado.Text = "Habilitado:";
            this.LbHabilitado.ThemeName = "TelerikMetroBlue";
            // 
            // UcFiltrosUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LbHabilitado);
            this.Controls.Add(this.UcHabilitado);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.TxtCuit);
            this.Controls.Add(this.BtnLimpiarFiltros);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.TxtTextoBuscar);
            this.Controls.Add(this.metroLabel1);
            this.Name = "UcFiltrosUsuarios";
            this.Size = new System.Drawing.Size(681, 123);
            this.Load += new System.EventHandler(this.UcFiltrosUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtTextoBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtCuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbHabilitado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtTextoBuscar;
        private Telerik.WinControls.UI.RadButton BtnBuscarCliente;
        private Telerik.WinControls.UI.RadButton BtnLimpiarFiltros;
        private Telerik.WinControls.UI.RadTextBox TxtCuit;
        private Telerik.WinControls.UI.RadLabel metroLabel2;
        private Util.UcFiltroSiNo UcHabilitado;
        private Telerik.WinControls.UI.RadLabel LbHabilitado;
    }
}
