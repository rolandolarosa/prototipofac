using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class CuentasxPagarTMBloqueoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarCuentasxPagarTMBloqueo(CuentasxPagarTMBloqueoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("CuentasxPagarTMBloqueo_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "ctaPagarID", DbType.String, BE.ctaPagarID);
               db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora); 
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

