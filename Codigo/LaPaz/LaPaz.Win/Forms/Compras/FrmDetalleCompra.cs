using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Win.Forms.Compras
{
    public partial class FrmDetalleCompra : FormBaseListado
    {
        private readonly IClock _clock;
        private Guid _compraId;
        private Compra _compra = new Compra();
        private readonly ICompraDetalleNegocio _compraDetalleNegocio;

        public FrmDetalleCompra(ILaPazUow uow, IClock clock, Guid id, ICompraDetalleNegocio compraDetalleNegocio)
        {
            Uow = uow;
            _compraId = id;
            _compraDetalleNegocio = compraDetalleNegocio;

            SortColumn = "FechaAlta";
            SortDirection = "ASC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TituloNombreTitulo"] = "TituloNombreTitulo";


            InitializeComponent();
            InicializarPaginador();

            //Fix para centrar columnas.
            this.MainPager = ListadoPager;
            this.Spinner = ucProgressSpinner;
        }

        private void InicializarPaginador()
        {
            ListadoPager.RefreshActionAsync = RefrescarListado;
        }


        private void radPageView1_SelectedPageChanged(object sender, EventArgs e)
        {
           if (Tabs.SelectedPage==pageCompraDetalle)
            {
                //CargarCompraDetalle();
                RefrescarListado();
            }
           if (Tabs.SelectedPage == pageCuotas)
           {
               CargarCuotas();
           }
           if (Tabs.SelectedPage == PagePagos)
           {
               CargarPagos();
           }
        }

        private void CargarPagos()
        {
            var pagos = Uow.CajaMovimientos.Listado().Where(cm => cm.ComprobanteId == _compraId).ToList();
            GrillaPagos.DataSource = pagos;
        }

        private void CargarCuotas()
        {
            if(_compra.TipoComprobanteId==TipoComprobanteEnum.FacCpraCtaCte)
            {
                var cuotas = Uow.ProveedoresCuentasCorrientes.Listado(pcc=>pcc.Proveedor).Where(pcc => pcc.CompraId == _compraId).ToList();
                GridCuotas.DataSource = cuotas;
            }
        }

        private void FrmDetalleCompra_Load(object sender, EventArgs e)
        {
            FormatoGrillas();

            _compra = Uow.Compras.Obtener(c => c.Id == _compraId);
            RefrescarListado();
            //CargarCompraDetalle();

        }

        private void FormatoGrillas()
        {
            this.GridCompraDetalle.Columns["PrecioCompra"].DataType = typeof (decimal);
            this.GridCompraDetalle.Columns["PrecioCompra"].FormatString = "{0:N2}";

            this.GridCompraDetalle.Columns["PrecioVenta"].DataType = typeof (decimal);
            this.GridCompraDetalle.Columns["PrecioVenta"].FormatString = "{0:N2}";

            this.GridCuotas.Columns["Importe"].DataType = typeof (decimal);
            this.GridCuotas.Columns["Importe"].FormatString = "{0:N2}";

            this.GridCuotas.Columns["Pagado"].DataType = typeof (decimal);
            this.GridCuotas.Columns["Pagado"].FormatString = "{0:N2}";

            this.GridCuotas.Columns["FechaVencimiento"].DataType = typeof (DateTime);
            this.GridCuotas.Columns["FechaVencimiento"].FormatString = "{0: dd/M/yyyy}";
        }

        private void CargarCompraDetalle()
        {
              ucProgressSpinner.Show();

              var page = ListadoPager.CurrentPage;
              var pageSize = ListadoPager.PageSize;
            int pageTotal = 0;

            var compraDetalle = _compraDetalleNegocio.Listado("FechaAlta", "ASC", _compraId, null, Context.SucursalActual.Id, ListadoPager.CurrentPage,
                                                                        ListadoPager.PageSize, out pageTotal);

            ListadoPager.UpdateState(pageTotal);
            GridCompraDetalle.DataSource = compraDetalle.ToList();

            ucProgressSpinner.Hide();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner.Show();

            int pageTotal = 0;

            //var codigoProveedor = ucFiltrosCompras.ProveedorId;
            //var nroComprobante = ucFiltrosCompras.NroComprobante;
            //var tipoId = ucFiltrosCompras.TipoId;
            //var desde = ucFiltrosCompras.FechaInicio.AddDays(-1);
            //var hasta = ucFiltrosCompras.FechaHasta;

            var page = ListadoPager.CurrentPage;
            var pageSize = ListadoPager.PageSize;

           // var filtrosVacios = ucFiltrosCompras.FiltrosVacios;

            var compras = await Task.Run(() =>  _compraDetalleNegocio.Listado("FechaAlta", "ASC", _compraId, null, Context.SucursalActual.Id, ListadoPager.CurrentPage,
                                                                        ListadoPager.PageSize, out pageTotal));

            GridCompraDetalle.DataSource = compras;

            ListadoPager.UpdateState(pageTotal);

            ucProgressSpinner.Hide();

            return pageTotal;
        }
    }
}
