using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class LimiteCreditoLogDAL
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarLimiteCreditoLog(LimiteCreditoLogBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("LimiteCreditoLog_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLog", DbType.String, BE.IdLog);
               if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdSocio_Dsc", DbType.String, BE.IdSocio_Dsc);
               db.AddInParameter(cmd, "IdReferencia", DbType.String, BE.IdReferencia);
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

