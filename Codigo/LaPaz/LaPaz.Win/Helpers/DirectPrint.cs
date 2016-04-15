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
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Forms;
using Microsoft.Reporting.WinForms;

namespace LaPaz.Win.Helpers
{
    public class DirectPrint
    {
        private string _descripcion;
        private string _formaPago;
        private string _recargo;
        private ReportViewer RptFacturaVenta;
        private ILaPazUow Uow;

        public DirectPrint(ILaPazUow uow)
        {
            Uow = uow;
        }

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        public string FormaPago
        {
            get { return _formaPago; }
            set { _formaPago = value; }
        }

        public string Recargo
        {
            get { return _recargo; }
            set { _recargo = value; }
        }

        public bool RecargarDetalle { get; set; }

        public void GenerarFactura(Guid ventaId)
        {
            RptFacturaVenta = new ReportViewer();
            var uowFactory = Ioc.Container.Get<IUowFactory>();
            var venta = Uow.Ventas.Obtener(v => v.Id == ventaId, v => v.CondicionesVenta);

            var factura = venta.NumeroComprobante.ToString();
            var fecha = venta.FechaComprobante.ToString();
            var cliente = Uow.Clientes.Obtener(c => c.Id == venta.ClienteId, c => c.Provincia, c => c.Localidad);
            var clienteNombre = "Cliente: " + cliente.Denominacion;
            var DNI = "Cuit/DNI: " + cliente.Cuit;
            var dom = cliente.Domicilio.TrimEnd(' ');
            var domicilio = "Domicilio: " + dom;
            var localidad = "Localidad: ---";
            if (cliente.Localidad !=null)
                 localidad = " Localidad: " + cliente.Localidad.Nombre.TrimEnd(' ');

            var condicionVenta = venta.CondicionesVenta.Nombre;

            //this.Cursor = Cursors.WaitCursor;
            RptFacturaVenta.LocalReport.DataSources.Clear();
            RptFacturaVenta.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\FacturaVenta.rdl";
            RptFacturaVenta.LocalReport.ReportPath = appPath + reportPath;

            var lineasFactura = Uow.Reportes.FacturaByVentaId(ventaId);

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
            //------------
            //Exporto a PDF
            //------------
            Warning[] warnings;
            string[] streamids;
            string mimeType;
            string encoding;
            string extension;

            byte[] bytes = RptFacturaVenta.LocalReport.Render(
               "PDF", null, out mimeType, out encoding,
                out extension,
               out streamids, out warnings);

            //GRABO EL PDF
            FileStream fs = new FileStream(string.Format(@"{0}\venta.pdf", Application.StartupPath),
               FileMode.Create);
            fs.Write(bytes, 0, bytes.Length);
            fs.Close();

            //MANDO DIRECTAMENTE A LA iMPRESORA
            SendToPrinter(string.Format(@"{0}\venta.pdf", Application.StartupPath));

            //Elimino pdf temproral
            if (File.Exists(string.Format(@"{0}\venta.pdf", Application.StartupPath)))
            {
                File.Delete(string.Format(@"{0}\venta.pdf", Application.StartupPath));
            }
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

        private void SendToPrinter(string pathFile)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = string.Format(@"{0}", pathFile);
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;

            Process p = new Process();
            p.StartInfo = info;
            p.Start();

            p.WaitForInputIdle();
            System.Threading.Thread.Sleep(3000);
            if (false == p.CloseMainWindow())
                p.Kill();
        }
    }
}
