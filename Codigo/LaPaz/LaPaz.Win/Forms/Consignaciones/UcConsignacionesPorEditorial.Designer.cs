using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Consignaciones
{
    partial class UcConsignacionesPorEditorial
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtEditorial = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtPorcentaje = new Framework.WinForm.Controls.CustomControls.NumericTextBox();
            this.GridTitulos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.GridTitulos);
            this.splitContainer1.Size = new System.Drawing.Size(1107, 314);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroLabel3);
            this.panel1.Controls.Add(this.TxtEditorial);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Controls.Add(this.TxtPorcentaje);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 45);
            this.panel1.TabIndex = 0;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(641, 11);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(79, 24);
            this.metroLabel3.TabIndex = 43;
            this.metroLabel3.Text = "Porcentaje";
            this.metroLabel3.TextAlignment = System.Drawing.ContentAlignment.TopRight;
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(83, 11);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.ReadOnly = true;
            this.TxtEditorial.Size = new System.Drawing.Size(513, 22);
            this.TxtEditorial.TabIndex = 46;
            this.TxtEditorial.TabStop = false;
            this.TxtEditorial.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(10, 11);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(63, 24);
            this.radLabel1.TabIndex = 44;
            this.radLabel1.Text = "Editorial";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPorcentaje
            // 
            this.TxtPorcentaje.DecimalNumbers = 2;
            this.TxtPorcentaje.DecimalText = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.TxtPorcentaje.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TxtPorcentaje.ForeColor = System.Drawing.Color.Black;
            this.TxtPorcentaje.Format = "^(\\-?)(\\d*)(\\,?)(\\d?)(\\d?)$";
            this.TxtPorcentaje.HasNegatives = true;
            this.TxtPorcentaje.Location = new System.Drawing.Point(726, 11);
            this.TxtPorcentaje.Name = "TxtPorcentaje";
            this.TxtPorcentaje.Size = new System.Drawing.Size(69, 22);
            this.TxtPorcentaje.TabIndex = 45;
            this.TxtPorcentaje.TabStop = false;
            this.TxtPorcentaje.Text = "0";
            this.TxtPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtPorcentaje.ThemeName = "TelerikMetroBlue";
            this.TxtPorcentaje.TextChanged += new System.EventHandler(this.TxtPorcentaje_TextChanged);
            // 
            // GridTitulos
            // 
            this.GridTitulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridTitulos.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridTitulos.Location = new System.Drawing.Point(0, 0);
            // 
            // GridTitulos
            // 
            this.GridTitulos.MasterTemplate.AllowAddNewRow = false;
            this.GridTitulos.MasterTemplate.AutoGenerateColumns = false;
            this.GridTitulos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "TituloId";
            gridViewTextBoxColumn1.HeaderText = "TituloId";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "TituloId";
            gridViewTextBoxColumn1.Width = 495;
            gridViewTextBoxColumn2.FieldName = "NombreTitulo";
            gridViewTextBoxColumn2.HeaderText = "Título";
            gridViewTextBoxColumn2.Name = "NombreTitulo";
            gridViewTextBoxColumn2.Width = 239;
            gridViewTextBoxColumn3.FieldName = "Autor";
            gridViewTextBoxColumn3.HeaderText = "Autor";
            gridViewTextBoxColumn3.Name = "Autor";
            gridViewTextBoxColumn3.Width = 110;
            gridViewTextBoxColumn4.FieldName = "Codigo";
            gridViewTextBoxColumn4.HeaderText = "Cod";
            gridViewTextBoxColumn4.Name = "Codigo";
            gridViewTextBoxColumn4.Width = 114;
            gridViewTextBoxColumn5.FieldName = "PrecioCompraCalculado";
            gridViewTextBoxColumn5.FormatString = "{0:c}";
            gridViewTextBoxColumn5.HeaderText = "Precio Compra";
            gridViewTextBoxColumn5.MinWidth = 102;
            gridViewTextBoxColumn5.Name = "PrecioCompraCalculado";
            gridViewTextBoxColumn5.Width = 102;
            gridViewTextBoxColumn6.FieldName = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.FormatString = "{0:c}";
            gridViewTextBoxColumn6.HeaderText = "Precio Venta";
            gridViewTextBoxColumn6.Name = "PrecioVentaTitulo";
            gridViewTextBoxColumn6.Width = 107;
            gridViewTextBoxColumn7.FieldName = "CantidadSinRendir";
            gridViewTextBoxColumn7.HeaderText = "Cant s/rendir";
            gridViewTextBoxColumn7.Name = "CantidadSinRendir";
            gridViewTextBoxColumn7.Width = 122;
            gridViewTextBoxColumn8.FieldName = "TotalSinRendir";
            gridViewTextBoxColumn8.FormatString = "{0:c}";
            gridViewTextBoxColumn8.HeaderText = "Total s/rendir";
            gridViewTextBoxColumn8.Name = "TotalSinRendir";
            gridViewTextBoxColumn8.Width = 108;
            gridViewTextBoxColumn9.EnableExpressionEditor = false;
            gridViewTextBoxColumn9.FieldName = "CantidadARendir";
            gridViewTextBoxColumn9.HeaderText = "Cant. a rendir";
            gridViewTextBoxColumn9.Name = "CantidadARendir";
            gridViewTextBoxColumn9.Width = 105;
            gridViewTextBoxColumn10.FieldName = "TotalARendir";
            gridViewTextBoxColumn10.FormatString = "{0:c}";
            gridViewTextBoxColumn10.HeaderText = "Total a rendir";
            gridViewTextBoxColumn10.MinWidth = 50;
            gridViewTextBoxColumn10.Name = "TotalARendir";
            gridViewTextBoxColumn10.Width = 86;
            gridViewTextBoxColumn11.FieldName = "PrecioCompraTitulo";
            gridViewTextBoxColumn11.FormatString = "{0:c}";
            gridViewTextBoxColumn11.HeaderText = "Precio Compra";
            gridViewTextBoxColumn11.IsVisible = false;
            gridViewTextBoxColumn11.Name = "PrecioCompraTitulo";
            gridViewTextBoxColumn11.Width = 102;
            this.GridTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11});
            this.GridTitulos.MasterTemplate.EnableGrouping = false;
            this.GridTitulos.Name = "GridTitulos";
            this.GridTitulos.Size = new System.Drawing.Size(1107, 265);
            this.GridTitulos.TabIndex = 13;
            this.GridTitulos.ThemeName = "TelerikMetroBlue";
            this.GridTitulos.ViewCellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.GridTitulos_ViewCellFormatting);
            this.GridTitulos.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.GridTitulos_CellValidating);
            this.GridTitulos.CellValidated += new Telerik.WinControls.UI.CellValidatedEventHandler(this.GridTitulos_CellValidated);
            this.GridTitulos.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.GridTitulos_DataBindingComplete);
            // 
            // UcConsignacionesPorEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcConsignacionesPorEditorial";
            this.Size = new System.Drawing.Size(1107, 314);
            this.Load += new System.EventHandler(this.UcConsignacionesPorEditorial_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPorcentaje)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private RadGridView GridTitulos;
        private System.Windows.Forms.Panel panel1;
        private RadLabel metroLabel3;
        private RadTextBox TxtEditorial;
        private RadLabel radLabel1;
        private Framework.WinForm.Controls.CustomControls.NumericTextBox TxtPorcentaje;

    }
}
