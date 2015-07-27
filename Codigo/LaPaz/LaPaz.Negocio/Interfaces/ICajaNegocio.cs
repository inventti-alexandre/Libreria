using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Entidades;
using LaPaz.Entidades.Dto;

namespace LaPaz.Negocio.Interfaces
{
    public interface ICajaNegocio : IDisposable
    {
        Caja UltimaCaja(Guid opertadorId,int sucursalId);
        Caja UltimaCajaCarrada(Guid opertadorId, int sucursalId);
        Caja AbrirCaja(Guid opertadorId,int sucursalId);
        Caja CerrarCaja(Guid opertadorId,int sucursalId);
        bool EstaUltimaCajaAbierta(Guid opertadorId, int sucursalId);
    }
}
