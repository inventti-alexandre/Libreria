using System;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using System.Linq;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcLocalidad : UserControlBase
    {
        private bool _cargandoLocalidades;

        public event EventHandler<Localidad> SeleccionarFinished;

        private Localidad _provincia;
        public Localidad Localidad
        {
            get { return _provincia; }
        }

        public int? LocalidadId
        {
            get { return (int?)(Combo.SelectedIndex != 0 ? Combo.SelectedValue : null); }
            set { Combo.SelectedValue = value ?? 0; }
        }

        public UcLocalidad()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void Localidad_Load(object sender, EventArgs e)
        {
        }

        public void CargarLocalidades(int provinciaId)
        {
            if (Ioc.Container == null)
                return;

            _cargandoLocalidades = true;

            var localidades = Uow.Localidades.Listado().Where(l => l.ProvinciaId == provinciaId).ToList();
            localidades.Insert(0,new Localidad() { Id = 0, Nombre = "SELECCIONE LOCALIDAD" });

            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
            Combo.DataSource = localidades;

            _cargandoLocalidades = false;
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoLocalidades)
                SeleccionarLocalidad();
        }

        private void SeleccionarLocalidad()
        {
            var provincia = Uow.Localidades.Obtener(p => p.Id == LocalidadId);
            _provincia = provincia;
            OnSeleccionarLocalidadFinished(provincia);
        }

        private void OnSeleccionarLocalidadFinished(Localidad provincia)
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
