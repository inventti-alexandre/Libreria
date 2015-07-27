using System;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Properties;
using LaPaz.Datos.Interfaces;

namespace LaPaz.Win.Forms.CierreCaja
{
    public partial class FrmCerrarCaja : EditFormBase
    {
        private readonly ICajaNegocio _cajaNegocio;

        public FrmCerrarCaja(ILaPazUow uow, ICajaNegocio cajaNegocio)
        {
            Uow = uow;

            _cajaNegocio = cajaNegocio;

            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            _cajaNegocio.CerrarCaja(Context.OperadorActual.Id, Context.SucursalActual.Id);
        }

        private void FrmCerrarCaja_Load(object sender, EventArgs e)
        {
            LbConfirmacionCerrarCaja.Text = string.Format(Resources.LabelConfirmarCerrarCaja, Context.OperadorActual.Usuario);
        }
    }
}
