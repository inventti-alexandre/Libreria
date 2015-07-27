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
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using Telerik.WinControls;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Libros
{
    public partial class FrmLibrosListado : FormBaseListado
    {
        private readonly ITituloNegocio _tituloNegocio;
        private RadDropDownMenu librosContextMenu;
        private TituloDto tituloSeleccionadoContextMenu;

        public FrmLibrosListado(IFormFactory formFactory, ILaPazUow uow, ITituloNegocio tituloNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            InitializeSortColumns();

            _tituloNegocio = tituloNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridLibros.CellFormatting += Grilla_CellFormatting;

            MainGrid = GridLibros;
            MainPager = TitulosPager;
            Spinner = UcProgressSpinner;

            InitializeGridContextMenu();
        }

        private void InitializeSortColumns()
        {
            SortColumn = "FechaAlta";
            SortDirection = "DESC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TemaNombre"] = "Tema.Nombre";
            SortColumnMappings["ProveedorDenominacion"] = "Proveedor.Denominacion";
        }

        private void InitializeGridContextMenu()
        {
            librosContextMenu = new RadDropDownMenu();
            var rmiClientesConsignacion = new RadMenuItem("Clientes Consig.");
            rmiClientesConsignacion.Click += rmiClientesConsignacion_Click;
            librosContextMenu.Items.Add(rmiClientesConsignacion);
        }

        private void rmiClientesConsignacion_Click(object sender, EventArgs e)
        {
            if (tituloSeleccionadoContextMenu != null)
            {
                using (var form = FormFactory.Create<FrmClientesListadoResumido>())
                {
                    var clientes = _tituloNegocio.ClientesConsignacion(tituloSeleccionadoContextMenu.Id,
                        this.Context.SucursalActual.Id);
                    form.ActualizarClientes(clientes);
                    form.ShowDialog();
                }

                tituloSeleccionadoContextMenu = null;
            }
        }

        protected override void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            base.Grilla_CellFormatting(sender, e);

            if (e.Column.Name == "ColumnaEliminar")
            {
                var titulo = e.Row.DataBoundItem as TituloDto;
                if (titulo != null)
                {
                    e.CellElement.Enabled = titulo.Activo;
                }
            }
        }

        private void InicializarPaginador()
        {
            TitulosPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            UcProgressSpinner.Show();

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
            var page = TitulosPager.CurrentPage;
            var pageSize = TitulosPager.PageSize;

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
            TitulosPager.UpdateState(pageTotal);
            return pageTotal;
        }

        private void FrmLibrosListado_Load(object sender, EventArgs e)
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
                case "ColumnaDetalle":
                    Detalle(titulo.Id);
                    break;
                case "ColumnaEditar":
                    Editar(titulo.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(titulo.Id);
                    break;
                case "ColumnaStock":
                    ActualizarStock(titulo.Id);
                    break;
                case "ColumnaReporte":
                    Reporte(titulo.Id);
                    break;
            }
        }

        private void Reporte(Guid libroId)
        {
            using (var formReporte = FormFactory.Create<Reportes.FrmClientesPorTitulo>())
            {
                formReporte.TituloId = libroId;
                var result = formReporte.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formReporte.Close();
                }
            }
        }

        private void Detalle(Guid libroId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarLibro>(libroId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                }
            }
        }

        private void Editar(Guid proveedorId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarLibro>(proveedorId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void ActualizarStock(Guid libroId)
        {
            using (var formStock = FormFactory.Create<FrmActualizarStockLibro>(libroId))
            {
                var result = formStock.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formStock.Close();
                    RefrescarListado();
                }
            }
        }

        private void BtnCrearLibro_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarLibro>(default(Guid), ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(Guid tituloId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarLibro>(tituloId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void FrmLibrosListado_KeyDown(object sender, KeyEventArgs e)
        {
            ClipboardHelper.SetPortapapeles(e, GridLibros);
        }

        private void GridLibros_RowFormatting(object sender, RowFormattingEventArgs e)
        {
            var titulo = e.RowElement.Data.DataBoundItem as TituloDto;

            if (titulo != null)
            {
                if (titulo.EstaConsignado)
                {
                    e.RowElement.MarcarComoConsignado();
                }
            }
        }

        private void GridLibros_ContextMenuOpening(object sender, ContextMenuOpeningEventArgs e)
        {
            var gridCell = e.ContextMenuProvider as GridDataCellElement;
            if (gridCell != null)
            {
                tituloSeleccionadoContextMenu = gridCell.RowInfo.DataBoundItem as TituloDto;
                if (tituloSeleccionadoContextMenu != null)
                {
                    if (tituloSeleccionadoContextMenu.EstaConsignado)
                    {
                        e.ContextMenu = librosContextMenu;
                    }
                }
            }
        }
    }
}
