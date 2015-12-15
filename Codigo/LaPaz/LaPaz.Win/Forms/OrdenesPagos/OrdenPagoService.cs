using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Extensiones;
using LaPaz.Win.Model;
using LaPaz.Datos.Interfaces;
using LaPaz.Seguridad;
using Framework.Comun.Utility;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Win.Forms.OrdenesPagos
{
    public interface IOrdenPagoService
    {
        void EliminarOrdenPago(Guid id);
        void AgregarCuentaMovimiento(OrdenesPago ordenPago, DetalleFormaPago pago);
        void AgregarMovimientos(OrdenesPago ordenPago, OrdenesPagoDetalle pago, DetalleFormaPago vPago);
        DetalleFormaPago ObtenerFormaPago(OrdenesPago ordenPago, OrdenesPagoDetalle ordenesPagoDetalle);
    }

    public class OrdenPagoService : IOrdenPagoService
    {
        private ILaPazUow _uow;
        private ILaPazContext _context;
        private IClock _clock;
        private ICajaNegocio _cajaNegocio;
        private Caja _cajaActual;

        public OrdenPagoService(ILaPazUow uow, ILaPazContext context, IClock clock, ICajaNegocio cajaNegocio)
        {
            _uow = uow;
            _context = context;
            _clock = clock;
            _cajaNegocio = cajaNegocio;
        }

        public void EliminarOrdenPago(Guid id)
        {
            _cajaActual = this._context.CajaActual;

            var ordenPago = _uow.OrdenesPagos.Obtener(op => op.Id == id, op => op.OrdenesPagoDetalles);
            foreach (var detalle in ordenPago.OrdenesPagoDetalles)
            {
                EliminarDetalle(ordenPago, detalle);
            }

            ordenPago.FechaAnulacion = _clock.Now;

            _uow.OrdenesPagos.Modificar(ordenPago);
            _uow.Commit();
        }

        private void EliminarDetalle(OrdenesPago ordenesPago, OrdenesPagoDetalle detalle)
        {


            detalle.InvertirImportes();
            detalle.FechaAnulacion = _clock.Now;

            var pago = ObtenerFormaPago(ordenesPago, detalle);

            pago.IsDeleted = true;

            AgregarMovimientos(ordenesPago, detalle, pago);

            if (pago.TipoPago == FormaPago.Transferencia || pago.TipoPago == FormaPago.Deposito)
            {
                pago.Importe = -pago.Importe;
                AgregarCuentaMovimiento(ordenesPago, pago);
            }

            _uow.OrdenesPagosDetalle.Modificar(detalle);
        }

        public void AgregarCuentaMovimiento(OrdenesPago ordenPago, DetalleFormaPago pago)
        {
            var movimiento = new CuentasMovimiento();
            movimiento.ComprobanteId = ordenPago.Id;

            switch (pago.TipoPago)
            {
                case FormaPago.Transferencia:
                    var pagoTrans = pago as PagoTransferencia;
                    movimiento.Debito = pagoTrans.Importe;
                    movimiento.NroMovimiento = pagoTrans.Numero;
                    movimiento.CuentaId = (int)pagoTrans.CuentaId;
                    movimiento.FechaMovimiento = _clock.Now;
                    movimiento.Descripcion = pagoTrans.Descripcion;
                    movimiento.TipoComprobanteId = TipoComprobanteEnum.OrdenPago;
                    movimiento.TipoMovimientoId = (int)TipoMovimientoBancarioEnum.TransferenciaBancariaAProveedores;
                    break;
                case FormaPago.Deposito:
                    var pagoDeposito = pago as PagoDeposito;
                    movimiento.Debito = pagoDeposito.Importe;
                    movimiento.NroMovimiento = pagoDeposito.Numero;
                    movimiento.CuentaId = (int)pagoDeposito.DepositoCuentaId;
                    movimiento.FechaMovimiento = _clock.Now;
                    movimiento.Descripcion = pagoDeposito.Descripcion;
                    movimiento.TipoComprobanteId = TipoComprobanteEnum.OrdenPago;
                    movimiento.TipoMovimientoId = (int)TipoMovimientoBancarioEnum.DepositoEfectivo;
                    break;
            }

            Caja caja = _cajaActual;

            movimiento.FechaAlta = _clock.Now;
            movimiento.SucursalAltaId = _context.SucursalActual.Id;
            movimiento.OperadorAltaId = _context.OperadorActual.Id;

            _uow.CuentasMovimientos.Agregar(movimiento);
        }

        public void AgregarMovimientos(OrdenesPago ordenPago, OrdenesPagoDetalle pago, DetalleFormaPago vPago)
        {
            var movimiento = new CajaMovimiento();
            var movimientoAnterior = new CajaMovimiento();
            if (vPago.IsDeleted)
                movimientoAnterior = _uow.CajaMovimientos.Obtener(c => c.ComprobanteId == ordenPago.Id);

            movimiento.Id = Guid.NewGuid();
            movimiento.Importe = pago.ImportePagado;
            movimiento.ComprobanteId = ordenPago.Id;
            movimiento.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            movimiento.TipoMovimientoCajaId = vPago.IsDeleted ? movimientoAnterior.TipoMovimientoCajaId : TipoMovimientoCajaEnum.PagoGastos;
            //movimiento.TipoMovimientoCajaId = vPago.IsDeleted ? TipoMovimientoCajaEnum.AnulaciónOrdenPago : TipoMovimientoCajaEnum.PagoGastos;
            movimiento.PcAlta = Environment.MachineName;
            movimiento.CajaId = _cajaActual.Id;

            if (pago.Efectivo.HasValue && pago.Efectivo != 0)
            {
                //Si ImportePagado <> 0 => Pago Normal en Efectivo
                //Si ImportePagado = 0 => Pago Programado
                if (pago.ImportePagado.HasValue && pago.ImportePagado != 0)
                {
                    var pagoEfec = vPago as PagoEfectivo;

                    if (pagoEfec.CajaAnterior)
                    {
                        ActualizarCajaAnterior(ordenPago, pagoEfec, _cajaActual, movimiento);
                    }
                    else
                    {
                        ActualizarCajaActual(pago, movimiento, _cajaActual);
                    }

               }

                movimiento.Efectivo = pago.Efectivo;
            }

            if (pago.Cheques.HasValue && (pago.Cheques > 0 || pago.Cheques < 0))
            {
                movimiento.Cheque = pago.Cheques;
            }

            if (pago.DepositoEfectivo.HasValue && (pago.DepositoEfectivo > 0 || pago.DepositoEfectivo < 0))
            {
                movimiento.Deposito = pago.DepositoEfectivo;
            }

            if (pago.Transferencia.HasValue && (pago.Transferencia > 0 || pago.Transferencia < 0))
            {
                movimiento.Transferencia = pago.Transferencia;
            }

         //   movimiento.FechaAlta = pago.Id == default(Guid) ? _clock.Now : pago.FechaAlta;

            movimiento.FechaAlta = DateTime.Now;// pago.Id == default(Guid) ? _clock.Now : pago.FechaAlta;


            movimiento.SucursalAltaId = _context.SucursalActual.Id;
            movimiento.OperadorAltaId = _context.OperadorActual.Id;

            _uow.CajaMovimientos.Agregar(movimiento);
        }

        private void ActualizarCajaActual(OrdenesPagoDetalle pago, CajaMovimiento movimiento, Caja caja)
        {
            movimiento.Efectivo = pago.Efectivo;
            caja.Egresos += (float)(pago.Efectivo ?? 0);
            caja.Saldo -= (float)(pago.Efectivo ?? 0);
            caja.FechaModificacion = pago.Id == default(Guid) ? (DateTime?)null : _clock.Now;
            caja.SucursalModificacionId = pago.Id == default(Guid)
                                              ? (int?)null
                                              : _context.SucursalActual.Id;
            caja.OperadorModificacionId = pago.Id == default(Guid)
                                              ? (Guid?)null
                                              : _context.OperadorActual.Id;
            _uow.Cajas.Modificar(caja);
        }

        public DetalleFormaPago ObtenerFormaPago(OrdenesPago ordenPago, OrdenesPagoDetalle ordenesPagoDetalle)
        {
            DetalleFormaPago pago = new DetalleFormaPago();

            pago.PuedeEliminar = ordenesPagoDetalle.PuedeEliminar();

            if (ordenesPagoDetalle.Efectivo.HasValue && ordenesPagoDetalle.Efectivo != 0)
            {
                var pagoEfectivo = new PagoEfectivo();
                pagoEfectivo.Id = ordenesPagoDetalle.Id;
                pagoEfectivo.Importe = ordenesPagoDetalle.Efectivo;
                pagoEfectivo.TipoPago = FormaPago.Efectivo;
                pagoEfectivo.Descripcion = ordenesPagoDetalle.Descripcion;
                pagoEfectivo.Fecha = ordenesPagoDetalle.FechaPago;
                pago = pagoEfectivo;
            }

            if (ordenesPagoDetalle.Cheques.HasValue && ordenesPagoDetalle.Cheques != 0)
            {
                var pagoCheque = new PagoCheque();
                pagoCheque.Id = ordenesPagoDetalle.Id;
                pagoCheque.Importe = ordenesPagoDetalle.Cheques;
                pagoCheque.TipoPago = FormaPago.Cheque;
                pagoCheque.Descripcion = ordenesPagoDetalle.Descripcion;
                pagoCheque.Fecha = ordenesPagoDetalle.FechaPago;
                pago = pagoCheque;
            }

            if (ordenesPagoDetalle.DepositoEfectivo.HasValue && ordenesPagoDetalle.DepositoEfectivo != 0)
            {
                var pagoDeposito = new PagoDeposito();
                var cuentaMov =
                    _uow.CuentasMovimientos.Obtener(
                        c =>
                        c.ComprobanteId == ordenPago.Id && c.Descripcion.Contains(ordenesPagoDetalle.Descripcion));
                pagoDeposito.Id = ordenesPagoDetalle.Id;
                pagoDeposito.DepositoCuentaId = cuentaMov.CuentaId;
                pagoDeposito.Importe = ordenesPagoDetalle.DepositoEfectivo;
                pagoDeposito.TipoPago = FormaPago.Deposito;
                pagoDeposito.Descripcion = ordenesPagoDetalle.Descripcion;
                pagoDeposito.Fecha = ordenesPagoDetalle.FechaPago;
                pago = pagoDeposito;
            }

            if (ordenesPagoDetalle.Transferencia.HasValue && ordenesPagoDetalle.Transferencia != 0)
            {
                var pagoTransferencia = new PagoTransferencia();
                var cuentaMov =
                    _uow.CuentasMovimientos.Obtener(
                        c =>
                        c.ComprobanteId == ordenPago.Id && c.Descripcion.Contains(ordenesPagoDetalle.Descripcion));
                pagoTransferencia.Id = ordenesPagoDetalle.Id;
                pagoTransferencia.CuentaId = cuentaMov.CuentaId;
                pagoTransferencia.Importe = ordenesPagoDetalle.Transferencia;
                pagoTransferencia.TipoPago = FormaPago.Transferencia;
                pagoTransferencia.Descripcion = ordenesPagoDetalle.Descripcion;
                pagoTransferencia.Fecha = ordenesPagoDetalle.FechaPago;
                pago = pagoTransferencia;
            }

            return pago;
        }

        private void ActualizarCajaAnterior(OrdenesPago ordenPago, PagoEfectivo pagoEfec, Caja caja, CajaMovimiento cajaMovimientoAnterior)
        {
            cajaMovimientoAnterior.CajaId = caja.Id;
            cajaMovimientoAnterior.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            cajaMovimientoAnterior.TipoMovimientoCajaId = TipoMovimientoCajaEnum.DepositoConCajaAnterior;
            cajaMovimientoAnterior.ComprobanteId = ordenPago.Id;
            cajaMovimientoAnterior.Importe = pagoEfec.Importe;

            if (cajaMovimientoAnterior.Efectivo == null)
                cajaMovimientoAnterior.Efectivo = 0;

            cajaMovimientoAnterior.Efectivo = pagoEfec.Importe;

            if (caja.Saldo == null)
                caja.Saldo = 0;

            //Pago Efectivo para Caja Anterior solo se Modifica el Saldo Acumulado
            caja.Saldo -= (float?)pagoEfec.Importe;

            _uow.Cajas.Modificar(caja);
        }
    }
}
