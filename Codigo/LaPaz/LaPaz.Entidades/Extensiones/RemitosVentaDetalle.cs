using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades
{
    public partial class RemitosVentaDetalle
    {
        public int? CantidadDevueltaPropia
        {
            get
            {
                if (this.CntDevuelta <= this.CntPr)
                {
                    return this.CntDevuelta;
                }

                return this.CntPr;
            }
        }

        public int? CantidadDevueltaConsignacion
        {
            get
            {
                if (CantidadDevueltaPropia < this.CntDevuelta)
                {
                    return this.CntDevuelta - CantidadVendidaPropia;
                }

                return 0;
            }
        }

        public int? CantidadVendidaPropia
        {
            get
            {
                if (this.CntVendida <= this.CntPr)
                {
                    return this.CntVendida;
                }

                return this.CntPr;
            }
        }

        public int? CantidadVendidaConsignacion
        {
            get
            {
                if (CantidadVendidaPropia < this.CntVendida)
                {
                    return this.CntVendida - CantidadVendidaPropia;
                }

                return 0;
            }
        }

        public int? SaldoPropio
        {
            get { return CntPr - CantidadVendidaPropia - CantidadDevueltaPropia; }
        }

        public int? SaldoConsignacion
        {
            get { return CntCn - CantidadVendidaConsignacion - CantidadDevueltaConsignacion; }
        }

        public int? CalcularNuevaCantidadVendidaPropia(int cantidadVendida)
        {
            if (SaldoPropio > cantidadVendida)
            {
                return cantidadVendida;
            }

            return SaldoPropio;
        }

        public int? CalcularNuevaCantidadVendidaConsignacion(int cantidadVendida)
        {
            return cantidadVendida - CalcularNuevaCantidadVendidaPropia(cantidadVendida);
        }
    }
}
