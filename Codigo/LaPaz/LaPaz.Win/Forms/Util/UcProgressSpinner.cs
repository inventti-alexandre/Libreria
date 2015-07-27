using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcProgressSpinner : UserControlBase
    {
        public UcProgressSpinner()
        {
            InitializeComponent();
        }

        public void Show()
        {
            label1.Visible = true;
            pictureBox1.Visible = true;
        }

        public void Hide()
        {
            label1.Visible = false;
            pictureBox1.Visible = false;
        }
    }
}
