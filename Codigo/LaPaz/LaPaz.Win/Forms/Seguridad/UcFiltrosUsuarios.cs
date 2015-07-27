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
using LaPaz.Seguridad;
using LaPaz.Win.Forms.Util;

namespace LaPaz.Win.Forms.Seguridad
{
    public partial class UcFiltrosUsuarios : UserControlBase
    {
        private bool _cargandoFiltros;

        public UcFiltrosUsuarios()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();

           // this.UcHabilitado.SeleccionarFinished += UcHabilitado_SeleccionarFinished;
        }

        #region Eventos
        
        public EventHandler Filtered;
        
        #endregion

        #region Propiedades

        public string Criteria
        {
            get { return TxtTextoBuscar.Text; }
            set { TxtTextoBuscar.Text = value; }
        }

        public string Cuit
        {
            get { return TxtCuit.Text; }
            set { TxtCuit.Text = value; }
        }

        public bool? Habilitado
        {
            get
            {
                switch (UcHabilitado.Value)
                {
                    case SiNoEnum.Si:
                        return true;
                    case SiNoEnum.No:
                        return false;
                    default:
                        return null;
                }
            }
        }

        #endregion

        #region Metodos

        private void UcFiltrosUsuarios_Load(object sender, EventArgs e)
        {
            if (!this.Context.IsInRole(RolesNames.SuperAdmin))
            {
                this.UcHabilitado.Visible = false;
                this.LbHabilitado.Visible = false;
            }
            else
            {
                this.UcHabilitado.Visible = true;
                this.LbHabilitado.Visible = true;
            }
        }

        private void TxtTextoBuscar_TextChanged(object sender, EventArgs e)
        {
            if (!_cargandoFiltros)
                OnFiltered();
        }

        private void TxtCuit_TextChanged(object sender, EventArgs e)
        {
            if (!_cargandoFiltros)
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
            _cargandoFiltros = true;
            TxtTextoBuscar.Text = string.Empty;
            TxtCuit.Text = string.Empty;
            _cargandoFiltros = false;

            OnFiltered();
        }

        private void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        private void UcHabilitado_SeleccionarFinished(object sender, SiNoEnum? i)
        {
            if (!_cargandoFiltros)
                OnFiltered();
        }

        #endregion
    }
}
