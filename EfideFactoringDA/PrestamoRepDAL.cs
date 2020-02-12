using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class PrestamoRepDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ReporteSocio(PrestamoRepBE BE)
        {
            DataSet dsResult;
            try
            {
                //cmd = db.GetStoredProcCommand("PrestamoRep_Mnt");
                cmd = db.GetStoredProcCommand("dbo.PrestamoAll_Rpt");
                cmd.CommandTimeout = 0;
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                if (BE.dtFecRegIni != DateTime.MinValue) { db.AddInParameter(cmd, "fechaRegInicio", DbType.DateTime, BE.dtFecRegIni); }
                if (BE.dtFecRegFin != DateTime.MinValue) { db.AddInParameter(cmd, "fechaRegFin", DbType.DateTime, BE.dtFecRegFin); }
                db.AddInParameter(cmd, "valorMonedaID", DbType.String, BE.MonedaID);
                db.AddInParameter(cmd, "valorPersonaID", DbType.String, BE.TipPerID);
                db.AddInParameter(cmd, "valorDecisionCredID", DbType.Int32, BE.EstatusID);
                db.AddInParameter(cmd, "ClienteID", DbType.String, BE.ClienteID);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "bTasa", DbType.Boolean, BE.bTasa);
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
