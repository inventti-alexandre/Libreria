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

namespace LaPaz.Win.Forms.Bancos
{
    public partial class FrmBancoListado : FormBaseListado
    {
        private readonly IBancoNegocio _bancoNegocio;

        public FrmBancoListado(IFormFactory formFactory, ILaPazUow uow, IBancoNegocio bancoNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;
            SortColumn = "Nombre";
            SortDirection = "ASC";
            
            _bancoNegocio = bancoNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.dgvBancos.CellFormatting += this.Grilla_CellFormatting;
            this.MainGrid = dgvBancos;
            this.MainPager = BancosPager;
            this.Spinner = ucProgressSpinner1;
        }
        
        private void InicializarPaginador()
        {
            BancosPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmBancoListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            RefrescarListado();
            UcFiltrosBancos.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            try
            {
                ucProgressSpinner1.Show();

                int pageTotal = 0;
                var nombre = UcFiltrosBancos.Nombre;

                var clientes = await Task.Run(() => _bancoNegocio.Listado(SortColumn, SortDirection,
                                                       nombre, BancosPager.CurrentPage, BancosPager.PageSize,
                                                       out pageTotal));

                dgvBancos.DataSource = clientes;

                BancosPager.UpdateState(pageTotal);

                return pageTotal;
            }
            catch (Exception ex)
            {
                
                throw;
            }
            
        }

        private void BtnCrearBanco_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarBanco>(0, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void dgvBancos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.dgvBancos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var banco = selectedRow.DataBoundItem as BancoDto;

            if (banco == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(banco.Id);
                    break;
                case "ColumnaEditar":
                    Editar(banco.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(banco.Id);
                    break;
            }
        }

        private void Detalle(int bancoId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarBanco>(bancoId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(int bancoId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarBanco>(bancoId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(int bancoId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarBanco>(bancoId, ActionFormMode.Delete))
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
