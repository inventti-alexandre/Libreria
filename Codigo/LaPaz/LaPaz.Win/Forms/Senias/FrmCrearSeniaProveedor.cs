using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using LaPaz.Win.Reportes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using System.Threading.Tasks;
using LaPaz.Negocio.Data;
using LaPaz.Win.Factory;

namespace LaPaz.Win.Forms.Senias
{
    public partial class FrmCrearSeniaProveedor : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IProveedorNegocio _proveedorNegocio;

        private Proveedor _proveedor;

        public FrmCrearSeniaProveedor(IClock clock,
                                      IFormFactory formFactory,
                                      IMessageBoxDisplayService messageBoxDisplayService,
                                      ILaPazUow uow,
                                      IUowFactory uowFactory,
                                      IProveedorNegocio proveedorNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            UowFactory = uowFactory;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _proveedorNegocio = proveedorNegocio;

            InitializeComponent();

            InicializarPaginador();

            this.GridSenias.CellFormatting += this.Grilla_CellFormatting;
        }

        #region Metodos
        private void FrmCrearSeniaProveedor_Load(object sender, EventArgs e)
        {
            this.GridSenias.CellFormatting += this.Grilla_CellFormatting;

            this.GridSenias.Columns["Fecha"].DataType = typeof(DateTime);
            this.GridSenias.Columns["Fecha"].FormatString = "{0: dd/M/yyyy}";
            this.GridSenias.Columns["FechaAnulacion"].DataType = typeof(DateTime);
            this.GridSenias.Columns["FechaAnulacion"].FormatString = "{0: dd/M/yyyy}";
            this.GridSenias.Columns["Importe"].FormatString = "{0:N2}";
            this.GridSenias.Columns["Utilizado"].FormatString = "{0:N2}";
            this.GridSenias.Columns["Disponible"].DataType = typeof(decimal);
            this.GridSenias.Columns["Disponible"].FormatString = "{0:N2}";

            this.UcBuscadorProveedor.SeleccionarFinished += UcBuscadorProveedorOnSeleccionarFinished;
            this.UcTotalesSeña.TotalAPagarChanged += UcTotalesSeniaOnTotalAPagarChanged;

            ToggleHabilitarControles(false);

        }

        private void UcTotalesSeniaOnTotalAPagarChanged(object sender, decimal? total)
        {
            if (UcTotalesSeña.TotalPagar > 0)
                BtnGuardar.Enabled = true;
            else
                BtnGuardar.Enabled = false;
        }

        private void UcBuscadorProveedorOnSeleccionarFinished(object sender, Proveedor proveedor)
        {
            if (proveedor != null)
            {
                if (proveedor.Id != Guid.Empty)
                {
                    ToggleHabilitarControles(true);

                    _proveedor = proveedor;

                    UcProveedorDetalle.ActualizarProveedor(proveedor);
                    UcProveedorDetalle.Disponible = _proveedorNegocio.SenaAFavorProveedor(proveedor.Id, Context.SucursalActual.Id);

                    RefrescarHistorial();
                }
                else
                {
                    ToggleHabilitarControles(false);
                }
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (this.UcTotalesSeña.Pagos.Count == 0)
            {
                _messageBoxDisplayService.ShowError("Debe agregar una seña.");
                return;
            }
            RealizarSenia();
        }

        private void GridSenias_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridSenias.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var senia = selectedRow.DataBoundItem as ProveedorSenia;

            if (senia == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Eliminar":
                    _messageBoxDisplayService.ShowConfirmationDialog(
                        Resources.MensajeConfirmarAnularSenia,
                        Resources.TituloConfirmarAnularSenia,
                        () => Anular(senia));
                    break;
                case "Anular":
                    AnularParcial(senia);
                    break;
            }
        }

        private void AnularParcial(ProveedorSenia senia)
        {
            using (var popup = FormFactory.Create<FrmAnularSenia>(senia.Id))
            {
                var result = popup.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefrescarHistorial();
                }
            }
        }

        protected override void Grilla_CellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.Column.Name == "Eliminar")
            {
                var senia = e.Row.DataBoundItem as ProveedorSenia;
                if (senia != null)
                {
                    e.CellElement.Enabled = senia.ImporteUsado.GetValueOrDefault() == 0;

                    var commandCell = e.CellElement as GridCommandCellElement;
                    if (commandCell != null)
                    {
                        commandCell.CommandButton.ToolTipText = Resources.TooltipAnulacionCompleta;
                    }

                }
            }
            else if (e.Column.Name == "Anular")
            {
                var senia = e.Row.DataBoundItem as ProveedorSenia;
                if (senia != null)
                {
                    e.CellElement.Enabled = senia.Importe != senia.ImporteUsado;
                    var commandCell = e.CellElement as GridCommandCellElement;
                    if (commandCell != null)
                    {
                        commandCell.CommandButton.ToolTipText = Resources.TooltipAnulacionParcial;
                    }
                }
            }
            base.Grilla_CellFormatting(sender, e);
        }

        private void ToggleHabilitarControles(bool enable)
        {
            PanelPagos.Enabled = enable;
        }

        private void InicializarPaginador()
        {
            ProveedorSeniasPager.RefreshActionAsync = RefrescarHistorial;
        }

        private async Task<int> RefrescarHistorial()
        {
            var currentPage = ProveedorSeniasPager.CurrentPage;
            var pageSize = ProveedorSeniasPager.PageSize;
            int pageTotal = 0;

            var senias = await
                Task.Run(
                    () =>
                        _proveedorNegocio.Senias("FechaAlta", "DESC", _proveedor.Id, Context.SucursalActual.Id, currentPage, pageSize,
                            out pageTotal));

            GridSenias.DataSource = senias;

            ProveedorSeniasPager.UpdateState(pageTotal);

            GridSenias.Refresh();

            return pageTotal;
        }

        private void ReiniciarForm()
        {
            LimpiarPagos();

            RefrescarHistorial();
        }

        private void LimpiarPagos()
        {
            UcTotalesSeña.Pagos.Clear();
            UcTotalesSeña.RefrescarPagos();
        }

        private void RealizarSenia()
        {
            ProveedorSenia senia = new ProveedorSenia();

            senia.Id = Guid.NewGuid();
            senia.ProveedorId = _proveedor.Id;
            senia.FechaAlta = _clock.Now;
            senia.FechaModificacion = _clock.Now;
            senia.Importe = UcTotalesSeña.TotalPagar;
            senia.ImporteUsado = 0;
            senia.OperadorAltaId = Context.OperadorActual.Id;
            senia.SucursalAltaId = Context.SucursalActual.Id;
            senia.OperadorModificacionId = Context.OperadorActual.Id;
            senia.SucursalModificacionId = Context.SucursalActual.Id;

            if (UcTotalesSeña.HayPagosConCajaAnterior)
            {
                var operador = this.ObtenerOperadorAdministrador();

                if (operador == null)
                {
                    return;
                }
            }

            _proveedorNegocio.CrearSeniaProveedor(senia,
                UcTotalesSeña.Pagos,
                this.Context.CajaActual,
                this.Context.OperadorActual.Id,
                this.Context.SucursalActual.Id);

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessSeniaExitosa);

            ReiniciarForm();
        }

        private void Anular(ProveedorSenia senia)
        {
            var operador = this.ObtenerOperadorAdministrador();

            if (operador == null)
            {
                return;
            }

            if (!this.EsOperadorAdmin)
            {
                //Guardamos el operador que autorizo la operacion.
                senia.OperadorAutoriza = operador.Id;
            }

            _proveedorNegocio.AnularSeniaProveedor(senia, this.Context.CajaActual, this.Context.OperadorActual.Id, this.Context.SucursalActual.Id);

            _messageBoxDisplayService.ShowSuccess("Anulación de seña exitosa");

            RefrescarHistorial();
        }

        #endregion
    }
}
