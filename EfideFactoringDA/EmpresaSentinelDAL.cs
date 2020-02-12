using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class EmpresaSentinelDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarEmpresaSentinel(EmpresaSentinelBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("EmpresaSentinel_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Periodo", DbType.String, BE.Periodo);
               db.AddInParameter(cmd, "RUC", DbType.String, BE.RUC);
               db.AddInParameter(cmd, "CalificacionNormal", DbType.String, BE.CalificacionNormal);
               db.AddInParameter(cmd, "DeudaDirectoIndirecto", DbType.String, BE.DeudaDirectoIndirecto);
               db.AddInParameter(cmd, "RangoDeuda", DbType.Decimal, BE.RangoDeuda);
               //db.AddInParameter(cmd, "Operador", DbType.String, BE.Operador);
               //db.AddInParameter(cmd, "RangoDeudaB", DbType.Decimal, BE.RangoDeudaB);
               db.AddInParameter(cmd, "DeudaCoativa", DbType.String, BE.DeudaCoativa);
               db.AddInParameter(cmd, "ProtestoNoRegularisado", DbType.String, BE.ProtestoNoRegularisado);
               db.AddInParameter(cmd, "Creditos", DbType.String, BE.Creditos);
               db.AddInParameter(cmd, "Grupo", DbType.String, BE.Grupo);
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

