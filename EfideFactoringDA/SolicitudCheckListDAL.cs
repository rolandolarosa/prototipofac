using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudCheckListDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitudCheckList(SolicitudCheckListBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SolicitudCheckList_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               db.AddInParameter(cmd, "IdDocumento_tt", DbType.String, BE.IdDocumento_tt);
               db.AddInParameter(cmd, "IdTipo_tt", DbType.String, BE.IdTipo_tt);
               db.AddInParameter(cmd, "vDocumento", DbType.String, BE.vDocumento);
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

