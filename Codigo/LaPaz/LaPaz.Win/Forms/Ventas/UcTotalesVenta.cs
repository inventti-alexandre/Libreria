using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Extentensions;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Win.Enums;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class UcTotalesVenta : UserControlBase
    {
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private IList<VentaPago> _pagos = new List<VentaPago>();
        private decimal? _senaTotal;
        private decimal? _creditoDevolucionTotal;

        public UcTotalesVenta()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
                _messageBoxDisplayService = Ioc.Container.Get<IMessageBoxDisplayService>();
            }

            InitializeComponent();

            this.GrillaPagos.CellFormatting += new CellFormattingEventHandler(this.Grilla_CellFormatting);
        }

        public event EventHandler<decimal?> TotalAPagarChanged;
        public event EventHandler<decimal?> FaltaPagarChanged;
        public event EventHandler<int?> DescuentoChanged;
        public event EventHandler<int?> RecargoChanged;
        public event EventHandler TotalChanged;
        public event EventHandler<decimal?> PagosChanged;

        #region Propiedades

        public IList<VentaPago> Pagos
        {
            get { return _pagos; }
        }


        public decimal? SubTotal
        {
            get
            {
                decimal subtotal;
                return decimal.TryParse(TxtSubtotal.Text, out subtotal) ? subtotal : (decimal?)0;
            }
            set
            {
                TxtSubtotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public decimal? Senas
        {
            get
            {
                decimal senas;
                return decimal.TryParse(TxtSenas.Text, out senas) ? senas : (decimal?)null;
            }
            set
            {
                TxtSenas.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                OnTotalChanged();
            }
        }

        public decimal? SenasDisp
        {
            get
            {
                decimal senas;
                return decimal.TryParse(TxtSenasDisp.Text, out senas) ? senas : (decimal?)null;
            }
            set
            {
                TxtSenasDisp.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public decimal? CreditosDevolucion
        {
            get
            {
                decimal creditosDevolucion;
                return decimal.TryParse(TxtCreditosDevolucion.Text, out creditosDevolucion) ? creditosDevolucion : (decimal?)null;
            }
            set
            {
                TxtCreditosDevolucion.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                OnTotalChanged();
            }
        }

        public decimal? CreditosDevolucionDisp
        {
            get
            {
                decimal creditosDevolucion;
                return decimal.TryParse(TxtCreditosDisp.Text, out creditosDevolucion) ? creditosDevolucion : (decimal?)null;
            }
            set
            {
                TxtCreditosDisp.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public int? Descuento
        {
            get
            {
                int descuento;
                return int.TryParse(txtDesc.Text, out descuento) ? descuento : (int?)null;
            }
            set
            {
                txtDesc.Text = value.HasValue ? value.Value.ToString() : string.Empty;
                OnTotalChanged();
            }
        }

        public int? Recargo
        {
            get
            {
                int recargo;
                return int.TryParse(txtRecargo.Text, out recargo) ? recargo : (int?)null;
            }
            set
            {
                txtRecargo.Text = value.HasValue ? value.Value.ToString() : string.Empty;
                OnTotalChanged();
            }
        }

        public decimal? TotalPagar
        {
            get
            {
                decimal totalPagar;
                return decimal.TryParse(TxtTotalPagar.Text, out totalPagar) ? totalPagar : (decimal?)null;
            }
            set
            {
                TxtTotalPagar.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public decimal? FaltaPagar
        {
            get
            {
                decimal faltaPagar;
                return decimal.TryParse(TxtFaltaPagar.Text, out faltaPagar) ? faltaPagar : (decimal?)null;
            }
            set
            {
                TxtFaltaPagar.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                TotalPagos();
            }
        }

        public decimal TotalEnEfectivo
        {
            get
            {
                decimal efectivo = 0;
                foreach (VentaPago pago in this.Pagos)
                {
                    if (pago.TipoPago == FormaPago.Efectivo)
                        efectivo = pago.Importe ?? 0;
                }

                return efectivo;
            }
        }

        public bool HayPagoEnEfectivo
        {
            get { return TotalEnEfectivo > 0; }
        }
        #endregion

        #region Metodos

        public void ActualizarMontosAFavor(decimal? sena, decimal? creditoDevolucion)
        {
            _senaTotal = sena;
            _creditoDevolucionTotal = creditoDevolucion;

            Senas = sena;
            CreditosDevolucion = creditoDevolucion;
        }

        private void UcTotalesVenta_Load(object sender, EventArgs e)
        {
            RefrescarPagos();
        }

        public void BtnAgregarPago_Click(object sender, EventArgs e)
        {
            using (var formAgregarPago = FormFactory.Create<FrmAgregarPago>(Guid.Empty, ActionFormMode.Create))
            {
                formAgregarPago.PagoAgregado += (o, pago) =>
                {
                    Pagos.Add(pago);
                    RefrescarPagos();
                    if (pago.TipoPago != FormaPago.Efectivo)
                    {
                        if (pago.Importe != TotalPagar)
                            OnPagosChanged(pago.Importe);
                        else
                        {
                            EliminarPagoEfectivo();
                        }
                    }

                    formAgregarPago.Close();
                };

                formAgregarPago.ShowDialog(); 
            }
        }

        public void EliminarPagoEfectivo()
        {
            if (Pagos.Count != 0)
            {
                foreach (var pago in Pagos)
                {
                    if (pago.TipoPago == FormaPago.Efectivo)
                    {
                        pago.Importe = 0;
                        Pagos.Remove(pago);
                        RefrescarPagos();
                        return;


                    }
                }
            }
        }

        public void GenerarPagoAutoNuevo(decimal? monto, FormaPago tipoPago)
        {
            if (!monto.HasValue || monto.Value == 00)
            {
                return;
            }

            if (Pagos.Count != 0)
            {
                foreach (var pago in Pagos)
                {
                    if (pago.TipoPago == tipoPago)
                    {
                        pago.Importe = monto;

                        GrillaPagos.DataSource = Pagos.ToList();
                        EliminarPagoCero();
                        RefrescarPagos();
                        return;
                    }
                }
            }
            VentaPago pagoNuevo = new VentaPago();
            pagoNuevo.TipoPago = tipoPago;
            pagoNuevo.Importe = monto;
            Pagos.Add(pagoNuevo);

            GrillaPagos.DataSource = Pagos.ToList();
            RefrescarPagos();
        }

        private void EliminarPagoCero()
        {
            foreach (var pago in Pagos)
            {
                if (pago.Importe == 0)
                {
                    pago.Importe = 0;
                    Pagos.Remove(pago);
                    RefrescarPagos();
                    return;
                }
            }
        }


        public void GenerarPagoAnticipoNuevo(decimal? monto, FormaPago tipoPago)
        {
            if (Pagos.Count != 0)
            {
                foreach (var pago in Pagos)
                {
                    if (pago.TipoPago == tipoPago)
                    {

                        pago.Importe = monto;

                        GrillaPagos.DataSource = Pagos.ToList();
                        EliminarPagoCero();
                        RefrescarPagos();
                        return;
                    }
                }
            }
            VentaPago pagoNuevo = new VentaPago();
            pagoNuevo.TipoPago = tipoPago;
            pagoNuevo.Importe = monto;
            Pagos.Add(pagoNuevo);

            GrillaPagos.DataSource = Pagos.ToList();
            RefrescarPagos();
        }

        public void GenerarPagoCuotas(decimal? monto)
        {
            if (Pagos.Count == 0)
            {
                VentaPago pago = new VentaPago();
                pago.TipoPago = FormaPago.CuentaCorriente;
                pago.Importe = monto;
                monto = 0;
                Pagos.Add(pago);
            }
            else
            {
                foreach (var pago in Pagos)
                {
                    if (pago.TipoPago == FormaPago.CuentaCorriente)
                    {
                        pago.Importe = monto;
                        monto = 0;
                    }
                }
            }


            if (monto != 0)
            {
                VentaPago pago = new VentaPago();
                pago.TipoPago = FormaPago.CuentaCorriente;
                pago.Importe = monto;
                Pagos.Add(pago);
            }

            GrillaPagos.DataSource = Pagos.ToList();
            RefrescarPagos();
        }

        public void RefrescarPagos()
        {
            GrillaPagos.DataSource = Pagos.ToList();
            var total = TotalPagos();
            FaltaPagar = TotalPagar - total;
        }

        public decimal TotalPagos()
        {
            return this.Pagos.Sum(p => p.Importe ?? 0);
        }

        public void LimpiarPagos()
        {
            Pagos.Clear();
            RefrescarPagos();
        }

        public bool Validar()
        {
            return ValidarTotales() && ValidarPagos() && ValidarSenas() && ValidarCreditosDevolucion();
        }

        private bool ValidarTotales()
        {
            return TotalPagar.HasValue && SubTotal.HasValue;
        }

        private bool ValidarPagos()
        {
            bool valido = true;

            bool totalPagosValido = !(TotalPagos() != TotalPagar);

            if (!totalPagosValido)
            {
                this.UserControlErrorProvider.SetError(TxtTotalPagar, "El total de pagos no coincide con el total a pagar");
            }

            valido = totalPagosValido;

            if (this.Pagos.HasDuplicates(new FormaPagoComparer()))
            {
                valido = false;
            }

            return valido;
        }

        private bool ValidarSenas()
        {
            if (this.Senas > _senaTotal)
            {
                this.UserControlErrorProvider.SetError(TxtSenas, string.Format("La sena no puede ser mayor a {0:c2}", this._senaTotal));
                return false;
            }
            return true;
        }

        private bool ValidarCreditosDevolucion()
        {
            if (this.CreditosDevolucion > _creditoDevolucionTotal)
            {
                this.UserControlErrorProvider.SetError(TxtCreditosDevolucion,
                                                       string.Format(
                                                           "El crédito por devolución no puede ser mayor a {0:c2}",
                                                           this._creditoDevolucionTotal));
                return false;
            }
            return true;
        }

        private void GrillaPagos_CommandCellClick(object sender, EventArgs e)
        {
            var selectedRow = GrillaPagos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var ventaPago = selectedRow.DataBoundItem as VentaPago;

            if (ventaPago == null)
                return;
            if (ventaPago.TipoPago != FormaPago.CuentaCorriente)
                EliminarPago(ventaPago);
        }

        private void GrillaPagos_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                var selectedRow = GrillaPagos.SelectedRows[0];

                var ventaPago = selectedRow.DataBoundItem as VentaPago;

                if (ventaPago != null)
                {
                    EliminarPago(ventaPago);
                }
            }
        }

        private void EliminarPago(VentaPago ventaPago)
        {
            Pagos.Remove(ventaPago);
            RefrescarPagos();
        }

        private void TxtCreditosDevolucion_TextChanged(object sender, EventArgs e)
        {
            OnTotalChanged();
        }

        private void txtDesc_KeyUp(object sender, KeyEventArgs e)
        {
            OnDescuentoChanged(Descuento);
        }

        private void OnDescuentoChanged(int? descuento)
        {
            if (DescuentoChanged != null)
            {
                DescuentoChanged(this, descuento);
                OnTotalChanged();
            }
        }

        private void txtRecargo_KeyUp(object sender, KeyEventArgs e)
        {
            OnRecargoChanged(Recargo);
        }

        private void OnPagosChanged(decimal? monto)
        {
            if (PagosChanged != null)
            {
                PagosChanged(this, monto);
            }
        }


        private void OnRecargoChanged(int? recargo)
        {
            if (RecargoChanged != null)
            {
                RecargoChanged(this, recargo);
                OnTotalChanged();
            }
        }

        private void OnTotalChanged()
        {
            if (TotalChanged != null)
            {
                TotalChanged(this, null);
                RefrescarPagos();
                //ActualizarTotal();
            }
        }
        private void TxtTotalPagar_TextChanged(object sender, EventArgs e)
        {
            OnTotalAPagarChanged(TotalPagar);
        }

        private void TxtTotalPagar_KeyUp(object sender, KeyEventArgs e)
        {
            OnTotalAPagarChanged(TotalPagar);
        }

        private void OnTotalAPagarChanged(decimal? monto)
        {
            if (TotalAPagarChanged != null)
            {
                TotalAPagarChanged(this, monto);
            }
        }



        #endregion

        private void TxtSenas_KeyUp(object sender, KeyEventArgs e)
        {
            OnTotalChanged();
        }

        private void TxtFaltaPagar_TextChanged(object sender, EventArgs e)
        {
            OnFaltaPagarChanged(FaltaPagar);
        }

        private void OnFaltaPagarChanged(decimal? FaltaPagar)
        {
            if (FaltaPagarChanged != null)
            {
                FaltaPagarChanged(this, FaltaPagar);
            }
        }

        private void txtRecargo_TextChanged(object sender, EventArgs e)
        {
            //OnRecargoChanged(Recargo);
        }

    }
}
