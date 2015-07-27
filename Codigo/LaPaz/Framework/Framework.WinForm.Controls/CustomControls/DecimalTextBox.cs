using System.Globalization;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Framework.WinForm.Controls.CustomControls
{
    public partial class DecimalTextBox : RadTextBox
    {
        const string NUMBER_FORMAT_2_DIGITS = "N2";

        public bool AceptaNegativos { get; set; }

        public DecimalTextBox()
        {
            InitializeComponent();

            this.KeyPress += OnKeyPress;
            this.Validating += DecimalTextBox_Validating;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs keyPressEventArgs)
        {
            var decimalSeparator = Convert.ToChar(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

            if (keyPressEventArgs.KeyChar == Convert.ToChar(22))
            {
                return;
            }

            if (keyPressEventArgs.KeyChar == '.')
            {
                keyPressEventArgs.KeyChar = decimalSeparator;
            }

            if (!char.IsNumber(keyPressEventArgs.KeyChar)
                && ((Keys)keyPressEventArgs.KeyChar != Keys.Back)
                && (keyPressEventArgs.KeyChar != decimalSeparator))
            {
                if (AceptaNegativos && Text == string.Empty && keyPressEventArgs.KeyChar == '-')
                    return;
                keyPressEventArgs.Handled = true;
            }
                

            if (keyPressEventArgs.KeyChar == decimalSeparator && Text.IndexOf(decimalSeparator) > 0)
                keyPressEventArgs.Handled = true;
        }

        protected override void OnGotFocus(EventArgs e)
        {
            SelectValueOnFocus();
            base.OnGotFocus(e);
        }

        private void SelectValueOnFocus()
        {
            if (IsDecimal())
            {
                if (!IsDecimalZero())
                    return;
            }
            this.SelectAll();
        }

        public bool IsDecimal()
        {
            decimal result;
            return decimal.TryParse(Text, out result);
        }

        private bool IsDecimalZero()
        {
            return (decimal.Parse(Text) == 0);
        }

        private void DecimalTextBox_Validating(object sender, CancelEventArgs e)
        {
            decimal value;
            Text = decimal.TryParse(Text, out value) ? value.ToString(NUMBER_FORMAT_2_DIGITS) : string.Empty;
        }

        public decimal? Value
        {
            get
            {
                decimal result;
                return decimal.TryParse(Text, out result)? result : (decimal?)null;
            }
        }
    }
}
