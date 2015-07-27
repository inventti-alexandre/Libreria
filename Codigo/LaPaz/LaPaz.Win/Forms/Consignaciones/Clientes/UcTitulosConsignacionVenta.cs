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
using Framework.WinForm.Comun.Notification;
using LaPaz.Win.Forms.Presupuesto;
using LaPaz.Win.Model;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Entidades.Dto;

namespace LaPaz.Win.Forms.Consignaciones.Clientes
{
    public partial class UcTitulosConsignacionVenta : UserControlBase
    {
        private IList<RemitosVentaDetalleDto> _titulos = new List<RemitosVentaDetalleDto>();
        
        private readonly IMessageBoxDisplayService _messageBoxDisplayService = new MessageBoxDisplayService();

        public UcTitulosConsignacionVenta()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
            this.GrillaTitulos.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grilla_CellFormatting);

        }

        public event EventHandler<IList<RemitosVentaDetalleDto>> RemitoTitulosChanged;

        #region Propiedades
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IList<RemitosVentaDetalleDto> Titulos
        {
            get { return _titulos; }
            set { _titulos = value; }
        }

        #endregion

        private void UcTitulosVenta_Load(object sender, EventArgs e)
        {
            
        }

        public decimal CalcularSubTotal()
        {
            return Titulos.Sum(t => t.SubTotal ?? 0);
        }

        public int CalcularCantidad()
        {
            return Titulos.Where(t => t.CntVendida.HasValue).Sum(t => t.CntVendida.Value);
        }

        public void RefrescarTitulos()
        {
            if (Titulos.Count == Context.SucursalActual.MaximoNroLineasPorVenta)
                _messageBoxDisplayService.ShowInfo("Con este título ha alcanzado el límite de libros para la factura.");

            lblCantidad.Text = string.Format("Cantidad de libros: {0}", CalcularCantidad());
            GrillaTitulos.DataSource = Titulos.ToList();

            GrillaTitulos.DataSource = Titulos;
        }

        public void ActualizarDescuento(int? descuento)
        {
            foreach (var consignacionTitulo in _titulos)
            {
                if (descuento == null)
                    //return;
                    descuento = 0;

                if (consignacionTitulo.SubTotal != null)
                {
                    consignacionTitulo.Descuento = descuento;
                    //consignacionTitulo.PrecioVenta = consignacionTitulo.PrecioVenta;
                    consignacionTitulo.PrecioVenta = consignacionTitulo.PrecioBase;

                    //var precioactulizado = (consignacionTitulo.PrecioVenta - (consignacionTitulo.PrecioVenta * consignacionTitulo.Descuento / 100));
                    var precioactulizado = (consignacionTitulo.PrecioBase - (consignacionTitulo.PrecioBase * consignacionTitulo.Descuento / 100));

                    consignacionTitulo.SubTotal = precioactulizado * consignacionTitulo.Cantidad;
                    CalcularSubTotal();
                    RefrescarTitulos();
                }
                
            }
        }

        public void ActualizarRecargo(int? recargo)
        {
            foreach (var ventaTitulo in _titulos)
            {

                if (recargo == null)
                    recargo = 0;
                // return;
                ventaTitulo.Recargo = recargo;
                if (ventaTitulo.Descuento > 0)
                    return;

                ventaTitulo.PrecioVenta = ventaTitulo.PrecioBase;
                var precioActualizado = (ventaTitulo.PrecioBase + (ventaTitulo.PrecioBase * ventaTitulo.Recargo / 100));
                //*ventaTitulo.Cantidad;
                ventaTitulo.SubTotal = precioActualizado * ventaTitulo.Cantidad;
                CalcularSubTotal();
                RefrescarTitulos();
            }
        }

        private void OnVentaTitulosChanged(IList<RemitosVentaDetalleDto> ventaTitulos)
        {
            if (RemitoTitulosChanged != null)
            {
                RemitoTitulosChanged(this, ventaTitulos);
            }
        }

        private void GrillaTitulos_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;
            var selectedRow = GrillaTitulos.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
            {
                return;
            }

            var ventaTitulo = selectedRow.DataBoundItem as RemitosVentaDetalleDto;

            if (ventaTitulo == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Editar":
                    EditarTitulo(ventaTitulo);
                    break;
            }
        }

        private void EditarTitulo(RemitosVentaDetalleDto remitoDetalleTitulo)
        {
            using (var formAgregarTitulo = FormFactory.Create<FrmModificarConsignacionVenta>(remitoDetalleTitulo.Id))
            {
                formAgregarTitulo.TituloModificado += (o, titulo) =>
                {
                    if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                    {
                        var tituloModificado = Titulos.FirstOrDefault(x => x.Id == titulo.Id);
                        if (titulo != null)
                        {
                            tituloModificado.CntVendida = titulo.CntVendida;
                            tituloModificado.CntDevuelta = titulo.CntDevuelta;
                            tituloModificado.PrecioVenta = titulo.PrecioVenta;
                            tituloModificado.SubTotal = titulo.SubTotal;
                        }

                        OnVentaTitulosChanged(Titulos);
                        RefrescarTitulos();
                    }
                    else
                    {
                        foreach (RemitosVentaDetalleDto remitoTitulo in Titulos)
                        {
                            if (remitoTitulo.TituloId == titulo.TituloId)
                            {
                                remitoTitulo.TituloId = titulo.TituloId;
                                remitoTitulo.TituloNombreTitulo = titulo.TituloNombreTitulo;
                                remitoTitulo.CntVendida = titulo.CntVendida;
                                remitoTitulo.CntDevuelta = titulo.CntDevuelta;
                                remitoTitulo.PrecioBase = titulo.PrecioBase;
                                remitoTitulo.PrecioVenta = titulo.PrecioVenta;
                                remitoTitulo.Descuento = titulo.Descuento;
                                remitoTitulo.SubTotal = titulo.SubTotal;

                                OnVentaTitulosChanged(Titulos);
                                RefrescarTitulos();
                            }
                        }
                    }

                    formAgregarTitulo.Close();
                };

                formAgregarTitulo.ShowDialog();
            }
        }
    }
}
