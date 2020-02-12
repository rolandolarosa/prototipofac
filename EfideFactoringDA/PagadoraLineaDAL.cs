using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class PagadoraLineaDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPagadoraLinea(PagadoraLineaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("PagadoraLinea_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nLinea", DbType.Decimal, BE.nLinea);
               db.AddInParameter(cmd, "nUtilizado", DbType.Decimal, BE.nUtilizado);
               db.AddInParameter(cmd, "IdNivelAutonomia_tt", DbType.String, BE.IdNivelAutonomia_tt);
               if (BE.dtFechaAprobacion != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaAprobacion", DbType.DateTime, BE.dtFechaAprobacion);}
               db.AddInParameter(cmd, "IdMedio_tt", DbType.String, BE.IdMedio_tt);
               db.AddInParameter(cmd, "IdAnalistaCredito_tt", DbType.String, BE.IdAnalistaCredito_tt);
               db.AddInParameter(cmd, "iPlazo", DbType.Int32, BE.iPlazo);
               if (BE.dtFechaVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaVencimiento", DbType.DateTime, BE.dtFechaVencimiento);}
               db.AddInParameter(cmd, "vcObservaciones", DbType.String, BE.vcObservaciones);
               db.AddInParameter(cmd, "nTipoCambio", DbType.Decimal, BE.nTipoCambio);
               if (BE.dtTipoCambio != DateTime.MinValue) { db.AddInParameter(cmd, "dtTipoCambio", DbType.DateTime, BE.dtTipoCambio); }
               db.AddInParameter(cmd, "IdEstadoLinea_tt", DbType.String, BE.IdEstadoLinea_tt);
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

