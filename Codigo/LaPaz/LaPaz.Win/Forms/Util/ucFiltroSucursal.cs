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
    public partial class UcFiltroSucursal : UserControlBase
    {
        private bool _cargandoSucursales;

        public event EventHandler<Sucursal> SeleccionarFinished;

        private Sucursal _sucursal;
        public Sucursal Sucursal
        {
            get { return _sucursal; }

        }

        public int? SucursalId
        {
            get { return (int?)Combo.SelectedValue; }
            set { Combo.SelectedValue = value ?? 0; }
        }

        public UcFiltroSucursal()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrSucursal_Load(object sender, EventArgs e)
        {
            CargarSucursal();
        }

        public void CargarSucursal()
        {
            if (Ioc.Container == null)
                return;

            _cargandoSucursales = true;
            //var sucursal = Uow.Sucursales.Listado().OrderBy(s => s.Nombre).ToList();
            var sucursal = Uow.Sucursales.Listado().OrderBy(s => s.Nombre).Where(s=>s.SucursalNumero != null).ToList();
            sucursal.Insert(0, new Sucursal() { Nombre= "SELECCIONE SUCURSAL", Id = 0 });
            Combo.DataSource = sucursal;
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
                SeleccionarSucursal();
        }

        private void SeleccionarSucursal()
        {
            _sucursal = (SucursalId.HasValue)
                            ? Uow.Sucursales.Obtener(p => p.Id == SucursalId, s => s.Provincia, s => s.Localidad)
                            : null;
            OnSeleccionarSucursalFinished(_sucursal);
        }

        private void OnSeleccionarSucursalFinished(Sucursal sucursal)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, sucursal);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }
}
