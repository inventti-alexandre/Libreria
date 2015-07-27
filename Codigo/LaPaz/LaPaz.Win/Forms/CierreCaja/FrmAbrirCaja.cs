using System;
using System.Threading;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Seguridad.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Properties;
using LaPaz.Datos.Interfaces;

namespace LaPaz.Win.Forms.CierreCaja
{
    public partial class FrmAbrirCaja : EditFormBase
    {
        private readonly ICajaNegocio _cajaNegocio;

        public FrmAbrirCaja(ILaPazUow uow, ICajaNegocio cajaNegocio)
        {
            Uow = uow;

            _cajaNegocio = cajaNegocio;
                
            InitializeComponent();
        }

        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            _cajaNegocio.AbrirCaja(Context.OperadorActual.Id, Context.SucursalActual.Id);
        }

        private void FrmAbrirCaja_Load(object sender, EventArgs e)
        {
            LbConfirmacionAbrirCaja.Text = string.Format(Resources.LabelConfirmarAbrirCaja, Context.OperadorActual.Usuario);
        }
    }
}
