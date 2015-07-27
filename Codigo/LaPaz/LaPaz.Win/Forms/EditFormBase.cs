using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Windows.Forms;
using Framework.Comun.Validation;

namespace LaPaz.Win.Forms
{
    public class EditFormBase : FormBase
    {
        public EditFormBase()
        {
            Errores = new Collection<ValidationResult>();
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
            var erroresControl = Errores.Where(r => r.MemberNames.Any(n => n == nombrePropiedad));
            if (erroresControl.Any())
            {
                foreach (var error in erroresControl)
                {
                    this.FormErrorProvider.SetError(control, error.ErrorMessage);
                }
            }
        }
    }
}
