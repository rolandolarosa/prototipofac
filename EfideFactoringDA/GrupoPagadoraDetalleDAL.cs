using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class GrupoPagadoraDetalleDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGrupoPagadoraDetalle(GrupoPagadoraDetalleBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("GrupoPagadoraDetalle_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdGrupoPagadora", DbType.String, BE.IdGrupoPagadora);
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

