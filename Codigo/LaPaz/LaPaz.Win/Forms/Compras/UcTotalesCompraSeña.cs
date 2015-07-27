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
using LaPaz.Win.Forms.Ventas;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcTotalesCompraSeña : UserControlBase
    {
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private IList<VentaPago> _pagos = new List<VentaPago>();
        private decimal? _senaTotal;
        
        public UcTotalesCompraSeña()
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
        public event EventHandler SeñaChanged;

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
                return decimal.TryParse(TxtSubtotal.Text, out subtotal) ? subtotal : (decimal?)null;
            }
            set
            {
                TxtSubtotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
                ActualizarTotal();
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
                ActualizarTotal();
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
        #endregion

        #region Metodos

        public void ActualizarMontosAFavor(decimal? sena)
        {
            _senaTotal = sena;
            SenasDisp = sena;
            
        }

        private void ActualizarTotal()
        {
            TotalPagar = SubTotal.GetValueOrDefault() - Senas.GetValueOrDefault() ;
            FaltaPagar = TotalPagar - TotalPagos();
        }

        private void UcTotalesVenta_Load(object sender, EventArgs e)
        {
            RefrescarPagos();
        }

        private void BtnAgregarPago_Click(object sender, EventArgs e)
        {
            using (var formAgregarPago = FormFactory.Create<FrmAgregarPago>(Guid.Empty, ActionFormMode.Edit))
            {
                formAgregarPago.PagoAgregado += (o, pago) =>
                {
                    Pagos.Add(pago);
                    RefrescarPagos();

                    formAgregarPago.Close();
                };

                formAgregarPago.ShowDialog();
            }
        }

        public void GenerarPagoAuto(decimal? monto)
        {
            if (Pagos.Count==0)
            {
                VentaPago pago = new VentaPago();
                pago.TipoPago = FormaPago.Efectivo;
                pago.Importe = monto;
                Pagos.Add(pago);
            }
            else
            {
                foreach (var pago in Pagos)
                {
                    switch (pago.TipoPago)
                    {
                        case FormaPago.Efectivo:
                            pago.Importe= monto;
                            break;
                    }
                }
            }

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
            FaltaPagar = TotalPagar - TotalPagos();
        }

        private decimal TotalPagos()
        {
            return this.Pagos.Sum(p => p.Importe ?? 0);
        }

        public bool Validar()
        {
            return ValidarTotales() && ValidarPagos() && ValidarSenas();
        }

        private bool ValidarTotales()
        {
            return TotalPagar.HasValue && SubTotal.HasValue;
        }

        private bool ValidarPagos()
        {
            bool valido = true;

            bool totalPagosValido =  !(TotalPagos() != TotalPagar);

            if (!totalPagosValido)
            {
                this.UserControlErrorProvider.SetError(TxtTotalPagar,"El total de pagos no coincide con el total a pagar");
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
                this.UserControlErrorProvider.SetError(TxtSenasDisp, string.Format("La sena no puede ser mayor a {0:c2}",this._senaTotal));
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

        private void TxtSenas_TextChanged(object sender, EventArgs e)
        {
            //ActualizarTotal();
            //OnSeñaChanged();
        }

        private void OnSeñaChanged()
        {
            if (SeñaChanged != null)
            {
                SeñaChanged(this,null);
            }
        }

        private void TxtTotalPagar_TextChanged(object sender, EventArgs e)
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

        public void GenerarPagoAutoNuevo(decimal? monto, FormaPago tipoPago)
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
        #endregion

        private void TxtSenas_KeyUp_1(object sender, KeyEventArgs e)
        {
            ActualizarTotal();
            OnSeñaChanged();
        }

        
    }
}
