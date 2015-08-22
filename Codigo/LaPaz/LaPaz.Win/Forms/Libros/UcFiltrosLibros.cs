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
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Libros
{
    public partial class UcFiltrosLibros : UserControlBase
    {
        public UcProgressSpinner Spinner
        {
            get { return ucProgressSpinner1; }
        }

        public bool FiltrosVacios
        {
            get
            {
                return CodigoProveedor == null &&
                       string.IsNullOrEmpty(CodigoLibroCompleto) &&
                       string.IsNullOrEmpty(ISBN) &&
                       string.IsNullOrEmpty(NombreTitulo) && ProveedorId == null &&
                       TemaId == null &&
                       string.IsNullOrEmpty(AutorNombre) &&
                       ConStock == null &&
                       string.IsNullOrEmpty(CodigoBarra) &&
                       OchoDeMarzo == null &&
                       EditorialId == null;
            }
        }

        public void SetearNullCbxStocks()
        {
            _limpiandoFiltros = true;

            CbxOchoDeMarzo.Value = null;
            UcConStock.Value = null;

            _limpiandoFiltros = false;
        }

        public void SetearProveedorDevolucion(Guid proveedor)
        {
            ProveedorId = proveedor;
            CbxProveedor.SelectedValue = proveedor;
            CbxProveedor.Enabled = false;
            CbxOchoDeMarzo.Enabled = false;
            UcConStock.Enabled = false; 
        }

        private bool _limpiandoFiltros;

        public UcFiltrosLibros()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }
            InitializeComponent();

            this.UcConStock.SeleccionarFinished += UcConStockOnSeleccionarFinished;
            this.UcFiltroEditorial.SeleccionarFinished += UcFiltroEditorialOnSeleccionarFinished;
            this.CbxOchoDeMarzo.SeleccionarFinished += UcOchoDeMarzoOnSeleccionarFinished;
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public int? CodigoProveedor
        {
            get
            {
                if (string.IsNullOrEmpty(TxtCodigo1.Text))
                    return null;
                return Convert.ToInt32(TxtCodigo1.Text);
            }
            set { TxtCodigo1.Text = value.ToString(); }
        }

        public string CodigoLibroCompleto
        {
            get
            {
                if (string.IsNullOrEmpty(TxtCodigo1.Text) || string.IsNullOrEmpty(TxtCodigo2.Text))
                    return null;
                return String.Format("{0}{1}", CompleteWithZeros(TxtCodigo1.Text, 4), CompleteWithZeros(TxtCodigo2.Text, 13));
            }
            set
            {
                TxtCodigo2.Text = value;
                TxtCodigo1.Text = value;
            }
        }

        public string ISBN
        {
            get { return TxtIsbn.Text; }
            set { TxtIsbn.Text = value; }
        }

        public string CodigoBarra
        {
            get { return TxtCodigoBarra.Text; }
            set { TxtCodigoBarra.Text = value; }
        }

        public string NombreTitulo
        {
            get { return TxtTitulo.Text; }
            set { TxtTitulo.Text = value; }
        }

        public Guid? ProveedorId
        {
            get { return (Guid?)(CbxProveedor.SelectedIndex != 0 ? CbxProveedor.SelectedValue : null); }
            set { CbxProveedor.SelectedValue = value ?? Guid.Empty; }
        }

        public string ProveedorTexto
        {
            get { return (CbxProveedor.SelectedIndex != 0 ? CbxProveedor.SelectedText : null); }
        }

        public int? TemaId
        {
            get { return (int?)(CbxTema.SelectedIndex != 0 ? CbxTema.SelectedValue : null); }
            set { CbxTema.SelectedValue = value ?? 0; }
        }

        public string TemaTexto
        {
            get { return (CbxTema.SelectedIndex != 0 ? CbxTema.SelectedText : null); }

        }

        public int? EditorialId
        {
            get { return UcFiltroEditorial.EditorialId; }
            set { UcFiltroEditorial.EditorialId = value; }
        }

        public string EditorialTexto
        {
            get { return UcFiltroEditorial.Editorial.Nombre; }
        }

        public string AutorNombre
        {
            get { return TxtAutor.Text; }
            set { TxtAutor.Text = value; }
        }

        public bool? ConStock
        {
            get { return UcConStock.Value != null ? UcConStock.Value == SiNoEnum.Si : (bool?)null; }
            set { UcConStock.Value = value != null ? (value == true ? SiNoEnum.Si : SiNoEnum.No) : (SiNoEnum?)null; }
        }

        public bool? OchoDeMarzo
        {
            get { return CbxOchoDeMarzo.Value != null ? CbxOchoDeMarzo.Value == SiNoEnum.Si : (bool?)null; }
            set { CbxOchoDeMarzo.Value = value != null ? (value == true ? SiNoEnum.Si : SiNoEnum.No) : (SiNoEnum?)null; }
        }

        public bool Activos
        {
            get { return !CkbEliminados.Checked; }
            set { CkbEliminados.Checked = !value; }
        }

        private string _btnBuscarTexto;
        public string BtnBuscarTexto
        {
            get { return _btnBuscarTexto ?? "Buscar"; }
            set { _btnBuscarTexto = value; }
        }

        #endregion

        #region Metodos

        private async void UcFiltrosLibros_Load(object sender, EventArgs e)
        {
            if (Uow == null) return;

            await CargarCombos();

            TxtCodigo1.GotFocus += TxtCodigo1OnGotFocus;
            TxtCodigo2.GotFocus += TxtCodigo2OnGotFocus;
            
            CbxOchoDeMarzo.Value = SiNoEnum.Si;
            UcConStock.Value = SiNoEnum.Si;
            BtnBuscar.Text = BtnBuscarTexto;
        }

        private void TxtCodigo1OnGotFocus(object sender, EventArgs eventArgs)
        {
            TxtCodigo1.SelectAll();
        }

        private void TxtCodigo2OnGotFocus(object sender, EventArgs eventArgs)
        {
            TxtCodigo2.SelectAll();
        }

        private async Task CargarCombos()
        {
            _limpiandoFiltros = true;

            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == false).OrderBy(p => p.Denominacion).ToList();
            proveedores.Insert(0, new Proveedor() { Denominacion = "SELECCIONE PROVEEDOR", Cuenta = 0 });

            CbxProveedor.DisplayMember = "Denominacion";
            CbxProveedor.ValueMember = "Id";
            CbxProveedor.DataSource = proveedores;

            var tema = Uow.Temas.Listado().OrderBy(t => t.Nombre).ToList();
            tema.Insert(0, new Tema() { Nombre = "SELECCIONE TEMA" });
            CbxTema.DataSource = tema;
            CbxTema.DisplayMember = "Nombre";
            CbxTema.ValueMember = "Id";

            _limpiandoFiltros = false;
        }


        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            //if (!_limpiandoFiltros)
            //    OnFiltered();
        }

        private void TxtTitulo_TextChanged(object sender, EventArgs e)
        {
            //if (!_limpiandoFiltros)
            //    OnFiltered();
        }

        private void TxtIsbn_TextChanged(object sender, EventArgs e)
        {
            //if (!_limpiandoFiltros)
            //    OnFiltered();
        }

        private void CbxTema_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void CbxProveedor_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CbxAutor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void UcConStockOnSeleccionarFinished(object sender, SiNoEnum? siNoEnum)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void UcOchoDeMarzoOnSeleccionarFinished(object sender, SiNoEnum? siNoEnum)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void UcFiltroEditorialOnSeleccionarFinished(object sender, Entidades.Editorial editorial)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            _limpiandoFiltros = true;

            TxtIsbn.Text = string.Empty;
            TxtTitulo.Text = string.Empty;
            CbxProveedor.SelectedIndex = 0;
            TxtAutor.Text = string.Empty;
            CbxTema.SelectedIndex = 0;
            TxtCodigo1.Text = string.Empty;
            TxtCodigo2.Text = string.Empty;
            TxtCodigoBarra.Text = string.Empty;
           // UcConStock.Value = null;
            UcFiltroEditorial.EditorialId = null;

            _limpiandoFiltros = false;
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            OnFiltered();
        }

        private void TxtCodigo1_Leave(object sender, EventArgs e)
        {
            CompleteWithZeros(TxtCodigo1, 4);
        }

        private void TxtCodigo2_Leave(object sender, EventArgs e)
        {
            CompleteWithZeros(TxtCodigo2, 13);
        }

        private void CompleteWithZeros(RadTextBox textbox, int length)
        {
            var text = CompleteWithZeros(textbox.Text, length);
            textbox.Text = text;
        }

        private string CompleteWithZeros(string text, int length)
        {
            if (!string.IsNullOrEmpty(text))
            {
                var complete = length - text.Length;
                if (complete > 0)
                {
                    for (int i = 0; i < complete; i++)
                    {
                        text = text.Insert(0, "0");
                    }
                }
            }
            return text;
        }

        private void TxtCodigo1_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtCodigo2_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtTitulo_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtIsbn_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtCodigoBarra_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void TxtAutor_KeyUp(object sender, KeyEventArgs e)
        {
            OnEnterPressed(e);
        }

        private void OnEnterPressed(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (!_limpiandoFiltros)
                    OnFiltered();
            }
        }

        private void ckbEliminados_ToggleStateChanged(object sender, StateChangedEventArgs args)
        {
            if (!_limpiandoFiltros)
                OnFiltered();
        }

        #endregion
    }
}
