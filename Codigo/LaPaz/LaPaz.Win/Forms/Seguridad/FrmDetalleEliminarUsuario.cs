using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AutoMapper.QueryableExtensions;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Seguridad
{
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.SuperAdmin)]
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.Admin)]
    public partial class FrmDetalleEliminarUsuario : FormBase
    {
        private readonly Guid _operadorId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IUsuarioNegocio _usuarioNegocio;
        private Operador _operador;

        public FrmDetalleEliminarUsuario(ILaPazUow uow, IMessageBoxDisplayService messageBoxDisplayService, IUsuarioNegocio usuarioNegocio, Guid id, ActionFormMode mode)
        {
            Uow = uow;

            _messageBoxDisplayService = messageBoxDisplayService;
            _operadorId = id;
            _usuarioNegocio = usuarioNegocio;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleUsuario;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelElimimnarUsuario;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

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

        public string Provincia
        {
            get { return TxtProvincia.Text.Trim(); }
            set { TxtProvincia.Text = value; }
        }

        public string Localidad
        {
            get { return TxtLocalidad.Text.Trim(); }
            set { TxtLocalidad.Text = value; }
        }

        #endregion

        private void FrmDetalleEliminarUsuario_Load(object sender, EventArgs e)
        {
            CargarUsuario(_operadorId);
        }

        private void CargarUsuario(Guid operadorId)
        {
            _operador = Uow.Operadores.Obtener(c => c.Id == operadorId, 
                                                      c => c.Personal.Provincia,
                                                      c => c.Personal.Localidad,
                                                      o => o.OperadorSucursals.Select(op => op.Sucursal.Provincia),
                                                      o => o.OperadorSucursals.Select(op => op.Sucursal.Localidad));

            this.NombreUsuario = _operador.Usuario;

            if (_operador.Personal != null)
            {
                this.ApellidoNombre = _operador.Personal.Nombre;
                this.Domicilio = _operador.Personal.Domicilio;
                this.Telefono = _operador.Personal.Telefono;
                this.Celular = _operador.Personal.Celular;
                this.Provincia = _operador.Personal.Provincia != null ? _operador.Personal.Provincia.Nombre : string.Empty;
                this.Localidad = _operador.Personal.Localidad != null ? _operador.Personal.Localidad.Nombre : string.Empty;
                this.Cuit = _operador.Personal.Cuit;
            }

            CargarRoles(_operador);
            CargarSucursales(_operador);

            ToggleHabilitado();
        }

        private void ToggleHabilitado()
        {
            if (!_operador.Habilitado)
            {
                UcMensajeDeshabilitado.Visible = true;
                LnkHabilitarUsuario.Visible = true;
                BtnEliminar.Visible = false;
            }
            else
            {
                UcMensajeDeshabilitado.Visible = false;
                LnkHabilitarUsuario.Visible = false;
                BtnEliminar.Visible = true;
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

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _usuarioNegocio.DeshabilitarOperador(_operadorId);
        }

        private void LnkHabilitarUsuario_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _usuarioNegocio.DeshabilitarOperador(_operadorId);
            ToggleHabilitado();
        }
    }
}
