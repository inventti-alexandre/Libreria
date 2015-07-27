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
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Bancos
{
    public partial class UcFiltrosBancos : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosBancos()
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

        
        private void TxtTextoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
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
           _limpiandoFiltros = false;

            OnFiltered();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        #endregion
    }
}
