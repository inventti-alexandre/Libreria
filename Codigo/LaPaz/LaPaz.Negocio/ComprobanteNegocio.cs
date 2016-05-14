using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Comun.Extentensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using Framework.Comun.Utility;

namespace LaPaz.Negocio
{
    public class ComprobanteNegocio : NegocioBase, IComprobanteNegocio
    {
        public ComprobanteNegocio(IUowFactory uowFactory)
        {
            UowFactory = uowFactory;
        }

        public string FormaDePago(Guid comprobanteId)
        {
            StringBuilder formaPago = new StringBuilder();

            using (var uow = UowFactory.Create<ILaPazUow>())
            {

                var cajaMovimiento = uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == comprobanteId);

                if (cajaMovimiento != null)
                {
                    if (cajaMovimiento.Efectivo.HasValue)
                    {
                        formaPago.AppendFormat("Efectivo {0:c2}. ", cajaMovimiento.Efectivo);
                    }

                    if (cajaMovimiento.Tarjeta.HasValue)
                    {
                        var tarjetasMovimientos =
                            uow.TarjetasMovimientos.Listado(tm => tm.Tarjeta).Where(tm => tm.CajaMovimientoId == cajaMovimiento.Id).ToList();

                        foreach (var tarjetasMovimiento in tarjetasMovimientos)
                        {
                            formaPago.AppendFormat("Tarjeta  {0} {1:c2}. ", tarjetasMovimiento.Tarjeta.Nombre, tarjetasMovimiento.Importe);
                        }
                    }

                    if (cajaMovimiento.Cheque.HasValue)
                    {
                        var chequesTerceros =
                            uow.ChequesTercero.Listado(ch => ch.Banco).Where(ch => ch.CajaMovimientoId == cajaMovimiento.Id);

                        foreach (var chequeTercero in chequesTerceros)
                        {
                            formaPago.AppendFormat("Cheque  {0} {1:c2}. ", chequeTercero.Banco.Nombre, chequeTercero.Importe);
                        }
                    }

                    if (cajaMovimiento.Deposito.HasValue)
                    {
                        var cuentasMovimientos =
                            uow.CuentasMovimientos.Listado(ch => ch.Cuenta).Where(ch => ch.ComprobanteId == comprobanteId);

                        foreach (var cuentasMovimiento in cuentasMovimientos)
                        {
                            formaPago.AppendFormat("Deposito  {0} {1:c2}. ", cuentasMovimiento.Cuenta.Nombre, cuentasMovimiento.Credito);
                        }
                    }
                }
            }

            return formaPago.ToString();
        }

        public string FormaDePagoReimpresion(Guid comprobanteId)
        {
            StringBuilder formaPago = new StringBuilder();

            using (var uow = UowFactory.Create<ILaPazUow>())
            {

                var cajaMovimiento = uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == comprobanteId);

                if (cajaMovimiento != null)
                {
                    if (cajaMovimiento.Efectivo.HasValue)
                    {
                        formaPago.AppendFormat("Efectivo {0:c2}. ", cajaMovimiento.Efectivo);
                    }

                    if (cajaMovimiento.Tarjeta.HasValue)
                    {
                        //var tarjetasMovimientos =
                        //    uow.TarjetasMovimientos.Listado(tm => tm.Tarjeta).Where(tm => tm.CajaMovimientoId == cajaMovimiento.Id).ToList();
                       
                        //foreach (var tarjetasMovimiento in tarjetasMovimientos)
                        //{
                        //    formaPago.AppendFormat("Tarjeta  {0} {1:c2}. ", tarjetasMovimiento.Tarjeta.Nombre, tarjetasMovimiento.Importe);
                        //}
                        formaPago.AppendFormat("Tarjeta  {0} . ",  cajaMovimiento.Tarjeta);
                    }

                    if (cajaMovimiento.Cheque.HasValue)
                    {
                        //var chequesTerceros =
                        //    uow.ChequesTercero.Listado(ch => ch.Banco).Where(ch => ch.CajaMovimientoId == cajaMovimiento.Id);

                        //foreach (var chequeTercero in chequesTerceros)
                        //{
                        //    formaPago.AppendFormat("Cheque  {0} {1:c2}. ", chequeTercero.Banco.Nombre, chequeTercero.Importe);
                        //}
                        formaPago.AppendFormat("Cheque  {0} . ", cajaMovimiento.Cheque);
                    }

                    if (cajaMovimiento.Deposito.HasValue)
                    {
                        //var cuentasMovimientos =
                        //    uow.CuentasMovimientos.Listado(ch => ch.Cuenta).Where(ch => ch.ComprobanteId == comprobanteId);

                        //foreach (var cuentasMovimiento in cuentasMovimientos)
                        //{
                        //    formaPago.AppendFormat("Deposito  {0} {1:c2}. ", cuentasMovimiento.Cuenta.Nombre, cuentasMovimiento.Credito);
                        //}
                        formaPago.AppendFormat("Deposito  {0} . ", cajaMovimiento.Deposito);
                    }
                }
            }

            return formaPago.ToString();
        }
    }
}
