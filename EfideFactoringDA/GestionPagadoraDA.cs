using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class GestionPagadoraDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGestionPagadora(GestionPagadoraBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.GestionPagadora");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "vcPagadora", DbType.String, BE.vcPagadora);
               db.AddInParameter(cmd, "IdGestor", DbType.String, BE.IdGestor);
               db.AddInParameter(cmd, "TipCam", DbType.Decimal, BE.TipCam);
               db.AddInParameter(cmd, "IdEstadoLinea_tt", DbType.String, BE.IdEstadoLinea_tt);
               db.AddInParameter(cmd, "FlgOrigen", DbType.Int32, BE.FlgOrigen); 
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

