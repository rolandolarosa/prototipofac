using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class EmpresaTopLineaDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarEmpresaTopLinea(EmpresaTopLineaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("EmpresaTopLinea_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "vRuc", DbType.String, BE.vRuc);
               db.AddInParameter(cmd, "vRazonSocial", DbType.String, BE.vRazonSocial);
               db.AddInParameter(cmd, "nLinea", DbType.Decimal, BE.nLinea);
               db.AddInParameter(cmd, "cEstado", DbType.String, BE.cEstado);
               db.AddInParameter(cmd, "vObservacion", DbType.String, BE.vObservacion);
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

