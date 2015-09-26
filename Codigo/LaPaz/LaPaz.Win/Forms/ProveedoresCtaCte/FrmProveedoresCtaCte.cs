using System.Data.Entity;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Win.Enums;
using Telerik.WinControls.UI;
using LaPaz.Win.Model;
using LaPaz.Entidades;
using System.Linq;
using System.Drawing;
using LaPaz.Entidades.Dto;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Data;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.ProveedoresCtaCte
{
    public partial class FrmProveedoresCtaCte : LaPaz.Win.Forms.FormBaseListado
    {


        #region Initialize Components

        private readonly IProveedorNegocio _proveedorNegocio;
        private readonly IClock _clock;
        private readonly MessageBoxDisplayService _messageBoxDisplayService;
        private Guid _pagoIdCtaCte;
        private Guid _pagoIdConsignacion;
        private int _celdasSeleccionadas = 0;


        public event EventHandler ProveedoresCuentaCorriente;

        public FrmProveedoresCtaCte(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio, IClock clock, MessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;

            Uow = uow;
            _clock = clock;
            SortColumn = "FechaAlta";
            SortDirection = "DESC";

            _proveedorNegocio = proveedorNegocio;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridCtaCte.CellFormatting += this.Grilla_CellFormatting;

            MainGrid = GridCtaCte;
            MainPager = ProveedoreCtaCtePager;
            Spinner = ucProgressSpinner1;
        }

        private void FrmProveedoresCtaCte_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            this.ucFiltroProveedor1.SeleccionarFinished += Filtered;
            this.ucTotalesCompraSeña1.SeñaChanged += ucTotalesCompraSeña1_SeñaChanged;
            this.ucTotalesCompraSeña1.TotalAPagarChanged += ucTotalesCompraSeña1_TotalAPagarChanged;
            this.ucTotalesCompraSeña1.FaltaPagarChanged += UcTotalesCompraSeñaOnFaltaPagarChanged;

            this.GridCtaCte.Columns["TotalVenta"].FormatString = "{0:N2}";
            this.GridCtaCte.Columns["Importe"].FormatString = "{0:N2}";
            this.GridCtaCte.Columns["Pagado"].FormatString = "{0:N2}";
            this.GridCtaCte.Columns["Pago"].FormatString = "{0:N2}";

            this.GridCtaCte.Columns["Importe"].FormatString = "{0:N2}";
            this.GridCtaCte.Columns["Pagado"].FormatString = "{0:N2}";
            DtpFechaPago.Value = _clock.Now;
        }

        private void UcTotalesCompraSeñaOnFaltaPagarChanged(object sender, decimal? e)
        {
            if (ucTotalesCompraSeña1.FaltaPagar != 0)
            {
                ucTotalesCompraSeña1.EliminarPagoEfectivo();
                if (ucTotalesCompraSeña1.FaltaPagar > 0)
                {
                    ucTotalesCompraSeña1.GenerarPagoAnticipoNuevo(ucTotalesCompraSeña1.FaltaPagar, FormaPago.Efectivo);
                }

            }
        }

        private void InicializarPaginador()
        {
            ProveedoreCtaCtePager.RefreshActionAsync = RefrescarListado;
        }

        #endregion

        #region Properties


        public Guid Id
        {
            get { return ((ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem).Id; }
        }

        public string NumeroFactura
        {
            get { return ((ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem).CompraNumeroComprobante; }
        }

        public int Cuota
        {
            get { return ((ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem).Cuota; }
        }

        public decimal? Subtotal
        {
            get { return (ucTotalesCompraSeña1.SubTotal); }
            set { (ucTotalesCompraSeña1.SubTotal) = value; }
        }


        public decimal? Pagado
        {
            get
            {

                return ((ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem).Pagado;
            }
            set
            {
                ((ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem).Pagado = value;
            }
        }

        public decimal? Deuda
        {
            get
            {
                return Convert.ToDecimal(lblDeuda.Text);
            }
            set { lblDeuda.Text = value.ToString(); }
        }

        public decimal? DeudaVencida
        {
            get
            {
                return Convert.ToDecimal(lblDeudaVencida.Text);
            }
            set { lblDeudaVencida.Text = value.ToString(); }
        }

        public decimal? Consignacion
        {
            get { return Convert.ToDecimal(LblConsigna.Text); }
            set { LblConsigna.Text = value.ToString(); }
        }

        public decimal? ConsignacionVencida
        {
            get { return Convert.ToDecimal(LblConsignaVencida.Text); }
            set { LblConsignaVencida.Text = value.ToString(); }
        }


        #endregion

        #region Methods

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var codigoProveedor = ucFiltroProveedor1.ProveedorId;

            var page = ProveedoreCtaCtePager.CurrentPage;
            var pageSize = ProveedoreCtaCtePager.PageSize;

            var proveedoresCtaCte =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorCtaCte(SortColumn, SortDirection, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, Context.SucursalActual.Id, ProveedoreCtaCtePager.CurrentPage, ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            var proveedoresConsignacion =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorConsignacion(SortColumn, SortDirection, null, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, null, null, true, Context.SucursalActual.Id, ProveedoreCtaCtePager.CurrentPage,
                                ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            GridCtaCte.DataSource = proveedoresCtaCte;

            GridConsignaciones.DataSource = proveedoresConsignacion;



            ProveedoreCtaCtePager.UpdateState(pageTotal);
            CalcularDeuda(proveedoresCtaCte);
            CalcularConsigna(proveedoresConsignacion);
            PintarCuotasVencidas();

            return pageTotal;
        }

        private void CalcularDeuda(List<ProveedorCtaCteDto> proveedoresCtaCte)
        {
            Deuda = 0;
            DeudaVencida = 0;
            if (proveedoresCtaCte != null)
            {
                foreach (var cuenta in proveedoresCtaCte)
                {
                    Deuda += (cuenta.Importe - cuenta.Pagado);
                    var total = (DateTime.Now - Convert.ToDateTime(cuenta.FechaVencimiento)).Days;
                    if (total >= 30)
                    {
                        DeudaVencida += (cuenta.Importe - cuenta.Pagado);
                    }
                }
            }
        }

        private void CalcularConsigna(List<ProveedorConsignacionDto> proveedoresConsigna)
        {
            Consignacion = 0;
            ConsignacionVencida = 0;
            if (proveedoresConsigna != null)
            {
                foreach (var cuenta in proveedoresConsigna)
                {
                    Consignacion += (cuenta.Importe - cuenta.Pagado);
                    var total = (DateTime.Now - Convert.ToDateTime(cuenta.FechaConsignacion)).Days;
                    if (total >= 30)
                    {
                        ConsignacionVencida += (cuenta.Importe - cuenta.Pagado);
                    }
                }
            }
        }

        private void PintarCuotasVencidas()
        {
            foreach (GridViewRowInfo row in GridCtaCte.Rows)
                //if (Convert.ToInt32(row.Cells[7].Value) < Convert.ToInt32(row.Cells[10].Value))
                //{
                row.Cells[1].Style.BackColor = System.Drawing.Color.Red;
            //}
        }

        private void Filtered(object sender, Entidades.Proveedor e)
        {
            RefrescarListado();
            CalcularSenias();
            LimpiarPagos();
            ActualizarMontos();
        }

        private void LimpiarPagos()
        {
            ucTotalesCompraSeña1.Pagos.Clear();
            ucTotalesCompraSeña1.TotalPagar = 0;
            ucTotalesCompraSeña1.SubTotal = 0;


        }

        private void CalcularSenias()
        {
            ucTotalesCompraSeña1.Senas = 0;
            ucTotalesCompraSeña1.SenasDisp = SeñaAFavorProveedor(ucFiltroProveedor1.ProveedorId);

            ucTotalesCompraSeña1.Creditos = 0;
            ucTotalesCompraSeña1.CreditosDisp = MontoAFavorProveedor(ucFiltroProveedor1.ProveedorId);

            ucTotalesCompraSeña1.Egresos = 0;
            ucTotalesCompraSeña1.EgresosDisp = EgresoProveedor(ucFiltroProveedor1.ProveedorId);
        }


        private void GridCtaCte_ValueChanged(object sender, EventArgs e)
        {
            if (sender.ToString() == "Telerik.WinControls.UI.RadCheckBoxEditor")
            {
                if (this.GridCtaCte.ActiveEditor.Value.ToString() == "On")
                {
                    AgregarPago(1);
                    _celdasSeleccionadas += 1;
                }
                else
                {
                    AgregarPago(-1);
                    _celdasSeleccionadas -= 1;
                }
            }
            else
            {
                ModificarPago();
            }

            ChequeoPagina(_celdasSeleccionadas, 1);

            if (sender.ToString() == "Telerik.WinControls.UI.RadTextBoxEditor")
            {
                var textbox = sender as Telerik.WinControls.UI.RadTextBoxEditor;

                if (textbox != null && textbox.Value.ToString() != "")
                {
                    //controlar que no vengan letras
                    AgregarPagoParcial(Convert.ToDecimal(textbox.Value.ToString()), Convert.ToDecimal(GridCtaCte.CurrentCell.Value.ToString()));
                    GridCtaCte.CurrentCell.Value = textbox.Value;
                }
            }
        }

        private void GridConsignaciones_ValueChanged(object sender, EventArgs e)
        {
            if (sender.ToString() == "Telerik.WinControls.UI.RadCheckBoxEditor")
            {
                if (this.GridConsignaciones.ActiveEditor.Value.ToString() == "On")
                {
                    AgregarPagoConsignaciones(1);
                    _celdasSeleccionadas += 1;
                }
                else
                {
                    AgregarPagoConsignaciones(-1);
                    _celdasSeleccionadas -= 1;
                }
            }
            else
            {
                ModificarPago();
            }

            ChequeoPagina(_celdasSeleccionadas, 0);




            if (sender.ToString() == "Telerik.WinControls.UI.RadTextBoxEditor")
            {
                var textbox = sender as Telerik.WinControls.UI.RadTextBoxEditor;

                if (textbox != null && textbox.Value.ToString() != "")
                {
                    AgregarPagoParcial(Convert.ToDecimal(textbox.Value.ToString()), Convert.ToDecimal(GridConsignaciones.CurrentCell.Value.ToString()));
                    GridConsignaciones.CurrentCell.Value = textbox.Value;
                }
            }


        }

        private void SelectAll()
        {
            ucTotalesCompraSeña1.SubTotal = 0;
            _celdasSeleccionadas = 0;
            if (RpvPagos.SelectedPage.Name == "CuentaCorriente")
            {
                if (ChkSeleccionCtaCte.Checked)
                {
                    for (int i = 0; i < GridCtaCte.RowCount; i++)
                    {


                        //if (GridCtaCte.Rows[i].Cells[8].Value == null)
                        //    MessageBox.Show("Es null" + i.ToString());
                        //else
                        //    if (GridCtaCte.Rows[i].Cells[8].Value.ToString() != "On")
                        //        MessageBox.Show("Es vacio" + i.ToString());

                        GridCtaCte.Rows[i].Cells[8].Value = "false";
                        // GridCtaCte.Rows[i].Cells[8].Value = true;
                        AgregarPagoLinea(1, i);
                        _celdasSeleccionadas += 1;
                        ChequeoPagina(_celdasSeleccionadas, 1);
                    }
                }
                else
                {
                    for (int i = 0; i < GridCtaCte.RowCount; i++)
                    {
                        //if (GridCtaCte.Rows[i].Cells[8].Value.ToString()=="true")
                        //{
                        GridCtaCte.Rows[i].Cells[8].Value = false;
                        //AgregarPagoLinea(-1, i);
                        //_celdasSeleccionadas -= 1;
                        //ChequeoPagina(_celdasSeleccionadas, 1);
                        //}

                    }
                }
            }
        }



        private void ChequeoPagina(int _celdasSeleccionadas, int p)
        {
            if (_celdasSeleccionadas > 0)
            {
                RpvPagos.Pages[p].Enabled = false;
            }
            else
                RpvPagos.Pages[p].Enabled = true;
        }

        private void ModificarPago()
        {

            Subtotal = this.Subtotal.GetValueOrDefault();
        }

        private void AgregarPagoParcial(decimal monto, decimal montoanterior)
        {
            Subtotal = this.Subtotal.GetValueOrDefault() + (monto) - montoanterior;
            ActualizarMontos();
        }
        private void AgregarPago(int signo)
        {
            //signo: si pasas 1 sumas porque estas agregando, si no es con -1 y resta.
            var selectedRow = GridCtaCte.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            var lineaSeleccionada = (ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem;


            var _compraSeleccionada = Uow.ProveedoresCuentasCorrientes.Obtener(p => p.Id == lineaSeleccionada.Id);

            if (_compraSeleccionada != null && signo > 0)
            {
                Subtotal = this.Subtotal.GetValueOrDefault() + ((_compraSeleccionada.Importe - _compraSeleccionada.Pagado) * signo);
                GridCtaCte.CurrentRow.Cells[7].Value = (_compraSeleccionada.Importe - _compraSeleccionada.Pagado).ToString();
            }
            else
            {
                Subtotal = this.Subtotal.GetValueOrDefault() + ((Convert.ToDecimal(GridCtaCte.CurrentRow.Cells[7].Value)) * signo);
                GridCtaCte.CurrentRow.Cells[7].Value = (_compraSeleccionada.Importe - _compraSeleccionada.Pagado).ToString();
            }

            //Deshabilitamos el "A pagar"
            if (signo > 0)
            {
                GridCtaCte.CurrentRow.Cells[7].ReadOnly = false;
            }
            else
            {
                GridCtaCte.CurrentRow.Cells[7].Value = "";
                GridCtaCte.CurrentRow.Cells[7].ReadOnly = true;
            }
            ActualizarMontos();

        }

        private void AgregarPagoLinea(int signo, int linea)
        {
            //signo: si pasas 1 sumas porque estas agregando, si no es con -1 y resta.
            var selectedRow = GridCtaCte.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            var lineaSeleccionada = (ProveedorCtaCteDto)GridCtaCte.CurrentRow.DataBoundItem;

            lineaSeleccionada = (ProveedorCtaCteDto)GridCtaCte.Rows[linea].DataBoundItem;

            var _compraSeleccionada = Uow.ProveedoresCuentasCorrientes.Obtener(p => p.Id == lineaSeleccionada.Id);

            if (_compraSeleccionada != null && signo > 0)
            {
                Subtotal = this.Subtotal.GetValueOrDefault() + ((_compraSeleccionada.Importe - _compraSeleccionada.Pagado) * signo);
                GridCtaCte.Rows[linea].Cells[7].Value = (_compraSeleccionada.Importe - _compraSeleccionada.Pagado).ToString();
            }
            else
            {
                Subtotal = this.Subtotal.GetValueOrDefault() + ((Convert.ToDecimal(GridCtaCte.Rows[linea].Cells[7].Value)) * signo);
                GridCtaCte.Rows[linea].Cells[7].Value = (_compraSeleccionada.Importe - _compraSeleccionada.Pagado).ToString();
            }

            //Deshabilitamos el "A pagar"
            if (signo > 0)
            {
                GridCtaCte.Rows[linea].Cells[7].ReadOnly = false;
            }
            else
            {
                GridCtaCte.Rows[linea].Cells[7].Value = "";
                GridCtaCte.Rows[linea].Cells[7].ReadOnly = true;
            }
            ActualizarMontos();

        }

        void ucTotalesCompraSeña1_TotalAPagarChanged(object sender, decimal? e)
        {
            if (ucTotalesCompraSeña1.FaltaPagar != 0)
            {
                ucTotalesCompraSeña1.EliminarPagoEfectivo();
                if (ucTotalesCompraSeña1.FaltaPagar > 0)
                {
                    ucTotalesCompraSeña1.GenerarPagoAnticipoNuevo(ucTotalesCompraSeña1.FaltaPagar, FormaPago.Efectivo);
                }

            }
        }

        void ucTotalesCompraSeña1_SeñaChanged(object sender, EventArgs e)
        {
            ActualizarMontos();
        }

        private void ActualizarMontos()
        {
            ucTotalesCompraSeña1.GenerarPagoAuto(ucTotalesCompraSeña1.TotalPagar);
        }

        public decimal SeñaAFavorProveedor(Guid? proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresSenias.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId
                                                   && ps.ImporteUsado < ps.Importe)
                                       .ToList();
            return proveedoresMontosFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteUsado.GetValueOrDefault());
        }


        private decimal? MontoAFavorProveedor(Guid? proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresMontosFavor.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId 
                                                    && ps.TipoComprobanteId== TipoComprobanteEnum.NotaCreditoProveedor
                                                   && ps.ImporteOcupado < ps.Importe)
                                       .ToList();
            return proveedoresMontosFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteOcupado.GetValueOrDefault());
        }

        private decimal? EgresoProveedor(Guid? proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresMontosFavor.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId
                                              && ps.TipoComprobanteId == TipoComprobanteEnum.MontoFavorProveedor
                                                   && ps.ImporteOcupado < ps.Importe)
                                       .ToList();
            return proveedoresMontosFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteOcupado.GetValueOrDefault());
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            _pagoIdConsignacion = Guid.NewGuid();
            _pagoIdCtaCte = Guid.NewGuid();
            if (RpvPagos.SelectedPage.Name == "CuentaCorriente")
            {
                GuardarCuotas();
            }
            else
            {
                GuardarConsignacion();
            }
            OnCuentaRealizada();

        }

        private void GuardarCuotas()
        {//Metodo que recorre cada fila del gridCuentaCorriente y va guardando los pagos de la cuota
            GuardarProveedoresPago(_pagoIdCtaCte);

            foreach (GridViewRowInfo row in GridCtaCte.Rows)
            {
                var lineaSeleccionada = (ProveedorCtaCteDto)row.DataBoundItem;

                var _compraSeleccionada = Uow.ProveedoresCuentasCorrientes.Obtener(p => p.Id == lineaSeleccionada.Id);

                if (_compraSeleccionada != null)
                {
                    if (row.Cells[8].Value != null)
                    {
                        //validar pagos individuales
                        if (Convert.ToDecimal(row.Cells[7].Value) > (Convert.ToDecimal(row.Cells[5].Value) - Convert.ToDecimal(row.Cells[6].Value)))
                        {
                            _messageBoxDisplayService.ShowError("El monto de la cuota supera al pago");
                            return;
                        }
                        _compraSeleccionada.Pagado += Convert.ToDecimal(row.Cells[7].Value);
                        _compraSeleccionada.FechaModificacion = _clock.Now;
                        Uow.ProveedoresCuentasCorrientes.Modificar(_compraSeleccionada);

                        #region proveedorPagoDetalle
                        var _proveedorPagoDetalle = new ProveedoresPagosDetalle();
                        _proveedorPagoDetalle.Id = Guid.NewGuid();
                        _proveedorPagoDetalle.ProveedorPagoId = _pagoIdCtaCte;
                        _proveedorPagoDetalle.ProveedorCuentaCorrienteId = Guid.Parse(row.Cells[9].Value.ToString());
                        _proveedorPagoDetalle.ProveedorConsignacionId = Guid.Empty;
                        _proveedorPagoDetalle.MontoPagado = Convert.ToDecimal(row.Cells[7].Value);
                        _proveedorPagoDetalle.FechaAlta = _clock.Now;
                        _proveedorPagoDetalle.OperadorAltaId = Context.OperadorActual.Id;
                        _proveedorPagoDetalle.SucursalAltaId = Context.SucursalActual.Id;
                        Uow.ProveedoresPagosDetalles.Agregar(_proveedorPagoDetalle);
                        #endregion

                    }
                    else
                    {

                    }

                }

            }
            GuardarPagos();


        }

        private void OnCuentaRealizada()
        {
            if (ProveedoresCuentaCorriente != null)
            {
                //ProveedoresCuentaCorriente(this, new EventArgs());

                RefrescarListado();
                CalcularSenias();
                LimpiarPagos();
                ActualizarMontos();

                _celdasSeleccionadas = 0;
                ChequeoPagina(_celdasSeleccionadas, 1);
                ChequeoPagina(_celdasSeleccionadas, 0);
            }
        }

        private void GuardarPagos()
        {
            if (!ValidarPagoCuentaCorriente())
                return;

            //Acumulamos los pagos
            decimal? efectivo = 0;
            decimal? efectivoCajaAnterior = 0;
            decimal? tarjeta = 0;
            decimal? cheque = 0;
            decimal? deposito = 0;
            decimal? transferencia = 0;

            foreach (var pago in ucTotalesCompraSeña1.Pagos)
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



            #region Guardamos caja en contado

            //Guardamos la caja
            Caja caja = new Caja();
            if (DtpFechaPago.Value != _clock.Now)
            {
                caja = Uow.Cajas.Obtener(c => DbFunctions.TruncateTime(c.FechaAlta) == DtpFechaPago.Value.Date);
                if (caja == null)
                {
                    MessageBox.Show("No se encontro una caja válida para esa fecha");
                    return;
                }
            }
            else
            {
                caja = this.Context.CajaActual;

                //descontar de la caja
                if (caja.Egresos == null)
                    caja.Egresos = 0;

                caja.Egresos += (float?)efectivo;

                if (caja.Saldo == null)
                    caja.Saldo = 0;
                caja.Saldo -= (float?)ucTotalesCompraSeña1.SubTotal;

                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = Context.SucursalActual.Id;
                caja.OperadorModificacionId = (Context.OperadorActual.Id);
            }


            //aca descontamos las señas en el caso de que se utilicen. 
            var _seña = UsoDeSeña();
            var _credito = UsoDeCredito();
            var _egreso = UsoEgreso();

            if (efectivo > 0)
            {
                CajaMovimiento cajaMovimiento = new CajaMovimiento();
                cajaMovimiento.Id = Guid.NewGuid();
                cajaMovimiento.CajaId = caja.Id;

                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.PagoProveedores;

                cajaMovimiento.ComprobanteId = _pagoIdCtaCte;
                cajaMovimiento.Importe = efectivo;
                cajaMovimiento.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;
                cajaMovimiento.Efectivo = efectivo;

                cajaMovimiento.Senia = _seña + _credito + _egreso;
                if (_seña > 0)
                {
                   // cajaMovimiento.Senia = _seña;
                    _seña = 0;
                }

                if (_credito > 0)
                {
                    _credito = 0;
                }

                if (_egreso > 0)
                {
                    _egreso = 0;
                }
                cajaMovimiento.FechaAlta = DtpFechaPago.Value;

                cajaMovimiento.PcAlta = System.Environment.MachineName;
                cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                cajaMovimiento.OperadorModificacionId = Context.OperadorActual.Id;
                cajaMovimiento.FechaModificacion = _clock.Now;
                cajaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;

                cajaMovimiento.TipoComprobante = TipoComprobanteEnum.PagoProveedores;
                Uow.CajaMovimientos.Agregar(cajaMovimiento);
            }

            if (tarjeta > 0 || deposito > 0 || cheque > 0 || efectivoCajaAnterior > 0 || transferencia > 0)
            {
                CajaMovimiento cajaMovimientoAnterior = new CajaMovimiento();
                cajaMovimientoAnterior.Id = Guid.NewGuid();
                cajaMovimientoAnterior.CajaId = caja.Id;

                //cajaMovimientoAnterior.TipoMovimientoCajaId =
                //    TipoMovimientoCajaEnum.PagoProveedorCajaAnterior -1;

                cajaMovimientoAnterior.TipoMovimientoCajaId =
                    TipoMovimientoCajaEnum.PagoCtaProveedorCajaAnterior;

                cajaMovimientoAnterior.ComprobanteId = _pagoIdCtaCte;
                cajaMovimientoAnterior.Importe = tarjeta + deposito + cheque + efectivoCajaAnterior + transferencia;
                cajaMovimientoAnterior.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;
                cajaMovimientoAnterior.FechaAlta = _clock.Now;
                cajaMovimientoAnterior.FechaModificacion = _clock.Now;
                cajaMovimientoAnterior.PcAlta = System.Environment.MachineName;
                cajaMovimientoAnterior.OperadorAltaId = Context.OperadorActual.Id;
                cajaMovimientoAnterior.SucursalAltaId = Context.SucursalActual.Id;
                cajaMovimientoAnterior.OperadorModificacionId = Context.OperadorActual.Id;
                cajaMovimientoAnterior.SucursalModificacionId = Context.SucursalActual.Id;
                cajaMovimientoAnterior.TipoComprobante = TipoComprobanteEnum.PagoProveedores;
                cajaMovimientoAnterior.Efectivo = efectivoCajaAnterior;
                cajaMovimientoAnterior.Tarjeta = tarjeta;
                cajaMovimientoAnterior.Deposito = deposito;
                cajaMovimientoAnterior.Cheque = cheque;
                cajaMovimientoAnterior.Transferencia = transferencia;

                cajaMovimientoAnterior.Senia = _seña + _credito + _egreso;
                //if (_seña > 0)
                //{
                //    cajaMovimientoAnterior.Senia = _seña;
                //}
                Uow.CajaMovimientos.Agregar(cajaMovimientoAnterior);

                //Guardamos el movimiento del depósito
                foreach (var pago in ucTotalesCompraSeña1.Pagos)
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

                            //CONTROLAR!!
                            cuentasMovimiento.TipoComprobanteId = TipoComprobanteEnum.PagoProveedores;

                            //le paso guid empty pero hay que ver que se le pasa
                            cuentasMovimiento.ComprobanteId = Guid.Empty;
                            cuentasMovimiento.MonedaId = 0;
                            cuentasMovimiento.NroMovimiento = pagoDeposito.Numero;
                            cuentasMovimiento.Descripcion = "DEPOSITO NRO " + pagoDeposito.Numero.ToString();
                            cuentasMovimiento.FechaCobro = _clock.Now;
                            cuentasMovimiento.Debito = pago.Importe;
                            cuentasMovimiento.Credito = 0;
                            cuentasMovimiento.TipoCarga = 1;
                            cuentasMovimiento.CajaId = caja.Id;
                            cuentasMovimiento.FechaAlta = _clock.Now;
                            cuentasMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                            cuentasMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                            Uow.CuentasMovimientos.Agregar(cuentasMovimiento);
                            break;

                        case FormaPago.Transferencia:
                            var pagoTransferencia = pago as VentaPagoTransferencia;

                            CuentasMovimiento cuentasMovimientoTransferecia = new CuentasMovimiento();
                            cuentasMovimientoTransferecia.CuentaId = pagoTransferencia.CuentaId ?? 0;
                            cuentasMovimientoTransferecia.TipoMovimientoId = 1;//Deposito a proveedor
                            cuentasMovimientoTransferecia.FechaMovimiento = pagoTransferencia.Fecha;
                            cuentasMovimientoTransferecia.EstadoMovimientoCuentaId = 0;

                            //CONTROLAR!!
                            cuentasMovimientoTransferecia.TipoComprobanteId = TipoComprobanteEnum.PagoProveedores;
                            //le paso guid empty pero hay que ver que se le pasa
                            cuentasMovimientoTransferecia.ComprobanteId = Guid.Empty;
                            cuentasMovimientoTransferecia.MonedaId = 0;
                            cuentasMovimientoTransferecia.NroMovimiento = pagoTransferencia.Numero;
                            cuentasMovimientoTransferecia.Descripcion = "TRANSFERENCIA NRO " + pagoTransferencia.Numero.ToString();
                            cuentasMovimientoTransferecia.FechaCobro = _clock.Now;
                            cuentasMovimientoTransferecia.Debito = pago.Importe;
                            cuentasMovimientoTransferecia.Credito = 0;
                            cuentasMovimientoTransferecia.TipoCarga = 1;
                            cuentasMovimientoTransferecia.CajaId = caja.Id;
                            cuentasMovimientoTransferecia.FechaAlta = _clock.Now;
                            cuentasMovimientoTransferecia.OperadorAltaId = Context.OperadorActual.Id;
                            cuentasMovimientoTransferecia.SucursalAltaId = Context.SucursalActual.Id;

                            Uow.CuentasMovimientos.Agregar(cuentasMovimientoTransferecia);
                            break;
                    }
                }

            }


            Uow.Cajas.Modificar(caja);

            #endregion



            Uow.Commit();

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessPagoExitoso);

        }

       



        private bool ValidarPagoCuentaCorriente()
        {
            bool bandera = !(!ucTotalesCompraSeña1.Validar());

            var cantidadSeleccionada = 0;
            foreach (GridViewRowInfo row in GridCtaCte.Rows)
            {
                var fila = row.Cells[8].Value;
                if (fila != null)
                {
                    if (fila.ToString() == "True")
                        cantidadSeleccionada += 1;
                }
            }
            if (cantidadSeleccionada == 0)
            {
                _messageBoxDisplayService.ShowError("Debe seleccionar una cuota.");
                bandera = false;
            }
            return bandera;
        }

        #region Consignacion
        private void GuardarPagosConsignacion()
        {
            if (!ValidarPagoConsignacion())
                return;

            //Acumulamos los pagos
            decimal? efectivo = 0;
            decimal? efectivoCajaAnterior = 0;
            decimal? tarjeta = 0;
            decimal? cheque = 0;
            decimal? deposito = 0;
            decimal? transferencia = 0;

            foreach (var pago in ucTotalesCompraSeña1.Pagos)
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



            #region Guardamos caja en contado

            //Guardamos la caja
            Caja caja = new Caja();
            if (DtpFechaPago.Value != _clock.Now)
            {
                caja = Uow.Cajas.Obtener(c => DbFunctions.TruncateTime(c.FechaAlta) == DtpFechaPago.Value.Date);
                if (caja == null)
                {
                    MessageBox.Show("No se encontro una caja válida para esa fecha");
                    return;
                }
            }
            else
            {
                caja = this.Context.CajaActual;

                //descontar de la caja
                if (caja.Egresos == null)
                    caja.Egresos = 0;

                caja.Egresos += (float?)efectivo;

                if (caja.Saldo == null)
                    caja.Saldo = 0;
                caja.Saldo -= (float?)ucTotalesCompraSeña1.SubTotal;

                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = Context.SucursalActual.Id;
                caja.OperadorModificacionId = (Context.OperadorActual.Id);
            }


            //aca descontamos las señas en el caso de que se utilicen. 
            var _seña = UsoDeSeña();
            var _credito = UsoDeCredito();
            var _egreso = UsoEgreso();

            if (efectivo > 0)
            {
                CajaMovimiento cajaMovimiento = new CajaMovimiento();
                cajaMovimiento.Id = Guid.NewGuid();
                cajaMovimiento.CajaId = caja.Id;

                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.PagoProveedores;

                //le paso guid empty pero hay que ver que se le pasa
                cajaMovimiento.ComprobanteId = _pagoIdConsignacion;
                cajaMovimiento.Importe = efectivo;
                cajaMovimiento.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;
                cajaMovimiento.Efectivo = efectivo;

                cajaMovimiento.Senia = _seña + _credito + _egreso;
                if (_seña > 0)
                {
                    //cajaMovimiento.Senia = _seña;
                    _seña = 0;
                }

                if (_credito > 0)
                {
                    //cajaMovimiento.Senia = _seña;
                    _credito = 0;
                }

                if (_egreso > 0)
                {
                    _egreso = 0;
                }

                cajaMovimiento.FechaAlta = DtpFechaPago.Value;

                cajaMovimiento.PcAlta = System.Environment.MachineName;
                cajaMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                cajaMovimiento.OperadorModificacionId = Context.OperadorActual.Id;
                cajaMovimiento.FechaModificacion = _clock.Now;
                cajaMovimiento.SucursalModificacionId = Context.SucursalActual.Id;

                cajaMovimiento.TipoComprobante = TipoComprobanteEnum.PagoProveedores;
                Uow.CajaMovimientos.Agregar(cajaMovimiento);
            }

            if (tarjeta > 0 || deposito > 0 || cheque > 0 || efectivoCajaAnterior > 0 || transferencia > 0)
            {
                CajaMovimiento cajaMovimientoAnterior = new CajaMovimiento();
                cajaMovimientoAnterior.Id = Guid.NewGuid();
                cajaMovimientoAnterior.CajaId = caja.Id;

                //cajaMovimientoAnterior.TipoMovimientoCajaId =
                //    TipoMovimientoCajaEnum.PagoProveedorCajaAnterior; -2
                cajaMovimientoAnterior.TipoMovimientoCajaId =
                    TipoMovimientoCajaEnum.PagoCtaProveedorCajaAnterior;

                cajaMovimientoAnterior.ComprobanteId = _pagoIdConsignacion;
                cajaMovimientoAnterior.Importe = tarjeta + deposito + cheque + efectivoCajaAnterior + transferencia;
                cajaMovimientoAnterior.ImpFac = (decimal?)ucTotalesCompraSeña1.SubTotal;
                cajaMovimientoAnterior.FechaAlta = _clock.Now;
                cajaMovimientoAnterior.FechaModificacion = _clock.Now;
                cajaMovimientoAnterior.PcAlta = System.Environment.MachineName;
                cajaMovimientoAnterior.OperadorAltaId = Context.OperadorActual.Id;
                cajaMovimientoAnterior.SucursalAltaId = Context.SucursalActual.Id;
                cajaMovimientoAnterior.OperadorModificacionId = Context.OperadorActual.Id;
                cajaMovimientoAnterior.SucursalModificacionId = Context.SucursalActual.Id;
                cajaMovimientoAnterior.TipoComprobante = TipoComprobanteEnum.PagoProveedores;
                cajaMovimientoAnterior.Efectivo = efectivoCajaAnterior;
                cajaMovimientoAnterior.Tarjeta = tarjeta;
                cajaMovimientoAnterior.Deposito = deposito;
                cajaMovimientoAnterior.Cheque = cheque;
                cajaMovimientoAnterior.Transferencia = transferencia;

                cajaMovimientoAnterior.Senia = _seña + _credito + _egreso;
              
                Uow.CajaMovimientos.Agregar(cajaMovimientoAnterior);

                //Guardamos el movimiento del depósito
                foreach (var pago in ucTotalesCompraSeña1.Pagos)
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

                            //CONTROLAR!!
                            cuentasMovimiento.TipoComprobanteId = TipoComprobanteEnum.PagoProveedores;

                            //le paso guid empty pero hay que ver que se le pasa
                            cuentasMovimiento.ComprobanteId = Guid.Empty;
                            cuentasMovimiento.MonedaId = 0;
                            cuentasMovimiento.NroMovimiento = pagoDeposito.Numero;
                            cuentasMovimiento.Descripcion = "DEPOSITO NRO " + pagoDeposito.Numero.ToString();
                            cuentasMovimiento.FechaCobro = _clock.Now;
                            cuentasMovimiento.Debito = pago.Importe;
                            cuentasMovimiento.Credito = 0;
                            cuentasMovimiento.TipoCarga = 1;
                            cuentasMovimiento.CajaId = caja.Id;
                            cuentasMovimiento.FechaAlta = _clock.Now;
                            cuentasMovimiento.OperadorAltaId = Context.OperadorActual.Id;
                            cuentasMovimiento.SucursalAltaId = Context.SucursalActual.Id;

                            Uow.CuentasMovimientos.Agregar(cuentasMovimiento);
                            break;

                        case FormaPago.Transferencia:
                            var pagoTransferencia = pago as VentaPagoTransferencia;

                            CuentasMovimiento cuentasMovimientoTransferecia = new CuentasMovimiento();
                            cuentasMovimientoTransferecia.CuentaId = pagoTransferencia.CuentaId ?? 0;
                            cuentasMovimientoTransferecia.TipoMovimientoId = 1;//Deposito a proveedor
                            cuentasMovimientoTransferecia.FechaMovimiento = pagoTransferencia.Fecha;
                            cuentasMovimientoTransferecia.EstadoMovimientoCuentaId = 0;

                            //CONTROLAR!!
                            cuentasMovimientoTransferecia.TipoComprobanteId = TipoComprobanteEnum.PagoProveedores;
                            //le paso guid empty pero hay que ver que se le pasa
                            cuentasMovimientoTransferecia.ComprobanteId = Guid.Empty;
                            cuentasMovimientoTransferecia.MonedaId = 0;
                            cuentasMovimientoTransferecia.NroMovimiento = pagoTransferencia.Numero;
                            cuentasMovimientoTransferecia.Descripcion = "TRANSFERENCIA NRO " + pagoTransferencia.Numero.ToString();
                            cuentasMovimientoTransferecia.FechaCobro = _clock.Now;
                            cuentasMovimientoTransferecia.Debito = pago.Importe;
                            cuentasMovimientoTransferecia.Credito = 0;
                            cuentasMovimientoTransferecia.TipoCarga = 1;
                            cuentasMovimientoTransferecia.CajaId = caja.Id;
                            cuentasMovimientoTransferecia.FechaAlta = _clock.Now;
                            cuentasMovimientoTransferecia.OperadorAltaId = Context.OperadorActual.Id;
                            cuentasMovimientoTransferecia.SucursalAltaId = Context.SucursalActual.Id;

                            Uow.CuentasMovimientos.Agregar(cuentasMovimientoTransferecia);
                            break;
                    }
                }

            }


            Uow.Cajas.Modificar(caja);

            #endregion



            Uow.Commit();

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessPagoExitoso);

        }

        private void GuardarProveedoresPago(Guid pagoId)
        {
            #region Guardar ProveedorPago

            var _proveedorPago = new ProveedoresPago();


            _proveedorPago.Id = pagoId;
            _proveedorPago.ProveedorId = Guid.Parse(ucFiltroProveedor1.ProveedorId.ToString());
            _proveedorPago.TipoComprobanteId = TipoComprobanteEnum.Recibo;
            _proveedorPago.Importe = ucTotalesCompraSeña1.TotalPagar;
            _proveedorPago.OperadorAltaId = Context.OperadorActual.Id;
            _proveedorPago.SucursalAltaId = Context.SucursalActual.Id;
            _proveedorPago.FechaAlta = _clock.Now;
            Uow.ProveedoresPagos.Agregar(_proveedorPago);

            #endregion


        }

        private bool ValidarPagoConsignacion()
        {
            bool bandera = !(!ucTotalesCompraSeña1.Validar());

            var cantidadSeleccionada = 0;
            foreach (GridViewRowInfo row in GridConsignaciones.Rows)
            {
                var fila = row.Cells[6].Value;
                if (fila != null)
                {
                    if (fila.ToString() == "True")
                        cantidadSeleccionada += 1;
                }
            }
            if (cantidadSeleccionada == 0)
            {
                _messageBoxDisplayService.ShowError("Debe seleccionar un pago.");
                bandera = false;
            }
            return bandera;
        }

        private void GuardarConsignacion()
        {
            GuardarProveedoresPago(_pagoIdConsignacion);
            foreach (GridViewRowInfo row in GridConsignaciones.Rows)
            {
                var lineaSeleccionada = (ProveedorConsignacionDto)row.DataBoundItem;

                var _consignacionSeleccionada = Uow.TitulosConsignacionesRendidas.Obtener(p => p.Id == lineaSeleccionada.Id);

                if (_consignacionSeleccionada != null)
                {
                    if (row.Cells[6].Value != null)
                    {
                        //validar pagos individuales
                        if (Convert.ToDecimal(row.Cells[5].Value) > (Convert.ToDecimal(row.Cells[3].Value) - Convert.ToDecimal(row.Cells[4].Value)))
                        {
                            _messageBoxDisplayService.ShowError("El monto de la cuota supera al pago");
                            return;
                        }

                        if (_consignacionSeleccionada.Pagado == null)
                            _consignacionSeleccionada.Pagado = Convert.ToDecimal(row.Cells[5].Value);
                        else
                            _consignacionSeleccionada.Pagado += Convert.ToDecimal(row.Cells[5].Value);

                        _consignacionSeleccionada.UltimaFechaPago = _clock.Now;
                        _consignacionSeleccionada.OperadorModificacionId = Context.OperadorActual.Id;
                        _consignacionSeleccionada.SucursalModificacionId = Context.SucursalActual.Id;
                        Uow.TitulosConsignacionesRendidas.Modificar(_consignacionSeleccionada);


                        #region proveedorPagoDetalle
                        var _proveedorPagoDetalle = new ProveedoresPagosDetalle();
                        _proveedorPagoDetalle.Id = Guid.NewGuid();
                        _proveedorPagoDetalle.ProveedorPagoId = _pagoIdConsignacion;
                        _proveedorPagoDetalle.ProveedorCuentaCorrienteId = Guid.Empty;
                        _proveedorPagoDetalle.ProveedorConsignacionId = Guid.Parse(row.Cells[7].Value.ToString());
                        _proveedorPagoDetalle.MontoPagado = Convert.ToDecimal(row.Cells[5].Value);
                        _proveedorPagoDetalle.FechaAlta = _clock.Now;
                        _proveedorPagoDetalle.OperadorAltaId = Context.OperadorActual.Id;
                        _proveedorPagoDetalle.SucursalAltaId = Context.SucursalActual.Id;
                        Uow.ProveedoresPagosDetalles.Agregar(_proveedorPagoDetalle);
                        #endregion
                    }
                    else
                    {

                    }

                }


            }
            GuardarPagosConsignacion();

        }

        private decimal? UsoDeSeña()
        {
            decimal? _seña = (decimal?)ucTotalesCompraSeña1.Senas;
            if (_seña > 0)
            {
                var monto = _seña;

                var proveedoresSenias =
                    Uow.ProveedoresSenias.Listado().Where((ps => ps.ProveedorId == ucFiltroProveedor1.ProveedorId
                                                                 && ps.ImporteUsado < ps.Importe)).OrderBy(
                                                                     p => p.FechaAlta).ToList();

                foreach (ProveedorSenia proveedorSenias in proveedoresSenias)
                {
                    if (monto != null)
                    {
                        if (monto > 0)
                        {
                            if ((proveedorSenias.Importe - proveedorSenias.ImporteUsado) >= monto)
                            {
                                proveedorSenias.ImporteUsado += monto;
                                monto = 0;
                            }
                            else
                            {
                                monto -= (proveedorSenias.Importe - proveedorSenias.ImporteUsado);
                                proveedorSenias.ImporteUsado = proveedorSenias.Importe;
                            }
                            Uow.ProveedoresSenias.Modificar(proveedorSenias);
                        }
                    }
                }
            }
            return _seña;
        }

        private decimal? UsoDeCredito()
        {
            decimal? credito = (decimal?)ucTotalesCompraSeña1.Creditos;
            if (credito > 0)
            {
                var monto = credito;

                var proveedoresCredito =
                    Uow.ProveedoresMontosFavor.Listado().Where((ps => ps.ProveedorId == ucFiltroProveedor1.ProveedorId
                                                                 && ps.TipoComprobanteId == TipoComprobanteEnum.NotaCreditoProveedor
                                                                 && ps.ImporteOcupado < ps.Importe)).OrderBy(
                                                                     p => p.FechaAlta).ToList();

                foreach (ProveedoresMontosFavor proveedorCredito in proveedoresCredito)
                {
                    if (monto != null)
                    {
                        if (monto > 0)
                        {
                            if ((proveedorCredito.Importe - proveedorCredito.ImporteOcupado) >= monto)
                            {
                                proveedorCredito.ImporteOcupado += monto;
                                monto = 0;
                            }
                            else
                            {
                                monto -= (proveedorCredito.Importe - proveedorCredito.ImporteOcupado);
                                proveedorCredito.ImporteOcupado = proveedorCredito.Importe;
                            }
                            Uow.ProveedoresMontosFavor.Modificar(proveedorCredito);
                        }
                    }
                }
            }
            return credito;
        }

        private decimal? UsoEgreso()
        {
            decimal? egreso = (decimal?)ucTotalesCompraSeña1.Egresos;
            if (egreso > 0)
            {
                var monto = egreso;

                var proveedoresCredito =
                    Uow.ProveedoresMontosFavor.Listado().Where((ps => ps.ProveedorId == ucFiltroProveedor1.ProveedorId
                                                                   && ps.TipoComprobanteId== TipoComprobanteEnum.MontoFavorProveedor
                                                                 && ps.ImporteOcupado < ps.Importe)).OrderBy(
                                                                     p => p.FechaAlta).ToList();

                foreach (ProveedoresMontosFavor proveedorCredito in proveedoresCredito)
                {
                    if (monto != null)
                    {
                        if (monto > 0)
                        {
                            if ((proveedorCredito.Importe - proveedorCredito.ImporteOcupado) >= monto)
                            {
                                proveedorCredito.ImporteOcupado += monto;
                                monto = 0;
                            }
                            else
                            {
                                monto -= (proveedorCredito.Importe - proveedorCredito.ImporteOcupado);
                                proveedorCredito.ImporteOcupado = proveedorCredito.Importe;
                            }
                            Uow.ProveedoresMontosFavor.Modificar(proveedorCredito);
                        }
                    }
                }
            }
            return egreso;
        }


        private void AgregarPagoConsignaciones(int signo)
        {
            //signo: si pasas 1 sumas porque estas agregando, si no es con -1 y resta.
            var selectedRow = GridConsignaciones.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            var lineaSeleccionada = (ProveedorConsignacionDto)GridConsignaciones.CurrentRow.DataBoundItem;

            var _consignaSeleccionada = Uow.TitulosConsignacionesRendidas.Obtener(p => p.Id == lineaSeleccionada.Id);


            if (_consignaSeleccionada != null && signo > 0)
            {
                Subtotal = this.Subtotal.GetValueOrDefault() + ((_consignaSeleccionada.Importe - _consignaSeleccionada.Pagado.GetValueOrDefault()) * signo);
                GridConsignaciones.CurrentRow.Cells[5].Value = (_consignaSeleccionada.Importe - _consignaSeleccionada.Pagado.GetValueOrDefault()).ToString();
            }
            else
            {
                Subtotal = this.Subtotal.GetValueOrDefault() + ((Convert.ToDecimal(GridConsignaciones.CurrentRow.Cells[5].Value)) * signo);
                GridConsignaciones.CurrentRow.Cells[5].Value = (_consignaSeleccionada.Importe - _consignaSeleccionada.Pagado.GetValueOrDefault()).ToString();
            }
            //Deshabilitamos el "A pagar"
            if (signo > 0)
            {
                GridConsignaciones.CurrentRow.Cells[5].ReadOnly = false;
            }
            else
            {
                GridConsignaciones.CurrentRow.Cells[5].Value = "";
                GridConsignaciones.CurrentRow.Cells[5].ReadOnly = true;
            }
            ActualizarMontos();
        }
        #endregion

        private void BtnCosas_Click(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void ChkSeleccionCtaCte_CheckedChanged(object sender, EventArgs e)
        {
            SelectAll();
        }

        private void GridCtaCte_CellClick(object sender, GridViewCellEventArgs e)
        {
            //MessageBox.Show("adsf");
        }


    }
}
