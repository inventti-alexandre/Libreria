using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Win.Forms.Util;

namespace LaPaz.Win.Helpers
{
    public static class ProgresoHelper
    {
        private static Form Container { get; set; }

        private static FrmProgreso _form;

        public static void MostrarProgreso()
        {
            _form.Show();
        }

        public static void EsconderProgreso()
        {
            if (_form != null)
            {
                _form.Hide();
            }
        }

        internal static void Inicializar(Forms.FrmPrincipal frmPrincipal)
        {
            Container = frmPrincipal;
            _form = new FrmProgreso();
        }
    }
}
