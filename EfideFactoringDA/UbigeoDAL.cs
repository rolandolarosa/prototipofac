using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class UbigeoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarUbigeo(UbigeoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Ubigeo_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdUbigeo", DbType.String, BE.IdUbigeo);
               db.AddInParameter(cmd, "ubiDepartamento", DbType.String, BE.ubiDepartamento);
               db.AddInParameter(cmd, "ubiProvincia", DbType.String, BE.ubiProvincia);
               db.AddInParameter(cmd, "ubiDistrito", DbType.String, BE.ubiDistrito);
               db.AddInParameter(cmd, "ubiNombre", DbType.String, BE.ubiNombre);
               db.AddInParameter(cmd, "ubiAux", DbType.String, BE.ubiAux);
               db.AddInParameter(cmd, "ubiEstado", DbType.Boolean, BE.ubiEstado);
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

