﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Extentensions;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Helpers;
using Microsoft.Reporting.WinForms;
using Telerik.WinControls.UI;
using LaPaz.Win.Forms.Libros;

namespace LaPaz.Win.Forms.Reportes
{
    public partial class FrmMultiRanking : FormBase
    {
        private readonly IReporteNegocio _reporteNegocio;
        private Guid _tituloId;
        private string _isbn;

        public FrmMultiRanking(IFormFactory formFactory, ILaPazUow uow, IReporteNegocio reporteNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            _reporteNegocio = reporteNegocio;

            InitializeComponent();
        }

        public Guid TituloId
        {
            get { return _tituloId; }
            set { _tituloId = value; }
        }

        private void FrmClientesPorTitulo_Load(object sender, EventArgs e)
        {
            CargarCombos();

            DtpFechaInicio.Value = DateTime.Now.AddMonths(-1);
            DtpFechaFin.Value = DateTime.Now;
            CbxColumnas.SelectedIndex = 0;
            CbxTipoRanking.SelectedIndex = 0;

            
        }

        private void Refresh()
        {
            this.Cursor = Cursors.WaitCursor;
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.ProcessingMode = ProcessingMode.Local;
            string appPath = Application.StartupPath.Replace("\\bin\\Debug", "");
            string reportPath = @"\RDLS\MultiRanking.rdl";
            reportViewer1.LocalReport.ReportPath = appPath + reportPath;

            var inicio = DtpFechaInicio.Value.AbsoluteStart();
            var fin = DtpFechaFin.Value.AbsoluteEnd();
            var tipo = CbxTipoRanking.Text;
            var col = CbxColumnas.SelectedIndex != 0;
            var cantFilas = (TxtCantidadFilas.Text == null ? 10 : Convert.ToInt32(TxtCantidadFilas.Text));
            Guid? proveedor = (Guid?) ddlProveedores.SelectedValue;
            if (proveedor == Guid.Empty)
                proveedor = null;
            
            int? tema = (int)ddlTemas.SelectedValue;
            if (tema == 0)
                tema = null;

           var multi = _reporteNegocio.ReporteMultiRanking(tipo, inicio, fin, this.Context.SucursalActual.Id, col, cantFilas,_isbn,proveedor,tema);

            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("ds", multi));

            var parametros = new List<ReportParameter>
                                {
                                    new ReportParameter("TipoRanking", tipo),
                                    new ReportParameter("SucursalId", this.Context.SucursalActual.Id.ToString()),
                                    new ReportParameter("FechaInicio", inicio.ToShortDateString()),
                                    new ReportParameter("FechaFin", fin.ToShortDateString()),
                                    new ReportParameter("CantidadFilas", cantFilas.ToString()),
                                    new ReportParameter("MuestraCantidad", col.ToString())
                                };

            reportViewer1.LocalReport.SetParameters(parametros);
            this.reportViewer1.RefreshReport();
            this.Cursor = Cursors.Default;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void reportViewer1_ReportRefresh(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Refresh();
        }

        private async Task CargarCombos()
        {
            //_limpiandoFiltros = true;

            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == false).OrderBy(p => p.Denominacion).ToList();
            proveedores.Insert(0, new Proveedor() { Denominacion = "SELECCIONE PROVEEDOR", Cuenta = null });

            ddlProveedores.DisplayMember = "Denominacion";
            ddlProveedores.ValueMember = "Id";
            ddlProveedores.DataSource = proveedores;

            var tema = Uow.Temas.Listado().OrderBy(t => t.Nombre).ToList();
            tema.Insert(0, new Tema() { Nombre = "SELECCIONE TEMA" , Id= 0});
            ddlTemas.DataSource = tema;
            ddlTemas.DisplayMember = "Nombre";
            ddlTemas.ValueMember = "Id";

            //_limpiandoFiltros = false;
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {

            using (var formSeleccionarTitulo = FormFactory.Create<FrmBuscarTitulo>())
            {
                formSeleccionarTitulo.TituloSelected += (o, titulo) =>
                {
                    TxtTitulo.Text = titulo.NombreTitulo;
                    _isbn = titulo.ISBN;
                    formSeleccionarTitulo.Close();
                };

                formSeleccionarTitulo.ShowDialog();
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            _isbn = null;
            TxtTitulo.Text = null;
            ddlProveedores.SelectedIndex = 0;
            ddlTemas.SelectedIndex = 0;
        }
    }
}
