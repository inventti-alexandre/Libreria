using System.Collections.Generic;
using LaPaz.Entidades.Dto;

namespace LaPaz.Negocio.Data
{
    public class RendirConsignacionClienteData : VentaDataBase
    {
        public IList<RemitosVentaDetalleDto> RemitosVentaDetalle { get; set; }
    }
}
