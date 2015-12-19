using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Libros
{
    public partial class FrmBuscarTitulo : FormBaseListado
    {
        private readonly ITituloNegocio _tituloNegocio;

        public FrmBuscarTitulo(IFormFactory formFactory, ILaPazUow uow, ITituloNegocio tituloNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            InitializeSortColumns();

            _tituloNegocio = tituloNegocio;

            InitializeComponent();

            //InicializarPaginador();

            //Fix para centrar columnas.
            this.GridLibros.CellFormatting += Grilla_CellFormatting;

            MainGrid = GridLibros;
           // MainPager = TitulosPager;
           // Spinner = UcProgressSpinner;

        }

        private void InitializeSortColumns()
        {
            SortColumn = "FechaAlta";
            SortDirection = "DESC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TemaNombre"] = "Tema.Nombre";
            SortColumnMappings["ProveedorDenominacion"] = "Proveedor.Denominacion";
        }

        #region Eventos
        public EventHandler<TituloDto> TituloSelected;

        private void OnTituloSelected(TituloDto titulo)
        {
            if (TituloSelected != null)
            {
                TituloSelected(this, titulo);
            }
        }

        #endregion

        public override async Task<int> RefrescarListado()
        {
            //UcProgressSpinner.Show();

            int pageTotal = 0;

            var codigoProveedor = UcFiltrosLibros.CodigoProveedor;
            var codigoLibroCompleto = UcFiltrosLibros.CodigoLibroCompleto;
            var isbn = UcFiltrosLibros.ISBN;
            var nombreTitulo = UcFiltrosLibros.NombreTitulo;
            var proveedorId = UcFiltrosLibros.ProveedorId;
            var temaId = UcFiltrosLibros.TemaId;
            var autorNombre = UcFiltrosLibros.AutorNombre;
            var editorialId = UcFiltrosLibros.EditorialId;
            var conStock = UcFiltrosLibros.ConStock;
            var codigoBarra = UcFiltrosLibros.CodigoBarra;
            var conOchoDeMarzo = UcFiltrosLibros.OchoDeMarzo;
            var activos = UcFiltrosLibros.Activos;
            var page = 1;//TitulosPager.CurrentPage;
            var pageSize = 50; // TitulosPager.PageSize;

            var filtrosVacios = UcFiltrosLibros.FiltrosVacios;

            var titulos = filtrosVacios
                            ? new List<TituloDto>()
                            : await Task.Run(() => _tituloNegocio.Listado(SortColumn, SortDirection,
                                                                codigoProveedor,
                                                                codigoLibroCompleto,
                                                                isbn,
                                                                codigoBarra,
                                                                nombreTitulo,
                                                                proveedorId,
                                                                temaId,
                                                                autorNombre,
                                                                editorialId,
                                                                conStock,
                                                                this.Context.SucursalActual.Id,
                                                                conOchoDeMarzo,
                                                                activos,
                                                                page, pageSize,
                                                                out pageTotal));

            GridLibros.DataSource = titulos;
            //TitulosPager.UpdateState(pageTotal);
            return pageTotal;
        }

        private void FrmBuscarTitulo_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            this.UcFiltrosLibros.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private void GridLibros_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridLibros.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var titulo = selectedRow.DataBoundItem as TituloDto;

            if (titulo == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Seleccionar":
                    SeleccionarTitulo(titulo);
                    break;
               
            }
        }

        private void SeleccionarTitulo(TituloDto titulo)
        {
            OnTituloSelected(titulo);
            //this.DialogResult();
        }

    }
}
