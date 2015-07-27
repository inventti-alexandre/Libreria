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
    public partial class UcFiltroTipoCuenta : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<TiposCuenta> SeleccionarFinished;

        private TiposCuenta _tipoCuenta;
        public TiposCuenta TipoCuenta
        {
            get { return _tipoCuenta; }
        }

        public int? TipoCuentaId
        {
            get
            {
                var tipoId = Combo.SelectedValue as int?;
                return tipoId == 0 ? null : tipoId;
            }
            set
            {
                Combo.SelectedValue = value ?? 0;
            }
        }

        public UcFiltroTipoCuenta()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrSubTema_Load(object sender, EventArgs e)
        {
            CargarTiposCuentas();
        }

        public void CargarTiposCuentas()
        {
            if (Ioc.Container == null)
                return;

            _limpiandoFiltros = true;
            var tipo = Uow.TiposCuentas.Listado().OrderBy(s => s.Nombre).ToList();
            tipo.Insert(0, new TiposCuenta() { Nombre= "SELECCIONE TIPO CUENTA", Id = 0 });
            Combo.DataSource = tipo;
            DefinirCombo();
            _limpiandoFiltros = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                SeleccionarCuenta();
        }

        private void SeleccionarCuenta()
        {
            if (TipoCuentaId.HasValue)
            {
                _tipoCuenta = Uow.TiposCuentas.Obtener(c => c.Id == (int)Combo.SelectedValue);
            }
            else
            {
                _tipoCuenta = null;
            }
            
            OnSeleccionarSucursalFinished(_tipoCuenta);
        }

        private void OnSeleccionarSucursalFinished(TiposCuenta tipoCuenta)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, tipoCuenta);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }
}
