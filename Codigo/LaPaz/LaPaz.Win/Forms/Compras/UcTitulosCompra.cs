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
using LaPaz.Negocio.Data;
using LaPaz.Win.Enums;
using LaPaz.Win.Model;
using Telerik.WinControls.UI;
using LaPaz.Win.Forms.Ventas;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcTitulosCompra : UserControlBase
    {
        private IList<CompraTitulo> _titulos = new List<CompraTitulo>();
        private IList<VentaTitulo> _titulosDevolucion = new List<VentaTitulo>();
        private Guid _proveedorId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService = new MessageBoxDisplayService();
        private Boolean _devolucion = false;

        public UcTitulosCompra()
        {

            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
        }

        public event EventHandler<IList<CompraTitulo>> CompraTitulosChanged;
        public event EventHandler<IList<VentaTitulo>> VentaTitulosChanged; 

        #region Propiedades

        public IList<CompraTitulo> Titulos
        {
            get { return _titulos; }
            set { _titulos = value; }
        }

        public IList<VentaTitulo> TitulosDevolucion
        {
            get { return _titulosDevolucion; }
            set { _titulosDevolucion = value; }
        }
        #endregion

        #region Metodos Publicos

        public decimal CalcularSubTotal()
        {
            if (Titulos != null)
            {
                return Titulos.Sum(t => t.SubTotal ?? 0);
            }
            else
            {
                return 0;
            }
            
        }

        public decimal CalcularSubTotalDevolucion()
        {
            if (TitulosDevolucion != null)
            {
                return TitulosDevolucion.Sum(t => t.SubTotal ?? 0);
            }
            else
            {
                return 0;
            }

        }

        public void ActualizarProveedorId(Guid proveedorId)
        {
            _proveedorId = proveedorId;
        }

        public void ActualizarOperacion(Boolean esDevolucion)
        {
            _devolucion = true;
        }

        public void LimpiarGrilla()
        {
            if (GrillaTitulos.RowCount > 0)
            {
                Titulos.Clear();
                RefrescarTitulos();
            }

        }

        public int CalcularCantidad()
        {
            if (!_devolucion)
                return Titulos.Sum(t => t.CantidadCompra ?? 0);
            else
            {
                GrillaTitulos.Columns[4].FieldName = "Cantidad";
                return TitulosDevolucion.Sum(t => t.Cantidad ?? 0);
            }
            
            
        }

        #endregion


        private void RefrescarTitulos()
        {
            lblCantidad.Text = string.Format("Cantidad de libros: {0}", CalcularCantidad());
            if (!_devolucion)
                GrillaTitulos.DataSource = Titulos.ToList();
            else
            {
                GrillaTitulos.DataSource = TitulosDevolucion.ToList();
            }
        }

        private void BtnAgregarTitulo_Click(object sender, EventArgs e)
        {
            if (_devolucion)
            {
                if (_proveedorId != Guid.Empty)
                {
                    using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibro>(_proveedorId, ActionFormMode.Edit))
                    {
                        formAgregarTitulo.TituloAgregado += (o, titulo) =>
                        {
                            if (!this.TitulosDevolucion.Any(t => t.TituloId == titulo.TituloId))
                            {
                                TitulosDevolucion.Add(titulo);
                                OnDevolucionTitulosChanged(TitulosDevolucion);
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
                
            }
            else
            {
                if (_proveedorId != Guid.Empty)
                {
                    using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibroCompra>(_proveedorId,ActionFormMode.Create))
                    {
                        formAgregarTitulo.TituloAgregado += (o, titulo) =>
                        {
                            if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                            {
                                Titulos.Add(titulo);
                                OnCompraTitulosChanged(Titulos);
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
            }
            
        }

        private void OnDevolucionTitulosChanged(IList<VentaTitulo> devolucionTitulos)
        {
            if (VentaTitulosChanged != null)
            {
                VentaTitulosChanged(this, devolucionTitulos);
            }
        }

        private void OnCompraTitulosChanged(IList<CompraTitulo> ventaTitulos)
        {
            if (CompraTitulosChanged != null)
            {
                CompraTitulosChanged(this, ventaTitulos);
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

            //if (_titulos.Count > 0)
            //    _messageBoxDisplayService.ShowInfo("Compra");
            //else if (_titulosDevolucion.Count > 0)
            //    _messageBoxDisplayService.ShowInfo("Devolucion");

            var compraTitulo = selectedRow.DataBoundItem as CompraTitulo;
            var compraTituloDevolucion = selectedRow.DataBoundItem as VentaTitulo;

            if (compraTitulo == null && compraTituloDevolucion == null)
                return;
            if (compraTitulo != null)
            {
                switch (commandCell.ColumnInfo.Name)
                {
                    case "Editar":
                        EditarTitulo(compraTitulo);
                        break;
                    case "Eliminar":
                        EliminarTitulo(compraTitulo);
                        break;
                }
            }
            else if (compraTituloDevolucion != null)
            {
                switch (commandCell.ColumnInfo.Name)
                {
                    case "Editar":
                        EditarTituloDevolucion(compraTituloDevolucion);
                        break;
                    case "Eliminar":
                        EliminarTituloDevolucion(compraTituloDevolucion);
                        break;
                }
            }

            

        }

        private void EditarTituloDevolucion(VentaTitulo compraTituloDevolucion)
        {
            using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibro>(compraTituloDevolucion.TituloId, ActionFormMode.Edit))
            {
                formAgregarTitulo.Cantidad = compraTituloDevolucion.Cantidad;
                formAgregarTitulo.TituloAgregado += (o, titulo) =>
                {
                    if (!this.TitulosDevolucion.Any(t => t.TituloId == titulo.TituloId))
                    {
                        TitulosDevolucion.Add(titulo);
                        OnCompraTitulosChanged(Titulos);
                        RefrescarTitulos();
                    }
                    else
                    {
                        foreach (VentaTitulo devolucionTitulo in TitulosDevolucion)
                        {
                            if (devolucionTitulo.TituloId == titulo.TituloId)
                            {
                                devolucionTitulo.TituloId = titulo.TituloId;
                                devolucionTitulo.TituloNombre = titulo.TituloNombre;
                                devolucionTitulo.Cantidad = titulo.Cantidad;
                                devolucionTitulo.PrecioBase = titulo.PrecioBase;
                                devolucionTitulo.PrecioVenta = titulo.PrecioVenta;
                                devolucionTitulo.SubTotal = titulo.SubTotal;
                                OnCompraTitulosChanged(Titulos);
                                RefrescarTitulos();
                            }
                        }
                    }

                    formAgregarTitulo.Close();
                };

                formAgregarTitulo.ShowDialog();
            }
        }

        private void EliminarTituloDevolucion(VentaTitulo compraTituloDevolucion)
        {
            TitulosDevolucion.Remove(compraTituloDevolucion);
            RefrescarTitulos();
            OnCompraTitulosChanged(Titulos);
        }

        private void EditarTitulo(CompraTitulo compraTitulo)
        {
            using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibroCompra>(compraTitulo.TituloId, ActionFormMode.Edit))
            {
                formAgregarTitulo.Cantidad = compraTitulo.CantidadCompra;
                formAgregarTitulo.TituloAgregado += (o, titulo) =>
                {
                    if (!this.Titulos.Any(t => t.TituloId == titulo.TituloId))
                    {
                        Titulos.Add(titulo);
                        OnCompraTitulosChanged(Titulos);
                        RefrescarTitulos();
                    }
                    else
                    {
                        foreach (CompraTitulo compraTitulo1 in Titulos)
                        {
                            if (compraTitulo1.TituloId == titulo.TituloId)
                            {
                                compraTitulo1.TituloId = titulo.TituloId;
                                compraTitulo1.TituloNombre = titulo.TituloNombre;
                                compraTitulo1.CantidadCompra = titulo.CantidadCompra;
                                compraTitulo1.PrecioBase = titulo.PrecioBase;
                                compraTitulo1.PrecioVenta = titulo.PrecioVenta;
                                compraTitulo1.SubTotal = titulo.SubTotal;
                                OnCompraTitulosChanged(Titulos);
                                RefrescarTitulos();
                            }
                        }
                    }

                    formAgregarTitulo.Close();
                };

                formAgregarTitulo.ShowDialog();
            }
        }

        private void EliminarTitulo(CompraTitulo compraTitulo)
        {
            Titulos.Remove(compraTitulo);
            RefrescarTitulos();
            OnCompraTitulosChanged(Titulos);
        }

        private void UcTitulosCompra_Load(object sender, EventArgs e)
        {
            
        }
    }
}
