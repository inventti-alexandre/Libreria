using System.Threading;
using Framework.Ioc;
using LaPaz.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Negocio;
using LaPaz.Negocio.Interfaces;
namespace LaPaz.Seguridad
{
    public class LaPazContext : ILaPazContext
    {
        public Operador OperadorActual
        {
            get { return LaPazIdentity.Operador; }
        }

        private LaPazIdentity LaPazIdentity
        {
            get
            {
                var laPazPrincipal = Thread.CurrentPrincipal as LaPazPrincipal;
                return laPazPrincipal != null ? laPazPrincipal.Identity as LaPazIdentity : null;
            }
        }

        private LaPazPrincipal LaPazPrincipal
        {
            get
            {
                return Thread.CurrentPrincipal as LaPazPrincipal;
            }
        }

        public Sucursal SucursalActual
        {
            get { return LaPazIdentity.Sucursal; }
        }

        public Caja CajaActual
        {
            get
            {
                using (var cajaNegocio = Ioc.Container.Get<ICajaNegocio>())
                {
                    return cajaNegocio.UltimaCaja(this.OperadorActual.Id, this.SucursalActual.Id);
                }
            }
        }

        public bool IsInRole(string role)
        {
            return LaPazPrincipal.IsInRole(role);
        }


        public bool EsOpedatorAdmin
        {
            get
            {
                return this.IsInRole(RolesNames.Admin) || this.IsInRole(RolesNames.SuperAdmin);
            }
        }
    }
}
