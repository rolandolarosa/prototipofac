using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class GrupoPagadoraDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGrupoPagadora(GrupoPagadoraBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("GrupoPagadora_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdGrupoPagadora", DbType.String, BE.IdGrupoPagadora);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "vcGrupo", DbType.String, BE.vcGrupo);
               db.AddInParameter(cmd, "IdCargo_tt", DbType.String, BE.IdCargo_tt);
               db.AddInParameter(cmd, "vcContacto", DbType.String, BE.vcContacto);
               db.AddInParameter(cmd, "vcTelefono1", DbType.String, BE.vcTelefono1);
               db.AddInParameter(cmd, "vcTelefono2", DbType.String, BE.vcTelefono2);
               db.AddInParameter(cmd, "vcAnexo", DbType.String, BE.vcAnexo);
               db.AddInParameter(cmd, "vcCelular", DbType.String, BE.vcCelular);
               db.AddInParameter(cmd, "vcEmail", DbType.String, BE.vcEmail);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nLinea", DbType.Decimal, BE.nLinea);
               db.AddInParameter(cmd, "nUtilizado", DbType.Decimal, BE.nUtilizado);
               if (BE.dtFechaVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaVencimiento", DbType.DateTime, BE.dtFechaVencimiento); }
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

