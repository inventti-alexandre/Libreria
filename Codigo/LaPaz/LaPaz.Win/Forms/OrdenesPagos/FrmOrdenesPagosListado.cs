using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using System.Threading.Tasks;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Win.Extensiones;

namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmOrdenesPagosListado : FormBaseListado
    {
        private readonly IOrdenesPagoNegocio _ordenPagoNegocio;

        public FrmOrdenesPagosListado(IFormFactory formFactory, ILaPazUow uow, IOrdenesPagoNegocio ordenesPagoNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;

            SortColumn = "Fecha";
            SortDirection = "DESC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["ProveedorDenominacion"] = "Proveedor.Denominacion";
            SortColumnMappings["Fecha"] = "Fecha";
            SortColumnMappings["ImporteDebe"] = "ImporteDebe";

            _ordenPagoNegocio = ordenesPagoNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridOrdenesPago.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = GridOrdenesPago;
            MainPager = OrdenesPagoPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            OrdenesPagoPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var concepto = UcFiltrosOrdenesPago.Concepto;
            var nrocomprobante = UcFiltrosOrdenesPago.NroComprobante;
            var proveedorId = UcFiltrosOrdenesPago.ProveedorId;
            var sucursalId = UcFiltrosOrdenesPago.SucursalId;
            var tipoComprobante = UcFiltrosOrdenesPago.TipoComprobanteId;
            var tipogastoId = UcFiltrosOrdenesPago.TipoGastoId;
            var centroGastoId = UcFiltrosOrdenesPago.CentroGastoId;
            var currentPage = OrdenesPagoPager.CurrentPage;
            var pageSize = OrdenesPagoPager.PageSize;
            var pendiente = UcFiltrosOrdenesPago.Pendiente;
            var ordenesPago = await Task.Run(() => _ordenPagoNegocio.Listado(SortColumn,
                                                                             SortDirection,
                                                                             concepto,
                                                                             nrocomprobante,
                                                                             proveedorId.ToString(),
                                                                             sucursalId,
                                                                             centroGastoId,
                                                                             tipogastoId,
                                                                             tipoComprobante,
                                                                             pendiente,
                                                                             currentPage,
                                                                             pageSize,
                                                                             out pageTotal));

            GridOrdenesPago.DataSource = ordenesPago;

            OrdenesPagoPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearOrdenPago_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarOrdenPago>(default(Guid), ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void GridOrdenesPagos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridOrdenesPago.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var orden = selectedRow.DataBoundItem as OrdenesPagoDto;

            if (orden == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(orden.Id);
                    break;
                case "ColumnaEditar":
                    Editar(orden.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(orden.Id);
                    break;
            }
        }

        private void Detalle(Guid ordenId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarOrdenPago>(ordenId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(Guid ordenId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarOrdenPago>(ordenId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(Guid ordenId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarOrdenPago>(ordenId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void FrmOrdenesPagosListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridOrdenesPago.AutoGenerateColumns = false;
            
            RefrescarListado();

            UcFiltrosOrdenesPago.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        protected override void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            base.Grilla_CellFormatting(sender, e);
            if (e.Column.Name == "ColumnaEliminar")
            {
                var orden = e.Row.DataBoundItem as OrdenesPagoDto;
                if (orden != null)
                {
                    e.CellElement.Enabled = orden.PuedeEliminar();
                }
            }
        }
    }
}
