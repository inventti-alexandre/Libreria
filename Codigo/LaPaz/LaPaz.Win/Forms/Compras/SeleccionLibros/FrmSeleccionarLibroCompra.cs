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
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Helpers;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Libros;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Compras
{
    public partial class FrmSeleccionarLibroCompra : EditFormBase
    {
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        private readonly ITituloNegocio _tituloNegocio;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        TituloDto tituloseleccionado = new TituloDto();
        private Proveedor _proveedor = new Proveedor();
        private Guid? _proveedorId;
        private readonly IClock _clock;
        private decimal? _precioVenta;
        private decimal? _precioBase;
        private Guid _idLibro;
        private string _codLibro;
        private Guid _Tituloid = Guid.Empty;
        private Guid _id;
        private ActionFormMode _formMode;

        public FrmSeleccionarLibroCompra(IClock clock, IFormFactory formFactory, ILaPazUow uow, ITituloNegocio tituloNegocio
                                        , Guid id, IMessageBoxDisplayService messageBoxDisplayService, ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;

            _messageBoxDisplayService = messageBoxDisplayService;
            _id = id;
            _formMode = mode;
            _clock = clock;
            _tituloNegocio = tituloNegocio;

            InitializeComponent();

            InicializarPaginador();
            
            ConfigurarColumnas();

            this.UcFiltrosLibros.CkbEliminados.Visible = false;
        }

        private void ConfigurarColumnas()
        {
            this.GridTitulos.Columns["FModificacion"].FormatString = "{0: MM/d/yyyy}";
            SortColumn = "NombreTitulo";
            SortDirection = "ASC";
        }

        public event EventHandler<CompraTitulo> TituloAgregado;

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

        public string CodigoBarra
        {
            get { return ((TituloDto)GridTitulos.CurrentRow.DataBoundItem).CodigoBarra; }
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
                TxtPrecioVenta.Text = value.HasValue ? value.Value.ToString("N2") : string.Empty;
            }
        }

       public decimal? PrecioBase
        {
            get
            {
                decimal preciocompra;
                return decimal.TryParse(TxtPrecioCompra.Text, out preciocompra) ? preciocompra : (decimal?)null;
            }
            set
            {
                TxtPrecioCompra.Text = value.HasValue ? value.Value.ToString("N2") : string.Empty;
            }
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

        public decimal? Descuento
        {
            get
            {
                decimal descuento;
                return decimal.TryParse(TxtDescuento.Text, out descuento) ? descuento : (decimal?)null;
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
                TxtSubtotal.Text = value.HasValue ? value.Value.ToString("N2") : string.Empty;
            }
        }

        #endregion

        private void InicializarPaginador()
        {
            TitulosPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmSeleccionarLibro_Load(object sender, EventArgs e)
        {
            GridTitulos.AutoGenerateColumns = false;

            //Pasamos el id del proveedor para que te muestre en el dropdownproveedor
            //UcFiltrosLibros.ProveedorId = _proveedor.Id;
            this.GridTitulos.Columns["PVenta"].FormatString = "{0:N2}";
            this.GridTitulos.Columns["FModificacion"].FormatString = "{0: d/M/yyyy}";
            UcFiltrosLibros.Filtered += Filtered;

            UcFiltrosLibros.SetearNullCbxStocks();

            if (_formMode == ActionFormMode.Create)
            {
                _proveedorId = _id;
                _proveedor = Uow.Proveedores.Obtener(p => p.Id == _id);
            }
            else if ((_formMode == ActionFormMode.Edit))
            {
                _Tituloid = _id;
                CargarTitulo(_Tituloid);
            }

            ChkCalcular.Checked = true;
        }

        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private async Task<int> RefrescarListado()
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
            var codigoBarra = UcFiltrosLibros.CodigoBarra;
            var sucursalId = this.Context.SucursalActual.Id;
            var conOchoDeMarzo = UcFiltrosLibros.OchoDeMarzo;
            var activos = UcFiltrosLibros.Activos;

            var titulos = await Task.Run(() =>
                                         _tituloNegocio.Listado("NombreTitulo", "ASC", codigoProveedor,
                                                                codigoLibroCompleto, isbn, codigoBarra,
                                                                nombreTitulo, proveedorId, temaId, autorNombre,
                                                                editorialId, conStock, sucursalId, conOchoDeMarzo, activos,
                                                                TitulosPager.CurrentPage, TitulosPager.PageSize,
                                                                out pageTotal));


            GridTitulos.DataSource = titulos;

            TitulosPager.UpdateState(pageTotal);

            UcFiltrosLibros.Spinner.Hide();

            BtnSeleccionar.Enabled = pageTotal != 0;

            return pageTotal;
        }
        private async Task<int> RefrescarListado(string CodLibro, Guid? Proveedor)
        {
            UcFiltrosLibros.Spinner.Show();

            int pageTotal = 0;


            var codigoLibroCompleto = CodLibro;
            var proveedorId = Proveedor;
            var sucursalId = this.Context.SucursalActual.Id;
            var conOchoDeMarzo = UcFiltrosLibros.OchoDeMarzo;
            var activos = UcFiltrosLibros.Activos;

            var titulos = await Task.Run(() =>
                                         _tituloNegocio.Listado("NombreTitulo", "ASC", null,
                                                                codigoLibroCompleto, null, null,
                                                                null, proveedorId, null, null,
                                                                null, null, sucursalId, conOchoDeMarzo,
                                                                activos,
                                                                TitulosPager.CurrentPage, TitulosPager.PageSize,
                                                                out pageTotal));


            GridTitulos.DataSource = titulos;

            TitulosPager.UpdateState(pageTotal);

            UcFiltrosLibros.Spinner.Hide();

            return pageTotal;
        }

        private void BtnSeleccionar_Click(object sender, EventArgs e)
        {
            //controlo que tenga algun ìtem seleccionado de la grilla
            var selectedRow = this.GridTitulos.SelectedRows.FirstOrDefault();
            if (selectedRow == null)
                return;

            //validacion cachorra. despues mejorar con los dto y toda la gilada
            decimal pVenta;
            if (TxtPrecioVenta.Text != "")
                pVenta = Convert.ToDecimal(TxtPrecioVenta.Text);
            else
            {
                pVenta = 0;
            }

            decimal pCompra;
            if (TxtPrecioCompra.Text != "")
                pCompra = Convert.ToDecimal(TxtPrecioCompra.Text);
            else
            {
                pCompra = 0;
            }

            if (pVenta < pCompra)
            {
                _messageBoxDisplayService.ShowError("El precio de venta no puede ser menor al precio de compra.");
                return;
            }

            //controlo que el titulo ya lo tenga el proveedor/si no lo tiene, agrego el titulo al proveedor
            var proveedorActual = Uow.Proveedores.Obtener(p => p.Id == _proveedorId);
            var codigoProveedor = proveedorActual.Cuenta;

            var tituloActual = Uow.Titulos.Obtener(t => t.Id == Id);
            var nuevoCod = codigoProveedor.ToString().PadLeft(4, '0').Substring(0, 4) + tituloActual.Cod.Substring(4);

            var tituloCheck = Uow.Titulos.Obtener(t => t.Cod == nuevoCod);

            if (tituloCheck == null)
            {
                var tituloProv = Uow.Titulos.Obtener(t => t.Id == Id);
                var libroNew = new Titulo();
                libroNew.Id = Guid.NewGuid();
                _idLibro = libroNew.Id;
                _codLibro = nuevoCod;
                libroNew.Cod = nuevoCod;
                libroNew.ISBN = tituloProv.ISBN;
                libroNew.NombreTitulo = tituloProv.NombreTitulo;
                libroNew.ProveedorId = _proveedorId;
                libroNew.AutorId = tituloProv.AutorId;
                libroNew.EditorialId = tituloProv.EditorialId;
                libroNew.TemaId = tituloProv.TemaId;
                libroNew.SubtemaId = tituloProv.SubtemaId;
                libroNew.PrecioVentaTitulo = PrecioVenta;
                libroNew.PrecioCompraTitulo = PrecioBase;
                libroNew.CodigoBarra = tituloProv.CodigoBarra;
                libroNew.ISBNg = tituloProv.ISBNg;
                libroNew.FechaAltaTitulo = tituloProv.FechaAltaTitulo;
                libroNew.TipoArticuloId = tituloProv.TipoArticuloId;
                libroNew.ModoStockId = tituloProv.ModoStockId;
                libroNew.TipoTituloId = tituloProv.TipoTituloId;
                libroNew.UnidadesId = tituloProv.UnidadesId;
                libroNew.TomosTitulosId = tituloProv.TomosTitulosId;
                libroNew.EstadoTituloId = tituloProv.EstadoTituloId;
                libroNew.AdicionalId = tituloProv.AdicionalId;
                libroNew.PesoTitulo = tituloProv.PesoTitulo;
                libroNew.PaisId = tituloProv.PaisId;
                libroNew.FechaEdicion = tituloProv.FechaEdicion;
                libroNew.IdiomaId = tituloProv.IdiomaId;
                libroNew.PartesId = tituloProv.PartesId;
                libroNew.Paginas = tituloProv.Paginas;
                libroNew.Encuad = tituloProv.Encuad;
                libroNew.Comentario = tituloProv.Comentario;
                libroNew.StkMin = tituloProv.StkMin;
                libroNew.FUltVta = tituloProv.FUltVta;
                libroNew.Fingreso = _clock.Now;
                libroNew.nControl = tituloProv.nControl;
                libroNew.UbicacionId = null;
                libroNew.PresentacionId = tituloProv.PresentacionId;
                libroNew.FechaAlta = _clock.Now;
                libroNew.SucursalAltaId = Context.SucursalActual.Id;
                libroNew.OperadorAltaId = Context.OperadorActual.Id;
                libroNew.FechaModificacion = _clock.Now;
                libroNew.SucursalModificacionId = Context.SucursalActual.Id;
                libroNew.OperadorModificacionId = Context.OperadorActual.Id;
                libroNew.Activo = true;
                Uow.Titulos.Agregar(libroNew);

                var tituloStockNew = new TituloStock();
                tituloStockNew.TituloId = libroNew.Id;
                tituloStockNew.SucursalId = Context.SucursalActual.Id;
                tituloStockNew.StkCn = 0;
                tituloStockNew.StkPr = 0;
                tituloStockNew.FechaAlta = _clock.Now;
                tituloStockNew.SucursalAltaId = Context.SucursalActual.Id;
                tituloStockNew.OperadorAltaId = Context.OperadorActual.Id;
                tituloStockNew.FechaModificacion = _clock.Now;
                tituloStockNew.SucursalModificacionId = Context.SucursalActual.Id;
                tituloStockNew.OperadorModificacionId = Context.OperadorActual.Id;
                Uow.TitulosStock.Agregar(tituloStockNew);
                Uow.Commit();
            }
            else
            {
                _idLibro = tituloCheck.Id;
                _codLibro = tituloCheck.Cod;
            }

            //mandar libro
            CompraTitulo titulo = ObtenerTitulo();

            //Validar cambios de precios
            if (TitulosValidator.SolicitarAutorizacionPorCambioDePrecios(titulo.MapToTitulo()))
            {
                var operador = this.ObtenerOperadorAdministrador();

                if (operador == null)
                    return;
            }

            var esValido = this.ValidarForm();

            if ((esValido))
            {
                OnTituloAgregado(titulo);

                //modifico el precio de toodos los proveedores
                ActualizarPrecioTitulo(titulo);
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void ActualizarPrecioTitulo(CompraTitulo titulo)
        {
            //MOdificar el de todos los proveedores?
            //List<Titulo> titulosModificar = Uow.Titulos.Listado().Where(t => t.CodigoBarra == titulo.CodigoBarra).ToList();
            var titulosModificar = new List<Titulo>();
            int _codigo ;
            var co = int.TryParse(titulo.CodigoBarra, out _codigo);
            

            if (String.IsNullOrEmpty(titulo.CodigoBarra) || _codigo == 0 )
            {
                titulosModificar = Uow.Titulos.Listado().Where(t => t.Id == titulo.TituloId).ToList();  
            }
            else
            {
                titulosModificar = Uow.Titulos.Listado().Where(t => t.CodigoBarra == titulo.CodigoBarra).ToList();
            }

            if (titulosModificar.Count > 0)
                {
                    foreach (var tituloModificar in titulosModificar)
                    {
                        if (tituloModificar.ProveedorId == _proveedorId)
                        {
                            //Precio de Venta
                            if (PrecioVenta >= tituloModificar.PrecioVentaTitulo)
                                ActualizarPrecioVenta(tituloModificar);
                        
                            else if (PrecioVenta<tituloModificar.PrecioVentaTitulo)
                            {
                                //_messageBoxDisplayService.ShowInfo("")
                                _messageBoxDisplayService.ShowConfirmationDialog(
                                    "El precio del título es menor. Desea almacenarlo?", "Actualizar Precio",
                                    () => { ActualizarPrecioVenta(tituloModificar); });
                            }

                            //Precio de Compra
                            if (PrecioBase >= tituloModificar.PrecioCompraTitulo)
                                ActualizarPrecioCompra(tituloModificar);

                            //else if (PrecioBase < tituloModificar.PrecioCompraTitulo)
                            //{
                            //    _messageBoxDisplayService.ShowConfirmationDialog(
                            //        "El precio del título es menor. Desea almacenarlo?", "Actualizar Precio",
                            //        () => { ActualizarPrecioCompra(tituloModificar); });
                            //}

                        }
                        else
                        {
                            if ((PrecioVenta > tituloModificar.PrecioVentaTitulo) || (PrecioBase > tituloModificar.PrecioCompraTitulo))
                                ActualizarPrecioVenta(tituloModificar);
                        }
                    }
               
                }
            
        }

        private void ActualizarPrecioVenta(Titulo tituloModificar)
        {
            tituloModificar.PrecioVentaTitulo = PrecioVenta;
            tituloModificar.OperadorModificacionId = Context.OperadorActual.Id;
            tituloModificar.FechaModificacion = _clock.Now;
            tituloModificar.SucursalModificacionId = Context.SucursalActual.Id;
            tituloModificar.UbicacionId = null;
            Uow.Titulos.Modificar(tituloModificar);
            Uow.Commit();
        }

        private void ActualizarPrecioCompra(Titulo tituloModificar)
        {
            tituloModificar.PrecioCompraTitulo = PrecioBase;
            tituloModificar.OperadorModificacionId = Context.OperadorActual.Id;
            tituloModificar.FechaModificacion = _clock.Now;
            tituloModificar.SucursalModificacionId = Context.SucursalActual.Id;
            tituloModificar.UbicacionId = null;
            Uow.Titulos.Modificar(tituloModificar);
            Uow.Commit();
        }

        private void OnTituloAgregado(CompraTitulo titulo)
        {
            if (TituloAgregado != null)
            {
                TituloAgregado(this, titulo);
            }
        }

        private CompraTitulo ObtenerTitulo()
        {
            //CONTROLAR
            CompraTitulo compraTitulo = new CompraTitulo();

            compraTitulo.TituloId = _idLibro;
            compraTitulo.Cod = _codLibro;
            compraTitulo.TituloNombre = TituloNombre;
            compraTitulo.CodigoBarra = CodigoBarra;
            compraTitulo.CantidadCompra = Cantidad;
            compraTitulo.PrecioBase = PrecioBase;
            compraTitulo.PrecioVenta = PrecioVenta;
            compraTitulo.SubTotal = SubTotal;

            return compraTitulo;
        }

        private void CargarTitulo(Guid _Tituloid)
        {
            UcFiltrosLibros.Spinner.Show();
            var _tituloEdit = Uow.Titulos.Obtener(t => t.Id == _Tituloid);


            int pageTotal = 0;

           
            
            var codigoProveedor = UcFiltrosLibros.CodigoProveedor;
            var codigoLibroCompleto = _tituloEdit.Cod; //UcFiltrosLibros.CodigoLibroCompleto;
            var isbn = UcFiltrosLibros.ISBN;
            var nombreTitulo = UcFiltrosLibros.NombreTitulo;
            var proveedorId = UcFiltrosLibros.ProveedorId;
            var temaId = UcFiltrosLibros.TemaId;
            var autorNombre = UcFiltrosLibros.AutorNombre;
            var editorialId = UcFiltrosLibros.EditorialId;
            var conStock = UcFiltrosLibros.ConStock;
            var conStock8 = UcFiltrosLibros.OchoDeMarzo;
            var sucursalId = this.Context.SucursalActual.Id;
            string codigoBarra = UcFiltrosLibros.CodigoBarra;
            var activos = UcFiltrosLibros.Activos;

            var titulos = _tituloNegocio.Listado(SortColumn, SortDirection, codigoProveedor, codigoLibroCompleto, isbn,
                                                 codigoBarra, nombreTitulo, proveedorId, temaId,
                                                 autorNombre, editorialId, conStock, sucursalId, conStock8, activos, TitulosPager.CurrentPage,
                                                 TitulosPager.PageSize,
                                                 out pageTotal);

            _proveedorId = _tituloEdit.ProveedorId;
            _proveedor = Uow.Proveedores.Obtener(p => p.Id == _proveedorId);

            GridTitulos.DataSource = titulos;
            UcFiltrosLibros.Spinner.Visible = false;

            TitulosPager.UpdateState(pageTotal);
        }
        private void GridTitulos_DoubleClick(object sender, EventArgs e)
        {
            InformacionDeLibro();
        }

        private void InformacionDeLibro()
        {
            if (GridTitulos.RowCount > 0)
            {

                tituloseleccionado = (TituloDto)GridTitulos.CurrentRow.DataBoundItem;
                var _tituloCompra = Uow.Titulos.Obtener(t => t.Id == tituloseleccionado.Id);

                
                if ((_proveedor.Id != _tituloCompra.ProveedorId))
                {
                    Titulo _tituloCompraProveedor; 
                    if (tituloseleccionado.CodigoBarra!=null)
                        _tituloCompraProveedor = Uow.Titulos.Obtener(t => t.CodigoBarra == tituloseleccionado.CodigoBarra && t.ProveedorId == _proveedor.Id);
                    else
                        _tituloCompraProveedor = Uow.Titulos.Obtener(t => t.NombreTitulo == tituloseleccionado.NombreTitulo && t.ProveedorId == _proveedor.Id);

                    if (_tituloCompraProveedor != null)
                    {
                        //_messageBoxDisplayService.Show(
                        //    "Seleccionaste el titulo de otro proveedor, se desplegaran los datos del titulo del proveedor", Resources.LabelCompras);
                        //_tituloCompra = _tituloCompraProveedor;
                        //RefrescarListado(_tituloCompra.Cod, _proveedorId);
                        if (MessageBox.Show("Seleccionaste el titulo de otro proveedor, ¿Desea que se desplieguen los datos del titulo del proveedor?", "Compra", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            _tituloCompra = _tituloCompraProveedor;
                            RefrescarListado(_tituloCompra.Cod, _proveedorId);
                        }
                    }
                }



                //controlo que no venga null el stock del sistema
                if (_tituloCompra != null)
                {
                    Descuento = _proveedor.PorcentajeDescuento;
                    PrecioBase = _tituloCompra.PrecioCompraTitulo;
                    _precioBase = _tituloCompra.PrecioCompraTitulo;
                    _precioVenta = _tituloCompra.PrecioVentaTitulo;
                    PrecioVenta = _tituloCompra.PrecioVentaTitulo;
                    Cantidad = 1;
                    SubTotal = _tituloCompra.PrecioCompraTitulo;
                    CalcularCostos();
                }
            }


        }

        
        private void GridTitulos_SelectionChanged(object sender, EventArgs e)
        {
            InformacionDeLibro();

        }

        private void CalcularCostos(bool modifPrecioCompra)
        {
            if (ChkCalcular.Checked == true && modifPrecioCompra == true)
            {
                PrecioVenta = PrecioBase * ((100 + Descuento) / 100);

            }
            else if (ChkCalcular.Checked == true)
            {
                //Santy
                PrecioBase = PrecioVenta * ((100 - Descuento) / 100);

                //Sil
                //PrecioBase = (100 * PrecioVenta) / (100 + Descuento);
                TxtPrecioCompra.Text = PrecioBase.ToString();

            }

            SubTotal = PrecioBase * Cantidad;

        }

        private void CalcularCostos()
        {
            if (ChkCalcular.Checked == true)
            {
                //santy
                PrecioBase = PrecioVenta * ((100 - Descuento) / 100);
                
                //sil
                //PrecioBase = (100*PrecioVenta)/(100 + Descuento);
            }
            SubTotal = PrecioBase * Cantidad;

        }

        private void ChkCalcular_ToggleStateChanged(object sender, Telerik.WinControls.UI.StateChangedEventArgs args)
        {
            if (ChkCalcular.Checked == false)
            {
                PrecioVenta = _precioVenta;
                PrecioBase = _precioBase;

            }
            CalcularCostos();
        }

       

        private void BtnNuevoLibro_Click(object sender, EventArgs e)
        {
            CrearLibro();
        }

        private void CrearLibro()
        {
            Guid provid = _proveedorId ?? default(Guid);
            //using (var formCrear = FormFactory.Create<FrmCrearEditarLibro>(default(Guid), ActionFormMode.Create))
            using (var formCrear = FormFactory.Create<FrmCrearEditarLibro>(provid, ActionFormMode.Create))
            {
                formCrear.TituloAgregado += (sender, titulo) =>
                {
                    CargarTitulo(titulo.Id);
                    formCrear.Close();
                };

                formCrear.ShowDialog();
            }
        }

        private void FrmSeleccionarLibroCompra_KeyDown(object sender, KeyEventArgs e)
        {
            ClipboardHelper.SetPortapapeles(e, GridTitulos);
        }

        private void TxtPrecioVenta_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {

                CalcularCostos(false);
                //PrecioVenta = PrecioBase;
                //SubTotal = PrecioBase * Cantidad;
            }
        }

        private void TxtPrecioCompra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Tab)
            {

                CalcularCostos(true);
                //PrecioVenta = PrecioBase;
                //SubTotal = PrecioBase * Cantidad;
            }
        }

        private void TxtDescuento_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtDescuento.Text == "")
                Descuento = 0;
            PrecioVenta = (PrecioBase * (100 + Descuento) / 100);
            SubTotal = PrecioBase * Cantidad;
        }

        private void TxtCantidad_TextChanged_1(object sender, EventArgs e)
        {
            if (TxtCantidad.Text == "")
            {
                SubTotal = 0;
                return;
            }
            else
            {
                try
                {
                    Cantidad =Convert.ToInt32(TxtCantidad.Text);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            SubTotal = PrecioBase * Cantidad;
        }

       

      

     

       
    

      

      


    }
}
