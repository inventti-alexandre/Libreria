using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Libros
{
    public partial class UcEstadoTitulos : UserControlBase
    {
        public UcEstadoTitulos()
        {
            InitializeComponent();
        }

        private void UcEstadoTitulos_Load(object sender, EventArgs e)
        {
            TitulosConsignadosPanel.BackColor = GridColors.TituloConsignado;
        }
    }
}
