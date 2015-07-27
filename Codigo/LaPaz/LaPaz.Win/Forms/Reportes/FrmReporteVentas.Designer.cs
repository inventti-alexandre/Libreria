﻿namespace LaPaz.Win.Forms.Reportes
{
    partial class FrmReporteVentas
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

                _reporteNegocio.Dispose();
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
            this.components = new System.ComponentModel.Container();
            this.ClienteDetalle = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.ClienteEditar = new LaPaz.Win.Controls.EditCell.EditColumn();
            this.ClienteEliminar = new LaPaz.Win.Controls.DeleteCell.DeleteColumn();
            this.detailsColumn1 = new LaPaz.Win.Controls.DetailCell.DetailsColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLimpiarFiltros = new Telerik.WinControls.UI.RadButton();
            this.CbxEditorial = new LaPaz.Win.Forms.Util.UcFiltroEditorial();
            this.CbxTemas = new LaPaz.Win.Forms.Util.UcFiltroTemas();
            this.radLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.ucFiltroOperadores = new LaPaz.Win.Forms.Util.UcFiltroOperadores();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CbxProveedor = new LaPaz.Win.Forms.Util.UcFiltroProveedor();
            this.DtpFechaFin = new Telerik.WinControls.UI.RadDateTimePicker();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.DtpFechaInicio = new Telerik.WinControls.UI.RadDateTimePicker();
            this.BtnBuscar = new Telerik.WinControls.UI.RadButton();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.UcFiltroStock = new LaPaz.Win.Forms.Util.UcFiltroStock();
            this.radLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaFin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaInicio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // ClienteDetalle
            // 
            this.ClienteDetalle.FillWeight = 31.2983F;
            this.ClienteDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteDetalle.HeaderText = "";
            this.ClienteDetalle.Name = "ClienteDetalle";
            this.ClienteDetalle.ReadOnly = true;
            this.ClienteDetalle.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteDetalle.ToolTipText = "Detalle";
            this.ClienteDetalle.Width = 27;
            // 
            // ClienteEditar
            // 
            this.ClienteEditar.FillWeight = 34.15069F;
            this.ClienteEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteEditar.HeaderText = "";
            this.ClienteEditar.Name = "ClienteEditar";
            this.ClienteEditar.ReadOnly = true;
            this.ClienteEditar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteEditar.ToolTipText = "Editar";
            this.ClienteEditar.Width = 29;
            // 
            // ClienteEliminar
            // 
            this.ClienteEliminar.FillWeight = 36.90251F;
            this.ClienteEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClienteEliminar.HeaderText = "";
            this.ClienteEliminar.Name = "ClienteEliminar";
            this.ClienteEliminar.ReadOnly = true;
            this.ClienteEliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ClienteEliminar.ToolTipText = "Eliminar";
            this.ClienteEliminar.Width = 31;
            // 
            // detailsColumn1
            // 
            this.detailsColumn1.HeaderText = "";
            this.detailsColumn1.Name = "detailsColumn1";
            this.detailsColumn1.ReadOnly = true;
            this.detailsColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.detailsColumn1.Width = 30;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.reportViewer1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1358, 860);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radLabel6);
            this.panel1.Controls.Add(this.UcFiltroStock);
            this.panel1.Controls.Add(this.BtnLimpiarFiltros);
            this.panel1.Controls.Add(this.CbxEditorial);
            this.panel1.Controls.Add(this.CbxTemas);
            this.panel1.Controls.Add(this.radLabel5);
            this.panel1.Controls.Add(this.radLabel4);
            this.panel1.Controls.Add(this.ucFiltroOperadores);
            this.panel1.Controls.Add(this.radLabel3);
            this.panel1.Controls.Add(this.radLabel2);
            this.panel1.Controls.Add(this.CbxProveedor);
            this.panel1.Controls.Add(this.DtpFechaFin);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.DtpFechaInicio);
            this.panel1.Controls.Add(this.BtnBuscar);
            this.panel1.Controls.Add(this.metroLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1352, 114);
            this.panel1.TabIndex = 0;
            // 
            // BtnLimpiarFiltros
            // 
            this.BtnLimpiarFiltros.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarFiltros.Location = new System.Drawing.Point(1208, 59);
            this.BtnLimpiarFiltros.Name = "BtnLimpiarFiltros";
            this.BtnLimpiarFiltros.Size = new System.Drawing.Size(113, 29);
            this.BtnLimpiarFiltros.TabIndex = 8;
            this.BtnLimpiarFiltros.Text = "Limpiar";
            this.BtnLimpiarFiltros.ThemeName = "TelerikMetroBlue";
            this.BtnLimpiarFiltros.Click += new System.EventHandler(this.BtnLimpiarFiltros_Click);
            // 
            // CbxEditorial
            // 
            this.CbxEditorial.EditorialId = null;
            this.CbxEditorial.Location = new System.Drawing.Point(746, 63);
            this.CbxEditorial.Name = "CbxEditorial";
            this.CbxEditorial.Size = new System.Drawing.Size(216, 27);
            this.CbxEditorial.TabIndex = 6;
            // 
            // CbxTemas
            // 
            this.CbxTemas.Location = new System.Drawing.Point(425, 61);
            this.CbxTemas.Name = "CbxTemas";
            this.CbxTemas.Size = new System.Drawing.Size(199, 27);
            this.CbxTemas.TabIndex = 5;
            this.CbxTemas.TemaId = null;
            // 
            // radLabel5
            // 
            this.radLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel5.Location = new System.Drawing.Point(651, 64);
            this.radLabel5.Name = "radLabel5";
            this.radLabel5.Size = new System.Drawing.Size(67, 24);
            this.radLabel5.TabIndex = 53;
            this.radLabel5.Text = "Editorial:";
            this.radLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(359, 64);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(48, 24);
            this.radLabel4.TabIndex = 52;
            this.radLabel4.Text = "Tema:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // ucFiltroOperadores
            // 
            this.ucFiltroOperadores.Location = new System.Drawing.Point(746, 24);
            this.ucFiltroOperadores.Name = "ucFiltroOperadores";
            this.ucFiltroOperadores.OperadorId = null;
            this.ucFiltroOperadores.Size = new System.Drawing.Size(216, 27);
            this.ucFiltroOperadores.TabIndex = 3;
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(651, 24);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(76, 24);
            this.radLabel3.TabIndex = 51;
            this.radLabel3.Text = "Operador:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(20, 64);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(105, 24);
            this.radLabel2.TabIndex = 5;
            this.radLabel2.Text = "Prov. Nombre:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // CbxProveedor
            // 
            this.CbxProveedor.EsGasto = false;
            this.CbxProveedor.Location = new System.Drawing.Point(137, 61);
            this.CbxProveedor.Name = "CbxProveedor";
            this.CbxProveedor.ProveedorId = null;
            this.CbxProveedor.Size = new System.Drawing.Size(200, 27);
            this.CbxProveedor.TabIndex = 4;
            // 
            // DtpFechaFin
            // 
            this.DtpFechaFin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaFin.Location = new System.Drawing.Point(425, 24);
            this.DtpFechaFin.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaFin.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaFin.Name = "DtpFechaFin";
            this.DtpFechaFin.NullableValue = null;
            this.DtpFechaFin.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaFin.Size = new System.Drawing.Size(130, 29);
            this.DtpFechaFin.TabIndex = 2;
            this.DtpFechaFin.TabStop = false;
            this.DtpFechaFin.ThemeName = "TelerikMetroBlue";
            this.DtpFechaFin.Value = new System.DateTime(((long)(0)));
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(359, 24);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(49, 24);
            this.radLabel1.TabIndex = 46;
            this.radLabel1.Text = "Hasta:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // DtpFechaInicio
            // 
            this.DtpFechaInicio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaInicio.Location = new System.Drawing.Point(137, 22);
            this.DtpFechaInicio.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.DtpFechaInicio.MinDate = new System.DateTime(((long)(0)));
            this.DtpFechaInicio.Name = "DtpFechaInicio";
            this.DtpFechaInicio.NullableValue = null;
            this.DtpFechaInicio.NullDate = new System.DateTime(((long)(0)));
            this.DtpFechaInicio.Size = new System.Drawing.Size(130, 29);
            this.DtpFechaInicio.TabIndex = 1;
            this.DtpFechaInicio.TabStop = false;
            this.DtpFechaInicio.ThemeName = "TelerikMetroBlue";
            this.DtpFechaInicio.Value = new System.DateTime(((long)(0)));
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscar.Location = new System.Drawing.Point(1208, 22);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(113, 29);
            this.BtnBuscar.TabIndex = 7;
            this.BtnBuscar.Text = "Generar";
            this.BtnBuscar.ThemeName = "TelerikMetroBlue";
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(20, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 24);
            this.metroLabel1.TabIndex = 44;
            this.metroLabel1.Text = "Desde:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(3, 123);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1352, 734);
            this.reportViewer1.TabIndex = 8;
            // 
            // UcFiltroStock
            // 
            this.UcFiltroStock.Location = new System.Drawing.Point(1057, 24);
            this.UcFiltroStock.Name = "UcFiltroStock";
            this.UcFiltroStock.Size = new System.Drawing.Size(119, 27);
            this.UcFiltroStock.TabIndex = 54;
            this.UcFiltroStock.Value = LaPaz.Win.Forms.Util.StockFilter.Ambos;
            // 
            // radLabel6
            // 
            this.radLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel6.Location = new System.Drawing.Point(984, 25);
            this.radLabel6.Name = "radLabel6";
            this.radLabel6.Size = new System.Drawing.Size(64, 24);
            this.radLabel6.TabIndex = 54;
            this.radLabel6.Text = "C/Stock:";
            this.radLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // FrmReporteVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 860);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmReporteVentas";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.FrmConsignacionesVendidas_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnLimpiarFiltros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaFin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtpFechaInicio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnBuscar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn2;
        private Telerik.WinControls.UI.GridViewTextBoxColumn dataGridViewButtonColumn3;
        private Controls.DetailCell.DetailsColumn detailsColumn1;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Id;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Denominacion;
        private Telerik.WinControls.UI.GridViewTextBoxColumn TipoDocumentoDi;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Cuit;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Telefono;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Celular;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Domicilio;
        private Telerik.WinControls.UI.GridViewTextBoxColumn Mail;
        private Controls.DetailCell.DetailsColumn ClienteDetalle;
        private Controls.EditCell.EditColumn ClienteEditar;
        private Controls.DeleteCell.DeleteColumn ClienteEliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private Telerik.WinControls.UI.RadButton BtnBuscar;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaInicio;
        private Telerik.WinControls.UI.RadDateTimePicker DtpFechaFin;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Util.UcFiltroProveedor CbxProveedor;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Util.UcFiltroOperadores ucFiltroOperadores;
        private Util.UcFiltroEditorial CbxEditorial;
        private Util.UcFiltroTemas CbxTemas;
        private Telerik.WinControls.UI.RadLabel radLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadButton BtnLimpiarFiltros;
        private Telerik.WinControls.UI.RadLabel radLabel6;
        private Util.UcFiltroStock UcFiltroStock;
    }
}