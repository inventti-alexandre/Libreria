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
    public partial class UcFiltroTiposGastos : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<TiposGasto> SeleccionarFinished;

        private TiposGasto _tiposGasto;
        public TiposGasto getTiposGasto
        {
            get { return _tiposGasto; }
        }

        public int? TipoGastoId
        {
            get { return (int?)Combo.SelectedValue; }
            set { Combo.SelectedValue = value; }
        }

        public UcFiltroTiposGastos()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrTiposGasto_Load(object sender, EventArgs e)
        {
            
        }

        public void CargarTiposGasto()
        {
            _limpiandoFiltros = true;
            var tiposGastos = Uow.TiposGastos.Listado().OrderBy(t => t.Nombre).ToList();
            tiposGastos.Insert(0, new TiposGasto() { Nombre= "SELECCIONE TIPO GASTO", Id = 0 });
            Combo.DataSource = tiposGastos;
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
                SeleccionarTiposGasto();
        }

        private void OnSeleccionarTipoGastoFinished(TiposGasto tipoGasto)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, tipoGasto);
            }
        }

        private void SeleccionarTiposGasto()
        {
            _tiposGasto = TipoGastoId.HasValue ?  Uow.TiposGastos.Obtener(p => p.Id == (int)Combo.SelectedValue) : null;
            OnSeleccionarTipoGastoFinished(_tiposGasto);
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }

    }
}
