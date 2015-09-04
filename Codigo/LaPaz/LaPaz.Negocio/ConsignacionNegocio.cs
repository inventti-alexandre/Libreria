using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.QueryableExtensions;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades.Dto;
using LaPaz.Entidades.Enums;
using LaPaz.Negocio.Interfaces;
using System.Linq;
using LaPaz.Entidades;
using AutoMapper;

namespace LaPaz.Negocio
{
    public class ConsignacionNegocio : NegocioBase, IConsignacionNegocio
    {
        public ConsignacionNegocio(ILaPazUow uow)
        {
            Uow = uow;
        }

        public List<ConsignacionSinRendir> VentasSinRendir(Guid? proveedorId, DateTime desde, DateTime hasta, int sucursalId)
        {
            try
            {
                var resultados = Uow.TitulosConsignacionesVendidas.VentasSinRendir(proveedorId, desde, hasta, sucursalId);
                return resultados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public List<ConsignacionesParaDevolver> ConsignacionesParaDevolver(Guid? proveedorId, DateTime desde, DateTime hasta)
        {
            try
            {
                var resultados = Uow.TitulosConsignacionesDevueltas.ConsignacionesParaDevolver(proveedorId, desde, hasta);
                return resultados;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
