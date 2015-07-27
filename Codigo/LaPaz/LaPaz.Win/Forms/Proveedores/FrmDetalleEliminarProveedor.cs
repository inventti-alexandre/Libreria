using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Validation;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Proveedores
{
    public partial class FrmDetalleEliminarProveedor : FormBase
    {
        private readonly Guid _proveedorId;

        public FrmDetalleEliminarProveedor(ILaPazUow uow, Guid id,ActionFormMode mode)
        {
            Uow = uow;
            _proveedorId = id;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleProveedor;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarProveedor;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        #region Propiedades

        public int? Cuenta
        {
            get
            {
                int cuenta;
                return int.TryParse(TxtCuenta.Text, out cuenta) ? cuenta : (int?)null;
            }
            set
            {
                TxtCuenta.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public string Denominacion
        {
            get { return TxtDenominacion.Text; }
            set { TxtDenominacion.Text = value; }
        }

        public string Domicilio
        {
            get { return TxtDomicilio.Text; }
            set { TxtDomicilio.Text = value; }
        }

        public string Telefono
        {
            get { return TxtTelefono.Text; }
            set { TxtTelefono.Text = value; }
        }

        public string Celular
        {
            get { return TxtCelular.Text; }
            set { TxtCelular.Text = value; }
        }

        public string Contacto
        {
            get { return TxtContacto.Text; }
            set { TxtContacto.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        public string EmailPedido
        {
            get { return TxtEmailPedido.Text; }
            set { TxtEmailPedido.Text = value; }
        }

        public string Comentarios
        {
            get { return TxtComentarios.Text; }
            set { TxtComentarios.Text = value; }
        }

        public string Provincia
        {
            get { return TxtProvincia.Text; }
            set { TxtProvincia.Text = value; }
        }
        
        public string Localidad
        {
            get { return TxtLocalidad.Text; }
            set { TxtLocalidad.Text = value; }
        }

        public string TipoDocumento
        {
            get { return TxtTipoDocumento.Text; }
            set { TxtTipoDocumento.Text = value; }
        }

        public string CondicionCompra
        {
            get { return TxtCondicionCompra.Text; }
            set { TxtCondicionCompra.Text = value; }
        }

        public decimal? Descuento
        {
            get { return string.IsNullOrEmpty(TxtDescuento.Text) ? (decimal?)null : Convert.ToDecimal(TxtDescuento.Text); }
            set { TxtDescuento.Text = value == null ? string.Empty : value.GetValueOrDefault().ToString("N2"); }
        }

        public string PaginaWeb
        {
            get { return TxtPaginaWeb.Text; }
            set { TxtPaginaWeb.Text = value; }
        }

        #endregion

        #region Metodos

        private void FrmDetalleEliminarProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedor(_proveedorId);
            radPageView1.SelectedPage = PageGeneral;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var proveedor = Uow.Proveedores.Obtener(p => p.Id == _proveedorId);
            proveedor.Activo = false;
            Uow.Proveedores.Modificar(proveedor);
            
            Uow.Commit();
        }

        private void CargarProveedor(Guid proveedorId)
        {
            Proveedor proveedor = Uow.Proveedores.Obtener(p => p.Id == proveedorId, p => p.Provincia, p => p.Localidad, 
                                                        p => p.TiposDocumentosIdentidad, p => p.CondicionCompra);

            this.Cuenta = proveedor.Cuenta;
            this.Denominacion = proveedor.Denominacion;
            this.Domicilio = proveedor.Domicilio;
            this.Telefono = proveedor.Telefono;
            this.Celular = proveedor.Celular;
            this.Contacto = proveedor.Contacto;
            this.Cuit = proveedor.Cuit;
            this.Provincia = proveedor.Provincia != null ? proveedor.Provincia.Nombre : string.Empty;
            this.Localidad = proveedor.Localidad != null ? proveedor.Localidad.Nombre : string.Empty;
            this.EmailPedido = proveedor.EmailPedido;
            this.Comentarios = proveedor.Comentarios;
            this.TipoDocumento = proveedor.TiposDocumentosIdentidad != null ? proveedor.TiposDocumentosIdentidad.Nombre : string.Empty;
            this.Descuento = proveedor.PorcentajeDescuento;
            this.PaginaWeb = proveedor.PaginaWeb;
            this.CondicionCompra = proveedor.CondicionCompra != null ? proveedor.CondicionCompra.Nombre : string.Empty;

            CargarBancos();
        }

        private void CargarBancos()
        {
            //TODO: Refrescar el uow de alguna manera
            var bancos = Uow.ProveedoresBancos.Listado(pb => pb.Banco).Where(pb => pb.ProveedorId == _proveedorId).ToList();
            var list = bancos.Select(AutoMapper.Mapper.Map<ProveedorBancoDto>).ToList();
            GridBancos.DataSource = list;
        }

        #endregion
    }
}
