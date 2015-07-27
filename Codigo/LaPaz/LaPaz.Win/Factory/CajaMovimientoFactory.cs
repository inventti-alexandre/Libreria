using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Comun.Utility;
using LaPaz.Entidades;
using LaPaz.Entidades.Enums;
using LaPaz.Seguridad;
using LaPaz.Win.Factory;

namespace LaPaz.Win.Factory
{
    public class CajaMovimientoFactory : ICajaMovientoFactory
    {
        private readonly IClock _clock;
        private readonly ILaPazContext _context;

        public CajaMovimientoFactory(IClock clock, ILaPazContext context)
        {
            _clock = clock;
            _context = context;
        }

        public CajaMovimiento Create(TipoComprobanteEnum tipoComprobante, TipoMovimientoCajaEnum tipoMovimiento, Guid comprobanteId, decimal importe)
        {
            CajaMovimiento cajaMovimiento = new CajaMovimiento();

            cajaMovimiento.Id = Guid.NewGuid();
            cajaMovimiento.CajaId = _context.CajaActual.Id;
            cajaMovimiento.TipoComprobante = tipoComprobante;
            cajaMovimiento.TipoMovimientoCajaId = tipoMovimiento;
            cajaMovimiento.ComprobanteId = comprobanteId;
            cajaMovimiento.Importe = importe;
            cajaMovimiento.ImpFac = importe;
            cajaMovimiento.FechaAlta = _clock.Now;
            cajaMovimiento.FechaModificacion = _clock.Now;
            cajaMovimiento.PcAlta = System.Environment.MachineName;
            cajaMovimiento.OperadorAltaId = _context.OperadorActual.Id;
            cajaMovimiento.SucursalAltaId = _context.SucursalActual.Id;
            cajaMovimiento.OperadorModificacionId = _context.OperadorActual.Id;
            cajaMovimiento.SucursalModificacionId = _context.SucursalActual.Id;

            return cajaMovimiento;
        }
    }
}
