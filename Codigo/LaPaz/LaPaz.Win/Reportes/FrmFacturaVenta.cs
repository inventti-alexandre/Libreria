using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Forms;
using Microsoft.Reporting.WinForms;

namespace LaPaz.Win.Reportes
{
    public partial class FrmFacturaVenta : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Guid _ventaId;
        public string _descripcion;
        public string _formaPago;
        public string _recargo;

        public FrmFacturaVenta(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _ventaId = id;

            InitializeComponent();
        }

        public bool RecargarDetalle { get; set; }

        private void FormFacturaVenta_Load(object sender, EventArgs e)
        {
            GenerarFactura();
            this.RptFacturaVenta.RefreshReport();
        }

        public void GenerarFactura()
        {
            var venta = Uow.Ventas.Obtener(v => v.Id == _ventaId, v => v.CondicionesVenta);

            var factura = venta.NumeroComprobante.ToString();
            var fecha = venta.FechaComprobante.ToString();
            var cliente = Uow.Clientes.Obtener(c => c.Id == venta.ClienteId, c => c.Provincia, c => c.Localidad);
            var clienteNombre = "Cliente: " + cliente.Denominacion;
            var DNI = "Cuit/DNI: " + cliente.Cuit;
            var dom = cliente.Domicilio.TrimEnd(' ');
            var domicilio = "Domicilio: " + dom;
            var localidad = " Localidad: " + cliente.Localidad.Nombre.TrimEnd(' ');
            var condicionVenta = venta.CondicionesVenta.Nombre;

            this.Cursor = Cursors.WaitCursor;
            RptFacturaVenta.LocalReport.DataSources.Clear();
            RptFacturaVenta.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\FacturaVenta.rdl";
            RptFacturaVenta.LocalReport.ReportPath = appPath + reportPath;

            var lineasFactura = Uow.Reportes.FacturaByVentaId(_ventaId);

            RptFacturaVenta.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lineasFactura));

            if (RecargarDetalle)
            {
                CargarDetalle(venta);
            }

            var parametros = new List<ReportParameter>
                                 {
                                     new ReportParameter("Fecha", fecha),
                                     new ReportParameter("FaacturaNro", factura),
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

        private void CargarDetalle(Venta venta)
        {
            _descripcion = string.Empty;
            _formaPago = string.Empty;
            //_recargo = venta.Recargo;

            var cajaMovimiento = Uow.CajaMovimientos.Obtener(cm => cm.ComprobanteId == venta.Id);
            if (cajaMovimiento != null)
            {
                if (cajaMovimiento.Senia.HasValue)
                {
                    _descripcion += "Seña  $" + cajaMovimiento.Senia + ". ";
                }

                if (cajaMovimiento.Efectivo.HasValue)
                {
                    _formaPago += "Efectivo $" + cajaMovimiento.Efectivo + ". ";
                }

                if (cajaMovimiento.Tarjeta.HasValue)
                {
                    var tarjetasMovimientos =
                        Uow.TarjetasMovimientos.Listado(tm => tm.Tarjeta).Where(tm => tm.CajaMovimientoId == cajaMovimiento.Id).ToList();

                    foreach (var tarjetasMovimiento in tarjetasMovimientos)
                    {
                        _formaPago += "Tarjeta " + tarjetasMovimiento.Tarjeta.Nombre + " $" + tarjetasMovimiento.Importe + ". ";
                    }
                }

                if (cajaMovimiento.Cheque.HasValue)
                {
                    var chequesTerceros =
                        Uow.ChequesTercero.Listado(ch => ch.Banco).Where(ch => ch.CajaMovimientoId == cajaMovimiento.Id);

                    foreach (var chequeTercero in chequesTerceros)
                    {
                        _formaPago += "Cheque " + chequeTercero.Banco.Nombre + " $" + chequeTercero.Importe + ". ";
                    }
                }

                if (cajaMovimiento.Deposito.HasValue)
                {
                    var cuentasMovimientos =
                        Uow.CuentasMovimientos.Listado(ch => ch.Cuenta).Where(ch => ch.ComprobanteId == venta.Id);

                    foreach (var cuentasMovimiento in cuentasMovimientos)
                    {
                        _formaPago += "Deposito " + cuentasMovimiento.Cuenta.Nombre + " $" + cuentasMovimiento.Credito + ". ";
                    }
                }
            }

            var cuotas = Uow.ClientesCuentasCorrientes.Listado().Where(cc => cc.VentaId == venta.Id).ToList();

            if (cuotas.Any())
            {
                var cantidadCuotas = cuotas.Count;
                var montoCuotas = cuotas.First().Importe;

                _descripcion += "Cuotas: " + cantidadCuotas + " de: $" + montoCuotas;
            }

            if (venta.CondicionVentaId == CondicionVentaEnum.CuentaCorriente && cajaMovimiento != null)
            {
                //Si es anticipo va adelante de todo.
                _descripcion = "Anticipo $" + cajaMovimiento.Importe + ". " + _descripcion;
            }
        }
    }
}
