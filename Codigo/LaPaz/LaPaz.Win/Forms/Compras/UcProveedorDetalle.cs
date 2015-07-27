using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Proveedores;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcProveedorDetalle : UserControlBase
    {
        private Proveedor _proveedor;

        public UcProveedorDetalle()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }
            InitializeComponent();
        }

        #region Propiedaes

        //public string Cuit
        //{
        //    get { return TxtProveedorCuit.Text; }
        //    set { TxtProveedorCuit.Text = value; }
        //}

        //public string Domicilio
        //{
        //    get { return TxtProveedorDomicilio.Text; }
        //    set { TxtProveedorDomicilio.Text = value; }
        //}

        //public string Provincia
        //{
        //    get { return TxtProveedorProvincia.Text; }
        //    set { TxtProveedorProvincia.Text = value; }
        //}

        //public string Localidad
        //{
        //    get { return TxtProveedorLocalidad.Text; }
        //    set { TxtProveedorLocalidad.Text = value; }
        //}

        //public string Celular
        //{
        //    get { return TxtProveedorCelular.Text; }
        //    set { TxtProveedorCelular.Text = value; }
        //}

        //public string Telefono
        //{
        //    get { return TxtProveedorTelefono.Text; }
        //    set { TxtProveedorTelefono.Text = value; }
        //}

        //public string Contacto
        //{
        //    get { return TxtProveedorContacto.Text; }
        //    set { TxtProveedorContacto.Text = value; }
        //}

        //public string EmailContacto
        //{
        //    get { return TxtProveedorEmailPedido.Text; }
        //    set { TxtProveedorEmailPedido.Text = value; }
        //}

        #endregion

        public void ActualizarProveedor(Proveedor proveedor)
        {
            _proveedor = proveedor;

            //this.Domicilio = proveedor.Domicilio;
            //this.Cuit = proveedor.Cuit;
            //this.Localidad = proveedor.Localidad.Nombre;
            //this.Provincia = proveedor.Provincia.Nombre;
            //this.Celular = proveedor.Celular;
            //this.Telefono = proveedor.Telefono;
            //this.Contacto = proveedor.Contacto;
            //this.EmailContacto = proveedor.EmailPedido;

            LnkVerDetalleProveedor.Enabled = true;
        }

        private void LnkVerDetalleProveedor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_proveedor == null)
            {
                return;
            }

            DetalleProveedor(_proveedor);
        }

        private void DetalleProveedor(Proveedor proveedor)
        {
            using (var formCrearProveedor = FormFactory.Create<FrmDetalleEliminarProveedor>(proveedor.Id,
                    ActionFormMode.Detail))
            {
                formCrearProveedor.ShowDialog();
            }
        }

        private void UcProveedorDetalle_Load(object sender, EventArgs e)
        {

        }
    }
}
