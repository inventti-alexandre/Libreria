using System;
using System.Linq;
using LaPaz.Datos.Interfaces;
using LaPaz.Negocio.Interfaces;
using LaPaz.Entidades;
using Framework.Comun.Utility;

namespace LaPaz.Negocio
{
    public class CajaNegocio : NegocioBase, ICajaNegocio
    {
        private readonly IClock _clock;

        public CajaNegocio(ILaPazUow uow, IClock clock,IUowFactory uowFactory)
        {
            Uow = uow;
            UowFactory = uowFactory;
            _clock = clock;
        }

        public Caja UltimaCaja(Guid opertadorId, int sucursalId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                return uow.Cajas.Listado()
                      .Where(c => c.OperadorId == opertadorId && c.SucursalId == sucursalId)
                      .OrderByDescending(c => c.Fecha).FirstOrDefault();
            }
        }

        public Caja UltimaCajaCarrada(Guid opertadorId, int sucursalId)
        {
            using (var uow = UowFactory.Create<ILaPazUow>())
            {
                return uow.Cajas.Listado()
                      .Where(c => c.FCierre != null && c.OperadorId == opertadorId)
                      .OrderByDescending(c => c.FCierre).FirstOrDefault();
            }
        }

        public Caja AbrirCaja(Guid opertadorId,int sucursalId)
        {
            Operador operador = Uow.Operadores.Obtener(o => o.Id == opertadorId);

            if (operador == null)
            {
                throw new ApplicationException("No se ha encontrado el operador");
            }

            Caja ultimaCaja = this.UltimaCaja(opertadorId, sucursalId);
            Caja caja = new Caja();
            if (ultimaCaja != null)
            {
                if (ultimaCaja.FCierre == null)
                {
                    throw new ApplicationException("No se puede abrir la caja. El operador posee una caja que no ha sido cerrada");
                }
                caja.Ingresos = 0;
                caja.Egresos = 0;
                caja.Cheques = 0;

                caja.Inicio = ultimaCaja.Saldo;
                caja.Saldo = ultimaCaja.Saldo;
            }

            var now = _clock.Now;

            caja.Id = Guid.NewGuid();
            caja.Fecha = now;
            caja.OperadorId = opertadorId;
            caja.OperadorAltaId = opertadorId;
            caja.FechaAlta = now;
            caja.SucursalAltaId = sucursalId;
            caja.SucursalId = sucursalId;

            Uow.Cajas.Agregar(caja);
            Uow.Commit();

            return caja;
        }

        public Caja CerrarCaja(Guid opertadorId, int sucursalId)
        {
            Caja ultimaCaja = this.UltimaCaja(opertadorId, sucursalId);

            if (ultimaCaja == null)
                throw new ApplicationException("No se puede cerrar la caja. La ultima caja del operador");

            if (ultimaCaja.FCierre != null)
                throw new ApplicationException(
                    "No se puede cerrar la caja. La ultima caja del operador ya ha sido cerrada");

            //if (ultimaCaja.Saldo != ultimaCaja.Inicio + ultimaCaja.Ingresos - ultimaCaja.Egresos)
            //    throw new ApplicationException(
            //        "No se puede cerrar la caja. El saldo de la misma no coincide con los ingreso/egreso");

            var now = _clock.Now;
            
            ultimaCaja.FCierre = _clock.Now;
            ultimaCaja.FechaModificacion = now;
            ultimaCaja.PcAlta = System.Environment.MachineName;

            Uow.Cajas.Modificar(ultimaCaja);
            Uow.Commit();

            return ultimaCaja;
        }

        public bool EstaUltimaCajaAbierta(Guid opertadorId, int sucursalId)
        {
            var ultimaCaja = this.UltimaCaja(opertadorId, sucursalId);
            return ultimaCaja != null && ultimaCaja.FCierre == null;
        }
    }
}
