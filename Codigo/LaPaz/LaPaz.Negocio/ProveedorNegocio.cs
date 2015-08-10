using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using LaPaz.Entidades;
using AutoMapper;
using Framework.Comun.Utility;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Response;

namespace LaPaz.Negocio
{
    public class ProveedorNegocio : NegocioBase, IProveedorNegocio
    {
        private readonly IClock _clock;

        public ProveedorNegocio(ILaPazUow uow, IUowFactory uowFactory, IClock clock)
        {
            _clock = clock;
            Uow = uow;
            UowFactory = uowFactory;
        }

        public List<ProveedorDto> Listado(string sortBy, string sortDirection, int? cuenta, string denominacion, string cuit, int? provinciaId, int? localidadId, TipoProveedor tipoProveedor, bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Denominacion";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Proveedor, bool>> where = x => ((tipoProveedor == TipoProveedor.Normal && x.Gto == false) || (tipoProveedor == TipoProveedor.Gastos && x.Gto == true)) &&
                                                           (!cuenta.HasValue || (x.Cuenta.HasValue && x.Cuenta.ToString().Contains(cuenta.ToString()))) &&
                                                           (string.IsNullOrEmpty(denominacion) ||
                                                            x.Denominacion.Contains(denominacion)) &&
                                                           (string.IsNullOrEmpty(cuit) || x.Cuit.Contains(cuit)) &&
                                                           (!provinciaId.HasValue || x.ProvinciaId == provinciaId) &&
                                                           (!localidadId.HasValue || x.LocalidadId == localidadId) &&
                                                           (!activo.HasValue || x.Activo == activo);

            var resultados = Uow.Proveedores.Listado(criteros,
                                                     where,
                                                     x => x.Localidad,
                                                     x => x.Provincia,
                                                     x => x.CondicionCompra,
                                                     x => x.Banco);


            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<ProveedorDto>().ToList();
        }

        public List<ProveedorSenia> Senias(string sortBy, string sortDirection, Guid? proveedorId, int pageIndex, int pageSize, out int pageTotal)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                var criteros = new PagingCriteria();

                criteros.PageNumber = pageIndex;
                criteros.PageSize = pageSize;
                criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
                criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

                Expression<Func<ProveedorSenia, bool>> where = x => !proveedorId.HasValue || x.ProveedorId == proveedorId;

                var resultados = uow.ProveedoresSenias.Listado(criteros, where);

                pageTotal = resultados.PagedMetadata.TotalItemCount;

                return resultados.Entities.ToList();
            }
        }

        public decimal SenaAFavorProveedor(Guid proveedorId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                var proveedorMontosFavor = uow.ProveedoresSenias.Listado().Where(ps => ps.ProveedorId == proveedorId
                                                                                       && ps.ImporteUsado < ps.Importe)
                    .ToList();

                return
                    proveedorMontosFavor.Sum(cm => cm.Importe.GetValueOrDefault() - cm.ImporteUsado.GetValueOrDefault());
            }

        }

        public List<ProveedorCtaCteDto> ProveedorCtaCte(string sortBy, string sortDirection, int? cuenta, string denominacion, string cuit, bool? activo, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "CompraId";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<ProveedoresCuentasCorriente, bool>> where = x => (
                                                           (!cuenta.HasValue || (x.Proveedor.Cuenta.HasValue && x.Proveedor.Cuenta.ToString().Contains(cuenta.ToString()))) &&
                                                           (string.IsNullOrEmpty(denominacion) ||
                                                            x.Proveedor.Denominacion.Contains(denominacion)) &&
                                                           (string.IsNullOrEmpty(cuit) || x.Proveedor.Cuit.Contains(cuit)) &&
                                                           (!activo.HasValue || x.Proveedor.Activo == activo) &&
                                                           ((x.Importe - x.Pagado) > 0));

            var resultados = Uow.ProveedoresCuentasCorrientes.Listado(criteros,
                                                     where,
                                                     x => x.Proveedor,
                                                     x => x.Compra);


            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<ProveedorCtaCteDto>().ToList();
        }

        public List<ProveedorConsignacionDto> ProveedorConsignacion(string sortBy, string sortDirection, Guid? proveedorId, int? cuenta,
            string denominacion, string cuit, bool? activo, DateTime? fechaConsigDesde, DateTime? fechaConsigHasta, bool? pendientePago,
            int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Id";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<TituloConsignacionRendida, bool>> where = x => (
                (!cuenta.HasValue ||
                 (x.Proveedor.Cuenta.HasValue && x.Proveedor.Cuenta.ToString().Contains(cuenta.ToString()))) &&
                (string.IsNullOrEmpty(denominacion) ||
                 x.Proveedor.Denominacion.Contains(denominacion)) &&
                (string.IsNullOrEmpty(cuit) || x.Proveedor.Cuit.Contains(cuit)) &&
                (!activo.HasValue || x.Proveedor.Activo == activo) &&
                (!proveedorId.HasValue || x.ProveedorId == proveedorId) &&
                (!fechaConsigDesde.HasValue || x.FechaConsignacion >= fechaConsigDesde) &&
                (!fechaConsigHasta.HasValue || x.FechaConsignacion <= fechaConsigHasta) &&
                (!pendientePago.HasValue ||
                 (pendientePago.Value && ((x.Importe - x.Pagado) > 0 || x.Pagado == null))) ||
                (!pendientePago.Value && ((x.Importe >= x.Pagado))));

            var resultados = Uow.TitulosConsignacionesRendidas.Listado(criteros, where, x => x.Proveedor);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<ProveedorConsignacionDto>().ToList();
        }

        public TituloConsignacionRendidaDto ObtenerTituloConsignacionPorId(Guid tituloConsignacionRendidaId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                TituloConsignacionRendidaDto response = new TituloConsignacionRendidaDto();

                var tituloConsignacionRendida =
                uow.TitulosConsignacionesRendidas.Obtener(x => x.Id == tituloConsignacionRendidaId, x => x.Proveedor);

                var tituloConsignacionDetalle =
                    uow.TitulosConsignacionesRendidasDetalle.Listado(x => x.Titulo.Autor)
                        .Where(x => x.TituloConsignacionRendidaId == tituloConsignacionRendidaId)
                        .Project().To<TituloConsignacionRendidasDetalleDto>().ToList();


                response.TituloConsignacionRendida = tituloConsignacionRendida;
                response.TituloConsignacionRendidasDetalle = tituloConsignacionDetalle;

                return response;
            }
        }

        public List<ProveedorConsignacionDto> ProveedorConsignacion(string sortBy, string sortDirection,
            Guid? proveedorId, bool? activo, DateTime? fechaConsigDesde, DateTime? fechaConsigHasta, int pageIndex,
            int pageSize, out int pageTotal)
        {
            return ProveedorConsignacion(sortBy, sortDirection, proveedorId, null, null, null, activo, fechaConsigDesde, fechaConsigHasta, null, pageIndex, pageSize, out pageTotal);
        }

        public void AnularSeniaProveedor(ProveedorSenia senia, Caja caja, Guid operadorId, int sucursalId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                var diferencia = senia.Importe - senia.ImporteUsado;
                if (diferencia == 0)
                    return;

                senia.ImporteUsado = senia.Importe;
                senia.FechaAnulacion = _clock.Now;
                senia.FechaModificacion = _clock.Now;
                senia.OperadorModificacionId = operadorId;
                senia.SucursalModificacionId = sucursalId;

                uow.ProveedoresSenias.Modificar(senia);

                if (caja.Ingresos == null)
                    caja.Ingresos = 0;
                caja.Egresos += (float?)diferencia;
                if (caja.Saldo == null)
                    caja.Saldo = 0;
                caja.Saldo -= (float?)diferencia;
                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = sucursalId;
                caja.OperadorModificacionId = operadorId;

                uow.Cajas.Modificar(caja);

                //Se deben buscar todas las cajasMovimientos
                var cajaMovimientoAnterior = uow.CajaMovimientos.Listado().Where(cm => cm.ComprobanteId == senia.Id);
                foreach (CajaMovimiento movimiento in cajaMovimientoAnterior)
                {
                    CajaMovimiento cajaMovimiento = new CajaMovimiento();
                    cajaMovimiento.Id = Guid.NewGuid();
                    cajaMovimiento.CajaId = caja.Id;
                    cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulacionSeniaProveedor;
                    cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaCliente;
                    cajaMovimiento.ComprobanteId = senia.Id;
                    cajaMovimiento.Senia = 0;
                    //analizar para Anulaciones Parciales
                    cajaMovimiento.Importe = movimiento.Importe;
                    cajaMovimiento.Efectivo = movimiento.Efectivo;
                    cajaMovimiento.Tarjeta = movimiento.Tarjeta;
                    cajaMovimiento.Cheque = movimiento.Cheque;
                    cajaMovimiento.Deposito = movimiento.Deposito;
                    cajaMovimiento.ImpFac = 0;
                    cajaMovimiento.PcAlta = Environment.MachineName;
                    cajaMovimiento.SucursalAltaId = sucursalId;
                    cajaMovimiento.OperadorAltaId = operadorId;
                    cajaMovimiento.FechaAlta = _clock.Now;
                    uow.CajaMovimientos.Agregar(cajaMovimiento);
                }

                uow.Commit();
            }
        }

        public void CrearSeniaProveedor(ProveedorSenia senia, IList<VentaPago> pagos, Caja caja, Guid operadorId, int sucursalId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                decimal? efectivo = 0;
                decimal? efectivoCajaAnterior = 0;
                decimal? tarjeta = 0;
                decimal? cheque = 0;
                decimal? deposito = 0;
                decimal? transferencia = 0;

                foreach (var pago in pagos)
                {
                    switch (pago.TipoPago)
                    {
                        case FormaPago.Efectivo:
                            efectivo += pago.Importe;
                            break;

                        case FormaPago.EfectivoCajaAnterior:
                            efectivoCajaAnterior += pago.Importe;
                            break;

                        case FormaPago.Tarjeta:
                            tarjeta += pago.Importe;
                            break;

                        case FormaPago.Cheque:
                            cheque += pago.Importe;
                            break;

                        case FormaPago.Deposito:
                            deposito += pago.Importe;
                            break;

                        case FormaPago.Transferencia:
                            transferencia += pago.Importe;
                            break;
                    }
                }

                if (efectivo > 0)
                {
                    //creo la caja movimiento para los pagos en efectivo que tocan la caja actual
                    CajaMovimiento cajaMovimiento = new CajaMovimiento();

                    cajaMovimiento.Id = Guid.NewGuid();
                    cajaMovimiento.CajaId = caja.Id;
                    cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaProveedor;
                    cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.SeñaProveedor;

                    cajaMovimiento.ComprobanteId = senia.Id;
                    cajaMovimiento.Importe = efectivo;
                    cajaMovimiento.ImpFac = efectivo;
                    cajaMovimiento.FechaAlta = _clock.Now;
                    cajaMovimiento.FechaModificacion = _clock.Now;
                    cajaMovimiento.PcAlta = System.Environment.MachineName;
                    cajaMovimiento.OperadorAltaId = operadorId;
                    cajaMovimiento.SucursalAltaId = sucursalId;
                    cajaMovimiento.OperadorModificacionId = operadorId;
                    cajaMovimiento.SucursalModificacionId = sucursalId;

                    //descontar de la caja
                    if (caja.Egresos == null)
                        caja.Egresos = 0;

                    caja.Egresos += (float?)efectivo;

                    if (caja.Saldo == null)
                        caja.Saldo = 0;

                    caja.Saldo -= (float?)efectivo;

                    caja.FechaModificacion = _clock.Now;
                    caja.SucursalModificacionId = sucursalId;//Sucursal del operador
                    caja.OperadorModificacionId = (operadorId);//Id el operador

                    //traer la caja
                    if (cajaMovimiento.Efectivo == null)
                        cajaMovimiento.Efectivo = 0;

                    cajaMovimiento.Efectivo = efectivo;

                    uow.CajaMovimientos.Agregar(cajaMovimiento);
                }

                if (tarjeta > 0 || deposito > 0 || cheque > 0 || efectivoCajaAnterior > 0 || transferencia > 0)
                {
                    //creo la caja movimiento para los pagos en efectivo que tocan la caja actual
                    CajaMovimiento cajaMovimientoAnterior = new CajaMovimiento();

                    cajaMovimientoAnterior.Id = Guid.NewGuid();
                    cajaMovimientoAnterior.CajaId = caja.Id;
                    cajaMovimientoAnterior.TipoComprobante = TipoComprobanteEnum.SeñaProveedor;
                    cajaMovimientoAnterior.TipoMovimientoCajaId = TipoMovimientoCajaEnum.SeñaProveedorCajaAnterior;
                    cajaMovimientoAnterior.ComprobanteId = senia.Id;
                    cajaMovimientoAnterior.Importe = tarjeta + deposito + cheque + efectivoCajaAnterior + transferencia;
                    cajaMovimientoAnterior.ImpFac = tarjeta + deposito + cheque + efectivoCajaAnterior + transferencia;
                    cajaMovimientoAnterior.FechaAlta = _clock.Now;
                    cajaMovimientoAnterior.FechaModificacion = _clock.Now;
                    cajaMovimientoAnterior.PcAlta = System.Environment.MachineName;
                    cajaMovimientoAnterior.OperadorAltaId = operadorId;
                    cajaMovimientoAnterior.SucursalAltaId = sucursalId;
                    cajaMovimientoAnterior.OperadorModificacionId = operadorId;
                    cajaMovimientoAnterior.SucursalModificacionId = sucursalId;

                    if (efectivoCajaAnterior > 0)
                    {
                        if (cajaMovimientoAnterior.Efectivo == null)
                            cajaMovimientoAnterior.Efectivo = 0;

                        cajaMovimientoAnterior.Efectivo += efectivoCajaAnterior;

                        if (caja.Saldo == null)
                            caja.Saldo = 0;
                        caja.Saldo -= (float?)efectivo;
                    }

                    if (tarjeta > 0)
                    {
                        if (cajaMovimientoAnterior.Tarjeta == null)
                            cajaMovimientoAnterior.Tarjeta = 0;

                        cajaMovimientoAnterior.Tarjeta += tarjeta;
                    }

                    if (cheque > 0)
                    {
                        if (cajaMovimientoAnterior.Cheque == null)
                            cajaMovimientoAnterior.Cheque = 0;

                        cajaMovimientoAnterior.Cheque += cheque;
                    }

                    if (deposito > 0)
                    {
                        if (cajaMovimientoAnterior.Deposito == null)
                            cajaMovimientoAnterior.Deposito = 0;

                        cajaMovimientoAnterior.Deposito += deposito;
                    }

                    if (transferencia > 0)
                    {
                        if (cajaMovimientoAnterior.Transferencia == null)
                            cajaMovimientoAnterior.Transferencia = 0;

                        cajaMovimientoAnterior.Transferencia += transferencia;
                    }

                    uow.CajaMovimientos.Agregar(cajaMovimientoAnterior);
                }

                //Guardamos el movimiento del depósito
                foreach (var pago in pagos)
                {
                    switch (pago.TipoPago)
                    {
                        case FormaPago.Cheque:
                            // HACER ALGO
                            break;

                        case FormaPago.Deposito:
                            var pagoDeposito = pago as VentaPagoDeposito;

                            CuentasMovimiento cuentasMovimiento = new CuentasMovimiento();
                            cuentasMovimiento.CuentaId = pagoDeposito.CuentaId ?? 0;
                            cuentasMovimiento.TipoMovimientoId = 1;//Deposito a proveedor
                            cuentasMovimiento.FechaMovimiento = pagoDeposito.Fecha;
                            cuentasMovimiento.EstadoMovimientoCuentaId = 0;
                            cuentasMovimiento.TipoComprobanteId = TipoComprobanteEnum.SeñaProveedor;
                            cuentasMovimiento.ComprobanteId = senia.Id;
                            cuentasMovimiento.MonedaId = 0;
                            cuentasMovimiento.NroMovimiento = pagoDeposito.Numero;
                            cuentasMovimiento.Descripcion = "DEPOSITO SEÑA NRO " + pagoDeposito.Numero.ToString();
                            cuentasMovimiento.FechaCobro = _clock.Now;
                            cuentasMovimiento.Debito = pago.Importe;
                            cuentasMovimiento.Credito = 0;
                            cuentasMovimiento.TipoCarga = 1;
                            cuentasMovimiento.CajaId = caja.Id;
                            cuentasMovimiento.FechaAlta = _clock.Now;
                            cuentasMovimiento.OperadorAltaId = operadorId;
                            cuentasMovimiento.SucursalAltaId = sucursalId;

                            uow.CuentasMovimientos.Agregar(cuentasMovimiento);
                            break;

                        case FormaPago.Transferencia:
                            var pagoTransferencia = pago as VentaPagoTransferencia;

                            CuentasMovimiento cuentasMovimientoTransferecia = new CuentasMovimiento();
                            cuentasMovimientoTransferecia.CuentaId = pagoTransferencia.CuentaId ?? 0;
                            cuentasMovimientoTransferecia.TipoMovimientoId = 1;//Deposito a proveedor
                            cuentasMovimientoTransferecia.FechaMovimiento = pagoTransferencia.Fecha;
                            cuentasMovimientoTransferecia.EstadoMovimientoCuentaId = 0;
                            cuentasMovimientoTransferecia.TipoComprobanteId = TipoComprobanteEnum.SeñaProveedor;
                            cuentasMovimientoTransferecia.ComprobanteId = senia.Id;
                            cuentasMovimientoTransferecia.MonedaId = 0;
                            cuentasMovimientoTransferecia.NroMovimiento = pagoTransferencia.Numero;
                            cuentasMovimientoTransferecia.Descripcion = "TRANSFERENCIA SEÑA NRO " + pagoTransferencia.Numero.ToString();
                            cuentasMovimientoTransferecia.FechaCobro = _clock.Now;
                            cuentasMovimientoTransferecia.Debito = pago.Importe;
                            cuentasMovimientoTransferecia.Credito = 0;
                            cuentasMovimientoTransferecia.TipoCarga = 1;
                            cuentasMovimientoTransferecia.CajaId = caja.Id;
                            cuentasMovimientoTransferecia.FechaAlta = _clock.Now;
                            cuentasMovimientoTransferecia.OperadorAltaId = operadorId;
                            cuentasMovimientoTransferecia.SucursalAltaId = sucursalId;

                            uow.CuentasMovimientos.Agregar(cuentasMovimientoTransferecia);
                            break;
                    }
                }

                uow.Cajas.Modificar(caja);

                uow.ProveedoresSenias.Agregar(senia);

                uow.Commit();
            }
        }


        public void EditarTitulosConsignacionDetalle(IList<TituloConsignacionRendidasDetalleDto> titulosConsignacionRendidaDetalle)
        {
            if (!titulosConsignacionRendidaDetalle.Any())
            {
                return;
            }

            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                var tituloConsignacionRendidaId = titulosConsignacionRendidaDetalle.First().TituloConsignacionRendidaId;

                decimal nuevoImporte = 0;

                foreach (var tituloConsignacionRendidaDetalle in titulosConsignacionRendidaDetalle)
                {
                    var tituloConsignacionRendidaActual = uow.TitulosConsignacionesRendidasDetalle.Obtener(x => x.Id == tituloConsignacionRendidaDetalle.Id);
                    tituloConsignacionRendidaActual.PrecioCompra = tituloConsignacionRendidaDetalle.PrecioCompra;
                    uow.TitulosConsignacionesRendidasDetalle.Modificar(tituloConsignacionRendidaActual);

                    nuevoImporte += tituloConsignacionRendidaDetalle.PrecioCompra * tituloConsignacionRendidaDetalle.Cantidad;
                }

                var tituloConsignacionRendida =
                    uow.TitulosConsignacionesRendidas.Obtener(x => x.Id == tituloConsignacionRendidaId);

                tituloConsignacionRendida.Importe = nuevoImporte;

                uow.TitulosConsignacionesRendidas.Modificar(tituloConsignacionRendida);

                uow.Commit();
            }
        }
    }
}
