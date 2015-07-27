using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Extentensions;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Helpers;
using Microsoft.Reporting.WinForms;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Reportes
{
    public partial class FrmMultiRanking : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;
        private Guid _tituloId;

        public FrmMultiRanking(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;

            InitializeComponent();
        }

        public Guid TituloId
        {
            get { return _tituloId; }
            set { _tituloId = value; }
        }

        private void FrmClientesPorTitulo_Load(object sender, EventArgs e)
        {
            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            DtpFechaFin.Value = DateTime.Now;
            CbxColumnas.SelectedIndex = 0;
            CbxTipoRanking.SelectedIndex = 0;
        }

        private void Refresh()
        {
            this.Cursor = Cursors.WaitCursor;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\MultiRanking.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var inicio = DtpFechaInicio.Value.AbsoluteStart();
            var fin = DtpFechaFin.Value.AbsoluteEnd();
            var tipo = CbxTipoRanking.Text;
            var col = CbxColumnas.SelectedIndex != 0;
            var cantFilas = (TxtCantidadFilas.Text == null ? 10 : Convert.ToInt32(TxtCantidadFilas.Text));

            var multi = _reporteNegocio.ReporteMultiRanking(tipo, inicio, fin, this.Context.SucursalActual.Id, col, cantFilas);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ds", multi));

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("TipoRanking", tipo),
                                    new ReportParameter("SucursalId", this.Context.SucursalActual.Id.ToString()),
                                    new ReportParameter("FechaInicio", inicio.ToShortDateString()),
                                    new ReportParameter("FechaFin", fin.ToShortDateString()),
                                    new ReportParameter("CantidadFilas", cantFilas.ToString()),
                                    new ReportParameter("MuestraCantidad", col.ToString())
                                };

            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void reportViewer1_ReportRefresh(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Refresh();
        }
    }
}
