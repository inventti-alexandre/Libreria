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
    public class BancoNegocio : NegocioBase, IBancoNegocio
    {
        private IClock _clock;

        public BancoNegocio(ILaPazUow uow, IClock clock, IUowFactory uowFactory)
        {
            Uow = uow;
            _clock = clock;
            UowFactory = uowFactory;
        }

        public List<BancoDto> Listado(string sortBy, string sortDirection, string nombre, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Nombre";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "ASC";

            Expression<Func<Banco, bool>> where = x => (string.IsNullOrEmpty(nombre) || x.Nombre.Contains(nombre));

            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                var resultados = uow.Bancos.Listado(criteros,
                                                    where);

                pageTotal = resultados.PagedMetadata.TotalItemCount;

                return resultados.Entities.Project().To<BancoDto>().ToList();
            }
        }
    }
}
