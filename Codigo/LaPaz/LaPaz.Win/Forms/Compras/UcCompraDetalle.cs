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
using LaPaz.Negocio;
using LaPaz.Negocio.Interfaces;
using LaPaz.Seguridad;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcCompraDetalle : UserControlBase
    {
        private readonly ICompraDetalleNegocio _compraDetalleNegocio;

        public UcCompraDetalle()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }


            InitializeComponent();

            _compraDetalleNegocio= new CompraDetalleNegocio(Uow);
        }

        public Guid _compraId { get; set; } 
        protected ILaPazContext Context { get; private set; }

        private void UcCompraDetalle_Load(object sender, EventArgs e)
        {
            this.GridCompraDetalle.Columns["PrecioCompra"].DataType = typeof(decimal);
            this.GridCompraDetalle.Columns["PrecioCompra"].FormatString = "{0:N2}";

            this.GridCompraDetalle.Columns["PrecioVenta"].DataType = typeof(decimal);
            this.GridCompraDetalle.Columns["PrecioVenta"].FormatString = "{0:N2}";

            CargarCompraDetalle();
        }

        private void CargarCompraDetalle()
        {
            ucProgressSpinner.Show();

            int pageTotal = 0;

            var compraDetalle = _compraDetalleNegocio.Listado("FechaAlta", "ASC", _compraId, null, Context.SucursalActual.Id, ListadoPager.CurrentPage,
                                                                        ListadoPager.PageSize, out pageTotal);

            GridCompraDetalle.DataSource = compraDetalle.ToList();

            ucProgressSpinner.Hide();
        }
    }
}
