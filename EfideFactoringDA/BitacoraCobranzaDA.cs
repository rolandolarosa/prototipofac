using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class BitacoraCobranzaDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarBitacoraCobranza(BitacoraCobranzaInputBE BE)
       {
           DataSet dsResult = new DataSet();
           try
           {
               cmd = db.GetStoredProcCommand("BitacoraCobranza_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdBitacora", DbType.String, BE.IdBitacora);
               db.AddInParameter(cmd, "IdEntidad", DbType.String, BE.IdEntidad);
               db.AddInParameter(cmd, "IdTipoBitacora_tt", DbType.String, BE.IdTipoBitacora_tt);
               db.AddInParameter(cmd, "IdOrigenBitacora_tt", DbType.String, BE.IdOrigenBitacora_tt);
               db.AddInParameter(cmd, "Descripcion", DbType.String, BE.Descripcion);
               if (BE.FechaAlerta != DateTime.MinValue) { db.AddInParameter(cmd, "FechaAlerta", DbType.DateTime, BE.FechaAlerta); }
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
               if (BE.FechaAtendido != DateTime.MinValue) { db.AddInParameter(cmd, "FechaAtendido", DbType.DateTime, BE.FechaAtendido); }
               db.AddInParameter(cmd, "IdGestor", DbType.String, BE.IdGestor);
               db.AddInParameter(cmd, "IdBitacoraGenerada", DbType.String, BE.IdBitacoraGenerada);
               db.AddInParameter(cmd, "nMontoCompromiso", DbType.Decimal, BE.nMontoCompromiso);
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