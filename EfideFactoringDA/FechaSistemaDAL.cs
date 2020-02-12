using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class FechaSistemaDAL
    {

        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarFechaSistema(FechaSistemaBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("FechaSistema_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                dsResult = db.ExecuteDataSet(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dsResult;
        }


    }
}
