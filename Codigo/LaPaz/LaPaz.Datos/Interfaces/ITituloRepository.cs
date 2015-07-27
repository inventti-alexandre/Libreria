using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;

namespace LaPaz.Datos.Interfaces
{
    public interface ITituloRepository : IRepository<Titulo>
    {
        IQueryable<TituloDto> Listado(string sortBy, string sortDirection, int? codigoProveedor,
                                      string codigoLibroCompleto, string isbn, string codigoBarra, string titulonombre,
                                      Guid? proveedorid, int? temaid, string autorNombre, int? editorialId,
                                      bool? conStock, int? sucursalId, bool? ochoDeMarzo, bool activos, int pageIndex,
                                      int pageSize,
                                      out int pageTotal);
    }
}
