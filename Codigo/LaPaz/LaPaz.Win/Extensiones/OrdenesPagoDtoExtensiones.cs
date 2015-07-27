using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Utility;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Extensiones
{
    public static class OrdenesPagoDtoExtensiones
    {
        public static bool PuedeEliminar(this OrdenesPagoDto ordenPago)
        {
            return ordenPago.OrdenesPagoDetalles.All(d => d.PuedeEliminar());
        }

        public static bool PuedeEliminar(this OrdenesPagoDetalle ordenPagoDetalle)
        {
            var context = Ioc.Container.Get<ILaPazContext>();
            var clock = Ioc.Container.Get<IClock>();
            var now = clock.Now;

            using (var cajaNegocio = Ioc.Container.Get<ICajaNegocio>())
            {
                var caja = cajaNegocio.UltimaCaja(context.OperadorActual.Id, context.SucursalActual.Id);
                if (caja != null)
                {
                    var puedeEditarDetalle = (ordenPagoDetalle.FechaAlta.HasValue &&
                                              ordenPagoDetalle.FechaAlta.Value.Date == now.Date &&
                                              ordenPagoDetalle.OperadorAltaId == context.OperadorActual.Id &&
                                              caja.Fecha.Date == now.Date &&
                                              caja.FCierre == null &&
                                              ordenPagoDetalle.CajaId == caja.Id);
                    if (!puedeEditarDetalle)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
