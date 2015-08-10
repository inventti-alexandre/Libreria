using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Negocio.Response;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class FrmEditarDetalleConsignacionProveedor : FormBase
    {
        private readonly IProveedorNegocio _proveedorNegocio;
        private readonly Guid _tituloConsignacionRendidaId;

        private TituloConsignacionRendidaDto _tituloConsignacionRendidaDto;

        public FrmEditarDetalleConsignacionProveedor(Guid id, IProveedorNegocio proveedorNegocio)
        {
            _tituloConsignacionRendidaId = id;
            _proveedorNegocio = proveedorNegocio;

            InitializeComponent();
        }

        public event EventHandler TituloConsignacionRendidaEditada;

        private void FrmEditarDetalleConsignacionProveedor_Load(object sender, EventArgs e)
        {
            _tituloConsignacionRendidaDto = _proveedorNegocio.ObtenerTituloConsignacionPorId(_tituloConsignacionRendidaId);

            TxtProveedor.Text = _tituloConsignacionRendidaDto.TituloConsignacionRendida.Proveedor.Denominacion;
            TxtLcn.Text = _tituloConsignacionRendidaDto.TituloConsignacionRendida.LCN;
            TxtFechaConsignacion.Text = _tituloConsignacionRendidaDto.TituloConsignacionRendida.FechaConsignacion.ToShortDateString();
            TxtImporteActual.Text = _tituloConsignacionRendidaDto.TituloConsignacionRendida.Importe.ToString("c2");
            TxtNuevoImporte.Text = _tituloConsignacionRendidaDto.TituloConsignacionRendida.Importe.ToString("c2");
            TxtPagado.Text = _tituloConsignacionRendidaDto.TituloConsignacionRendida.Pagado.HasValue
                ? _tituloConsignacionRendidaDto.TituloConsignacionRendida.Pagado.Value.ToString("c2")
                : String.Empty;

            GridConsignacionTitulos.DataSource = _tituloConsignacionRendidaDto.TituloConsignacionRendidasDetalle;

            if (_tituloConsignacionRendidaDto.TituloConsignacionRendida.Saldada)
            {
                EstablecerFormularioParaDetalle();
            }
        }

        private void EstablecerFormularioParaDetalle()
        {
            this.BtnGuardar.Visible = false;
            this.GridConsignacionTitulos.AllowEditRow = false;
            this.LblNuevoImporte.Visible = false;
            this.TxtNuevoImporte.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            var titulosConsignacionRendidasDetalleDto = GridConsignacionTitulos.DataSource as IList<TituloConsignacionRendidasDetalleDto>;

            if (titulosConsignacionRendidasDetalleDto != null)
            {
                _proveedorNegocio.EditarTitulosConsignacionDetalle(titulosConsignacionRendidasDetalleDto);

                OnTituloConsignacionRendidaEditada();
            }
        }

        private void OnTituloConsignacionRendidaEditada()
        {
            if (TituloConsignacionRendidaEditada != null)
            {
                TituloConsignacionRendidaEditada(this, new EventArgs());
            }
        }

        private void GridConsignacionTitulos_CellValueChanged(object sender, Telerik.WinControls.UI.GridViewCellEventArgs e)
        {
            ActualizarNuevoImporte();
        }

        private void ActualizarNuevoImporte()
        {
            var nuevoImporte =
                _tituloConsignacionRendidaDto.TituloConsignacionRendidasDetalle.Sum(x => x.PrecioCompra * x.Cantidad);

            TxtNuevoImporte.Text = nuevoImporte.ToString("c2");
        }
    }
}
