using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess
{
    public class CuentaBancosDA : ICuentaBancosD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public void insertCuentaBancos(BusinessEntity.CuentaBancosBE pCuentaBancosBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertCuentaBancos))
            {
                cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.String, pCuentaBancosBE.idTipoEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pCuentaBancosBE.idEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.String, pCuentaBancosBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoCuenta", DbType.String, pCuentaBancosBE.idTipoCuenta);
                dbAdeudosInversiones.AddInParameter(cmd, "cuentaLocal", DbType.String, pCuentaBancosBE.cuentaLocal);
                dbAdeudosInversiones.AddInParameter(cmd, "cuentaCCI", DbType.String, pCuentaBancosBE.cuentaCCI);
                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, pCuentaBancosBE.usuCreacion);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public void updateCuentaBancos(BusinessEntity.CuentaBancosBE pCuentaBancosBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspUpdateCuentaBancos))
            {
                cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "cuentaBancoID", DbType.String, pCuentaBancosBE.cuentaBancoID);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.String, pCuentaBancosBE.idTipoEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pCuentaBancosBE.idEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.String, pCuentaBancosBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoCuenta", DbType.String, pCuentaBancosBE.idTipoCuenta);
                dbAdeudosInversiones.AddInParameter(cmd, "cuentaLocal", DbType.String, pCuentaBancosBE.cuentaLocal);
                dbAdeudosInversiones.AddInParameter(cmd, "cuentaCCI", DbType.String, pCuentaBancosBE.cuentaCCI);
                dbAdeudosInversiones.AddInParameter(cmd, "usuUltActualizacion", DbType.String, pCuentaBancosBE.usuUltActualizacion);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public CuentaBancosBE getCuentaBancos(int pCuentaBancoID)
        {
            BusinessEntity.CuentaBancosBE oCuentaBancosBE = new BusinessEntity.CuentaBancosBE();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetCuentaBancos))
                {
                    cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "cuentaBancoID", DbType.Int32, pCuentaBancoID);
                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oCuentaBancosBE = CuentaBancosP.ObtenerCuentaBancos(dr);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return oCuentaBancosBE;
        }

        public List<CuentaBancosBE> listCuentaBancos(int pidTipoEntidadFinanciera)
        {
            List<BusinessEntity.CuentaBancosBE> lstCuentaBancosBE = new List<BusinessEntity.CuentaBancosBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListCuentaBancos))
                {
                    cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pidTipoEntidadFinanciera);
                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstCuentaBancosBE.Add(CuentaBancosP.ObtenerCuentaBancos(dr));
                    }
                }
            }
            catch (Exception ex)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstCuentaBancosBE;
        }
    }
}
