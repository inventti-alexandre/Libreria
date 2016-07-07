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
using LaPaz.Win.Model;
using LaPaz.Win.Helpers;
using LaPaz.Win.Properties;
using LaPaz.Seguridad;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class FrmSeleccionarLibroPresupuesto : EditFormListadoBase
    {
        private readonly IClock _clock;
        private readonly ITituloNegocio _tituloNegocio;
        private readonly IRepository<TituloStockMigracion> _migracionRepo;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        TituloDto _tituloseleccionado = new TituloDto();
        private decimal? _precioVentaActual;
        private Guid _Tituloid = Guid.Empty;

        public FrmSeleccionarLibroPresupuesto(IClock clock, IFormFactory formFactory,
                                   IRepository<TituloStockMigracion> migracionRepo,
                                   ILaPazUow uow,
                                   ITituloNegocio tituloNegocio,
                                   IMessageBoxDisplayService messageBoxDisplayService,
                                   Guid id)
        {
            FormFactory = formFactory;
            Uow = uow;
            _clock = clock;
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
                return decimal.TryParse(TxtPrecioVenta.Text, out precioventa) ? precioventa : (decimal?)null;
            }
            set
            {
                _precioVentaActual = value;
                TxtPrecioVenta.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty;

            }
        }

        public decimal? PrecioBase
        {
            get
            {
                decimal preciobase;
                return decimal.TryParse(TxtPrecioVenta.Text, out preciobase) ? preciobase : (decimal?)null;
            }
            set { TxtPrecioVenta.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
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
            UcFiltrosLibros.Filtered += Filtered;
            if (_Tituloid != Guid.Empty)
            {
                CargarTitulo(_Tituloid);
            }
        }

        private void CargarTitulo(Guid _Tituloid)
        {
            UcFiltrosLibros.Spinner.Show();

            int pageTotal = 0;

            var codigoProveedor = UcFiltrosLibros.CodigoProveedor;
            var codigoLibroCompleto = Uow.Titulos.Obtener(t => t.Id == _Tituloid).Cod; ;//UcFiltrosLibros.CodigoLibroCompleto;
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
                                                 autorNombre, editorialId, conStock, sucursalId, conOchoDeMarzo, activos,
                                                 TitulosPager.CurrentPage,
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
                                           activos,
                                           TitulosPager.CurrentPage,
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

            var esValido = this.ValidarForm();

            if ((esValido))
            {
                OnTituloAgregado(titulo);
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
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
            this.ValidarControl(TxtPrecioVenta, "PrecioVenta");
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
                var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == 2);
                var migracionTituloStock = _migracionRepo.Obtener(t => t.TituloId == _tituloseleccionado.Id && t.SucursalId == 2);

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

                Descuento = null;
                PrecioVenta = _tituloseleccionado.PrecioVentaTitulo;
                SubTotal = PrecioVenta;
                Cantidad = 1;
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
                SubTotal = (PrecioVenta * (100 - Descuento) / 100) * Cantidad;

            }
        }

        private void TxtDescuento_TextChanged(object sender, EventArgs e)
        {
            ActualizarSubtotal();
        }

        private void TxtCantidad_TextChanged(object sender, EventArgs e)
        {
            SubTotal = PrecioVenta * Cantidad;
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
            //if (PrecioVenta < _precioVentaActual)
            //{
            //    var descuentoDec = 100 - (PrecioVenta * 100 / _precioVentaActual);
            //    Descuento = (int?)descuentoDec ?? 0;
            //}
            //else 
                if (PrecioVenta > _precioVentaActual)
            {
                Descuento = null;
            }

        }

        private void GridTitulos_SelectionChanged(object sender, EventArgs e)
        {
            InformacionDeLibro();

        }

        private void FrmSeleccionarLibroPresupuesto_KeyDown(object sender, KeyEventArgs e)
        {
            ClipboardHelper.SetPortapapeles(e, GridTitulos);
        }
    }
}
