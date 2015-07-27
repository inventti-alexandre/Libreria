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

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class UcBuscadorConsignacion : UserControlBase
    {
        public UcBuscadorConsignacion()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        public event EventHandler<List<RemitosVenta>> BuscarConsignacionFinished;
        public event EventHandler<List<Cliente>> BuscarClienteFinished;
        public event EventHandler<FormaPago> FormaPagoChanged;

        public Entidades.Enums.TipoComprobanteEnum TipoComprobanteSeleccionado;
        public CondicionVentaEnum CondicionVentaSeleccionada;
        public TipoMovimientoCajaEnum TipoCajaMovimientoSeleccionado;

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
            this.RdbContado.IsChecked = true;
        }

        public string Cuit
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        private void BtnBuscarConsignacion_Click(object sender, EventArgs e)
        {
            BuscarConsignacion();
        }

        private void BuscarConsignacion()
        {
            int nroConsginacion;
            var isNumeric = int.TryParse(TxtTextoBuscar.Text, out nroConsginacion);

            if (!isNumeric)
            {
                OnBuscarConsignacionFinished(null);
            }

            Expression<Func<RemitosVenta, bool>> where = x => x.NumeroComprobante == nroConsginacion.ToString() &&
               x.TipoComprobante == (int)TipoComprobanteEnum.RemitosConsignacCliente;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var remitos = Uow.RemitosVentas.Listado(x => x.ClienteConsignado.Localidad, x => x.ClienteConsignado.Provincia, x => x.ClienteConsignado.CondicionesVenta)
                .Where(@where)
                .ToList();

                Cursor.Current = Cursors.Default;
                OnBuscarConsignacionFinished(remitos);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void BuscarCliente()
        {
            var textBuscarCuit = TxtBuscarCliente.Text.PadLeft(11, '0');
            var textBuscarDenominacion = TxtBuscarCliente.Text.ToStringSearch();

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
                OnBuscarClienteFinished(clientes);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void OnBuscarClienteFinished(List<Cliente> clientes)
        {
            if (BuscarClienteFinished != null)
            {
                BuscarClienteFinished(this, clientes);
            }
        }

        private void OnBuscarConsignacionFinished(List<RemitosVenta> remitosVentas)
        {
            if (BuscarConsignacionFinished != null)
            {
                BuscarConsignacionFinished(this, remitosVentas);
            }
        }

        private void OnFormaPagoChanged(FormaPago formaPago)
        {
            if (FormaPagoChanged != null)
            {
                FormaPagoChanged(this, formaPago);
            }
        }

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarConsignacion();
            }
        }

        private void UcBuscadorConsignacion_Load(object sender, EventArgs e)
        {
            TxtTextoBuscar.Focus();
        }

        public void Foco()
        {
            TxtTextoBuscar.Text = string.Empty;
            TxtTextoBuscar.Focus();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void TxtBuscarCliente_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarCliente();
            }
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

        private void RdbContado_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (RdbContado.IsChecked)
            {
                TipoComprobanteSeleccionado = Entidades.Enums.TipoComprobanteEnum.FacVtaCtado;
                CondicionVentaSeleccionada = CondicionVentaEnum.Contado;
                TipoCajaMovimientoSeleccionado = TipoMovimientoCajaEnum.FacturaVentaContado;
                OnFormaPagoChanged(FormaPago.Contado);
            }
        }
    }
}
