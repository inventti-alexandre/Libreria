using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroCuentas : UserControlBase
    {
        private bool _cargandoSucursales;

        public event EventHandler<Cuenta> SeleccionarFinished;

        private Cuenta _cuenta;
        public Cuenta Cuenta
        {
            get { return _cuenta; }
        }

        public int? Id
        {
            get { return (int?) Combo.SelectedValue; }
            set { Combo.SelectedValue = value; }
        }

        public string Texto
        {
            get { return Combo.Text; }
        }

        public UcFiltroCuentas()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrCuentas_Load(object sender, EventArgs e)
        {
            CargarCuenta();
        }

        public void CargarCuenta()
        {
            if (Ioc.Container == null)
                return;

            _cargandoSucursales = true;
            var cuenta = Uow.Cuentas.Listado().Where(c => c.Activo).OrderBy(s => s.Nombre).ToList();
            cuenta.Insert(0, new Cuenta() { Nombre= "SELECCIONE CUENTA", Id = 0 });
            Combo.DataSource = cuenta;
            DefinirCombo();
            _cargandoSucursales = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoSucursales)
                SeleccionarCuenta();
        }

        private void SeleccionarCuenta()
        {
            _cuenta = (Id.HasValue)
                            ? Uow.Cuentas.Obtener(p => p.Id == Id)
                            : null;
            OnSeleccionarSucursalFinished(_cuenta);
        }

        private void OnSeleccionarSucursalFinished(Cuenta cuenta)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, cuenta);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = null;
        }
    }
}
