using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class TercerCasoSocioDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarTercerCasoSocio(TercerCasoSocioBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("TercerCasoSocio_Mnt");
                db.AddInParameter(cmd, "IdTercerCaso", DbType.String, BE.IdTercerCaso);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
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
