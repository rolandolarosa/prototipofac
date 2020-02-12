using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.IntercafeData.inversion
{
    public interface  ICuentaBancosD
    {
        void insertCuentaBancos(CuentaBancosBE pCuentaBancosBE);
        void updateCuentaBancos(CuentaBancosBE pCuentaBancosBE);
        CuentaBancosBE getCuentaBancos(int pCuentaBancoID);
        List<CuentaBancosBE> listCuentaBancos(int pidTipoEntidadFinanciera);
    }
}
