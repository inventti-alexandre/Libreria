using System;
using System.Data.Entity;
using LaPaz.Entidades;

namespace LaPaz.Datos.Repositorio
{
    /// <summary>
    /// The EF-dependent, base repository for data access
    /// </summary>
    public class EFBaseRepository
    {
        public EFBaseRepository()
        {
            CreateDbContext();
        }

        public EFBaseRepository(DbContext dbContext)
        {
            if (dbContext == null) 
                throw new ArgumentNullException("dbContext");
            DbContext = dbContext;
            LaPazEntities = dbContext as LaPazEntities;
            if (LaPazEntities !=null)
                LaPazEntities.Database.CommandTimeout = 1000;
        }

        protected void CreateDbContext()
        {
            DbContext = new LaPazEntities();
            DbContext.Configuration.ProxyCreationEnabled = false;
            DbContext.Configuration.LazyLoadingEnabled = false;
            DbContext.Configuration.ValidateOnSaveEnabled = false;
            
            LaPazEntities = DbContext as LaPazEntities;
            if (LaPazEntities != null)
                LaPazEntities.Database.CommandTimeout = 1000;
        }
        
        protected DbContext DbContext { get; set; }

        public LaPazEntities LaPazEntities { get; set; }
    }
}
