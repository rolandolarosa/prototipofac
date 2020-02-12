using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class RenovacionPagoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarRenovacionPago(RenovacionPagoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("RenovacionPago_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdRenovacion", DbType.String, BE.IdRenovacion);
               db.AddInParameter(cmd, "socioBancoID", DbType.String, BE.socioBancoID);
               db.AddInParameter(cmd, "ctasBancariaID", DbType.String, BE.ctasBancariaID);
               db.AddInParameter(cmd, "ctasBanNumCta", DbType.String, BE.ctasBanNumCta);
               db.AddInParameter(cmd, "nTotal", DbType.Decimal, BE.nTotal);
               db.AddInParameter(cmd, "IdOperacion_tt", DbType.String, BE.IdOperacion_tt);
               db.AddInParameter(cmd, "IdTipoAbono_tt", DbType.String, BE.IdTipoAbono_tt);
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

