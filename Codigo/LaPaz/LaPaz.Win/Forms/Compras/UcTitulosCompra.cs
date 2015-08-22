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
        private IList<VentaTitulo> _titulosVenta = new List<VentaTitulo>();
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

        public IList<CompraTitulo> Titulos;
        //{
        //    get { return _titulos; }
        //    set { _titulos = value; }
        //}
        public IList<VentaTitulo> TitulosVenta
        {
            get { return _titulosVenta; }
            set { _titulosVenta = value; }
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
                return TitulosVenta.Sum(t => t.Cantidad ?? 0);
            
        }

        #endregion


        private void RefrescarTitulos()
        {
            lblCantidad.Text = string.Format("Cantidad de libros: {0}", CalcularCantidad());
            if (!_devolucion)
                GrillaTitulos.DataSource = Titulos.ToList();
            else
            {
                GrillaTitulos.DataSource = TitulosVenta.ToList();
            }
        }

        private void BtnAgregarTitulo_Click(object sender, EventArgs e)
        {
            if (_devolucion)
            {
                using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibro>(Guid.Empty))
                {
                    formAgregarTitulo.TituloAgregado += (o, titulo) =>
                    {
                        if (!this.TitulosVenta.Any(t => t.TituloId == titulo.TituloId))
                        {
                            TitulosVenta.Add(titulo);
                            OnDevolucionTitulosChanged(TitulosVenta);
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
            else
            {
                if (_proveedorId != Guid.Empty)
                {
                    using (var formAgregarTitulo = FormFactory.Create<FrmSeleccionarLibroCompra>(_proveedorId,
                            ActionFormMode.Create))
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

            var compraTitulo = selectedRow.DataBoundItem as CompraTitulo;

            if (compraTitulo == null)
                return;
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
    }
}
