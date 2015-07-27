using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using LaPaz.Win.Reportes;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Compras
{
    public partial class FrmCrearSeñaProveedor : FormBase
    {
        #region InitializeComponents
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Proveedor _proveedor;
        private readonly ICompraNegocio _compranegocio;
        //private int _tipoConsignacion = 1; //Consignacion proveedor

        public FrmCrearSeñaProveedor(IClock clock,
                                IFormFactory formFactory,
                                IMessageBoxDisplayService messageBoxDisplayService,
                                ILaPazUow uow)
        {
            FormFactory = formFactory;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            Uow = uow;

            InitializeComponent();

        }
        #endregion

        #region Properties
        #endregion

        #region Metodos
        private void FrmCrearSeñaProveedor_Load(object sender, EventArgs e)
        {
            this.UcBuscadorProveedor.SeleccionarFinished += ucBuscadorProveedorOnSeleccionarFinished;
            this.UcTotalesSeña.TotalAPagarChanged += ucTotalesSeñaOnTotalAPagarChanged;
            DeshabilitarControles();
        }

        void ucTotalesSeñaOnTotalAPagarChanged(object sender, decimal? total)
        {
            if (UcTotalesSeña.TotalPagar > 0)
                BtnGuardar.Enabled = true;
            else
                BtnGuardar.Enabled = false;
        }

        private void DeshabilitarControles()
        {
            UcTotalesSeña.Enabled = false;
            BtnGuardar.Enabled = false;
            ChkCajaAnterior.Enabled = false;
        }

        private void HabilitarControles()
        {
            UcTotalesSeña.Enabled = true;
            ChkCajaAnterior.Enabled = true;
        }

        private void ucBuscadorProveedorOnSeleccionarFinished(object sender, Proveedor proveedor)
        {
            if (proveedor != null)
            {
                if (proveedor.Id != Guid.Empty)
                {
                    HabilitarControles();
                    _proveedor = proveedor;

                    UcProveedorDetalle.ActualizarProveedor(proveedor);

                    RefrescarHistorial();
                }
            }
        }

        private void RefrescarHistorial()
        {
            var señas = Uow.ProveedoresSenias.Listado()
                                             .Where(ps => ps.ProveedorId == _proveedor.Id)
                                             .OrderByDescending(c => c.FechaAlta);

            GridSeñas.DataSource = señas.ToList();

            GridSeñas.Refresh();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            RealizarSenia();

            ReiniciarForm();
        }

        private void ReiniciarForm()
        {
            LimpiarPagos();

            RefrescarHistorial();

            ChkCajaAnterior.IsChecked = false;
        }

        private void LimpiarPagos()
        {
            UcTotalesSeña.Pagos.Clear();
            UcTotalesSeña.RefrescarPagos();
        }

        private void RealizarSenia()
        {
            try
            {
                Caja caja = this.Context.CajaActual;

                ProveedorSenia seña = new ProveedorSenia();

                seña.Id = Guid.NewGuid();
                seña.ProveedorId = _proveedor.Id;
                seña.FechaAlta = _clock.Now;
                seña.FechaModificacion = _clock.Now;
                seña.Importe = UcTotalesSeña.TotalPagar;
                seña.ImporteUsado = 0;
                seña.OperadorAltaId = Context.OperadorActual.Id;
                seña.SucursalAltaId = Context.SucursalActual.Id;
                seña.OperadorModificacionId = Context.OperadorActual.Id;
                seña.SucursalModificacionId = Context.SucursalActual.Id;

                decimal? efectivo = 0;
                decimal? tarjeta = 0;
                decimal? cheque = 0;
                decimal? deposito = 0;

                foreach (var pago in UcTotalesSeña.Pagos)
                {
                    switch (pago.TipoPago)
                    {
                        case FormaPago.Efectivo:
                            efectivo += pago.Importe;
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
                    }
                }

                if (efectivo > 0 && ChkCajaAnterior.Checked == false)
                {
                    //creo la caja movimiento para los pagos en efectivo que tocan la caja actual
                    CajaMovimiento cajaMovimiento = new CajaMovimiento();

                    cajaMovimiento.Id = Guid.NewGuid();
                    cajaMovimiento.CajaId = caja.Id;
                    cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaProveedor;
                    cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.SeñaProveedor;

                    cajaMovimiento.ComprobanteId = seña.Id;
                    cajaMovimiento.Importe = efectivo;
                    cajaMovimiento.FechaAlta = _clock.Now;
                    cajaMovimiento.FechaModificacion = _clock.Now;
                    cajaMovimiento.PcAlta = System.Environment.MachineName;
                    cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                    cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;
                    cajaMovimiento.OperadorModificacionId = Context.OperadorActual.Id;
                    cajaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;

                    //descontar de la caja
                    if (caja.Egresos == null)
                        caja.Egresos = 0;

                    if (ChkCajaAnterior.Checked == false)
                        caja.Egresos += (float?)efectivo;

                    if (caja.Saldo == null)
                        caja.Saldo = 0;

                    caja.Saldo -= (float?)efectivo;

                    caja.FechaModificacion = _clock.Now;
                    caja.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
                    caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

                    //traer la caja
                    if (cajaMovimiento.Efectivo == null)
                        cajaMovimiento.Efectivo = 0;

                    cajaMovimiento.Cheque = cheque;
                    cajaMovimiento.Tarjeta = tarjeta;
                    cajaMovimiento.Deposito = deposito;
                    cajaMovimiento.Efectivo = efectivo;
                    efectivo = 0;

                    Uow.CajaMovimientos.Agregar(cajaMovimiento);
                }

                if (tarjeta > 0 || deposito > 0 || cheque > 0 || efectivo > 0)
                {
                    //creo la caja movimiento para los pagos en efectivo que tocan la caja actual
                    CajaMovimiento cajaMovimientoAnterior = new CajaMovimiento();

                    cajaMovimientoAnterior.Id = Guid.NewGuid();
                    cajaMovimientoAnterior.CajaId = caja.Id;
                    cajaMovimientoAnterior.TipoComprobante = TipoComprobanteEnum.SeñaProveedor;
                    cajaMovimientoAnterior.TipoMovimientoCajaId = TipoMovimientoCajaEnum.SeñaProveedorCajaAnterior;
                    cajaMovimientoAnterior.ComprobanteId = seña.Id;
                    cajaMovimientoAnterior.Importe = tarjeta + deposito + cheque + efectivo;
                    cajaMovimientoAnterior.FechaAlta = _clock.Now;
                    cajaMovimientoAnterior.FechaModificacion = _clock.Now;
                    cajaMovimientoAnterior.PcAlta = System.Environment.MachineName;
                    cajaMovimientoAnterior.OperadorAltaId = Context.OperadorActual.Id;
                    cajaMovimientoAnterior.SucursalAltaId = Context.SucursalActual.Id;
                    cajaMovimientoAnterior.OperadorModificacionId = Context.OperadorActual.Id;
                    cajaMovimientoAnterior.SucursalModificacionId = Context.SucursalActual.Id;

                    if (efectivo > 0)
                    {
                        if (cajaMovimientoAnterior.Efectivo == null)
                            cajaMovimientoAnterior.Efectivo = 0;

                        cajaMovimientoAnterior.Efectivo += efectivo;

                        cajaMovimientoAnterior.Cheque += cheque;
                        cajaMovimientoAnterior.Tarjeta += tarjeta;
                        cajaMovimientoAnterior.Deposito += deposito;

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

                    Uow.CajaMovimientos.Agregar(cajaMovimientoAnterior);
                }


                Uow.Cajas.Modificar(caja);

                Uow.ProveedoresSenias.Agregar(seña);

                Uow.Commit();

                _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessSeniaExitosa);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            CloseTab();
        }
        #endregion
    }
}
