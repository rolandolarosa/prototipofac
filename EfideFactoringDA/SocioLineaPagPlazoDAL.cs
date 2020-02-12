using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class SocioLineaPagPlazoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSocioLineaPagPlazo(SocioLineaPagPlazoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SocioLineaPagPlazo_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
               db.AddInParameter(cmd, "IdItem", DbType.String, BE.IdItem);
               db.AddInParameter(cmd, "nPlazo", DbType.Decimal, BE.nPlazo);
               db.AddInParameter(cmd, "nTasa", DbType.Decimal, BE.nTasa);
               db.AddInParameter(cmd, "nTasaSobregiro", DbType.Decimal, BE.nTasaSobregiro);
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

