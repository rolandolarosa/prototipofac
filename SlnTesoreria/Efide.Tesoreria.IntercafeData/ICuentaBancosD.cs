using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.IntercafeData
{
    public interface  ICuentaBancosD
    {
        void insertCuentaBancos(BusinessEntity.CuentaBancosBE pCuentaBancosBE);
        void updateCuentaBancos(BusinessEntity.CuentaBancosBE pCuentaBancosBE);
        CuentaBancosBE getCuentaBancos(int pCuentaBancoID);
        List<CuentaBancosBE> listCuentaBancos(int pidTipoEntidadFinanciera);
    }
}
