using System;
using System.Collections.Generic;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;

namespace LaPaz.Negocio
{
    public class TitulosMovimientoNegocio : NegocioBase , ITitulosMovimientoNegocio
    {
        public TitulosMovimientoNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

      
        public List<TitulosMovimientoDto> Listado(int id, int sucursal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = 1;
            criteros.PageSize = 2000;
            criteros.SortBy =  "FechaAlta";
            criteros.SortDirection =  "ASC";

            Expression<Func<TitulosMovimiento, bool>> where = x => 
                                                           (x.Id > id) && (x.SucursalAltaId==sucursal)
                                                           ;

            var resultados = Uow.TitulosMovimiento.Listado(criteros,
                                                where,
                                                x => x.Titulos,
                                                x=> x.Ventas);

            //pageTotal = resultados.PagedMetadata.TotalItemCount;
            return resultados.Entities.Project().To<TitulosMovimientoDto>().ToList();
        }
    }
}
