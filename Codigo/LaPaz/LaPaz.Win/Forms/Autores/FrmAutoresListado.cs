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

namespace LaPaz.Win.Forms.Autores
{
    public partial class FrmAutoresListado : FormBaseListado
    {
        private readonly IAutorNegocio _autorNegocio;

        public FrmAutoresListado(IFormFactory formFactory, ILaPazUow uow, IAutorNegocio autorNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _autorNegocio = autorNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridAutores.CellFormatting += this.Grilla_CellFormatting;

            MainGrid = GridAutores;
            MainPager = AutoresPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            AutoresPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            
            var nombre = ucFiltrosAutores.Nombre;
            SortDirection = "ASC";
            var autores = await Task.Run(() => _autorNegocio.Listado(SortColumn, SortDirection,
                                                                nombre,
                                                                AutoresPager.CurrentPage, AutoresPager.PageSize,
                                                                out pageTotal));

            GridAutores.DataSource = autores;
            AutoresPager.UpdateState(pageTotal);
            return pageTotal;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private void Detalle(int autorId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarAutor>(autorId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                }
            }
        }

        private void Editar(int autorId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarAutor>(autorId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void Eliminar(int autorId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarAutor>(autorId, ActionFormMode.Delete))
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
            using (var formCrear = FormFactory.Create<FrmCrearEditarAutor>(0, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void FrmAutoresListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridAutores.AutoGenerateColumns = false;
            RefrescarListado();
            this.ucFiltrosAutores.Filtered += Filtered;
        }

        private void GridAutores_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridAutores.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var autor = selectedRow.DataBoundItem as AutorDto;

            if (autor == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(autor.Id);
                    break;
                case "ColumnaEditar":
                    Editar(autor.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(autor.Id);
                    break;
            }
        }
    }
}
