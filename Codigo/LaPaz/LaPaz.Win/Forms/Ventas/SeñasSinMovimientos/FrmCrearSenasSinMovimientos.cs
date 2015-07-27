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
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Ventas.SeñasSinMovimientos
{
    public partial class FrmCrearSenasSinMovimientos : FormBase
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private readonly IVentaNegocio _ventaNegocio;
        private Cliente _cliente;
        private Guid _clienteId;
       

        public FrmCrearSenasSinMovimientos(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                        IVentaNegocio ventaNegocio,
                             IFormRegistry formRegistry, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _clienteId = id;
            _cliente = new Cliente();
            _ventaNegocio = ventaNegocio;
            InitializeComponent();
            this.Text = "Señas";
        }

        #region Propiedades

        public decimal? Monto
        {
            get
            {
                decimal monto;
                return decimal.TryParse(TxtMonto.Text, out monto) ? monto : (decimal?)0;
            }
            set
            {
                TxtMonto.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;
            }
        }

        #endregion
       

        private void FrmCrearSenas_Load(object sender, EventArgs e)
        {
            this.ucBuscadorClienteSimple.BuscarFinished += UcBuscadorClienteOnBuscarFinished;
            this.ucTotalesSeña.TotalAPagarChanged += UcTotalesSeñaOnTotalAPagarChanged;


            this.GridSeñas.CellFormatting += this.Grilla_CellFormatting;
            this.GridSeñas.Columns["Fecha"].DataType = typeof (DateTime);
            this.GridSeñas.Columns["Fecha"].FormatString = "{0: dd/M/yyyy}";
            this.GridSeñas.Columns["FechaAnulacion"].DataType = typeof(DateTime);
            this.GridSeñas.Columns["FechaAnulacion"].FormatString = "{0: dd/M/yyyy}";
            this.GridSeñas.Columns["Importe"].FormatString = "{0:N2}";
            this.GridSeñas.Columns["Utilizado"].FormatString = "{0:N2}";
            if (_clienteId != Guid.Empty)
            {
                _cliente = Uow.Clientes.Obtener(c => c.Id == _clienteId);
                ActualizarCliente(_cliente);
                pnlBuscador.Visible = false;
            }

        }

        private void UcTotalesSeñaOnTotalAPagarChanged(object sender, decimal? e)
        {
            if (ucTotalesSeña.TotalPagar != 0 && ucTotalesSeña.TotalPagar != Monto)
            {
                ucTotalesSeña.EliminarPagoEfectivo();
                if (ucTotalesSeña.TotalPagar != Monto)
                {
                    if (Monto - ucTotalesSeña.TotalPagar > 0)
                        ucTotalesSeña.GenerarPagoAutoNuevo(Monto - ucTotalesSeña.TotalPagar, FormaPago.Efectivo);
                }

            }
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
                    var seleccionarCliente = new FrmSeleccionarCliente(clientes);

                    seleccionarCliente.ClienteSelected += (o, cliente) =>
                    {
                        ActualizarCliente(cliente);
                        seleccionarCliente.Close();
                    };

                    seleccionarCliente.ShowDialog();
                }
            }
            else
            {
                CrearCliente();
            }
        }

        private void CrearCliente()
        {
            var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(default(Guid), ActionFormMode.Create);

            formCrearCliente.ClienteAgregado += (sender, cliente) =>
            {
                ActualizarCliente(cliente);
                formCrearCliente.Close();
            };

            formCrearCliente.ShowDialog();
        }

        private void ActualizarCliente(Cliente cliente)
        {
            _cliente = cliente;
            TxtCliente.Text = cliente.Denominacion;
            TxtDni.Text = cliente.Cuit.TrimStart('0');
            TxtSenias.Text = _ventaNegocio.SenaAFavorCliente(_cliente.Id).ToString("N2");
            TxtCreditos.Text = _ventaNegocio.CreditosPorDevolucion(_cliente.Id).ToString("N2");
            BuscarHistorial();
        }

        private void BuscarHistorial()
        {
            var señas = Uow.ClientesMontosFavor.Listado().Where(c => c.ClienteId == _cliente.Id && (c.TipoComprobanteId == TipoComprobanteEnum.SeñaCliente || c.TipoComprobanteId == TipoComprobanteEnum.NotaCrédito)).OrderByDescending(c => c.FechaAlta);

            GridSeñas.DataSource = señas.ToList();
            GridSeñas.Refresh();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (Monto!= ucTotalesSeña.TotalPagar)
            {
                _messageBoxDisplayService.ShowError("Los montos no coiniden");
                return;
            }
            
            int sucursal = 1;
            ClienteMontoFavor clienteMontoFavor = new ClienteMontoFavor();
            clienteMontoFavor.Id = Guid.NewGuid();
            clienteMontoFavor.ClienteId = _cliente.Id;
            clienteMontoFavor.FechaComprobante = _clock.Now;
            clienteMontoFavor.TipoComprobanteId = TipoComprobanteEnum.SeñaCliente;
            clienteMontoFavor.LCN = "R" + sucursal.ToString().PadLeft(4, '0') + CalcularLCN().PadLeft(8, '0');
            clienteMontoFavor.Concepto = "Seña " + clienteMontoFavor.LCN;
            clienteMontoFavor.Importe = ucTotalesSeña.TotalPagar;
            clienteMontoFavor.ImpOcupado = 0;
            clienteMontoFavor.Observaciones = TipoComprobanteEnum.SeñaCliente.ToString();
            clienteMontoFavor.FechaAlta = _clock.Now;
            clienteMontoFavor.OperadorAltaId = Context.OperadorActual.Id;
            clienteMontoFavor.SucursalAltaId = 2;

            Uow.ClientesMontosFavor.Agregar(clienteMontoFavor);


            

            //Recibo recibo = new Recibo();
            //recibo.Id = Guid.NewGuid();
            //recibo.SucursalCompId = Context.SucursalActual.Id;
            //recibo.Tipo = "3";//TipoComprobanteEnum.SeñaCliente;
            //recibo.PuntoVenta = Context.SucursalActual.Id;
            //var ultimoRecibo = _reciboNegocio.Listado("FechaAlta", "DESC", Context.SucursalActual.Id).First();
            //int numero;
            //int reciboNumero = int.TryParse(ultimoRecibo.Numero.Substring(1), out numero) ? numero : 0;
            //recibo.Numero = "C" + (numero + 1).ToString().PadLeft(13, '0');
            //recibo.FechaPago = _clock.Now;
            //recibo.Total = ucTotalesSeña.TotalPagar;
            //recibo.CobradorId = 0;
            //recibo.OperadorAltaId = Context.OperadorActual.Id;
            //recibo.SucursalAltaId = Context.SucursalActual.Id;
            //recibo.FechaAlta = _clock.Now;

            //Uow.Recibos.Agregar(recibo);
            
            Uow.Commit();
            _messageBoxDisplayService.ShowSuccess("Seña generada con éxito");

            var crearSenia = FormFactory.Create<FrmComprobante>();
            crearSenia._concepto = "Seña de Cliente";
            crearSenia._LCN = clienteMontoFavor.LCN;
            var conv = new Conversion();

            crearSenia._montoTexto =  conv.enletras(ucTotalesSeña.TotalPagar.ToString());
            //crearSenia._montoTexto = "cien";
            //crearSenia.Show();

            BuscarHistorial();
            Limpiar();
        }

        private void Limpiar()
        {
            ucTotalesSeña.Pagos.Clear();
            ucTotalesSeña.RefrescarPagos();
        }

       
        private string CalcularLCN()
        {
            var ultimoLCN = Uow.ClientesMontosFavor.Listado().Where(c => c.SucursalAltaId == Context.SucursalActual.Id).OrderByDescending(c => c.FechaAlta).First().LCN;

            int lcn;
            int proximolcn = int.TryParse(ultimoLCN.Substring(5), out lcn) ? lcn : 0;
            return (proximolcn + 1).ToString();

        }

        private void GridSeñas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridSeñas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var senia = selectedRow.DataBoundItem as ClienteMontoFavor;

            if (senia == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Eliminar":
                    Anular(senia);
                    break;
            }
        }

        private void Anular(ClienteMontoFavor senia)
        {
            //Utiliar toda la seña
            if (senia.TipoComprobanteId==TipoComprobanteEnum.SeñaCliente)
            {
                var diferencia = senia.Importe - senia.ImpOcupado;
                if (diferencia == 0)
                    return;

                senia.ImpOcupado = senia.Importe;
                senia.FechaAnulacion = _clock.Now;
                senia.FechaModificacion = _clock.Now;
                senia.OperadorModificacionId = Context.OperadorActual.Id;
                senia.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.ClientesMontosFavor.Modificar(senia);
                //generar cajamovimientno
                Caja caja = this.Context.CajaActual;
                if (caja.Ingresos == null)
                    caja.Ingresos = 0;
                caja.Egresos += (float?)diferencia;
                if (caja.Saldo == null)
                    caja.Saldo = 0;
                caja.Saldo -= (float?)diferencia;
                caja.FechaModificacion = _clock.Now;
                caja.SucursalModificacionId = Context.SucursalActual.Id;//Sucursal del operador
                caja.OperadorModificacionId = (Context.OperadorActual.Id);//Id el operador

                Uow.Cajas.Modificar(caja);

                CajaMovimiento cajaMovimiento = new CajaMovimiento();
                cajaMovimiento.Id = Guid.NewGuid();
                cajaMovimiento.CajaId = caja.Id;
                cajaMovimiento.TipoMovimientoCajaId = TipoMovimientoCajaEnum.AnulaciónSeña;
                cajaMovimiento.TipoComprobante = TipoComprobanteEnum.SeñaCliente;
                cajaMovimiento.ComprobanteId = senia.Id;
                cajaMovimiento.Senia = 0;
                cajaMovimiento.Importe = diferencia;
                cajaMovimiento.ImpFac = 0;
                cajaMovimiento.PcAlta = Environment.MachineName;
                cajaMovimiento.SucursalAltaId = Context.SucursalActual.Id;//Sucursal del operador
                cajaMovimiento.OperadorAltaId = (Context.OperadorActual.Id);//Id el operador
                cajaMovimiento.FechaAlta = _clock.Now;
                Uow.CajaMovimientos.Agregar(cajaMovimiento);

                //Generaregreso??
                Uow.Commit();
                _messageBoxDisplayService.ShowSuccess("Anulación de seña exitosa");

                BuscarHistorial();
            }
            else
            {
                _messageBoxDisplayService.ShowError("No puede anular una nota de crédito");
            }
        }

        private void TabSeñas_SelectedPageChanged(object sender, EventArgs e)
        {
            if (TabSeñas.SelectedPage == TabSeñasHistorial)
                pnlMontoSenia.Visible=false;
            else
            {
                pnlMontoSenia.Visible = true;
            }
            
        }

        private void TxtMonto_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode== Keys.Enter)
                ucTotalesSeña.GenerarPagoAutoNuevo(Monto, FormaPago.Efectivo);
        }

        private void radButton1_Click(object sender, EventArgs e)
        {
            ucTotalesSeña.GenerarPagoAutoNuevo(Monto, FormaPago.Efectivo);
        }

      }
}
