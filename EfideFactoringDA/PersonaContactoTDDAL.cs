using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class PersonaContactoTDDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPersonaContactoTD(PersonaContactoTDBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("PersonaContactoTD_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "contacCargo", DbType.String, BE.contacCargo);
               db.AddInParameter(cmd, "contacArea", DbType.String, BE.contacArea);
               db.AddInParameter(cmd, "contacNombre", DbType.String, BE.contacNombre);
               db.AddInParameter(cmd, "contacAnexo", DbType.String, BE.contacAnexo);
               db.AddInParameter(cmd, "contacEmail1", DbType.String, BE.contacEmail1);
               db.AddInParameter(cmd, "contacEmail2", DbType.String, BE.contacEmail2);
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

