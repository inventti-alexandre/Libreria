using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework.Comun.Attributes;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Helpers;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Win.Reportes;

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class FrmConsignacionCliente : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IRemitosVentaNegocio _consignacionNegocio;
        private readonly IClienteNegocio _clienteNegocio;
        private Cliente _cliente;
        private RemitosVenta _consignacion;
        private Guid _id;
        private readonly ActionFormMode _formMode;

        public FrmConsignacionCliente(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                             IRemitosVentaNegocio consignacionNegocio,
                             IClienteNegocio clienteNegocio,
                             IFormRegistry formRegistry, Guid id, ActionFormMode mode)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _consignacionNegocio = consignacionNegocio;
            _clienteNegocio = clienteNegocio;
            _consignacion = new RemitosVenta();
            _id = id;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = "Nueva consignación";
                    break;
                case ActionFormMode.Edit:
                    this.Text = "Editar consignación";
                    break;
            }
        }

        private void FrmConsignacionCliente_Load(object sender, EventArgs e)
        {
            this.TxtFecha.Text = _clock.Now.ToShortDateString();
            this.ucBuscadorClienteConsignacion.BuscarFinished += UcBuscadorClienteOnBuscarFinished;
            this.ucTitulosVenta.VentaTitulosChanged += ucTitulosVentaConsignacionTitulosChanged;

            this.ucClienteDetalle.ClienteEdited += UcClienteDetalleOnClienteEdited;

            if (_formMode == ActionFormMode.Create)
            {
                TxtNroConsignacion.Text = _consignacionNegocio.SiguienteNroConsignacion(Context.SucursalActual.Id).ToString();
            }
            if (_formMode == ActionFormMode.Edit)
            {
                _consignacion = Uow.RemitosVentas.Obtener(r => r.Id == _id);
                TxtNroConsignacion.Text = _consignacion.NumeroComprobante;
            }

            DtpFechaVencimiento.Value = _clock.Now.AddMonths(1);
            DtpFechaVencimiento.MinDate = _clock.Now;

            ucBuscadorClienteConsignacion.Foco();
        }

        private void UcBuscadorClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    ActualizarCliente(clientes.Single());
                }
                else
                {
                    //Mas de uno encontrado.
                    using (var seleccionarCliente = new FrmSeleccionarCliente(clientes))
                    {
                        seleccionarCliente.ClienteSelected += (o, cliente) =>
                        {
                            ActualizarCliente(cliente);
                            seleccionarCliente.Close();
                        };

                        seleccionarCliente.ShowDialog();
                    }
                }
            }
            else
            {
                CrearCliente();
            }

        }

        private void UcClienteDetalleOnClienteEdited(object sender, Cliente cliente)
        {
            var clienteEdited = Uow.Clientes.Obtener(c => c.Id == cliente.Id, c => c.Localidad, c => c.Provincia, c => c.CondicionesVenta);
            ActualizarCliente(clienteEdited);
        }

        private void CrearCliente()
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create))
            {
                int i = 0;
                if (int.TryParse(ucBuscadorClienteConsignacion.Cuit, out i))
                    formCrearCliente.SetearDni(ucBuscadorClienteConsignacion.Cuit);


                formCrearCliente.ClienteAgregado += (sender, cliente) =>
                {
                    ActualizarCliente(cliente);
                    formCrearCliente.Close();
                };

                formCrearCliente.ShowDialog();
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

            ucClienteDetalle.ActualizarCliente(_cliente, deudaTotal, deudaVencida);
        }

        private void RealizarConsignacion()
        {
            _consignacion.Id = Guid.NewGuid();

            switch (_formMode)
            {
                case ActionFormMode.Create:
                    _consignacion.NumeroComprobante = _consignacionNegocio.SiguienteNroConsignacion(Context.SucursalActual.Id).ToString();
                    break;
                case ActionFormMode.Edit:
                    TxtNroConsignacion.Text = _consignacion.NumeroComprobante;
                    break;
            }

            _consignacion.LCN = "";

            _consignacion.ClienteId = _cliente.Id;

            _consignacion.PuntoVenta = 1;//; "no encuentro, pero no es igual a sucursal"
            _consignacion.FechaComprobante = _clock.Now;
            _consignacion.FechaVencimiento = DtpFechaVencimiento.Value;
            _consignacion.ImporteNeto = ucTitulosVenta.Titulos.Sum(x => x.PrecioVenta);
            _consignacion.ImporteIVA = IvaHelper.CalcularIva(_consignacion.ImporteNeto.Value);
            _consignacion.FechaEmision = _clock.Now;
            _consignacion.NumeroComprobante = TxtNroConsignacion.Text;
            _consignacion.LCN = LcnHelper.ObtenerLcn(_consignacion.NumeroComprobante,Context.SucursalActual.SucursalNumero ?? 1, "X");
            _consignacion.Concepto = "CONSIGNACION PARA CLIENTES";
            _consignacion.TipoComprobante = (int)Entidades.Enums.TipoComprobanteEnum.RemitosConsignacCliente;
            _consignacion.Observaciones = TxtObservacion.Text;
            _consignacion.FechaAlta = _clock.Now;
            _consignacion.SucursalAltaId = Context.SucursalActual.Id;//Sucursal del operador
            _consignacion.OperadorAltaId = Context.OperadorActual.Id;//Id el operador

            Uow.RemitosVentas.Agregar(_consignacion);


            //CONSIGNACION DETALLE
            foreach (var titulo in ucTitulosVenta.Titulos)
            {
                //Descontar stock
                var tituloStock =
                    Uow.TitulosStock.Obtener(ts => ts.TituloId == titulo.TituloId && ts.SucursalId == Context.SucursalActual.Id);
                var cantidadAVender = titulo.Cantidad;
                int? cantpropia = 0;
                int? cantconsiganda = 0;

                if (tituloStock.StkPr > 0)
                {
                    if (tituloStock.StkPr >= cantidadAVender)
                    {
                        tituloStock.StkPr -= cantidadAVender;
                        cantpropia = cantidadAVender;
                        cantidadAVender = 0;
                    }
                    else
                    {
                        cantpropia = tituloStock.StkPr;
                        cantidadAVender -= tituloStock.StkPr;
                        tituloStock.StkPr = 0;
                    }
                }

                if (cantidadAVender > 0 && tituloStock.StkCn > 0)
                {
                    if (tituloStock.StkCn >= cantidadAVender)
                    {
                        tituloStock.StkCn -= cantidadAVender;
                        cantconsiganda = cantidadAVender;
                    }
                    else
                    {
                        _messageBoxDisplayService.ShowError("No hay suficiente stock para completar la consignación");
                        return;
                        //Deberia cancelar la venta completa
                    }
                }

                Uow.TitulosStock.Modificar(tituloStock);

                RemitosVentaDetalle remitoDetalle = new RemitosVentaDetalle();
                remitoDetalle.Id = Guid.NewGuid();
                remitoDetalle.RemitoVentaId = _consignacion.Id;
                remitoDetalle.TituloId = titulo.TituloId;
                remitoDetalle.CntPr = cantpropia;
                remitoDetalle.CntCn = cantconsiganda;
                remitoDetalle.PrecioVenta = titulo.PrecioVenta;
                remitoDetalle.PrecioBase = titulo.PrecioBase;
                remitoDetalle.Descuento = titulo.Descuento;
                remitoDetalle.FechaAlta = _clock.Now;
                remitoDetalle.SucursalAltaId = Context.SucursalActual.Id;//Sucursal del operador
                remitoDetalle.OperadorAltaId = (Context.OperadorActual.Id);//Id el operador

                Uow.RemitosVentasDetalle.Agregar(remitoDetalle);
            }

            Uow.Commit();

            _messageBoxDisplayService.ShowSuccess(Resources.MessageSuccessConsignacionExitosa);

            using (var crearConsignacion = FormFactory.Create<FrmComprobanteConsignacion>(_consignacion.Id))
            {
                crearConsignacion._descripcion = _consignacion.Concepto;
                crearConsignacion._formaPago = "CONSIGNACION";
                crearConsignacion._recargo = "";

                crearConsignacion.ShowDialog();
            }

            var pageTab = this.Parent as RadPageViewPage;
            if (pageTab != null)
            {
                pageTab.Dispose();
            };
        }

        private void BtnRecargarNroFactura_Click(object sender, EventArgs e)
        {
            TxtNroConsignacion.Text = _consignacionNegocio.SiguienteNroConsignacion(Context.SucursalActual.Id).ToString();
        }

        private void BtnConsignar_Click(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageSeleccionarCliente);
                return;
            }

            if (!ucTitulosVenta.Titulos.Any())
            {
                _messageBoxDisplayService.ShowError(Resources.ErrorMessageVentaSinLibros);
                return;
            }

            RealizarConsignacion();
        }

        private void ucTitulosVentaConsignacionTitulosChanged(object sender, IList<VentaTitulo> consignacionTitulos)
        {
            if (ucTitulosVenta.Titulos.Count == 0)
            {

            }
        }
    }
}
