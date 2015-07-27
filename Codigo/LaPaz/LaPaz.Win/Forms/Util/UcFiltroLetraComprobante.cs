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
    public partial class UcFiltroLetraComprobante : UserControlBase
    {
        private bool _cargandoLetraComprobante;

        public UcFiltroLetraComprobante()
        {
            InitializeComponent();
        }

        public event EventHandler<string> SeleccionarFinished;

        public string Letra
        {
            get
            {
                var letraSeleccionada = (string)Combo.SelectedValue;

                return !string.IsNullOrEmpty(letraSeleccionada) && letraSeleccionada != "0" ? letraSeleccionada : string.Empty;
            }
            set { Combo.SelectedValue = value ?? "0"; }
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoLetraComprobante)
            {
                OnSeleccionarTipoComprobanteFinished(Letra);
            }
        }

        private void OnSeleccionarTipoComprobanteFinished(string letra)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, letra);
            }
        }

        private void UcFiltroLetraComprobante_Load(object sender, EventArgs e)
        {

        }

        public void CargarLetrasComprobantes()
        {
            _cargandoLetraComprobante = true;

            var lista = new[]
                                   {
                                       new {Id = "0", Descripcion = "SELECCIONE LETRA"},
                                       new {Id = "A", Descripcion = "A"},
                                       new {Id = "B", Descripcion = "B"},
                                       new {Id = "C", Descripcion = "C"},
                                       new {Id = "R", Descripcion = "R"}
                                   };
            Combo.DataSource = lista;
            Combo.DisplayMember = "Descripcion";
            Combo.ValueMember = "Id";

            _cargandoLetraComprobante = false;
        }
    }
}
