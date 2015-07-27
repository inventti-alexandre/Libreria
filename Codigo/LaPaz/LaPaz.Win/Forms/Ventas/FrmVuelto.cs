using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmVuelto : FormBase
    {
        public FrmVuelto()
        {
            InitializeComponent();
        }

        #region Propiedades

        public decimal? APagar
        {
            get
            {
                decimal Apagar;
                return decimal.TryParse(DtxtAPagar.Text, out Apagar) ? Apagar : 0;
            }
            set { DtxtAPagar.Text = value.ToString(); }
        }

        public decimal? Paga
        {
            get
            {
                decimal pagar;
                return decimal.TryParse(DTxtPaga.Text, out pagar) ? pagar : 0;
            }
            set { DTxtPaga.Text = value.ToString(); }
        }

        public decimal? Vuelto
        {
            get
            {
                decimal vuelto;
                return decimal.TryParse(DtxtVuelto.Text, out vuelto) ? vuelto : 0;
            }
            set { DtxtVuelto.Text = value.ToString(); }
        }
        #endregion

        private void DTxtPaga_TextChanged(object sender, EventArgs e)
        {
            CalcularVuelto();
        }

        private void CalcularVuelto()
        {
            Vuelto = Paga - APagar;
        }

        private void DtxtAPagar_TextChanged(object sender, EventArgs e)
        {
            CalcularVuelto();
        }

        private void DtxtAPagar_KeyDown(object sender, KeyEventArgs e)
        {
            CalcularVuelto();
            OnEnterPressed(e);
        }

        private void DTxtPaga_KeyDown(object sender, KeyEventArgs e)
        {
            CalcularVuelto();
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                this.Close();
            }
        }

        private void DtxtVuelto_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }
    }
}
