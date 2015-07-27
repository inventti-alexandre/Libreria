using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    public partial class ConsignacionSinRendir
    {
        public decimal? Descuento { get; set; }
        
        public decimal TotalSinRendir
        {
            get
            {
                //var totalSinRendir = PrecioCompraTitulo.GetValueOrDefault() * Convert.ToInt32(CantidadSinRendir.GetValueOrDefault());
                //var descuentoSinRendir = (Convert.ToDecimal(Descuento.GetValueOrDefault() * PrecioCompraTitulo.GetValueOrDefault()) / 100) * Convert.ToInt32(CantidadSinRendir.GetValueOrDefault());
                //return totalSinRendir - descuentoSinRendir;
                return PrecioCompraCalculado * Convert.ToInt32(CantidadSinRendir.GetValueOrDefault());
            }
        }

        private int? _cantidadArendir;
        public int CantidadARendir
        {
            get { return _cantidadArendir ?? Convert.ToInt32(CantidadSinRendir); }
            set { _cantidadArendir = value;  }
        }

        public decimal TotalARendir
        {
            get
            {
                return PrecioCompraCalculado * Convert.ToInt32(CantidadARendir);
            }
        }

        public decimal PrecioCompraCalculado
        {
            get
            {
                var descuento = Descuento.GetValueOrDefault();
                if (descuento == 0)
                    return PrecioCompraTitulo.GetValueOrDefault();

                var venta = PrecioVentaTitulo.GetValueOrDefault();
                return venta - (venta*(descuento/100));
            }
        }
    }
}
