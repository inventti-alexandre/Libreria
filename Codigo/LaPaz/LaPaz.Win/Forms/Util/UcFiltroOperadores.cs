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
    public partial class UcFiltroOperadores : UserControlBase
    {
        private bool _cargandoOperadores;

        public event EventHandler<Operador> SeleccionarFinished;

        private Operador _operador;
        public Operador Operador
        {
            get { return _operador; }
        }

        public Guid? OperadorId
        {
            get
            {
                if (Combo == null)
                    return null;
                if (Combo.SelectedValue == null || (Guid)Combo.SelectedValue == Guid.Empty)
                    return null;
                return (Guid?) Combo.SelectedValue;
            }
            set { Combo.SelectedValue = value; }
        }

        public UcFiltroOperadores()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrOperadores_Load(object sender, EventArgs e)
        {
            CargarOperadores();
        }

        public void CargarOperadores()
        {
            if (Ioc.Container == null)
                return;

            _cargandoOperadores = true;
            var operadores = Uow.Operadores.Listado().Where(o => o.Habilitado).OrderBy(s => s.Usuario).ToList();
            operadores.Insert(0, new Operador() { Usuario = "TODOS" });
            Combo.DataSource = operadores;
            DefinirCombo();
            _cargandoOperadores = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Usuario";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoOperadores)
                SeleccionarOperador();
        }

        private void SeleccionarOperador()
        {
            _operador = (OperadorId.HasValue)
                            ? Uow.Operadores.Obtener(o => o.Id == OperadorId)
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
            Combo.SelectedValue = 0;
        }
    }
}
