using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudTrackingDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitudTracking(SolicitudTrackingBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SolicitudTracking_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               db.AddInParameter(cmd, "IdTipo_tt", DbType.String, BE.IdTipo_tt);
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

