using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Negocio.Interfaces;
using Framework.WinForm.Comun.Notification;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Win.Properties;
namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class FrmModificarConsignacionVenta : FormBase
    {
        private readonly IClock _clock;
        private readonly IRemitosVentaDetalleNegocio _remitoDetalleNegocio;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private bool _cargandoCantidad;
        private decimal? _precioVentaActual;
        private Guid _remitoDetalleid = Guid.Empty;
        private bool _libroPasado = false;
        private bool _cambiaPrecio = false;
        private RemitosVentaDetalleDto remitoDetalle;
        private int cntCn;
        private int cntPr;
        public FrmModificarConsignacionVenta(IClock clock, IFormFactory formFactory,
                                   ILaPazUow uow,
                                   IRemitosVentaDetalleNegocio remitoDetalleNegocio,
                                   IMessageBoxDisplayService messageBoxDisplayService,
                                   Guid id)
        {

            FormFactory = formFactory;
            Uow = uow;

            _clock = clock;

            InitializeComponent();

            _messageBoxDisplayService = messageBoxDisplayService;
            _remitoDetalleNegocio = remitoDetalleNegocio;
            _remitoDetalleid = id;
        }

        public event EventHandler<RemitosVentaDetalleDto> TituloModificado;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmModificarConsignacionVenta_Load(object sender, EventArgs e)
        {
            if (_remitoDetalleid != Guid.Empty)
            {
                remitoDetalle = _remitoDetalleNegocio.RemitoDetalleById(_remitoDetalleid.ToString());

                cntCn = remitoDetalle.CntVendida ?? 0;
                cntPr = remitoDetalle.CntDevuelta ?? 0;
                
                var precioCn = remitoDetalle.PrecioVenta ?? 0;
                var precioAc = remitoDetalle.TituloPrecioVentaTitulo ?? 0;
                TxtCntConsignada.Text = remitoDetalle.CntCn.ToString();
                TxtCntPropia.Text = remitoDetalle.CntPr.ToString();
                TxtPrecioConsignado.Text = precioCn.ToString("N2");
                TxtPrecioActual.Text = precioAc.ToString("N2");
                var cntVendida = (remitoDetalle.Cantidad - cntCn + cntPr);
                if (cntVendida > 0)
                    TxtCntVendida.Text = cntVendida.ToString();
                else
                {
                    TxtCntVendida.Text = "0";
                    BtnAceptar.Enabled = false;
                }
                TxtCntDevuelta.Text = "0";
                TxtPrecioVenta.Text = (precioCn <= precioAc ? precioAc : precioCn).ToString("N2");

                
            }
            else
            {
                BtnAceptar.Enabled = false;
            }
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                RemitosVentaDetalleDto remitoDTO = ObtenerDetalle();
                if(TituloModificado != null)
                {
                    TituloModificado(this,remitoDTO);
                }
            }
        }

        private void TxtCntVendida_TextChanged(object sender, EventArgs e)
        {
            //int vendida;
            //var vendidaParse = int.TryParse(TxtCntVendida.Text, out vendida);
            //if (vendidaParse)
            //    TxtCntVendida.Text = (remitoDetalle.CntCn + remitoDetalle.CntPr - vendida).ToString();
        }

        private void TxtCntDevuelta_TextChanged(object sender, EventArgs e)
        {
            //int devuelta;
            //var devueltaParse = int.TryParse(TxtCntDevuelta.Text, out devuelta);
            //if (devueltaParse)
            //    TxtCntVendida.Text = (remitoDetalle.CntCn + remitoDetalle.CntPr - devuelta).ToString();
        }

        private bool Validar()
        {
            int vendida;
            int devuelta;

            var vendidaParse = int.TryParse(TxtCntVendida.Text, out vendida);
            var devueltaParse = int.TryParse(TxtCntDevuelta.Text, out devuelta);

            if (remitoDetalle.Cantidad < (vendida + devuelta))
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageDifferentCuantity);
                return false;
            }

            return true;
        }

        private RemitosVentaDetalleDto ObtenerDetalle()
        {
            RemitosVentaDetalleDto detalleDto = new RemitosVentaDetalleDto();
            detalleDto.Id = remitoDetalle.Id;
            detalleDto.PrecioBase = remitoDetalle.PrecioBase;
            detalleDto.PrecioVenta = TxtPrecioVenta.Value;
            detalleDto.CntCn = remitoDetalle.CntCn;
            detalleDto.CntPr = remitoDetalle.CntPr;
            detalleDto.CntVendida = Convert.ToInt32(TxtCntVendida.Text == "" ? "0" : TxtCntVendida.Text);
            detalleDto.CntDevuelta = Convert.ToInt32(TxtCntDevuelta.Text == "" ? "0" : TxtCntDevuelta.Text);
            detalleDto.SubTotal = detalleDto.CntVendida*detalleDto.PrecioVenta;
            detalleDto.TituloCod = remitoDetalle.TituloCod;
            detalleDto.TituloNombreTitulo = remitoDetalle.TituloNombreTitulo;

            return detalleDto;
        }
    }
}
