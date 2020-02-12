﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;

namespace Efide.Tesoreria.BusinessLogic.adeudo
{
    public class CuentaBancosBL : ICuentaBancosD
    {
        private CuentaBancosDA _CuentaBancosDA;
        private CuentaBancosDA oCuentaBancosDA
        {
            get { return (_CuentaBancosDA == null ? _CuentaBancosDA = new CuentaBancosDA() : _CuentaBancosDA); }
        }

        public void insertCuentaBancos(CuentaBancosBE pCuentaBancosBE)
        {
            oCuentaBancosDA.insertCuentaBancos(pCuentaBancosBE);
        }

        public void updateCuentaBancos(CuentaBancosBE pCuentaBancosBE)
        {
            oCuentaBancosDA.updateCuentaBancos(pCuentaBancosBE);
        }

        public CuentaBancosBE getCuentaBancos(int pCuentaBancoID)
        {
            return oCuentaBancosDA.getCuentaBancos(pCuentaBancoID);
        }

        public List<CuentaBancosBE> listCuentaBancos(int pidTipoEntidadFinanciera)
        {
            return oCuentaBancosDA.listCuentaBancos(pidTipoEntidadFinanciera);
        }
    }
}