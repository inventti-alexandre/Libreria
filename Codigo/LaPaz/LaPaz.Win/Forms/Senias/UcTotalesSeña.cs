using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Helpers;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Ventas;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Senias
{
    public partial class UcTotalesSenia : UserControlBase
    {
        #region Fields
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private IList<VentaPago> _pagos = new List<VentaPago>();
        private decimal? _senaTotal;
        private decimal? _creditoDevolucionTotal; 
        #endregion

        public UcTotalesSenia()
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

        #region Propiedades

        public IList<VentaPago> Pagos
        {
            get { return _pagos; }
        }

        public string FormasDePagosParaComprobante 
        {
            get { return FormaPagoHelper.FormaPagoComprobante(this.Pagos); }
        }

        public bool HayPagosConCajaAnterior
        {
            get
            {
                decimal? efectivoCajaAnterior = 0;

                foreach (var pago in this.Pagos)
                {
                    switch (pago.TipoPago)
                    {
                        case FormaPago.EfectivoCajaAnterior:
                            efectivoCajaAnterior += pago.Importe;
                            break;
                    }
                }

                return efectivoCajaAnterior > 0;
            }
        }


        public decimal? TotalPagar
        {
            get
            {
                decimal totalPagar;
                return decimal.TryParse(TxtTotal.Text, out totalPagar) ? totalPagar : (decimal?)null;
            }
            set
            {
                TxtTotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }


        #endregion

        #region Metodos

        private void UcTotalesVenta_Load(object sender, EventArgs e)
        {
            RefrescarPagos();
        }

        private void BtnAgregarPago_Click(object sender, EventArgs e)
        {
            using (var formAgregarPago = FormFactory.Create<FrmAgregarPago>(Guid.Empty, ActionFormMode.Edit))
            {
                formAgregarPago.PermitirPagoEfectivo = false;
                formAgregarPago.PagoAgregado += (o, pago) =>
                {
                    Pagos.Add(pago);
                    RefrescarPagos();

                    formAgregarPago.Close();
                };

                formAgregarPago.ShowDialog(); 
            }
        }

        public void RefrescarPagos()
        {
            GrillaPagos.DataSource = Pagos.ToList();
            TotalPagar = Pagos.ToList().Sum(p => p.Importe);
            OnTotalAPagarChanged(TotalPagar);
        }

        private void OnTotalAPagarChanged(decimal? monto)
        {
            if (TotalAPagarChanged != null)
            {
                TotalAPagarChanged(this, monto);
            }
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

        private void TxtTotal_TextChanged(object sender, EventArgs e)
        {
            OnTotalAPagarChanged(TotalPagar);
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

        #endregion
    }
}
