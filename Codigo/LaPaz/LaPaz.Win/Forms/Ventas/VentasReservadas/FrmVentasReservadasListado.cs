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
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Consignaciones.Clientes;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Ventas.VentasReservadas
{
    public partial class FrmVentasReservadasListado : FormBaseListado
    {
        private readonly IClock _clock;
        private readonly IVentaReservadaNegocio _ventaReservadaNegocio;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmVentasReservadasListado(IClock clock, IFormFactory formFactory, IMessageBoxDisplayService messageBoxDisplayService, ILaPazUow uow,
            IVentaReservadaNegocio ventaReservadaNegocio,
                             IFormRegistry formRegistry)
        {
            Uow = uow;

            SortColumn = "FechaAlta";
            SortDirection = "DESC";

            SortColumnMappings = new Dictionary<string, string>();
            //SortColumnMappings["TipoDocumentoDi"] = "TiposDocumentosIdentidad.Abreviatura";

            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;
            _ventaReservadaNegocio = ventaReservadaNegocio;
            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GrillaFacturasReservadas.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = GrillaFacturasReservadas;
            this.MainPager = FacturaPager;
            this.Spinner = ucProgressSpinner1;
            
        }

        private void InicializarPaginador()
        {
            FacturaPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmVentasReservadasListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            this.GrillaFacturasReservadas.Columns["FechaAlta"].DataType = typeof(DateTime);
            this.GrillaFacturasReservadas.Columns["FechaAlta"].FormatString = "{0: dd/M/yyyy}";

            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            
            var currentPage = FacturaPager.CurrentPage;
            var pageSize = FacturaPager.PageSize;

            var facturasReservadas =
                await
                Task.Run(
                    () =>
                    _ventaReservadaNegocio.Listado(SortColumn, SortDirection, Context.OperadorActual.Id,Context.SucursalActual.Id, currentPage,
                                                   pageSize, out pageTotal));
                                                                     
            GrillaFacturasReservadas.DataSource = facturasReservadas.ToList();

            FacturaPager.UpdateState(pageTotal);

            return pageTotal;
        }

        private void GrillaFacturasReservadas_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GrillaFacturasReservadas.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var ventaReservada = selectedRow.DataBoundItem as VentaReservadaDto;

            if (ventaReservada == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
               case "ColumnaEditar":
                    Editar(ventaReservada.LCN);
                    break;
               case "ColumnaEditarConsignacion":
                    EditarConsigna(ventaReservada.LCN);
                    break;
               case "ColumnaEditarComentario":
                    EditarComentario(ventaReservada.NroReserva);
                    
                    break;
             }
            RefrescarListado();
        }

        private void EditarComentario(int Nroreserva)
        {
            //int nroComprobante;
            //int.TryParse(lcn.Substring(5), out nroComprobante);
            using (var formComentario = FormFactory.Create<FrmComentario>(Nroreserva))
            {
                formComentario.ComentarioAgregado += (o, comentario) =>
                {
                    VentaReservada reserva = Uow.VentasReservadas.Listado().Where(r => r.NroReserva == Nroreserva && r.SucReserva == Context.SucursalActual.Id).FirstOrDefault();
                    reserva.Comentario = comentario;
                    Uow.VentasReservadas.Modificar(reserva);
                    Uow.Commit();
                    formComentario.Close();
                };
                formComentario.ShowDialog();
            }
        }

        private void EditarConsigna(string lcn)
        {
            //abrirFrmConsignacionCliente Pasando nro de factura
            int nroComprobante;
            int.TryParse(lcn.Substring(5), out nroComprobante);
            using (var formEditar = FormFactory.Create<FrmRendirConsignacionCliente>(nroComprobante, ActionFormMode.Edit))
            {
                formEditar.FormBorderStyle = FormBorderStyle.FixedSingle;
                var result = formEditar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formEditar.Close();
                    RefrescarListado();
                }
            }
        }

        private void Editar(string lcn)
        {
            //abrirFrmCrearVentaPasando nnro de factura
            int nroComprobante;
            int.TryParse(lcn.Substring(5), out nroComprobante);
            using ( var formEditar = FormFactory.Create<FrmCrearVenta>(nroComprobante, ActionFormMode.Edit))
            {
                formEditar.FormBorderStyle = FormBorderStyle.FixedSingle;
                var result = formEditar.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formEditar.Close();
                    RefrescarListado();
                } 
            }
        }
    }
}
