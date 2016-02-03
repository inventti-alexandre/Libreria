using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Forms;
using Microsoft.Reporting.WinForms;

namespace LaPaz.Win.ProveedoresDevolucion
{
    public partial class FrmComprobanteDevolucion : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Guid _comprobaneId;
       

        public FrmComprobanteDevolucion(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _comprobaneId = id;
            InitializeComponent();
        }

        private void FormFacturaVenta_Load(object sender, EventArgs e)
        {
            GenerarComprobante();
            this.RptComprobante.RefreshReport();
        }

        public void GenerarComprobante()
        {

            var comprobante = Uow.TitulosConsignacionesDevueltas.Obtener(p => p.Id == _comprobaneId);

            this.Cursor = Cursors.WaitCursor;
            RptComprobante.LocalReport.DataSources.Clear();
            RptComprobante.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");

            string reportPath = "";
            if (Context.SucursalActual.Id==2)
                reportPath = @"\RDLS\ComprobanteDevolucion.rdl";
            else
            {
                if (Context.SucursalActual.Id==27)
                    reportPath = @"\RDLS\ComprobanteDevolucionVecinito.rdl";
            }
            RptComprobante.LocalReport.ReportPath = appPath + reportPath;

            var lineasComprobante = Uow.Reportes.DevolucionById(_comprobaneId);

            RptComprobante.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lineasComprobante));

            var parametros = new List<ReportParameter>
                             {
                                 //new ReportParameter("Recargo", _recargo)
                             };

            //RptComprobante.LocalReport.SetParameters(parametros);
            this.RptComprobante.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
