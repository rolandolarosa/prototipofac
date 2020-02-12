using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class GestionMetasDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGestionMetas(GestionMetasBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("GestionMetas_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Annio", DbType.String, BE.Annio);
               db.AddInParameter(cmd, "Mes", DbType.String, BE.Mes);
               db.AddInParameter(cmd, "GestorId", DbType.String, BE.GestorId);
               db.AddInParameter(cmd, "Monto", DbType.Decimal, BE.Monto);
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

