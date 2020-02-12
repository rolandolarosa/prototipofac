using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class PagadoraObservacionDAL
    {

        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarPagadoraObservacion(PagadoraObservacionBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("PagadoraObservacion_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdObservacion", DbType.String, BE.IdObservacion);
                db.AddInParameter(cmd, "vcComentario", DbType.String, BE.vcComentario);
                db.AddInParameter(cmd, "vcUsuario", DbType.String, BE.vcUsuario);
                if (BE.dtFecha != DateTime.MinValue) { db.AddInParameter(cmd, "dtFecha", DbType.DateTime, BE.dtFecha); }
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
