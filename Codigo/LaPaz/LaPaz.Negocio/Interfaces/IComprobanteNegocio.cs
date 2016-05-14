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
    public interface IComprobanteNegocio : IDisposable
    {
        string FormaDePago(Guid comprobanteId);
        string FormaDePagoReimpresion(Guid comprobanteId);
        
    }
}
