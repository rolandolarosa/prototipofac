using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudDocumentoDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitudDocumento(SolicitudDocumentoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SolicitudDocumento_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
               db.AddInParameter(cmd, "iPlazo", DbType.Int32, BE.iPlazo);
               db.AddInParameter(cmd, "nTEA", DbType.Decimal, BE.nTEA);
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

