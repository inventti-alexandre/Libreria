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
    public partial class FrmConsignacionesVendidas : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;

        public FrmConsignacionesVendidas(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;

            InitializeComponent();
        }

        private void FrmConsignacionesVendidas_Load(object sender, EventArgs e)
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
            string reportPath = @"\RDLS\ConsignacionesVendidas.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            Guid? operadorId = ucFiltroOperadores.OperadorId;

            var operador = operadorId == null
                               ? "TODOS"
                               : ucFiltroOperadores.Operador.Usuario;

            int? proveedorCod = null;
            if (!string.IsNullOrEmpty(txtCodProveedor.Text))
            {
                proveedorCod = Convert.ToInt32(txtCodProveedor.Text);
            }

            var inicio = SetTimeToZero(DtpFechaInicio.Value);
            var fin = SetTimeToZero(DtpFechaFin.Value.AddDays(1));

            Guid? proveedorId = null;
            string proveedorNombre = "TODOS";
            var proveedor = CbxProveedor.Proveedor;
            if (proveedor != null)
            {
                proveedorId = proveedor.Id;
                proveedorNombre = proveedor.Denominacion;
            }

            var consignaciones = _reporteNegocio.ConsignacionesVendidas(inicio, fin, Context.SucursalActual.Id, proveedorId, operadorId, proveedorCod);
            
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", consignaciones));

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
                                    new ReportParameter("ProveedorId", proveedorId == null ? string.Empty : proveedorId.ToString()),
                                    new ReportParameter("Proveedor", proveedorNombre),
                                    new ReportParameter("Operador", operador),
                                    new ReportParameter("CodigoProveedor", proveedorCod == null ? "-" : proveedorCod.ToString())
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
