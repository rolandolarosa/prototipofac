using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class TarifarioDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarTarifario(TarifarioBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Tarifario_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdTarifario", DbType.String, BE.IdTarifario);
               db.AddInParameter(cmd, "tipCxcID", DbType.String, BE.tipCxcID);
               db.AddInParameter(cmd, "IdTipoCalculo_tt", DbType.String, BE.IdTipoCalculo_tt);
               db.AddInParameter(cmd, "IdCalculo_tt", DbType.String, BE.IdCalculo_tt);
               db.AddInParameter(cmd, "PorMonto", DbType.Decimal, BE.PorMonto);
               db.AddInParameter(cmd, "PorConcepto_tt", DbType.String, BE.PorConcepto_tt);
               db.AddInParameter(cmd, "Monto", DbType.Decimal, BE.Monto);
               db.AddInParameter(cmd, "IdFrecuencia_tt", DbType.String, BE.IdFrecuencia_tt);
               db.AddInParameter(cmd, "bTransferencia", DbType.Boolean, BE.bTransferencia);
               db.AddInParameter(cmd, "tipCxcNombre", DbType.String, BE.tipCxcNombre);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdReferencia", DbType.String, BE.IdReferencia);
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

