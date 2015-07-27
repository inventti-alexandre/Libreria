using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Framework.Ioc;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using System.Linq;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms.Util
{
    public partial class UcFiltroAutor : UserControlBase
    {
        private bool _cargandoAutores;

        public event EventHandler<Autor> SeleccionarFinished;

        private Autor _autor;
        public Autor Autor
        {
            get { return _autor; }
        }

        public int? AutorId
        {
            get
            {
                var autorId = Combo.SelectedValue as int?;
                return autorId == 0 ? null : autorId;
            }
            set
            {
                if (value.GetValueOrDefault() != 0 && !Combo.Items.Any(i => i.Value == (object)value))
                {
                    var autor = Uow.Autores.Obtener(value.GetValueOrDefault());
                    var autores = new List<Autor>{
                    new Autor() { Nombre = "SELECCIONE AUTOR" },
                        autor
                    };
                    Combo.DataSource = autores;
                }
                Combo.SelectedValue = value ?? 0;
            }
        }

        public UcFiltroAutor()
        {
            if (Ioc.Container != null)
            {
                Uow = Ioc.Container.Get<ILaPazUow>();
            }

            InitializeComponent();

            DefinirCombo();
        }

        public void CargarAutor()
        {
            if (Ioc.Container == null)
                return;

            _cargandoAutores = true;

            DefinirCombo();

            var autores = Uow.Autores.Listado().ToList();
            autores.Insert(0, new Autor() { Nombre = "SELECCIONE AUTOR", Id = 0 });
            Combo.DataSource = autores;

            _cargandoAutores = false;
        }

        private void DefinirCombo()
        {
            Combo.DisplayMember = "Nombre";
            Combo.ValueMember = "Id";
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            if (!_cargandoAutores)
                SeleccionarAutor();
        }

        private void SeleccionarAutor()
        {
            var autor = Uow.Autores.Obtener(a => a.Id == AutorId);
            _autor = autor;
            OnSeleccionarAutorFinished(autor);
        }

        private void OnSeleccionarAutorFinished(Autor autor)
        {
            if (SeleccionarFinished != null)
            {
                SeleccionarFinished(this, autor);
            }
        }

        public void Reset()
        {
            Combo.SelectedValue = 0;
        }

        private void Combo_KeyUp(object sender, KeyEventArgs e)
        {
            //Datasource only changes when user hits a letter
            //OrElse e.KeyCode = Keys.Return Then
            if ((e.KeyCode >= Keys.A && e.KeyCode <= Keys.Z))
            {
                //and we have atleast 3 characters
                if (Combo.Text.Length > 2)
                {
                    //suspend any further keyboard input, untill we're done
                    Combo.KeyDown += SuspendKeyboard;
                    string txt = Combo.Text;
                    //update de dropdown datasource based on the user input (from Open Access model)
                    var autores = Uow.Autores.Listado().Where(a => a.Nombre.StartsWith(txt)).OrderBy(a => a.Nombre).Take(100).ToList();
                    Combo.DataSource = autores;
                    //This should be done when initializing the form
                    //ddlPatient.DisplayMember = "InfoZoekPatient"
                    //ddlPatient.ValueMember = "PatientID"
                    //restore the user input and place the cursor at the and of the text
                    Combo.Text = txt;
                    Combo.SelectionStart = txt.Length;
                    //restore keyboard input
                    Combo.KeyDown -= SuspendKeyboard;
                }
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void SuspendKeyboard(object sender, KeyEventArgs e)
        {
            e.Handled = true;
            e.SuppressKeyPress = true;
        }

        private void Combo_Leave(object sender, EventArgs e)
        {
            var ddl = sender as RadDropDownList;
            bool clear = true;
            //check if the selected item valuemember equals the ddl text.
            if (ddl.SelectedItem != null)
            {
                var autor = ddl.SelectedItem.DataBoundItem as Autor;
                if (autor != null)
                {
                    if (ddl.Text.Trim() == autor.Nombre.Trim())
                        clear = false;
                }
            }

            if (clear)
            {
                ddl.SelectedIndex = -1;
                ddl.Text = string.Empty;
                ddl.SelectedItem = null;
                ddl.Update();
            }
        }

        private void UcFiltroAutor_Load(object sender, EventArgs e)
        {
            Combo.SelectedIndex = 0;
        }
    }
}
