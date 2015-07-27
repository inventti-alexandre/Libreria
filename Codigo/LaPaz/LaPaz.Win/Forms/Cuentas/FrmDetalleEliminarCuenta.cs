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
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Cuentas
{
    public partial class FrmDetalleEliminarCuenta : EditFormBase
    {
        private readonly int _cuentaId;
        private readonly IClock _clock;
        private readonly ActionFormMode _formMode;
        private Cuenta _cuenta;
        
        public FrmDetalleEliminarCuenta(ILaPazUow uow, IClock clock, int id, ActionFormMode mode)
        {
            Uow = uow;

            _cuentaId = id;
            _clock = clock;
            _formMode = mode;

            InitializeComponent();
            InicializarForm(mode);

        }

        #region Metodos
        private void InicializarForm(ActionFormMode mode)
        {
            switch (mode)
            {
                case ActionFormMode.Detail:
                    this.Text = Resources.LabelDetalleCuenta;
                    BtnEliminar.Visible = false;
                    break;
                case ActionFormMode.Delete:
                    this.Text = Resources.LabelEliminarCuenta;
                    BtnEliminar.Visible = true;
                    break;
            }
        }

        private void CargarCuenta(int cuentaId)
        {
            _cuenta = Uow.Cuentas.Obtener(a => a.Id == cuentaId, c => c.BancosPropio, c => c.TiposCuenta);
            TxtNombre.Text = _cuenta.Nombre;
            TxtBanco.Text = _cuenta.BancosPropio.Nombre;
            TxtTipoCuenta.Text = _cuenta.TiposCuenta.Nombre;
            TxtDescripcion.Text = _cuenta.Descripcion;
            TxtTitular.Text = _cuenta.Titular;
            TxtFechaApertura.Text = _cuenta.FechaApertura.ToShortDateString();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            var cuenta = Uow.Cuentas.Obtener(c => c.Id == _cuentaId);
            var movimientos = Uow.CuentasMovimientos.Listado().Count(m => m.CuentaId == _cuentaId);
            if (movimientos > 0)
            {
                cuenta.FechaCierre = _clock.Now;
                cuenta.Activo = false;
                Uow.Cuentas.Modificar(cuenta);
            }
            else
            {
                Uow.Cuentas.Eliminar(cuenta);
            }
            
            Uow.Commit();
        }

        private void FrmDetalleEliminarAutor_Load(object sender, EventArgs e)
        {
            CargarCuenta(_cuentaId);
        }

        #endregion

    }
}
