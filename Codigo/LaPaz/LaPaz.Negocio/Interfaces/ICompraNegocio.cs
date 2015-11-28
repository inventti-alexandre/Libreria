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
    public interface ICompraNegocio : IDisposable
    {
        Compra CrearCompra(Compra compra);
        List<ComprasDto> Listado(string sortBy, string sortDirection, Guid? proveedorId, string nroComprobante, TipoComprobanteEnum? tipoId, int sucursal,  DateTime fechaInicio, DateTime fechaFin, int pageIndex, int pageSize, out int pageTotal);
        decimal? CompraTotal(Guid? proveedorId, int? sucursalId, DateTime fechaInicio, DateTime fechaFin);
        int? CantidadCompra(Guid? proveedorId, int? sucursalId, DateTime fechaInicio, DateTime fechaFin);
    }
}
