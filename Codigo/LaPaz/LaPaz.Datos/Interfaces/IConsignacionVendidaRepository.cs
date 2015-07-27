using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;

namespace LaPaz.Datos.Interfaces
{
    public interface IConsignacionVendidaRepository : IRepository<TitulosConsignacionesVendida>
    {
        List<ConsignacionSinRendir> VentasSinRendir(Guid? proveedorId, DateTime desde, DateTime hasta);
    }
}
