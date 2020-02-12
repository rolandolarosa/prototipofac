using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class TercerCasoDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarTercercaso(TercercasoBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("Tercercaso_Mnt");
                db.AddInParameter(cmd, "IdTercerCaso", DbType.String, BE.IdTercerCaso);
                db.AddInParameter(cmd, "Ruc", DbType.String, BE.Ruc);
                db.AddInParameter(cmd, "RazonSocial", DbType.String, BE.Razonsocial);
                db.AddInParameter(cmd, "FlgValSocio", DbType.String, BE.FlgValSocio);
                db.AddInParameter(cmd, "Opcion", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "Usuario", DbType.String, BE.USUARIO);
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
