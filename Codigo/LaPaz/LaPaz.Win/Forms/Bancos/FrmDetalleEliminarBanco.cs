using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Bancos
{
    public partial class FrmDetalleEliminarBanco : FormBase
    {
        private readonly int _bancoId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

        public FrmDetalleEliminarBanco(ILaPazUow uow, IMessageBoxDisplayService messageBoxDisplayService, int id, ActionFormMode mode)
        {
            Uow = uow;
            _messageBoxDisplayService = messageBoxDisplayService;
            _bancoId = id;

            InitializeComponent();

            InicializarForm(mode);
        }

        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleBanco;
                    this.BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarBanco;
                    this.BtnEliminar.Visible = true;
                    break;
            }
        }

        #region Propiedades
        public int Id { get; set; }

        public string Nombre
        {
            get { return txtNombre.Text; }
            set { txtNombre.Text = value; }
        }

        #endregion

        private void FrmDetalleEliminarBanco_Load(object sender, EventArgs e)
        {
            CargarBanco(_bancoId);
        }

        private void CargarBanco(int bancoId)
        {
            Banco banco = Uow.Bancos.Obtener(c => c.Id == bancoId, c => c.Provincia, c => c.Localidad);

            this.Nombre = banco.Nombre;
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var banco = Uow.Bancos.Obtener(p => p.Id == _bancoId);

            var cheques = Uow.ChequesTerceros.Listado().Where(c => c.BancoId == _bancoId).ToList();
            var tarjetasMovimientos = Uow.TarjetasMovimientos.Listado().Where(m => m.BancoId == _bancoId).ToList();
            if (cheques.Any() || tarjetasMovimientos.Any())
            {
                _messageBoxDisplayService.Show(Resources.ErrorMessageBancoConDatos,Resources.LabelBancos);
                return;
            }

            var proveedores = Uow.Proveedores.Listado().Where(p => p.ProveerdorBcoId == _bancoId).ToList();
            foreach (var proveedor in proveedores)
            {
                proveedor.ProveerdorBcoId = null;
                Uow.Proveedores.Modificar(proveedor);
            }

            var proveedoresBancos = Uow.ProveedoresBancos.Listado().Where(pb => pb.BancoId == _bancoId).ToList();
            foreach (var proveedorBanco in proveedoresBancos)
            {
                Uow.ProveedoresBancos.Eliminar(proveedorBanco);
            }

            Uow.Bancos.Eliminar(banco);
            Uow.Commit();
        }
    }
}
