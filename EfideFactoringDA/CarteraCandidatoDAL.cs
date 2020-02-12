using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class CarteraCandidatoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarCarteraCandidato(CarteraCandidatoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("CarteraCandidato_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdCartera", DbType.String, BE.IdCartera);
               db.AddInParameter(cmd, "cRucPagadora", DbType.String, BE.cRucPagadora);
               db.AddInParameter(cmd, "vApePaterno", DbType.String, BE.vApePaterno);
               db.AddInParameter(cmd, "vApeMaterno", DbType.String, BE.vApeMaterno);
               db.AddInParameter(cmd, "vNombre", DbType.String, BE.vNombre);
               db.AddInParameter(cmd, "IdTipoDocumento_tt", DbType.String, BE.IdTipoDocumento_tt);
               db.AddInParameter(cmd, "vNroDocumento", DbType.String, BE.vNroDocumento);
               db.AddInParameter(cmd, "IdTipoPersona_tt", DbType.String, BE.IdTipoPersona_tt);
               db.AddInParameter(cmd, "cGlobal_TipoRiesgo", DbType.Int32, BE.cGlobal_TipoRiesgo);
               db.AddInParameter(cmd, "cGlobal_TipoEmpresa", DbType.Int32, BE.cGlobal_TipoEmpresa);
               db.AddInParameter(cmd, "vContacto", DbType.String, BE.vContacto);
               db.AddInParameter(cmd, "vCargo", DbType.String, BE.vCargo);
               db.AddInParameter(cmd, "vTelefono1", DbType.String, BE.vTelefono1);
               db.AddInParameter(cmd, "vTelefono2", DbType.String, BE.vTelefono2);
               db.AddInParameter(cmd, "vTelefono3", DbType.String, BE.vTelefono3);
               db.AddInParameter(cmd, "vCorreo", DbType.String, BE.vCorreo);
               db.AddInParameter(cmd, "FlgPagadora", DbType.Int32, BE.FlgPagadora);
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

