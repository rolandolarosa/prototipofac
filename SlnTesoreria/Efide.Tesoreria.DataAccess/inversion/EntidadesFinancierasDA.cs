using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Populate.inversion;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess.inversion
{
    public class EntidadesFinancierasDA : IEntidadesFinancierasD
    {
        private Database _dbFenixCat;
        private Database dbFenixCat
        {
            get { return (_dbFenixCat == null ? _dbFenixCat = DatabaseFactory.CreateDatabase(AppSettings.ConexionStrDBFENIXCAT) : _dbFenixCat); }
        }

        public List<EntidadesFinancierasBE> obtenerEntidadesFinancieras(EntidadesFinancierasBE pEntidadesFinancierasBE)
        {
            List<EntidadesFinancierasBE> lstValoresGeneralesBE = new List<EntidadesFinancierasBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbFenixCat.GetStoredProcCommand(GetNameStoreProcedure.spSelectEntidadesFinancieras))
                {
                    //cmd.CommandTimeout = 0;
                    dbFenixCat.AddInParameter(cmd, "entFinancieraID", DbType.String, pEntidadesFinancierasBE.entFinancieraID);
                    dbFenixCat.AddInParameter(cmd, "valorTipoEntFinancID", DbType.Int32, pEntidadesFinancierasBE.valorTipoEntFinancID);
                    dbFenixCat.AddInParameter(cmd, "emprRazonSocial", DbType.String, pEntidadesFinancierasBE.emprRazonSocial);
                    dbFenixCat.AddInParameter(cmd, "entFinEstado", DbType.Boolean, pEntidadesFinancierasBE.entFinEstado);
                    dbFenixCat.AddInParameter(cmd, "empresaID", DbType.String, pEntidadesFinancierasBE.empresaID);
                    dbFenixCat.AddInParameter(cmd, "codigoEntFin", DbType.String, pEntidadesFinancierasBE.codigoEntFin);
                    dr = dbFenixCat.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstValoresGeneralesBE.Add(EntidadesFinancierasP.obtenerEntidadesFinancieras(dr));
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
