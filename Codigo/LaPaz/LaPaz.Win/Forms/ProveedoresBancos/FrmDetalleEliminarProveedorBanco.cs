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
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.ProveedoresBancos
{
    public partial class FrmDetalleEliminarProveedorBanco : FormBase
    {
        private readonly Guid _proveedorBancoId;

        public FrmDetalleEliminarProveedorBanco(ILaPazUow uow, Guid id, ActionFormMode mode)
        {
            Uow = uow;
            _proveedorBancoId = id;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = "Detalle de Proveedor Banco";
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = "Eliminar Proveedor Banco";
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        #region Propiedades

        public Guid Id { get; set; }

        public Guid ProveedorId { get; set; }

        public string BancoNombre
        {
            get { return TxtBanco.Text; }
            set { TxtBanco.Text = value; }
        }

        public string Titular
        {
            get { return TxtTitular.Text; }
            set { TxtTitular.Text = value; }
        }

        public string CuentaCorriente
        {
            get { return TxtCuentaCorriente.Text; }
            set { TxtCuentaCorriente.Text = value; }
        }

        public string CajaAhorro
        {
            get { return TxtCajaAhorro.Text; }
            set { TxtCajaAhorro.Text = value; }
        }

        public string Cbu
        {
            get { return TxtCbu.Text; }
            set { TxtCbu.Text = value; }
        }

        #endregion

        #region Metodos

        private void FrmDetalleEliminarProveedorBanco_Load(object sender, EventArgs e)
        {
            CargarProveedorBanco(_proveedorBancoId);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var proveedorBanco = Uow.ProveedoresBancos.Obtener(p => p.Id == _proveedorBancoId);
            Uow.ProveedoresBancos.Eliminar(proveedorBanco);
            Uow.Commit();
        }

        private void CargarProveedorBanco(Guid proveedorBancoId)
        {
            ProveedorBanco proveedorBanco = Uow.ProveedoresBancos.Obtener(p => p.Id == proveedorBancoId, p => p.Banco);

            this.BancoNombre = proveedorBanco.Banco.Nombre;
            this.Titular = proveedorBanco.Titular;
            this.Cbu = proveedorBanco.CBU;
            this.CuentaCorriente = proveedorBanco.CtaCte;
            this.CajaAhorro = proveedorBanco.CajaAhorro;
        }

        #endregion
    }
}
