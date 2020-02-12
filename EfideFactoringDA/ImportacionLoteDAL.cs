using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class ImportacionLoteDAL
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarImportacionLote(ImportacionLoteBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("ImportacionLote_Val");
               db.AddInParameter(cmd, "USUARIO", DbType.Int32, BE.USUARIO);
               db.AddInParameter(cmd, "vcRuc", DbType.String, BE.RucPagadora);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "cNumDoc", DbType.String, BE.cNumDoc);
               db.AddInParameter(cmd, "Pagadora_Dsc", DbType.String, BE.Pagadora_Dsc);
               db.AddInParameter(cmd, "RucGiradorOriginal", DbType.String, BE.RucGiradorOriginal);
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

