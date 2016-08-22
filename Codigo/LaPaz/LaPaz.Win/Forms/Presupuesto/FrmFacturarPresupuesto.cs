using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class FrmFacturarPresupuesto : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cliente _cliente;
        private readonly IClienteNegocio _clienteNegocio;
        private readonly IVentaNegocio _ventaNegocio;
        private readonly IPresupuestoDetalleNegocio _presupuestoDetalleNegocio;

        public FrmFacturarPresupuesto(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             IClienteNegocio clienteNegocio,
                             IVentaNegocio ventaNegocio,
                             IPresupuestoDetalleNegocio presupuestoDetalleNegocio,
                             ILaPazUow uow)
        {
             Uow = uow;
            _clock = clock;
            _clienteNegocio = clienteNegocio;
            _ventaNegocio = ventaNegocio;
            _presupuestoDetalleNegocio = presupuestoDetalleNegocio;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
        }

        private void FrmFacturarPresupuesto_Load(object sender, EventArgs e)
        {
            this.ucBuscadorPresupuesto.BuscarPresupuestoFinished += UcBuscadorPresupuestoOnBuscarPresupuestoFinished;
        }

        private void UcBuscadorPresupuestoOnBuscarPresupuestoFinished(object sender, List<Presupuestos> presupuestos)
        {
            if (presupuestos.Any())
            {
                if (presupuestos.Count == 1)
                {
                    Guid id = presupuestos[0].ClienteId ?? Guid.Empty;
                    var cliente = Uow.Clientes.Obtener(c => c.Id == id, c=>c.Localidad, c=>c.Provincia);
                    ActualizarCliente(cliente);
                    LblFechaPresupuesto.Text = "Fecha de Presupuesto: " + presupuestos[0].FechaAlta.ToString();

                }

                ucTitulosPresupuesto.Titulos = _presupuestoDetalleNegocio.ListadoByPresupuestoId(presupuestos[0].Id.ToString());
                ucTitulosPresupuesto.RefrescarTitulos();
            }
            else
            {
                _messageBoxDisplayService.ShowWarning(Resources.ErrorBuscarConsignacionVacio);
            }
        }

        private void ActualizarCliente(Cliente cliente)
        {
            if (!cliente.Activo ?? true)
            {
                _messageBoxDisplayService.Show(this, string.Format(Resources.MensajeClienteInactivo, cliente.Denominacion, cliente.Cuit), Resources.LabelVentas);
                return;
            }

            _cliente = cliente;

            var deudaTotal = _clienteNegocio.DeudaTotal(_cliente.Id, this.Context.SucursalActual.Id);
            var deudaVencida = _clienteNegocio.DeudaVencida(_cliente.Id, this.Context.SucursalActual.Id);

            UcClienteDetalle.ActualizarCliente(_cliente, deudaTotal, deudaVencida);
            UcCuentaCorrienteInfo.ActualizarInfoCuentaCorriente(_cliente);

            UcTotalesVenta.SenasDisp = _ventaNegocio.SenaAFavorCliente(_cliente.Id, Context.SucursalActual.Id);
            UcTotalesVenta.CreditosDevolucionDisp = _ventaNegocio.CreditosPorDevolucion(_cliente.Id, Context.SucursalActual.Id);

            UcTotalesVenta.ActualizarMontosAFavor(UcTotalesVenta.SenasDisp, UcTotalesVenta.CreditosDevolucionDisp);
            UcTotalesVenta.Senas = 0;
            UcTotalesVenta.CreditosDevolucion = 0;

            //UcBuscadorPrespuesto.ActualizarFormaPago(_cliente);
        }
    }
}
