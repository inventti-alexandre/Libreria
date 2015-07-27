namespace LaPaz.Win.Forms.Temas
{
    partial class FrmCrearEditarTema
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
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn2 = new Telerik.WinControls.UI.GridViewCommandColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn3 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.EpvProveedores = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.PageTema = new Telerik.WinControls.UI.RadPageViewPage();
            this.metroLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.TxtNombre = new Telerik.WinControls.UI.RadTextBox();
            this.PageSubTema = new Telerik.WinControls.UI.RadPageViewPage();
            this.BtnCrear = new Telerik.WinControls.UI.RadButton();
            this.GridSubTemas = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.EpvProveedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            this.PageTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).BeginInit();
            this.PageSubTema.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubTemas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubTemas.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // EpvProveedores
            // 
            this.EpvProveedores.ContainerControl = this;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(494, 266);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 16;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(607, 266);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 17;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.PageTema);
            this.radPageView1.Controls.Add(this.PageSubTema);
            this.radPageView1.Location = new System.Drawing.Point(12, 12);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.PageSubTema;
            this.radPageView1.Size = new System.Drawing.Size(695, 235);
            this.radPageView1.TabIndex = 84;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // PageTema
            // 
            this.PageTema.Controls.Add(this.metroLabel3);
            this.PageTema.Controls.Add(this.TxtNombre);
            this.PageTema.Location = new System.Drawing.Point(5, 31);
            this.PageTema.Name = "PageTema";
            this.PageTema.Size = new System.Drawing.Size(685, 199);
            this.PageTema.Text = "Tema";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel3.Location = new System.Drawing.Point(3, 20);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(67, 24);
            this.metroLabel3.TabIndex = 70;
            this.metroLabel3.Text = "Nombre:";
            this.metroLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // TxtNombre
            // 
            this.TxtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombre.Location = new System.Drawing.Point(93, 19);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(467, 26);
            this.TxtNombre.TabIndex = 69;
            this.TxtNombre.TabStop = false;
            this.TxtNombre.ThemeName = "TelerikMetroBlue";
            // 
            // PageSubTema
            // 
            this.PageSubTema.Controls.Add(this.BtnCrear);
            this.PageSubTema.Controls.Add(this.GridSubTemas);
            this.PageSubTema.Location = new System.Drawing.Point(5, 31);
            this.PageSubTema.Name = "PageSubTema";
            this.PageSubTema.Size = new System.Drawing.Size(685, 199);
            this.PageSubTema.Text = "Sub Temas";
            // 
            // BtnCrear
            // 
            this.BtnCrear.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCrear.Location = new System.Drawing.Point(17, 14);
            this.BtnCrear.Name = "BtnCrear";
            this.BtnCrear.Size = new System.Drawing.Size(75, 30);
            this.BtnCrear.TabIndex = 10;
            this.BtnCrear.Text = "Crear";
            this.BtnCrear.ThemeName = "TelerikMetroBlue";
            this.BtnCrear.Click += new System.EventHandler(this.BtnCrear_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnCrear.GetChildAt(0))).Text = "Crear";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnCrear.GetChildAt(0).GetChildAt(2))).StretchHorizontally = true;
            // 
            // GridSubTemas
            // 
            this.GridSubTemas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridSubTemas.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.GridSubTemas.Location = new System.Drawing.Point(17, 52);
            this.GridSubTemas.Margin = new System.Windows.Forms.Padding(5);
            // 
            // GridSubTemas
            // 
            this.GridSubTemas.MasterTemplate.AllowAddNewRow = false;
            this.GridSubTemas.MasterTemplate.AllowColumnReorder = false;
            this.GridSubTemas.MasterTemplate.AllowDeleteRow = false;
            this.GridSubTemas.MasterTemplate.AllowDragToGroup = false;
            this.GridSubTemas.MasterTemplate.AllowEditRow = false;
            this.GridSubTemas.MasterTemplate.AllowRowResize = false;
            this.GridSubTemas.MasterTemplate.AutoGenerateColumns = false;
            this.GridSubTemas.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 29;
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.Name = "Nombre";
            gridViewTextBoxColumn2.Width = 531;
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.View_Details;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaDetalle";
            gridViewCommandColumn1.Width = 30;
            gridViewCommandColumn2.HeaderText = "";
            gridViewCommandColumn2.Image = global::LaPaz.Win.Properties.Resources.Data_Edit;
            gridViewCommandColumn2.MaxWidth = 30;
            gridViewCommandColumn2.MinWidth = 30;
            gridViewCommandColumn2.Name = "ColumnaEditar";
            gridViewCommandColumn2.Width = 30;
            gridViewCommandColumn3.HeaderText = "";
            gridViewCommandColumn3.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn3.MaxWidth = 30;
            gridViewCommandColumn3.MinWidth = 30;
            gridViewCommandColumn3.Name = "ColumnaEliminar";
            gridViewCommandColumn3.Width = 30;
            this.GridSubTemas.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewCommandColumn1,
            gridViewCommandColumn2,
            gridViewCommandColumn3});
            this.GridSubTemas.MasterTemplate.EnableGrouping = false;
            this.GridSubTemas.MasterTemplate.EnableSorting = false;
            this.GridSubTemas.Name = "GridSubTemas";
            this.GridSubTemas.ReadOnly = true;
            this.GridSubTemas.Size = new System.Drawing.Size(640, 132);
            this.GridSubTemas.TabIndex = 9;
            this.GridSubTemas.ThemeName = "TelerikMetroBlue";
            this.GridSubTemas.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.GridSubTemas_CommandCellClick);
            // 
            // FrmCrearEditarTema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 305);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCrearEditarTema";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Tema";
            this.Load += new System.EventHandler(this.FrmCrearEditarTema_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EpvProveedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            this.PageTema.ResumeLayout(false);
            this.PageTema.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombre)).EndInit();
            this.PageSubTema.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCrear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubTemas.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GridSubTemas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider EpvProveedores;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage PageTema;
        private Telerik.WinControls.UI.RadPageViewPage PageSubTema;
        private Telerik.WinControls.UI.RadGridView GridSubTemas;
        private Telerik.WinControls.UI.RadButton BtnCrear;
        private Telerik.WinControls.UI.RadLabel metroLabel3;
        private Telerik.WinControls.UI.RadTextBox TxtNombre;
    }
}