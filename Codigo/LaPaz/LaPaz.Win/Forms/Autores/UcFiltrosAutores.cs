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
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Forms.Util;

namespace LaPaz.Win.Forms.Autores
{
    public partial class UcFiltrosAutores : UserControlBase
    {
        public UcProgressSpinner Spinner
        {
            get { return ucProgressSpinner1; }
        }

        private bool _limpiandoFiltros;

        public UcFiltrosAutores()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return TxtNombre.Text; }
            set { TxtNombre.Text = value; }
        }

        #endregion

        #region Metodos

        private void UcFiltrosLibros_Load(object sender, EventArgs e)
        {
            if (Uow == null) return;

        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
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

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;

            TxtNombre.Text = string.Empty;

            _limpiandoFiltros = false;

            OnFiltered();

        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        #endregion

    }
}
