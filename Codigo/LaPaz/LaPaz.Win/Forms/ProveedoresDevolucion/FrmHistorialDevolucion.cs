using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.ProveedoresDevolucion;
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

namespace LaPaz.Win.Forms.ProveedoresDevolucion
{
    public partial class FrmHistorialDevolucion : FormBaseListado
    {
        private readonly ITitulosConsignacionesDevueltasNegocio _devolucionNegocio;
        public FrmHistorialDevolucion(IFormFactory formFactory, ILaPazUow uow, ITitulosConsignacionesDevueltasNegocio devolucionNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;

            SortColumn = "FechaAlta";
            SortDirection = "DESC";


            _devolucionNegocio = devolucionNegocio;

            InitializeComponent();
        }

        private void FrmHistorialDevolucion_Load(object sender, EventArgs e)
        {
            UcFiltrosCompras.Filtered += UcFiltrosComprasOnFiltered;
         
        }

        private void UcFiltrosComprasOnFiltered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {

            int pageTotal = 0;

            var codigoProveedor = UcFiltrosCompras.ProveedorId;
            var nroComprobante = UcFiltrosCompras.NroComprobante;
            var desde = UcFiltrosCompras.FechaInicio.AddDays(-1);
            var hasta = UcFiltrosCompras.FechaHasta;

            var page = 1;
            var pageSize = 200;

            var filtrosVacios = UcFiltrosCompras.FiltrosVacios;

            var devoluciones = await Task.Run(() => _devolucionNegocio.Listado(SortColumn, SortDirection, codigoProveedor, nroComprobante, Context.SucursalActual.Id,
                desde, hasta, 1, 200, out pageTotal));

            GridDevoluciones.DataSource = devoluciones;
            
            return pageTotal;
        }

        private void GridDevoluciones_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridDevoluciones.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var devolucion = selectedRow.DataBoundItem as TitulosConsignacionesDevueltasDto;

            if (devolucion == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Imprimir":
                    Imprimir(devolucion.Id);
                    break;
            }
        }

        private void Imprimir(Guid devolucionId)
        {
            using (var comprobante = FormFactory.Create<FrmComprobanteDevolucion>(devolucionId))
            {
                //comprobante.RecargarDetalle = true;
                comprobante.ShowDialog();
            }
        }
    }
}
