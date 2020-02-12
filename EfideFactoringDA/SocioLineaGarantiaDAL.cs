using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class SocioLineaGarantiaDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSocioLineaGarantia(SocioLineaGarantiaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SocioLineaGarantia_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
               db.AddInParameter(cmd, "IdTipo_Documento_tt", DbType.String, BE.IdTipo_Documento_tt);
               db.AddInParameter(cmd, "Documento", DbType.String, BE.Documento);
               db.AddInParameter(cmd, "Archivo", DbType.Binary, BE.Archivo);
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

