using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using Framework.Ioc;
using LaPaz.Entidades;
using System.Linq.Expressions;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class ucBuscadorPresupuesto : UserControlBase
    {
        public ucBuscadorPresupuesto()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        public event EventHandler<List<Presupuestos>> BuscarPresupuestoFinished;

        private void BtnBuscarPresupuesto_Click(object sender, EventArgs e)
        {
            BuscarPresupuesto(Context.SucursalActual.Id);
        }

        private void BuscarPresupuesto(int sucursalId)
        {
            int nroPresupuesto;
            var isNumeric = int.TryParse(TxtTextoBuscar.Text, out nroPresupuesto);

            //if (!isNumeric)
            //{
            //    OnBuscarPresupuestoFinished(null);
            //}

            Expression<Func<Presupuestos, bool>> where = x => x.LCN == TxtTextoBuscar.Text
               // && x.TipoComprobante == (int)TipoComprobanteEnum.RemitosConsignacCliente
               &&  x.SucursalAltaId == sucursalId;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var presupuestos = Uow.Presupuesto.Listado()
                .Where(@where)
                .ToList();

                Cursor.Current = Cursors.Default;
                OnBuscarPresupuestoFinished(presupuestos);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void OnBuscarPresupuestoFinished(List<Presupuestos> presupuesto)
        {
            if (BuscarPresupuestoFinished != null)
            {
                BuscarPresupuestoFinished(this, presupuesto);
            }
        }

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BuscarPresupuesto(Context.SucursalActual.Id);
            }
        }

    }
}
