using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class GrupoPagadoraLogDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGrupoPagadoraLog(GrupoPagadoraLogBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("GrupoPagadoraLog_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdGrupoLineaLog", DbType.String, BE.IdGrupoLineaLog);
               db.AddInParameter(cmd, "IdGrupoPagadora", DbType.String, BE.IdGrupoPagadora);
               if (BE.dtRegistro != DateTime.MinValue){ db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro);}
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.Decimal, BE.IdMoneda_tt);
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

