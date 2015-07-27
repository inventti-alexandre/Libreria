using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Extentensions;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Forms.Senias
{
    public partial class UcBuscadorClienteSimple : UserControlBase
    {
        public string Cuit
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        public UcBuscadorClienteSimple()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        public event EventHandler<List<Cliente>> BuscarFinished;

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
        {
            var textBuscarCuit = TxtTextoBuscar.Text.PadLeft(11, '0');
            var textBuscarDenominacion = TxtTextoBuscar.Text.ToStringSearch();

            Expression<Func<Cliente, bool>> where =
                x =>
                SqlFunctions.PatIndex(textBuscarCuit, x.Cuit) > 0 ||
                SqlFunctions.PatIndex(textBuscarDenominacion, x.Denominacion) > 0;

            Cursor.Current = Cursors.WaitCursor;

            try
            {
                var clientes = Uow.Clientes.Listado(x => x.CondicionesVenta, x => x.Localidad, x => x.Provincia)
                .Where(@where)
                .OrderBy(c => c.Denominacion)
                .ToList();

                Cursor.Current = Cursors.Default;
                OnBuscarFinished(clientes);
            }
            catch (Exception e)
            {
                Cursor.Current = Cursors.Default;
            }
        }


        private void OnBuscarFinished(List<Cliente> clientes)
        {
            if (BuscarFinished != null)
            {
                BuscarFinished(this, clientes);
            }
        }

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            if (TxtTextoBuscar.Text.Length > 2)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    BuscarCliente();
                }
                else
                {
                    BtnBuscarCliente.Enabled = true;
                }
            }
            else
            {
                BtnBuscarCliente.Enabled = false;
            }
        }
    }
}
