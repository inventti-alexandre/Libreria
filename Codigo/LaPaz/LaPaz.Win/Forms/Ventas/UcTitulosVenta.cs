using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using Framework.Ioc;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Data;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Presupuesto;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Ventas
{
    public partial class UcTitulosVenta : UserControlBase
    {
        private IList<VentaTitulo> _titulos = new List<VentaTitulo>();

        private readonly IMessageBoxDisplayService _messageBoxDisplayService = new MessageBoxDisplayService();

        public UcTitulosVenta()
        {
            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
            this.GrillaTitulos.CellFormatting += new CellFormattingEventHandler(this.Grilla_CellFormatting);
        }

        public event EventHandler<IList<VentaTitulo>> VentaTitulosChanged;

        #region Propiedades

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public IList<VentaTitulo> Titulos
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
            return Titulos.Sum(t => t.Cantidad ?? 0);
        }

        public void RefrescarTitulos()
        {
            if (BtnAgregarTitulo.Visible == true)
            {
                if (Titulos.Count == Context.SucursalActual.MaximoNroLineasPorVenta)
                {
                    BtnAgregarTitulo.Enabled = false;
                    _messageBoxDisplayService.ShowInfo("Con este título ha alcanzado el límite de libros para la factura.");
                }
                else
                    BtnAgregarTitulo.Enabled = true;
            }

            lblCantidad.Text = string.Format("Cantidad de libros: {0}", CalcularCantidad());

            //Si es presupuestos ordenamos alfabeticamente
            if (btnAgregarPresupuesto.Visible)
            {
                GrillaTitulos.DataSource = Titulos.OrderBy(t => t.TituloNombre).ToList();
            }
            else
            {
                GrillaTitulos.DataSource = Titulos.ToList();
            }
        }

        public void ActualizarDescuento(int? descuento)
        {
            foreach (var ventaTitulo in _titulos)
            {
                if (descuento == null)
                    //return;
                    descuento = 0;
                ventaTitulo.Descuento = descuento;
                ventaTitulo.PrecioVenta = ventaTitulo.PrecioBase;
                var precioactulizado = (ventaTitulo.PrecioBase - (ventaTitulo.PrecioBase * ventaTitulo.Descuento / 100));
                //*ventaTitulo.Cantidad;
                ventaTitulo.SubTotal = precioactulizado * ventaTitulo.Cantidad;
                CalcularSubTotal();
                RefrescarTitulos();
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

        public void BtnAgregarTitulo_Click(object sender, EventArgs e)
        {
            using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibro>(Guid.Empty, ActionFormMode.Create))
            {
                formAgregarTitulo.TituloAgregado += (o, titulo) =>
                {
                    if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                    {
                        Titulos.Add(titulo);
                        OnVentaTitulosChanged(Titulos);
                        RefrescarTitulos();
                    }
                    else
                    {
                        _messageBoxDisplayService.ShowInfo("Ya agregó el libro " + titulo.TituloNombre.ToString());
                    }

                    formAgregarTitulo.Close();
                };

                formAgregarTitulo.ShowDialog();
            }
        }

        private void OnVentaTitulosChanged(IList<VentaTitulo> ventaTitulos)
        {
            if (VentaTitulosChanged != null)
            {
                VentaTitulosChanged(this, ventaTitulos);
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

            var ventaTitulo = selectedRow.DataBoundItem as VentaTitulo;

            if (ventaTitulo == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Editar":
                    EditarTitulo(ventaTitulo);
                    break;
                case "Eliminar":
                    EliminarTitulo(ventaTitulo);
                    break;
            }


        }

        private void EditarTitulo(VentaTitulo ventaTitulo)
        {
            if (BtnAgregarTitulo.Visible)
            {
                using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibro>(ventaTitulo.TituloId))
                {
                    formAgregarTitulo.TituloAgregado += (o, titulo) =>
                    {
                        if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                        {
                            Titulos.Add(titulo);
                            OnVentaTitulosChanged(Titulos);
                            RefrescarTitulos();
                        }
                        else
                        {
                            foreach (VentaTitulo ventaTitulo1 in Titulos)
                            {
                                if (ventaTitulo1.TituloId == titulo.TituloId)
                                {
                                    ventaTitulo1.TituloId = titulo.TituloId;
                                    ventaTitulo1.TituloNombre = titulo.TituloNombre;
                                    ventaTitulo1.ProveedorId = titulo.ProveedorId;
                                    ventaTitulo1.Cantidad = titulo.Cantidad;
                                    ventaTitulo1.CantidadConsignada = titulo.CantidadConsignada;
                                    ventaTitulo1.CantidadPropia = titulo.CantidadPropia;
                                    ventaTitulo1.PrecioBase = titulo.PrecioBase;
                                    ventaTitulo1.PrecioVenta = titulo.PrecioVenta;
                                    ventaTitulo1.Descuento = titulo.Descuento;
                                    ventaTitulo1.SubTotal = titulo.SubTotal;


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
            else //presupuesto
            {
                using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibroPresupuesto>(ventaTitulo.TituloId))
                {
                    formAgregarTitulo.TituloAgregado += (o, titulo) =>
                    {
                        if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                        {
                            Titulos.Add(titulo);
                            OnVentaTitulosChanged(Titulos);
                            RefrescarTitulos();
                        }
                        else
                        {
                            foreach (VentaTitulo ventaTitulo1 in Titulos)
                            {
                                if (ventaTitulo1.TituloId == titulo.TituloId)
                                {
                                    ventaTitulo1.TituloId = titulo.TituloId;
                                    ventaTitulo1.TituloNombre = titulo.TituloNombre;
                                    ventaTitulo1.ProveedorId = titulo.ProveedorId;
                                    ventaTitulo1.Cantidad = titulo.Cantidad;
                                    ventaTitulo1.CantidadConsignada = titulo.CantidadConsignada;
                                    ventaTitulo1.CantidadPropia = titulo.CantidadPropia;
                                    ventaTitulo1.PrecioBase = titulo.PrecioBase;
                                    ventaTitulo1.PrecioVenta = titulo.PrecioVenta;
                                    ventaTitulo1.Descuento = titulo.Descuento;
                                    ventaTitulo1.SubTotal = titulo.SubTotal;


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

        private void EliminarTitulo(VentaTitulo ventaTitulo)
        {
            Titulos.Remove(ventaTitulo);
            RefrescarTitulos();
            OnVentaTitulosChanged(Titulos);
        }

        private void UcTitulosVenta_Load(object sender, EventArgs e)
        {
            this.GrillaTitulos.Columns["SubTotal"].FormatString = "{0:N2}";
            this.GrillaTitulos.Columns["PrecioVenta"].FormatString = "{0:N2}";
        }

        private void btnAgregarPresupuesto_Click(object sender, EventArgs e)
        {
            using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibroPresupuesto>(Guid.Empty))
            {
                formAgregarTitulo.TituloAgregado += (o, titulo) =>
                {
                    if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                    {
                        Titulos.Add(titulo);
                        OnVentaTitulosChanged(Titulos);
                        RefrescarTitulos();
                    }
                    else
                    {
                        _messageBoxDisplayService.ShowInfo("Ya agregó el libro " + titulo.TituloNombre.ToString());
                    }
                    formAgregarTitulo.Close();
                };

                formAgregarTitulo.ShowDialog();
            }
        }

        public void HabilitarPresupuesto()
        {
            BtnAgregarTitulo.Visible = false;
            btnAgregarPresupuesto.Visible = true;
            btnAgregarPresupuesto.Left = BtnAgregarTitulo.Left;
            btnAgregarPresupuesto.Top = btnAgregarPresupuesto.Top;
        }
    }
}
