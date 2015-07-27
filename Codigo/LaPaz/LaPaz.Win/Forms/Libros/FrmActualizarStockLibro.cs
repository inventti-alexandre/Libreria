using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Autenticacion;
using LaPaz.Win.Forms.Proveedores;
using LaPaz.Win.Forms.SubTemas;
using LaPaz.Win.Forms.Temas;
using LaPaz.Win.Properties;
using Telerik.WinControls.UI;
using LaPaz.Seguridad;

namespace LaPaz.Win.Forms.Libros
{
    public partial class FrmActualizarStockLibro : EditFormBase
    {
        private readonly Guid _tituloId;

        private readonly IRepository<TituloStockMigracion> _tituloStockMigracionRepo;
        private readonly IClock _clock;

        public FrmActualizarStockLibro(ILaPazUow uow,IFormFactory formFactory, IRepository<TituloStockMigracion> tituloStockMigracionRepo, IClock clock, Guid id)
        {
            Uow = uow;
            FormFactory = formFactory;

            _tituloId = id;
            _tituloStockMigracionRepo = tituloStockMigracionRepo;
            _clock = clock;

            InitializeComponent();
        }

        #region Propiedades

        public int? StockPropio
        {
            get
            {
                int stock;
                return int.TryParse(TxtStockPropio.Text, out stock) ? stock : (int?)null;
            }
            set
            {
                TxtStockPropio.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? StockConsignado
        {
            get
            {
                int stock;
                return int.TryParse(TxtStockConsignado.Text, out stock) ? stock : (int?)null;
            }
            set
            {
                TxtStockConsignado.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? StockPropioMigracion
        {
            get
            {
                int stock;
                return int.TryParse(TxtStockPropioMigracion.Text, out stock) ? stock : (int?)null;
            }
            set
            {
                TxtStockPropioMigracion.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        public int? StockConsignadoMigracion
        {
            get
            {
                int stock;
                return int.TryParse(TxtStockConsignadoMigracion.Text, out stock) ? stock : (int?)null;
            }
            set
            {
                TxtStockConsignadoMigracion.Text = value.HasValue ? value.Value.ToString() : string.Empty;
            }
        }

        #endregion

        #region Metodos

        private void FrmActualizarStockLibro_Load(object sender, EventArgs e)
        {
            CargarStocksTitulo(_tituloId);
        }

        private void CargarStocksTitulo(Guid tituloId)
        {
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == tituloId && t.SucursalId == this.Context.SucursalActual.Id);
            if (tituloStock != null)
            {
                StockPropio = tituloStock.StkPr;
                StockConsignado = tituloStock.StkCn;
            }

            var tituloStockMigracion = _tituloStockMigracionRepo.Obtener(t => t.TituloId == tituloId && t.SucursalId == this.Context.SucursalActual.Id);
            if (tituloStockMigracion != null)
            {
                StockPropioMigracion = tituloStockMigracion.StkPr;
                StockConsignadoMigracion = tituloStockMigracion.StkCn;
            }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            var operadorAdmin = this.ObtenerOperadorAdministrador();

            if (operadorAdmin == null) return;

            ToggleHabilitarControlesEditar(true);
        }

        private void ToggleHabilitarControlesEditar(bool editar)
        {
            this.TxtStockPropio.Enabled = editar;
            this.TxtStockConsignado.Enabled = editar;
            this.TxtStockPropioMigracion.Enabled = editar;
            this.TxtStockConsignadoMigracion.Enabled = editar;

            this.BtnGuardar.Enabled = editar;
            this.BtnEditar.Enabled = !editar;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ActualizarStock();
        }

        private void ActualizarStock()
        {
            var tituloStock = Uow.TitulosStock.Obtener(t => t.TituloId == _tituloId && t.SucursalId == this.Context.SucursalActual.Id);
            if (tituloStock != null)
            {
                tituloStock.OperadorModificacionId = this.Context.OperadorActual.Id;
                tituloStock.SucursalModificacionId = this.Context.SucursalActual.Id;

                tituloStock.StkPr = StockPropio;
                tituloStock.StkCn = StockConsignado;

                Uow.TitulosStock.Modificar(tituloStock);
            }
            else
            {
                tituloStock = new TituloStock();

                tituloStock.TituloId = _tituloId;
                tituloStock.OperadorAltaId = this.Context.OperadorActual.Id;
                tituloStock.SucursalAltaId = this.Context.SucursalActual.Id;
                tituloStock.SucursalId = this.Context.SucursalActual.Id;
                tituloStock.FechaAlta = _clock.Now;

                tituloStock.StkPr = StockPropio;
                tituloStock.StkCn = StockConsignado;

                Uow.TitulosStock.Agregar(tituloStock);
            }

            Uow.Commit();

            var tituloStockMigracion = _tituloStockMigracionRepo.Obtener(t => t.TituloId == _tituloId && t.SucursalId == this.Context.SucursalActual.Id);
            if (tituloStockMigracion != null)
            {
                tituloStockMigracion.OperadorModificacionId = this.Context.OperadorActual.Id;
                tituloStockMigracion.SucursalModificacionId = this.Context.SucursalActual.Id;

                tituloStockMigracion.StkPr = StockPropioMigracion;
                tituloStockMigracion.StkCn = StockConsignadoMigracion;

                _tituloStockMigracionRepo.Modificar(tituloStockMigracion);
            }
            else
            {
                tituloStockMigracion = new TituloStockMigracion();

                tituloStockMigracion.TituloId = _tituloId;
                tituloStockMigracion.OperadorAltaId = this.Context.OperadorActual.Id;
                tituloStockMigracion.SucursalAltaId = this.Context.SucursalActual.Id;
                tituloStockMigracion.SucursalId = this.Context.SucursalActual.Id;
                tituloStockMigracion.FechaAlta = _clock.Now;

                tituloStockMigracion.StkPr = StockPropioMigracion;
                tituloStockMigracion.StkCn = StockConsignadoMigracion;

                _tituloStockMigracionRepo.Agregar(tituloStockMigracion);
            }

            _tituloStockMigracionRepo.Commit();
        }

        #endregion
    }
}
