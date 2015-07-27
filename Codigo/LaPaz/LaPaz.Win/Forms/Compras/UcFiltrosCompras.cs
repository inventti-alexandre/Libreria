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
using LaPaz.Entidades.Enums;
using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcFiltrosCompras : UserControlBase
    {
        public UcProgressSpinner Spinner
        {
            get { return ucProgressSpinner1; }
        }

        public bool FiltrosVacios
        {
            get
            {
                return ProveedorId == null &&
                       string.IsNullOrEmpty(NroComprobante) &&
                       TipoId == null;
            }
        }

        private bool _limpiandoFiltros;

        public UcFiltrosCompras()
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

       
        public Guid? ProveedorId
        {
            get { return (Guid?)(CbxProveedor.SelectedIndex != 0 ? CbxProveedor.SelectedValue : null); }
            set { CbxProveedor.SelectedValue = value ?? Guid.Empty; }
        }

       public TipoComprobanteEnum? TipoId
        {
            get { return (TipoComprobanteEnum?)(cbxTipo.SelectedIndex != 0 ? cbxTipo.SelectedValue : null); }
            set { cbxTipo.SelectedValue = value ?? 0; }
        }

        public string NroComprobante
        {
            get { return TxtNroCompra.Text; }
            set { TxtNroCompra.Text = value; }
        }

        public DateTime FechaInicio 
        {
            get { return dtpDesde.Value; }
            set { dtpDesde.Value = value; }
        }

        public DateTime FechaHasta
        {
            get { return DtpHasta.Value; }
            set { DtpHasta.Value = value; }
        }

       #endregion

        #region Metodos

        private async void UcFiltrosLibros_Load(object sender, EventArgs e)
        {
            if (Uow == null) return;

            await CargarCombos();
            DtpHasta.Value = DateTime.Now;
        }

       private async Task CargarCombos()
        {
            _limpiandoFiltros = true;

            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == false).OrderBy(p => p.Denominacion).ToList();
            proveedores.Insert(0, new Proveedor() { Denominacion = "SELECCIONE PROVEEDOR", Cuenta = 0 });

            CbxProveedor.DisplayMember = "Denominacion";
            CbxProveedor.ValueMember = "Id";
            CbxProveedor.DataSource = proveedores;

            var tipo = Uow.TiposComprobantes.Listado().OrderBy(t => t.Nombre).ToList();
            //tipo.Insert(0, new TipoComprobante()); { Nombre = "SELECCIONE TIPO" });
            cbxTipo.DataSource = tipo;
            cbxTipo.DisplayMember = "Nombre";
            cbxTipo.ValueMember = "Id";

            _limpiandoFiltros = false;
        }

       private void cbxTipo_SelectedValueChanged(object sender, EventArgs e)
       {
           if (!_limpiandoFiltros)
               OnFiltered();
       }

      private void CbxProveedor_SelectedValueChanged(object sender, EventArgs e)
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
            CbxProveedor.SelectedIndex = 0;
            TxtNroCompra.Text = string.Empty;
            cbxTipo.SelectedIndex = 0;
          
            _limpiandoFiltros = false;
         }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

      
        private void cbxTipo_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtAutor_KeyUp(object sender, KeyEventArgs e)
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
