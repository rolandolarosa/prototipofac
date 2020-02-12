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
    public class ValoresGeneralesDA : IValoresGeneralesD
    {
        private Database _dbFenixCat;
        private Database dbFenixCat
        {
            get { return (_dbFenixCat == null ? _dbFenixCat = DatabaseFactory.CreateDatabase(AppSettings.ConexionStrDBFENIXCAT) : _dbFenixCat); }
        }

        public List<ValoresGeneralesBE> listValoresGenerales(ValoresGeneralesBE pValoresGeneralesBE)
        {
            List<ValoresGeneralesBE> lstValoresGeneralesBE = new List<ValoresGeneralesBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbFenixCat.GetStoredProcCommand(GetNameStoreProcedure.spSelectValorGenerales))
                {
                    //cmd.CommandTimeout = 0;
                    dbFenixCat.AddInParameter(cmd, "valorID", DbType.Int32, pValoresGeneralesBE.valorID);
                    dbFenixCat.AddInParameter(cmd, "varCodigo", DbType.Int32, pValoresGeneralesBE.varCodigo);
                    dr = dbFenixCat.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstValoresGeneralesBE.Add(ValoresGeneralesP.obtenerValoresGenerales(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstValoresGeneralesBE;
        }

        public List<ValueListsBE> listCuentasBancarias()
        {
            List<ValueListsBE> lstValoresGeneralesBE = new List<ValueListsBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbFenixCat.GetStoredProcCommand(GetNameStoreProcedure.spSelectCtasBancariasTR))
                {
                    //cmd.CommandTimeout = 0;
                    dbFenixCat.AddInParameter(cmd, "@ctasBancariasID", DbType.String, DBNull.Value);
                    dbFenixCat.AddInParameter(cmd, "@ctasBanEstado", DbType.String, "1");
                    dbFenixCat.AddInParameter(cmd, "@PlazaID", DbType.String, DBNull.Value);
                    dbFenixCat.AddInParameter(cmd, "@ctasBanNumCta", DbType.String, DBNull.Value);
                    dbFenixCat.AddInParameter(cmd, "@valorTipoEntFinID", DbType.String, DBNull.Value);
                    dbFenixCat.AddInParameter(cmd, "@valorMonedaID", DbType.String, DBNull.Value);
                    dr = dbFenixCat.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstValoresGeneralesBE.Add(ValoresGeneralesP.obtenerCuentasBancarias(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstValoresGeneralesBE;
        }
    }
}
