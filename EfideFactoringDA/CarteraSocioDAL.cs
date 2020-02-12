using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class CarteraSocioDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarCarteraSocio(CarteraSocioBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("CarteraSocio_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "gestorCuentaID", DbType.String, BE.gestorCuentaID);
               if (BE.FechaInicio != DateTime.MinValue) { db.AddInParameter(cmd, "FechaInicio", DbType.DateTime, BE.FechaInicio); }
               if (BE.FechaFin != DateTime.MinValue) { db.AddInParameter(cmd, "FechaFin", DbType.DateTime, BE.FechaFin); }
               if (BE.FechaInactivo1 != DateTime.MinValue) { db.AddInParameter(cmd, "FechaInactivo1", DbType.DateTime, BE.FechaInactivo1); }
               if (BE.FechaInactivo2 != DateTime.MinValue) { db.AddInParameter(cmd, "FechaInactivo2", DbType.DateTime, BE.FechaInactivo2); }
               db.AddInParameter(cmd, "NumDias", DbType.Int32, BE.NumDias);
               db.AddInParameter(cmd, "UsuarioID", DbType.String, BE.UsuarioID);
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

