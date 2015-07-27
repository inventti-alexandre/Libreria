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
using LaPaz.Win.Model;
namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroDesdeHasta : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<DesdeHasta> SeleccionarFinished;
        
        public DateTime Desde
        {
            get { return DtpFechaDesde.Value; }
            set { DtpFechaDesde.Value = value; }
        }

        public DateTime Hasta
        {
            get { return DtpFechaHasta.Value; }
            set { DtpFechaHasta.Value = value; }
        }

        public UcFiltroDesdeHasta()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltroDesdeHasta_Load(object sender, EventArgs e)
        {
           Reset();
        }
        
        private  void OnSelecionarCentroCosto(DesdeHasta desdehasta)
        {
            if (SeleccionarFinished != null)
                SeleccionarFinished(this, desdehasta);
        }

        private void SeleccionarFechas()
        {
            DesdeHasta fechas = new DesdeHasta() {Desde = this.Desde, Hasta = this.Hasta};
            OnSelecionarCentroCosto(fechas);
        }

        public void Reset()
        {
            Desde = DateTime.Today;
            Hasta = DateTime.Today;
        }

        private void DtpFechaDesde_ValueChanged(object sender, EventArgs e)
        {
            DtpFechaHasta.MinDate = Desde;
            if(!_limpiandoFiltros && Desde <= Hasta)
                SeleccionarFechas();
        }

        private void DtpFechaHasta_ValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros && Desde <= Hasta)
                SeleccionarFechas();
        }

    }
}
