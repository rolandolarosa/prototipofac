using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class BovedaDetalleDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarBovedaDetalle(BovedaDetalleBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("BovedaDetalle_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdBoveda", DbType.String, BE.IdBoveda);
               db.AddInParameter(cmd, "IdFormatoDocLegal_tt", DbType.String, BE.IdFormatoDocLegal_tt);
               if (BE.dtAdjunto != DateTime.MinValue) { db.AddInParameter(cmd, "dtAdjunto", DbType.DateTime, BE.dtAdjunto); }
               db.AddInParameter(cmd, "vArchivoAdjunto", DbType.String, BE.vArchivoAdjunto);
               db.AddInParameter(cmd, "bFlgRecepcion", DbType.Boolean, BE.bFlgRecepcion);
               if (BE.FechaPago != DateTime.MinValue) { db.AddInParameter(cmd, "FechaPago", DbType.DateTime, BE.FechaPago); }
               db.AddInParameter(cmd, "ImportePago", DbType.Decimal, BE.ImportePago);
               db.AddInParameter(cmd, "Comentario", DbType.String, BE.Comentario); 
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

