namespace LaPaz.Win.Forms.Clientes
{
    partial class FrmClientesListadoResumido
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn1 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn2 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn3 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn4 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn5 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn8 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            this.GrillaClientes = new Telerik.WinControls.UI.RadGridView();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.grillaRemitos = new Telerik.WinControls.UI.RadGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRemitos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRemitos.MasterTemplate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.GrillaClientes.Location = new System.Drawing.Point(489, 298);
            // 
            // GrillaClientes
            // 
            this.GrillaClientes.MasterTemplate.AllowAddNewRow = false;
            this.GrillaClientes.MasterTemplate.AllowDeleteRow = false;
            this.GrillaClientes.MasterTemplate.AllowDragToGroup = false;
            this.GrillaClientes.MasterTemplate.AllowEditRow = false;
            this.GrillaClientes.MasterTemplate.AutoGenerateColumns = false;
            this.GrillaClientes.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Denominacion";
            gridViewTextBoxColumn1.FormatString = "";
            gridViewTextBoxColumn1.HeaderText = "Nombre";
            gridViewTextBoxColumn1.MinWidth = 300;
            gridViewTextBoxColumn1.Name = "ColumnaNombre";
            gridViewTextBoxColumn1.Width = 300;
            gridViewTextBoxColumn2.FieldName = "Cuit";
            gridViewTextBoxColumn2.FormatString = "";
            gridViewTextBoxColumn2.HeaderText = "DNI";
            gridViewTextBoxColumn2.MinWidth = 100;
            gridViewTextBoxColumn2.Name = "ColumnaDNI";
            gridViewTextBoxColumn2.Width = 100;
            gridViewTextBoxColumn3.FieldName = "Telefono";
            gridViewTextBoxColumn3.HeaderText = "Teléfono";
            gridViewTextBoxColumn3.MinWidth = 100;
            gridViewTextBoxColumn3.Name = "ColumnaTelefono";
            gridViewTextBoxColumn3.Width = 100;
            gridViewTextBoxColumn4.FieldName = "RemitosVenta.NumeroComprobante";
            gridViewTextBoxColumn4.HeaderText = "column1";
            gridViewTextBoxColumn4.Name = "column1";
            gridViewTextBoxColumn4.Width = 5;
            this.GrillaClientes.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4});
            this.GrillaClientes.Name = "GrillaClientes";
            this.GrillaClientes.ShowGroupPanel = false;
            this.GrillaClientes.Size = new System.Drawing.Size(110, 34);
            this.GrillaClientes.TabIndex = 0;
            this.GrillaClientes.Text = "GrillaClientes";
            this.GrillaClientes.ThemeName = "TelerikMetroBlue";
            this.GrillaClientes.Visible = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(605, 302);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 41;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // grillaRemitos
            // 
            this.grillaRemitos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grillaRemitos.Location = new System.Drawing.Point(12, 12);
            // 
            // grillaRemitos
            // 
            this.grillaRemitos.MasterTemplate.AllowAddNewRow = false;
            this.grillaRemitos.MasterTemplate.AllowColumnReorder = false;
            this.grillaRemitos.MasterTemplate.AllowDragToGroup = false;
            this.grillaRemitos.MasterTemplate.AutoGenerateColumns = false;
            this.grillaRemitos.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn5.FieldName = "RemitosVenta.NumeroComprobante";
            gridViewTextBoxColumn5.HeaderText = "Consigna Nro";
            gridViewTextBoxColumn5.Name = "Consigna";
            gridViewTextBoxColumn5.Width = 97;
            gridViewTextBoxColumn6.FieldName = "RemitosVenta.ClienteConsignado.Denominacion";
            gridViewTextBoxColumn6.HeaderText = "Cliente";
            gridViewTextBoxColumn6.Name = "Cliente";
            gridViewTextBoxColumn6.Width = 195;
            gridViewTextBoxColumn7.FieldName = "RemitosVenta.ClienteConsignado.Cuit";
            gridViewTextBoxColumn7.HeaderText = "DNI";
            gridViewTextBoxColumn7.Name = "DNI";
            gridViewTextBoxColumn7.Width = 180;
            gridViewTextBoxColumn8.FieldName = "RemitosVenta.ClienteConsignado.Telefono";
            gridViewTextBoxColumn8.HeaderText = "Telefono";
            gridViewTextBoxColumn8.Name = "Telefono";
            gridViewTextBoxColumn8.Width = 202;
            this.grillaRemitos.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewTextBoxColumn8});
            this.grillaRemitos.Name = "grillaRemitos";
            this.grillaRemitos.ReadOnly = true;
            this.grillaRemitos.Size = new System.Drawing.Size(693, 275);
            this.grillaRemitos.TabIndex = 42;
            this.grillaRemitos.Text = "radGridView1";
            this.grillaRemitos.ThemeName = "TelerikMetroBlue";
            // 
            // FrmClientesListadoResumido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 343);
            this.Controls.Add(this.grillaRemitos);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.GrillaClientes);
            this.Name = "FrmClientesListadoResumido";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrillaClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRemitos.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRemitos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadGridView GrillaClientes;
        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadGridView grillaRemitos;
    }
}