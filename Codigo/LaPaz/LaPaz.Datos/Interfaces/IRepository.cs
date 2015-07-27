using System;
using System.Linq;
using System.Linq.Expressions;
using LaPaz.Datos.Helpers;
using LaPaz.Entidades;

namespace LaPaz.Datos.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> Listado();
        IQueryable<T> Listado(params Expression<Func<T, object>>[] includes);
        PagedResultList<T> Listado(PagingCriteria paging, params Expression<Func<T, object>>[] includes);
        PagedResultList<T> Listado(PagingCriteria paging, Expression<Func<T, bool>> whereClause,
                                   params Expression<Func<T, object>>[] includes);
        T Obtener(int id);
        T Obtener(Expression<Func<T, bool>> whereClause, params Expression<Func<T, object>>[] includes);
        void Agregar(T entity);
        void Modificar(T entity);
        void Eliminar(T entity);
        void Eliminar(int id);
        bool Commit();
    }
}
