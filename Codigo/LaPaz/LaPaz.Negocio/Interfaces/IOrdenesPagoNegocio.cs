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
   public interface IOrdenesPagoNegocio: IDisposable
    {
       List<OrdenesPagoDto> Listado(string sortBy, string sortDirection, string concepto, string nrocomprobante, 
                            string proveedorId, int? sucursalGastoId, int? centroCostoId, int? tipogastoId, 
                            TipoComprobanteEnum? tipoComprobanteId, bool pendiente, int pageIndex, int pageSize, out int pageTotal);
    }
}
