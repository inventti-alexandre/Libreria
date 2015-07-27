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
using Framework.Comun.Extentensions;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class UcBuscadorCliente : UserControlBase
    {
        public UcBuscadorCliente()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();

            EstablecerPagoEfectivo();
        }

        public event EventHandler<List<Cliente>> BuscarFinished;
        public event EventHandler<FormaPago> FormaPagoChanged;

        public Entidades.Enums.TipoComprobanteEnum TipoComprobanteSeleccionado;
        public CondicionVentaEnum CondicionVentaSeleccionada;
        public TipoMovimientoCajaEnum TipoCajaMovimientoSeleccionado;

        public string Cuit
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        public void ActualizarFormaPago(Cliente cliente)
        {
            if (cliente.CondicionVentaId == CondicionVentaEnum.CuentaCorriente || cliente.CondicionVentaId == CondicionVentaEnum.MesCompra10)
            {
                this.RdbCuentaCorriente.Enabled = true;
            }
            else
            {
                this.RdbCuentaCorriente.IsChecked = false;
                this.RdbCuentaCorriente.Enabled = false;     
            }
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            var textBuscarCuit = TxtTextoBuscar.Text.PadLeft(11, '0'); 
            var textBuscarDenominacion = TxtTextoBuscar.Text.ToStringSearch();

            Expression<Func<Cliente, bool>> where =
                x =>
                SqlFunctions.PatIndex(textBuscarCuit, x.Cuit) > 0 ||
                SqlFunctions.PatIndex(textBuscarDenominacion, x.Denominacion) > 0;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var clientes = Uow.Clientes.Listado(x => x.CondicionesVenta, x => x.Localidad, x => x.Provincia)
                .Where(@where)
                .OrderBy(c => c.Denominacion)
                .ToList();

                Cursor.Current = Cursors.Default;
                OnBuscarFinished(clientes);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
         }

        private void OnBuscarFinished(List<Cliente> clientes)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, clientes);
            }
        }

        private void OnFormaPagoChanged(FormaPago formaPago)
        {
            if (FormaPagoChanged != null)
            {
                FormaPagoChanged(this, formaPago);
            }
        }

        private void RdbContado_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbContado.IsChecked)
            {
                EstablecerPagoEfectivo();
                OnFormaPagoChanged(FormaPago.Contado);
            }
        }

        private void EstablecerPagoEfectivo()
        {
            TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.FacVtaCtado;
            CondicionVentaSeleccionada = CondicionVentaEnum.Contado;
            TipoCajaMovimientoSeleccionado = TipoMovimientoCajaEnum.FacturaVentaContado;
        }

        private void RdbCuentaCorriente_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbCuentaCorriente.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.FacVtaCtaCte;
                CondicionVentaSeleccionada = CondicionVentaEnum.CuentaCorriente;
                TipoCajaMovimientoSeleccionado = TipoMovimientoCajaEnum.FacturaVentaCtaCte;
                OnFormaPagoChanged(FormaPago.CuentaCorriente);
            }
        }

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCliente();
            }
        }

        private void UcBuscadorCliente_Load(object sender, EventArgs e)
        {
            TxtTextoBuscar.Focus();
        }

        public void Foco()
        {
            TxtTextoBuscar.Text = string.Empty;
            TxtTextoBuscar.Focus();
        }

        public void OcultarModosPago()
        {
            metroPanel1.Visible = false;
        }
    }
}
