using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;

namespace LaPaz.Negocio.Interfaces
{
    public interface ITituloNegocio
    {
        List<TituloDto> Listado(string sortBy, string sortDirection, int? codigoProveedor, string codigoLibroCompleto, 
                                string isbn, string codigoBarra, string tituloNombre,
                                Guid? proveedorid, int? temaid, string autorNombre,int? editorialId, 
                                bool? conStock, int? sucursalId, bool? ochoDeMarzo,bool activos, int pageIndex, int pageSize, out int pageTotal);

        List<TituloDto> Listado(string sortBy, string sortDirection, int? codigoProveedor, string codigoLibroCompleto, int pageIndex, int pageSize, out int pageTotal);
        List<TituloDto> Listado(string sortBy, string sortDirection, int pageIndex, int pageSize, out int pageTotal);
        List<Cliente> ClientesConsignacion(Guid tituloId, int sucursalId);
        List<RemitosVentaDetalle> RemitosConsignacion(Guid tituloId, int sucursalId);
    }
}
