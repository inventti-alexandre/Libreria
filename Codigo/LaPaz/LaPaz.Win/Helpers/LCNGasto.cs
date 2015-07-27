using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LaPaz.Datos.Interfaces;
using LaPaz.Entidades;

namespace LaPaz.Win.Helpers
{
    public class LCNGasto
    {
        public static string Generar(ILaPazUow Uow, int sucursalId)
        {
            string lcn;
            char pad = '0';
            int nroComprobante;
            OrdenesPago sucursalOrden;
            if (Uow.OrdenesPagos.Listado().Where(o => o.SucursalId == sucursalId).Any())
            {
                var lista= Uow.OrdenesPagos.Listado().Where(o => o.SucursalId == sucursalId).OrderByDescending(o => o.Fecha).ToList();
                sucursalOrden = lista.First();
                string lcnSucursal = sucursalOrden.LCN.Substring(5, 8);
                int.TryParse(lcnSucursal, out nroComprobante);
                nroComprobante += 1;
                lcn = string.Format("{0}{1}", sucursalId.ToString().PadLeft(4, pad),
                                    nroComprobante.ToString().PadLeft(8, pad));
            }
            else
            {
                nroComprobante = 1;
                lcn = string.Format("{0}{1}", sucursalId.ToString().PadLeft(4, pad),
                                    nroComprobante.ToString().PadLeft(8, pad));
            }
            
            return lcn;
        }
    }
}
