using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class TelefonoTDDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarTelefonoTD(TelefonoTDBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("TelefonoTD_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "valorCodigoID", DbType.Int32, BE.valorCodigoID);
               db.AddInParameter(cmd, "valorTipoID", DbType.Int32, BE.valorTipoID);
               db.AddInParameter(cmd, "valorOrigenTeleID", DbType.Int32, BE.valorOrigenTeleID);
               db.AddInParameter(cmd, "teleTelefono", DbType.String, BE.teleTelefono);
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

