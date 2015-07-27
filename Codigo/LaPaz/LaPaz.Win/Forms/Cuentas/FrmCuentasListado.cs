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
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Cuentas
{
    public partial class FrmCuentasListado : FormBaseListado
    {
        private readonly ICuentaNegocio _cuentaNegocio;

        public FrmCuentasListado(IFormFactory formFactory, ILaPazUow uow, ICuentaNegocio cuentaNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _cuentaNegocio = cuentaNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridCuentas.CellFormatting += this.Grilla_CellFormatting;

            MainGrid = GridCuentas;
            MainPager = CuentasPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            CuentasPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var nombre = ucFiltrosCuentas.Nombre;
            var titular = ucFiltrosCuentas.Titular;
            var bancoPropioId = ucFiltrosCuentas.BancoPropioId;
            var tipoCuentaId = ucFiltrosCuentas.TipoCuentaId;
            
            SortDirection = "ASC";
            var cuentas = await Task.Run(() => _cuentaNegocio.Listado(SortColumn, SortDirection,
                                                                nombre,
                                                                tipoCuentaId,
                                                                bancoPropioId,
                                                                titular,
                                                                CuentasPager.CurrentPage, 
                                                                CuentasPager.PageSize,
                                                                out pageTotal));

            GridCuentas.DataSource = cuentas;
            CuentasPager.UpdateState(pageTotal);
            return pageTotal;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private void Detalle(int cuentaId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarCuenta>(cuentaId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                }    
            }
        }

        private void Editar(int cuentaId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCuenta>(cuentaId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(int cuentaId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarCuenta>(cuentaId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void BtnCrearAutor_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarCuenta>(0, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void FrmCuentasListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridCuentas.AutoGenerateColumns = false;
            RefrescarListado();
            this.ucFiltrosCuentas.Filtered += Filtered;
        }

        private void GridCuentas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridCuentas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var cuenta = selectedRow.DataBoundItem as CuentaDto;

            if (cuenta == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(cuenta.Id);
                    break;
                case "ColumnaEditar":
                    Editar(cuenta.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(cuenta.Id);
                    break;
            }
        }
    }
}
