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
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Libros
{
    public partial class FrmDetalleEliminarLibro : EditFormBase
    {
        private readonly Guid _tituloId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;
        private Titulo _titulo;

        public FrmDetalleEliminarLibro(ILaPazUow uow,
                                       IClock clock,
                                       IMessageBoxDisplayService messageBoxDisplayService,
                                       Guid id,
                                       ActionFormMode mode)
        {
            Uow = uow;

            _tituloId = id;
            _clock = clock;
            _formMode = mode;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();
            InicializarForm(mode);
        }

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

        public string Proveedor
        {
            get { return TxtProveedor.Text; }
            set { TxtProveedor.Text = value; }
        }

        public string ProveedorCodigo
        {
            get;
            set;
        }

        public string Autor
        {
            get { return TxtAutor.Text; }
            set { TxtAutor.Text = value; }
        }

        public string Editorial
        {
            get { return TxtEditorial.Text; }
            set { TxtEditorial.Text = value; }
        }

        public string Tema
        {
            get { return TxtTema.Text; }
            set { TxtTema.Text = value; }
        }

        public string SubTema
        {
            get { return TxtSubTema.Text; }
            set { TxtSubTema.Text = value; }
        }

        public decimal? PrecioVenta
        {
            get { return Convert.ToDecimal(TxtPrecioVenta.Text); }
            set { TxtPrecioVenta.Text = Convert.ToString(value); }
        }

        public decimal? PrecioCompra
        {
            get { return Convert.ToDecimal(TxtPrecioCompra.Text); }
            set { TxtPrecioCompra.Text = Convert.ToString(value); }
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
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleLibro;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarLibro;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        private void FrmCrearEditarLibro_Load(object sender, EventArgs e)
        {
            CargarTitulo(_tituloId);
        }

        private void CargarTitulo(Guid tituloId)
        {
            if (tituloId == default(Guid))
            {
                _titulo = new Titulo();
                //Default values.
            }
            else
            {
                _titulo = Uow.Titulos.Obtener(t => t.Id == tituloId, p => p.Proveedor, a => a.Autor
                                                    , e => e.Editorial
                                                    , t => t.Tema
                                                    , s => s.SubTema);
            }

            this.Titulo = _titulo.NombreTitulo;
            this.Codigo = _titulo.Cod;
            this.CodigoBarra = _titulo.CodigoBarra;
            this.Isbn = _titulo.ISBN;
            this.Proveedor = _titulo.Proveedor != null ? _titulo.Proveedor.Denominacion : string.Empty;
            this.Autor = _titulo.Autor != null ? _titulo.Autor.Nombre : string.Empty;
            this.Editorial = _titulo.Editorial != null ? _titulo.Editorial.Nombre : string.Empty;
            this.Tema = _titulo.Tema != null ? _titulo.Tema.Nombre : string.Empty;
            this.SubTema = _titulo.SubTema != null ? _titulo.SubTema.Nombre : string.Empty;
            this.PrecioVenta = _titulo.PrecioVentaTitulo;
            this.PrecioCompra = _titulo.PrecioCompraTitulo;
            this.Comentario = _titulo.Comentario;
        }

        #endregion

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            _messageBoxDisplayService.ShowConfirmationDialog(Resources.ConfirmationMessageEliminarLibro, 
                                                             Resources.DialogTitleEliminarLibro, 
                                                             EliminarLibro);
        }

        private void EliminarLibro()
        {
            var titulo = Uow.Titulos.Obtener(p => p.Id == _tituloId);

            titulo.Activo = false;

            Uow.Titulos.Modificar(titulo);
            Uow.Commit();
        }
    }
}
