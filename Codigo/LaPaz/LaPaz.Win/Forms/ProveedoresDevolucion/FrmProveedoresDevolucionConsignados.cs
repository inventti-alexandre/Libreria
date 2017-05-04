using System.Data.Entity;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Win.Enums;
using Telerik.WinControls.UI;
using LaPaz.Win.Model;
using LaPaz.Entidades;
using System.Linq;
using System.Drawing;
using System.Dynamic;
using LaPaz.Entidades.Dto;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Data;
using LaPaz.Win.Properties;
using LaPaz.Win.ProveedoresDevolucion;

namespace LaPaz.Win.Forms.ProveedoresDevolucion
{
    public partial class FrmProveedoresDevolucionConsignados : LaPaz.Win.Forms.FormBaseListado
    {


        #region Initialize Components

        private readonly IProveedorNegocio _proveedorNegocio;
        private readonly IClock _clock;
        private readonly MessageBoxDisplayService _messageBoxDisplayService;
        private Guid _pagoIdCtaCte;
        private Guid _pagoIdConsignacion;
        private int _celdasSeleccionadas = 0;
        private Proveedor _proveedor;
        private TipoComprobanteEnum _tipoComprobante= TipoComprobanteEnum.NotaCreditoProveedor;

        public event EventHandler DevolucionRealizada;

        public FrmProveedoresDevolucionConsignados(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio, IClock clock, MessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;

            Uow = uow;
            _clock = clock;
            SortColumn = "FechaAlta";
            SortDirection = "DESC";

            _proveedorNegocio = proveedorNegocio;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            //this.GridCtaCte.CellFormatting += this.Grilla_CellFormatting;

            //MainGrid = GridCtaCte;
            //MainPager = ProveedoreCtaCtePager;
            Spinner = ucProgressSpinner1;
        }

        private void FrmProveedoresDevolucion_Load(object sender, EventArgs e)
        {
            this.ucFiltroProveedor1.SeleccionarFinished+=UcFiltroProveedor1_SeleccionarFinished;
            this.ucTitulosDevolucion.VentaTitulosChanged += ucTitulosDevolucion_CompraTitulosChanged;

        }

        private void ucTitulosDevolucion_CompraTitulosChanged(object sender, IList<VentaTitulo> e)
        {
           LblImporte.Text = ucTitulosDevolucion.CalcularSubTotalDevolucion().ToString();
        }

        private void UcFiltroProveedor1_SeleccionarFinished(object sender, Proveedor proveedor)
        {
            ActualizarProveedor(proveedor);
        }

        private void ActualizarProveedor(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                _proveedor = proveedor;
                ucTitulosDevolucion.ActualizarProveedorId(_proveedor.Id);
                ucTitulosDevolucion.ActualizarOperacion(true);
            }
        }

       private void InicializarPaginador()
        {
           // ProveedoreCtaCtePager.RefreshActionAsync = RefrescarListado;
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var codigoProveedor = ucFiltroProveedor1.ProveedorId;

            //var page = ProveedoreCtaCtePager.CurrentPage;
            //var pageSize = ProveedoreCtaCtePager.PageSize;

            var proveedoresCtaCte =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorCtaCte(SortColumn, SortDirection, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, Context.SucursalActual.Id, 1, 50,
                                //, true, Context.SucursalActual.Id, ProveedoreCtaCtePager.CurrentPage, ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            var proveedoresConsignacion =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorConsignacion(SortColumn, SortDirection, null, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, null, null, true, Context.SucursalActual.Id, 1,50,
                                //, true, null, null, true, Context.SucursalActual.Id, ProveedoreCtaCtePager.CurrentPage,ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

          //  ProveedoreCtaCtePager.UpdateState(pageTotal);
           

            return pageTotal;
        }

        private void Filtered(object sender, Entidades.Proveedor e)
        {
            RefrescarListado();
        }

        public decimal SeñaAFavorProveedor(Guid? proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresSenias.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId
                                                   && ps.ImporteUsado < ps.Importe)
                                       .ToList();
            return proveedoresMontosFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteUsado.GetValueOrDefault());
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ucTitulosDevolucion.CalcularCantidad() > 0)
                GuardarDevolucion();
            else
            {
                _messageBoxDisplayService.ShowError("Debe Seleccionar por lo menos un título para devolución");
            }
        }


        private void GuardarDevolucion()
        {
            //Recorro y controlo que ninguna cantidad sea mayor a la disponible
            foreach (var devolucionesTitulos in ucTitulosDevolucion.TitulosDevolucion)
            {
                int? _cantidadTotal = devolucionesTitulos.Cantidad;

                if (devolucionesTitulos.CantidadConsignada < _cantidadTotal)
                {
                    _messageBoxDisplayService.ShowError("La cantidad devuleta es mayor a la cantidad disponible del libro: " + devolucionesTitulos.TituloNombre);
                    return;
                }
            }

            //Genero TitulosConsignacionesDevueltas
            Guid titulosConsignacionDevuelta = TitulosConsignacionesDevueltas(_proveedor.Id);

            foreach (var devolucionTitulo in ucTitulosDevolucion.TitulosDevolucion)
            {
                int? _cantidadTotal = devolucionTitulo.Cantidad;

                if (devolucionTitulo.CantidadConsignada >= _cantidadTotal)
                {
                    DescontarLibrosConsignados(_cantidadTotal, devolucionTitulo.TituloId);
                    ModificarTitulosConsignacion(devolucionTitulo.TituloId, _proveedor.Id, _cantidadTotal);
                    TitulosConsignacionesDevueltaDetalle(devolucionTitulo, _cantidadTotal, titulosConsignacionDevuelta);
                }

            }

            Uow.Commit();
            _messageBoxDisplayService.ShowSuccess("Devolución guardada correctamente");

            using (var crearComprobante = FormFactory.Create<FrmComprobanteDevolucion>(titulosConsignacionDevuelta))
            {
                crearComprobante.ShowDialog();
            }

            onDevolucionRealizada();
        }

        private void DescontarLibrosPropios(int? propio, Guid TituloId)
        {
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == TituloId && t.SucursalAltaId == Context.SucursalActual.Id);
            if (tituloStock != null)
            {
                tituloStock.StkPr -= propio;
                Uow.TitulosStock.Modificar(tituloStock);
            }
        }

        private void DescontarLibrosConsignados(int? propio, Guid TituloId)
        {
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == TituloId && t.SucursalId == Context.SucursalActual.Id);
            if (tituloStock != null)
            {
                tituloStock.StkCn -= propio;
                Uow.TitulosStock.Modificar(tituloStock);
            }
        }

        private void TitulosConsignacionesDevueltaDetalle(VentaTitulo devolucionTitulo, int? cantidad, Guid tituloconsignaciondevuelta)
        {
            TitulosConsignacionesDevueltasDetalle titulosConsignacionesDevueltasDetalle =
                new TitulosConsignacionesDevueltasDetalle();
            titulosConsignacionesDevueltasDetalle.Id = Guid.NewGuid();
            titulosConsignacionesDevueltasDetalle.TituloConsignacionDevueltaId = tituloconsignaciondevuelta;
            titulosConsignacionesDevueltasDetalle.TituloId = devolucionTitulo.TituloId;
            titulosConsignacionesDevueltasDetalle.Cantidad = cantidad ?? 0;
            Uow.TitulosConsignacionesDevueltasDetalles.Agregar(titulosConsignacionesDevueltasDetalle);
        }

        private Guid TitulosConsignacionesDevueltas(Guid proveedor)
        {
            TitulosConsignacionesDevuelta titulosConsignacionesDevuelta = new TitulosConsignacionesDevuelta();
            titulosConsignacionesDevuelta.Id = Guid.NewGuid();
            titulosConsignacionesDevuelta.ProveedorId = proveedor;
            titulosConsignacionesDevuelta.LCN = GenerarLcnTitulosDevolucion();
            titulosConsignacionesDevuelta.Observaciones = TxtObservaciones.Text;
            titulosConsignacionesDevuelta.FechaAlta = _clock.Now;
            titulosConsignacionesDevuelta.OperadorAltaId = Context.OperadorActual.Id;
            titulosConsignacionesDevuelta.SucursalAltaId = Context.SucursalActual.Id;
            Uow.TitulosConsignacionesDevueltas.Agregar(titulosConsignacionesDevuelta);
            return titulosConsignacionesDevuelta.Id;
        }

        private void ModificarTitulosConsignacion(Guid titulo, Guid proveedor, int? cantdevuelta)
        {
            //Busco las consignaciones de titulos y actualizo la columna CnVn
            var titulosConsignaciones =
                Uow.TitulosConsignaciones.Listado().Where(
                    tc => tc.TituloId == titulo && tc.SucursalAltaId == Context.SucursalActual.Id && tc.ProveedorId == proveedor && (tc.CntVn + tc.CntDev) < tc.CntCn).
                    OrderBy(tc => tc.FechaAlta);

            foreach (TitulosConsignacion tituloConsignacion in titulosConsignaciones)
            {
                if (cantdevuelta > 0)
                {
                    if (tituloConsignacion.CntCn - tituloConsignacion.CntVn - tituloConsignacion.CntDev >= cantdevuelta)
                    {
                        tituloConsignacion.CntDev += cantdevuelta ?? 0;
                        cantdevuelta = 0;
                    }
                    else
                    {
                        var disponible = tituloConsignacion.CntCn - tituloConsignacion.CntVn - tituloConsignacion.CntDev;
                        cantdevuelta -= disponible;
                        tituloConsignacion.CntDev = tituloConsignacion.CntCn;
                    }

                    tituloConsignacion.FechaModificacion = _clock.Now;
                    tituloConsignacion.OperadorModificacionId = Context.OperadorActual.Id;
                    tituloConsignacion.SucursalModificacionId = Context.SucursalActual.Id;

                    Uow.TitulosConsignaciones.Modificar(tituloConsignacion);
                }
            }
        }

        private void onDevolucionRealizada()
        {
            if (DevolucionRealizada != null)
            {
                DevolucionRealizada(this, new EventArgs());
            }

        }

        private string GenerarLcnTitulosDevolucion()
        {

            var ultimaDevolucion = Uow.TitulosConsignacionesDevueltas.Listado().Where(p => p.SucursalAltaId == Context.SucursalActual.Id)
                .OrderByDescending(p => p.FechaAlta).Take(1).FirstOrDefault();
            int lcnNuevo = 0;

            if (ultimaDevolucion != null)
            {
                var lcn = ultimaDevolucion.LCN.Substring(5);
                lcnNuevo = int.TryParse(lcn, out lcnNuevo) ? lcnNuevo : 0;
            }

            lcnNuevo += 1;
            string sucursal = Context.SucursalActual.SucursalNumero.ToString();
            return "X" + "000" + sucursal + lcnNuevo.ToString().PadLeft(8, '0');

        }
   
        #endregion

       
    }
}
