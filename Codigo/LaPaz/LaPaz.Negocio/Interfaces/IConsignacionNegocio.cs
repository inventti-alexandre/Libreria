using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;

namespace LaPaz.Negocio.Interfaces
{
    public interface IConsignacionNegocio : IDisposable
    {
        List<ConsignacionSinRendir> VentasSinRendir(Guid? proveedorId, DateTime desde, DateTime hasta);
        List<ConsignacionesParaDevolver> ConsignacionesParaDevolver(Guid? proveedorId, DateTime desde, DateTime hasta);
    }
}
