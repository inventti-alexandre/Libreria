using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Migracion;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Helpers;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using LaPaz.Seguridad;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class FrmSeleccionarLibro : EditFormListadoBase
    {
        private readonly IClock _clock;
        private readonly ITituloNegocio _tituloNegocio;
        private readonly IPaseLibroNegocio _paseLibroNegocio;
        private readonly IRepository<TituloStockMigracion> _migracionRepo;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private bool _cargandoCantidad;
        TituloDto _tituloseleccionado = new TituloDto();
        private decimal? _precioVentaActual;
        private Guid _Tituloid = Guid.Empty;
        private bool _libroPasado = false;
        private bool _cambiaPrecio = false;

        public FrmSeleccionarLibro(IClock clock, IFormFactory formFactory,
                                   IRepository<TituloStockMigracion> migracionRepo,
                                   ILaPazUow uow,
                                   ITituloNegocio tituloNegocio,
                                   IMessageBoxDisplayService messageBoxDisplayService,
                                   IPaseLibroNegocio paseLibroNegocio, Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;

            _clock = clock;
            _paseLibroNegocio = paseLibroNegocio;

            InitializeComponent();

            _migracionRepo = migracionRepo;
            _messageBoxDisplayService = messageBoxDisplayService;
            _tituloNegocio = tituloNegocio;
            _Tituloid = id;

            ConfigurarColumnas();

            this.MainGrid = GridTitulos;
            this.MainPager = TitulosPager;

            this.UcFiltrosLibros.CkbEliminados.Visible = false;

            InicializarPaginador();
        }

        private void ConfigurarColumnas()
        {
            this.GridTitulos.Columns["FModificacion"].FormatString = "{0: d/M/yyyy}";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["Titulo"] = "NombreTitulo";
            SortColumnMappings["Codigo"] = "Cod";
            SortColumnMappings["Autor"] = "Autor.Nombre";
            SortColumnMappings["PVenta"] = "PrecioVentaTitulo";

            SortColumn = "NombreTitulo";
            SortDirection = "ASC";
        }

        public event EventHandler<VentaTitulo> TituloAgregado;

        #region Propiedades

        public Guid Id
        {
            get { return ((TituloDto)GridTitulos.CurrentRow.DataBoundItem).Id; }
        }

        public string Cod
        {
            get { return ((TituloDto)GridTitulos.CurrentRow.DataBoundItem).Cod; }
        }

        public string CodigoBarra
        {
            get { return ((TituloDto)GridTitulos.CurrentRow.DataBoundItem).CodigoBarra; }
        }

        public string TituloNombre
        {
            get { return ((TituloDto)GridTitulos.CurrentRow.DataBoundItem).NombreTitulo; }
        }

        public Guid? TituloProveedorId
        {
            get { return ((TituloDto)GridTitulos.CurrentRow.DataBoundItem).ProveedorId; }
        }

        public decimal? PrecioVenta
        {
            get
            {
                decimal precioventa;
                return decimal.TryParse(DTxtPrecioVenta.Text, out precioventa) ? precioventa : (decimal?)null;
            }
            set
            {
                _precioVentaActual = value;
                DTxtPrecioVenta.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;

            }
        }

        public decimal? PrecioBase
        {
            get
            {
                decimal preciobase;
                return decimal.TryParse(DTxtPrecioVenta.Text, out preciobase) ? preciobase : (decimal?)null;
            }
            set { DTxtPrecioVenta.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }

        public int? Cantidad
        {
            get
            {
                int cantidad;
                return int.TryParse(TxtCantidad.Text, out cantidad) ? cantidad : (int?)null;
            }
            set
            {
                TxtCantidad.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? CantidadPropia
        {
            get
            {
                int propio;
                return int.TryParse(TxtPropio.Text, out propio) ? propio : (int?)null;
            }
            set
            {
                TxtPropio.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? CantidadConsignada
        {
            get
            {
                int consignado;
                return int.TryParse(TxtConsignado.Text, out consignado) ? consignado : (int?)null;
            }
            set
            {
                TxtConsignado.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        //Propiedades de los Txt de Migracion

        public int? MigracionCantidadPropia
        {
            get
            {
                int migracionpropio;
                return int.TryParse(TxtMigracionPropio.Text, out migracionpropio) ? migracionpropio : (int?)null;
            }
            set
            {
                TxtMigracionPropio.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? MigracionCantidadConsignada
        {
            get
            {
                int migracionconsignado;
                return int.TryParse(TxtMigracionConsignado.Text, out migracionconsignado) ? migracionconsignado : (int?)null;
            }
            set
            {
                TxtMigracionConsignado.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? Descuento
        {
            get
            {
                int descuento;
                return int.TryParse(TxtDescuento.Text, out descuento) ? descuento : (int?)null;
            }
            set
            {
                TxtDescuento.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public decimal? SubTotal
        {
            get
            {
                decimal subtotal;
                return decimal.TryParse(TxtSubtotal.Text, out subtotal) ? subtotal : (decimal?)null;
            }
            set
            {
                TxtSubtotal.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        #endregion

        private void InicializarPaginador()
        {
            TitulosPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmSeleccionarLibro_Load(object sender, EventArgs e)
        {
            this.Spinner = UcFiltrosLibros.Spinner;
            base.EditFormListadoBase_Load(sender, e);
            GridTitulos.AutoGenerateColumns = false;
            //RefrescarListado();
            UcFiltrosLibros.Filtered += Filtered;
            if (_Tituloid != Guid.Empty)
            {
                CargarTitulo(_Tituloid);
            }

            //deshabilito los botones de pase de stock
            BtnPaseConsignacion.Enabled = false;
            BtnPasarLibro.Enabled = false;
            if (!Context.IsInRole(RolesNames.Admin) || !Context.IsInRole(RolesNames.Administrativo) || !Context.IsInRole(RolesNames.SuperAdmin))
                BtnPaseConsignacion.Visible = false;

        }

        private void CargarTitulo(Guid _Tituloid)
        {
            UcFiltrosLibros.Spinner.Show();

            int pageTotal = 0;

            var codigoProveedor = UcFiltrosLibros.CodigoProveedor;
            var codigoLibroCompleto = Uow.Titulos.Obtener(t => t.Id == _Tituloid).Cod;
            var isbn = UcFiltrosLibros.ISBN;
            var nombreTitulo = UcFiltrosLibros.NombreTitulo;
            var proveedorId = UcFiltrosLibros.ProveedorId;
            var temaId = UcFiltrosLibros.TemaId;
            var autorNombre = UcFiltrosLibros.AutorNombre;
            var editorialId = UcFiltrosLibros.EditorialId;
            var conStock = UcFiltrosLibros.ConStock;
            var sucursalId = this.Context.SucursalActual.Id;
            var conOchoDeMarzo = UcFiltrosLibros.OchoDeMarzo;
            string codigoBarra = UcFiltrosLibros.CodigoBarra;
            var activos = UcFiltrosLibros.Activos;

            var titulos = _tituloNegocio.Listado(SortColumn, SortDirection, codigoProveedor, codigoLibroCompleto, isbn,
                                                 codigoBarra, nombreTitulo, proveedorId, temaId,
                                                 autorNombre, editorialId, conStock, sucursalId, conOchoDeMarzo,
                                                 activos, TitulosPager.CurrentPage,
                                                 TitulosPager.PageSize,
                                                 out pageTotal);

            GridTitulos.DataSource = titulos;

            TitulosPager.UpdateState(pageTotal);

            Spinner.Hide();
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            UcFiltrosLibros.Spinner.Show();

            int pageTotal = 0;

            var codigoProveedor = UcFiltrosLibros.CodigoProveedor;
            var codigoLibroCompleto = UcFiltrosLibros.CodigoLibroCompleto;
            var isbn = UcFiltrosLibros.ISBN;
            var nombreTitulo = UcFiltrosLibros.NombreTitulo;
            var proveedorId = UcFiltrosLibros.ProveedorId;
            var temaId = UcFiltrosLibros.TemaId;
            var autorNombre = UcFiltrosLibros.AutorNombre;
            var editorialId = UcFiltrosLibros.EditorialId;
            var conStock = UcFiltrosLibros.ConStock;
            var sucursalId = this.Context.SucursalActual.Id;
            var conOchoDeMarzo = UcFiltrosLibros.OchoDeMarzo;
            var codigoBarra = UcFiltrosLibros.CodigoBarra;
            var activos = UcFiltrosLibros.Activos;

            var titulos =
                await
                Task.Run(
                    () =>

                    _tituloNegocio.Listado(SortColumn, SortDirection, codigoProveedor, codigoLibroCompleto, isbn,
                                           codigoBarra, nombreTitulo, proveedorId, temaId,
                                           autorNombre, editorialId, conStock, sucursalId, conOchoDeMarzo,
                                           activos, TitulosPager.CurrentPage,
                                           TitulosPager.PageSize,
                                           out pageTotal));

            GridTitulos.DataSource = titulos;

            TitulosPager.UpdateState(pageTotal);

            Spinner.Hide();

            BtnSeleccionar.Enabled = pageTotal != 0;

            return pageTotal;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            //mandar libro
            VentaTitulo titulo = ObtenerTitulo();

            //controlar si se modifica el precio de venta y si hay descuento
            if (PrecioVenta > _precioVentaActual)
            {
                ActualizarPrecioTitulos(titulo);

                PrecioBase = PrecioVenta;
            }

            var porcentaje = Descuento;
            var porcentajeNoAutorizado = porcentaje > Context.SucursalActual.MaximoPorcentajeDescuento;

            if (porcentajeNoAutorizado)
            {
                var operador = this.ObtenerOperadorAdministrador();

                if (operador == null)
                {
                    return;
                }
            }

            var esValido = this.ValidarForm();
            var cant = ValidarCantidad();

            if ((esValido) && (cant))
            {
                OnTituloAgregado(titulo);
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void RevertirPrecioOriginal(VentaTitulo titulo)
        {
            PrecioVenta = _precioVentaActual;

            titulo.PrecioVenta = PrecioVenta;

            ActualizarSubtotal();

            titulo.SubTotal = this.SubTotal;
        }

        private void ActualizarPrecioTitulos(VentaTitulo titulo)
        {
            List<Titulo> titulosModificar;
            if (String.IsNullOrEmpty(titulo.CodigoBarra))
                titulosModificar = Uow.Titulos.Listado().Where(t => t.Id == titulo.TituloId).ToList();
            else
            {
                int codigo;
                int codBarra = int.TryParse(titulo.CodigoBarra, out codigo) ? codigo : codigo;
                if (codBarra==0)
                    titulosModificar = Uow.Titulos.Listado().Where(t => t.Id == titulo.TituloId).ToList();
                else
                titulosModificar = Uow.Titulos.Listado().Where(t => t.CodigoBarra == titulo.CodigoBarra).ToList();
            }
            

            if (titulosModificar != null)
            {
                foreach (var tituloModificar in titulosModificar)
                {
                    tituloModificar.PrecioVentaTitulo = PrecioVenta;
                    tituloModificar.OperadorModificacionId = Context.OperadorActual.Id;
                    tituloModificar.FechaModificacion = _clock.Now;
                    tituloModificar.SucursalModificacionId = Context.SucursalActual.Id;
                    tituloModificar.UbicacionId = null;
                    tituloModificar.OperadorUltimoPrecioId = this.Context.OperadorActual.Id;

                    Uow.Titulos.Modificar(tituloModificar);
                }
                Uow.Commit();
            }
            Uow.Commit();
        }

        private void OnTituloAgregado(VentaTitulo titulo)
        {
            if (TituloAgregado != null)
            {
                TituloAgregado(this, titulo);
            }
        }

        private VentaTitulo ObtenerTitulo()
        {
            VentaTitulo ventaTitulo = new VentaTitulo();

            ventaTitulo.TituloId = Id;
            ventaTitulo.Cod = Cod;
            ventaTitulo.CodigoBarra = CodigoBarra;
            ventaTitulo.TituloNombre = TituloNombre;
            ventaTitulo.Cantidad = Cantidad;
            ventaTitulo.CantidadPropia = CantidadPropia;
            ventaTitulo.CantidadConsignada = CantidadConsignada;
            if (PrecioBase > _tituloseleccionado.PrecioVentaTitulo)
                ventaTitulo.PrecioBase = PrecioVenta;
            else
                ventaTitulo.PrecioBase = _tituloseleccionado.PrecioVentaTitulo;//PrecioVenta;
            ventaTitulo.PrecioVenta = PrecioVenta;
            ventaTitulo.Descuento = Descuento;
            ventaTitulo.SubTotal = SubTotal;
            ventaTitulo.ProveedorId = _tituloseleccionado.ProveedorId;

            return ventaTitulo;
        }

        protected override object ObtenerEntidad()
        {
            return this.ObtenerTitulo();
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(DTxtPrecioVenta, "PrecioVenta");
        }

        private void GridTitulos_DoubleClick(object sender, EventArgs e)
        {
            InformacionDeLibro();
        }

        private void InformacionDeLibro()
        {
            if (GridTitulos.RowCount > 0)
            {
                _tituloseleccionado = (TituloDto)GridTitulos.CurrentRow.DataBoundItem;
                var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
                var migracionTituloStock = _migracionRepo.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);

                //controlo que no venga null el stock del sistema
                if (tituloStock != null)
                {
                    CantidadPropia = tituloStock.StkPr ?? 0;
                    CantidadConsignada = tituloStock.StkCn ?? 0;
                }
                else
                {
                    CantidadPropia = 0;
                    CantidadConsignada = 0;
                }

                //controlo que no venga null el stock migrado
                if (migracionTituloStock != null)
                {
                    MigracionCantidadPropia = migracionTituloStock.StkPr ?? 0;
                    MigracionCantidadConsignada = migracionTituloStock.StkCn ?? 0;

                }
                else
                {
                    MigracionCantidadPropia = 0;
                    MigracionCantidadConsignada = 0;

                }

                HabilitarControles(CantidadPropia, CantidadConsignada, MigracionCantidadPropia, MigracionCantidadConsignada);

                _cargandoCantidad = true;
                Cantidad = 1;
                _cargandoCantidad = false;

                Descuento = null;
                _cambiaPrecio = false;
                PrecioVenta = _tituloseleccionado.PrecioVentaTitulo;
                SubTotal = PrecioVenta;
            }
        }

        private void HabilitarControles(int? cantidadPropia, int? cantidadConsignada, int? migracionCantidadPropia, int? migracionCantidadConsignada)
        {
            if ((_tituloseleccionado.ProveedorDenominacion == "FUTURO DISTRIBUIDORA DEL S.A." || _tituloseleccionado.ProveedorDenominacion == "JOURNAL EDICIONES"))
            {
                if (Context.IsInRole(RolesNames.Admin) || Context.IsInRole(RolesNames.Administrativo) || Context.IsInRole(RolesNames.SuperAdmin))
                    BtnPaseConsignacion.Visible = true;
                BtnPasarLibro.Visible = false;

                // Controlo las cantidades propias y consignadas si son 0 ambos deshabilito el btnSeleccionar
                if (cantidadConsignada == 0 && cantidadPropia == 0)
                    BtnSeleccionar.Enabled = false;
                else
                    BtnSeleccionar.Enabled = true;

                // Controlo las cantidades propias y consignadas de migracion si son 0 ambos deshabilito el btnPasarLibro
                if (migracionCantidadConsignada == 0 && migracionCantidadPropia == 0)
                    BtnPaseConsignacion.Enabled = false;
                else
                    BtnPaseConsignacion.Enabled = true;
            }
            else
            {
                BtnPaseConsignacion.Visible = false;
                BtnPasarLibro.Visible = true;
                BtnPasarLibro.Enabled = true;


                // Controlo las cantidades propias y consignadas si son 0 ambos deshabilito el btnSeleccionar
                if (cantidadConsignada == 0 && cantidadPropia == 0)
                    BtnSeleccionar.Enabled = false;
                else
                    BtnSeleccionar.Enabled = true;
            }

        }

        private bool ValidarCantidad()
        {
            int sumaStock = Convert.ToInt16(TxtPropio.Text) + Convert.ToInt16(TxtConsignado.Text);
            int cantidad;
            if (TxtCantidad.Text != "")
                cantidad = Convert.ToInt16(TxtCantidad.Text);
            else
                cantidad = 0;

            if (cantidad <= sumaStock)
            {
                return true;
            }
            else
            {
                _messageBoxDisplayService.ShowWarning(Resources.WarningMessageCantidadSeleccionadaSuperaStockDisponible);
                TxtCantidad.Text = sumaStock.ToString();
                return false;
            }

        }

        private void ActualizarSubtotal()
        {
            if (Descuento == null)
            {

                SubTotal = PrecioVenta * Cantidad;
            }
            else
            {
                if (_cambiaPrecio)
                {
                    SubTotal = (PrecioVenta) * Cantidad;
                }
                else
                {
                    SubTotal = (PrecioVenta * (100 - Descuento) / 100) * Cantidad;
                }
            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            ActualizarSubtotal();
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            SubTotal = PrecioVenta * Cantidad;
            if (!_cargandoCantidad)
                ValidarCantidad();
        }

        private void TxtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            CalcularDescuento();
            ActualizarSubtotal();
        }

        private void CalcularDescuento()
        {
            if (_precioVentaActual == null)
                return;
            if (PrecioVenta < _precioVentaActual)
            {
                var descuentoDec = 100 - (PrecioVenta * 100 / _precioVentaActual);
                Descuento = (int?)descuentoDec ?? 0;
            }
            else if (PrecioVenta > _precioVentaActual)
            {
                Descuento = null;
            }

        }

        private void GridTitulos_SelectionChanged(object sender, EventArgs e)
        {
            InformacionDeLibro();

        }

        private void BtnPasarLibro_Click(object sender, EventArgs e)
        {
            if (_libroPasado == false)
            {
                if (CantidadConsignada>0 || CantidadPropia>0)
                    _messageBoxDisplayService.ShowConfirmationDialog("Ya tiene un libro en stock, desea pasarlo?",
                                                                 "Pase de stock", () => { PaseLibro(); });
                else
                    PaseLibro();
            }
            else
            {
                if (CantidadConsignada > 0 || CantidadPropia > 0)
                   _messageBoxDisplayService.ShowConfirmationDialog("Ya paso un stock de este libro. Desea pasar otro?",
                                                                     "Pase de stock", ()=> { PaseLibro(); });
            }

        }

        private void PaseLibro()
        {
            _libroPasado = true;
            PasarLibro();
            InformacionDeLibro();
        }

        private void PasarLibro()
        {
            if (Convert.ToInt16(TxtMigracionPropio.Text) != 0)
            {
                MigracionStockPropio(true);
            }
            else if (Convert.ToInt16(TxtMigracionConsignado.Text) != 0)
            {
                MigracionStockPropio(false);
            }
            else
            {
                _messageBoxDisplayService.ShowWarning(Resources.WarningMessagePasarStockLibro);
            }
        }

        private void MigracionStockPropio(bool propio)
        {
            _tituloseleccionado = (TituloDto)GridTitulos.CurrentRow.DataBoundItem;
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
            var migracionTituloStock = _migracionRepo.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
            //LAPAZ
            Guid _idProveedor8Marzo = Guid.Parse("A7F325F0-EF29-4D81-B6A1-4A1A8688E075");

            //SANTY HP
            //Guid _idProveedor8Marzo = Guid.Parse("A827DD36-4B41-4F4F-BB81-B56DE923B4D2");

            //USUARIO PC
            //Guid _idProveedor8Marzo = Guid.Parse("03979D63-B3B4-4615-9979-CD5DFC4F9B72");


            var prov8Marzo = Uow.Proveedores.Obtener(p => p.Id == _idProveedor8Marzo || p.Denominacion == "8 DE MARZO");
            //var prov8Marzo = Uow.Proveedores.Obtener(p => p.Denominacion=="8 DE MARZO");


            //var compraList = _paseLibroNegocio.Listado("FechaAlta","Asc",prov8Marzo.Id);


            //si el titulo stock no existe lo doy de alta
            if (tituloStock == null)
            {
                tituloStock = new TituloStock();
                tituloStock.TituloId = _tituloseleccionado.Id;
                tituloStock.SucursalId = Context.SucursalActual.Id;
                tituloStock.StkCn = 0;
                tituloStock.StkPr = 0;
                tituloStock.FechaAlta = _clock.Now;
                tituloStock.SucursalAltaId = Context.SucursalActual.Id;
                tituloStock.OperadorAltaId = Context.OperadorActual.Id;
                Uow.TitulosStock.Agregar(tituloStock);
                Uow.Commit();

                tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
            }
            //Traigo la primer compra, que es donde se estan almacenando los detalles de compra del proveedor 8 de Marzo
            var compraList = Uow.Compras.Listado().Where(p => p.ProveedorId == prov8Marzo.Id).OrderBy(p => p.FechaAlta).First();

            var compras = new Compra();
            if (compraList == null)
            {
                compras = new Compra();
                compras.Id = Guid.NewGuid();
                compras.LCN = "0000000000000";
                compras.TipoComprobanteId = TipoComprobanteEnum.RemitoTransferencia;
                compras.ProveedorId = prov8Marzo.Id;
                compras.LetraComprobante = "X";
                compras.PuntoVenta = Context.SucursalActual.Id;
                compras.NumeroComprobante = "0000000000000";
                compras.FechaComprobante = _clock.Now;
                compras.Concepto = "REMITO POR TRANSFERENCIA";
                compras.ImporteNeto = 0;
                compras.ImporteIVA = 0;
                compras.EstadoCompraId = 1;
                compras.OperadorAltaId = Context.OperadorActual.Id;
                compras.SucursalAltaId = Context.SucursalActual.Id;
                compras.FechaAlta = _clock.Now;
                compras.FechaModificacion = _clock.Now;
                compras.OperadorModificacionId = Context.OperadorActual.Id;
                compras.SucursalModificacionId = Context.SucursalActual.Id;

                Uow.Compras.Agregar(compras);
            }
            else
            {
                compras = Uow.Compras.Obtener(c => c.Id == compraList.Id);
            }

            var compraDetalle = new ComprasDetalle();
            compraDetalle.Id = Guid.NewGuid();
            compraDetalle.CompraId = compras.Id;
            compraDetalle.TituloId = _tituloseleccionado.Id;
            compraDetalle.PrecioCompra = 0;
            compraDetalle.FechaAlta = _clock.Now;
            compraDetalle.SucursalAltaId = Context.SucursalActual.Id;
            compraDetalle.OperadorAltaId = Context.OperadorActual.Id;
            compraDetalle.FechaModificacion = _clock.Now;
            compraDetalle.SucursalModificacionId = Context.SucursalActual.Id;
            compraDetalle.OperadorModificacionId = Context.OperadorActual.Id;

            //Si propio es true descontamos e incrementamos los propios, si no consignados
            if (propio)
            {
                //Descuento 1 libro
                migracionTituloStock.StkPr -= 1;
                tituloStock.StkPr += 1;

                //Modifico las propiedades
                CantidadPropia = tituloStock.StkPr;
                MigracionCantidadPropia = migracionTituloStock.StkPr;

                //Agrego en compra detalle
                compraDetalle.CntPr = 1;

                //Comiteo los cambios a la base
                _migracionRepo.Modificar(migracionTituloStock);
                _migracionRepo.Commit();


            }
            else
            {
                //Descuento 1 libro
                migracionTituloStock.StkCn -= 1;
                tituloStock.StkCn += 1;


                //Modifico las propiedades
                CantidadConsignada = tituloStock.StkCn;
                MigracionCantidadConsignada = migracionTituloStock.StkCn;

                //Agrego en compra detalle
                compraDetalle.CntCn = 1;

                //Comiteo los cambios a la base
                _migracionRepo.Modificar(migracionTituloStock);
                _migracionRepo.Commit();

            }
            tituloStock.FechaModificacion = _clock.Now;
            tituloStock.OperadorModificacionId = Context.OperadorActual.Id;

            Uow.ComprasDetalles.Agregar(compraDetalle);
            Uow.TitulosStock.Modificar(tituloStock);
            Uow.Commit();
        }


        private void PasarLibroFuturoJournal()
        {
            Guid? proveedorId = _tituloseleccionado.ProveedorId;

            if (Convert.ToInt16(TxtMigracionConsignado.Text) != 0)
            {
                MigracionStockFuturoJournal(false, proveedorId);
            }
            else if (Convert.ToInt16(TxtMigracionPropio.Text) != 0)
            {
                MigracionStockFuturoJournal(true, proveedorId);
            }
            else
            {
                _messageBoxDisplayService.ShowWarning(Resources.WarningMessagePasarStockLibro);
            }
        }

        private void MigracionStockFuturoJournal(bool propio, Guid? proveedorId)
        {
            _tituloseleccionado = (TituloDto)GridTitulos.CurrentRow.DataBoundItem;
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
            var migracionTituloStock = _migracionRepo.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
            //LAPAZ
            Guid? _idProveedor = proveedorId;

            var provFuturoOJournal = Uow.Proveedores.Obtener(p => p.Id == _idProveedor);

            //si el titulo stock no existe lo doy de alta
            if (tituloStock == null)
            {
                tituloStock = new TituloStock();
                tituloStock.TituloId = _tituloseleccionado.Id;
                tituloStock.SucursalId = Context.SucursalActual.Id;
                tituloStock.StkCn = 0;
                tituloStock.StkPr = 0;
                tituloStock.FechaAlta = _clock.Now;
                tituloStock.SucursalAltaId = Context.SucursalActual.Id;
                tituloStock.OperadorAltaId = Context.OperadorActual.Id;
                Uow.TitulosStock.Agregar(tituloStock);
                Uow.Commit();

                tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == Context.SucursalActual.Id);
            }
            DateTime fechaCompra = DateTime.Parse("2015-01-01");
            var compraLists = Uow.Compras.Listado().Where(p => p.ProveedorId == provFuturoOJournal.Id && p.FechaAlta > fechaCompra).OrderBy(p => p.FechaAlta).ToList();

            Compra compraList;
            if (compraLists.Count > 0)
                compraList = compraLists.First();
            else
                compraList = null;

            var compras = new Compra();
            if (compraList == null)
            {
                compras = new Compra();
                compras.Id = Guid.NewGuid();
                compras.LCN = "0000000000000";
                compras.TipoComprobanteId = TipoComprobanteEnum.RemitosConsignacProveedor;
                compras.ProveedorId = provFuturoOJournal.Id;
                compras.LetraComprobante = "X";
                compras.PuntoVenta = Context.SucursalActual.Id;
                compras.NumeroComprobante = "0000000000000";
                compras.FechaComprobante = _clock.Now;
                compras.Concepto = "REMITO POR CONSIGNACION PROVEEDOR";
                compras.ImporteNeto = 0;
                compras.ImporteIVA = 0;
                compras.EstadoCompraId = 1;
                compras.OperadorAltaId = Context.OperadorActual.Id;
                compras.SucursalAltaId = Context.SucursalActual.Id;
                compras.FechaAlta = _clock.Now;

                Uow.Compras.Agregar(compras);
            }
            else
            {
                //compraList = Uow.Compras.Listado().Where(p => p.ProveedorId == provFuturoOJournal.Id).OrderBy(p => p.FechaAlta).First();
                compras = Uow.Compras.Obtener(c => c.Id == compraList.Id);
            }

            var compraDetalle = new ComprasDetalle();
            compraDetalle.Id = Guid.NewGuid();
            compraDetalle.CompraId = compras.Id;
            compraDetalle.TituloId = _tituloseleccionado.Id;
            compraDetalle.PrecioCompra = 0;
            compraDetalle.FechaAlta = _clock.Now;
            compraDetalle.SucursalAltaId = Context.SucursalActual.Id;
            compraDetalle.OperadorAltaId = Context.OperadorActual.Id;
            compraDetalle.FechaModificacion = _clock.Now;
            compraDetalle.SucursalModificacionId = Context.SucursalActual.Id;
            compraDetalle.OperadorModificacionId = Context.OperadorActual.Id;




            //Si propio es true descontamos e incrementamos los propios, si no consignados
            if (propio)
            {
                //Descuento 1 libro
                migracionTituloStock.StkPr -= 1;
                tituloStock.StkPr += 1;

                //Modifico las propiedades
                CantidadPropia = tituloStock.StkPr;
                MigracionCantidadPropia = migracionTituloStock.StkPr;

                //Agrego en compra detalle
                compraDetalle.CntPr = 1;

                //Comiteo los cambios a la base
                _migracionRepo.Modificar(migracionTituloStock);
                _migracionRepo.Commit();


            }
            else
            {
                //Descuento 1 libro
                migracionTituloStock.StkCn -= 1;
                tituloStock.StkCn += 1;


                //Modifico las propiedades
                CantidadConsignada = tituloStock.StkCn;
                MigracionCantidadConsignada = migracionTituloStock.StkCn;

                //Agrego en compra detalle
                compraDetalle.CntCn = 1;


                //Agrego la consignacion
                TitulosConsignacion consignacion = new TitulosConsignacion();
                consignacion.Id = Guid.NewGuid();
                consignacion.TituloId = _tituloseleccionado.Id;
                consignacion.ClienteId = Guid.Empty;
                consignacion.ProveedorId = provFuturoOJournal.Id;
                consignacion.TipoConsignacion = 1;
                consignacion.CntPr = 0;
                consignacion.CntCn = 1;
                consignacion.CntVn = 0;
                consignacion.FechaAlta = _clock.Now;
                consignacion.SucursalAltaId = Context.SucursalActual.Id;
                consignacion.OperadorAltaId = Context.OperadorActual.Id;
                Uow.TitulosConsignaciones.Agregar(consignacion);

                //Comiteo los cambios a la base
                _migracionRepo.Modificar(migracionTituloStock);
                _migracionRepo.Commit();

            }
            tituloStock.FechaModificacion = _clock.Now;
            tituloStock.OperadorModificacionId = Context.OperadorActual.Id;

            Uow.ComprasDetalles.Agregar(compraDetalle);
            Uow.TitulosStock.Modificar(tituloStock);
            Uow.Commit();
        }

        private void TxtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            _cambiaPrecio = true;
        }

        private void BtnPaseConsignacion_Click(object sender, EventArgs e)
        {
            _libroPasado = true;
            PasarLibroFuturoJournal();
            InformacionDeLibro();
        }

        private void DTxtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            CalcularDescuento();
            ActualizarSubtotal();
        }


        private void DTxtPrecioVenta_KeyDown(object sender, KeyEventArgs e)
        {
            _cambiaPrecio = true;
        }

        private void FrmSeleccionarLibro_KeyDown(object sender, KeyEventArgs e)
        {
            ClipboardHelper.SetPortapapeles(e, GridTitulos);
        }
    }
}
