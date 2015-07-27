using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Win.Infrastructure.Forms
{
    public interface IForm
    {
        bool HasUnsavedChanges { get; }
    }
}
