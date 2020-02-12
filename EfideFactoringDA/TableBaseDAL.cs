using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class TableBaseDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarTableBase(TableBaseBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("TableBase_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Table_Id", DbType.String, BE.Table_Id);
               db.AddInParameter(cmd, "Table_Parent_Id", DbType.String, BE.Table_Parent_Id);
               db.AddInParameter(cmd, "Table_Name", DbType.String, BE.Table_Name);
               db.AddInParameter(cmd, "Table_Order", DbType.String, BE.Table_Order);
               db.AddInParameter(cmd, "Table_Value", DbType.String, BE.Table_Value);
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

