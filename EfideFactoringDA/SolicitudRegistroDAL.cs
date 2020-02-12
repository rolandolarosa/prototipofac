using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudRegistroDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitudRegistro(SolicitudRegistroBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SolicitudRegistro_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               db.AddInParameter(cmd, "IdTipoRegistro_tt", DbType.String, BE.IdTipoRegistro_tt);
               db.AddInParameter(cmd, "vTomo", DbType.String, BE.vTomo);
               db.AddInParameter(cmd, "vFicha", DbType.String, BE.vFicha);
               db.AddInParameter(cmd, "vPartida", DbType.String, BE.vPartida);
               if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
               db.AddInParameter(cmd, "vLugar", DbType.String, BE.vLugar);
               db.AddInParameter(cmd, "vNroPagina", DbType.String, BE.vNroPagina);
               db.AddInParameter(cmd, "vCC", DbType.String, BE.vCC);
               db.AddInParameter(cmd, "vEP", DbType.String, BE.vEP);
               db.AddInParameter(cmd, "vOtro", DbType.String, BE.vOtro);
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

