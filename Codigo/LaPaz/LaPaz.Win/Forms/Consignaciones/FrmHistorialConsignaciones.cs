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
    public partial class FrmHistorialConsignaciones : FormBase
    {
        private readonly IProveedorNegocio _proveedorNegocio;

        public FrmHistorialConsignaciones(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            _proveedorNegocio = proveedorNegocio;

            InitializeComponent();
        }

        public async Task RefrescarListado()
        {
            var proveedorId = ucFiltrosConsignaciones.ProveedorId;
            var desde = ucFiltrosConsignaciones.Desde;
            var hasta = ucFiltrosConsignaciones.Hasta;

            int pageTotal = 0;

            var proveedoresConsignacion = await Task.Run(() =>
                _proveedorNegocio.ProveedorConsignacion(string.Empty, string.Empty, proveedorId, null,
                                                        desde,
                                                        hasta,
                                                        1, 
                                                        50,
                                                        out pageTotal));

            UcConsignacionesProveedorListado.Consignaciones = proveedoresConsignacion;
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
