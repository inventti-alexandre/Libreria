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
using LaPaz.Win.Forms.Clientes;

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class UcClienteDetalleConsignacion : UserControlBase
    {
        public event EventHandler<Cliente> ClienteEdited; 

        private Cliente _cliente;

        public UcClienteDetalleConsignacion()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }
            InitializeComponent();
        }

        public string ClienteNombre
        {
            get { return TxtClienteNombre.Text; }
            set { TxtClienteNombre.Text = value; }
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

        public string FormaPago
        {
            get { return TxtFormaPago.Text; }
            set { TxtFormaPago.Text = value; }
        }

        public void ActualizarCliente(Cliente cliente)
        {
            _cliente = cliente;

            this.ClienteNombre = cliente.Denominacion;
            this.Domicilio = cliente.Domicilio;
            this.Cuit = cliente.Cuit;
            this.Localidad = cliente.Localidad.Nombre;
            this.Provincia = cliente.Provincia.Nombre;
            this.FormaPago = cliente.CondicionesVenta.Nombre;

            LnkVerDetalleCliente.Enabled = true;
            LnkEditarCliente.Enabled = true;
        }

        private void LnkVerDetalleCliente_Click(object sender, EventArgs e)
        {
            if (_cliente == null)
            {
                return;
            }

            DetalleCliente(_cliente);
        }

        private void DetalleCliente(Cliente cliente)
        {
            using (var formCrearCliente = FormFactory.Create<FrmDetalleEliminarCliente>(cliente.Id, ActionFormMode.Detail))
            {
                formCrearCliente.ShowDialog();
            }
        }

        public void ActualizarCliente(Cliente cliente, decimal deudaTotal, decimal deudaVencida)
        {
            TxtDeudaTotal.Text = deudaTotal.ToString("c2");
            TxtDeudaVencida.Text = deudaVencida.ToString("c2");
            ActualizarCliente(cliente);
        }

        private void EditarCliente(Cliente cliente)
        {
            using (var formCrearCliente = FormFactory.Create<FrmCrearEditarCliente>(cliente.Id, ActionFormMode.Edit))
            {
                if (formCrearCliente.ShowDialog() == DialogResult.OK)
                {
                    if (ClienteEdited != null)
                    {
                        ClienteEdited(this, cliente);
                    }
                }
            }
        }

        private void LnkEditarCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_cliente == null)
            {
                return;
            }

            EditarCliente(_cliente);
        }
    }
}
