using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcTipoCompra : UserControlBase
    {
        public UcTipoCompra()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        public event EventHandler<TipoComprobanteEnum> TipoCompraChanged;

        public Entidades.Enums.TipoComprobanteEnum TipoComprobanteSeleccionado;
        
        private void OnTipoCompraChanged(TipoComprobanteEnum tipoCompra)
        {
            if (TipoCompraChanged != null)
            {
                TipoCompraChanged(this, tipoCompra);
            }
        }

        private void RdbContado_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbContado.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.FacCpraContado;
                OnTipoCompraChanged(TipoComprobanteEnum.FacCpraContado);
            }
        }

        private void RdbCuentaCorriente_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbCuentaCorriente.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.FacCpraCtaCte;
                OnTipoCompraChanged(TipoComprobanteEnum.FacCpraCtaCte);
            }
        }

        private void RdbConsignacion_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbConsignacion.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.RemitosConsignacProveedor;
                OnTipoCompraChanged(TipoComprobanteEnum.RemitosConsignacProveedor);
            }
        }

        private void RdbProduccion_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbProduccion.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.IngresosProducción;
                OnTipoCompraChanged(TipoComprobanteEnum.IngresosProducción);
            }
        }

        private void RdbAnular_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbAnular.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.RemitosAnulacConsigVend;
                OnTipoCompraChanged(TipoComprobanteEnum.RemitosAnulacConsigVend);
            }
        }
        
    }
}
