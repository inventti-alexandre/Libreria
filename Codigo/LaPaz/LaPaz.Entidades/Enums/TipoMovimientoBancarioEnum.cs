using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPaz.Entidades.Enums
{
    public enum TipoMovimientoBancarioEnum
    {
        SaldoInicial = 1,
        DepositoEfectivo = 2,
        DepositoValores = 3,
        ComisiónBancaria = 51,
        RetiroEfectivo = 52,
        EmisiónDeCheque = 53,
        TransferenciaBancariaAProveedores = 54,
        TransferenciaBancariaOrdenPago = 55
    }
}
