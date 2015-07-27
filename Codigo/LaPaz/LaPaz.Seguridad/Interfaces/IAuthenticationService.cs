using LaPaz.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Seguridad.Interfaces
{
    public interface IAuthenticationService : IDisposable
    {
        Operador AuthenticateUser(string username, string password);
    }
}
