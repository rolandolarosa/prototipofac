using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class SocioLineaPagDocDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSocioLineaPagDoc(SocioLineaPagDocBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SocioLineaPagDoc_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
               db.AddInParameter(cmd, "nFondoGarantia", DbType.Decimal, BE.nFondoGarantia);
               db.AddInParameter(cmd, "IdTipoConfirmacion", DbType.String, BE.IdTipoConfirmacion);
               db.AddInParameter(cmd, "bInteres", DbType.Boolean, BE.bInteres);
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

