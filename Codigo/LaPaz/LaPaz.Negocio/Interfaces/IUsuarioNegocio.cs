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
    public interface IUsuarioNegocio
    {
        List<UsuarioDto> Listado(string sortBy, string sortDirection, string criteria,string cuit,bool? habilitado, int pageIndex, int pageSize, out int pageTotal);
        void CrearOperador(Operador operador);
        void EditarOperador(Operador operador);
        void EliminarOperador(Guid operadorId);
        void DeshabilitarOperador(Guid operadorId);
        void HabilitarOperador(Guid operadorId);
    }
}
