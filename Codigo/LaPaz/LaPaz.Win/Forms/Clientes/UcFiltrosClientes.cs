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
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.Clientes
{
    public partial class UcFiltrosClientes : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosClientes()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        //public event EventHandler<List<Cliente>> BuscarFinished;
        #endregion

        #region Propiedades

        public string Denominacion
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        //public int? ProvinciaId
        //{
        //    get { return (int?)(CbxProvincia.SelectedIndex != 0 ? CbxProvincia.SelectedValue : null); }
        //    set { CbxProvincia.SelectedValue = value ?? 0; }
        //}

        //public int? LocalidadId
        //{
        //    get { return (int?)(CbxLocalidad.SelectedIndex != 0 ? CbxLocalidad.SelectedValue : null); }
        //    set { CbxLocalidad.SelectedValue = value ?? 0; }
        //}

        #endregion

        #region Metodos

        private void UcFiltrosClientes_Load(object sender, EventArgs e)
        {

        }

        private void TxtTextoBuscar_TextChanged(object sender, EventArgs e)
        {
            //if (!_limpiandoFiltros)
            //    OnFiltered();
        }

        private void TxtCuit_TextChanged(object sender, EventArgs e)
        {
            //if (!_limpiandoFiltros)
            //    OnFiltered();
        }
        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;
            TxtTextoBuscar.Text = string.Empty;
            TxtCuit.Text = string.Empty;
            _limpiandoFiltros = false;

           // OnFiltered();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            OnFiltered();
            //var textBuscarDenominacion = TxtTextoBuscar.Text;
            //var textBuscarCuit = TxtTextoBuscar.Text.PadLeft(11, '0');

            //Expression<Func<Cliente, bool>> where =
            //    x => SqlFunctions.PatIndex(textBuscarCuit, x.Cuit) > 0 || SqlFunctions.PatIndex(textBuscarDenominacion, x.Denominacion) > 0;

            //Cursor.Current = Cursors.WaitCursor;

            //var clientes = Uow.Clientes.Listado(x => x.CondicionesVenta, x => x.Localidad, x => x.Provincia)
            //                           .Where(where)
            //                           .ToList();

            //Cursor.Current = Cursors.Default;

            //OnBuscarFinished(clientes);
        }

        #endregion

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtCuit_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        }

    }
}
