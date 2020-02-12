using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class UsuarioDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarUsuario(UsuarioBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("Usuario_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "usuarioID", DbType.String, BE.usuarioID);
                db.AddInParameter(cmd, "usuContrasena", DbType.String, BE.usuContrasena);
                db.AddInParameter(cmd, "gFecha", DbType.DateTime, BE.pfecha);
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
