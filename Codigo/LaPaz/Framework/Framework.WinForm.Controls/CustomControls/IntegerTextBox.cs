using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace Framework.WinForm.Controls.CustomControls
{
    public partial class IntegerTextBox : RadTextBox
    {
        public IntegerTextBox()
        {
            InitializeComponent();
            this.KeyPress += OnKeyPress;
        }

        private void OnKeyPress(object sender, KeyPressEventArgs e)
        {
            // Ignore all non-control and non-numeric key presses.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
