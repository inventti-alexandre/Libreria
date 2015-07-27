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
using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Consignaciones
{
    public partial class UcConsignacionesDevolucionPorEditorial : UserControlBase
    {
        private int _itemsCount { get; set; }

        public event EventHandler GridDatabound;
        
        public UcConsignacionesDevolucionPorEditorial()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        public UcConsignacionesDevolucionPorEditorial(string editorial, List<ConsignacionesParaDevolver> titulos)
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();

            TxtEditorial.Text = editorial;
            
            GridTitulos.DataSource = titulos;
            _itemsCount = titulos.Count;

            foreach (GridViewDataColumn column in this.GridTitulos.Columns)
            {
                column.ReadOnly = column.Name != "CantidadADevolver";
            }
        }

        private void UcConsignacionesPorEditorial_Load(object sender, EventArgs e)
        {
            this.Width = this.Parent.Width - 40;
            var incremento = 150;
            if (_itemsCount < 3)
                incremento = 100;
            else if (incremento < 6)
                incremento = 127;

            this.Height = 60 + incremento;

            splitContainer1.SplitterDistance = 45;
        }

        private void GridTitulos_CellValidating(object sender, CellValidatingEventArgs eventArgs)
        {
            if (eventArgs.Column.Name == "CantidadADevolver")
            {
                if (eventArgs.Value == null)
                {
                    eventArgs.Cancel = true;
                }
                else
                {
                    try
                    {
                        int intValue;
                        var valor = eventArgs.Value == "" ? 0 : eventArgs.Value;
                        if (!Int32.TryParse(valor.ToString(), out intValue))
                        {
                            eventArgs.Cancel = true;
                        }
                        else
                        {
                            //Todo: validar que la cantidad a rendir no supere la cantidad en consignación
                            var item = eventArgs.Row.DataBoundItem as ConsignacionesParaDevolver;
                            if ((item != null && intValue > item.CantidadSinRendir) || intValue < 0)
                            {
                                eventArgs.Cancel = true;
                            }
                            else
                            {
                                _validating = true;
                            }
                        }
                    }
                    catch
                    {
                        // Error occured so validation error!
                        eventArgs.Cancel = true;
                    }
                }
            }
        }


        public IEnumerable<ConsignacionesParaDevolver> ObtenerListado()
        {
            return GridTitulos.Rows.Select(r => r.DataBoundItem as ConsignacionesParaDevolver).ToList();
        }

        private void GridTitulos_DataBindingComplete(object sender, GridViewBindingCompleteEventArgs e)
        {
            if (GridDatabound != null)
            {
                GridDatabound(this, e);
            }
        }

        private bool _validating = false;
        private void GridTitulos_CellValidated(object sender, CellValidatedEventArgs e)
        {
            if (_validating)
            {
                _validating = false;
                if (GridDatabound != null)
                {
                    GridDatabound(this, e);
                }
            }
        }

    }
}
