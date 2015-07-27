using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Datos.Repositorio
{
    /// <summary>
    /// The EF-dependent, generic repository for data access
    /// </summary>
    /// <typeparam name="T">Type of entity for this Repository.</typeparam>
    public class EFRepository<T> : EFBaseRepository, IRepository<T> where T : class
    {
        public EFRepository()
            : base()
        {
            DbSet = DbContext.Set<T>();
        }

        public EFRepository(DbContext dbContext)
            : base(dbContext)
        {
            DbSet = DbContext.Set<T>();
        }

        protected DbSet<T> DbSet { get; set; }

        public virtual IQueryable<T> Listado()
        {
            return DbSet;
        }

        public IQueryable<T> Listado(params Expression<Func<T, object>>[] includes)
        {
            var dbset = DbSet.AsQueryable();
            foreach (var include in includes)
            {
                dbset = dbset.Include(include);
            }

            return dbset;
        }

        /// <summary>
        /// Gets all of T from the data store by pagging.
        /// </summary>
        /// <param name="paging">paging criteria to determine which page of T to return.</param>
        /// <param name="includes">a params expression array of property names to return in each item of the entity object graph.</param>
        /// <returns>RepositoryResultList of T.</returns>
        public PagedResultList<T> Listado(PagingCriteria paging, params Expression<Func<T, object>>[] includes)
        {
            PagedResultList<T> result = new PagedResultList<T>();

            var data = DbSet.Where(x => true);
            int totalRecords = data.Count();

            foreach (var include in includes)
            {
                data = data.Include(include);
            }

            result.Entities = data.AsQueryable()
                .OrderBy(paging.SortBy + " " + paging.SortDirection)
                .Skip((paging.PageNumber - 1) * paging.PageSize)
                .Take(paging.PageSize);

            result.PagedMetadata = new PagedMetadata(totalRecords, paging.PageSize, paging.PageNumber);
            return result;
        }

        /// <summary>
        /// Finds all of T from the data store with a pagging.
        /// </summary>
        /// <param name="paging">paging criteria to determine which page of T to return.</param>
        /// <param name="whereClause">where clause to filter entities.</param>
        /// <param name="includes">a params expression array of property names to return in each item of the entity object graph.</param>
        /// <returns>RepositoryResultList of T.</returns>
        public PagedResultList<T> Listado(PagingCriteria paging, Expression<Func<T, bool>> whereClause, params Expression<Func<T, object>>[] includes)
        {
            PagedResultList<T> result = new PagedResultList<T>();

            var data = DbSet.Where(x => true);
            int totalRecords = data.Count(whereClause);

            foreach (var include in includes)
            {
                data = data.Include(include);
            }

            result.Entities = data.AsQueryable()
                .Where(whereClause)
                .OrderBy(paging.SortBy + " " + paging.SortDirection)
                .Skip((paging.PageNumber - 1)*paging.PageSize)
                .Take(paging.PageSize);

            result.PagedMetadata = new PagedMetadata(totalRecords, paging.PageSize, paging.PageNumber);
            return result;
        }

        public virtual T Obtener(int id)
        {
            return DbSet.Find(id);
        }

        public virtual T Obtener(Expression<Func<T, bool>> whereClause, params Expression<Func<T, object>>[] includes)
        {
            var dbset = DbSet.AsQueryable();
            foreach (var include in includes)
            {
                dbset = dbset.Include(include);
            }
            return dbset.FirstOrDefault(whereClause);
        }

        public virtual void Agregar(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Detached)
            {
                dbEntityEntry.State = EntityState.Added;
            }
            else
            {
                DbSet.Add(entity);
            }
        }

        public virtual void Modificar(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
            {
                DbSet.Attach(entity);
            }
            dbEntityEntry.State = EntityState.Modified;
        }

        public virtual void Eliminar(T entity)
        {
            DbEntityEntry dbEntityEntry = DbContext.Entry(entity);
            if (dbEntityEntry.State != EntityState.Deleted)
            {
                dbEntityEntry.State = EntityState.Deleted;
            }
            else
            {
                DbSet.Attach(entity);
                DbSet.Remove(entity);
            }
        }

        public virtual void Eliminar(int id)
        {
            var entity = Obtener(id);
            if (entity == null) return; // not found; assume already deleted.
            Eliminar(entity);
        }

        public bool Commit()
        {
            try
            {
                DbContext.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}
