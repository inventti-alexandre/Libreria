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

namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroCentrosCostos : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<CentrosCosto> SeleccionarFinished;

        private CentrosCosto _CentrosCosto;

        public CentrosCosto getCentrosCosto
        {
            get { return _CentrosCosto; }
        }

        public int? CentrosCostoId
        {
            get { return (int?) Combo.SelectedValue; }
            set { Combo.SelectedValue = value; }
        }

        public UcFiltroCentrosCostos()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltroCentrosCosto_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarCentroCosto()
        {
            _limpiandoFiltros = true;
            var centroCosto = Uow.CentrosCostos.Listado().OrderBy(p => p.Nombre).ToList();
            centroCosto.Insert(0, new CentrosCosto() { Nombre= "SELECCIONE CENTRO COSTO"});
            Combo.DataSource = centroCosto;
            DefinirCombo();
            _limpiandoFiltros = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                SeleccionarCentroCosto();
        }

        private  void OnSelecionarCentroCosto(CentrosCosto centroCosto)
        {
            if (SeleccionarFinished != null)
                SeleccionarFinished(this, centroCosto);
        }

        private void SeleccionarCentroCosto()
        {
            if (CentrosCostoId.HasValue)
            {
                
            }
            _CentrosCosto = CentrosCostoId.HasValue
                                ? Uow.CentrosCostos.Obtener(p => p.Id == (int) Combo.SelectedValue)
                                : null;
            OnSelecionarCentroCosto(_CentrosCosto);
        }

        public void Reset()
        {
            Combo.SelectedIndex = 0;
        }

    }
}
