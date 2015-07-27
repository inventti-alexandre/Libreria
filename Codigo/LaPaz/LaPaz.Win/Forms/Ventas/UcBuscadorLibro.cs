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

namespace LaPaz.Win.Forms.Ventas
{
    public partial class UcBuscadorLibro : UserControlBase
    {
        public UcBuscadorLibro()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();
        }

        #region Eventos
        public EventHandler Filtered;
        #endregion

        #region Propiedades

        public string Codigo
        {
            get { return TxtCodigo.Text; }
            set { TxtCodigo.Text = value; }
        }

        public string ISBN
        {
            get { return TxtIsbn.Text; }
            set { TxtIsbn.Text = value; }
        }

        public string NombreTitulo
        {
            get { return TxtTitulo.Text; }
            set { TxtTitulo.Text = value; }
        }

        public Guid? ProveedorId
        {
            get { return (Guid)(CbxProveedor.SelectedIndex != 0 ? CbxProveedor.SelectedValue : Guid.NewGuid()); }
            set { CbxProveedor.SelectedValue = value ?? Guid.NewGuid(); }
        }

        public int? TemaId
        {
            get { return (int?)(CbxTema.SelectedIndex != 0 ? CbxTema.SelectedValue : null); }
            set { CbxTema.SelectedValue = value ?? 0; }
        }

        public int? AutorId
        {
            get { return (int?)(CbxAutor.SelectedIndex != 0 ? CbxAutor.SelectedValue : null); }
            set { CbxAutor.SelectedValue = value ?? 0; }
        }


        #endregion

        #region Metodos

        private void UcBuscadorLibro_Load_1(object sender, EventArgs e)
        {
            CargarCombos();
        }

        private void CargarCombos()
        {
            var proveedores = Uow.Proveedores.Listado().Where(p => p.Gto == false).OrderBy(p => p.Denominacion).ToList();
            proveedores.Insert(0, new Proveedor() { Denominacion = "SELECCIONE PROVEEDOR", Cuenta = 0 });

            CbxProveedor.DisplayMember = "Denominacion";
            CbxProveedor.ValueMember = "Id";
            CbxProveedor.DataSource = proveedores;

            var autor = Uow.Autores.Listado().OrderBy(e => e.Nombre).Take(5).ToList();
            autor.Insert(0, new Autor() { Nombre = "SELECCIONE AUTOR" });
            CbxAutor.DataSource = autor;
            CbxAutor.DisplayMember = "Nombre";
            CbxAutor.ValueMember = "Id";

            var tema = Uow.Temas.Listado().OrderBy(t => t.Nombre).ToList();
            tema.Insert(0, new Tema() { Nombre = "SELECCIONE TEMA" });
            CbxTema.DataSource = tema;
            CbxTema.DisplayMember = "Nombre";
            CbxTema.ValueMember = "Id";
        }

        private void TxtCodigo_TextChanged_1(object sender, EventArgs e)
        {
            OnFiltered();
        }

        private void CbxAutor_SelectedValueChanged_1(object sender, EventArgs e)
        {
            OnFiltered();
        }
       
      private void OnFiltered()
        {
            if (Filtered != null)
            {
                Filtered(this, new EventArgs());
            }
        }


      private void BtnBuscar_Click_1(object sender, EventArgs e)
      {
          OnFiltered();
      }

      private void metroButton1_Click_1(object sender, EventArgs e)
      {
          TxtCodigo.Text = string.Empty;
          TxtIsbn.Text = string.Empty;
          TxtTitulo.Text = string.Empty;
          CbxProveedor.SelectedIndex = 0;
          CbxAutor.SelectedIndex = 0;
          CbxTema.SelectedIndex = 0;

          OnFiltered();
      }

    #endregion

     

     

   }
}
