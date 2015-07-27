using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System.Linq;
using LaPaz.Entidades;
using AutoMapper;

namespace LaPaz.Negocio
{
    public class CuentaNegocio : NegocioBase, ICuentaNegocio
    {
        public CuentaNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<CuentaDto> Listado(string sortBy, string sortDirection, string nombre, int? tipoCuentaId, int? bancoPropioId, string titular, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();
            
            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "FechaApertura";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Cuenta, bool>> where = x => (string.IsNullOrEmpty(nombre) || x.Nombre.Contains(nombre)) &&
                                                        (string.IsNullOrEmpty(titular) || x.Titular.Contains(titular)) &&
                                                        (!tipoCuentaId.HasValue || x.TipoCuentaId == tipoCuentaId) &&
                                                        (!bancoPropioId.HasValue || x.BancoPropioId == bancoPropioId) &&
                                                        (x.Activo);
           
            var resultados = Uow.Cuentas.Listado(criteros,
                                                     where,
                                                     c => c.BancosPropio,
                                                     c=> c.TiposCuenta);
            

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<CuentaDto>().ToList();   
        }
    }
}
