using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using Framework.Comun.Utility;

namespace LaPaz.Negocio
{
    public class PaseLibroNegocio : NegocioBase, IPaseLibroNegocio
    {
        private IClock _clock;

        public PaseLibroNegocio(ILaPazUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public List<Compra> Listado(string sortBy, string sortDirection, Guid proveedor)
        {
            var criteros = new PagingCriteria();

            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaAlta";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            Expression<Func<Compra, bool>> where = x => (x.ProveedorId == proveedor);

            var resultados = Uow.Compras.Listado(criteros,
                                                    where);

            return resultados.Entities.Project().To<Compra>().ToList();
        }
    }
}
