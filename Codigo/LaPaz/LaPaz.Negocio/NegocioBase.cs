using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework.Ioc;
using LaPaz.Datos.Helpers;
using LaPaz.Datos.Interfaces;

namespace LaPaz.Negocio
{
    public class NegocioBase : IDisposable
    {
        protected ILaPazUow Uow { get; set; }

        protected IUowFactory UowFactory { get; set; }

        #region IDisposable

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (Uow != null)
                {
                    Uow.Dispose();
                    Uow = null;
                    Ioc.Container.Release(this);
                }
            }
        }

        #endregion
    }
}
