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
    public partial class UcFiltroCuentasProveedor : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<Proveedor> SeleccionarFinished;

        private Proveedor _proveedor;
        public Proveedor Proveedor
        {
            get { return _proveedor; }
        }

        public Guid? ProveedorId
        {
            get { return (Guid?)Combo.SelectedValue; }
            set { Combo.SelectedValue = value ?? Guid.Empty; }
        }

        public bool EsGasto { get; set; }

        public UcFiltroCuentasProveedor()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltroProveedor_Load(object sender, EventArgs e)
        {
           // CargarProveedores(EsGasto);
        }

        public void CargarProveedores(bool esGasto = false)
        {
            _limpiandoFiltros = true;
            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == esGasto && p.Activo).OrderBy(p => p.Cuenta).Select(p => new {Descripcion=p.Cuenta.ToString(), Id = p.Id}).ToList();
            proveedores.Insert(0, new { Descripcion = "SELECCIONE CUENTA", Id = Guid.Empty });
            Combo.DataSource = proveedores;
            DefinirCombo();
            _limpiandoFiltros = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Descripcion";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                SeleccionarProveedor();
        }

        private void OnSeleccionarProveedorFinished(Proveedor proveedor)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, proveedor);
            }
        }

        private void SeleccionarProveedor()
        {
            _proveedor = (ProveedorId.HasValue)
                             ? Uow.Proveedores.Obtener(p => p.Id == (Guid) Combo.SelectedValue, p => p.Localidad,
                                                       p => p.Provincia)
                             : null;
            OnSeleccionarProveedorFinished(_proveedor);
        }

        public void Reset()
        {
            Combo.SelectedValue = Guid.Empty;
        }
        
    }
}
