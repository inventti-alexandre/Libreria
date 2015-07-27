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
    public partial class UcConsignacionesPorEditorial : UserControlBase
    {
        private int _itemsCount { get; set; }

        public event EventHandler GridDatabound;
        
        public UcConsignacionesPorEditorial()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();
        }

        public UcConsignacionesPorEditorial(string editorial, List<ConsignacionSinRendir> titulos, decimal? descuento)
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();

            TxtEditorial.Text = editorial;
            TxtPorcentaje.Text = descuento.GetValueOrDefault().ToString("N2");

            foreach (var consignacionSinRendir in titulos)
            {
                consignacionSinRendir.Descuento = descuento;
            }

            GridTitulos.DataSource = titulos;
            _itemsCount = titulos.Count;

            foreach (GridViewDataColumn column in this.GridTitulos.Columns)
            {
                column.ReadOnly = column.Name != "CantidadARendir" && column.Name != "PrecioVentaTitulo";
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

            
            var summaryItem = new GridViewSummaryItem
                            {
                                Name = "TotalARendir", 
                                Aggregate = GridAggregateFunction.Sum,
                                FormatString = "{0:c}"
                                
                            };

            var summaryRowItem = new GridViewSummaryRowItem {summaryItem};

            this.GridTitulos.SummaryRowsBottom.Add(summaryRowItem);
        }

        private void GridTitulos_CellValidating(object sender, CellValidatingEventArgs eventArgs)
        {
            if (eventArgs.Column.Name == "CantidadARendir")
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
                            var item = eventArgs.Row.DataBoundItem as ConsignacionSinRendir;
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

            if (eventArgs.Column.Name == "PrecioVentaTitulo")
            {
                if (eventArgs.Value == null)
                {
                    eventArgs.Cancel = true;
                }
                else
                {
                    try
                    {
                        Decimal value;
                        var text = eventArgs.Value == null
                                       ? null
                                       : eventArgs.Value.ToString().Replace("$ ", "").Replace(".", "").Replace(",", ".");
                        if (!Decimal.TryParse(text, out value) || value <= 0)
                        {
                            eventArgs.Cancel = true;
                        }
                        else
                        {
                            _validating = true;
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

        private void TxtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            var titulos = GridTitulos.Rows.Select(r => r.DataBoundItem as ConsignacionSinRendir).ToList();
            foreach (var consignacionSinRendir in titulos)
            {
                var descuento = string.IsNullOrEmpty(TxtPorcentaje.Text)
                                    ? 0
                                    : Convert.ToDecimal(TxtPorcentaje.Text);
                consignacionSinRendir.Descuento = descuento;
            }
            GridTitulos.DataSource = titulos.ToList();
        }

        public IEnumerable<ConsignacionSinRendir> ObtenerListado()
        {
            return GridTitulos.Rows.Select(r => r.DataBoundItem as ConsignacionSinRendir).ToList();
        }

        private void GridTitulos_ViewCellFormatting(object sender, CellFormattingEventArgs e)
        {
            if (e.CellElement.RowInfo.Group == null && e.CellElement is GridSummaryCellElement)
            {
                e.CellElement.ForeColor = Color.Black;
                e.CellElement.TextAlignment = ContentAlignment.MiddleLeft;
                e.CellElement.Font = new Font(FontFamily.GenericSansSerif, 12, FontStyle.Bold);
            }
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
