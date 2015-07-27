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
    public partial class UcFiltroTemas : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<Tema> SeleccionarFinished;

        private Tema _tema;
        public Tema Tema
        {
            get { return _tema; }
        }

        public int? TemaId
        {
            get
            {
                var temaId = Combo.SelectedValue as int?;
                return temaId == 0 ? null : temaId;
            }
            set { Combo.SelectedValue = value ?? 0; }
        }

        public UcFiltroTemas()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrSubTema_Load(object sender, EventArgs e)
        {
            CargarTemas();
        }

        public void CargarTemas()
        {
            if (Ioc.Container == null)
                return;

            _limpiandoFiltros = true;
            var tema = Uow.Temas.Listado().OrderBy(s => s.Nombre).ToList();
            tema.Insert(0, new Tema() { Nombre= "SELECCIONE TEMA", Id = 0 });
            Combo.DataSource = tema;
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
                SeleccionarSubTema();
        }

        private void SeleccionarSubTema()
        {
            if (TemaId.HasValue)
            {
                _tema = Uow.Temas.Obtener(p => p.Id == (int)Combo.SelectedValue);
            }
            else
            {
                _tema = null;
            }
            
            if (_tema != null)
                OnSeleccionarSucursalFinished(_tema);
        }

        private void OnSeleccionarSucursalFinished(Tema tema)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, tema);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }
}
