using System;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Negocio;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Clientes;

namespace LaPaz.Win.Forms.Proveedores
{
    public partial class UcProveedorDetalle : UserControlBase
    {
        private Proveedor _proveedor;
      
        public UcProveedorDetalle()
        {
            InitializeComponent();
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

        public decimal? Disponible
        {
            get
            {
                decimal disponible;
                return decimal.TryParse(TxtDisponible.Text, out disponible) ? disponible : (decimal?)null;
            }
            set { TxtDisponible.Text = value.HasValue ? value.Value.ToString("n2") : string.Empty; }
        }


        public void ActualizarProveedor(Proveedor proveedor)
        {
            _proveedor = proveedor;

            this.Denominacion = proveedor.Denominacion;
            this.Domicilio = proveedor.Domicilio;
            this.Cuit = proveedor.Cuit;
            this.Localidad = proveedor.Localidad != null ? proveedor.Localidad.Nombre : string.Empty;
            this.Provincia = proveedor.Provincia != null ? proveedor.Provincia.Nombre : string.Empty;
        }
    }
}
