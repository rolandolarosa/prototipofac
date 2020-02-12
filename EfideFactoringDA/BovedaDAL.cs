using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
    public class BovedaDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarBoveda(BovedaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Boveda_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdBoveda", DbType.String, BE.IdBoveda);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
               db.AddInParameter(cmd, "vDescripcion", DbType.String, BE.vDescripcion);
               if (BE.dtEnvioBoveda != DateTime.MinValue) { db.AddInParameter(cmd, "dtEnvioBoveda", DbType.DateTime, BE.dtEnvioBoveda); }
               if (BE.dtCierreBoveda != DateTime.MinValue) { db.AddInParameter(cmd, "dtCierreBoveda", DbType.DateTime, BE.dtCierreBoveda); }
               db.AddInParameter(cmd, "vRazonSocialSocio", DbType.String, BE.vRazonSocialSocio);
               db.AddInParameter(cmd, "FlgVerHistoricos", DbType.Int32, BE.FlgVerHistoricos);
               db.AddInParameter(cmd, "IdPersonaSolicitud", DbType.String, BE.IdPersonaSolicitud);
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
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

