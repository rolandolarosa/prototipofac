using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class CuentaBancosBL : ICuentaBancosD
    {
        private CuentaBancosDA _CuentaBancosDA;
        private CuentaBancosDA oCuentaBancosDA
        {
            get { return (_CuentaBancosDA == null ? _CuentaBancosDA = new CuentaBancosDA() : _CuentaBancosDA); }
        }

        public void insertCuentaBancos(BusinessEntity.CuentaBancosBE pCuentaBancosBE)
        {
            oCuentaBancosDA.insertCuentaBancos(pCuentaBancosBE);
        }

        public void updateCuentaBancos(BusinessEntity.CuentaBancosBE pCuentaBancosBE)
        {
            oCuentaBancosDA.updateCuentaBancos(pCuentaBancosBE);
        }

        public BusinessEntity.CuentaBancosBE getCuentaBancos(int pCuentaBancoID)
        {
            return oCuentaBancosDA.getCuentaBancos(pCuentaBancoID);
        }

        public List<BusinessEntity.CuentaBancosBE> listCuentaBancos(int pidTipoEntidadFinanciera)
        {
            return oCuentaBancosDA.listCuentaBancos(pidTipoEntidadFinanciera);
        }
    }
}
