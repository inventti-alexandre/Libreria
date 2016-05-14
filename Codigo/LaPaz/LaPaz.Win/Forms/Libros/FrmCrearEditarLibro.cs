using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Forms.Autores;
using LaPaz.Win.Forms.Editorial;
using LaPaz.Win.Forms.Proveedores;
using LaPaz.Win.Forms.SubTemas;
using LaPaz.Win.Forms.Temas;
using LaPaz.Win.Helpers;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Seguridad;

namespace LaPaz.Win.Forms.Libros
{
    public partial class FrmCrearEditarLibro : EditFormBase
    {
        private readonly Guid _tituloId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Titulo _titulo;
        private decimal? _precioVentaOriginal;
        private Guid? _operadorUltimoPrecioIdOriginal;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmCrearEditarLibro(IFormFactory formFactory,
                                   ILaPazUow uow,
                                   IUowFactory uowFactory,
                                   IClock clock,
                                   Guid id,
                                   IMessageBoxDisplayService messageBoxDisplayService,
                                   ActionFormMode mode)
        {
            Uow = uow;
            FormFactory = formFactory;
            UowFactory = uowFactory;

            _tituloId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            InicializarForm(mode);

            DefinirCombos();
            CargarCombos();
        }

        #region Eventos
        public event EventHandler<Titulo> TituloAgregado;
        #endregion

        #region Propiedades

        public string Titulo
        {
            get { return TxtTitulo.Text; }
            set { TxtTitulo.Text = value; }
        }

        public String Codigo
        {
            get { return TxtCodigo.Text; }
            set { TxtCodigo.Text = value; }
        }

        public String CodigoBarra
        {
            get { return TxtCodigoBarra.Text; }
            set { TxtCodigoBarra.Text = value; }
        }

        public string Isbn
        {
            get { return TxtIsbn.Text; }
            set { TxtIsbn.Text = value; }
        }

        public Guid? Proveedor
        {
            get { return (Guid?)CbxProveedor.ProveedorId; }
            set { CbxProveedor.ProveedorId = value ?? Guid.Empty; }
        }

        public int? ProveedorCuenta
        {
            get
            {
                int cuenta;
                return int.TryParse(CbxProveedorCodigo.SelectedText, out cuenta) ? cuenta : 0;
               

            }
            set { CbxProveedorCodigo.SelectedText = value.ToString(); }
        }

        public int? Autor
        {
            get { return CbxAutor.AutorId; }
            set { CbxAutor.AutorId = value; }
        }

        public int? Editorial
        {
            get { return (int?)CbxEditorial.EditorialId; }
            set { CbxEditorial.EditorialId = value ?? 0; }
        }

        public int? Tema
        {
            get { return (int)CbxTema.SelectedValue; }
            set { CbxTema.SelectedValue = value ?? 0; }
        }

        public int? SubTema
        {
            get { return (int)CbxSubTema.SelectedValue; }
            set { CbxSubTema.SelectedValue = value ?? 0; }
        }

        public decimal? PrecioVenta
        {

            get
            {
                decimal precioventa;
                return decimal.TryParse(TxtPrecioVenta.Text, out precioventa) ? precioventa : (decimal?)null;
            }
            set { TxtPrecioVenta.Text = value.HasValue ? value.Value.ToString() : string.Empty; }

        }

        public decimal? PrecioCompra
        {
            get
            {
                decimal preciocompra;
                return decimal.TryParse(TxtPrecioCompra.Text, out preciocompra) ? preciocompra : (decimal?)null;
            }
            set { TxtPrecioCompra.Text = value.HasValue ? value.Value.ToString() : string.Empty; }
        }

        public string Comentario
        {
            get { return TxtComentario.Text; }
            set { TxtComentario.Text = value; }
        }

        #endregion

        #region Metodos

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Create:
                    this.Text = Resources.LabelCrearLibro;
                    CbxProveedor.Enabled = true;
                    break;
                case ActionFormMode.Edit:
                    this.Text = Resources.LabelEditarLibro;
                    break;
            }
        }

        private void FrmCrearEditarLibro_Load(object sender, EventArgs e)
        {
            CbxProveedor.CargarProveedores(false);
            CbxEditorial.CargarEditorial();
            CbxEditorial.CargarEditorial();
            CargarTitulo(_tituloId);
        }

        private void DefinirCombos()
        {
            // CbxProveedor.DisplayMember = "Denominacion";
            CbxProveedor.ProveedorId = Guid.Empty;

            CbxProveedorCodigo.DisplayMember = "Cuenta";
            CbxProveedorCodigo.ValueMember = "Id";
            
            CbxTema.DisplayMember = "Nombre";
            CbxTema.ValueMember = "Id";
        }

        private void CargarTitulo(Guid tituloId)
        {
            if (tituloId == default(Guid))
            {
                _titulo = new Titulo();
            }
            else
            {
                _titulo = Uow.Titulos.Obtener(t => t.Id == tituloId);
                _precioVentaOriginal = _titulo.PrecioVentaTitulo;
                _operadorUltimoPrecioIdOriginal = _titulo.OperadorUltimoPrecioId;
            }
            this.Titulo = _titulo.NombreTitulo;
            this.Codigo = _titulo.Cod;
            this.CodigoBarra = _titulo.CodigoBarra;
            this.Isbn = _titulo.ISBN;
            this.Proveedor = _titulo.ProveedorId;
            this.Autor = _titulo.AutorId;
            this.Editorial = _titulo.EditorialId;
            this.Tema = _titulo.TemaId;
            this.SubTema = _titulo.SubtemaId;
            this.PrecioVenta = _titulo.PrecioVentaTitulo;
            this.PrecioCompra = _titulo.PrecioCompraTitulo;
            this.Comentario = _titulo.Comentario;

            //Si el titulo tiene stock, no se debe permitir cambiar el proveedor
            //var stock = Uow.TitulosStock.Listado().Where(ts => ts.TituloId == tituloId).FirstOrDefault();
            //if (stock.StkCn > 0 || stock.StkPr > 0)
            //{
            //    CbxProveedor.Enabled = false;
            //    tituloId = default(Guid);
            //}
        }

        protected override object ObtenerEntidad()
        {
            return ObtenerLibroDesdeForm();
        }

        private void CargarCombos()
        {
            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == false && p.Activo).OrderBy(p => p.Denominacion).ToList();
            proveedores.Insert(0, new Proveedor() { Denominacion = "SELECCIONE PROVEEDOR", Cuenta = 0 });
            CbxProveedorCodigo.DataSource = proveedores;

           CbxEditorial.CargarEditorial();

            var tema = Uow.Temas.Listado().OrderBy(t => t.Nombre).ToList();
            tema.Insert(0, new Tema() { Nombre = "SELECCIONE TEMA" });
            CbxTema.DataSource = tema;
        }

        private void CargarSubTema(int tema)
        {
            var subtema = Uow.SubTemas.Listado().Where(s => s.TemaId == tema).OrderBy(s => s.Nombre).ToList();
            subtema.Insert(0, new SubTema() { Nombre = "SELECCIONE SUBTEMA" });
            CbxSubTema.DataSource = subtema;
            CbxSubTema.DisplayMember = "Nombre";
            CbxSubTema.ValueMember = "Id";
        }
        private void CbxSubTema_Enter_1(object sender, EventArgs e)
        {
            CargarSubTema((int)CbxTema.SelectedValue);
        }


        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            GuardarLibro();
        }

        private void GuardarLibro()
        {

            var esValido = this.ValidarForm();

            //if (TxtPrecioVenta.Text == "")
            //    TxtPrecioVenta.Text = "0";

            if (!esValido || !ValidarPrecio())
            {
                this.DialogResult = DialogResult.None;
            }
            else
            {
                var titulo = ObtenerLibroDesdeForm();

                if (_formMode == ActionFormMode.Create)
                {
                    Uow.Titulos.Agregar(titulo);
                }
                else
                {
                    Uow.Titulos.Modificar(titulo);
                }
                Uow.Commit();

                ActualizarPrecioTitulo(titulo);

                if (_formMode == ActionFormMode.Create)
                {
                    OnTituloAgregado(titulo);
                }
            }
        }

        private bool ValidarPrecio()
        {
            if (this._formMode == ActionFormMode.Create)
                return true;

             var solicitarAutorizacion = TitulosValidator.SolicitarAutorizacionPorCambioDePrecios(_titulo);

             if (solicitarAutorizacion)
             {
                 var operadorAdmin = this.ObtenerOperadorAdministrador();

                 if (operadorAdmin == null)
                 {
                     return false;
                 }
             }

             return true;
        }

        protected override void ValidarControles()
        {
            this.ValidarControl(TxtTitulo, "NombreTitulo");
            this.ValidarControl(TxtCodigo, "Cod");
            this.ValidarControl(CbxProveedor, "ProveedorId");
            this.ValidarControl(TxtPrecioVenta, "PrecioVentaTitulo");
        }

        private Titulo ObtenerLibroDesdeForm()
        {
            _titulo.Id = _tituloId == default(Guid) ? Guid.NewGuid() : _tituloId;
            if (Codigo.Length > 17)
                Codigo = Codigo.Substring(Codigo.Length - 17);

            _titulo.Cod = Codigo;
            _titulo.ISBN = this.TxtIsbn.Text;
            _titulo.NombreTitulo = this.TxtTitulo.Text;

            _titulo.ProveedorId = (Guid?)this.CbxProveedor.ProveedorId;
            _titulo.EditorialId = (int?)this.CbxEditorial.EditorialId;
            _titulo.AutorId = (int?)this.CbxAutor.AutorId;
            _titulo.TemaId = (int?)this.CbxTema.SelectedValue;
            _titulo.SubtemaId = (int?)this.CbxSubTema.SelectedValue;

            _titulo.PrecioVentaTitulo = PrecioVenta;
            _titulo.PrecioCompraTitulo = PrecioCompra;
            _titulo.CodigoBarra = this.TxtCodigoBarra.Text;

            _titulo.TipoArticuloId = 1;
            _titulo.ModoStockId = 1;
            _titulo.TipoTituloId = 1;
            _titulo.UnidadesId = 0;
            _titulo.TomosTitulosId = 0;
            _titulo.EstadoTituloId = 1;
            _titulo.PaisId = 1;
            _titulo.IdiomaId = 1;
            _titulo.Comentario = TxtComentario.Text;

            if (this._formMode == ActionFormMode.Create)
            {
                _titulo.OperadorUltimoPrecioId = Context.OperadorActual.Id;
                _titulo.FechaAlta = _clock.Now;
                _titulo.FechaAltaTitulo = _clock.Now;
                _titulo.OperadorAltaId = Context.OperadorActual.Id;
                _titulo.SucursalAltaId = Context.SucursalActual.Id;
                _titulo.OperadorUltimoPrecioId = _titulo.PrecioVentaTitulo != _precioVentaOriginal
                    ? Context.OperadorActual.Id
                    : _operadorUltimoPrecioIdOriginal;

                _titulo.FechaModificacion = _clock.Now;
                _titulo.Activo = true;
            }
            else
            {
                _titulo.OperadorUltimoPrecioId = _titulo.PrecioVentaTitulo != _precioVentaOriginal 
                    ? Context.OperadorActual.Id 
                    : _operadorUltimoPrecioIdOriginal;

                _titulo.FechaModificacion = _clock.Now;
                _titulo.FechaEdicion = _clock.Now;
                _titulo.OperadorModificacionId = Context.OperadorActual.Id;
                _titulo.SucursalModificacionId = Context.SucursalActual.Id;
            }

            //hardcodeado por ahora
            _titulo.UbicacionId = null;

            return _titulo;
        }

        private void BtnAddProveedor_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarProveedor>(Guid.Empty, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefrescarCbxProveedor(formCrear.Proveedor.Id);
                    formCrear.Close();
                }
            }
        }

        private void RefrescarCbxProveedor(Guid proveedorId)
        {
            CbxProveedor.CargarProveedores(true);
            CbxProveedor.ProveedorId = proveedorId;
        }

        private void RefrescarCbxAutor(int autorId)
        {
            CbxAutor.AutorId = autorId;
        }

        private void RefrescarEditorial(object sender, Entidades.Editorial editorial)
        {
            CbxEditorial.CargarEditorial();
            Editorial = editorial.Id;
        }

        private void BtnAddEditoria_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarEditorial>(0, ActionFormMode.Create))
            {
                formCrear.EditorialAgregado += RefrescarEditorial;
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                }
            }
        }

        private void BtnAddAutor_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarAutor>(0, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    RefrescarCbxAutor(formCrear.Autor.Id);
                    formCrear.Close();
                }
            }
        }

        private void BtnAddTema_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarTema>(0, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                }
            }
        }

        private void BtnAddSubtema_Click(object sender, EventArgs e)
        {
            if (CbxTema.SelectedValue.ToString() != "")
            {
                using (var formCrear = FormFactory.Create<FrmCrearEditarTema>(0, ActionFormMode.Create))
                {
                    var result = formCrear.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        formCrear.Close();
                    }    
                }
            }
        }

        private void TxtCodigoBarra_KeyUp(object sender, KeyEventArgs e)
        {
            var cuenta = "0";
            if (CbxProveedor.Proveedor != null)
            {
                cuenta = CbxProveedor.Proveedor.Cuenta.ToString();
                
            }
            Codigo = cuenta.PadLeft(4,'0') + CodigoBarra.PadLeft(13, '0');
           
        }

        private void CbxProveedor_SeleccionarFinished(object sender, Proveedor e)
        {
            //MessageBox.Show("seleecion " + CbxProveedor.Proveedor.Cuenta);
            if (CbxProveedor.Proveedor != null)
                Codigo = CbxProveedor.Proveedor.Cuenta.ToString().PadLeft(4, '0') + CodigoBarra.PadLeft(13, '0');
        }

        private void OnTituloAgregado(Titulo titulo)
        {
            if (TituloAgregado != null)
            {
                TituloAgregado(this, titulo);
            }
        }

        #endregion

        #region ActualizarPrecioVenta
        private void ActualizarPrecioTitulo(Titulo titulo)
        {
            //MOdificar el de todos los proveedores?
            var titulosModificar = new List<Titulo>();
            int _codigo;
            var co = int.TryParse(titulo.CodigoBarra, out _codigo);


            if (String.IsNullOrEmpty(titulo.CodigoBarra) || _codigo == 0)
            {
                titulosModificar = Uow.Titulos.Listado().Where(t => t.Id == titulo.Id).ToList();
            }
            else
            {
                titulosModificar = Uow.Titulos.Listado().Where(t => t.CodigoBarra == titulo.CodigoBarra).ToList();
            }

            if (titulosModificar.Count > 0)
            {
                foreach (var tituloModificar in titulosModificar)
                {
                    if (tituloModificar.ProveedorId == _titulo.ProveedorId)
                    {
                        //Precio de Venta
                        if (PrecioVenta >= tituloModificar.PrecioVentaTitulo)
                            ActualizarPrecioVenta(tituloModificar);

                        else if (PrecioVenta < tituloModificar.PrecioVentaTitulo)
                        {
                            //_messageBoxDisplayService.ShowInfo("")
                            _messageBoxDisplayService.ShowConfirmationDialog(
                                "El precio del título es menor. Desea almacenarlo?", "Actualizar Precio",
                                () => { ActualizarPrecioVenta(tituloModificar); });
                        }

                        //Precio de Compra
                        //if (PrecioBase >= tituloModificar.PrecioCompraTitulo)
                        //    ActualizarPrecioCompra(tituloModificar);

                      

                    }
                    else
                    {
                        if ((PrecioVenta > tituloModificar.PrecioVentaTitulo))//|| (PrecioBase > tituloModificar.PrecioCompraTitulo))
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

        #endregion

        private void TxtCodigoBarra_TextChanged(object sender, EventArgs e)
        {
            TxtCodigoBarra_KeyUp(null, null);
        }
    }
}
