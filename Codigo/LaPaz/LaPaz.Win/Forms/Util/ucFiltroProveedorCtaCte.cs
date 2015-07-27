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
    public partial class UcFiltroProveedorCtaCte : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<ProveedoresCuentasCorriente> SeleccionarFinished;

        private ProveedoresCuentasCorriente _proveedorCtaCte;
        public ProveedoresCuentasCorriente getProveedorCtaCte
        {
            get { return _proveedorCtaCte; }
        }

        public int? ProveedorCtaCteId
        {
            get { return (int?)(Combo.SelectedIndex != 0 ? Combo.SelectedValue : null); }
            set { Combo.SelectedValue = value ?? 0; }
        }

        public UcFiltroProveedorCtaCte()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltroProveedor_Load(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;
            CargarProveedores();
            _limpiandoFiltros = false;
        }

        private void CargarProveedores()
        {
            var proveedores = Uow.ProveedoresCuentasCorrientes.Listado().ToList();
            proveedores.Insert(0, new ProveedoresCuentasCorriente() { ProveedorDenominacion = "SELECCIONE PROVEEDOR", Id = Guid.Empty });
            Combo.DataSource = proveedores;
            DefinirCombo();
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "ProveedorDenominacion";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                SeleccionarProveedorCtaCte();
        }

        private void OnSeleccionarProveedorFinished(ProveedoresCuentasCorriente proveedor)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, proveedor);
            }
        }

        private void SeleccionarProveedorCtaCte()
        {
            var proveedorCtaCte = Uow.ProveedoresCuentasCorrientes.Obtener(p => p.Id == (Guid)Combo.SelectedValue, p=>p.Proveedor);
            _proveedorCtaCte = proveedorCtaCte;
            OnSeleccionarProveedorFinished(proveedorCtaCte);
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }

    }
}
