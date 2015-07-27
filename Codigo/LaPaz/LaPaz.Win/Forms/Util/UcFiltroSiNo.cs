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
    public partial class UcFiltroSiNo : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<SiNoEnum?> SeleccionarFinished;

        public SiNoEnum? Value
        {
            get
            {
                if (Combo.SelectedValue == null)
                    return null;
                var intValue = (int)Combo.SelectedValue;
                return intValue == 0 ? (SiNoEnum?) null : (SiNoEnum) intValue;
            }
            set
            {
                if (value == null)
                    Combo.SelectedIndex = 0;
                else
                    Combo.SelectedValue = (int)value;
            }
        }

        public UcFiltroSiNo()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        private void ucFiltrSiNo_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            _limpiandoFiltros = true;

            var lista = new []
                            {
                                new {Id = 0, Nombre = "SELECCIONE.."},
                                new {Id = (int)SiNoEnum.Si, Nombre = "SI"},
                                new {Id = (int)SiNoEnum.No, Nombre = "NO"}
                            };

            DefinirCombo();

            Combo.DataSource = lista;
            
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
                OnSeleccionarItemFinished(Value);
        }

        private void OnSeleccionarItemFinished(SiNoEnum? id)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, id);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }
    }

    public enum SiNoEnum
    {
        Si = 1,
        No = 2
    }
}
