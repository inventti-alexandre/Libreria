using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Forms;
using Framework.Comun.Extentensions;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class UcFiltrosPresupuesto : UserControlBase
    {
        private bool _limpiandoFiltros;

        public UcFiltrosPresupuesto()
        {
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public string TextoABuscar
        {
            get { return TxtTexto.Text; }
            set { TxtTexto.Text = value; }
        }

        public string LCN
        {
            get { return TxtNumero.Text; }
            set { TxtNumero.Text = value; }
        }

        #endregion

        #region Metodos

        private void UcFiltrosVentas_Load(object sender, EventArgs e)
        {
        }

        private void TxtTexto_TextChanged(object sender, EventArgs e)
        {
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

            TxtTexto.Text = string.Empty;

            _limpiandoFiltros = false;

            OnFiltered();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        private void TxtTexto_KeyUp(object sender, KeyEventArgs e)
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

        #endregion

       
    }
}
