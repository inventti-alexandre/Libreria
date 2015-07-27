using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
    public partial class FrmClientesPorTitulo : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;
        private Guid _tituloId;

        public FrmClientesPorTitulo(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
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
            DtpFechaInicio.Value = DateTime.Now.AddDays(-30);
            DtpFechaFin.Value = DateTime.Now;
            Refresh();
        }

        private void Refresh()
        {
            this.Cursor = Cursors.WaitCursor;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\ClientesPorTitulo.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var inicio = SetTimeToZero(DtpFechaInicio.Value);
            var fin = SetTimeToZero(DtpFechaFin.Value.AddDays(1));

            var titulos = _reporteNegocio.ReporteClientesPorTitulo(_tituloId, inicio, fin, this.Context.SucursalActual.Id);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ds", titulos));

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("FechaDesde", DtpFechaInicio.Value.Date.ToShortDateString()),
                                    new ReportParameter("FechaHasta", DtpFechaFin.Value.Date.ToShortDateString())
                                };

            reportViewer1.LocalReport.SetParameters(parametros);

            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
           Refresh();
        }

        private DateTime SetTimeToZero(DateTime fecha)
        {
            fecha = fecha.AddDays(-1);
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, 23, 59, 59);
        }

        private void reportViewer1_ReportRefresh(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Refresh();
        }
    }
}
