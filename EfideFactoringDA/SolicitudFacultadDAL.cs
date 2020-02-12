using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudFacultadDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitudFacultad(SolicitudFacultadBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SolicitudFacultad_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               db.AddInParameter(cmd, "IdTipo_tt", DbType.String, BE.IdTipo_tt);
               db.AddInParameter(cmd, "IdItem", DbType.String, BE.IdItem);
               db.AddInParameter(cmd, "IdFacultad_tt", DbType.String, BE.IdFacultad_tt);
               db.AddInParameter(cmd, "IdRepresentanteF1", DbType.String, BE.IdRepresentanteF1);
               db.AddInParameter(cmd, "IdRepresentanteF2", DbType.String, BE.IdRepresentanteF2);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nMontoMaximo", DbType.Decimal, BE.nMontoMaximo);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
               db.AddInParameter(cmd, "bFirma", DbType.Boolean, BE.bFirma); 
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

