using System;
using System.Collections.Generic;
using System.Linq;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Presupuesto;
using LaPaz.Win.Reportes;
using Telerik.WinControls.UI;
using System.Threading.Tasks;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class FrmPresupuestoListado : FormBaseListado
    {
        private IPresupuestoNegocio _presupuestoNegocio;

        public FrmPresupuestoListado(IFormFactory formFactory, ILaPazUow uow, IPresupuestoNegocio presupuestoNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;

            _presupuestoNegocio = presupuestoNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridPresupuestos.CellFormatting += this.Grilla_CellFormatting;

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["ClienteDenominacion"] = "Cliente.Denominacion";

            MainGrid = GridPresupuestos;
            MainPager = PresupuestoPager;
            Spinner = UcProgressSpinner;
        }

        private void InicializarPaginador()
        {
            PresupuestoPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmVentasListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);

            this.UcFiltrosPresupuesto.Filtered += Filtered;

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

            var texto = UcFiltrosPresupuesto.TextoABuscar;
            var lcn = UcFiltrosPresupuesto.LCN;
            var currentPage = PresupuestoPager.CurrentPage;
            var pageSize = PresupuestoPager.PageSize;

            var presupuestos = await Task.Run(() => _presupuestoNegocio.Listado(SortColumn,
                                                                         SortDirection,
                                                                         texto,
                                                                         lcn,
                                                                         currentPage,
                                                                         pageSize,
                                                                         out pageTotal));

            GridPresupuestos.DataSource = presupuestos;

            PresupuestoPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void GridPresupuestos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridPresupuestos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var presupuesto = selectedRow.DataBoundItem as PresupuestoDto;

            if (presupuesto == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Imprimir":
                    Imprimir(presupuesto.Id);
                    break;
            }
        }

        private void Imprimir(Guid presupuestoId)
        {
            using (var crearPresupuesto = FormFactory.Create<FrmComprobantePresupuesto>(presupuestoId))
            {
                crearPresupuesto._descripcion = "";
                crearPresupuesto._formaPago = "";
                crearPresupuesto._recargo = "";
                crearPresupuesto.ShowDialog();    
            }
        }
    }
}