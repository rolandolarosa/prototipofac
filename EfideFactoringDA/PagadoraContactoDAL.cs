using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class PagadoraContactoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPagadoraContacto(PagadoraContactoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("PagadoraContacto_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdItemCtc", DbType.String, BE.IdItemCtc);
               db.AddInParameter(cmd, "IdCargo_tt", DbType.String, BE.IdCargo_tt);
               db.AddInParameter(cmd, "vcContacto", DbType.String, BE.vcContacto);
               db.AddInParameter(cmd, "vcTelefono1", DbType.String, BE.vcTelefono1);
               db.AddInParameter(cmd, "vcTelefono2", DbType.String, BE.vcTelefono2);
               db.AddInParameter(cmd, "vcAnexo", DbType.String, BE.vcAnexo);
               db.AddInParameter(cmd, "vcCelular", DbType.String, BE.vcCelular);
               db.AddInParameter(cmd, "vcEmail", DbType.String, BE.vcEmail);
               if (BE.dtCumpleano != DateTime.MinValue) { db.AddInParameter(cmd, "dtCumpleano", DbType.DateTime, BE.dtCumpleano); }
               db.AddInParameter(cmd, "bEntregaLetra", DbType.Boolean, BE.bEntregaLetra);
               db.AddInParameter(cmd, "bEnvioDocumentacion", DbType.Boolean, BE.bEnvioDocumentacion);
               db.AddInParameter(cmd, "bEnvioCobranza", DbType.Boolean, BE.bEnvioCobranza);
               db.AddInParameter(cmd, "bFinanzas", DbType.Boolean, BE.bFinanzas);
               db.AddInParameter(cmd, "bRealizarLLamada", DbType.Boolean, BE.bRealizarLLamada);
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

