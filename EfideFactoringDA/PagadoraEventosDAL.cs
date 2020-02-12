using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class PagadoraEventosDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPagadoraEventos(PagadoraEventosBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("PagadoraEventos_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdEvento_tt", DbType.String, BE.IdEvento_tt);
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

