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
using LaPaz.Win.Forms.Util;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class UcFiltrosConsignaciones : UserControlBase
    {
        public UcProgressSpinner Spinner
        {
            get { return ucProgressSpinner1; }
        }

        public UcFiltrosConsignaciones()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        public EventHandler Cleaned;
        #endregion

        #region Propiedades

        public Guid? ProveedorId
        {
            get 
            {
                if (CbxProveedor.ProveedorId == Guid.Empty)
                    return null;
                return CbxProveedor.ProveedorId; 
            }
            set { CbxProveedor.ProveedorId = value; }
        }

        public DateTime Desde
        {
            get { return DtpFechaInicio.Value; }
            set { DtpFechaInicio.Value = value; }
        }

        public DateTime Hasta
        {
            get { return DtpFechaFin.Value; }
            set { DtpFechaFin.Value = value; }
        }

        #endregion

        #region Metodos

        private void UcFiltrosConsignaciones_Load(object sender, EventArgs e)
        {
            ReiniciarFiltros();
        }

        public void ReiniciarFiltros()
        {
            CbxProveedor.ProveedorId = null;
            DtpFechaFin.Value = DateTime.Now;
            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
        }

        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void OnCleaned()
        {
            if (Cleaned != null)
            {
                Cleaned(this, new EventArgs());
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            ReiniciarFiltros();
            OnCleaned();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        #endregion
    }
}
