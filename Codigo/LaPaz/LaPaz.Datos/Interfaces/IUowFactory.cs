using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Datos.Interfaces
{
    public interface IUowFactory
    {
        T Create<T>();
    }
}
