using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class BaseNegativaDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBGestion");
       DbCommand cmd = null;

       public DataSet ProcesarBaseNegativa(BaseNegativaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("BaseNegativa_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdBaseNegativa", DbType.String, BE.IdBaseNegativa);
               db.AddInParameter(cmd, "vApePaterno", DbType.String, BE.vApePaterno);
               db.AddInParameter(cmd, "vApeMaterno", DbType.String, BE.vApeMaterno);
               db.AddInParameter(cmd, "vNombre", DbType.String, BE.vNombre);
               db.AddInParameter(cmd, "IdTipoDocumento_tt", DbType.String, BE.IdTipoDocumento_tt);
               db.AddInParameter(cmd, "vNroDocumento", DbType.String, BE.vNroDocumento);
               db.AddInParameter(cmd, "Motivo", DbType.String, BE.Motivo);
               db.AddInParameter(cmd, "Observacion", DbType.String, BE.Observacion);
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

