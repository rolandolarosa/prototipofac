using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class ReporteDA
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarReporte(int OPCION, string Usuario, int ConceptoId, string Columna, int ValorMonedaId, int FlgSBS)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("dbo.Rpt_FlujoCaja");
                cmd.CommandTimeout = 0;
                db.AddInParameter(cmd, "OPCION", DbType.Int32, OPCION);
                db.AddInParameter(cmd, "Usuario", DbType.String, Usuario);
                db.AddInParameter(cmd, "ConceptoIdPar", DbType.Int32, ConceptoId);
                db.AddInParameter(cmd, "Columna", DbType.String, Columna);
                db.AddInParameter(cmd, "ValorMonedaId", DbType.Int32, ValorMonedaId);
                db.AddInParameter(cmd, "FlgSBS", DbType.Int32, FlgSBS); 
                dsResult = db.ExecuteDataSet(cmd);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return dsResult;
        }

        public DataSet ProcesarReporteRatioLiquidez(int OPCION, string Usuario, int ConceptoId, string Columna, int ValorMonedaId)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("dbo.Rpt_RatioLiquidez");
                cmd.CommandTimeout = 0;
                db.AddInParameter(cmd, "OPCION", DbType.Int32, OPCION);
                db.AddInParameter(cmd, "Usuario", DbType.String, Usuario);
                db.AddInParameter(cmd, "ConceptoIdPar", DbType.Int32, ConceptoId);
                db.AddInParameter(cmd, "Columna", DbType.String, Columna);
                db.AddInParameter(cmd, "ValorMonedaId", DbType.Int32, ValorMonedaId);
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
