using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using Framework.Ioc;
using LaPaz.Seguridad;
using LaPaz.Win.Forms.Autenticacion;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Helpers
{
    public static class TitulosValidator
    {
        public static bool SolicitarAutorizacionPorCambioDePrecios(Titulo tituloAValidar)
        {
            var uowFactory = Ioc.Container.Get<IUowFactory>();

            using (var uow = uowFactory.Create<ILaPazUow>())
            {
                //Obtener el precio de venta actual en la base de datos.
                var titulo = uow.Titulos.Obtener(x => x.Id == tituloAValidar.Id);

                if (titulo == null) return false;

                decimal? precioDeCompraActual = titulo.PrecioCompraTitulo;
                decimal? precioDeVentaActual = titulo.PrecioVentaTitulo;

                var solicitarAutorizacion = (precioDeCompraActual.HasValue &&
                                             tituloAValidar.PrecioVentaTitulo < precioDeCompraActual.Value) ||
                                             tituloAValidar.PrecioVentaTitulo < precioDeVentaActual;

                return solicitarAutorizacion;
            }
        }
    }
}
