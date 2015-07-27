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
    public partial class FrmMovimientosCajaAnterior : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;

        public FrmMovimientosCajaAnterior(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;

            InitializeComponent();
        }

        private void FrmInformeCaja_Load(object sender, EventArgs e)
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
            string reportPath = @"\RDLS\MovimientosCajaAnterior.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            Guid? operadorId = ucFiltroOperadores.OperadorId;

            var operador = operadorId == null
                               ? "TODOS"
                               : ucFiltroOperadores.Operador.Usuario;

            var inicio = SetTimeToZero(DtpFechaInicio.Value);
            var fin = SetTimeToZero(DtpFechaFin.Value.AddDays(1));
            var datos = _reporteNegocio.MovimientosCajaAnterior(inicio, fin, Context.SucursalActual.Id, operadorId);
            var egresos = datos.Where(x => x.Tipo == "Egresos").ToList();


            var totales = new TotalesEgresosDatasetRow()
                              {
                                  EgresosTotal = (decimal)egresos.Sum(eg => eg.Total)
                              };

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Egresos", egresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Totales", new List<TotalesEgresosDatasetRow> { totales }));

            var sucursal = Context.SucursalActual.Nombre;
            var fecha = DateTime.Now.ToShortDateString();
            var hora = DateTime.Now.ToShortTimeString();
            var sucursalId = Context.SucursalActual.Id;
                
            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("Sucursal", sucursal),
                                    new ReportParameter("SucursalId", sucursalId.ToString()),
                                    new ReportParameter("Fecha", fecha),
                                    new ReportParameter("Hora", hora),
                                    new ReportParameter("Desde", DtpFechaInicio.Value.ToShortDateString()),
                                    new ReportParameter("Hasta", DtpFechaFin.Value.ToShortDateString()),
                                    new ReportParameter("Operador", operador)
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

    public class TotalesEgresosDatasetRow
    {
        public decimal EgresosTotal { get; set; }
        public decimal EgresosFacturado { get; set; }
    }
}
