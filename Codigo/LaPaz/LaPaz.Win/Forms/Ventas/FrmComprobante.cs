using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using Microsoft.Reporting.WinForms;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmComprobante : FormBase
    {
        public string _LCN = "";
        public string _montoTexto;
        public string _concepto;
        public string _formaPago;
        public decimal? _montoActualizado = 0;

        public FrmComprobante(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow)
        {
            Uow = uow;
            InitializeComponent();
        }

        private void FrmComprobante_Load(object sender, EventArgs e)
        {
            GenerarComprobante();

            //Imprimir();
        }

        //private void Imprimir()
        //{
        //    PrintDocument printDoc = new PrintDocument();
        //    printDoc.PrinterSettings.PrinterName=
        //}

        private void GenerarComprobante()
        {
            this.Cursor = Cursors.WaitCursor;
            RtvComprobante.LocalReport.DataSources.Clear();
            RtvComprobante.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = "";
            if (_montoActualizado == 0)
                reportPath = @"\RDLS\ClienteMontoFavor.rdl";
            else
            {
                reportPath = @"\RDLS\ClienteMontoFavorActulizacion.rdl";
            }

            RtvComprobante.LocalReport.ReportPath = appPath + reportPath;

            var datos = Uow.Reportes.ClienteMontoFavorByLcn(_LCN);

            RtvComprobante.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", datos));
            var parametros = new List<ReportParameter>
                             {
                                 new ReportParameter("MontoTexto", _montoTexto),
                                 new ReportParameter("lcn", _LCN),
                                 new ReportParameter("Concepto", _concepto),
                                 new ReportParameter("MontoActualizado", _montoActualizado.ToString()),
                                 new ReportParameter("FormaPago", _formaPago)
                             };

            RtvComprobante.LocalReport.SetParameters(parametros);
            this.RtvComprobante.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
