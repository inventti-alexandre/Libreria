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
    public partial class FrmTarjetasChequesYDepositos : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;

        public FrmTarjetasChequesYDepositos(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;

            InitializeComponent();
        }

        private void FrmTarjetasChequesYDepositos_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            DtpFechaInicio.Value = DateTime.Now;
            DtpFechaFin.Value = DateTime.Now;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\TarjetasChequesYDepositos.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var inicio = SetTimeToZero(DtpFechaInicio.Value);
            var fin = SetTimeToZero(DtpFechaFin.Value.AddDays(1));
            var sucursalId = Context.SucursalActual.Id;

            Guid? operadorId = ucFiltroOperadores.OperadorId;
            var operador = operadorId == null
                               ? "TODOS"
                               : ucFiltroOperadores.Operador.Usuario;

            var datos = _reporteNegocio.TarjetasChequesYDespositos(inicio, fin, sucursalId, operadorId);
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReporteDataset", datos));

            var sucursal = Context.SucursalActual.Nombre;
            var fecha = DateTime.Now.ToShortDateString();
            var hora = DateTime.Now.ToShortTimeString();
            
                
            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("Sucursal", sucursal),
                                    new ReportParameter("SucursalId", sucursalId.ToString()),
                                    new ReportParameter("Fecha", fecha),
                                    new ReportParameter("Hora", hora),
                                    new ReportParameter("Desde", DtpFechaInicio.Value.ToShortDateString()),
                                    new ReportParameter("Hasta", DtpFechaFin.Value.ToShortDateString()),
                                    new ReportParameter("OperadorNombre", operador)
                                };
            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        private DateTime SetTimeToZero(DateTime fecha)
        {
            return new DateTime(fecha.Year, fecha.Month, fecha.Day, 0, 0, 0);
        }
    }
}
