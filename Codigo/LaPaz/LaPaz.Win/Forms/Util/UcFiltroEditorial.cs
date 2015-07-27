using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using System.Linq;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroEditorial : UserControlBase
    {
        private bool _cargandoEditorial;

        public event EventHandler<Entidades.Editorial> SeleccionarFinished;

        private Entidades.Editorial _editorial;
        public Entidades.Editorial Editorial
        {
            get { return _editorial; }
        }

        public int? EditorialId
        {
            get
            {
                var editorialId = Combo.SelectedValue as int?;
                return editorialId == 0 ? null : editorialId;
            }
            set
            {
                Combo.SelectedValue = value ?? 0;
            }
        }

        public UcFiltroEditorial()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void UcFiltroEditorial_Load(object sender, EventArgs e)
        {
            CargarEditorial();
        }

        public void CargarEditorial()
        {
            if (Ioc.Container == null)
                return;

            _cargandoEditorial = true;

            DefinirCombo();

            var editorial = Uow.Editoriales.Listado().Where(e => e.Activo.Value == true).OrderBy(s => s.Nombre).ToList();
            editorial.Insert(0, new Entidades.Editorial() { Nombre = "SELECCIONE EDITORIAL", Id = 0 });
            Combo.DataSource = editorial;

            _cargandoEditorial = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoEditorial)
                SeleccionarSucursal();
        }

        private void SeleccionarSucursal()
        {
            _editorial = (EditorialId.HasValue)
                            ? Uow.Editoriales.Obtener(p => p.Id == EditorialId)
                            : null;

            if (_editorial != null)
                OnSeleccionarEditorialFinished(_editorial);
        }

        private void OnSeleccionarEditorialFinished(Entidades.Editorial editorial)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, editorial);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }
}
