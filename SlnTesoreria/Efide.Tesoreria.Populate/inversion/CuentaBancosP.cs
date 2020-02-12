using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.Populate.inversion
{
    public class CuentaBancosP
    {
        public static CuentaBancosBE ObtenerCuentaBancos(IDataReader dr)
        {
            CuentaBancosBE oCuentaBancosBE = new CuentaBancosBE();

            if (!dr.IsDBNull(dr.GetOrdinal("cuentaBancoID")))
                oCuentaBancosBE.cuentaBancoID = dr.GetInt32(dr.GetOrdinal("cuentaBancoID"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoEntidadFinanciera")))
                oCuentaBancosBE.idTipoEntidadFinanciera = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("idTipoEntidadFinanciera")));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoEntidadFinanciera")))
                oCuentaBancosBE.nomTipoEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEntidadFinanciera")))
                oCuentaBancosBE.idEntidadFinanciera = dr.GetString(dr.GetOrdinal("idEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idMoneda")))
                oCuentaBancosBE.idMoneda = Convert.ToInt32(dr.GetDecimal(dr.GetOrdinal("idMoneda")));

            if (!dr.IsDBNull(dr.GetOrdinal("nomMoneda")))
                oCuentaBancosBE.nomMoneda = dr.GetString(dr.GetOrdinal("nomMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoCuenta")))
                oCuentaBancosBE.idTipoCuenta = dr.GetString(dr.GetOrdinal("idTipoCuenta"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoCuenta")))
                oCuentaBancosBE.nomTipoCuenta = dr.GetString(dr.GetOrdinal("nomTipoCuenta"));

            if (!dr.IsDBNull(dr.GetOrdinal("cuentaLocal")))
                oCuentaBancosBE.cuentaLocal = dr.GetString(dr.GetOrdinal("cuentaLocal"));

            if (!dr.IsDBNull(dr.GetOrdinal("cuentaCCI")))
                oCuentaBancosBE.cuentaCCI = dr.GetString(dr.GetOrdinal("cuentaCCI"));

            if (!dr.IsDBNull(dr.GetOrdinal("emprRazonSocial")))
                oCuentaBancosBE.emprRazonSocial = dr.GetString(dr.GetOrdinal("emprRazonSocial"));
            
            return oCuentaBancosBE;
        }
    }
}
