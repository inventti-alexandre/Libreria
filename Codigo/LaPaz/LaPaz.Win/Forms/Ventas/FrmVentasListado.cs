using System;
using System.Collections.Generic;
using System.Linq;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Forms.Proveedores;
using LaPaz.Win.Reportes;
using Telerik.WinControls.UI;
using System.Threading.Tasks;
using Framework.Ioc;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmVentasListado : FormBaseListado
    {
        public FrmVentasListado(IFormFactory formFactory, ILaPazUow uow)
        {
            FormFactory = formFactory;
            Uow = uow;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridVentas.CellFormatting += this.Grilla_CellFormatting;

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["ClienteDenominacion"] = "Cliente.Denominacion";
            SortColumnMappings["EstadosVentaAbreviatura"] = "EstadosVenta.Abreviatura";
            SortColumnMappings["TiposComprobanteAbreviatura"] = "TiposComprobante.Abreviatura";
            SortColumnMappings["CondicionesVentaDescripcion"] = "CondicionesVenta.Descripcion";

            MainGrid = GridVentas;
            MainPager = ProveedoresPager;
            Spinner = UcProgressSpinner;
        }

        private void InicializarPaginador()
        {
            ProveedoresPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmVentasListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);

            this.UcFiltrosVentas.Filtered += Filtered;

            RefrescarListado();
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            UcProgressSpinner.Show();

            int pageTotal = 0;

            var texto = UcFiltrosVentas.TextoABuscar;
            // var tipoComprobante =  UcFiltrosVentas.TipoComprobante;
            var numeroComprobante = UcFiltrosVentas.NumeroComprobante;
            // var letraComprobante = UcFiltrosVentas.LetraComprobante;
            var currentPage = ProveedoresPager.CurrentPage;
            var pageSize = ProveedoresPager.PageSize;

            var ventas = await Task.Run(() =>
                                        {
                                            using (var ventaNegocio = Ioc.Container.Get<IVentaNegocio>())
                                            {
                                                return ventaNegocio.Listado(SortColumn,
                                                    SortDirection,
                                                    texto,
                                                    null,
                                                    numeroComprobante,
                                                    null,
                                                    currentPage,
                                                    pageSize,
                                                    out pageTotal);
                                            }
                                        });

            GridVentas.DataSource = ventas;

            ProveedoresPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void GridProveedores_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridVentas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var venta = selectedRow.DataBoundItem as VentaDto;

            if (venta == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Imprimir":
                    Imprimir(venta.Id);
                    break;
            }
        }

        private void Imprimir(Guid ventaId)
        {
            using (var crearVenta = FormFactory.Create<FrmFacturaVenta>(ventaId))
            {
                crearVenta.RecargarDetalle = true;
                crearVenta.ShowDialog(); 
            }
        }
    }
}