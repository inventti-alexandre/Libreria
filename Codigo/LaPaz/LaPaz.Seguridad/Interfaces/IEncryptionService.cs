using LaPaz.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Seguridad.Interfaces
{
    public interface IEncryptionService
    {
        string CalculateHash(string clearTextPassword, string salt);
    }
}
