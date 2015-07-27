using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Migracion;
using LaPaz.Entidades;

namespace LaPaz.Datos.Interfaces
{
    public interface IMigracionLaPazUow : IDisposable
    {
        IRepository<TituloStockMigracion> TitulosStockMigracion { get; }

        void Commit();
    }
}
