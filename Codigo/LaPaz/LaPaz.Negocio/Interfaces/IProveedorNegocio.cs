using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Data;
using LaPaz.Negocio.Response;

namespace LaPaz.Negocio.Interfaces
{
    public interface IProveedorNegocio : IDisposable
    {
        List<ProveedorDto> Listado(string sortBy, string sortDirection, int? cuenta, string denominacion, string cuit,
            int? provinciaId, int? localidadId, TipoProveedor tipoProveedor, bool? activo, int pageIndex, int pageSize,
            out int pageTotal);

        List<ProveedorSenia> Senias(string sortBy, string sortDirection, Guid? proveedorId, int sucursalId, int pageIndex, int pageSize,
                                    out int pageTotal);

        List<ProveedorCtaCteDto> ProveedorCtaCte(string sortBy1, string sortDirection, int? cuenta, string denominacion,
            string cuit, bool? activo, int sucursalid, int pageIndex, int pageSize, out int pageTotal);

        List<ProveedorConsignacionDto> ProveedorConsignacion(string sortBy, string sortDirection, Guid? proveedorId,
            int? cuenta, string denominacion, string cuit, bool? activo, DateTime? fechaConsigDesde,
            DateTime? fechaConsigHasta, bool? pendientePago, int sucursalId,
            int pageIndex, int pageSize, out int pageTotal);

        List<ProveedorConsignacionDto> ProveedorConsignacion(string sortBy, string sortDirection,
            Guid? proveedorId, bool? activo, DateTime? fechaConsigDesde, DateTime? fechaConsigHasta,
            int sucursalId, int pageIndex,
            int pageSize, out int pageTotal);

        TituloConsignacionRendidaDto ObtenerTituloConsignacionPorId(Guid tituloConsignacionRendidaId);

        decimal SenaAFavorProveedor(Guid proveedorId, int sucursalId);

        void AnularSeniaProveedor(ProveedorSenia senia, Caja caja, Guid operadorId, int sucursalId);

        void CrearSeniaProveedor(ProveedorSenia senia, IList<VentaPago> pagos, Caja caja, Guid operadorId,
            int sucursalId);

        void EditarTitulosConsignacionDetalle(IList<TituloConsignacionRendidasDetalleDto> titulosDetalleDtos);
    }
}
