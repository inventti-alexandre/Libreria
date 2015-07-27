using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcTotalesCompra : UserControlBase
    {
        public UcTotalesCompra()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }
            InitializeComponent();
        }

        #region Propiedades

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

      }
}
