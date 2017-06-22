using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Forms.Ventas;
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
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class FrmConsignacionListado : FormBaseListado
    {
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Cliente _cliente;
        private readonly IRemitosVentaNegocio _remitoNegocio;
        public FrmConsignacionListado(IFormFactory formFactory, ILaPazUow uow,IRemitosVentaNegocio remitoNegocio)
        {
            FormFactory = formFactory;
            Uow = uow;
            InitializeComponent();

            //Fix para centrar columnas.
            this.GridConsignaciones.CellFormatting += this.Grilla_CellFormatting;

            MainGrid = GridConsignaciones;
            _remitoNegocio = remitoNegocio;
        }

        private void FrmConsignacionListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);

            this.ucBuscadorConsignacion1.BuscarConsignacionFinished += UcBuscadorConsignacionOnBuscarFinished;
            this.ucBuscadorConsignacion1.BuscarClienteFinished += UcBuscadorClienteOnBuscarFinished;
        }

        private void UcBuscadorConsignacionOnBuscarFinished(object sender, List<RemitosVenta> remitos)
        {
            if (remitos.Any())
            {
                if (remitos.Count == 1)
                {
                    Guid id = remitos[0].Id;
                    var remitoVenta = _remitoNegocio.GetById(id, Context.SucursalActual.Id).ToList();
                    GridConsignaciones.DataSource = remitoVenta;
                }
            }
            else
            {
                _messageBoxDisplayService.ShowWarning(Resources.ErrorBuscarConsignacionVacio);
            }
        }

        private void UcBuscadorClienteOnBuscarFinished(object sender, List<Cliente> clientes)
        {
            if (clientes.Any())
            {
                if (clientes.Count == 1)
                {
                    var id = clientes[0].Id;
                    var remitoVenta = _remitoNegocio.GetByClienteId(id, Context.SucursalActual.Id).ToList();
                    GridConsignaciones.DataSource = remitoVenta;
                }
                else
                {
                    //Mas de uno encontrado.
                    using (var seleccionarCliente = new FrmSeleccionarCliente(clientes))
                    {
                        seleccionarCliente.ClienteSelected += (o, cliente) =>
                        {
                            _cliente = cliente;
                            seleccionarCliente.Close();
                        };

                        seleccionarCliente.ShowDialog();
                        if (_cliente != null)
                        {
                            var id = _cliente.Id;
                            var remitoVenta = _remitoNegocio.GetByClienteId(id, Context.SucursalActual.Id).ToList();
                            GridConsignaciones.DataSource = remitoVenta;
                        }
                    }
                }
            }
        }

        private void GridConsignaciones_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GridConsignaciones.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var remitoVenta = selectedRow.DataBoundItem as RemitosVentaDto;

            if (remitoVenta == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Imprimir":
                    Imprimir(remitoVenta.Id);
                    break;
            }
        }

        private void Imprimir(Guid remitoVentaId)
        {
            using (var crearRemitoVenta = FormFactory.Create<FrmComprobanteConsignacion>(remitoVentaId))
            {
                crearRemitoVenta.RecargarDetalle = true;
                crearRemitoVenta.ShowDialog();
            }
        }

    }
}
