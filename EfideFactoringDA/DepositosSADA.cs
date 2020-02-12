using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class DepositosSADA
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarDepositosSA(DepositosSABE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("DepositosSA_QRY");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                db.AddInParameter(cmd, "valorMonedaID", DbType.String, BE.valorMonedaID);
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
