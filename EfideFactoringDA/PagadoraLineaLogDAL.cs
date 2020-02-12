using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class PagadoraLineaLogDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPagadoraLineaLog(PagadoraLineaLogBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("PagadoraLineaLog_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLineaLog", DbType.String, BE.IdLineaLog);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "IdNivelAutonomia_tt", DbType.String, BE.IdNivelAutonomia_tt);
               db.AddInParameter(cmd, "IdMedio_tt", DbType.String, BE.IdMedio_tt);
               db.AddInParameter(cmd, "IdAnalistaCredito_tt", DbType.String, BE.IdAnalistaCredito_tt);
               db.AddInParameter(cmd, "iPlazo", DbType.Int32, BE.iPlazo);
               if (BE.dtFechaAprobacion != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaAprobacion", DbType.DateTime, BE.dtFechaAprobacion); }
               if (BE.dtFechaVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaVencimiento", DbType.DateTime, BE.dtFechaVencimiento); }
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

