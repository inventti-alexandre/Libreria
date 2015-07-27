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

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcBuscadorProveedor : UserControlBase
    {
        private bool _limpiandoFiltros;
        private bool _seleccionandoProveedor;

        public UcBuscadorProveedor()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();

        }

        public event EventHandler<Proveedor> SeleccionarFinished;

        private void UcBuscadorProveedor_Load(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;
            CargarProveedores();
            CbxCuentasProveedor.SeleccionarFinished += OnSeleccionarFinished;
            _limpiandoFiltros = false;
        }

        private void CargarProveedores()
        {
            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == false && p.Activo).OrderBy(p => p.Denominacion).ToList();
            proveedores.Insert(0, new Proveedor() { Denominacion = "SELECCIONE PROVEEDOR", Cuenta = 0 });

            ComboProveedores.DisplayMember = "Denominacion";
            ComboProveedores.ValueMember = "Id";
            ComboProveedores.DataSource = proveedores;

            CbxCuentasProveedor.CargarProveedores(false);
        }

        private void BtnSeleccionar_Click_1(object sender, EventArgs e)
        {
            SeleccionarProveedor();
        }

        private void ComboProveedores_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros && ComboProveedores.Text != "")
                SeleccionarProveedor();
        }

        private void SeleccionarProveedor()
        {
            _seleccionandoProveedor = true;

            Proveedor proveedor = ComboProveedores.SelectedValue != null
                                        ? Uow.Proveedores.Obtener(p => p.Id == (Guid)ComboProveedores.SelectedValue,
                                                                    p => p.Localidad, p => p.Provincia)
                                                                    : null;

            CbxCuentasProveedor.ProveedorId = proveedor.Id;

            OnSeleccionarFinished(proveedor);

            _seleccionandoProveedor = false;
        }

        private void OnSeleccionarFinished(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                if (SeleccionarFinished != null)
                {
                    SeleccionarFinished(this, proveedor);
                    ComboProveedores.SelectedValue = proveedor.Id;
                }
            }
        }

        private void OnSeleccionarFinished(Object sender, Proveedor proveedor)
        {
            if (proveedor != null && !_seleccionandoProveedor)
                OnSeleccionarFinished(proveedor);
        }
    }
}
