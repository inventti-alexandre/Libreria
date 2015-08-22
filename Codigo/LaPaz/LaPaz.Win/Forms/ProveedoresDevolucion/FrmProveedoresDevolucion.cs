using System.Data.Entity;
using Framework.Comun.Utility;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Win.Enums;
using Telerik.WinControls.UI;
using LaPaz.Win.Model;
using LaPaz.Entidades;
using System.Linq;
using System.Drawing;
using LaPaz.Entidades.Dto;
using Framework.WinForm.Comun.Notification;
using LaPaz.Negocio.Data;
using LaPaz.Win.Properties;

namespace LaPaz.Win.Forms.FrmProveedoresDevolucion
{
    public partial class FrmProveedoresDevolucion : LaPaz.Win.Forms.FormBaseListado
    {


        #region Initialize Components

        private readonly IProveedorNegocio _proveedorNegocio;
        private readonly IClock _clock;
        private readonly MessageBoxDisplayService _messageBoxDisplayService;
        private Guid _pagoIdCtaCte;
        private Guid _pagoIdConsignacion;
        private int _celdasSeleccionadas = 0;
        private Proveedor _proveedor;


        public event EventHandler ProveedoresCuentaCorriente;

        public FrmProveedoresDevolucion(IFormFactory formFactory, ILaPazUow uow, IProveedorNegocio proveedorNegocio, IClock clock, MessageBoxDisplayService messageBoxDisplayService)
        {
            FormFactory = formFactory;

            Uow = uow;
            _clock = clock;
            SortColumn = "FechaAlta";
            SortDirection = "DESC";

            _proveedorNegocio = proveedorNegocio;
            _messageBoxDisplayService = messageBoxDisplayService;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            //this.GridCtaCte.CellFormatting += this.Grilla_CellFormatting;

            //MainGrid = GridCtaCte;
            MainPager = ProveedoreCtaCtePager;
            Spinner = ucProgressSpinner1;
        }

        private void FrmProveedoresDevolucion_Load(object sender, EventArgs e)
        {
            this.ucFiltroProveedor1.SeleccionarFinished+=UcFiltroProveedor1_SeleccionarFinished;


        }

        private void UcFiltroProveedor1_SeleccionarFinished(object sender, Proveedor proveedor)
        {
            ActualizarProveedor(proveedor);
        }

        private void ActualizarProveedor(Proveedor proveedor)
        {
            if (proveedor != null)
            {
                _proveedor = proveedor;
                ucTitulosDevolucion.ActualizarProveedorId(_proveedor.Id);
                ucTitulosDevolucion.ActualizarOperacion(true);
            }
        }

       

        private void InicializarPaginador()
        {
            ProveedoreCtaCtePager.RefreshActionAsync = RefrescarListado;
        }

        #endregion

        #region Properties

        #endregion

        #region Methods

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var codigoProveedor = ucFiltroProveedor1.ProveedorId;

            var page = ProveedoreCtaCtePager.CurrentPage;
            var pageSize = ProveedoreCtaCtePager.PageSize;

            var proveedoresCtaCte =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorCtaCte(SortColumn, SortDirection, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, ProveedoreCtaCtePager.CurrentPage, ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            var proveedoresConsignacion =
                await
                    Task.Run(
                        () =>
                            _proveedorNegocio.ProveedorConsignacion(SortColumn, SortDirection, null, null,
                                ucFiltroProveedor1.Proveedor.Denominacion, ucFiltroProveedor1.Proveedor.Cuit
                                , true, null, null, true, ProveedoreCtaCtePager.CurrentPage,
                                ProveedoreCtaCtePager.PageSize,
                                out pageTotal));

            //GridCtaCte.DataSource = proveedoresCtaCte;

            //GridConsignaciones.DataSource = proveedoresConsignacion;



            ProveedoreCtaCtePager.UpdateState(pageTotal);
           

            return pageTotal;
        }

       

        private void Filtered(object sender, Entidades.Proveedor e)
        {
            RefrescarListado();
            
            ActualizarMontos();
        }

      



       

        private void ActualizarMontos()
        {
           //ucTotalesCompraSeña1.GenerarPagoAuto(ucTotalesCompraSeña1.TotalPagar);
        }

        public decimal SeñaAFavorProveedor(Guid? proveedorId)
        {
            var proveedoresMontosFavor = Uow.ProveedoresSenias.Listado()
                                       .Where(ps => ps.ProveedorId == proveedorId
                                                   && ps.ImporteUsado < ps.Importe)
                                       .ToList();
            return proveedoresMontosFavor.Sum(ps => ps.Importe.GetValueOrDefault() - ps.ImporteUsado.GetValueOrDefault());
        }

        #endregion

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            _pagoIdConsignacion = Guid.NewGuid();
            _pagoIdCtaCte = Guid.NewGuid();
            //if (RpvPagos.SelectedPage.Name == "CuentaCorriente")
            //{
            //    GuardarCuotas();
            //}
            //else
            //{
            //    GuardarConsignacion();
            //}
            //OnCuentaRealizada();

        }

        

    

      


    }
}
