using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework.Comun.Validation;
using Framework.WinForm.Controls;
using LaPaz.Win.Forms.Util;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Forms
{
    public class EditFormListadoBase : FormBase
    {
        public string SortColumn { get; set; }
        public string SortDirection { get; set; }
        public RadGridView MainGrid { get; set; }
        public MetroPager MainPager { get; set; }
        public Dictionary<string, string> SortColumnMappings { get; set; }
        public UcProgressSpinner Spinner { get; set; }

        public EditFormListadoBase()
        {
            Errores = new Collection<ValidationResult>();
        }

        private void MainGridOnDataBindingComplete(object sender, GridViewBindingCompleteEventArgs gridViewBindingCompleteEventArgs)
        {
            Spinner.Hide();
        }

        private void MainGridOnSortChanged(object sender, GridViewCollectionChangedEventArgs gridViewCollectionChangedEventArgs)
        {
            var sort = gridViewCollectionChangedEventArgs.GridViewTemplate.Sort;
            var split = sort.Split(' ');
            SortColumn = FinalSortColumn(split[0]);
            SortDirection = split[1];
            MainPager.CurrentPage = 0;
            RefrescarListado();
        }

        public virtual async Task<int> RefrescarListado()
        {
            return 0;
        }

        private string FinalSortColumn(string column)
        {
            if (SortColumnMappings == null || !SortColumnMappings.ContainsKey(column))
                return column;
            return SortColumnMappings[column];
        }

        protected virtual object ObtenerEntidad()
        {
            return new object();
        }

        protected virtual void ValidarControles()
        {
        }

        protected ICollection<ValidationResult> Errores { get; set; }

        protected virtual bool ValidarForm()
        {
            //Validate
            this.FormErrorProvider.Clear();
            ICollection<ValidationResult> errores = new Collection<ValidationResult>();
            var esValido = DataAnnotationsValidator.TryValidate(ObtenerEntidad(), out errores);
            Errores = errores;

            //Mostrar errores de validacion en controles
            ValidarControles();

            return esValido;
        }

        protected void ValidarControl(Control control, string nombrePropiedad)
        {
            var erroresControl = Errores.Where(r => r.MemberNames.First() == nombrePropiedad);
            if (erroresControl.Any())
            {
                foreach (var error in erroresControl)
                {
                    this.FormErrorProvider.SetError(control, error.ErrorMessage);
                }
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // EditFormListadoBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "EditFormListadoBase";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Load += new System.EventHandler(this.EditFormListadoBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        public void EditFormListadoBase_Load(object sender, EventArgs e)
        {
            MainGrid.SortChanged += MainGridOnSortChanged;
            MainGrid.DataBindingComplete += MainGridOnDataBindingComplete;
        }
    }
}
