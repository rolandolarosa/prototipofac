using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class ProductosFactoringDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarProductosFactoring(ProductosFactoringBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("ProductosFactoring_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "prodCreditoID", DbType.String, BE.prodCreditoID);
               db.AddInParameter(cmd, "lineaCreditoID", DbType.String, BE.lineaCreditoID);
               db.AddInParameter(cmd, "condicionID", DbType.String, BE.condicionID);
               db.AddInParameter(cmd, "monedaID", DbType.Int32, BE.monedaID);
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

