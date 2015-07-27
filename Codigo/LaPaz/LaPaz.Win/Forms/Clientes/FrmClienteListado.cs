using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Clientes
{
    public partial class FrmClienteListado : FormBaseListado
    {
        private readonly IClienteNegocio _clienteNegocio;

        public FrmClienteListado(IFormFactory formFactory, ILaPazUow uow, IClienteNegocio clienteNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;
            SortColumn = "Denominacion";
            SortDirection = "ASC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TipoDocumentoDi"] = "TiposDocumentosIdentidad.Abreviatura";

            _clienteNegocio = clienteNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.dgvClientes.CellFormatting += this.Grilla_CellFormatting;
            this.MainGrid = dgvClientes;
            this.MainPager = ClientesPager;
            this.Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            ClientesPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmClienteListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            RefrescarListado();
            UcFiltrosClientes.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            var denominacion = UcFiltrosClientes.Denominacion;
            var cuit = UcFiltrosClientes.Cuit;

            var clientes = await Task.Run(() => _clienteNegocio.Listado(SortColumn, SortDirection,
                                                                        denominacion, cuit, true,
                                                                        ClientesPager.CurrentPage,
                                                                        ClientesPager.PageSize,
                                                                        out pageTotal));

            dgvClientes.DataSource = clientes;

            ClientesPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearCliente_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void dgvClientes_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.dgvClientes.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var cliente = selectedRow.DataBoundItem as ClienteDto;

            if (cliente == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(cliente.Id);
                    break;
                case "ColumnaEditar":
                    Editar(cliente.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(cliente.Id);
                    break;
            }
        }

        private void Detalle(Guid clientId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarCliente>(clientId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(Guid clienteId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCliente>(clienteId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(Guid clienteId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarCliente>(clienteId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }
    }
}
