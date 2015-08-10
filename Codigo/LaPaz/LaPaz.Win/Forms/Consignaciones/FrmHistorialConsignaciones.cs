using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class FrmHistorialConsignaciones : FormBaseListado
    {
        private readonly IProveedorNegocio _proveedorNegocio;

        public FrmHistorialConsignaciones(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _proveedorNegocio = proveedorNegocio;

            InitializeComponent();

            HistorialConsignacionesPager.RefreshActionAsync = RefrescarListado;
            Spinner = UcProgressSpinner;
        }

        public async Task<int> RefrescarListado()
        {
            var proveedorId = ucFiltrosConsignaciones.ProveedorId;
            var desde = ucFiltrosConsignaciones.Desde;
            var hasta = ucFiltrosConsignaciones.Hasta;

            var pageSize = HistorialConsignacionesPager.PageSize;
            var pageIndex = HistorialConsignacionesPager.CurrentPage;

            int pageTotal = 0;

            UcProgressSpinner.Show();

            var proveedoresConsignacion = await Task.Run(() =>
                _proveedorNegocio.ProveedorConsignacion(string.Empty, string.Empty, proveedorId, null,
                    desde,
                    hasta,
                    pageIndex,
                    pageSize,
                    out pageTotal));

            UcConsignacionesProveedorListado.Consignaciones = proveedoresConsignacion;

            UcProgressSpinner.Hide();   

            return pageTotal;
        }

        private void FrmRendicionConsignaciones_Load(object sender, EventArgs e)
        {
            ucFiltrosConsignaciones.Filtered += Filtered;
            ucFiltrosConsignaciones.Cleaned += Filtered;

            UcConsignacionesProveedorListado.AbrirDetalle += UcConsignacionesProveedorListado_AbrirDetalle;
        }

        private void UcConsignacionesProveedorListado_AbrirDetalle(object sender, Guid tituloConsignacionRendidaId)
        {
            using (var form = FormFactory.Create<FrmEditarDetalleConsignacionProveedor>(tituloConsignacionRendidaId))
            {
                form.TituloConsignacionRendidaEditada += OnTituloConsignacionRendidaEditada;
                form.ShowDialog();
            }
        }

        void OnTituloConsignacionRendidaEditada(object sender, EventArgs e)
        {
            var form = sender as FrmEditarDetalleConsignacionProveedor;
            if (form != null)
            {
                form.TituloConsignacionRendidaEditada -= OnTituloConsignacionRendidaEditada;
                RefrescarListado();
            }
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }
    }
}
