using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Helpers;
using Framework.Comun.Utility;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class UcCuentaCorrienteInfo : UserControlBase
    {
        public UcCuentaCorrienteInfo()
        {
            InitializeComponent();
        }

        public event EventHandler<decimal?> AnticipoChanged;
        public event EventHandler CuotasChanged;

        #region Propiedades
        public decimal? Anticipo
        {
            get
            {
                decimal anticipo;
                return decimal.TryParse(TxtAnticipo.Text, out anticipo) ? anticipo : (decimal?)null;
            }
            set
            {
                TxtAnticipo.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public decimal? Adeuda
        {
            get
            {
                decimal adeuda;
                return decimal.TryParse(TxtAdeuda.Text, out adeuda) ? adeuda : (decimal?)null;
            }
            set
            {
                TxtAdeuda.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public int? Cuotas
        {
            get
            {
                int cuotas;
                return int.TryParse(TxtCantidadCuotas.Text, out cuotas) ? cuotas : (int?)null;
            }
            set
            {
                TxtCantidadCuotas.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        public DateTime Vencimiento
        {
            get
            {
                return DateTime.Parse(DTPVencimiento.Text);
            }
            set
            {
                DTPVencimiento.Value = DateTime.Now.AddMonths(1);
            }
        }

        public float? Montocuota
        {
            get
            {
                float monto;
                return float.TryParse(TxtMontoCuota.Text, out monto) ? monto : (float?)null;
            }
            set
            {
                TxtMontoCuota.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
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
            }
        }
        public decimal? Total
        {
            get
            {
                decimal total;
                return decimal.TryParse(TxtTotal.Text, out total) ? total : (decimal?)null;
            }
            set
            {
                TxtTotal.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }
        #endregion

        #region Eventos

        private void OnAnticipoChanged(decimal? monto)
        {
            if (AnticipoChanged != null)
            {
                AnticipoChanged(this, monto);
            }
        }

        private void OnCuotasChanged()
        {
            if (CuotasChanged != null)
            {
                CuotasChanged(this, null);
            }
        }

        #endregion

        public void ActualizarInfoCuentaCorriente(Cliente cliente)
        {

        }

        private void TxtAnticipo_TextChanged(object sender, EventArgs e)
        {
            if (Anticipo <= Adeuda)
                Adeuda = Total - Anticipo;
            if (Anticipo == 0 || Anticipo == null)
                Adeuda = Total;

            OnAnticipoChanged(Anticipo);
        }

        private void TxtCantidadCuotas_TextChanged(object sender, EventArgs e)
        {
            if (TxtCantidadCuotas.Text != "0" && Adeuda != null && Cuotas != null)
            {
                CalcularCuotas();
                OnCuotasChanged();
            }
        }

        private void CalcularCuotas()
        {
            var listadoCuotas = PaymentHelper.Divide((decimal) Adeuda, Cuotas ?? 1).ToArray();
            Montocuota = (float?) listadoCuotas.First();
            SubTotal = listadoCuotas.Sum();
        }

        private void TxtAdeuda_TextChanged(object sender, EventArgs e)
        {
            if (Adeuda != null & Cuotas != null)
            {
                CalcularCuotas();
            }
        }

        private void UcCuentaCorrienteInfo_Load(object sender, EventArgs e)
        {
            TxtCantidadCuotas.Text = "1";
            TxtAnticipo.Text = "0";
        }
    }
}
