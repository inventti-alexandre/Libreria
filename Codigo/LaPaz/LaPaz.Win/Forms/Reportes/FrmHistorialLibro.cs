using LaPaz.Datos.Interfaces;
using LaPaz.Negocio.Interfaces;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Reportes
{
    public partial class FrmHistorialLibro : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;
        public FrmHistorialLibro(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;
            InitializeComponent();
        }

        public string CodigoLibroCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(TxtCodigo1.Text) || string.IsNullOrEmpty(TxtCodigo2.Text))
                    return null;
                return String.Format("{0}{1}", CompleteWithZeros(TxtCodigo1.Text, 4), (TxtCodigo2.Text));
                //return String.Format("{0}{1}", CompleteWithZeros(TxtCodigo1.Text, 4), CompleteWithZeros(TxtCodigo2.Text, 13));
            }
            set
            {
                TxtCodigo2.Text = value;
                TxtCodigo1.Text = value;
            }
        }

        private string CompleteWithZeros(string text, int length)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var complete = length - text.Length;
                if (complete > 0)
                {
                    for (int i = 0; i < complete; i++)
                    {
                        text = text.Insert(0, "0");
                    }
                }
            }
            return text;
        }
        private void FrmHistorialLibro_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }

        private void BtnVerInforme_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\HistorialLibro.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var titulo = Uow.Titulos.Listado().Where(t => t.Cod == CodigoLibroCompleto).FirstOrDefault();
            Guid tituloId = titulo.Id;
            var datos = _reporteNegocio.HistorialLibro(tituloId);
           

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("MovTitulo", datos));

           var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("tituloId", tituloId.ToString()),
                                };
            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }
    }
}
