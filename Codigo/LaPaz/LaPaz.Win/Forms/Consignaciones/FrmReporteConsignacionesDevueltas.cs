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

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class FrmReporteConsignacionesDevueltas : FormBase
    {
        public Guid ProveedorId { get; set; }
        public List<ConsignacionesParaDevolver> Listado { get; set; }
        public DateTime Desde { get; set; }
        public DateTime Hasta { get; set; }

        public FrmReporteConsignacionesDevueltas(ILaPazUow uow, List<ConsignacionesParaDevolver> listado, 
            Guid proveedorId, DateTime desde, DateTime hasta)
        {
            Uow = uow;
            ProveedorId = proveedorId;
            Listado = listado;
            Desde = desde;
            Hasta = hasta;

            InitializeComponent();
        }

        private void FrmReporteConsignaciones_Load(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.ProcessingMode = ProcessingMode.Local;
                string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
                string reportPath = @"\RDLS\DevolucionConsignaciones.rdl";
                reportViewer1.LocalReport.ReportPath = appPath + reportPath;
                reportViewer1.ZoomPercent = 130;

                var proveedor = Uow.Proveedores.Obtener(p => p.Id == ProveedorId);

                reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ReporteDataset", Listado));

                var fecha = DateTime.Now.ToShortDateString();
                var hora = DateTime.Now.ToShortTimeString();


                var parametros = new List<ReportParameter>
                                 {
                                     new ReportParameter("Fecha", fecha),
                                     new ReportParameter("Hora", hora),
                                     new ReportParameter("Desde", Desde.ToShortDateString()),
                                     new ReportParameter("Hasta", Hasta.ToShortDateString()),
                                     new ReportParameter("ProveedorNombre", proveedor.Denominacion)
                                 };

                reportViewer1.LocalReport.SetParameters(parametros);
                this.reportViewer1.RefreshReport();
                this.Cursor = Cursors.Default;
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
            
            
        }
    }
}
