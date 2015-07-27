using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace LaPaz.Win.Helpers
{
    public class FormRegistry : IFormRegistry
    {
        IDictionary<Type, IList<Form>> _forms = new Dictionary<Type, IList<Form>>();
        private bool _isPageRemovedEventAttached;

        public IEnumerable<Form> GetForms(Type formType)
        {
            return GetFormsInternal(formType);
        }

        public void AddForm(Form form)
        {
            if (_forms.ContainsKey(form.GetType()))
            {
                var formValues = _forms[form.GetType()];
                if (!formValues.Any(x => x == form))
                {
                    formValues.Add(form);
                }
            }
            else
            {
                _forms.Add(form.GetType(), new List<Form>() { form });
            }

            if (!_isPageRemovedEventAttached)
            {
                var pageTab = form.Parent as RadPageViewPage;
                if (pageTab != null)
                {
                    pageTab.Owner.PageRemoved += OwnerOnPageRemoved;
                }
                _isPageRemovedEventAttached = true;
            }
        }

        private void OwnerOnPageRemoved(object sender, RadPageViewEventArgs radPageViewEventArgs)
        {
            var form = radPageViewEventArgs.Page.Controls.OfType<Form>().FirstOrDefault();
            
            //Cerrar el form cuando se cierra el tab.
            if (form != null && Application.OpenForms.OfType<Form>().Any(x => x == form) && !form.IsDisposed)
            {
                form.Close();    
            }

            RemoveForm(form);
        }

        public void RemoveForm(Form form)
        {
            var formList = GetFormsInternal(form.GetType());
            var formToRemove = formList.FirstOrDefault(x => x == form);
            if (formToRemove != null)
            {
                formList.Remove(form);
            }
        }

        private IList<Form> GetFormsInternal(Type form)
        {
            KeyValuePair<Type, IList<Form>> forms = _forms.FirstOrDefault(x => x.Key == form);
            return forms.Key != null ? forms.Value : new List<Form>();
        }
    }
}
