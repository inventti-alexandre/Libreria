using System.Windows.Forms;

namespace LaPaz.Win.Forms.Seguridad
{
    partial class FrmCrearEditarUsuario
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
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn6 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewTextBoxColumn gridViewTextBoxColumn7 = new Telerik.WinControls.UI.GridViewTextBoxColumn();
            Telerik.WinControls.UI.GridViewCommandColumn gridViewCommandColumn1 = new Telerik.WinControls.UI.GridViewCommandColumn();
            this.BtnCancelar = new Telerik.WinControls.UI.RadButton();
            this.BtnGuardar = new Telerik.WinControls.UI.RadButton();
            this.EpvCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.PvSucursales = new Telerik.WinControls.UI.RadPageViewPage();
            this.UcSucursales = new LaPaz.Win.Forms.Util.UcFiltroSucursal();
            this.BtnAgregarSucursal = new Telerik.WinControls.UI.RadButton();
            this.DgvSucursales = new Telerik.WinControls.UI.RadGridView();
            this.PvGeneral = new Telerik.WinControls.UI.RadPageViewPage();
            this.UcMensajeAdvertenciaCambioClave = new LaPaz.Win.Forms.Util.UcMessage();
            this.radLabel2 = new Telerik.WinControls.UI.RadLabel();
            this.CbxCambiarClave = new Telerik.WinControls.UI.RadCheckBox();
            this.metroLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.TxtConfirmarPassword = new Telerik.WinControls.UI.RadTextBox();
            this.txtApellidoNombre = new Telerik.WinControls.UI.RadTextBox();
            this.TxtPassword = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel4 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel5 = new Telerik.WinControls.UI.RadLabel();
            this.radLabel3 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel6 = new Telerik.WinControls.UI.RadLabel();
            this.TxtNombreUsuario = new Telerik.WinControls.UI.RadTextBox();
            this.metroLabel7 = new Telerik.WinControls.UI.RadLabel();
            this.txtDni = new Telerik.WinControls.UI.RadTextBox();
            this.radLabel1 = new Telerik.WinControls.UI.RadLabel();
            this.txtDomicilio = new Telerik.WinControls.UI.RadTextBox();
            this.LbRoles = new Telerik.WinControls.UI.RadListControl();
            this.txtTelefono = new Telerik.WinControls.UI.RadTextBox();
            this.UcLocalidad = new LaPaz.Win.Forms.Util.UcLocalidad();
            this.txtCelular = new Telerik.WinControls.UI.RadTextBox();
            this.UcProvincia = new LaPaz.Win.Forms.Util.UcProvincia();
            this.metroLabel8 = new Telerik.WinControls.UI.RadLabel();
            this.metroLabel12 = new Telerik.WinControls.UI.RadLabel();
            this.radPageView1 = new Telerik.WinControls.UI.RadPageView();
            this.LnkHabilitarUsuario = new System.Windows.Forms.LinkLabel();
            this.UcMensajeDeshabilitado = new LaPaz.Win.Forms.Util.UcMessage();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).BeginInit();
            this.PvSucursales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarSucursal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSucursales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSucursales.MasterTemplate)).BeginInit();
            this.PvGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxCambiarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmarPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDni)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).BeginInit();
            this.radPageView1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancelar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(817, 434);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(100, 30);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.ThemeName = "TelerikMetroBlue";
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnGuardar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardar.Location = new System.Drawing.Point(704, 434);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(100, 30);
            this.BtnGuardar.TabIndex = 1;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.ThemeName = "TelerikMetroBlue";
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // EpvCliente
            // 
            this.EpvCliente.ContainerControl = this;
            // 
            // PvSucursales
            // 
            this.PvSucursales.Controls.Add(this.UcSucursales);
            this.PvSucursales.Controls.Add(this.BtnAgregarSucursal);
            this.PvSucursales.Controls.Add(this.DgvSucursales);
            this.PvSucursales.Location = new System.Drawing.Point(5, 31);
            this.PvSucursales.Name = "PvSucursales";
            this.PvSucursales.Size = new System.Drawing.Size(898, 368);
            this.PvSucursales.Text = "Sucursales";
            // 
            // UcSucursales
            // 
            this.UcSucursales.Location = new System.Drawing.Point(3, 25);
            this.UcSucursales.Margin = new System.Windows.Forms.Padding(4);
            this.UcSucursales.Name = "UcSucursales";
            this.UcSucursales.Size = new System.Drawing.Size(277, 27);
            this.UcSucursales.SucursalId = null;
            this.UcSucursales.TabIndex = 13;
            // 
            // BtnAgregarSucursal
            // 
            this.BtnAgregarSucursal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarSucursal.Location = new System.Drawing.Point(287, 23);
            this.BtnAgregarSucursal.Name = "BtnAgregarSucursal";
            this.BtnAgregarSucursal.Size = new System.Drawing.Size(75, 30);
            this.BtnAgregarSucursal.TabIndex = 12;
            this.BtnAgregarSucursal.Text = "Agregar";
            this.BtnAgregarSucursal.ThemeName = "TelerikMetroBlue";
            this.BtnAgregarSucursal.Click += new System.EventHandler(this.BtnAgregarSucursal_Click);
            ((Telerik.WinControls.UI.RadButtonElement)(this.BtnAgregarSucursal.GetChildAt(0))).Text = "Agregar";
            ((Telerik.WinControls.Primitives.BorderPrimitive)(this.BtnAgregarSucursal.GetChildAt(0).GetChildAt(2))).StretchHorizontally = true;
            // 
            // DgvSucursales
            // 
            this.DgvSucursales.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvSucursales.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.DgvSucursales.Location = new System.Drawing.Point(3, 63);
            this.DgvSucursales.Margin = new System.Windows.Forms.Padding(5);
            // 
            // 
            // 
            this.DgvSucursales.MasterTemplate.AllowAddNewRow = false;
            this.DgvSucursales.MasterTemplate.AllowColumnReorder = false;
            this.DgvSucursales.MasterTemplate.AllowDeleteRow = false;
            this.DgvSucursales.MasterTemplate.AllowDragToGroup = false;
            this.DgvSucursales.MasterTemplate.AllowEditRow = false;
            this.DgvSucursales.MasterTemplate.AllowRowResize = false;
            this.DgvSucursales.MasterTemplate.AutoGenerateColumns = false;
            this.DgvSucursales.MasterTemplate.AutoSizeColumnsMode = Telerik.WinControls.UI.GridViewAutoSizeColumnsMode.Fill;
            gridViewTextBoxColumn1.FieldName = "Id";
            gridViewTextBoxColumn1.HeaderText = "Id";
            gridViewTextBoxColumn1.IsVisible = false;
            gridViewTextBoxColumn1.Name = "Id";
            gridViewTextBoxColumn1.ReadOnly = true;
            gridViewTextBoxColumn1.Width = 29;
            gridViewTextBoxColumn2.FieldName = "Nombre";
            gridViewTextBoxColumn2.HeaderText = "Nombre";
            gridViewTextBoxColumn2.MinWidth = 150;
            gridViewTextBoxColumn2.Name = "Nombre";
            gridViewTextBoxColumn2.Width = 155;
            gridViewTextBoxColumn3.FieldName = "ProvinciaNombre";
            gridViewTextBoxColumn3.FormatString = "";
            gridViewTextBoxColumn3.HeaderText = "Provincia";
            gridViewTextBoxColumn3.Name = "Provincia";
            gridViewTextBoxColumn3.Width = 169;
            gridViewTextBoxColumn4.FieldName = "LocalidadNombre";
            gridViewTextBoxColumn4.FormatString = "{0:c2}";
            gridViewTextBoxColumn4.HeaderText = "Localidad";
            gridViewTextBoxColumn4.Name = "Localidad";
            gridViewTextBoxColumn4.Width = 128;
            gridViewTextBoxColumn5.FieldName = "Direccion";
            gridViewTextBoxColumn5.FormatString = "{0:c2}";
            gridViewTextBoxColumn5.HeaderText = "Domicilio";
            gridViewTextBoxColumn5.Name = "Domicilio";
            gridViewTextBoxColumn5.Width = 193;
            gridViewTextBoxColumn6.FieldName = "TelPart";
            gridViewTextBoxColumn6.FormatString = "{0:c2}";
            gridViewTextBoxColumn6.HeaderText = "Telefono";
            gridViewTextBoxColumn6.Name = "Telefono";
            gridViewTextBoxColumn6.Width = 116;
            gridViewTextBoxColumn7.FieldName = "TelCel";
            gridViewTextBoxColumn7.FormatString = "";
            gridViewTextBoxColumn7.HeaderText = "Celular";
            gridViewTextBoxColumn7.MinWidth = 80;
            gridViewTextBoxColumn7.Name = "Celular";
            gridViewTextBoxColumn7.TextAlignment = System.Drawing.ContentAlignment.MiddleRight;
            gridViewTextBoxColumn7.Width = 83;
            gridViewCommandColumn1.FieldName = "ColumnaEliminar";
            gridViewCommandColumn1.HeaderText = "";
            gridViewCommandColumn1.Image = global::LaPaz.Win.Properties.Resources.Garbage_Closed;
            gridViewCommandColumn1.MaxWidth = 30;
            gridViewCommandColumn1.MinWidth = 30;
            gridViewCommandColumn1.Name = "ColumnaEliminar";
            gridViewCommandColumn1.Width = 30;
            this.DgvSucursales.MasterTemplate.Columns.AddRange(new Telerik.WinControls.UI.GridViewDataColumn[] {
            gridViewTextBoxColumn1,
            gridViewTextBoxColumn2,
            gridViewTextBoxColumn3,
            gridViewTextBoxColumn4,
            gridViewTextBoxColumn5,
            gridViewTextBoxColumn6,
            gridViewTextBoxColumn7,
            gridViewCommandColumn1});
            this.DgvSucursales.MasterTemplate.EnableGrouping = false;
            this.DgvSucursales.MasterTemplate.EnableSorting = false;
            this.DgvSucursales.Name = "DgvSucursales";
            this.DgvSucursales.ReadOnly = true;
            this.DgvSucursales.Size = new System.Drawing.Size(890, 232);
            this.DgvSucursales.TabIndex = 11;
            this.DgvSucursales.ThemeName = "TelerikMetroBlue";
            this.DgvSucursales.CommandCellClick += new Telerik.WinControls.UI.CommandCellClickEventHandler(this.DgvSucursales_CommandCellClick);
            // 
            // PvGeneral
            // 
            this.PvGeneral.Controls.Add(this.UcMensajeAdvertenciaCambioClave);
            this.PvGeneral.Controls.Add(this.radLabel2);
            this.PvGeneral.Controls.Add(this.CbxCambiarClave);
            this.PvGeneral.Controls.Add(this.metroLabel1);
            this.PvGeneral.Controls.Add(this.TxtConfirmarPassword);
            this.PvGeneral.Controls.Add(this.txtApellidoNombre);
            this.PvGeneral.Controls.Add(this.TxtPassword);
            this.PvGeneral.Controls.Add(this.metroLabel4);
            this.PvGeneral.Controls.Add(this.radLabel4);
            this.PvGeneral.Controls.Add(this.metroLabel5);
            this.PvGeneral.Controls.Add(this.radLabel3);
            this.PvGeneral.Controls.Add(this.metroLabel6);
            this.PvGeneral.Controls.Add(this.TxtNombreUsuario);
            this.PvGeneral.Controls.Add(this.metroLabel7);
            this.PvGeneral.Controls.Add(this.txtDni);
            this.PvGeneral.Controls.Add(this.radLabel1);
            this.PvGeneral.Controls.Add(this.txtDomicilio);
            this.PvGeneral.Controls.Add(this.LbRoles);
            this.PvGeneral.Controls.Add(this.txtTelefono);
            this.PvGeneral.Controls.Add(this.UcLocalidad);
            this.PvGeneral.Controls.Add(this.txtCelular);
            this.PvGeneral.Controls.Add(this.UcProvincia);
            this.PvGeneral.Controls.Add(this.metroLabel8);
            this.PvGeneral.Controls.Add(this.metroLabel12);
            this.PvGeneral.Location = new System.Drawing.Point(5, 36);
            this.PvGeneral.Name = "PvGeneral";
            this.PvGeneral.Size = new System.Drawing.Size(898, 363);
            this.PvGeneral.Text = "General";
            // 
            // UcMensajeAdvertenciaCambioClave
            // 
            this.UcMensajeAdvertenciaCambioClave.Location = new System.Drawing.Point(605, 105);
            this.UcMensajeAdvertenciaCambioClave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcMensajeAdvertenciaCambioClave.Message = "La clave actual se perderá.";
            this.UcMensajeAdvertenciaCambioClave.Name = "UcMensajeAdvertenciaCambioClave";
            this.UcMensajeAdvertenciaCambioClave.Size = new System.Drawing.Size(277, 41);
            this.UcMensajeAdvertenciaCambioClave.TabIndex = 144;
            this.UcMensajeAdvertenciaCambioClave.TipoMensaje = Framework.WinForm.Comun.Notification.TipoMensajeGenerico.Advertencia;
            this.UcMensajeAdvertenciaCambioClave.Visible = false;
            // 
            // radLabel2
            // 
            this.radLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel2.Location = new System.Drawing.Point(17, 30);
            this.radLabel2.Name = "radLabel2";
            this.radLabel2.Size = new System.Drawing.Size(154, 29);
            this.radLabel2.TabIndex = 131;
            this.radLabel2.Text = "Nombre Usuario:";
            this.radLabel2.ThemeName = "TelerikMetroBlue";
            // 
            // CbxCambiarClave
            // 
            this.CbxCambiarClave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxCambiarClave.Location = new System.Drawing.Point(455, 112);
            this.CbxCambiarClave.Name = "CbxCambiarClave";
            this.CbxCambiarClave.Size = new System.Drawing.Size(148, 29);
            this.CbxCambiarClave.TabIndex = 126;
            this.CbxCambiarClave.Text = "Cambiar Clave";
            this.CbxCambiarClave.ThemeName = "TelerikMetroBlue";
            this.CbxCambiarClave.ToggleStateChanged += new Telerik.WinControls.UI.StateChangedEventHandler(this.CbxCambiarClave_ToggleStateChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel1.Location = new System.Drawing.Point(17, 70);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(164, 29);
            this.metroLabel1.TabIndex = 129;
            this.metroLabel1.Text = "Apellido, Nombre:";
            this.metroLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // TxtConfirmarPassword
            // 
            this.TxtConfirmarPassword.Enabled = false;
            this.TxtConfirmarPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConfirmarPassword.Location = new System.Drawing.Point(603, 192);
            this.TxtConfirmarPassword.Name = "TxtConfirmarPassword";
            this.TxtConfirmarPassword.PasswordChar = '*';
            this.TxtConfirmarPassword.Size = new System.Drawing.Size(278, 31);
            this.TxtConfirmarPassword.TabIndex = 9;
            this.TxtConfirmarPassword.TabStop = false;
            this.TxtConfirmarPassword.ThemeName = "TelerikMetroBlue";
            // 
            // txtApellidoNombre
            // 
            this.txtApellidoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellidoNombre.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidoNombre.Location = new System.Drawing.Point(154, 69);
            this.txtApellidoNombre.Name = "txtApellidoNombre";
            this.txtApellidoNombre.Size = new System.Drawing.Size(277, 31);
            this.txtApellidoNombre.TabIndex = 1;
            this.txtApellidoNombre.TabStop = false;
            this.txtApellidoNombre.ThemeName = "TelerikMetroBlue";
            // 
            // TxtPassword
            // 
            this.TxtPassword.Enabled = false;
            this.TxtPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPassword.Location = new System.Drawing.Point(603, 152);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.Size = new System.Drawing.Size(278, 31);
            this.TxtPassword.TabIndex = 8;
            this.TxtPassword.TabStop = false;
            this.TxtPassword.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel4.Location = new System.Drawing.Point(17, 154);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(93, 29);
            this.metroLabel4.TabIndex = 132;
            this.metroLabel4.Text = "Domicilio:";
            this.metroLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel4
            // 
            this.radLabel4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel4.Location = new System.Drawing.Point(455, 194);
            this.radLabel4.Name = "radLabel4";
            this.radLabel4.Size = new System.Drawing.Size(149, 29);
            this.radLabel4.TabIndex = 143;
            this.radLabel4.Text = "Confirmar Clave:";
            this.radLabel4.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel5
            // 
            this.metroLabel5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel5.Location = new System.Drawing.Point(17, 196);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(88, 29);
            this.metroLabel5.TabIndex = 133;
            this.metroLabel5.Text = "Teléfono:";
            this.metroLabel5.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel3
            // 
            this.radLabel3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel3.Location = new System.Drawing.Point(455, 154);
            this.radLabel3.Name = "radLabel3";
            this.radLabel3.Size = new System.Drawing.Size(59, 29);
            this.radLabel3.TabIndex = 141;
            this.radLabel3.Text = "Clave:";
            this.radLabel3.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel6
            // 
            this.metroLabel6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel6.Location = new System.Drawing.Point(17, 238);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(72, 29);
            this.metroLabel6.TabIndex = 134;
            this.metroLabel6.Text = "Celular:";
            this.metroLabel6.ThemeName = "TelerikMetroBlue";
            // 
            // TxtNombreUsuario
            // 
            this.TxtNombreUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.TxtNombreUsuario.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNombreUsuario.Location = new System.Drawing.Point(154, 29);
            this.TxtNombreUsuario.Name = "TxtNombreUsuario";
            this.TxtNombreUsuario.Size = new System.Drawing.Size(277, 31);
            this.TxtNombreUsuario.TabIndex = 0;
            this.TxtNombreUsuario.TabStop = false;
            this.TxtNombreUsuario.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel7
            // 
            this.metroLabel7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel7.Location = new System.Drawing.Point(454, 29);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(90, 29);
            this.metroLabel7.TabIndex = 135;
            this.metroLabel7.Text = "Provincia:";
            this.metroLabel7.ThemeName = "TelerikMetroBlue";
            // 
            // txtDni
            // 
            this.txtDni.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(154, 110);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(277, 31);
            this.txtDni.TabIndex = 2;
            this.txtDni.TabStop = false;
            this.txtDni.ThemeName = "TelerikMetroBlue";
            // 
            // radLabel1
            // 
            this.radLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radLabel1.Location = new System.Drawing.Point(454, 235);
            this.radLabel1.Name = "radLabel1";
            this.radLabel1.Size = new System.Drawing.Size(59, 29);
            this.radLabel1.TabIndex = 137;
            this.radLabel1.Text = "Roles:";
            this.radLabel1.ThemeName = "TelerikMetroBlue";
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDomicilio.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(154, 152);
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.Size = new System.Drawing.Size(277, 31);
            this.txtDomicilio.TabIndex = 3;
            this.txtDomicilio.TabStop = false;
            this.txtDomicilio.ThemeName = "TelerikMetroBlue";
            // 
            // LbRoles
            // 
            this.LbRoles.CaseSensitiveSort = true;
            this.LbRoles.DisplayMember = "Description";
            this.LbRoles.ItemHeight = 18;
            this.LbRoles.Location = new System.Drawing.Point(605, 235);
            this.LbRoles.Name = "LbRoles";
            this.LbRoles.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LbRoles.Size = new System.Drawing.Size(277, 106);
            this.LbRoles.TabIndex = 10;
            this.LbRoles.Text = "radListControl1";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(154, 193);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(277, 31);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TabStop = false;
            this.txtTelefono.ThemeName = "TelerikMetroBlue";
            // 
            // UcLocalidad
            // 
            this.UcLocalidad.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcLocalidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.UcLocalidad.LocalidadId = null;
            this.UcLocalidad.Location = new System.Drawing.Point(605, 70);
            this.UcLocalidad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UcLocalidad.Name = "UcLocalidad";
            this.UcLocalidad.Size = new System.Drawing.Size(277, 27);
            this.UcLocalidad.TabIndex = 7;
            // 
            // txtCelular
            // 
            this.txtCelular.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCelular.Location = new System.Drawing.Point(154, 234);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(277, 31);
            this.txtCelular.TabIndex = 5;
            this.txtCelular.TabStop = false;
            this.txtCelular.ThemeName = "TelerikMetroBlue";
            // 
            // UcProvincia
            // 
            this.UcProvincia.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UcProvincia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.UcProvincia.Location = new System.Drawing.Point(605, 28);
            this.UcProvincia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UcProvincia.Name = "UcProvincia";
            this.UcProvincia.ProvinciaId = null;
            this.UcProvincia.Size = new System.Drawing.Size(277, 27);
            this.UcProvincia.TabIndex = 6;
            // 
            // metroLabel8
            // 
            this.metroLabel8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel8.Location = new System.Drawing.Point(454, 71);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(94, 29);
            this.metroLabel8.TabIndex = 136;
            this.metroLabel8.Text = "Localidad:";
            this.metroLabel8.ThemeName = "TelerikMetroBlue";
            // 
            // metroLabel12
            // 
            this.metroLabel12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroLabel12.Location = new System.Drawing.Point(17, 112);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(47, 29);
            this.metroLabel12.TabIndex = 138;
            this.metroLabel12.Text = "Cuit:";
            this.metroLabel12.ThemeName = "TelerikMetroBlue";
            // 
            // radPageView1
            // 
            this.radPageView1.Controls.Add(this.PvGeneral);
            this.radPageView1.Controls.Add(this.PvSucursales);
            this.radPageView1.Location = new System.Drawing.Point(12, 12);
            this.radPageView1.Name = "radPageView1";
            this.radPageView1.SelectedPage = this.PvGeneral;
            this.radPageView1.Size = new System.Drawing.Size(908, 404);
            this.radPageView1.TabIndex = 97;
            this.radPageView1.Text = "radPageView1";
            this.radPageView1.ThemeName = "TelerikMetroBlue";
            ((Telerik.WinControls.UI.RadPageViewStripElement)(this.radPageView1.GetChildAt(0))).StripButtons = Telerik.WinControls.UI.StripViewButtons.None;
            // 
            // LnkHabilitarUsuario
            // 
            this.LnkHabilitarUsuario.ActiveLinkColor = System.Drawing.Color.DodgerBlue;
            this.LnkHabilitarUsuario.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.LnkHabilitarUsuario.LinkColor = System.Drawing.Color.DodgerBlue;
            this.LnkHabilitarUsuario.Location = new System.Drawing.Point(399, 445);
            this.LnkHabilitarUsuario.Name = "LnkHabilitarUsuario";
            this.LnkHabilitarUsuario.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LnkHabilitarUsuario.Size = new System.Drawing.Size(111, 25);
            this.LnkHabilitarUsuario.TabIndex = 0;
            this.LnkHabilitarUsuario.TabStop = true;
            this.LnkHabilitarUsuario.Text = "Habilitar";
            this.LnkHabilitarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LnkHabilitarUsuario.Visible = false;
            this.LnkHabilitarUsuario.VisitedLinkColor = System.Drawing.Color.DodgerBlue;
            this.LnkHabilitarUsuario.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkHabilitarUsuario_LinkClicked);
            // 
            // UcMensajeDeshabilitado
            // 
            this.UcMensajeDeshabilitado.Location = new System.Drawing.Point(12, 430);
            this.UcMensajeDeshabilitado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UcMensajeDeshabilitado.Message = "Este usuario se encuentra deshabilitado";
            this.UcMensajeDeshabilitado.Name = "UcMensajeDeshabilitado";
            this.UcMensajeDeshabilitado.Size = new System.Drawing.Size(381, 43);
            this.UcMensajeDeshabilitado.TabIndex = 141;
            this.UcMensajeDeshabilitado.TipoMensaje = Framework.WinForm.Comun.Notification.TipoMensajeGenerico.Advertencia;
            this.UcMensajeDeshabilitado.Visible = false;
            // 
            // FrmCrearEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 610);
            this.Controls.Add(this.LnkHabilitarUsuario);
            this.Controls.Add(this.UcMensajeDeshabilitado);
            this.Controls.Add(this.radPageView1);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.BtnCancelar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmCrearEditarUsuario";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "";
            this.Load += new System.EventHandler(this.FrmCrearOperador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCancelar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EpvCliente)).EndInit();
            this.PvSucursales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnAgregarSucursal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSucursales.MasterTemplate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvSucursales)).EndInit();
            this.PvGeneral.ResumeLayout(false);
            this.PvGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CbxCambiarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtConfirmarPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtApellidoNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDni)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radLabel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LbRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCelular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metroLabel12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPageView1)).EndInit();
            this.radPageView1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadButton BtnCancelar;
        private Telerik.WinControls.UI.RadButton BtnGuardar;
        private ErrorProvider EpvCliente;
        private Telerik.WinControls.UI.RadPageView radPageView1;
        private Telerik.WinControls.UI.RadPageViewPage PvGeneral;
        private Util.UcMessage UcMensajeAdvertenciaCambioClave;
        private Telerik.WinControls.UI.RadLabel radLabel2;
        private Telerik.WinControls.UI.RadCheckBox CbxCambiarClave;
        private Telerik.WinControls.UI.RadLabel metroLabel1;
        private Telerik.WinControls.UI.RadTextBox TxtConfirmarPassword;
        private Telerik.WinControls.UI.RadTextBox txtApellidoNombre;
        private Telerik.WinControls.UI.RadTextBox TxtPassword;
        private Telerik.WinControls.UI.RadLabel metroLabel4;
        private Telerik.WinControls.UI.RadLabel radLabel4;
        private Telerik.WinControls.UI.RadLabel metroLabel5;
        private Telerik.WinControls.UI.RadLabel radLabel3;
        private Telerik.WinControls.UI.RadLabel metroLabel6;
        private Telerik.WinControls.UI.RadTextBox TxtNombreUsuario;
        private Telerik.WinControls.UI.RadLabel metroLabel7;
        private Telerik.WinControls.UI.RadTextBox txtDni;
        private Telerik.WinControls.UI.RadLabel radLabel1;
        private Telerik.WinControls.UI.RadTextBox txtDomicilio;
        private Telerik.WinControls.UI.RadListControl LbRoles;
        private Telerik.WinControls.UI.RadTextBox txtTelefono;
        private Util.UcLocalidad UcLocalidad;
        private Telerik.WinControls.UI.RadTextBox txtCelular;
        private Util.UcProvincia UcProvincia;
        private Telerik.WinControls.UI.RadLabel metroLabel8;
        private Telerik.WinControls.UI.RadLabel metroLabel12;
        private Telerik.WinControls.UI.RadPageViewPage PvSucursales;
        private Telerik.WinControls.UI.RadButton BtnAgregarSucursal;
        private Telerik.WinControls.UI.RadGridView DgvSucursales;
        private Util.UcFiltroSucursal UcSucursales;
        private LinkLabel LnkHabilitarUsuario;
        private Util.UcMessage UcMensajeDeshabilitado;
    }
}