namespace LaPaz.Win.Forms.LotesDeFacturas
{
    partial class FrmLoteFacturaListado
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
            this.components = new System.ComponentModel.Container();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.ProveedoresPager = new Framework.WinForm.Controls.MetroPager();
            this.GrillaLotes = new Telerik.WinControls.UI.RadGridView();
            this.ucProgressSpinner = new LaPaz.Win.Forms.Util.UcProgressSpinner();
            this.BtnNuevo = new Telerik.WinControls.UI.RadButton();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLotes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.ProveedoresPager);
            this.radPanel1.Controls.Add(this.GrillaLotes);
            this.radPanel1.Location = new System.Drawing.Point(12, 45);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(800, 449);
            this.radPanel1.TabIndex = 0;
            // 
            // ProveedoresPager
            // 
            this.ProveedoresPager.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProveedoresPager.CurrentPage = 1;
            this.ProveedoresPager.Location = new System.Drawing.Point(419, 3);
            this.ProveedoresPager.Name = "ProveedoresPager";
            this.ProveedoresPager.PageSize = 50;
            this.ProveedoresPager.PageTotal = 1;
            this.ProveedoresPager.RefreshAction = null;
            this.ProveedoresPager.RefreshActionAsync = null;
            this.ProveedoresPager.Size = new System.Drawing.Size(378, 39);
            this.ProveedoresPager.TabIndex = 11;
            // 
            // GrillaLotes
            // 
            this.GrillaLotes.Location = new System.Drawing.Point(16, 48);
            // 
            // GrillaLotes
            // 
            this.GrillaLotes.MasterTemplate.AllowAddNewRow = false;
            this.GrillaLotes.MasterTemplate.AllowColumnReorder = false;
            this.GrillaLotes.MasterTemplate.AllowDeleteRow = false;
            this.GrillaLotes.MasterTemplate.AllowDragToGroup = false;
            this.GrillaLotes.MasterTemplate.AllowEditRow = false;
            this.GrillaLotes.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaLotes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "NroLote";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "NroLote";
            gridViewTextBoxColumn1.Name = "NroLote";
            gridViewTextBoxColumn1.Width = 143;
            gridViewTextBoxColumn2.FieldName = "Tipo";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "Tipo";
            gridViewTextBoxColumn2.Name = "Tipo";
            gridViewTextBoxColumn2.Width = 143;
            gridViewTextBoxColumn3.FieldName = "NroDesde";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "NroDesde";
            gridViewTextBoxColumn3.Name = "NroDesde";
            gridViewTextBoxColumn3.Width = 143;
            gridViewTextBoxColumn4.FieldName = "NroHasta";
            gridViewTextBoxColumn4.FormatString = "";
            gridViewTextBoxColumn4.HeaderText = "NroHasta";
            gridViewTextBoxColumn4.Name = "NroHasta";
            gridViewTextBoxColumn4.Width = 143;
            gridViewTextBoxColumn5.FieldName = "NroActual";
            gridViewTextBoxColumn5.FormatString = "";
            gridViewTextBoxColumn5.HeaderText = "NroActual";
            gridViewTextBoxColumn5.Name = "NroActual";
            gridViewTextBoxColumn5.Width = 142;
            gridViewCommandColumn1.FormatString = "";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "Editar";
            gridViewCommandColumn1.Width = 30;
            this.GrillaLotes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewCommandColumn1});
            this.GrillaLotes.Name = "GrillaLotes";
            this.GrillaLotes.ReadOnly = true;
            this.GrillaLotes.Size = new System.Drawing.Size(761, 385);
            this.GrillaLotes.TabIndex = 0;
            this.GrillaLotes.ThemeName = "TelerikMetroBlue";
            this.GrillaLotes.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GrillaLotes_CommandCellClick);
            // 
            // ucProgressSpinner
            // 
            this.ucProgressSpinner.Location = new System.Drawing.Point(658, 12);
            this.ucProgressSpinner.Name = "ucProgressSpinner";
            this.ucProgressSpinner.Size = new System.Drawing.Size(154, 27);
            this.ucProgressSpinner.TabIndex = 1;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnNuevo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNuevo.Location = new System.Drawing.Point(712, 9);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(100, 30);
            this.BtnNuevo.TabIndex = 18;
            this.BtnNuevo.Text = "Crear";
            this.BtnNuevo.ThemeName = "TelerikMetroBlue";
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // FrmLoteFacturaListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 578);
            this.ControlBox = false;
            this.Controls.Add(this.BtnNuevo);
            this.Controls.Add(this.ucProgressSpinner);
            this.Controls.Add(this.radPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmLoteFacturaListado";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmLoteFacturaListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLotes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaLotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnNuevo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadPanel radPanel1;
        private Telerik.WinControls.UI.RadGridView GrillaLotes;
        private Framework.WinForm.Controls.MetroPager ProveedoresPager;
        private Util.UcProgressSpinner ucProgressSpinner;
        private Telerik.WinControls.UI.RadButton BtnNuevo;
    }
}