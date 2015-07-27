using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;
using System;

namespace LaPaz.Win.Forms.ProveedoresGastos
{
    public partial class FrmDetalleEliminarProveedorGasto : FormBase
    {
        private readonly Guid _proveedorId;

        public FrmDetalleEliminarProveedorGasto(ILaPazUow uow, Guid id, ActionFormMode mode)
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
                    this.Text = Resources.LabelDetalleProveedorGasto;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarProveedorGasto;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        #region Propiedades

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

        #endregion

        #region Metodos

        private void FrmDetalleEliminarProveedor_Load(object sender, EventArgs e)
        {
            CargarProveedor(_proveedorId);
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

            this.Denominacion = proveedor.Denominacion;
            this.Domicilio = proveedor.Domicilio;
            this.Telefono = proveedor.Telefono;
            this.Celular = proveedor.Celular;
            this.Contacto = proveedor.Contacto;
            this.Cuit = proveedor.Cuit;
            this.Provincia = proveedor.Provincia != null ? proveedor.Provincia.Nombre : string.Empty;
            this.Localidad = proveedor.Localidad != null ? proveedor.Localidad.Nombre : string.Empty;
            this.TipoDocumento = proveedor.TiposDocumentosIdentidad != null ? proveedor.TiposDocumentosIdentidad.Nombre : string.Empty;
        }

        #endregion
    }
}
