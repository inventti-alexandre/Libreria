using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using LaPaz.Win.Enums;
using LaPaz.Win.Forms.Ventas;
using LaPaz.Win.Helpers;
using Telerik.WinControls.UI;
using LaPaz.Entidades;

namespace LaPaz.Win.Forms.SubTemas
{
    public partial class FrmSubTemasListado : FormBaseListado
    {
        private readonly ISubTemaNegocio _subTemaNegocio;

        public FrmSubTemasListado(IFormFactory formFactory, ILaPazUow uow, ISubTemaNegocio subTemaNegocio)
        {
            FormFactory = formFactory;

            Uow = uow;

            SortColumn = "Tema.Nombre";
            SortDirection = "ASC";

            SortColumnMappings = new Dictionary<string, string>();
            SortColumnMappings["TemaNombre"] = "Tema.Nombre";

            _subTemaNegocio = subTemaNegocio;

            InitializeComponent();

            InicializarPaginador();

            //Fix para centrar columnas.
            this.GridSubTemas.CellFormatting += this.Grilla_CellFormatting;
            
            MainGrid = GridSubTemas;
            MainPager = SubTemasPager;
            Spinner = ucProgressSpinner1;
        }

        private void InicializarPaginador()
        {
            SubTemasPager.RefreshActionAsync = RefrescarListado;
        }

        public override async Task<int> RefrescarListado()
        {
            ucProgressSpinner1.Show();

            int pageTotal = 0;

            var nombre = ucFiltrosSubTemas.Nombre;
            var temaId = ucFiltrosSubTemas.TemaId;
            var subTemas = await Task.Run(() => _subTemaNegocio.Listado(SortColumn, SortDirection,
                                                                temaId,
                                                                nombre,
                                                                SubTemasPager.CurrentPage, SubTemasPager.PageSize,
                                                                out pageTotal));

            GridSubTemas.DataSource = subTemas;
            SubTemasPager.UpdateState(pageTotal);
            return pageTotal;
        }
        
        private void Filtered(object sender, EventArgs eventArgs)
        {
            RefrescarListado();
        }

        private void FrmSubTemasListado_Load(object sender, EventArgs e)
        {
            base.FormBaseListado_Load(sender, e);
            GridSubTemas.AutoGenerateColumns = false;
            RefrescarListado();
            this.ucFiltrosSubTemas.Filtered += Filtered;
        }
        
    }
}
