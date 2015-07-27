using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Utility;
using Framework.WinForm.Comun.Notification;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.LotesDeFacturas
{
    public partial class FrmLoteFacturaListado : FormBaseListado
    {
        private readonly IClock _clock;
        private readonly IMessageBoxDisplayService _messageBoxDisplayService;

     

        public FrmLoteFacturaListado(IClock clock,
                             IFormFactory formFactory,
                             IMessageBoxDisplayService messageBoxDisplayService,
                             ILaPazUow uow,
                          IFormRegistry formRegistry)
        {
            FormFactory = formFactory;
            Uow = uow;
            FormRegistry = formRegistry;

            _clock = clock;
            _messageBoxDisplayService = messageBoxDisplayService;


            InitializeComponent();
            InicializarPaginador();
            this.Text = "Lotes de Facturas";

            //Fix para centrar columnas.
            this.GrillaLotes.CellFormatting += this.Grilla_CellFormatting;
            MainGrid = GrillaLotes;
            MainPager = ProveedoresPager;
            Spinner = ucProgressSpinner;
        }

        private void InicializarPaginador()
        {
            ProveedoresPager.RefreshActionAsync = RefrescarListado;
        }

        private void FrmLoteFacturaListado_Load(object sender, EventArgs e)
        {
            RefrescarListado();
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner.Show();
            int pageTotal = 0;


            var lotes = await Task.Run(() => Uow.LotesFacturas.Listado().OrderByDescending(l=>l.NroLote).Where(l => l.OperadorLote == Context.OperadorActual.Id));
                
            GrillaLotes.DataSource = lotes.ToList();

            ProveedoresPager.UpdateState(pageTotal);
            ucProgressSpinner.Hide();
            return pageTotal;
        }

        private void GrillaLotes_CommandCellClick(object sender, EventArgs e)
        {
            var commandCell = (GridCommandCellElement)sender;

            var selectedRow = this.GrillaLotes.SelectedRows.FirstOrDefault();

            if (selectedRow == null)
                return;

            var lote = selectedRow.DataBoundItem as LoteFactura;

            if (lote == null)
                return;

            switch (commandCell.ColumnInfo.Name)
            {
                case "Editar":
                    if (lote.Estado==EstadoLoteEnum.Activo)
                        Editar(lote.NroLote);
                    else
                        _messageBoxDisplayService.ShowWarning("No puede editar un lote cerrado o inactivo");
                    break;
            }
        }

        private void Editar(int nroLote)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarLote>(nroLote, ActionFormMode.Edit))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                }
            }
        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            using (var formCrear = FormFactory.Create<FrmCrearEditarLote>(0, ActionFormMode.Create))
            {
                var result = formCrear.ShowDialog();
                if (result == DialogResult.OK)
                {
                    formCrear.Close();
                    RefrescarListado();
                } 
            }
        }
    }
}
