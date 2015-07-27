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

namespace LaPaz.Win.Forms.Editorial
{
    public partial class UcFiltrosEditorial : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosEditorial()
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

        public string Nombre
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        #endregion

        #region Metodos

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
            _limpiandoFiltros = false;

           // OnFiltered();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        #endregion

        private void TxtTextoBuscar_KeyUp(object sender, KeyEventArgs e)
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
