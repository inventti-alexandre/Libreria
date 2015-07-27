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

namespace LaPaz.Win.Forms.Editorial
{
    public partial class FrmEditorialListado : FormBaseListado
    {
        private readonly IEditorialNegocio _editorialNegocio;

        public FrmEditorialListado(IFormFactory formFactory, ILaPazUow uow, IEditorialNegocio editorialNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;
            SortColumn = "Nombre";
            SortDirection = "ASC";

            _editorialNegocio = editorialNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.dgvEditoriales.CellFormatting += this.Grilla_CellFormatting;
            this.MainGrid = dgvEditoriales;
            this.MainPager = EditorialesPager;
            this.Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            EditorialesPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmEditorialListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            RefrescarListado();
            UcFiltrosEditoriales.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            var nombre = UcFiltrosEditoriales.Nombre;

            var editoriales = await Task.Run(() => _editorialNegocio.Listado(SortColumn, SortDirection,
                                                   nombre, EditorialesPager.CurrentPage, EditorialesPager.PageSize,
                                                   out pageTotal));

            dgvEditoriales.DataSource = editoriales;

            EditorialesPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearEditorial_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarEditorial>(0, ActionFormMode.Create))
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

            var selectedRow = this.dgvEditoriales.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var editorial = selectedRow.DataBoundItem as EditorialDto;

            if (editorial == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(editorial.Id);
                    break;
                case "ColumnaEditar":
                    Editar(editorial.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(editorial.Id);
                    break;
            }
        }

        private void Detalle(int editorialId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarEditorial>(editorialId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(int editorialId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarEditorial>(editorialId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(int editorialId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarEditorial>(editorialId, ActionFormMode.Delete))
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
