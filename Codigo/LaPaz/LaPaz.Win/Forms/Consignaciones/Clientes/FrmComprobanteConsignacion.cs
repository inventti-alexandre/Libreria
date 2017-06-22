using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using Microsoft.Reporting.WinForms;

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class FrmComprobanteConsignacion : FormBase
    {
        private Guid _remitoId;
        public string _descripcion;
        public string _formaPago;
        public string _recargo;

        public FrmComprobanteConsignacion(IFormFactory formFactory, ILaPazUow uow, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;

            _remitoId = id;

            InitializeComponent();
        }

        public bool RecargarDetalle { get; set; }

        private void FormFacturaVenta_Load(object sender, EventArgs e)
        {
            GenerarComprobante();
        }

        public void GenerarComprobante()
        {
            var remito = Uow.RemitosVentas.Obtener(r => r.Id == _remitoId);

            var consignacion = remito.NumeroComprobante.ToString();
            var fecha = remito.FechaComprobante.ToString();
            var cliente = Uow.Clientes.Obtener(c => c.Id == remito.ClienteId, c => c.Provincia, c => c.Localidad);
            //var clienteNombre = "Cliente: " + cliente.Denominacion;
            //var DNI = "Cuit/DNI: " + cliente.Cuit;
            //var dom = cliente.Domicilio.TrimEnd(' ');
            //var domicilio = "Domicilio: " + dom;
            // var localidad = " Localidad: ---" ;
            //if (cliente.Localidad != null)
            //    localidad = " Localidad: " + cliente.Localidad.Nombre.TrimEnd(' ');
            var clienteNombre = cliente.Denominacion;
            var DNI = cliente.Cuit;
            var dom = cliente.Domicilio.TrimEnd(' ');
            var domicilio =  dom;
            var localidad = "";
            if (cliente.Localidad != null)
                localidad =  cliente.Localidad.Nombre.TrimEnd(' ');
            var condicionRemito = "CONSIGNACIÓN";

            this.Cursor = Cursors.WaitCursor;

            RptComprobanteConsignacion.LocalReport.DataSources.Clear();
            RptComprobanteConsignacion.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");   
            string reportPath = "";

            if (Context.SucursalActual.Id==2)
                 reportPath = @"\RDLS\ComprobanteConsignacion.rdl";
            else
            {
                if (Context.SucursalActual.Id==27)
                     reportPath = @"\RDLS\ComprobanteConsignacionVecinito.rdl";
            }
            RptComprobanteConsignacion.LocalReport.ReportPath = appPath + reportPath;

            var lineasConsignacion = Uow.Reportes.ReciboConsignacion(remito.Id);

            RptComprobanteConsignacion.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lineasConsignacion));

            if (RecargarDetalle)
            {
                CargarDetalle(remito);
            }

            var parametros = new List<ReportParameter>
                                 {
                                     new ReportParameter("Fecha", fecha),
                                     new ReportParameter("FacturaNro", consignacion),
                                     new ReportParameter("Cliente", clienteNombre),
                                     new ReportParameter("Domicilio", domicilio),
                                     new ReportParameter("DescripcionPago", _descripcion),
                                     new ReportParameter("DNI", DNI),
                                     new ReportParameter("Localidad", localidad),
                                     new ReportParameter("CondicionVenta", condicionRemito),
                                     new ReportParameter("FormaPago", _formaPago),
                                     new ReportParameter("Recargo", _recargo)
                                 };

            RptComprobanteConsignacion.LocalReport.SetParameters(parametros);
            this.RptComprobanteConsignacion.RefreshReport();

            this.Cursor = Cursors.Default;
        }

        private void CargarDetalle(RemitosVenta remito)
        {
            _descripcion = string.Empty;
            _formaPago = string.Empty;
        }
    }
}
