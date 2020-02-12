using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class GestionDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGestion(GestionBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Gestion_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdGestion", DbType.String, BE.IdGestion);
               db.AddInParameter(cmd, "IdGestionAtendida", DbType.String, BE.IdGestionAtendida);
               db.AddInParameter(cmd, "IdEntidad", DbType.String, BE.IdEntidad);
               db.AddInParameter(cmd, "IdAccion_tt", DbType.String, BE.IdAccion_tt);
               db.AddInParameter(cmd, "IdTipoCompromiso_tt", DbType.String, BE.IdTipoCompromiso_tt);
               if (BE.dtFechaCompromiso != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaCompromiso", DbType.DateTime, BE.dtFechaCompromiso); }
               db.AddInParameter(cmd, "IdMotivo_tt", DbType.String, BE.IdMotivo_tt);
               db.AddInParameter(cmd, "Comentario", DbType.String, BE.Comentario);
               db.AddInParameter(cmd, "FlgSocio", DbType.Int32, BE.FlgSocio);
               db.AddInParameter(cmd, "FlgInteresado", DbType.Int32, BE.FlgInteresado);
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
               db.AddInParameter(cmd, "Entidad", DbType.String, BE.Entidad);
               if (BE.FechaInicio != DateTime.MinValue) { db.AddInParameter(cmd, "FechaInicio", DbType.DateTime, BE.FechaInicio); }
               if (BE.FechaFin != DateTime.MinValue) { db.AddInParameter(cmd, "FechaFin", DbType.DateTime, BE.FechaFin); }
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

