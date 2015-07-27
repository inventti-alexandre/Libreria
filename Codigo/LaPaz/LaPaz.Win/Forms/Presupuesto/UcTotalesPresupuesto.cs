using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Data;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class UcTotalesPresupuesto : UserControlBase
    {
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private IList<VentaPago> _pagos = new List<VentaPago>();
        private decimal? _senaTotal;
        private decimal? _creditoDevolucionTotal;

        public UcTotalesPresupuesto()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
                _messageBoxDisplayService = Ioc.Container.Get<IMessageBoxDisplayService>();
            }

            InitializeComponent();

        }

        public event EventHandler<decimal?> TotalAPagarChanged;
        public event EventHandler<int?> DescuentoChanged;
        public event EventHandler<int?> RecargoChanged;
        public event EventHandler TotalChanged;

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

      #endregion

        #region Metodos

        private void UcTotalesVenta_Load(object sender, EventArgs e)
        {
           
        }

        public decimal TotalPagos()
        {
            return this.Pagos.Sum(p => p.Importe ?? 0);
        }
        
        public bool Validar()
        {
            return ValidarTotales() ;
        }

        private bool ValidarTotales()
        {
            return TotalPagar.HasValue && SubTotal.HasValue;
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
                TotalChanged(this,null);
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
    
    }
}
