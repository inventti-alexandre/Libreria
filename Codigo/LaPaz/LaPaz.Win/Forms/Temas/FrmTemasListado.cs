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

namespace LaPaz.Win.Forms.Temas
{
    public partial class FrmTemasListado : FormBaseListado
    {
        private readonly ITemaNegocio _temaNegocio;

        public FrmTemasListado(IFormFactory formFactory, ILaPazUow uow, ITemaNegocio temaNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _temaNegocio = temaNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridTemas.CellFormatting += this.Grilla_CellFormatting;

            MainGrid = GridTemas;
            MainPager = TemasPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            TemasPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            
            var nombre = ucFiltrosTemas.Nombre;
            SortDirection = "ASC";
            var temas = await Task.Run(() => _temaNegocio.Listado(SortColumn, SortDirection,
                                                                nombre,
                                                                TemasPager.CurrentPage, TemasPager.PageSize,
                                                                out pageTotal));

            GridTemas.DataSource = temas;
            TemasPager.UpdateState(pageTotal);
            return pageTotal;
        }
        
        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }
        
        private void Detalle(int temaId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarTema>(temaId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                } 
            }
        }

        private void Editar(int temaId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarTema>(temaId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                } 
            }
        }

        private void Eliminar(int temaId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarTema>(temaId, ActionFormMode.Delete))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                } 
            }
        }

        private void FrmTemasListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridTemas.AutoGenerateColumns = false;
            RefrescarListado();
            this.ucFiltrosTemas.Filtered += Filtered;
        }

        private void GridTemas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridTemas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var tema = selectedRow.DataBoundItem as TemaDto;

            if (tema == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(tema.Id);
                    break;
                case "ColumnaEditar":
                    Editar(tema.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(tema.Id);
                    break;
            }
        }

        private void BtnCrearTema_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarTema>(0, ActionFormMode.Create))
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
