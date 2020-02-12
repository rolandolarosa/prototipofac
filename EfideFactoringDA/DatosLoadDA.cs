using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class DatosLoadDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarDatosLoad(DatosLoadBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("DatosLoad_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Codigo", DbType.String, BE.Codigo);
               db.AddInParameter(cmd, "Descripcion", DbType.String, BE.Descripcion);
               db.AddInParameter(cmd, "Columna1", DbType.String, BE.Columna1);
               db.AddInParameter(cmd, "Columna2", DbType.String, BE.Columna2);
               db.AddInParameter(cmd, "Columna3", DbType.String, BE.Columna3);
               db.AddInParameter(cmd, "Columna4", DbType.String, BE.Columna4);
               db.AddInParameter(cmd, "Columna5", DbType.String, BE.Columna5);
               db.AddInParameter(cmd, "Columna6", DbType.String, BE.Columna6);
               db.AddInParameter(cmd, "Columna7", DbType.String, BE.Columna7);
               db.AddInParameter(cmd, "Columna8", DbType.String, BE.Columna8);
               db.AddInParameter(cmd, "Columna9", DbType.String, BE.Columna9);
               db.AddInParameter(cmd, "Columna10", DbType.String, BE.Columna10);
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

