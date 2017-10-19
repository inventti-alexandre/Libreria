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
    public interface ITitulosMovimientoNegocio : IDisposable
    {
        List<TitulosMovimientoDto> Listado(int id, int sucursal);
    }
}
