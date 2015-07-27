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
    public interface ICuentaNegocio : IDisposable
    {
       List<CuentaDto> Listado(string sortBy, string sortDirection, string nombre, int? tipoCuentaId, int? bancoPropioId, string titular, int pageIndex, int pageSize, out int pageTotal);
    }
}
