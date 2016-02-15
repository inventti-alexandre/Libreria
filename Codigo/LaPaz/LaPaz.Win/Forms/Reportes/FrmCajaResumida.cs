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
    public partial class FrmCajaResumida : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;

        public FrmCajaResumida(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
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
            string reportPath = @"\RDLS\CajaResumida.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var inicio = SetTimeToZero(DtpFechaInicio.Value);
            var fin = SetTimeToZero(DtpFechaFin.Value.AddDays(1));

            Guid? operadorId = ucFiltroOperadores.OperadorId;

            var operador = operadorId == null
                               ? "TODOS"
                               : ucFiltroOperadores.Operador.Usuario;

            var ventas = _reporteNegocio.CajaResumidaVentas(inicio, fin, Context.SucursalActual.Id, operadorId);
            var ingresos = _reporteNegocio.CajaResumidaIngresos(inicio, fin, Context.SucursalActual.Id, operadorId);
            var egresos = _reporteNegocio.CajaResumidaEgresos(inicio, fin, Context.SucursalActual.Id, operadorId);
            var composicionIngresos = _reporteNegocio.CajaResumidaComposicionIngresos(inicio, fin, Context.SucursalActual.Id, operadorId);
            var composicionEgresos = _reporteNegocio.CajaResumidaComposicionEgresos(inicio, fin, Context.SucursalActual.Id, operadorId);
            var composicionVentas = _reporteNegocio.CajaResumidaComposicionVentas(inicio, fin, Context.SucursalActual.Id, operadorId);

            //"Depósitos con Caja Anterior"
            var totales = new EgresosTotalesRow()
            {
                Cantidad = (int)egresos.Where(eg => eg.Nombre != "Depósitos con Caja Anterior").Sum(eg => eg.Cantidad),
                //Total = (int)egresos.Where(eg => eg.Nombre != "Depósitos con Caja Anterior").Sum(eg => eg.Total)
                Total = (decimal)egresos.Where(eg => eg.Nombre != "Depósitos con Caja Anterior").Sum(eg => eg.Total)
            };

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Ventas", ventas));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Ingresos", ingresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("Egresos", egresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ComposicionIngresos", composicionIngresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ComposicionEgresos", composicionEgresos));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ComposicionVentas", composicionVentas));
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("EgresosTotales", new List<EgresosTotalesRow> { totales }));

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

    public class EgresosTotalesRow
    {
        public int Cantidad { get; set; }
        //public int Total { get; set; }
        public decimal Total { get; set; }
    }
}
