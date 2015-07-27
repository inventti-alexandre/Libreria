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
using LaPaz.Win.Enums;
using LaPaz.Win.Model;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Compras
{
    public partial class UcTitulosCompra : UserControlBase
    {
        private IList<CompraTitulo> _titulos = new List<CompraTitulo>();
        private Guid _proveedorId;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService = new MessageBoxDisplayService();

        public UcTitulosCompra()
        {

            if (Ioc.Container != null)
            {
                FormFactory = Ioc.Container.Get<IFormFactory>();
            }

            InitializeComponent();
        }

        public event EventHandler<IList<CompraTitulo>> CompraTitulosChanged;

        #region Propiedades

        public IList<CompraTitulo> Titulos
        {
            get { return _titulos; }
            set { _titulos = value; }
        }



        #endregion

        #region Metodos Publicos

        public decimal CalcularSubTotal()
        {
            return Titulos.Sum(t => t.SubTotal ?? 0);
        }

        public void ActualizarProveedorId(Guid proveedorId)
        {
            _proveedorId = proveedorId;
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
            return Titulos.Sum(t => t.CantidadCompra ?? 0);
        }

        #endregion


        private void RefrescarTitulos()
        {
            lblCantidad.Text = string.Format("Cantidad de libros: {0}", CalcularCantidad());
            GrillaTitulos.DataSource = Titulos.ToList();
        }

        private void BtnAgregarTitulo_Click(object sender, EventArgs e)
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
