using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Seguridad;

namespace LaPaz.Win.Forms.Seguridad
{
    [PrincipalPermission(SecurityAction.Demand,Role = RolesNames.SuperAdmin)]
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.Admin)]
    public partial class FrmUsuariosListado : FormBaseListado
    {
        private readonly IUsuarioNegocio _usuarioNegocio;

        public FrmUsuariosListado(IFormFactory formFactory, ILaPazUow uow, IUsuarioNegocio usuariosNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _usuarioNegocio = usuariosNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.DgvUsuarios.CellFormatting += this.Grilla_CellFormatting;
            this.MainGrid = DgvUsuarios;
            this.MainPager = UsuariosPager;
            this.Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            UsuariosPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmUsuariosListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            RefrescarListado();
            UcFiltrosUsuarios.Filtered += Filtered;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;
            var criteria = UcFiltrosUsuarios.Criteria;
            var cuit = UcFiltrosUsuarios.Cuit;
            bool? habilitado = UcFiltrosUsuarios.Habilitado;

            //Solo mostramos habilitados para usuarios que no son super admin
            if (!this.Context.IsInRole(RolesNames.SuperAdmin))
                habilitado = true;

            var usuarios = await Task.Run(() => _usuarioNegocio.Listado(SortColumn, SortDirection,
                                                   criteria,cuit,habilitado,
                                                   UsuariosPager.CurrentPage, UsuariosPager.PageSize,
                                                   out pageTotal));

            DgvUsuarios.DataSource = usuarios;

            UsuariosPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void BtnCrearUsuarios_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarUsuario>(default(Guid), ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void DgvUsuarios_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.DgvUsuarios.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var usuario = selectedRow.DataBoundItem as UsuarioDto;

            if (usuario == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "ColumnaDetalle":
                    Detalle(usuario.Id);
                    break;
                case "ColumnaEditar":
                    Editar(usuario.Id);
                    break;
                case "ColumnaEliminar":
                    Eliminar(usuario.Id);
                    break;
            }
        }

        private void Detalle(Guid usuarioId)
        {
            using ( var formCrear = FormFactory.Create<FrmDetalleEliminarUsuario>(usuarioId, ActionFormMode.Detail))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                } 
            }
        }

        private void Editar(Guid usuariosId)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarUsuario>(usuariosId, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                } 
            }
        }

        private void Eliminar(Guid usuariosId)
        {
            using (var formCrear = FormFactory.Create<FrmDetalleEliminarUsuario>(usuariosId, ActionFormMode.Delete))
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
