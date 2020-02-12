using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class IndicadorMensualDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarIndicadorMensual(IndicadorMensualBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("IndicadorMensual_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Periodo", DbType.String, BE.Periodo);
               if (BE.dtActualizacion != DateTime.MinValue) { db.AddInParameter(cmd, "dtActualizacion", DbType.DateTime, BE.dtActualizacion); }
               db.AddInParameter(cmd, "vCodigoIndicador", DbType.String, BE.vCodigoIndicador);
               db.AddInParameter(cmd, "vDescripcionIndicador", DbType.String, BE.vDescripcionIndicador);
               db.AddInParameter(cmd, "nImporte", DbType.Decimal, BE.nImporte); 
               db.AddInParameter(cmd, "nLimiteIndividual", DbType.Decimal, BE.nLimiteIndividual);
               db.AddInParameter(cmd, "nLimiteRiesgo", DbType.Decimal, BE.nLimiteRiesgo);
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

