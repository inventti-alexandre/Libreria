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
    public class UsuarioNegocio : NegocioBase, IUsuarioNegocio
    {
        public UsuarioNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<UsuarioDto> Listado(string sortBy, string sortDirection, string criteria, string cuit,bool? habilitado, int pageIndex, int pageSize, out int pageTotal)
        {
            var criteros = new PagingCriteria();

            criteros.PageNumber = pageIndex;
            criteros.PageSize = pageSize;
            criteros.SortBy = !string.IsNullOrEmpty(sortBy) ? sortBy : "Usuario";
            criteros.SortDirection = !string.IsNullOrEmpty(sortDirection) ? sortDirection : "DESC";

            Expression<Func<Operador, bool>> where = x => (string.IsNullOrEmpty(criteria) || x.Usuario.Contains(criteria)) &&
                                                          (string.IsNullOrEmpty(cuit) || x.Personal.Cuit.Contains(cuit)) &&
                                                          (!habilitado.HasValue || x.Habilitado == habilitado);

            var resultados = Uow.Operadores.Listado(criteros,
                                                    where,
                                                    x => x.Personal,
                                                    x => x.Roles);

            pageTotal = resultados.PagedMetadata.TotalItemCount;

            return resultados.Entities.Project().To<UsuarioDto>().ToList();
        }

        public void CrearOperador(Operador operador)
        {
            AgregarNuevasSucursales(operador);
            Uow.Operadores.Agregar(operador);
            Uow.Personales.Agregar(operador.Personal);
            Uow.Commit();
        }

        public void EditarOperador(Operador operador)
        {
            ActualizarSucursales(operador);
            
            Uow.Personales.Modificar(operador.Personal);
            Uow.Operadores.Modificar(operador);
            Uow.Commit();
        }

        public void EliminarOperador(Guid operadorId)
        {
            var operador = Uow.Operadores.Obtener(c => c.Id == operadorId,
                                                       c => c.Personal,
                                                       o => o.OperadorSucursals);

            EliminarSucursales(operador);
            Uow.Personales.Eliminar(operador.Personal);
            Uow.Operadores.Eliminar(operador);
            Uow.Commit();
        }

        public void DeshabilitarOperador(Guid operadorId)
        {
            var operador = Uow.Operadores.Obtener(c => c.Id == operadorId);
            operador.Habilitado = false;
            Uow.Commit();
        }

        public void HabilitarOperador(Guid operadorId)
        {
            var operador = Uow.Operadores.Obtener(c => c.Id == operadorId);
            operador.Habilitado = true;
            Uow.Commit();
        }

        private void ActualizarSucursales(Operador operador)
        {
            var sucursales =
                Uow.OperadorSucursales.Listado().Where(os => os.OperadorId == operador.Id);

            foreach (var operadorSucursal in sucursales.ToList())
            {
                if (!operador.OperadorSucursals.Any(op => op.Id == operadorSucursal.Id))
                {
                    Uow.OperadorSucursales.Eliminar(operadorSucursal);
                }
            }

            foreach (var operadorSucursal in operador.OperadorSucursals)
            {
                if (!sucursales.Any(op => op.Id == operadorSucursal.Id))
                {
                    Uow.OperadorSucursales.Agregar(operadorSucursal);
                }
            }
        }

        private void AgregarNuevasSucursales(Operador operador)
        {
            var nuevasSucursales = operador.OperadorSucursals;

            foreach (var operadorSucursal in nuevasSucursales)
            {
                Uow.OperadorSucursales.Agregar(operadorSucursal);
            }
        }

        private void EliminarSucursales(Operador operador)
        {
            var sucursales =
               Uow.OperadorSucursales.Listado().Where(os => os.OperadorId == operador.Id);

            foreach (var operadorSucursal in sucursales.ToList())
            {
                Uow.OperadorSucursales.Eliminar(operadorSucursal);
            }
        }
    }
}
