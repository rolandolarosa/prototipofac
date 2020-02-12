using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class MovimientoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarMovimiento(MovimientoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Movimiento_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdMovimiento", DbType.String, BE.IdMovimiento);
               db.AddInParameter(cmd, "IdTipo_tt", DbType.String, BE.IdTipo_tt);
               db.AddInParameter(cmd, "IdReferencia", DbType.String, BE.IdReferencia);
               db.AddInParameter(cmd, "RazonSocial", DbType.String, BE.RazonSocial);
               db.AddInParameter(cmd, "TipoDocumento", DbType.String, BE.TipoDocumento);
               db.AddInParameter(cmd, "NroDoc", DbType.String, BE.NroDoc);
               if (BE.FechaMovimiento != DateTime.MinValue) { db.AddInParameter(cmd, "FechaMovimiento", DbType.DateTime, BE.FechaMovimiento); }
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "Importe", DbType.Decimal, BE.Importe);
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
               db.AddInParameter(cmd, "Comentario", DbType.String, BE.Comentario);
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

