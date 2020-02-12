using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class SocioLineaDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSocioLinea(SocioLineaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SocioLinea_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "RUCSocio", DbType.String, BE.RUCSocio);
               db.AddInParameter(cmd, "IdSocio_Dsc", DbType.String, BE.IdSocio_Dsc);
               db.AddInParameter(cmd, "IdTipoLinea_tt", DbType.String, BE.IdTipoLinea_tt);
               if (BE.dtRegistro != DateTime.MinValue){ db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro);}
               if (BE.dtVencimiento != DateTime.MinValue){ db.AddInParameter(cmd, "dtVencimiento", DbType.DateTime, BE.dtVencimiento);}
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nImporte", DbType.Decimal, BE.nImporte);
               db.AddInParameter(cmd, "nUtilizado", DbType.Decimal, BE.nUtilizado);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdPagadora_Dsc", DbType.String, BE.IdPagadora_Dsc);
               db.AddInParameter(cmd, "FlgVerPagadoras", DbType.Int32, BE.FlgVerPagadoras);
               db.AddInParameter(cmd, "FlgOrigen", DbType.Int32, BE.FlgOrigen);
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

