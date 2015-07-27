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
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroTiposComprobantes : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<TipoComprobante> SeleccionarFinished;

        private TipoComprobante _tipoComprobante;
        public TipoComprobante getTiposComprobante
        {
            get { return _tipoComprobante; }
        }

        public TipoComprobanteEnum? TipoComprobanteId()
        {
            if (Combo.SelectedValue == null)
                return null;
            TipoComprobanteEnum _result;
            Enum.TryParse(Combo.SelectedValue.ToString(), out _result);
            return _result;
        }

        public TipoComprobanteEnum? TipoComprobante
        {
            get
            {
                var tipoComprobanteSeleccionado = (int)Combo.SelectedValue;

                if (tipoComprobanteSeleccionado == 0)
                    return null;

                TipoComprobanteEnum tipoComprobante;
                Enum.TryParse(tipoComprobanteSeleccionado.ToString(), out tipoComprobante);
                return tipoComprobante;
            }
            set { Combo.SelectedValue = value.HasValue ? (int)value : 0; }
        }

        public void Set(TipoComprobanteEnum Id)
        {
            Combo.SelectedValue = Id;
        }

        public UcFiltroTiposComprobantes()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void UcFiltrTiposGasto_Load(object sender, EventArgs e)
        {
        }

        public void CargarTiposComprobantes()
        {
            _limpiandoFiltros = true;

            var tiposComprobantes = Uow.TiposComprobantes.Listado().OrderBy(t => t.Nombre).ToList();
            tiposComprobantes.Insert(0, new TipoComprobante() { Nombre = "SELECCIONE COMPROBANTE" });
            Combo.DataSource = tiposComprobantes;
            DefinirCombo();

            _limpiandoFiltros = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void OnSeleccionarTipoComprobanteFinished(TipoComprobante tipoComprobante)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, tipoComprobante);
            }
        }

        private void SeleccionarTipoComprobante()
        {
            _tipoComprobante = TipoComprobanteId().HasValue
                                   ? Uow.TiposComprobantes.Obtener(
                                       p => p.Id == (TipoComprobanteEnum)Combo.SelectedValue)
                                   : null;

            OnSeleccionarTipoComprobanteFinished(_tipoComprobante);

        }

        private void Combo_SelectedIndexChanged(object sender, Telerik.WinControls.UI.Data.PositionChangedEventArgs e)
        {
            if (!_limpiandoFiltros)
                SeleccionarTipoComprobante();
        }

        public void Reset()
        {
            Combo.SelectedIndex = 0;
        }
    }
}
