using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Consignaciones
{
    partial class UcConsignacionesDevolucionPorEditorial
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn9 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn10 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn11 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn12 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TxtEditorial = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.GridTitulos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditorial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
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
            this.panel1.Controls.Add(this.TxtEditorial);
            this.panel1.Controls.Add(this.radLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1107, 45);
            this.panel1.TabIndex = 0;
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(83, 11);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.ReadOnly = true;
            this.TxtEditorial.Size = new System.Drawing.Size(739, 22);
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
            gridViewTextBoxColumn7.FieldName = "TituloId";
            gridViewTextBoxColumn7.HeaderText = "TituloId";
            gridViewTextBoxColumn7.IsVisible = false;
            gridViewTextBoxColumn7.Name = "TituloId";
            gridViewTextBoxColumn7.Width = 495;
            gridViewTextBoxColumn8.FieldName = "NombreTitulo";
            gridViewTextBoxColumn8.HeaderText = "Título";
            gridViewTextBoxColumn8.Name = "NombreTitulo";
            gridViewTextBoxColumn8.Width = 377;
            gridViewTextBoxColumn9.FieldName = "Autor";
            gridViewTextBoxColumn9.HeaderText = "Autor";
            gridViewTextBoxColumn9.Name = "Autor";
            gridViewTextBoxColumn9.Width = 174;
            gridViewTextBoxColumn10.FieldName = "Codigo";
            gridViewTextBoxColumn10.HeaderText = "Cod";
            gridViewTextBoxColumn10.Name = "Codigo";
            gridViewTextBoxColumn10.Width = 180;
            gridViewTextBoxColumn11.FieldName = "CantidadSinRendir";
            gridViewTextBoxColumn11.HeaderText = "Cant s/rendir";
            gridViewTextBoxColumn11.Name = "CantidadSinRendir";
            gridViewTextBoxColumn11.Width = 193;
            gridViewTextBoxColumn12.EnableExpressionEditor = false;
            gridViewTextBoxColumn12.FieldName = "CantidadADevolver";
            gridViewTextBoxColumn12.HeaderText = "Cant. a devolver";
            gridViewTextBoxColumn12.Name = "CantidadADevolver";
            gridViewTextBoxColumn12.Width = 165;
            this.GridTitulos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8,
            gridViewTextBoxColumn9,
            gridViewTextBoxColumn10,
            gridViewTextBoxColumn11,
            gridViewTextBoxColumn12});
            this.GridTitulos.MasterTemplate.EnableGrouping = false;
            this.GridTitulos.Name = "GridTitulos";
            this.GridTitulos.Size = new System.Drawing.Size(1107, 265);
            this.GridTitulos.TabIndex = 13;
            this.GridTitulos.ThemeName = "TelerikMetroBlue";
            this.GridTitulos.CellValidating += new Telerik.WinControls.UI.CellValidatingEventHandler(this.GridTitulos_CellValidating);
            this.GridTitulos.CellValidated += new Telerik.WinControls.UI.CellValidatedEventHandler(this.GridTitulos_CellValidated);
            this.GridTitulos.DataBindingComplete += new Telerik.WinControls.UI.GridViewBindingCompleteEventHandler(this.GridTitulos_DataBindingComplete);
            // 
            // UcConsignacionesDevolucionPorEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "UcConsignacionesDevolucionPorEditorial";
            this.Size = new System.Drawing.Size(1107, 314);
            this.Load += new System.EventHandler(this.UcConsignacionesPorEditorial_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtEditorial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridTitulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private RadGridView GridTitulos;
        private System.Windows.Forms.Panel panel1;
        private RadTextBox TxtEditorial;
        private RadLabel radLabel1;

    }
}
