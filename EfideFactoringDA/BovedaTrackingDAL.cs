using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class BovedaTrackingDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarBovedaTracking(BovedaTrackingBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("BovedaTracking_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdBoveda", DbType.String, BE.IdBoveda);
               db.AddInParameter(cmd, "IdFormatoDocLegal_tt", DbType.String, BE.IdFormatoDocLegal_tt);
               db.AddInParameter(cmd, "IdTracking", DbType.String, BE.IdTracking);
               db.AddInParameter(cmd, "vComentario", DbType.String, BE.vComentario);
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

