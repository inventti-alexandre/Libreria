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
    public partial class UcFiltroStock : UserControlBase
    {
        private bool _limpiandoFiltros;

        public event EventHandler<StockFilter?> SeleccionarFinished;

        public StockFilter? Value
        {
            get
            {
                if (Combo.SelectedValue == null)
                    return null;
                var intValue = (int)Combo.SelectedValue;
                return intValue == 0 ? (StockFilter?)null : (StockFilter)intValue;
            }
            set
            {
                if (value == null)
                    Combo.SelectedIndex = 0;
                else
                    Combo.SelectedValue = (int)value;
            }
        }

        public string ValueText
        {
            get { return Combo.Text; }
        }

        public bool? Consignado
        {
            get
            {
                return Value.HasValue 
                    ? (Value.Value == StockFilter.Ambos || Value.Value == StockFilter.Consignado) 
                    : (bool?) null;
            }
        }

        public bool? Propio
        {
            get
            {
                return Value.HasValue
                    ? (Value.Value == StockFilter.Ambos || Value.Value == StockFilter.Propio)
                    : (bool?)null;
            }
        }

        public UcFiltroStock()
        {
            InitializeComponent();
        }

        private void ucFiltroStock_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        public void Cargar()
        {
            _limpiandoFiltros = true;

            var opciones = new []
                            {
                                new {Id = 0, Nombre = "SELECCIONE.."},
                                new {Id = (int)StockFilter.Ambos, Nombre = "AMBOS"},
                                new {Id = (int)StockFilter.Consignado, Nombre = "CONSIGNADO"},
                                new {Id = (int)StockFilter.Propio, Nombre = "PRÓPIO"}
                            };

            DefinirCombo();

            Combo.DataSource = opciones;
            
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

        private void OnSeleccionarItemFinished(StockFilter? id)
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

    public enum StockFilter
    {
        Ambos = 1,
        Consignado = 2,
        Propio = 3,
    }
}
