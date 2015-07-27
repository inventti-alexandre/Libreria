using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Datos.Repositorio
{
    public class TituloRepository : EFRepository<Titulo>, ITituloRepository
    {
        public TituloRepository()
        {
        }

        public TituloRepository(DbContext dbContext)
            : base(dbContext)
        {
        }

        public IQueryable<TituloDto> Listado(string sortBy, string sortDirection, int? codigoProveedor, string codigoLibroCompleto,
                            string isbn, string codigoBarra, string titulonombre, Guid? proveedorid, int? temaid, string autorNombre,
                            int? editorialId, bool? conStock, int? sucursalId, bool? ochoDeMarzo, bool activos, int pageIndex, int pageSize, out int pageTotal)
        {
            var sortExpression = SortHelper.SortExpression(sortBy, sortDirection);

            var titulos = LaPazEntities.TitulosListado(sortExpression, codigoProveedor, codigoLibroCompleto, isbn, codigoBarra,
                                                             titulonombre, proveedorid, temaid, autorNombre, editorialId, conStock,
                                                             sucursalId, ochoDeMarzo, activos, pageIndex, pageSize).ToList();

            pageTotal = titulos.Any() ? titulos.First().TotalResults.GetValueOrDefault() : 0;

            return titulos.AsQueryable();
        }
    }
}