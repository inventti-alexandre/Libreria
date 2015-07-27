using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Seguridad;
using LaPaz.Seguridad.Interfaces;
using LaPaz.Entidades;
using LaPaz.Datos.Interfaces;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Autenticacion
{
    public partial class FrmLogin : EditFormBase
    {
        private readonly IAuthenticationService _authenticationService;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        public List<string> RolesAceptados { get; set; }
        public bool CambiarIdentity { get; set; }
        public Operador UltimoOperadorIngresado { get; set; } 
            
        public FrmLogin(IAuthenticationService authenticationService, IMessageBoxDisplayService messageBoxDisplayService,ILaPazUow uow)
        {
            CambiarIdentity = true;

            _authenticationService = authenticationService;
            _messageBoxDisplayService = messageBoxDisplayService;

            Uow = uow;

            InitializeComponent();
        }

        public static Operador RequerirAdmin()
        {
            var formFactory = Ioc.Container.Get<IFormFactory>();
            using (var login = formFactory.Create<FrmLogin>())
            {
                login.RolesAceptados = new List<string>() { RolesNames.Admin, RolesNames.SuperAdmin };
                login.CambiarIdentity = false;
                if (login.ShowDialog() == DialogResult.OK)
                {
                    return login.UltimoOperadorIngresado;
                }
                else
                {
                    //Cancelado.
                    return null;
                }
            }
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            var clearTextPassword = TxtPassword.Text;
            var username = CbxUsuario.Usuario;

            this.FormErrorProvider.Clear();

            if (string.IsNullOrEmpty(username))
            {
                this.FormErrorProvider.SetError(CbxUsuario, "Debe ingresar un usuario");
                this.DialogResult = DialogResult.None;
                return;
            }

            if (string.IsNullOrEmpty(clearTextPassword))
            {
                this.FormErrorProvider.SetError(TxtPassword, "Debe ingresar una clave");
                this.DialogResult = DialogResult.None;
                return;
            }

            if (UcSucursales.Sucursal == null)
            {
                this.FormErrorProvider.SetError(UcSucursales, "Debe seleccionar una sucursal");
                this.DialogResult = DialogResult.None;
                return;
            }

            try
            {
                //Validate credentials through the authentication service
                Operador user = _authenticationService.AuthenticateUser(username, clearTextPassword);
                Sucursal sucursal = UcSucursales.Sucursal;

                //Get the current principal object
                LaPazPrincipal laPazPrincipal = Thread.CurrentPrincipal as LaPazPrincipal;
                if (laPazPrincipal == null)
                    throw new ArgumentException("The application's default thread principal must be set to a CustomPrincipal object on startup.");


                var sucursalValida = user.OperadorSucursals.Any(s => s.SucursalId == sucursal.Id);
                if (!sucursalValida)
                {
                    this.FormErrorProvider.SetError(UcSucursales, "No esta habilitado para ingresar con esta sucursal");
                    this.DialogResult = DialogResult.None;
                    return;
                }

                if (RolesAceptados != null && RolesAceptados.Any())
                {
                    if (!(user.Roles.Select(r => r.Description).Any(r => RolesAceptados.Any(ra => ra == r))))
                    {
                        _messageBoxDisplayService.ShowError(Resources.ErrorMessageRolesRequeridos);
                        this.DialogResult = DialogResult.None;
                        return;
                    }
                }

                if (CambiarIdentity)
                {
                    //Authenticate the user
                    laPazPrincipal.Identity = new LaPazIdentity(user, sucursal);
                }

                UltimoOperadorIngresado = user;

            }
            catch (UnauthorizedAccessException)
            {
                _messageBoxDisplayService.ShowError("La credenciales ingresadas no son correctas");
                this.DialogResult = DialogResult.None;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            if (Context.SucursalActual != null)
            {
                UcSucursales.SucursalId = Context.SucursalActual.Id;
            }

            CbxUsuario.SeleccionarFinished += UsuarioSeleccionado;
            CbxUsuario.CargarOperadores(2);
        }

        private void UsuarioSeleccionado(object sender, Operador operador)
        {
            //var operador = Uow.Operadores.Obtener(o => o.Usuario == CbxUsuario.Usuario,o => o.OperadorSucursals);

            if (operador != null)
            {
                var sucursal = operador.OperadorSucursals.FirstOrDefault();

                if (sucursal != null && (!UcSucursales.SucursalId.HasValue || UcSucursales.SucursalId == 0))
                {
                    UcSucursales.SucursalId = sucursal.SucursalId;
                }
            }
        }
    }
}
