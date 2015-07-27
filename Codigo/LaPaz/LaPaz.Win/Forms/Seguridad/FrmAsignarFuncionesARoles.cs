using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using System.Threading.Tasks;

namespace LaPaz.Win.Forms.Seguridad
{
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.SuperAdmin)]
    [PrincipalPermission(SecurityAction.Demand, Role = RolesNames.Admin)]
    public partial class FrmAsignarFuncionesARoles : EditFormBase
    {
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        List<RadListDataItem> _selectedItems = new List<RadListDataItem>();

        public FrmAsignarFuncionesARoles(ILaPazUow uow, IMessageBoxDisplayService messageBoxDisplayService)
        {
            Uow = uow;
            _messageBoxDisplayService = messageBoxDisplayService;
            InitializeComponent();
            this.UcRoles.SeleccionarFinished += UcRoles_SeleccionarFinished;
        }

        #region Propiedades

        public IList<Funcion> FuncionesDisponibles { get; set; }
        public IList<Funcion> FuncionesAsignadas { get; set; }

        #endregion

        #region Metodos

        private void MoveToTargetListBox(RadListControl sourceListBox, RadListControl targetListBox)
        {
            if (sourceListBox.Items.Count == 0)
            {
                return;
            }

            if (sourceListBox.SelectedItems == null)
            {
                return;
            }

            foreach (RadListDataItem selItem in sourceListBox.SelectedItems)
            {
                _selectedItems.Add(selItem);
            }

            var sourceDataSource = sourceListBox.DataSource as IList<Funcion>;
            var targetDataSource = targetListBox.DataSource as IList<Funcion>;

            if (sourceDataSource == null || targetDataSource == null)
            {
                return;
            }

            foreach (Funcion funcion in _selectedItems.Select(x => x.DataBoundItem))
            {
                sourceDataSource.Remove(funcion);
                targetDataSource.Add(funcion);
            }

            _selectedItems.Clear();

            sourceListBox.ListElement.ClearSelected();
            targetListBox.ListElement.ClearSelected();

            sourceListBox.Rebind();
            targetListBox.Rebind();
        }

        private void BtnMoveToRight_Click(object sender, EventArgs e)
        {
            MoveToTargetListBox(this.LbAllItems, this.LbSelectedItems);
        }

        private void BtnMoveToLeft_Click(object sender, EventArgs e)
        {
            MoveToTargetListBox(this.LbSelectedItems, this.LbAllItems);
        }

        private void FrmAsignarFuncionesARoles_Load(object sender, EventArgs e)
        {
        }

        private void BtnMoveAllToRight_Click(object sender, EventArgs e)
        {
            this.LbAllItems.SelectAll();
            MoveToTargetListBox(this.LbAllItems, this.LbSelectedItems);
        }

        private void BtnMoveAllToLeft_Click(object sender, EventArgs e)
        {
            this.LbSelectedItems.SelectAll();
            MoveToTargetListBox(this.LbSelectedItems, this.LbAllItems);
        }

        private void UcRoles_SeleccionarFinished(object sender, Role role)
        {
            CargarListas(role);
        }

        private void CargarListas(Role role)
        {
            var funciones = Uow.Funciones.Listado().ToList();

            FuncionesAsignadas = Uow.Funciones.Listado(f => f.Roles)
                                                  .Where(f => f.Roles.Any(r => r.Id == role.Id))
                                                  .ToList();

            FuncionesDisponibles = funciones.Except(FuncionesAsignadas).ToList();

            this.LbAllItems.DisplayMember = "Descripcion";
            this.LbAllItems.DataSource = FuncionesDisponibles;
            this.LbSelectedItems.DisplayMember = "Descripcion";
            this.LbSelectedItems.DataSource = FuncionesAsignadas;
        }

        #endregion

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (UcRoles.Role == null)
                return;

            var roleId = UcRoles.Role.Id;
            var funcionesAsignadas = LbSelectedItems.DataSource as List<Funcion>;

            await Task.Run(() =>
                         {
                             var role = Uow.Roles.Obtener(r => r.Id == roleId, r => r.Funciones);

                             role.Funciones.Clear();

                             role.Funciones = funcionesAsignadas;

                             Uow.Commit();
                         });

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSucessAsignarFuncionesARoles);
        }
    }
}
