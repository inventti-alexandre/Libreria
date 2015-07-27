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
    public partial class UcUsuariosLogin : UserControlBase
    {
        private bool _cargandoUsuarios;

        public event EventHandler<Operador> SeleccionarFinished;

        private Operador _operador;
        public Operador Operador
        {
            get { return _operador; }
        }

        public Guid? OperadorId
        {
            get { return (Guid?) Combo.SelectedValue; }
            set { Combo.SelectedValue = value ?? Guid.Empty; }
        }

        public string Usuario
        {
            get { return (Operador != null) ? Operador.Usuario : null; }
        }

        public UcUsuariosLogin()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void UcUsuariosLogin_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarOperadores(int sucursalId)
        {
            if (Ioc.Container == null)
                return;

            _cargandoUsuarios = true;
            var operadoresId = Uow.OperadorSucursales.Listado().Where(os => os.SucursalId == sucursalId).Select(os => os.OperadorId).ToList();
            var operador = Uow.Operadores.Listado().Where(o => operadoresId.Contains(o.Id) && o.Habilitado).ToList();
            operador.Insert(0, new Operador() { Usuario = "SELECCIONE USUARIO", Id = Guid.Empty });
            Combo.DataSource = operador;
            DefinirCombo();
            _cargandoUsuarios = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Usuario";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoUsuarios)
                SeleccionarOperador();
        }

        private void SeleccionarOperador()
        {
            _operador = (OperadorId.HasValue)
                            ? Uow.Operadores.Obtener(p => p.Id == OperadorId, o => o.OperadorSucursals)
                            : null;
            OnSeleccionarSucursalFinished(_operador);
        }

        private void OnSeleccionarSucursalFinished(Operador operador)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, operador);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = Guid.Empty;
        }
    }
}
