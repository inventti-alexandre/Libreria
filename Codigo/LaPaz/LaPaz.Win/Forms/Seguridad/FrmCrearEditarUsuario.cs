using System;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;
using LaPaz.Seguridad.Interfaces;
using Telerik.WinControls.Enumerations;
using Telerik.WinControls.UI;
using LaPaz.Entidades.Dto;
using AutoMapper.QueryableExtensions;

namespace LaPaz.Win.Forms.Seguridad
{
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.SuperAdmin)]
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.Admin)]
    public partial class FrmCrearEditarUsuario : EditFormBase
    {
        private readonly Guid _operadorId;
        private readonly IUsuarioNegocio _usuarioNegocio;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private readonly IEncryptionService _encryptionService;
        private Operador _operador;

        public FrmCrearEditarUsuario(ILaPazUow uow,
                                     IClock clock,
                                     IEncryptionService encryptionService,
                                     IUsuarioNegocio usuarioNegocio,
                                     Guid id,
                                     ActionFormMode mode)
        {
            Uow = uow;

            _operadorId = id;
            _clock = clock;
            _formMode = mode;
            _encryptionService = encryptionService;
            _usuarioNegocio = usuarioNegocio;

            InitializeComponent();
            InicializarForm(mode);

            UcProvincia.SeleccionarFinished += cbxProvincia_SeleccionarFinished;
        }

        #region Eventos
        public event EventHandler<Operador> OperadorAgregado;
        #endregion

        #region Propiedades

        public Guid Id { get; set; }

        public string ApellidoNombre
        {
            get { return txtApellidoNombre.Text; }
            set { txtApellidoNombre.Text = value; }
        }

        public string NombreUsuario
        {
            get { return TxtNombreUsuario.Text; }
            set { TxtNombreUsuario.Text = value; }
        }

        public string Cuit
        {
            get { return txtDni.Text; }
            set { txtDni.Text = value; }
        }

        public string Domicilio
        {
            get { return txtDomicilio.Text; }
            set { txtDomicilio.Text = value; }
        }

        public string Telefono
        {
            get { return txtTelefono.Text; }
            set { txtTelefono.Text = value; }
        }

        public string Celular
        {
            get { return txtCelular.Text.Trim(); }
            set { txtCelular.Text = value; }
        }

        public GridViewDataColumn ColumnaEliminar
        {
            get
            {
                return DgvSucursales.Columns.GetColumnByFieldName("ColumnaEliminar").FirstOrDefault();
            }
        }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearUsuarioOperador;
                    this.CbxCambiarClave.IsChecked = true;
                    this.CbxCambiarClave.Visible = false;
                    UcMensajeAdvertenciaCambioClave.Visible = false;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarOperador;
                    break;
            }
        }

        private void FrmCrearOperador_Load(object sender, EventArgs e)
        {
            CargarOperador(_operadorId);
        }

        private void CargarOperador(Guid usuarioId)
        {
            if (usuarioId == default(Guid))
            {
                _operador = new Operador();
                _operador.Id = Guid.NewGuid();
                _operador.Personal = new Personal();
                _operador.Personal.Id = Guid.NewGuid();
                _operador.Habilitado = true;
            }
            else
            {
                _operador = Uow.Operadores.Obtener(c => c.Id == usuarioId, o => o.Roles, o => o.Personal,
                                                                           o => o.OperadorSucursals.Select(op => op.Sucursal.Provincia),
                                                                           o => o.OperadorSucursals.Select(op => op.Sucursal.Localidad));
                if (_operador.Personal == null)
                {
                    _operador.Personal = new Personal();
                    _operador.Personal.Id = Guid.NewGuid();
                }
            }

            this.NombreUsuario = _operador.Usuario;

            this.ApellidoNombre = _operador.Personal.Nombre;
            this.Domicilio = _operador.Personal.Domicilio;
            this.Telefono = _operador.Personal.Telefono;
            this.Celular = _operador.Personal.Celular;
            this.UcProvincia.ProvinciaId = _operador.Personal.ProvinciaId;
            this.UcLocalidad.LocalidadId = _operador.Personal.LocalidadId;
            this.Cuit = _operador.Personal.Cuit;

            CargarRoles(_operador);
            CargarSucursales(_operador);

            ToggleHabilitado();
        }

        private void ToggleHabilitado()
        {
            if (!_operador.Habilitado)
            {
                txtApellidoNombre.Enabled = false;
                TxtNombreUsuario.Enabled = false;
                txtCelular.Enabled = false;
                txtDni.Enabled = false;
                txtDomicilio.Enabled = false;
                txtTelefono.Enabled = false;
                TxtPassword.Enabled = false;
                TxtConfirmarPassword.Enabled = false;

                UcLocalidad.Enabled = false;
                UcProvincia.Enabled = false;
                UcSucursales.Enabled = false;

                CbxCambiarClave.Enabled = false;
                ColumnaEliminar.IsVisible = false;
                LbRoles.Enabled = false;

                BtnAgregarSucursal.Enabled = false;

                UcMensajeDeshabilitado.Visible = true;
                LnkHabilitarUsuario.Visible = true;
            }
            else
            {
                txtApellidoNombre.Enabled = true;
                TxtNombreUsuario.Enabled = true;
                txtCelular.Enabled = true;
                txtDni.Enabled = true;
                txtDomicilio.Enabled = true;
                txtTelefono.Enabled = true;
                TxtPassword.Enabled = true;
                TxtConfirmarPassword.Enabled = true;

                UcLocalidad.Enabled = true;
                UcProvincia.Enabled = true;
                UcSucursales.Enabled = true;

                CbxCambiarClave.Enabled = true;
                ColumnaEliminar.IsVisible = true;
                LbRoles.Enabled = true;

                UcMensajeDeshabilitado.Visible = false;
                LnkHabilitarUsuario.Visible = false;

                BtnAgregarSucursal.Enabled = true;
            }
        }

        private void CargarSucursales(Operador operador)
        {
            var sucursales = operador.OperadorSucursals.Select(op => op.Sucursal).AsQueryable().Project().To<SucursalDto>().ToList();
            DgvSucursales.DataSource = sucursales;
        }

        private void CargarRoles(Operador operador)
        {
            var roles = Uow.Roles.Listado().ToList();
            var rolesAsignados = operador.Roles;

            if (!operador.Habilitado)
            {
                LbRoles.DataSource = rolesAsignados;
                return;
            }

            LbRoles.DataSource = roles;

            foreach (var item in LbRoles.Items)
            {
                var role = item.DataBoundItem as Role;
                if (role != null)
                {
                    item.Selected = rolesAsignados.Any(r => r.Id == role.Id);
                }
            }
        }

        private void cbxProvincia_SeleccionarFinished(object sender, Provincia provincia)
        {
            UcLocalidad.CargarLocalidades(provincia.Id);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            CrearEditarOperador();
        }

        private void CrearEditarOperador()
        {
            var esValido = this.ValidarForm();

            if (!esValido)
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var operador = ObtenerOperadorDesdeForm();

                //Guardar nuevo password.
                if (CbxCambiarClave.IsChecked)
                {
                    operador.Clave = _encryptionService.CalculateHash(TxtPassword.Text, NombreUsuario);
                }

                if (_formMode == ActionFormMode.Create)
                {
                    _usuarioNegocio.CrearOperador(operador);
                    OnOperadorAgregado(operador);
                }
                else
                {
                    _usuarioNegocio.EditarOperador(operador);
                }
            }
        }

        private void OnOperadorAgregado(Operador cliente)
        {
            if (OperadorAgregado != null)
            {
                OperadorAgregado(this, cliente);
            }
        }

        private Operador ObtenerOperadorDesdeForm()
        {
            _operador.Usuario = NombreUsuario;
            _operador.Personal.Nombre = ApellidoNombre;
            _operador.Personal.Domicilio = Domicilio;
            _operador.Personal.Telefono = Telefono;
            _operador.Personal.Celular = Celular;
            _operador.Personal.ProvinciaId = UcProvincia.ProvinciaId;
            _operador.Personal.LocalidadId = UcLocalidad.LocalidadId;
            _operador.Personal.Cuit = Cuit.PadLeft(11, '0');

            _operador.Roles.Clear();
            _operador.Roles = LbRoles.SelectedItems.Select(i => i.DataBoundItem as Role).ToList();

            //Fechas.
            _operador.FechaAlta = _formMode == ActionFormMode.Create ? _clock.Now : _operador.FechaAlta;
            _operador.FechaModificacion = _formMode == ActionFormMode.Create ? (DateTime?)null : _clock.Now;

            _operador.SucursalAltaId = _formMode == ActionFormMode.Create
                                          ? this.Context.SucursalActual.Id
                                          : _operador.SucursalAltaId;

            _operador.SucursalModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _operador.SucursalModificacionId;

            _operador.OperadorAltaId = _formMode == ActionFormMode.Create
                                          ? this.Context.OperadorActual.Id
                                          : _operador.OperadorAltaId;

            _operador.OperadorModificacionId = _formMode == ActionFormMode.Create
                                                  ? null
                                                  : _operador.OperadorModificacionId;

            return _operador;
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerOperadorDesdeForm();
        }

        protected override bool ValidarForm()
        {
            var esValido = base.ValidarForm();

            if (CbxCambiarClave.IsChecked)
            {
                if (string.IsNullOrEmpty(TxtPassword.Text))
                {
                    FormErrorProvider.SetError(TxtPassword, "Debe ingresar una clave");
                    esValido = false;
                }

                if (string.IsNullOrEmpty(TxtConfirmarPassword.Text))
                {
                    FormErrorProvider.SetError(TxtConfirmarPassword, "Debe confirmar la clave");
                    esValido = false;
                }

                if (TxtPassword.Text != TxtConfirmarPassword.Text)
                {
                    FormErrorProvider.SetError(TxtPassword, Resources.ErrorMessagePasswordsDiferentes);
                    FormErrorProvider.SetError(TxtConfirmarPassword, Resources.ErrorMessagePasswordsDiferentes);
                    esValido = false;
                }
            }

            return esValido;
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtNombreUsuario, "Usuario");
            this.ValidarControl(txtApellidoNombre, "Nombre");
            this.ValidarControl(txtDni, "Cuit");
            this.ValidarControl(txtDomicilio, "Domicilio");
            this.ValidarControl(txtCelular, "Celular");
        }

        #endregion

        private void BtnAgregarSucursal_Click(object sender, EventArgs e)
        {
            if (UcSucursales.Sucursal != null && !_operador.OperadorSucursals.Any(s => s.SucursalId == UcSucursales.Sucursal.Id))
            {
                //Obtenemos la sucursal de este contexto con provincias y localidades.
                var sucursalSeleccionada = Uow.Sucursales.Obtener(s => s.Id == UcSucursales.Sucursal.Id,
                                                                  s => s.Provincia,
                                                                  s => s.Localidad);
                var operadorSucursal = new OperadorSucursal();

                operadorSucursal.Id = Guid.NewGuid();
                operadorSucursal.OperadorAltaId = this.Context.OperadorActual.Id;
                operadorSucursal.FechaAlta = _clock.Now;
                operadorSucursal.SucursalId = UcSucursales.Sucursal.Id;
                operadorSucursal.Sucursal = sucursalSeleccionada;

                _operador.OperadorSucursals.Add(operadorSucursal);

                CargarSucursales(_operador);
            }
        }

        private void CbxCambiarClave_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            TxtPassword.Enabled = args.ToggleState == ToggleState.On;
            TxtConfirmarPassword.Enabled = args.ToggleState == ToggleState.On;
            UcMensajeAdvertenciaCambioClave.Visible = args.ToggleState == ToggleState.On;
        }

        private void DgvSucursales_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.DgvSucursales.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var sucursal = selectedRow.DataBoundItem as SucursalDto;

            if (sucursal == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaEliminar":
                    EliminarSucursal(sucursal);
                    break;
            }
        }

        private void EliminarSucursal(SucursalDto sucursal)
        {
            var operadorSucursalAEliminar = _operador.OperadorSucursals.FirstOrDefault(op => op.SucursalId == sucursal.Id);
            _operador.OperadorSucursals.Remove(operadorSucursalAEliminar);
            CargarSucursales(_operador);
        }

        private void LnkHabilitarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _usuarioNegocio.HabilitarOperador(_operador.Id);
            CargarOperador(_operador.Id);
        }
    }
}
