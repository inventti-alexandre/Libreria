using System;
using System.Linq;
using System.Security.Permissions;
using System.Windows.Forms;
using Framework.WinForm.Controls.Extensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio;
using LaPaz.Seguridad;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Forms.Autores;
using LaPaz.Win.Forms.Bancos;
using LaPaz.Win.Forms.CierreCaja;
using LaPaz.Win.Forms.Clientes;
using LaPaz.Win.Forms.Compras;
using LaPaz.Win.Forms.Consignaciones;
using LaPaz.Win.Forms.Consignaciones.Clientes;
using LaPaz.Win.Forms.Cuentas;
using LaPaz.Win.Forms.Libros;
using LaPaz.Win.Forms.LotesDeFacturas;
using LaPaz.Win.Forms.Operadores;
using LaPaz.Win.Forms.Presupuesto;
using LaPaz.Win.Forms.ProveedoresDevolucion;
using LaPaz.Win.Forms.Reportes;
using LaPaz.Win.Forms.Senias;
using LaPaz.Win.Forms.SubTemas;
using LaPaz.Win.Forms.Temas;
using LaPaz.Win.Forms.Tickets;
using LaPaz.Win.Forms.Proveedores;
using LaPaz.Win.Forms.ProveedoresCtaCte;
using LaPaz.Win.Forms.Editorial;
using LaPaz.Win.Forms.Util;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Forms.OrdenesPagos;
using LaPaz.Win.Forms.Ventas.AnulacionFacturas;
using LaPaz.Win.Forms.Ventas.CreditosDevolucion;
using LaPaz.Win.Forms.Ventas.VentasReservadas;
using LaPaz.Win.Helpers;
using LaPaz.Win.Properties;
using LaPaz.Win.Reportes;
using Telerik.WinControls;
using Telerik.WinControls.UI;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Forms.Seguridad;
using LaPaz.Win.Forms.Configuracion;
using System.Collections;
using System.Collections.Generic;

namespace LaPaz.Win.Forms
{
    [PrincipalPermission(SecurityAction.Demand)]
    public partial class FrmPrincipal : FormBase
    {
        private readonly IFormRegistry _formRegistry;
        private readonly ICajaNegocio _cajaNegocio;

        public FrmPrincipal(IFormFactory formFactory,
                            ILaPazUow uow,
                            IFormRegistry formRegistry,
                            ICajaNegocio cajaNegocio,
                            IUowFactory uowFactory)
        {
            FormFactory = formFactory;
            Uow = uow;
            UowFactory = uowFactory;

            _formRegistry = formRegistry;
            _cajaNegocio = cajaNegocio;

            InitializeComponent();
            HideCloseButtonInAccesosPage();
            ActualizarEstadoCierreCaja();
            ActualizarUsuarioActual();
            ToggleHabilitarMenuItems(MainMenu.Items);
        }

        private void ActualizarEstadoCierreCaja()
        {
            var estaCajaAbierta = _cajaNegocio.EstaUltimaCajaAbierta(Context.OperadorActual.Id,
                                                                     Context.SucursalActual.Id);

            LnkAbrirCerraCaja.Text = estaCajaAbierta
                ? Resources.LabelCerrarCaja
                : Resources.LabelAbrirCaja;

            BtnCrearVenta.ToggleEnableDisabled(estaCajaAbierta);
            BtnOrdenesPago.ToggleEnableDisabled(estaCajaAbierta);
            MiVentas.Enabled = estaCajaAbierta;
            MiPagosProgramados.Enabled = estaCajaAbierta;
            MiOrdenesPago.Enabled = estaCajaAbierta;
        }

        private void ActualizarUsuarioActual()
        {
            LnkUsuarioActual.Text = Context.OperadorActual.Usuario;
        }

        private void BtnLibrosListado_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmLibrosListado>();
            AbrirTab(pantalla);
        }

        private void BtnProveedoresListado_Click(object sender, EventArgs e)
        {
            //var pantalla = new LaPaz.Win.Forms.Proveedores.FrmProveedoresListado(FormFactory, Uow, new ProveedorNegocio(Uow), TipoProveedor.Normal);
            var pantalla = FormFactory.Create<FrmProveedoresListado>(TipoProveedor.Normal);
            pantalla.Text = "Proveedores";
            AbrirTab(pantalla);
        }

        private void BtnClienteListado_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmClienteListado>(0);
            AbrirTab(pantalla);
        }

        private void BtnTicketsConsulta_Click(object sender, EventArgs e)
        {
            using (var pantalla = FormFactory.Create<FrmCrearEditarTicket>())
            {
                pantalla.ShowDialog();
            }
        }

        private void BtnCrearVenta_Click(object sender, EventArgs e)
        {
            var crearVenta = FormFactory.Create<FrmCrearVenta>(default(int), ActionFormMode.Create);
            crearVenta.VentaRealizada += CrearVentaOnVentaRealizada;
            AbrirMultipleTab(crearVenta);
        }

        private void CrearVentaOnVentaRealizada(object sender, EventArgs eventArgs)
        {
            var form = sender as Form;
            if (form != null)
            {
                var crearVenta = FormFactory.Create<FrmCrearVenta>(default(int), ActionFormMode.Create);
                crearVenta.VentaRealizada += CrearVentaOnVentaRealizada;
                RefrescarTab(form, crearVenta);
            }
        }

        private void BtnCrearCompra_Click(object sender, EventArgs e)
        {
            var crearCompra = FormFactory.Create<FrmCrearCompra>();
            crearCompra.CompraRealizada += CrearCompraOnCompraRealizada;
            AbrirTab(crearCompra);
        }

        private void CrearCompraOnCompraRealizada(object sender, EventArgs eventArgs)
        {
            var form = sender as Form;
            if (form != null)
            {
                CerrarTab(form);
            }
        }

        private void CrearDevolucionOnDevolucionRealizada(object sender, EventArgs eventArgs)
        {
            var form = sender as Form;
            if (form != null)
            {
                CerrarTab(form);
            }
        }

        public void AbrirTab(Form form)
        {
            form.Cursor = Cursors.WaitCursor;
            var page = TabsPrincipal.Pages.FirstOrDefault(p => p.Text == form.Text);

            if (page == null)
            {
                page = GetPage(form);
            }

            TabsPrincipal.SelectedPage = page;
            form.Cursor = Cursors.Default;

            _formRegistry.AddForm(form);
        }

        private RadPageViewPage GetPage(Form form)
        {
            RadPageViewPage page;
            form.Owner = this;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            page = new RadPageViewPage();
            page.AutoScroll = true;
            form.Parent = page;
            page.Text = form.Text;
            page.Controls.Add(form);
            TabsPrincipal.Pages.Add(page);
            form.Show();

            return page;
        }

        private RadPageViewPage UpadatePage(RadPageViewPage page, Form form)
        {
            form.Owner = this;
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            page.AutoScroll = true;
            form.Parent = page;
            page.Text = form.Text;
            page.Controls.Clear();
            page.Controls.Add(form);
            form.Show();

            page.Refresh();

            return page;
        }

        public void AbrirMultipleTab(Form form)
        {
            form.Cursor = Cursors.WaitCursor;

            var page = GetPage(form);

            form.Cursor = Cursors.Default;

            TabsPrincipal.SelectedPage = page;

            _formRegistry.AddForm(form);
        }

        private void CerrarTab(Form form)
        {
            form.Cursor = Cursors.WaitCursor;

            var page = TabsPrincipal.Pages.FirstOrDefault(p => p == form.Parent);

            if (page != null)
            {
                TabsPrincipal.Pages.Remove(page);
            }

            form.Cursor = Cursors.Default;
        }

        private void RefrescarTab(Form currentForm, Form newForm)
        {
            this.Cursor = Cursors.WaitCursor;

            var page = TabsPrincipal.Pages.FirstOrDefault(p => p.Text == currentForm.Text);

            page = UpadatePage(page, newForm);

            TabsPrincipal.SelectedPage = page;

            _formRegistry.RemoveForm(currentForm);

            _formRegistry.AddForm(newForm);

            this.Cursor = Cursors.Default;
        }

        private void TabsPrincipal_SelectedPageChanging(object sender, RadPageViewCancelEventArgs e)
        {
            if (e.Page == PageAccesos)
            {
                ToggleStripPageClose(false);
            }
            else
            {
                ToggleStripPageClose(true);
            }
        }

        private void ToggleStripPageClose(bool show)
        {
            var pageViewStripElement = TabsPrincipal.ViewElement as RadPageViewStripElement;
            if (pageViewStripElement != null)
            {
                pageViewStripElement.ShowItemCloseButton = show;
                pageViewStripElement.StripButtons = show ? StripViewButtons.Auto : StripViewButtons.Scroll;
            }
        }

        private void HideCloseButtonInAccesosPage()
        {
            ToggleStripPageClose(false);
            PageAccesos.Item.ButtonsPanel.CloseButton.Visibility = ElementVisibility.Collapsed;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnOrdenesPago_Click(object sender, EventArgs e)
        {
            var pantalla = new FrmOrdenesPagosListado(FormFactory, Uow, new OrdenPagoNegocio(Uow));
            pantalla.Text = "Ordenes de Pagos";
            AbrirTab(pantalla);
        }

        private void BtnCrearSeña_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCrearSenia>(Guid.Empty, ActionFormMode.Create);
            AbrirTab(pantalla);
        }

        private void BtnCrearDevolucion_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCreditoDevolucion>();
            AbrirTab(pantalla);
        }

        private void BtnInformeCaja_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmInformeCaja>();
            AbrirTab(pantalla);
        }

        private void LnkAbrirCerraCaja_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_cajaNegocio.EstaUltimaCajaAbierta(Context.OperadorActual.Id, Context.SucursalActual.Id))
            {
                using (var frmCerrarCaja = FormFactory.Create<FrmCerrarCaja>())
                {
                    var result = frmCerrarCaja.ShowDialog();
                    if (result == DialogResult.OK)
                        ActualizarEstadoCierreCaja();
                }
            }
            else
            {
                using (var frmAbrirCaja = FormFactory.Create<FrmAbrirCaja>())
                {
                    var result = frmAbrirCaja.ShowDialog();
                    if (result == DialogResult.OK)
                        ActualizarEstadoCierreCaja();
                }
            }
        }

        private void LnkUsuarioActual_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var frmDetalleOperador = FormFactory.Create<FrmDetalleOperador>())
            {
                frmDetalleOperador.ShowDialog();
            }
        }

        private void BtnSeñaProveedor_Click(object sender, EventArgs e)
        {
            var crearSeñaProveedor = FormFactory.Create<FrmCrearSeniaProveedor>();
            AbrirTab(crearSeñaProveedor);
        }

        private void MiAsignarFuncionesARoles_Click(object sender, EventArgs e)
        {
            using (var form = FormFactory.Create<FrmAsignarFuncionesARoles>())
            {
                form.ShowDialog();
            }
        }

        private void BtnPagosProgramdos_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmPagosProgramadosListado>(0);
            AbrirTab(pantalla);
        }

        private void MiUsuariosListado_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmUsuariosListado>(0);
            AbrirTab(pantalla);
        }

        private void btnFacturasReservadas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmVentasReservadasListado>();
            pantalla.Owner = this;
            AbrirTab(pantalla);
        }

        private void rmiConfiguracion_Click(object sender, EventArgs e)
        {
            using (var form = FormFactory.Create<FrmParametrosConfiguracion>())
            {
                form.ShowDialog();
            }
        }

        private void MiVentas_Click(object sender, EventArgs e)
        {
            var crearVenta = FormFactory.Create<FrmCrearVenta>(default(int), ActionFormMode.Create);
            crearVenta.Closed += CrearVentaOnVentaRealizada;
            AbrirMultipleTab(crearVenta);
        }

        private void MiSenias_Click(object sender, EventArgs e)
        {

        }

        private void MiDevoluciones_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCreditoDevolucion>();
            AbrirTab(pantalla);
        }

        private void MiFacturasReservadas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmVentasReservadasListado>();
            AbrirTab(pantalla);
        }

        private void radMenuItem3_Click(object sender, EventArgs e)
        {
            //var pantalla = new LaPaz.Win.Forms.Proveedores.FrmProveedoresListado(FormFactory, Uow, new ProveedorNegocio(Uow), TipoProveedor.Normal);
            var pantalla = FormFactory.Create<FrmProveedoresListado>(TipoProveedor.Normal);
            pantalla.Text = "Proveedores";
            AbrirTab(pantalla);
        }

        private void MiProveedoresGastos_Click(object sender, EventArgs e)
        {
            //var pantalla = new LaPaz.Win.Forms.Proveedores.FrmProveedoresListado(FormFactory, Uow, new ProveedorNegocio(Uow), TipoProveedor.Gastos);
            var pantalla = FormFactory.Create<FrmProveedoresListado>(TipoProveedor.Gastos);
            pantalla.Text = "Proveedores Gastos";
            AbrirTab(pantalla);
        }

        private void MiOrdenesPago_Click(object sender, EventArgs e)
        {
            var pantalla = new FrmOrdenesPagosListado(FormFactory, Uow, new OrdenPagoNegocio(Uow));
            pantalla.Text = "Ordenes de Pagos";
            AbrirTab(pantalla);
        }

        private void MiPagosProgramados_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmPagosProgramadosListado>(0);
            AbrirTab(pantalla);
        }

        private void MiCompraLibros_Click(object sender, EventArgs e)
        {
            var crearCompra = FormFactory.Create<FrmCrearCompra>();
            crearCompra.CompraRealizada += CrearCompraOnCompraRealizada;
            AbrirTab(crearCompra);
        }

        private void MiSeniasProveedores_Click(object sender, EventArgs e)
        {
            var crearSeñaProveedor = FormFactory.Create<FrmCrearSeniaProveedor>();
            AbrirTab(crearSeñaProveedor);
        }

        private void MiLibros_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmLibrosListado>();
            AbrirTab(pantalla);
        }

        private void MiAutores_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmAutoresListado>(0);
            AbrirTab(pantalla);
        }

        private void MiTemas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmTemasListado>(0);
            AbrirTab(pantalla);
        }

        private void MiSubTemas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmSubTemasListado>(0);
            AbrirTab(pantalla);
        }

        private void MiClientes_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmClienteListado>(0);
            AbrirTab(pantalla);
        }

        private void MiBancos_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmBancoListado>(0);
            AbrirTab(pantalla);
        }

        private void MiInformeCaja_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmInformeCaja>();
            AbrirTab(pantalla);
        }

        private void MiTicketConsulta_Click(object sender, EventArgs e)
        {
            using (var pantalla = FormFactory.Create<FrmCrearEditarTicket>())
            {
                pantalla.ShowDialog();
            }
        }

        private void MiCajaResumida_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCajaResumida>();
            AbrirTab(pantalla);
        }

        private void MiReporteTarjetasCheques_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmTarjetasChequesYDepositos>();
            AbrirTab(pantalla);
        }

        private void radMenuItem1_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmLoteFacturaListado>();
            AbrirTab(pantalla);
        }

        private void radMenuItem2_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmAnulacionFactura>();
            pantalla.AccionRealizada += CrearVentaOnVentaRealizada;
            AbrirTab(pantalla);

        }

        private void MiReporteConsignacionesVendidas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmConsignacionesVendidas>();
            AbrirTab(pantalla);
        }

        private void ToggleHabilitarMenuItems(RadItemOwnerCollection items)
        {
            foreach (object item in items)
            {
                var subItem = item as RadMenuItem;
                if (subItem != null)
                {
                    if (subItem.Items.Any())
                    {
                        subItem.Enabled = IsItemEnabled(subItem);
                        ToggleHabilitarMenuItems(subItem.Items);
                    }
                    else
                    {
                        subItem.Enabled = IsItemEnabled(subItem);
                    }
                }
            }
        }

        private bool IsItemEnabled(RadMenuItem item)
        {
            var rolesPermitidos = item.Tag != null ? item.Tag.ToString().Split(',') : new string[0];
            return item.Tag == null || (item.Tag != null && rolesPermitidos.Any(r => this.Context.IsInRole(r)));
        }

        private void MiSeñaConMovimiento_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCrearSenia>(Guid.Empty, ActionFormMode.Create);
            pantalla.Text = "Nueva Seña";
            AbrirTab(pantalla);
        }

        private void MiSeñaSinMovimiento_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCrearSenia>(Guid.Empty, ActionFormMode.Edit);
            pantalla.Text = "Seña Existente";
            AbrirTab(pantalla);
        }

        private void BtnCrearSeñaSinMovimiento_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCrearSenia>(Guid.Empty, ActionFormMode.Edit);
            pantalla.Text = "Seña Existente";
            AbrirTab(pantalla);
        }

        private void MiMovimientosCajaAnterior_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmMovimientosCajaAnterior>();
            AbrirTab(pantalla);
        }

        private void rMnPresupuesto_Click(object sender, EventArgs e)
        {
            var crearPresupuesto = FormFactory.Create<FrmCrearPresupuesto>();
            crearPresupuesto.PresupuestoRealizado += CrearVentaOnVentaRealizada;
            AbrirTab(crearPresupuesto);
        }

        private void btnListadoCompras_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmComprasListado>();
            AbrirTab(pantalla);
        }

        private void MiSubEditoriales_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmEditorialListado>();
            AbrirTab(pantalla);
        }

        private void MiReporteVentas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmReporteVentas>();
            AbrirTab(pantalla);
        }

        private void MiReporteLibros_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmReporteLibrosListado>();
            AbrirTab(pantalla);
        }

        private void MiCuentas_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmCuentasListado>();
            AbrirTab(pantalla);
        }

        private void MiVentasListado_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmVentasListado>();
            AbrirTab(pantalla);
        }
        private void MiConsignacionesSinRendir_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmRendicionConsignaciones>();
            AbrirTab(pantalla);
        }

        private void MiPresupuestoListado_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmPresupuestoListado>();
            AbrirTab(pantalla);
        }

        private void MiReporteRanking_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmMultiRanking>();
            AbrirTab(pantalla);
        }

        private void BtnProveedoresCtaCte_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmProveedoresCtaCte>(Guid.Empty, ActionFormMode.Create);
            pantalla.ProveedoresCuentaCorriente += CrearVentaOnVentaRealizada;
            AbrirTab(pantalla);

        }

        private void BtnConsignaciones_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmConsignacionCliente>(Guid.Empty, ActionFormMode.Create);
            AbrirTab(pantalla);
        }

        private void MiDevolverConsignaciones_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmDevolucionConsignaciones>();
            AbrirTab(pantalla);
        }

        private void BtnRendirConsignacion_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmRendirConsignacionCliente>(0, ActionFormMode.Create);
            AbrirTab(pantalla);
        }

        private void MiRendirConsignacionCliente_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmRendirConsignacionCliente>(0, ActionFormMode.Create);
            AbrirTab(pantalla);
        }

        private void MiConsignacionesProveedorHistorial_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmHistorialConsignaciones>();
            AbrirTab(pantalla);
        }

        private void BtnProveedoresDevolucion_Click(object sender, EventArgs e)
        {
            var crearDevolucion = FormFactory.Create<FrmProveedoresDevolucion.FrmProveedoresDevolucion>();
            crearDevolucion.DevolucionRealizada += CrearDevolucionOnDevolucionRealizada;
            AbrirTab(crearDevolucion);
        }

        private void radMenuItem5_Click(object sender, EventArgs e)
        {
            var pantalla = FormFactory.Create<FrmProveedorGeneral>();
            AbrirTab(pantalla);
        }

        private void BtnProveedoresdevConsig_Click(object sender, EventArgs e)
        {
            var crearDevolucion = FormFactory.Create<FrmProveedoresDevolucionConsignados>();
            crearDevolucion.DevolucionRealizada += CrearDevolucionOnDevolucionRealizada;
            AbrirTab(crearDevolucion);
        }

        
    }
}

