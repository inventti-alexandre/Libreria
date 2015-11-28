using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using Framework.Comun.Extentensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using LaPaz.Entidades;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Response;
using Framework.Comun.Utility;
using LaPaz.Negocio.Helpers;

namespace LaPaz.Negocio
{
    public class VentaNegocio : NegocioBase, IVentaNegocio
    {
        public const decimal ImporteIva = 0;

        private readonly IClock _clock;

        public VentaNegocio(ILaPazUow uow, IClock clock, IUowFactory factory)
        {
            Uow = uow;
            UowFactory = factory;
            _clock = clock;
        }

        public List<VentaDto> Listado(string sortBy, string sortDirection, string criteria,
                                      string letraComprobante, int? numeroComprobante, TipoComprobanteEnum? tipoComprobante,
                                      int pageIndex, int pageSize, out int pageTotal)
        {

            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            var denominacionFormateado = criteria.ToStringSearch();

            Expression<Func<Venta, bool>> where = x => ((string.IsNullOrEmpty(criteria) || SqlFunctions.PatIndex(denominacionFormateado, x.Cliente.Denominacion) > 0) || x.Cliente.Denominacion.Contains(denominacionFormateado)) &&
                                                       (!numeroComprobante.HasValue || x.NumeroComprobante.ToString().Contains(numeroComprobante.ToString()));

            var resultados = Uow.Ventas.Listado(criteros,
                                                    where,
                                                    x => x.EstadosVenta,
                                                    x => x.Cliente,
                                                    x => x.TiposComprobante,
                                                    x => x.CondicionesVenta);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<VentaDto>().ToList();
        }

        public CrearVentaResponse CrearVenta(CrearVentaData ventaData)
        {
            CrearVentaResponse reponse = new CrearVentaResponse();

            var venta = AgregarVenta(ventaData);

            foreach (var titulo in ventaData.Titulos)
            {
                //Descontar stock
                var tituloStock =
                    Uow.TitulosStock.Obtener(ts => ts.TituloId == titulo.TituloId && ts.SucursalId == ventaData.SucursalId);
                var cantidadAVender = titulo.Cantidad;
                int? cantpropia = 0;
                int? cantconsiganda = 0;

                if (tituloStock.StkPr > 0)
                {
                    if (tituloStock.StkPr >= cantidadAVender)
                    {
                        tituloStock.StkPr -= cantidadAVender;
                        cantpropia = cantidadAVender;
                        cantidadAVender = 0;
                    }
                    else
                    {
                        cantpropia = tituloStock.StkPr;
                        cantidadAVender -= tituloStock.StkPr;
                        tituloStock.StkPr = 0;
                    }
                }

                if (cantidadAVender > 0 && tituloStock.StkCn > 0)
                {

                    if (tituloStock.StkCn >= cantidadAVender && tituloStock.StkCn > 0)
                    {
                        tituloStock.StkCn -= cantidadAVender;
                        cantconsiganda = cantidadAVender;
                    }
                    else
                    {
                        throw new ApplicationException("No hay suficiente stock para completar la venta");
                    }
                }

                Uow.TitulosStock.Modificar(tituloStock);

                AgregarVentaDetalle(venta, ventaData.SucursalId, ventaData.OperadorId,
                                    titulo.TituloId, titulo.Cantidad, titulo.SubTotal,
                                    titulo.PrecioBase, titulo.Descuento, cantpropia, cantconsiganda);

                if (titulo.CantidadConsignada > 0 && cantconsiganda > 0)
                {
                    AgregarTitulosConsignacionVendida(ventaData, titulo.TituloId, titulo.ProveedorId, venta, cantconsiganda);

                    ActualizarTitulosConsignaciones(ventaData, titulo.TituloId, titulo.ProveedorId, cantconsiganda);
                }
            }

            var caja = ActualizarCajaActual(ventaData, venta);

            var cajaMovimiento = CrearCajaMovimiento(ventaData, caja, venta);

            reponse.FacturaInfo.Descripcion += "Seña  $" + cajaMovimiento.Senia + ". ";

            foreach (var pago in ventaData.Pagos)
            {
                switch (pago.TipoPago)
                {
                    case FormaPago.Efectivo:
                        cajaMovimiento.Efectivo = pago.Importe;
                        reponse.FacturaInfo.FormaPago += "Efectivo $" + pago.Importe + ". ";
                        break;
                    case FormaPago.Tarjeta:
                        ProcesarPagoTarjeta(ventaData, pago, cajaMovimiento);
                        reponse.FacturaInfo.FormaPago += "Tarjeta " + pago.Descripcion + " $" + pago.Importe + ". ";
                        break;
                    case FormaPago.Cheque:
                        ProcesarPagoCheque(ventaData, pago, cajaMovimiento);
                        reponse.FacturaInfo.FormaPago += "Cheque " + pago.Descripcion + " $" + pago.Importe + ". ";
                        break;
                    case FormaPago.Deposito:
                        ProcesarPagoDeposito(ventaData, pago, cajaMovimiento, venta, caja);
                        reponse.FacturaInfo.FormaPago += "Deposito " + pago.Descripcion + " $" + pago.Importe + ". ";
                        break;

                    case FormaPago.CuentaCorriente:
                        ProcesarPagoCuentaCorriente(ventaData, reponse, venta);
                        reponse.FacturaInfo.Descripcion = "Anticipo $" + ventaData.Anticipo + ". " + reponse.FacturaInfo.Descripcion;
                        break;
                }
            }

            Uow.CajaMovimientos.Agregar(cajaMovimiento);

            AgregarClienteMovimiento(ventaData, venta);

            if (!ventaData.EsVentaReservada)
                AumentarNumeroFactura(ventaData.OperadorId, ventaData.SucursalId);

            ActualizarSeniasCliente(ventaData, reponse);

            ActualizarCreditosAFavorCliente(ventaData, reponse);

            reponse.VentaId = venta.Id;

            Uow.Commit();

            return reponse;
        }

        public CrearVentaResponse CrearVentaRendicionConsignacionCliente(RendirConsignacionClienteData ventaData)
        {
            CrearVentaResponse reponse = new CrearVentaResponse();

            var existeVenta =
                    ventaData.RemitosVentaDetalle.Any(r => r.CntVendida.HasValue && r.CntVendida.Value != 0);

            var existeDevolucion =
                ventaData.RemitosVentaDetalle.Any(r => r.CntDevuelta.HasValue && r.CntDevuelta.Value != 0);

            if(!existeVenta && existeDevolucion)
            {
                foreach (var remitoVentaDetalleActualizado in ventaData.RemitosVentaDetalle)
                {
                    var remitoVentaDetalle =
                        Uow.RemitosVentasDetalle.Obtener(r => r.Id == remitoVentaDetalleActualizado.Id);

                    AumentarStockConCantidadDevuelta(ventaData, remitoVentaDetalleActualizado, remitoVentaDetalle);
                    //Actualizar remito venta.
                    remitoVentaDetalle.CntVendida = remitoVentaDetalle.CntVendida ?? 0;
                    remitoVentaDetalle.CntDevuelta = remitoVentaDetalle.CntDevuelta ?? 0;
                    remitoVentaDetalle.CntVendida += remitoVentaDetalleActualizado.CntVendida;
                    remitoVentaDetalle.CntDevuelta += remitoVentaDetalleActualizado.CntDevuelta;

                    Uow.RemitosVentasDetalle.Modificar(remitoVentaDetalle);

                    Uow.Commit();

                    //return reponse;
                }
                return reponse;
            }

            var venta = AgregarVenta(ventaData);

            foreach (var remitoVentaDetalleActualizado in ventaData.RemitosVentaDetalle)
            {
                var remitoVentaDetalle = Uow.RemitosVentasDetalle.Obtener(r => r.Id == remitoVentaDetalleActualizado.Id);

                var cantidadVendidaPropia =
                    remitoVentaDetalle.CalcularNuevaCantidadVendidaPropia(remitoVentaDetalleActualizado.CntVendida.GetValueOrDefault());

                var cantidadVendidaConsignacion =
                    remitoVentaDetalle.CalcularNuevaCantidadVendidaConsignacion(remitoVentaDetalleActualizado.CntVendida.GetValueOrDefault());

                
                AumentarStockConCantidadDevuelta(ventaData, remitoVentaDetalleActualizado, remitoVentaDetalle);
                //Actualizar remito venta.
                remitoVentaDetalle.CntVendida = remitoVentaDetalle.CntVendida ?? 0;
                remitoVentaDetalle.CntDevuelta = remitoVentaDetalle.CntDevuelta ?? 0;
                remitoVentaDetalle.CntVendida += remitoVentaDetalleActualizado.CntVendida;
                remitoVentaDetalle.CntDevuelta += remitoVentaDetalleActualizado.CntDevuelta;

                Uow.RemitosVentasDetalle.Modificar(remitoVentaDetalle);


                //var cantidadVendidaPropia =
                //    remitoVentaDetalle.CalcularNuevaCantidadVendidaPropia(remitoVentaDetalleActualizado.CntVendida.GetValueOrDefault());

                //var cantidadVendidaConsignacion =
                //    remitoVentaDetalle.CalcularNuevaCantidadVendidaConsignacion(remitoVentaDetalleActualizado.CntVendida.GetValueOrDefault());

                if (remitoVentaDetalleActualizado.CntVendida > 0)
                {
        
                    AgregarVentaDetalle(venta, ventaData.SucursalId, ventaData.OperadorId,
                        remitoVentaDetalleActualizado.TituloId, remitoVentaDetalleActualizado.Cantidad,
                        remitoVentaDetalleActualizado.SubTotal,
                        remitoVentaDetalleActualizado.PrecioBase, remitoVentaDetalleActualizado.Descuento,
                        cantidadVendidaPropia, cantidadVendidaConsignacion);
                
                    if (cantidadVendidaConsignacion > 0)
                    {
                        var titulo = Uow.Titulos.Obtener(t => t.Id == remitoVentaDetalleActualizado.TituloId);

                        if (titulo != null)
                        {
                            AgregarTitulosConsignacionVendida(ventaData, titulo.Id, titulo.ProveedorId, venta, cantidadVendidaConsignacion);

                            ActualizarTitulosConsignaciones(ventaData, titulo.Id, titulo.ProveedorId, cantidadVendidaConsignacion);
                        }
                    }
                }
            }

            var caja = ActualizarCajaActual(ventaData, venta);

            var cajaMovimiento = CrearCajaMovimiento(ventaData, caja, venta);

            reponse.FacturaInfo.Descripcion += "Seña  $" + cajaMovimiento.Senia + ". ";

            foreach (var pago in ventaData.Pagos)
            {
                switch (pago.TipoPago)
                {
                    case FormaPago.Efectivo:
                        cajaMovimiento.Efectivo = pago.Importe;
                        reponse.FacturaInfo.FormaPago += "Efectivo $" + pago.Importe + ". ";
                        break;
                    case FormaPago.Tarjeta:
                        ProcesarPagoTarjeta(ventaData, pago, cajaMovimiento);
                        reponse.FacturaInfo.FormaPago += "Tarjeta " + pago.Descripcion + " $" + pago.Importe + ". ";
                        break;
                    case FormaPago.Cheque:
                        ProcesarPagoCheque(ventaData, pago, cajaMovimiento);
                        reponse.FacturaInfo.FormaPago += "Cheque " + pago.Descripcion + " $" + pago.Importe + ". ";
                        break;
                    case FormaPago.Deposito:
                        ProcesarPagoDeposito(ventaData, pago, cajaMovimiento, venta, caja);
                        reponse.FacturaInfo.FormaPago += "Deposito " + pago.Descripcion + " $" + pago.Importe + ". ";
                        break;

                    case FormaPago.CuentaCorriente:
                        ProcesarPagoCuentaCorriente(ventaData, reponse, venta);
                        reponse.FacturaInfo.Descripcion = "Anticipo $" + ventaData.Anticipo + ". " + reponse.FacturaInfo.Descripcion;
                        break;
                }
            }

            Uow.CajaMovimientos.Agregar(cajaMovimiento);

            AgregarClienteMovimiento(ventaData, venta);

            if (!ventaData.EsVentaReservada)
                AumentarNumeroFactura(ventaData.OperadorId, ventaData.SucursalId);

            ActualizarSeniasCliente(ventaData, reponse);

            ActualizarCreditosAFavorCliente(ventaData, reponse);

            reponse.VentaId = venta.Id;

            Uow.Commit();

            return reponse;
        }

        private void AumentarStockConCantidadDevuelta(RendirConsignacionClienteData ventaData,
            RemitosVentaDetalleDto remitoVentaDetalleActualizado, RemitosVentaDetalle remitoVentaDetalle)
        {
            //Sumar al stock si se devolvio algun libro del titulo
            if (remitoVentaDetalleActualizado.CntDevuelta > 0)
            {
                var tituloStock =
                    Uow.TitulosStock.Obtener(
                        ts => ts.TituloId == remitoVentaDetalleActualizado.TituloId && ts.SucursalId == ventaData.SucursalId);

                int? cantconsiganda = 0;
                int? cantidadADevolver = remitoVentaDetalleActualizado.CntDevuelta;

                //Primero devuelvo los consignados
                if (remitoVentaDetalle.CntCn - (remitoVentaDetalle.CntDevuelta ?? 0) > 0)
                {
                    if ((remitoVentaDetalle.CntCn - (remitoVentaDetalle.CntDevuelta ?? 0)) >= remitoVentaDetalleActualizado.CntDevuelta)
                    {
                        tituloStock.StkCn += remitoVentaDetalleActualizado.CntDevuelta;
                        cantidadADevolver = 0;
                    }
                    else
                    {
                        tituloStock.StkCn += (remitoVentaDetalleActualizado.CntDevuelta ??0) - (remitoVentaDetalle.CntCn - remitoVentaDetalle.CntDevuelta);
                        cantidadADevolver -= (remitoVentaDetalle.CntCn - (remitoVentaDetalle.CntDevuelta ?? 0 ));
                    }
                }
                //Despues los propios
                if (remitoVentaDetalle.CntPr > 0 && cantidadADevolver > 0)
                {
                    if (remitoVentaDetalle.CntPr >= cantidadADevolver)
                    {
                        tituloStock.StkPr += cantidadADevolver;
                    }
                }

            }
        }

        public void ReservarFactura(ReservarFacturaData reservarFacturaData)
        {
            LoteFactura loteFactura =
               Uow.LotesFacturas.Obtener(
                   l => l.OperadorLote == reservarFacturaData.OperadorActualId && l.NroActual < l.NroHasta && l.Estado == EstadoLoteEnum.Activo && l.SucursalAltaId==reservarFacturaData.SucursalActualId);

            // Guardar Reservar Factura
            VentaReservada ventaReservada = new VentaReservada();
            ventaReservada.SucReserva = reservarFacturaData.SucursalActualId;
            ventaReservada.NroLote = loteFactura.NroLote;

            ventaReservada.LCN = LcnHelper.ObtenerLcn(this.SiguienteNumeroFactura(reservarFacturaData.OperadorActualId, reservarFacturaData.SucursalActualId), reservarFacturaData.PuntoVenta);
            ventaReservada.FechaAlta = _clock.Now;
            ventaReservada.SucursalAltaId = reservarFacturaData.SucursalActualId;
            ventaReservada.OperadorAltaId = reservarFacturaData.OperadorActualId;
            Uow.VentasReservadas.Agregar(ventaReservada);

            AumentarNumeroFactura(reservarFacturaData.OperadorActualId, reservarFacturaData.SucursalActualId);

            Uow.Commit();
        }
        
        public LoteFactura UltimoNroLote(Guid opertadorId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                return uow.LotesFacturas.Obtener(l => l.OperadorLote == opertadorId && l.NroActual < l.NroHasta && l.Estado == EstadoLoteEnum.Activo);
            }
        }

        public LoteFactura UltimoNroLote(Guid opertadorId, int sucursalId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                return uow.LotesFacturas.Obtener(l => l.OperadorLote == opertadorId && l.NroActual < l.NroHasta && l.Estado == EstadoLoteEnum.Activo && l.SucursalAltaId==sucursalId);
            }
        }
 
        public int SiguienteNumeroFactura(Guid opertadorId, int sucursalId)
        {

           // var usuario = Uow.
            var loteFactura = UltimoNroLote(opertadorId, sucursalId);// Uow.LotesFacturas.Obtener(l => l.OperadorLote == opertadorId && l.NroActual < l.NroHasta && l.Estado == EstadoLoteEnum.Activo);

            if (loteFactura == null)
            {
                throw new ApplicationException("No se ha encontrado el lote de factura para el operador actual");
            }

            var numeroFactura = (loteFactura.NroActual ?? 0) + 1;

            if (numeroFactura > loteFactura.NroHasta)
            {
                throw new ApplicationException("Ya se ha alcanzado el último número de factura dentro del lote");
            }

            return numeroFactura;
        }

        public int UltimoNumeroFactura(Guid opertadorId)
        {
            //var usuario = Uow.
            var loteFactura = Uow.LotesFacturas.Obtener(l => l.OperadorLote == opertadorId && l.NroActual < l.NroHasta && l.Estado == EstadoLoteEnum.Activo);

            if (loteFactura == null)
            {
                throw new ApplicationException("No se ha encontrado el lote de factura para el operador actual");
            }

            //var numeroFactura = (loteFactura.NroActual ?? 0) + 1;

            //if (numeroFactura > loteFactura.NroHasta)
            //{
            //    loteFactura.Estado = EstadoLoteEnum.Cerrado;
            //    Uow.LotesFacturas.Modificar(loteFactura);
            //    Uow.LotesFacturas.Commit();
            //    //throw new ApplicationException("Ya se ha alcanzado el último número de factura dentro del lote");
            //    return 0;

            //}

            return loteFactura.NroHasta;
        }

        public Guid IdCajaActual(Guid opertadorId)
        {
            //var usuario = Uow.
            var caja = Uow.Cajas.Obtener(c => c.OperadorId == opertadorId && c.FCierre == null);

            if (caja == null)
            {
                throw new ApplicationException("No se ha caja abierta para el operador actual");
            }

            return caja.Id;
        }

        public decimal SenaAFavorCliente(Guid clienteId, int sucursalId)
        {
            var clientesMontosFavor = Uow.ClientesMontosFavor.Listado()
                                       .Where(cm => cm.ClienteId == clienteId
                                                    && cm.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente
                                                    && !cm.FechaAnulacion.HasValue
                                           //&& !cm.VentaId.HasValue 
                                           && cm.SucursalAltaId == sucursalId
                                                    && cm.ImpOcupado < cm.Importe)
                                       .ToList();

            return clientesMontosFavor.Sum(cm => cm.Importe.GetValueOrDefault() - cm.ImpOcupado.GetValueOrDefault());
        }

        public decimal CreditosPorDevolucion(Guid clienteId, int sucursalId)
        {
            var clientesMontosFavor = Uow.ClientesMontosFavor.Listado()
                                       .Where(cm => cm.ClienteId == clienteId
                                                    && cm.TipoComprobanteId == TipoComprobanteEnum.NotaCrédito
                                                    && !cm.FechaAnulacion.HasValue
                                                    && cm.SucursalAltaId == sucursalId
                                                    && cm.ImpOcupado < cm.Importe)
                                       .ToList();

            return clientesMontosFavor.Sum(cm => cm.Importe.GetValueOrDefault() - cm.ImpOcupado.GetValueOrDefault());
        }

        private void ActualizarVentaReservada(VentaDataBase ventaData)
        {
            var lcn = LcnHelper.ObtenerLcn(ventaData.NumeroComprobante.GetValueOrDefault(), ventaData.PuntoVenta);

            //var ventaReservada = Uow.VentasReservadas.Obtener(v => v.LCN == lcn);
            var ventaReservada = Uow.VentasReservadas.Listado().OrderByDescending(v=>v.FechaAlta).FirstOrDefault(v => v.LCN == lcn);

            if (ventaReservada != null)
            {
                ventaReservada.FechaModificacion = _clock.Now;
                ventaReservada.OperadorModificacionId = ventaData.OperadorId;
                ventaReservada.SucursalModificacionId = ventaData.SucursalId;
                Uow.VentasReservadas.Modificar(ventaReservada);
            }
        }

        private void AumentarNumeroFactura(Guid operadorId, int sucursalId)
        {
            LoteFactura loteFactura =
                Uow.LotesFacturas.Obtener(
                    l => l.OperadorLote == operadorId && l.NroActual < l.NroHasta && l.Estado == EstadoLoteEnum.Activo && l.SucursalAltaId==sucursalId);

            var ultimo = this.SiguienteNumeroFactura(operadorId, sucursalId);
            if (ultimo == loteFactura.NroActual)
            {
                loteFactura.Estado = EstadoLoteEnum.Cerrado;
            }
            else
            {
                loteFactura.NroActual += 1;
            }

            loteFactura.FechaModificacion = _clock.Now;
            loteFactura.OperadorAltaId = operadorId;
            loteFactura.SucursalModificacionId = sucursalId;

            Uow.LotesFacturas.Modificar(loteFactura);
        }

        private Venta AgregarVenta(VentaDataBase ventaData)
        {
            var venta = new Venta();

            venta.Id = Guid.NewGuid();

            if (!ventaData.EsVentaReservada)
            {
                venta.NumeroComprobante = this.SiguienteNumeroFactura(ventaData.OperadorId, ventaData.SucursalId);
            }
            else
            {
                venta.NumeroComprobante = ventaData.NumeroComprobante.GetValueOrDefault();

                ActualizarVentaReservada(ventaData);
            }

            venta.LetraComprobante = LcnHelper.LetraConsumidorFinal;
            venta.LCN = LcnHelper.ObtenerLcn(venta.NumeroComprobante, ventaData.PuntoVenta);
            venta.ComprobanteId = ventaData.TipoComprobanteSeleccionado;
            venta.ClienteId = ventaData.ClienteId;

            venta.PuntoVenta = ventaData.PuntoVenta;
            venta.FechaComprobante = _clock.Now;
            venta.FechaVencimiento = _clock.Now;
            venta.CondicionVentaId = ventaData.CondicionVentaSeleccionada;

            venta.Concepto = ventaData.TipoComprobanteSeleccionado.ToString();
            venta.ImporteNeto = ventaData.TotalPagar.GetValueOrDefault();
            venta.ImporteIva = ImporteIva;

            venta.ImporteSena = ventaData.Senas + ventaData.CreditosDevolucion;
            venta.FechaUltimoPago = _clock.Now;
            venta.TotalPagado = ventaData.TotalPagar;
            venta.EstadoVentaId = EstadoVentaEnum.Entregada;

            venta.FechaAlta = _clock.Now;
            venta.SucursalAltaId = ventaData.SucursalId;
            venta.OperadorAltaId = ventaData.OperadorId;

            Uow.Ventas.Agregar(venta);

            return venta;
        }

        private void AgregarVentaDetalle(Venta venta, int sucursalId, Guid operadorId, Guid tituloId, int? cantidad, decimal? subTotal,
                                         decimal? precioBase, int? descuento, int? cantpropia, int? cantconsiganda)
        {
            VentaDetalle ventaDetalle = new VentaDetalle();

            ventaDetalle.Id = Guid.NewGuid();
            ventaDetalle.VentaId = venta.Id;
            ventaDetalle.TituloId = tituloId;
            ventaDetalle.CantidadPropia = cantpropia;
            ventaDetalle.CantidadConsig = cantconsiganda;
            ventaDetalle.Precio = subTotal;
            ventaDetalle.CantidadAuditada = cantidad;
            ventaDetalle.PrecioBase = precioBase;
            ventaDetalle.Descuento = descuento;
            ventaDetalle.FechaAlta = _clock.Now;
            ventaDetalle.SucursalAltaId = sucursalId;
            ventaDetalle.OperadorAltaId = operadorId;

            Uow.VentasDetalle.Agregar(ventaDetalle);
        }

        private void ActualizarCreditosAFavorCliente(VentaDataBase ventaData, CrearVentaResponse reponse)
        {
            //Actualizar creditos a favor del cliente
            var montoCredito = ventaData.CreditosDevolucion;
            var clientesCreditoFavor = Uow.ClientesMontosFavor.Listado()
                .Where(cm => cm.ClienteId == ventaData.ClienteId
                    && cm.SucursalAltaId == ventaData.SucursalId
                             && cm.TipoComprobanteId == TipoComprobanteEnum.NotaCrédito
                             && !cm.FechaAnulacion.HasValue
                             && cm.ImpOcupado < cm.Importe).OrderBy(cmf => cmf.FechaAlta)
                .ToList();
            foreach (ClienteMontoFavor clienteCreditoFavor in clientesCreditoFavor)
            {
                if (montoCredito != null)
                {
                    if (montoCredito > 0)
                    {
                        if ((clienteCreditoFavor.Importe - clienteCreditoFavor.ImpOcupado) >= montoCredito)
                        {
                            clienteCreditoFavor.ImpOcupado += montoCredito;
                            montoCredito = 0;
                        }
                        else
                        {
                            montoCredito -= (clienteCreditoFavor.Importe - clienteCreditoFavor.ImpOcupado);
                            clienteCreditoFavor.ImpOcupado = clienteCreditoFavor.Importe;
                        }

                        clienteCreditoFavor.FechaModificacion = _clock.Now;
                        clienteCreditoFavor.OperadorModificacionId = ventaData.OperadorId;
                        clienteCreditoFavor.SucursalAltaId = ventaData.SucursalId;

                        Uow.ClientesMontosFavor.Modificar(clienteCreditoFavor);

                        if (clienteCreditoFavor.Importe != clienteCreditoFavor.ImpOcupado)
                        {
                            reponse.Comprobantes.Add(new ComprobanteVenta()
                            {
                                Concepto = "Actualización de Nota de crédito",
                                LCN = clienteCreditoFavor.LCN,
                                Importe = clienteCreditoFavor.Importe,
                                ImpOcupado = clienteCreditoFavor.ImpOcupado
                            });
                        }
                    }
                }
            }
        }

        private void ActualizarSeniasCliente(VentaDataBase ventaData, CrearVentaResponse reponse)
        {
            //Actulizar señas de cliente
            var monto = ventaData.Senas;
            var clientesMontosFavor = Uow.ClientesMontosFavor.Listado().Where((cm => cm.ClienteId == ventaData.ClienteId
                                                                                     &&
                                                                                     cm.TipoComprobanteId ==
                                                                                     TipoComprobanteEnum.SeñaCliente
                                                                                     && cm.SucursalAltaId== ventaData.SucursalId
                                                                                     && !cm.FechaAnulacion.HasValue
                                                                                     && cm.ImpOcupado < cm.Importe))
                .OrderBy(cmf => cmf.FechaAlta)
                .ToList();


            foreach (ClienteMontoFavor clienteMontoFavor in clientesMontosFavor)
            {
                if (monto != null)
                {
                    if (monto > 0)
                    {
                        if ((clienteMontoFavor.Importe - clienteMontoFavor.ImpOcupado) >= monto)
                        {
                            clienteMontoFavor.ImpOcupado += monto;
                            monto = 0;
                        }
                        else
                        {
                            monto -= (clienteMontoFavor.Importe - clienteMontoFavor.ImpOcupado);
                            clienteMontoFavor.ImpOcupado = clienteMontoFavor.Importe;
                        }

                        clienteMontoFavor.FechaModificacion = _clock.Now;
                        clienteMontoFavor.OperadorModificacionId = ventaData.OperadorId;
                        clienteMontoFavor.SucursalAltaId = ventaData.SucursalId;

                        Uow.ClientesMontosFavor.Modificar(clienteMontoFavor);

                        if (clienteMontoFavor.Importe != clienteMontoFavor.ImpOcupado)
                        {
                            reponse.Comprobantes.Add(new ComprobanteVenta()
                            {
                                Concepto = "Actualización de seña",
                                LCN = clienteMontoFavor.LCN,
                                Importe = clienteMontoFavor.Importe,
                                ImpOcupado = clienteMontoFavor.ImpOcupado
                            });
                        }
                    }
                }
            }
        }

        private void AgregarClienteMovimiento(VentaDataBase ventaData, Venta venta)
        {
            //ClienteMovimiento
            ClientesMovimiento clientesMovimiento = new ClientesMovimiento();

            clientesMovimiento.IdCliente = ventaData.ClienteId;
            clientesMovimiento.IdTipoComprobante = (int?)ventaData.TipoComprobanteSeleccionado;
            clientesMovimiento.IdComprobante = venta.Id;
            clientesMovimiento.Concepto = ventaData.TipoComprobanteSeleccionado.ToString();
            clientesMovimiento.Haber = ventaData.TotalPagar;
            clientesMovimiento.FechaGeneracion = _clock.Now;
            clientesMovimiento.FechaAlta = _clock.Now;
            clientesMovimiento.SucursalAltaId = ventaData.SucursalId;
            clientesMovimiento.OperadorAltaId = ventaData.OperadorId;

            Uow.ClientesMovimientos.Agregar(clientesMovimiento);
        }

        private void ProcesarPagoCuentaCorriente(VentaDataBase ventaData, CrearVentaResponse reponse, Venta venta)
        {
            var cuotas = ventaData.Cuotas;
            reponse.FacturaInfo.Descripcion += "Cuotas: " + cuotas + " de: $" + ventaData.Montocuota.ToString();
            for (int i = 1; i <= cuotas; i++)
            {
                ClienteCuentaCorriente clienteCuentaCorriente = new ClienteCuentaCorriente();
                clienteCuentaCorriente.Id = Guid.NewGuid();
                clienteCuentaCorriente.VentaId = venta.Id;
                clienteCuentaCorriente.ClienteId = ventaData.ClienteId;
                clienteCuentaCorriente.Cuota = (byte)i;
                clienteCuentaCorriente.Fecha = _clock.Now;
                DateTime venc = ventaData.VencimientoCuota;
                clienteCuentaCorriente.FechaVencimiento = venc.AddMonths(i - 1);
                clienteCuentaCorriente.Importe = ventaData.Montocuota;
                clienteCuentaCorriente.Pagado = 0;
                clienteCuentaCorriente.FechaGeneracion = _clock.Now;
                clienteCuentaCorriente.FechaAlta = _clock.Now;
                clienteCuentaCorriente.SucursalAltaId = ventaData.SucursalId;
                clienteCuentaCorriente.OperadorAltaId = ventaData.OperadorId;
                Uow.ClientesCuentasCorrientes.Agregar(clienteCuentaCorriente);
            }
        }

        private void ProcesarPagoDeposito(VentaDataBase ventaData, VentaPago pago, CajaMovimiento cajaMovimiento, Venta venta, Caja caja)
        {
            var pagoDeposito = pago as VentaPagoDeposito;
            if (cajaMovimiento.Deposito == null)
                cajaMovimiento.Deposito = 0;

            //Guardar Cuentas Movimientos
            cajaMovimiento.Deposito += pago.Importe;

            CuentasMovimiento cuentasMovimiento = new CuentasMovimiento();
            cuentasMovimiento.CuentaId = pagoDeposito.CuentaId ?? 0;
            cuentasMovimiento.TipoMovimientoId = 2; //Deposito
            cuentasMovimiento.FechaMovimiento = pagoDeposito.Fecha;
            cuentasMovimiento.EstadoMovimientoCuentaId = 0;
            cuentasMovimiento.TipoComprobanteId = ventaData.TipoComprobanteSeleccionado;
            cuentasMovimiento.ComprobanteId = venta.Id;
            cuentasMovimiento.MonedaId = 0;
            cuentasMovimiento.CondicionVentaId = ventaData.CondicionVentaSeleccionada;
            cuentasMovimiento.NroMovimiento = pagoDeposito.Numero;
            cuentasMovimiento.Descripcion = "DEPOSITO NRO " + pagoDeposito.Numero.ToString();
            cuentasMovimiento.FechaCobro = _clock.Now;
            cuentasMovimiento.Debito = 0;
            cuentasMovimiento.Credito = pago.Importe;
            cuentasMovimiento.TipoCarga = 2;
            cuentasMovimiento.CajaId = caja.Id;
            cuentasMovimiento.FechaAlta = _clock.Now;
            cuentasMovimiento.OperadorAltaId = ventaData.OperadorId;
            cuentasMovimiento.SucursalAltaId = ventaData.SucursalId;

            Uow.CuentasMovimientos.Agregar(cuentasMovimiento);
        }

        private void ProcesarPagoCheque(VentaDataBase ventaData, VentaPago pago, CajaMovimiento cajaMovimiento)
        {
            var pagoCheque = pago as VentaPagoCheque;

            if (cajaMovimiento.Cheque == null)
                cajaMovimiento.Cheque = 0;

            cajaMovimiento.Cheque += pago.Importe;

            ChequesTercero chequesTercero = new ChequesTercero();
            chequesTercero.Id = Guid.NewGuid();
            chequesTercero.CajaMovimientoId = cajaMovimiento.Id;
            chequesTercero.BancoId = pagoCheque.BancoId ?? 0;
            chequesTercero.NroCheque = pagoCheque.Numero;
            chequesTercero.Fecha = _clock.Now;
            chequesTercero.FechaCobro = _clock.Now;
            chequesTercero.Importe = (float)pago.Importe;
            chequesTercero.FechaAlta = _clock.Now;
            chequesTercero.EstadoChequeId = 0;
            chequesTercero.SucursalAltaId = ventaData.SucursalId;
            chequesTercero.OperadorAltaId = ventaData.OperadorId;

            Uow.ChequesTerceros.Agregar(chequesTercero);
        }

        private void ProcesarPagoTarjeta(VentaDataBase ventaData, VentaPago pago, CajaMovimiento cajaMovimiento)
        {
            var pagoTarjeta = pago as VentaPagoTarjeta;
            if (cajaMovimiento.Tarjeta == null)
                cajaMovimiento.Tarjeta = 0;

            cajaMovimiento.Tarjeta += pago.Importe;
            //GUARDAR TARJETA MOVIMIENTO 
            TarjetasMovimiento tarjetasMovimiento = new TarjetasMovimiento();
            tarjetasMovimiento.CajaMovimientoId = cajaMovimiento.Id;
            tarjetasMovimiento.TarjetaId = pagoTarjeta.TarjetaId ?? 0;
            tarjetasMovimiento.LoteCupon = pagoTarjeta.CuponNumero;
            tarjetasMovimiento.Fecha = _clock.Now;
            tarjetasMovimiento.Importe = (float)pago.Importe;
            tarjetasMovimiento.Estado = 1; // No se 
            tarjetasMovimiento.FechaAlta = _clock.Now;
            tarjetasMovimiento.SucursalAltaId = ventaData.SucursalId;
            tarjetasMovimiento.OperadorAltaId = ventaData.OperadorId;

            Uow.TarjetasMovimientos.Agregar(tarjetasMovimiento);
        }

        private CajaMovimiento CrearCajaMovimiento(VentaDataBase ventaData, Caja caja, Venta venta)
        {
            CajaMovimiento cajaMovimiento = new CajaMovimiento();
            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = caja.Id;
            cajaMovimiento.TipoMovimientoCajaId = ventaData.TipoCajaMovimientoSeleccionado;
            cajaMovimiento.TipoComprobante = ventaData.TipoComprobanteSeleccionado;
            cajaMovimiento.ComprobanteId = venta.Id;
            cajaMovimiento.Senia = ventaData.Senas + ventaData.CreditosDevolucion;
            if (ventaData.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
                cajaMovimiento.Importe = ventaData.Anticipo;
            else
                cajaMovimiento.Importe = ventaData.TotalPagar;

            cajaMovimiento.ImpFac = ventaData.SubTotal;
            
            //if (ventaData.CondicionVentaSeleccionada == CondicionVentaEnum.CuentaCorriente)
            //    cajaMovimiento.ImpFac = ventaData.SubTotal;
            //else
            //    cajaMovimiento.ImpFac = ventaData.TotalPagar;


            cajaMovimiento.PcAlta = ventaData.PcAlta;
            cajaMovimiento.SucursalAltaId = ventaData.SucursalId;
            cajaMovimiento.OperadorAltaId = ventaData.OperadorId;
            cajaMovimiento.FechaAlta = _clock.Now;

            return cajaMovimiento;
        }

        private Caja ActualizarCajaActual(VentaDataBase ventaData, Venta venta)
        {
            Caja caja = Uow.Cajas.Obtener(c => c.Id == ventaData.CajaActualId);

            if (caja.Ingresos == null)
                caja.Ingresos = 0;
            caja.Ingresos += (float?)venta.TotalPagado;
            if (caja.Saldo == null)
                caja.Saldo = 0;
            caja.Saldo += (float?)venta.TotalPagado;
            caja.FechaModificacion = _clock.Now;
            caja.SucursalModificacionId = ventaData.SucursalId;
            caja.OperadorModificacionId = ventaData.OperadorId;

            Uow.Cajas.Modificar(caja);
            return caja;
        }

        private void ActualizarTitulosConsignaciones(VentaDataBase ventaData, Guid tituloId, Guid? proveedorId, int? cantconsiganda)
        {
            //Busco las consignaciones de titulos y actualizo la columna CnVn
            var titulosConsignaciones =
                Uow.TitulosConsignaciones.Listado().Where(
                    tc => tc.TituloId == tituloId && tc.ProveedorId == proveedorId && (tc.CntVn + tc.CntDev) < tc.CntCn).
                    OrderBy(tc => tc.FechaAlta);

            foreach (TitulosConsignacion tituloConsignacion in titulosConsignaciones)
            {
                if (cantconsiganda > 0)
                {
                    if (tituloConsignacion.CntCn - tituloConsignacion.CntVn - tituloConsignacion.CntDev >= cantconsiganda)
                    {
                        tituloConsignacion.CntVn += cantconsiganda ?? 0;
                        cantconsiganda = 0;
                    }
                    else
                    {
                        var disponible = tituloConsignacion.CntCn - tituloConsignacion.CntVn - tituloConsignacion.CntDev;
                        cantconsiganda -= disponible;
                        tituloConsignacion.CntVn = tituloConsignacion.CntCn;
                    }

                    tituloConsignacion.FechaModificacion = _clock.Now;
                    tituloConsignacion.OperadorModificacionId = ventaData.OperadorId;
                    tituloConsignacion.SucursalModificacionId = ventaData.SucursalId;

                    Uow.TitulosConsignaciones.Modificar(tituloConsignacion);
                }
            }
        }

        private void AgregarTitulosConsignacionVendida(VentaDataBase ventaData, Guid tituloId, Guid? proveedorId, Venta venta, int? cantconsiganda)
        {
            TitulosConsignacionesVendida titulosConsignacionesVendida = new TitulosConsignacionesVendida();

            titulosConsignacionesVendida.Id = Guid.NewGuid();
            titulosConsignacionesVendida.nTipo = 1;
            titulosConsignacionesVendida.ClienteId = Guid.Empty;
            titulosConsignacionesVendida.ProveedorId = proveedorId;
            titulosConsignacionesVendida.TituloId = tituloId;
            titulosConsignacionesVendida.ComprobanteId = venta.Id;
            titulosConsignacionesVendida.Fecha = _clock.Now;
            titulosConsignacionesVendida.CntCn = cantconsiganda; // titulo.CantidadConsignada;
            titulosConsignacionesVendida.CntPag = 0;
            titulosConsignacionesVendida.FechaAlta = _clock.Now;
            titulosConsignacionesVendida.OperadorAltaId = ventaData.OperadorId;
            titulosConsignacionesVendida.SucursalAltaId = ventaData.SucursalId;

            Uow.TitulosConsignacionesVendidas.Agregar(titulosConsignacionesVendida);
        }

       }
}
