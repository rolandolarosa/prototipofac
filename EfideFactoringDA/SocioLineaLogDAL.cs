using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class SocioLineaLogDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSocioLineaLog(SocioLineaLogBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SocioLineaLog_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLineaLog", DbType.String, BE.IdLineaLog);
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               if (BE.dtRegistro != DateTime.MinValue){ db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro);}
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nImporteAnterior", DbType.Decimal, BE.nImporteAnterior);
               db.AddInParameter(cmd, "nImporteNuevo", DbType.Decimal, BE.nImporteNuevo);
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

