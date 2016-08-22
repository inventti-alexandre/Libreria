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
using LaPaz.Win.Forms.Ventas;

namespace LaPaz.Win.Forms.Presupuesto
{
    public partial class UcTitulosPresupuesto : UserControlBase
    {
        private IList<PresupuestoDetalleDto> _titulos = new List<PresupuestoDetalleDto>();
        
        private readonly IMessageBoxDisplayService _messageBoxDisplayService = new MessageBoxDisplayService();

        public UcTitulosPresupuesto()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
            this.GrillaTitulos.CellFormatting += new Telerik.WinControls.UI.CellFormattingEventHandler(this.Grilla_CellFormatting);

        }

        public event EventHandler<IList<PresupuestoDetalleDto>> PresupuestoTitulosChanged;

        #region Propiedades
        
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IList<PresupuestoDetalleDto> Titulos
        {
            get { return _titulos; }
            set { _titulos = value; }
        }

        #endregion

        
        public decimal CalcularSubTotal()
        {
            return Titulos.Sum(t => t.SubTotal ?? 0);
        }

        public int CalcularCantidad()
        {
            return Titulos.Sum(t => t.Cantidad.Value);
        }

        public void RefrescarTitulos()
        {
            if (Titulos.Count == Context.SucursalActual.MaximoNroLineasPorVenta)
                _messageBoxDisplayService.ShowInfo("Con este título ha alcanzado el límite de libros para la factura.");

            lblCantidad.Text = string.Format("Cantidad de libros: {0}", CalcularCantidad());
            GrillaTitulos.DataSource = Titulos.ToList();

            GrillaTitulos.DataSource = Titulos;
        }

        //public void ActualizarDescuento(int? descuento)
        //{
        //    foreach (var consignacionTitulo in _titulos)
        //    {
        //        if (descuento == null)
        //            //return;
        //            descuento = 0;

        //        if (consignacionTitulo.SubTotal != null)
        //        {
        //            consignacionTitulo.Descuento = descuento;
        //            consignacionTitulo.PrecioVenta = consignacionTitulo.PrecioBase;

        //            var precioactulizado = (consignacionTitulo.PrecioBase - (consignacionTitulo.PrecioBase * consignacionTitulo.Descuento / 100));

        //            consignacionTitulo.SubTotal = precioactulizado * (consignacionTitulo.CntVendida);
        //            CalcularSubTotal();
        //            RefrescarTitulos();
        //        }
                
        //    }
        //}

        //public void ActualizarRecargo(int? recargo)
        //{
        //    foreach (var ventaTitulo in _titulos)
        //    {

        //        if (recargo == null)
        //            recargo = 0;
                
        //        ventaTitulo.Recargo = recargo;
                
        //        if (ventaTitulo.Descuento > 0)
        //            return;

        //        if (ventaTitulo.SubTotal != null)
        //        {
        //            ventaTitulo.PrecioVenta = ventaTitulo.PrecioBase;
        //            var precioActualizado = (ventaTitulo.PrecioBase + (ventaTitulo.PrecioBase*ventaTitulo.Recargo/100));
        //            //*ventaTitulo.Cantidad;
        //            ventaTitulo.SubTotal = precioActualizado*ventaTitulo.CntVendida;
        //            CalcularSubTotal();
        //            RefrescarTitulos();
        //        }
        //    }
        //}

        private void OnPresupuestoTitulosChanged(IList<PresupuestoDetalleDto> presupuestoTitulos)
        {
            if (PresupuestoTitulosChanged != null)
            {
                PresupuestoTitulosChanged(this, presupuestoTitulos);
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

            var presupuestoTitulo = selectedRow.DataBoundItem as PresupuestoDetalleDto;

            if (presupuestoTitulo == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Editar":
                    EditarTitulo(presupuestoTitulo);
                    break;
            }
        }

        private void EditarTitulo(PresupuestoDetalleDto presupuestoTitulo)
        {
            using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibro>(presupuestoTitulo.Id))
            {
                formAgregarTitulo.TituloAgregado += (o, titulo) =>
                {
                    if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                    {
                        var tituloModificado = Titulos.FirstOrDefault(x => x.Id == titulo.TituloId);
                        if (titulo != null)
                        {
                            tituloModificado.Cantidad = titulo.Cantidad;
                            tituloModificado.Precio = titulo.PrecioVenta;
                            tituloModificado.SubTotal = titulo.SubTotal;
                        }

                        OnPresupuestoTitulosChanged(Titulos);
                        RefrescarTitulos();
                    }
                    else
                    {
                        foreach (PresupuestoDetalleDto presupTitulo in Titulos)
                        {
                            if (presupTitulo.TituloId == titulo.TituloId)
                            {
                                presupTitulo.TituloId = titulo.TituloId;
                                presupTitulo.TituloNombreTitulo = titulo.TituloNombre;
                                presupTitulo.Cantidad = titulo.Cantidad;
                                presupTitulo.Precio = titulo.PrecioVenta;
                                presupTitulo.SubTotal = titulo.SubTotal;

                                OnPresupuestoTitulosChanged(Titulos);
                                RefrescarTitulos();
                            }
                        }
                    }

                    formAgregarTitulo.Close();
                };

                formAgregarTitulo.ShowDialog();
            }
        }

        //public void ActualizarInfo()
        //{
        //    foreach (PresupuestoDetalleDto presupuestoDetalleDto in Titulos)
        //    {
        //        presupuestoDetalleDto.Cantidad = remitosVentaDetalleDto.CntARendir ?? 0;
        //        remitosVentaDetalleDto.CntDevuelta = remitosVentaDetalleDto.CntADevolver ?? 0;
        //    }
        //}
    }
}
