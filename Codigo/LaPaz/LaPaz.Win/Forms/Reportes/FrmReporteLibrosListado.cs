using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Util;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using Microsoft.Reporting.WinForms;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Reportes
{
    public partial class FrmReporteLibrosListado : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;

        public FrmReporteLibrosListado(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;

            InitializeComponent();
        }

        #region Propiedades

        public int? CodigoProveedor
        {
            get
            {
                if (string.IsNullOrEmpty(TxtCodigo1.Text))
                    return null;
                return Convert.ToInt32(TxtCodigo1.Text);
            }
            set { TxtCodigo1.Text = value.ToString(); }
        }

        public string CodigoLibroCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(TxtCodigo1.Text) || string.IsNullOrEmpty(TxtCodigo2.Text))
                    return null;
                return String.Format("{0}{1}", CompleteWithZeros(TxtCodigo1.Text, 4), CompleteWithZeros(TxtCodigo2.Text, 13));
            }
            set
            {
                TxtCodigo2.Text = value;
                TxtCodigo1.Text = value;
            }
        }

        public string ISBN
        {
            get { return TxtIsbn.Text; }
            set { TxtIsbn.Text = value; }
        }

        public string CodigoBarra
        {
            get { return TxtCodigoBarra.Text; }
            set { TxtCodigoBarra.Text = value; }
        }

        public string NombreTitulo
        {
            get { return TxtTitulo.Text; }
            set { TxtTitulo.Text = value; }
        }

        public Guid? ProveedorId
        {
            get { return CbxProveedor.ProveedorId; }
        }

        public string ProveedorTexto
        {
            get { return (CbxProveedor.Proveedor != null ? CbxProveedor.Proveedor.Denominacion : null); }
        }

        public int? TemaId
        {
            get { return CbxTema.TemaId; }
        }

        public string TemaTexto
        {
            get { return (CbxTema.Tema != null ? CbxTema.Tema.Nombre : null); }

        }

        public int? EditorialId
        {
            get { return UcFiltroEditorial.EditorialId; }
            set { UcFiltroEditorial.EditorialId = value; }
        }

        public string EditorialTexto
        {
            get { return UcFiltroEditorial.Editorial != null ? UcFiltroEditorial.Editorial.Nombre : null; }
        }

        public string AutorNombre
        {
            get { return TxtAutor.Text; }
            set { TxtAutor.Text = value; }
        }

        public bool? ConStock
        {
            get { return UcConStock.Value != null ? UcConStock.Value == SiNoEnum.Si : (bool?)null; }
            set { UcConStock.Value = value != null ? (value == true ? SiNoEnum.Si : SiNoEnum.No) : (SiNoEnum?)null; }
        }

        public bool? OchoDeMarzo
        {
            get { return CbxOchoDeMarzo.Value != null ? CbxOchoDeMarzo.Value == SiNoEnum.Si : (bool?)null; }
            set { CbxOchoDeMarzo.Value = value != null ? (value == true ? SiNoEnum.Si : SiNoEnum.No) : (SiNoEnum?)null; }
        }


        #endregion

        private void RefrescarReprote()
        {
            this.Cursor = Cursors.WaitCursor;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\ListadoLibros.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var codigoProveedor = CodigoProveedor;
            var codigoLibroCompleto = CodigoLibroCompleto;
            var isbn = ISBN;
            var titulo = NombreTitulo;
            var proveedorId = ProveedorId;
            var temaId = TemaId;
            var autorNombre = AutorNombre;
            var editorialId = EditorialId;
            var conStock = ConStock;
            var codigoBarra = CodigoBarra;
            var conOchoDeMarzo = OchoDeMarzo;


            var titulos = _reporteNegocio.ReporteAutorTitulosListado(codigoProveedor, codigoLibroCompleto, isbn, codigoBarra, titulo, proveedorId.ToString(), temaId,
                                                                autorNombre, editorialId, conStock, this.Context.SucursalActual.Id, conOchoDeMarzo);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", titulos));

            var sucursal = Context.SucursalActual.Nombre;

            string conStockTexto = "";
            string conStock8Texto = "";

            if (conStock.HasValue)
            {
                if (conStock.Value)
                {
                    conStockTexto = "SI";
                }
                else
                {
                    conStockTexto = "NO";
                }
            }

            if (conOchoDeMarzo.HasValue)
            {
                if (conStock.Value)
                {
                    conStock8Texto = "SI";
                }
                else
                {
                    conStock8Texto = "NO";
                }
            }

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("Sucursal", sucursal),
                                    new ReportParameter("CodigoProveedor", codigoProveedor.ToString()),
                                    new ReportParameter("CodigoLibroCompleto", codigoLibroCompleto),
                                    new ReportParameter("Proveedor", ProveedorTexto),
                                    new ReportParameter("ISBN", isbn),
                                    new ReportParameter("Tema", TemaTexto),
                                    new ReportParameter("Editorial", EditorialTexto),
                                    new ReportParameter("CodigoBarra", codigoBarra),
                                    new ReportParameter("TituloNombre", titulo),
                                    new ReportParameter("AutorNombre", autorNombre),
                                    new ReportParameter("ConStock", conStockTexto),
                                    new ReportParameter("OchoDeMarzo", conStock8Texto)
                                };

            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.ZoomPercent = 100;
            this.Cursor = Cursors.Default;
        }


        private void FrmLibrosListado_Load(object sender, EventArgs e)
        {
            CbxOchoDeMarzo.Value = SiNoEnum.Si;
            UcConStock.Value = SiNoEnum.Si;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            RefrescarReprote();
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

        private void reportViewer1_ReportRefresh(object sender, CancelEventArgs e)
        {
            RefrescarReprote();
        }
    }
}
