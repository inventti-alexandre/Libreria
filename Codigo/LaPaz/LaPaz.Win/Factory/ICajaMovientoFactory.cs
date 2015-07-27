using System;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;

namespace LaPaz.Win.Factory
{
    public interface ICajaMovientoFactory
    {
        CajaMovimiento Create(TipoComprobanteEnum tipoComprobante, TipoMovimientoCajaEnum tipoMovimiento,
            Guid comprobanteId, decimal importe);
    }
}
