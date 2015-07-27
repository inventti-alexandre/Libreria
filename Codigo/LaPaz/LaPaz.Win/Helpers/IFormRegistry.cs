using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaPaz.Win.Helpers
{
    public interface IFormRegistry
    {
        IEnumerable<Form> GetForms(Type formType);
        void AddForm(Form form);
        void RemoveForm(Form form);
    }
}
