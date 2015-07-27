using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;
using LaPaz.Negocio.Interfaces;
using Framework.Comun.Utility;

namespace LaPaz.Negocio
{
    public class VentaDetalleNegocio : NegocioBase, IVentaDetalleNegocio
    {
        private IClock _clock;

        public VentaDetalleNegocio(ILaPazUow uow, IClock clock)
        {
            Uow = uow;
            _clock = clock;
        }

        public List<VentaDetalleDto> Listado(Guid ventaId)
        {
           //var resultados = Uow.VentasDetalle.Listado(x=>x.VentaId== ventaId,
           //                                         x => x.Titulo);
            var resultados = Uow.VentasDetalle.Listado(x => x.Titulo).Where(x => x.VentaId == ventaId);
            
            return resultados.Project().To<VentaDetalleDto>().ToList();
        }

        public decimal DeudaTotal(Guid clienteId)
        {
            var cuentasCorrientes = Uow.ClientesCuentasCorrientes.Listado().Where(cc => cc.ClienteId == clienteId);
            return (decimal) cuentasCorrientes.Select(cc => cc.Importe ?? 0 - cc.Pagado ?? 0).DefaultIfEmpty(0).Sum();
        }

        public decimal DeudaVencida(Guid clienteId)
        {
            var cuentasCorrientes = Uow.ClientesCuentasCorrientes.Listado()
                                       .Where(cc => cc.ClienteId == clienteId
                                                    && cc.FechaVencimiento <= _clock.Now);

            return (decimal) cuentasCorrientes.Select(cc => cc.Importe ?? 0 - cc.Pagado ?? 0).DefaultIfEmpty(0).Sum();
        }
    }
}
