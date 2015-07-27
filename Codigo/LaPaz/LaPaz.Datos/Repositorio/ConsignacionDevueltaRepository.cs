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
    public class ConsignacionDevueltaRepository : EFRepository<TitulosConsignacionesDevuelta>, IConsignacionDevueltaRepository
    {
        public ConsignacionDevueltaRepository()
        {
        }

        public ConsignacionDevueltaRepository(DbContext dbContext)
            : base(dbContext)
        {
        }
        
        public List<ConsignacionesParaDevolver> ConsignacionesParaDevolver(Guid? proveedorId, DateTime desde, DateTime hasta)
        {
            return LaPazEntities.ConsignacionesParaDevolver(proveedorId, desde, hasta).ToList();
        }
    }
}