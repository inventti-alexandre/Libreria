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
using LaPaz.Win.Forms.ProveedoresGastos;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Proveedores
{
    public partial class FrmProveedoresListado : FormBaseListado
    {
        private readonly IProveedorNegocio _proveedorNegocio;
        private TipoProveedor _tipoProveedor;

        public FrmProveedoresListado(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio, TipoProveedor tipoProveedor)
        {
            FormFactory = formFactory;
            _tipoProveedor = tipoProveedor;
            Uow = uow;

            SortColumn = "Denominacion";
            SortDirection = "ASC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["ProvinciaNombre"] = "Provincia.Nombre";
            SortColumnMappings["LocalidadNombre"] = "Localidad.Nombre";
            SortColumnMappings["CondicionCompraNombre"] = "CondicionCompra.Nombre";
            SortColumnMappings["BancoNombre"] = "Banco.Nombre";

            _proveedorNegocio = proveedorNegocio;

            InitializeComponent();

            InicializarPaginador();

            InicializarForm(tipoProveedor);

            //Fix para centrar columnas.
            this.GridProveedores.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = GridProveedores;
            MainPager = ProveedoresPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarForm(TipoProveedor tipoProveedor)
        {
            if (tipoProveedor == TipoProveedor.Gastos)
            {
                this.GridProveedores.Columns["Cuenta"].IsVisible = false;
            }

            UcFiltrosProveedores.TipoProveedor = tipoProveedor;
        }

        private void InicializarPaginador()
        {
            ProveedoresPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmProveedoresListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridProveedores.AutoGenerateColumns = false;
            RefrescarListado();
            UcFiltrosProveedores.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            //GridProveedores.DataSource = new List<ProveedorDto>();
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var cuenta = UcFiltrosProveedores.Cuenta;
            var denominacion = UcFiltrosProveedores.Denominacion;
            var cuit = UcFiltrosProveedores.Cuit;
            var provinciaId = UcFiltrosProveedores.ProvinciaId;
            var localidadId = UcFiltrosProveedores.LocalidadId;
            var currentPage = ProveedoresPager.CurrentPage;
            var pageSize = ProveedoresPager.PageSize;

            var proveedores = await Task.Run(() => _proveedorNegocio.Listado(SortColumn,
                                                                             SortDirection,
                                                                             cuenta,
                                                                             denominacion,
                                                                             cuit,
                                                                             provinciaId,
                                                                             localidadId,
                                                                             _tipoProveedor,
                                                                             true,
                                                                             currentPage,
                                                                             pageSize,
                                                                             out pageTotal));

            GridProveedores.DataSource = proveedores;

            ProveedoresPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearProveedor_Click(object sender, EventArgs e)
        {
            using (Form form = this._tipoProveedor == TipoProveedor.Normal
                            ? (Form)FormFactory.Create<FrmCrearEditarProveedor>(default(Guid), ActionFormMode.Create)
                            : FormFactory.Create<FrmCrearEditarProveedorGasto>(default(Guid), ActionFormMode.Create))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    form.Close();
                    RefrescarListado();
                }
            }
        }

        private void GridProveedores_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridProveedores.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var proveedor = selectedRow.DataBoundItem as ProveedorDto;

            if (proveedor == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(proveedor.Id);
                    break;
                case "ColumnaEditar":
                    Editar(proveedor.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(proveedor.Id);
                    break;
            }
        }

        private void Detalle(Guid proveedorId)
        {
            using (Form form = this._tipoProveedor == TipoProveedor.Normal
                                    ? (Form)FormFactory.Create<FrmDetalleEliminarProveedor>(proveedorId, ActionFormMode.Detail)
                                    : FormFactory.Create<FrmDetalleEliminarProveedorGasto>(proveedorId, ActionFormMode.Detail))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    form.Close();
                    RefrescarListado();
                } 
            }
        }

        private void Editar(Guid proveedorId)
        {
            using (Form form = this._tipoProveedor == TipoProveedor.Normal
                                    ? (Form)FormFactory.Create<FrmCrearEditarProveedor>(proveedorId, ActionFormMode.Edit)
                                    : FormFactory.Create<FrmCrearEditarProveedorGasto>(proveedorId, ActionFormMode.Edit))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    form.Close();
                    RefrescarListado();
                } 
            }
        }

        private void Eliminar(Guid proveedorId)
        {
            using (Form form = this._tipoProveedor == TipoProveedor.Normal
                                    ? (Form)FormFactory.Create<FrmDetalleEliminarProveedor>(proveedorId, ActionFormMode.Delete)
                                    : FormFactory.Create<FrmDetalleEliminarProveedorGasto>(proveedorId, ActionFormMode.Delete))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    form.Close();
                    RefrescarListado();
                } 
            }
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                _proveedorNegocio.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}