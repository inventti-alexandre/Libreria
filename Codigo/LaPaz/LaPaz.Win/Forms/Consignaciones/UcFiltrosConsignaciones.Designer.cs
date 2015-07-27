using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Consignaciones
{
    partial class UcFiltrosConsignaciones
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
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.CbxProveedor = new LaPaz.Win.Forms.Util.UcFiltroProveedor();
            this.ucProgressSpinner1 = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.DtpFechaFin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFechaInicio = new Telerik.WinControls.UI.RadDateTimePicker();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnLimpiar
            // 
            this.BtnLimpiar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiar.Location = new System.Drawing.Point(492, 46);
            this.BtnLimpiar.Name = "BtnLimpiar";
            this.BtnLimpiar.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiar.TabIndex = 5;
            this.BtnLimpiar.Text = "Limpiar Filtros";
            this.BtnLimpiar.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiar.Click += new System.EventHandler(this.BtnLimpiar_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(16, 50);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(81, 24);
            this.metroLabel3.TabIndex = 39;
            this.metroLabel3.Text = "Proveedor:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(373, 46);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 4;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.EsGasto = false;
            this.CbxProveedor.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProveedor.Location = new System.Drawing.Point(109, 49);
            this.CbxProveedor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.ProveedorId = null;
            this.CbxProveedor.Size = new System.Drawing.Size(210, 26);
            this.CbxProveedor.TabIndex = 3;
            this.CbxProveedor.TabStop = false;
            // 
            // ucProgressSpinner1
            // 
            this.ucProgressSpinner1.Location = new System.Drawing.Point(663, 3);
            this.ucProgressSpinner1.Name = "ucProgressSpinner1";
            this.ucProgressSpinner1.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner1.TabIndex = 47;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(433, 5);
            this.DtpFechaFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaFin.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.NullableValue = null;
            this.DtpFechaFin.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaFin.Size = new System.Drawing.Size(172, 29);
            this.DtpFechaFin.TabIndex = 2;
            this.DtpFechaFin.TabStop = false;
            this.DtpFechaFin.ThemeName = "TelerikMetroBlue";
            this.DtpFechaFin.Value = new System.DateTime(((long)(0)));
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(371, 7);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 24);
            this.radLabel1.TabIndex = 51;
            this.radLabel1.Text = "Hasta:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(109, 7);
            this.DtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaInicio.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.NullableValue = null;
            this.DtpFechaInicio.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaInicio.Size = new System.Drawing.Size(161, 29);
            this.DtpFechaInicio.TabIndex = 1;
            this.DtpFechaInicio.TabStop = false;
            this.DtpFechaInicio.ThemeName = "TelerikMetroBlue";
            this.DtpFechaInicio.Value = new System.DateTime(((long)(0)));
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(16, 7);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 24);
            this.metroLabel1.TabIndex = 50;
            this.metroLabel1.Text = "Desde:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // UcFiltrosConsignaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.DtpFechaFin);
            this.Controls.Add(this.radLabel1);
            this.Controls.Add(this.DtpFechaInicio);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ucProgressSpinner1);
            this.Controls.Add(this.BtnLimpiar);
            this.Controls.Add(this.CbxProveedor);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.BtnBuscar);
            this.Name = "UcFiltrosConsignaciones";
            this.Size = new System.Drawing.Size(821, 98);
            this.Load += new System.EventHandler(this.UcFiltrosConsignaciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnLimpiar;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Util.UcProgressSpinner ucProgressSpinner1;
        private UcFiltroProveedor CbxProveedor;
        private RadDateTimePicker DtpFechaFin;
        private RadLabel radLabel1;
        private RadDateTimePicker DtpFechaInicio;
        private RadLabel metroLabel1;
    }
}
