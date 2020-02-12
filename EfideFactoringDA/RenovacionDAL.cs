using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class RenovacionDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarRenovacion(RenovacionBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("Renovacion_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "gSesionID", DbType.String, BE.gSesionID);
                db.AddInParameter(cmd, "gPlazaID", DbType.String, BE.gPlazaID);
                if (BE.gFechaOp != DateTime.MinValue || BE.gFechaOp != null) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, BE.gFechaOp); }
                db.AddInParameter(cmd, "IdRenovacion", DbType.String, BE.IdRenovacion);
                if (BE.dtRenovacion != DateTime.MinValue) { db.AddInParameter(cmd, "dtRenovacion", DbType.DateTime, BE.dtRenovacion); }
                if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
                db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
                db.AddInParameter(cmd, "TipoRenovacion", DbType.String, BE.TipoRenovacion);
                db.AddInParameter(cmd, "CtasBancariasID", DbType.String, BE.CtasBancariasID);
                db.AddInParameter(cmd, "IdOperacion_tt", DbType.String, BE.IdOperacion_tt);
                db.AddInParameter(cmd, "IdTipoAbono_tt", DbType.String, BE.IdTipoAbono_tt);
                db.AddInParameter(cmd, "socioBancoID", DbType.String, BE.socioBancoID);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
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
