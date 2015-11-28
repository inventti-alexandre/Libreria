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
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Compras
{
    public partial class FrmComprasListado : FormBaseListado
    {
        private readonly ICompraNegocio _compraNegocio;

        public FrmComprasListado(IFormFactory formFactory, ILaPazUow uow, ICompraNegocio compraNegocio )
        {
            FormFactory = formFactory;

            Uow = uow;

            SortColumn = "FechaAlta";
            SortDirection = "DESC";


            _compraNegocio = compraNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridCompras.CellFormatting += this.Grilla_CellFormatting;

            MainGrid = GridCompras;
            MainPager = ComprasPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            ComprasPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmListadoCompras_Load(object sender, EventArgs e)
        {
            this.Text = "Listado de Compras";
            this.GridCompras.Columns["FechaAlta"].DataType = typeof(DateTime);
            this.GridCompras.Columns["FechaAlta"].FormatString = "{0: dd/M/yyyy}";
            this.GridCompras.Columns["FechaVencimiento"].DataType = typeof(DateTime);
            this.GridCompras.Columns["FechaVencimiento"].FormatString = "{0: dd/M/yyyy}";
            this.GridCompras.Columns["ImporteNeto"].DataType = typeof (decimal);
            this.GridCompras.Columns["ImporteNeto"].FormatString = "{0:N2}";


            base.FormBaseListado_Load(sender, e);
            this.ucFiltrosCompras.Filtered += Filtered;

        }

    
        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal =  0;

            var codigoProveedor = ucFiltrosCompras.ProveedorId;
            var nroComprobante = ucFiltrosCompras.NroComprobante;
            var tipoId = ucFiltrosCompras.TipoId;
            var desde = ucFiltrosCompras.FechaInicio.AddDays(-1);
            var hasta = ucFiltrosCompras.FechaHasta;
           
            var page = ComprasPager.CurrentPage;
            var pageSize = ComprasPager.PageSize;

            var filtrosVacios = ucFiltrosCompras.FiltrosVacios;

            var compras = await Task.Run(() => _compraNegocio.Listado(SortColumn, SortDirection,codigoProveedor,nroComprobante,tipoId,Context.SucursalActual.Id, 
                desde, hasta,ComprasPager.CurrentPage, ComprasPager.PageSize,
                                                      out pageTotal));

            GridCompras.DataSource = compras;

           ComprasPager.UpdateState(pageTotal);

            //Resumen de movimiento
            TxtCantidad.Text = _compraNegocio.CantidadCompra(codigoProveedor, Context.SucursalActual.Id,desde,hasta).ToString(); // compras.Count.ToString();

            decimal total = _compraNegocio.CompraTotal(codigoProveedor, Context.SucursalActual.Id, desde, hasta) ?? 0;
            TxtCompras.Text = total.ToString("n2"); // compras.Select(c => c.ImporteNeto).Sum().ToString();



            return pageTotal;
        }

        private void GridCompras_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridCompras.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var compra = selectedRow.DataBoundItem as ComprasDto;

            if (compra == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Detalle":
                    Detalle(compra.Id);
                    break;
           }
        }

        private void Detalle(Guid compraid)
        {
            using (var formDetalle = FormFactory.Create<FrmDetalleCompra>(compraid))
            {
               // formDetalle.ShowDialog();
                var result = formDetalle.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formDetalle.Close();
                }
            }
        }
    }
}
