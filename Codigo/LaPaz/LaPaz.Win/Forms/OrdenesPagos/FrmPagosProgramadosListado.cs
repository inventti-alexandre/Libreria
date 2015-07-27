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
using LaPaz.Entidades.Enums;
using Framework.Comun.Utility;

namespace LaPaz.Win.Forms.OrdenesPagos
{
    public partial class FrmPagosProgramadosListado : FormBaseListado
    {
        private readonly IOrdenesPagoDetalleNegocio _ordenPagoDetalleNegocio;
        private readonly IClock _clock;

        public FrmPagosProgramadosListado(IFormFactory formFactory, ILaPazUow uow, IClock clock, IOrdenesPagoDetalleNegocio ordenesPagoDetalleNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;

            _clock = clock;
            SortColumn = "FechaPago";
            SortDirection = "ASC";

            _ordenPagoDetalleNegocio = ordenesPagoDetalleNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridPagos.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = GridPagos;
            MainPager = PagosPager;
            Spinner = ucProgressSpinner;
        }

        private void InicializarPaginador()
        {
            PagosPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner.Show();

            int pageTotal = 0;

            var desde = ucFiltrosPagoProgramados.Desde;
            var hasta = ucFiltrosPagoProgramados.Hasta;
            var anulados = ucFiltrosPagoProgramados.Anulados;
            var currentPage = PagosPager.CurrentPage;
            var pageSize = PagosPager.PageSize;

            var ordenesPagoDetalle = await Task.Run(() => _ordenPagoDetalleNegocio.Listado(SortColumn,
                                                                             SortDirection,
                                                                             desde,
                                                                             hasta,
                                                                             anulados,
                                                                             currentPage,
                                                                             pageSize,
                                                                             out pageTotal));

            GridPagos.DataSource = ordenesPagoDetalle;

            PagosPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void GridPagos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridPagos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var pago = selectedRow.DataBoundItem as OrdenesPagoDetalleDto;


            if (pago == null)
                return;
            if (pago.FechaAnulacion == null)
            {
                switch (commandCell.ColumnInfo.Name)
                {
                    case "ColumnaEliminar":
                        Eliminar(pago.Id);
                        break;
                    case "ColumnaPagar":
                        Pagar(pago.Id);
                        break;
                }
            }
        }

        private void Pagar(Guid pagoId)
        {
            var pago = Uow.OrdenesPagosDetalle.Obtener(o => o.Id == pagoId, o => o.OrdenesPago);
            pago.ImportePagado = pago.Efectivo ?? 0 + pago.Deposito ?? 0 + pago.DepositoEfectivo ?? 0 + pago.Cheques ?? 0;
            var orden = pago.OrdenesPago;
            orden.ImportePagado += pago.ImportePagado ?? 0;
            Uow.OrdenesPagos.Modificar(orden);
            Uow.OrdenesPagosDetalle.Modificar(pago);
            AgregarMovimientos(pago);
            Uow.Commit();
            RefrescarListado();
        }

        private void Detalle(Guid pagoId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarDetalle>(pagoId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(Guid pagoId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarDetalle>(pagoId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(Guid pagoId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarDetalle>(pagoId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void FrmPagosProgramadosListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridPagos.AutoGenerateColumns = false;
            RefrescarListado();
            ucFiltrosPagoProgramados.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private void AgregarMovimientos(OrdenesPagoDetalle _ordenPagoDetalle)
        {
            var movimiento = new CajaMovimiento();
            movimiento.Id = Guid.NewGuid();
            movimiento.Importe = _ordenPagoDetalle.ImportePagado;
            movimiento.ComprobanteId = _ordenPagoDetalle.OrdenPagoId;
            movimiento.TipoComprobante = TipoComprobanteEnum.OrdenPago;
            movimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.PagoGastos;
            Caja caja = this.Context.CajaActual;
            movimiento.CajaId = caja.Id;

            movimiento.Efectivo = _ordenPagoDetalle.ImportePagado;
            caja.Egresos += (float)(_ordenPagoDetalle.ImportePagado ?? 0);
            caja.Saldo -= (float)(_ordenPagoDetalle.ImportePagado ?? 0);
            caja.FechaModificacion = _ordenPagoDetalle.Id == default(Guid) ? (DateTime?)null : _clock.Now;
            caja.SucursalModificacionId = _ordenPagoDetalle.Id == default(Guid)
           ? null
           : caja.SucursalModificacionId;
            caja.OperadorModificacionId = _ordenPagoDetalle.Id == default(Guid)
            ? null
            : caja.OperadorModificacionId;
            Uow.Cajas.Modificar(caja);

            movimiento.FechaAlta = _ordenPagoDetalle.Id == default(Guid) ? _clock.Now : _ordenPagoDetalle.FechaAlta;
            movimiento.FechaModificacion = _ordenPagoDetalle.Id == default(Guid) ? (DateTime?)null : _clock.Now;

            movimiento.SucursalAltaId = _ordenPagoDetalle.Id == default(Guid)
                ? Context.SucursalActual.Id
                : movimiento.SucursalAltaId;

            movimiento.SucursalModificacionId = _ordenPagoDetalle.Id == default(Guid)
                ? null
                : movimiento.SucursalModificacionId;

            movimiento.OperadorAltaId = _ordenPagoDetalle.Id == default(Guid)
                ? Context.OperadorActual.Id
                : movimiento.OperadorAltaId;

            movimiento.OperadorModificacionId = _ordenPagoDetalle.Id == default(Guid)
                ? null
                : movimiento.OperadorModificacionId;

            Uow.CajaMovimientos.Agregar(movimiento);
        }
    }
}
