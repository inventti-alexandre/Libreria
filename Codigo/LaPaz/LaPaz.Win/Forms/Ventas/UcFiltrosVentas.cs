using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class UcFiltrosVentas : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosVentas()
        {
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public int? NumeroComprobante
        {
            get
            {
                int cuenta;
                return int.TryParse(TxtNumeroComprobante.Text, out cuenta) ? cuenta : (int?)null;
            }
            set
            {
                TxtNumeroComprobante.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public string TextoABuscar
        {
            get { return TxtTexto.Text; }
            set { TxtTexto.Text = value; }
        }

        public TipoComprobanteEnum? TipoComprobante
        {
            get { return UcFiltroTiposComprobantes.TipoComprobante; }
        }

        public string LetraComprobante
        {
            get { return UcFiltroLetraComprobante.Letra; }
        }

        #endregion

        #region Metodos

        private void UcFiltrosVentas_Load(object sender, EventArgs e)
        {
            //UcFiltroTiposComprobantes.CargarTiposComprobantes();
            //UcFiltroLetraComprobante.CargarLetrasComprobantes();

           // this.UcFiltroTiposComprobantes.SeleccionarFinished += UcFiltroTiposComprobantesOnSeleccionarFinished;
            //this.UcFiltroLetraComprobante.SeleccionarFinished += UcFiltroLetraComprobanteOnSeleccionarFinished;
        }

        private void UcFiltroLetraComprobanteOnSeleccionarFinished(object sender, string s)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void UcFiltroTiposComprobantesOnSeleccionarFinished(object sender, TipoComprobante tipoComprobante)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void TxtTexto_TextChanged(object sender, EventArgs e)
        {
            //if (!_limpiandoFiltros)
            //    OnFiltered();
        }

        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;

            TxtTexto.Text = string.Empty;
            TxtNumeroComprobante.Text = string.Empty;
           // UcFiltroLetraComprobante.Letra = string.Empty;
            //UcFiltroTiposComprobantes.TipoComprobanteId();
            
            _limpiandoFiltros = false;

            OnFiltered();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        #endregion
    }
}
