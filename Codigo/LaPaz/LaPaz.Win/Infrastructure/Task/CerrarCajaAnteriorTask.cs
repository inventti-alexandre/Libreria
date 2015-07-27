using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using Framework.Comun.Utility;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Infrastructure.Task
{
    public class CerrarCajaAnteriorTask : IRunAfterLogin
    {
        public void Execute()
        {
            var context = Ioc.Container.Get<ILaPazContext>();
            var clock = Ioc.Container.Get<IClock>();
            var now = clock.Now;

            using (var cajaNegocio = Ioc.Container.Get<ICajaNegocio>())
            {
                if (cajaNegocio.EstaUltimaCajaAbierta(context.OperadorActual.Id, context.SucursalActual.Id))
                {
                    var ultimaCaja = cajaNegocio.UltimaCaja(context.OperadorActual.Id, context.SucursalActual.Id);

                    if ((now.Date > ultimaCaja.Fecha.Date))
                    {
                        cajaNegocio.CerrarCaja(context.OperadorActual.Id, context.SucursalActual.Id);
                        cajaNegocio.AbrirCaja(context.OperadorActual.Id, context.SucursalActual.Id);

                        var messageBoxService = Ioc.Container.Get<IMessageBoxDisplayService>();

                        messageBoxService.ShowInfo(Resources.InfoMessageCajaAnteriorCerradaAutomaticamente);
                    }
                }
            }
        }
    }
}
