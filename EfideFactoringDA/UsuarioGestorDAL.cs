using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class UsuarioGestorDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarUsuarioGestor(UsuarioGestorBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("UsuarioGestor_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "UsuarioID", DbType.String, BE.UsuarioID);
                db.AddInParameter(cmd, "IdGestor", DbType.String, BE.IdGestor);
                db.AddInParameter(cmd, "IdTipoGestor_tt", DbType.String, BE.IdTipoGestor_tt);
                db.AddInParameter(cmd, "IndPrint", DbType.Int32, BE.IndPrint);
                db.AddInParameter(cmd, "bAdmLineaPag", DbType.Boolean, BE.bAdmLineaPag);
                db.AddInParameter(cmd, "bAdmBloqueoPag", DbType.Boolean, BE.bAdmBloqueoPag);
                db.AddInParameter(cmd, "bAdmContactos", DbType.Boolean, BE.bAdmContactos);
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
