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

namespace LaPaz.Win.Forms.FrmProveedoresDevolucion
{
    public partial class FrmProveedoresDevolucion : LaPaz.Win.Forms.FormBaseListado
    {


        #region Initialize Components

        private readonly IProveedorNegocio _proveedorNegocio;
        private readonly IClock _clock;
        private readonly MessageBoxDisplayService _messageBoxDisplayService;
        private Guid _pagoIdCtaCte;
        private Guid _pagoIdConsignacion;
        private int _celdasSeleccionadas = 0;
        private Proveedor _proveedor;


        public event EventHandler ProveedoresCuentaCorriente;

        public FrmProveedoresDevolucion(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio, IClock clock, MessageBoxDisplayService messageBoxDisplayService)
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
            MainPager = ProveedoreCtaCtePager;
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
            ProveedoreCtaCtePager.RefreshActionAsync = RefrescarListado;
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

            var page = ProveedoreCtaCtePager.CurrentPage;
            var pageSize = ProveedoreCtaCtePager.PageSize;

            var proveedoresCtaCte =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorCtaCte(SortColumn, SortDirection, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, Context.SucursalActual.Id, ProveedoreCtaCtePager.CurrentPage, ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            var proveedoresConsignacion =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorConsignacion(SortColumn, SortDirection, null, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, null, null, true, Context.SucursalActual.Id, ProveedoreCtaCtePager.CurrentPage,
                                ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            //GridCtaCte.DataSource = proveedoresCtaCte;

            //GridConsignaciones.DataSource = proveedoresConsignacion;



            ProveedoreCtaCtePager.UpdateState(pageTotal);
           

            return pageTotal;
        }

       

        private void Filtered(object sender, Entidades.Proveedor e)
        {
            RefrescarListado();
            
            ActualizarMontos();
        }

      



       

        private void ActualizarMontos()
        {
           //ucTotalesCompraSeña1.GenerarPagoAuto(ucTotalesCompraSeña1.TotalPagar);
        }

        public decimal SeñaAFavorProveedor(Guid? proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresSenias.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId
                                                   && ps.ImporteUsado < ps.Importe)
                                       .ToList();
            return proveedoresMontosFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteUsado.GetValueOrDefault());
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
          GuardarDevolucion();           
        }

        private void DescontarLibros(int propio,int consignado,Guid TituloId)
        {
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == TituloId && t.SucursalAltaId == Context.SucursalActual.Id);
            if (tituloStock != null)
            {
                tituloStock.StkCn -= consignado;
                tituloStock.StkPr -= propio;
                Uow.TitulosStock.Modificar(tituloStock);
            }
        }

        private void GuardarDevolucion()
        {

            #region ProveedorMontoFavor
            ProveedoresMontosFavor proveedorMontoFavor = new ProveedoresMontosFavor();

            proveedorMontoFavor.Id = Guid.NewGuid();
            proveedorMontoFavor.ProveedorId = _proveedor.Id;
            proveedorMontoFavor.TipoComprobanteId = TipoComprobanteEnum.MontoFavorProveedor;
            proveedorMontoFavor.LCN = GenerarLcn();
            proveedorMontoFavor.Concepto = TxtConcepto.Text;
            proveedorMontoFavor.Importe = Convert.ToDecimal(LblImporte.Text);
            proveedorMontoFavor.ImporteOcupado = 0;
            proveedorMontoFavor.Observaciones = TxtObservaciones.Text;
            proveedorMontoFavor.FechaAlta = _clock.Now;
            proveedorMontoFavor.SucursalAltaId = Context.SucursalActual.Id;
            proveedorMontoFavor.OperadorAltaId = Context.OperadorActual.Id;

            Uow.ProveedoresMontosFavor.Agregar(proveedorMontoFavor);
            #endregion

            #region TitulosConsignacionesDevueltas
            //TitulosConsignacionesDevuelta titulosConsignacionesDevuelta = new TitulosConsignacionesDevuelta();

            #endregion

            #region ProveedorMontoFavorDetalle
            foreach (var devolucionTitulo in ucTitulosDevolucion.TitulosDevolucion)
            {
                int _propia = 0;
                int? _consignada = 0;
                int? _cantidadTotal = devolucionTitulo.Cantidad;
                ProveedoresMontosFavorDetalle proveedoresMontosFavorDetalle = new ProveedoresMontosFavorDetalle();
                proveedoresMontosFavorDetalle.Id = Guid.NewGuid();
                proveedoresMontosFavorDetalle.ProveedoresMontosFavor = proveedorMontoFavor.Id;
                proveedoresMontosFavorDetalle.TitulosId = devolucionTitulo.TituloId;
                _consignada = CalcularConsignadas(Convert.ToInt16(_cantidadTotal), devolucionTitulo.CantidadConsignada);
                _propia = CalcularPropias(Convert.ToInt16(_cantidadTotal), _consignada);
                proveedoresMontosFavorDetalle.CantidadPropia = _propia;
                proveedoresMontosFavorDetalle.CantidadConsignada = _consignada;
                proveedoresMontosFavorDetalle.FechaAlta = _clock.Now;
                proveedoresMontosFavorDetalle.SucursalAltaId = Context.SucursalActual.Id;
                proveedoresMontosFavorDetalle.OperadorAltaId = Context.OperadorActual.Id;
                Uow.ProveedoresMontosFavorDetalle.Agregar(proveedoresMontosFavorDetalle);

                DescontarLibros(_propia, Convert.ToInt16(_consignada), proveedoresMontosFavorDetalle.TitulosId);
            }
            #endregion

            
            Uow.Commit();
        }

        private int CalcularPropias(int cantidadTotal, int? consignada)
        {
            if (consignada < cantidadTotal)
                return (cantidadTotal - Convert.ToInt16(consignada));
            else
            {
                return 0;
            }

        }

        private int CalcularConsignadas(int _cantidadTotal,int? consignada)
        {
            if (consignada >= _cantidadTotal)
                return _cantidadTotal;
            else
            {
                return (Convert.ToInt16(consignada));
            }
            
        }

        private string GenerarLcn()
        {
             
            var ultimoPresupuesto = Uow.ProveedoresMontosFavor.Listado().Where(p => p.SucursalAltaId == Context.SucursalActual.Id)
                .OrderByDescending(p => p.FechaAlta).Take(1).FirstOrDefault();
            int lcnNuevo = 0;

            if (ultimoPresupuesto != null)
            {
                var lcn = ultimoPresupuesto.LCN.Substring(5);
                lcnNuevo = int.TryParse(lcn, out lcnNuevo) ? lcnNuevo : 0;
            }

            lcnNuevo += 1;

            return "X" + "0001" + lcnNuevo.ToString().PadLeft(8, '0');
          
        }



        

    

      


    }
}
