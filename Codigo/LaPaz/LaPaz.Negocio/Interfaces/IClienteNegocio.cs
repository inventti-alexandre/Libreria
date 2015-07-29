using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Datos.Helpers;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;

namespace LaPaz.Negocio.Interfaces
{
    public interface IClienteNegocio : IDisposable
    {
        List<ClienteDto> Listado(string sortBy, string sortDirection, string denominacion, string cuit,bool? activo, int pageIndex, int pageSize, out int pageTotal);
        decimal DeudaTotal(Guid clienteId, int? sucursalId);
        decimal DeudaVencida(Guid clienteId, int? sucursalId);
        List<ClienteMontoFavor> Senias(string sortBy, string sortDirection, Guid? clienteId, int pageIndex, int pageSize,
                                       out int pageTotal);

        Cliente ObtenerPorId(Guid clienteId);
    }
}
