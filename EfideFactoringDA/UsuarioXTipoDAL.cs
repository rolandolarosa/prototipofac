using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class UsuarioXTipoDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarUsuarioXTipo(UsuarioXTipoBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("UsuarioXTipo_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION); 
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "UsuarioID", DbType.String, BE.UsuarioID);
                db.AddInParameter(cmd, "Table_Id_Tipo", DbType.String, BE.Table_Id_Tipo);
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
