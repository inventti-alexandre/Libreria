using System;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using System.Linq;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcProvincia : UserControlBase
    {
        private bool _cargandoProvincias;

        public event EventHandler<Provincia> SeleccionarFinished;

        private Provincia _provincia;
        public Provincia Provincia
        {
            get { return _provincia; }
        }

        public int? ProvinciaId
        {
            get { return (int?)(Combo.SelectedIndex != 0 ? Combo.SelectedValue : null); }
            set { Combo.SelectedValue = value ?? 0; }
        }

        public UcProvincia()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void Provincia_Load(object sender, EventArgs e)
        {
            CargarProvincias();
        }

        public void CargarProvincias()
        {
            if (Ioc.Container == null)
                return;

            _cargandoProvincias = true;

            var provincias = Uow.Provincias.Listado().OrderBy(s => s.Nombre).ToList();
            provincias.Insert(0,new Provincia() { Id = 0, Nombre = "SELECCIONE PROVINCIA" });

            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
            Combo.DataSource = provincias;

            _cargandoProvincias = false;
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoProvincias)
                SeleccionarProvincia();
        }

        private void SeleccionarProvincia()
        {
            var provincia = Uow.Provincias.Obtener(p => p.Id == ProvinciaId);
            _provincia = provincia;
            OnSeleccionarProvinciaFinished(provincia);
        }

        private void OnSeleccionarProvinciaFinished(Provincia provincia)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, provincia);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }
}
