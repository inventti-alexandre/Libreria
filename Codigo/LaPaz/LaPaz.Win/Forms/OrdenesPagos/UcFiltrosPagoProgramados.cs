using System;
using System.Linq;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Forms.Util;
namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class UcFiltrosPagoProgramados : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosPagoProgramados()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public DateTime Desde
        {
            get { return ucFiltroDesdeHasta1.Desde; }
        }

        public DateTime Hasta
        {
            get { return ucFiltroDesdeHasta1.Hasta; }
        }

        public bool? Anulados
        {
            get
            {
                switch (CbxSiNo.Value)
                {
                    case SiNoEnum.Si:
                        return true;
                    case SiNoEnum.No:
                        return false;
                    default:
                        return null;
                }
            }
        }

        #endregion

        #region Metodos

        private void UcFiltrosOrdenesPago_Load(object sender, EventArgs e)
        {
            ucFiltroDesdeHasta1.Reset();
            ucFiltroDesdeHasta1.SeleccionarFinished += CambioFechas;
        }

        private void OnFiltered(object sender, object eventArgs)
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void CambioFechas(object sender, DesdeHasta desdehasta)
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;

            ucFiltroDesdeHasta1.Reset();
            CbxSiNo.Reset();

            _limpiandoFiltros = false;

            OnFiltered(sender, e);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered(sender, e);
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                Uow.Dispose();
            }
            base.Dispose(disposing);
        }

        #endregion
    }
}
