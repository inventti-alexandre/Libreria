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

namespace LaPaz.Win.Presupuesto
{
    public partial class FrmComprobantePresupuesto : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Guid _presupuestoId;
        public string _descripcion = "";
        public string _formaPago = "";
        public string _recargo = "";

        public FrmComprobantePresupuesto(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _presupuestoId = id;
            InitializeComponent();
        }

        private void FormFacturaVenta_Load(object sender, EventArgs e)
        {
            GenerarFactura();
            this.RptFacturaVenta.RefreshReport();
        }

        public void GenerarFactura()
        {

            var presupuesto = Uow.Presupuesto.Obtener(p => p.Id == _presupuestoId);
            var lcn = presupuesto.LCN;
            var fecha = presupuesto.Fecha.ToString();
            var cliente = Uow.Clientes.Obtener(c => c.Id == presupuesto.ClienteId, c => c.Provincia, c => c.Localidad);
            var clienteNombre = cliente.Denominacion;
            var DNI = cliente.Cuit;
            var dom = cliente.Domicilio.TrimEnd(' ');
            var domicilio = dom;
            var localidad = cliente.Localidad.Nombre.TrimEnd(' ');
            var condicionVenta = "";


            this.Cursor = Cursors.WaitCursor;
            RptFacturaVenta.LocalReport.DataSources.Clear();
            RptFacturaVenta.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");

            string reportPath = "";
            if (Context.SucursalActual.Id==2)
                reportPath = @"\RDLS\ComprobantePresupuesto.rdl";
            else
            {
                if (Context.SucursalActual.Id==27)
                    reportPath = @"\RDLS\ComprobantePresupuestoVecinito.rdl";
            }
            RptFacturaVenta.LocalReport.ReportPath = appPath + reportPath;

            var lineasPresupuesto = Uow.Reportes.PresupuestoById(_presupuestoId);

            RptFacturaVenta.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lineasPresupuesto));

            var parametros = new List<ReportParameter>
                             {
                                 new ReportParameter("Fecha", fecha),
                                 new ReportParameter("FaacturaNro", lcn),
                                 new ReportParameter("Cliente", clienteNombre),
                                 new ReportParameter("Domicilio", domicilio),
                                 new ReportParameter("DescripcionPago", _descripcion),
                                 new ReportParameter("DNI", DNI),
                                 new ReportParameter("Localidad", localidad),
                                 new ReportParameter("CondicionVenta", condicionVenta),
                                 new ReportParameter("FormaPago", _formaPago),
                                 new ReportParameter("Recargo", _recargo)
                             };

            RptFacturaVenta.LocalReport.SetParameters(parametros);
            this.RptFacturaVenta.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
