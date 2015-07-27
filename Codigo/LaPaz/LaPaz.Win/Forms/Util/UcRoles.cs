using System;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using System.Linq;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcRoles : UserControlBase
    {
        private bool _cargandoRoles;

        public event EventHandler<Role> SeleccionarFinished;

        private Role _role;
        public Role Role
        {
            get { return _role; }
        }

        public int? RoleId
        {
            get { return (int?)(Combo.SelectedIndex != 0 ? Combo.SelectedValue : null); }
            set { Combo.SelectedValue = value ?? 0; }
        }

        public UcRoles()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void UcRoles_Load(object sender, EventArgs e)
        {
            CargarRoles();
        }

        public void CargarRoles()
        {
            if (Ioc.Container == null)
                return;

            _cargandoRoles = true;
            var roles = Uow.Roles.Listado().OrderBy(s => s.Description).ToList();
            roles.Insert(0, new Role() { Description= "SELECCIONE ROL", Id = 0 });
            Combo.DataSource = roles;
            DefinirCombo();
            _cargandoRoles = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Description";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoRoles)
                SeleccionarRole();
        }

        private void SeleccionarRole()
        {
            var role = Uow.Roles.Obtener(p => p.Id == RoleId);
            _role = role;
            OnSeleccionarRoleFinished(role);
        }

        private void OnSeleccionarRoleFinished(Role role)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, role);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }
}
