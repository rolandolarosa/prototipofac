using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;


namespace EfideFactoringDA
{
    public class CuentaSocioDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;
        
        public DataSet BuscarCuentaSocio(CuentaSocioBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("BuscarCuentaSocio");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "valorTipoCuentaID", DbType.Decimal, BE.valorTipoCuentaID);
                db.AddInParameter(cmd, "valorTipoCuentaAhoID", DbType.Decimal, BE.valorTipoCuentaAhoID);
                db.AddInParameter(cmd, "razonSocial", DbType.String, BE.razonSocial);
                db.AddInParameter(cmd, "numDoc", DbType.String, BE.numDoc);
                db.AddInParameter(cmd, "comunTipoCliID", DbType.String, BE.comunTipoCliID);
                db.AddInParameter(cmd, "clienteID", DbType.String, BE.clienteID);                
                db.AddInParameter(cmd, "numCuentaID", DbType.String, BE.numCuentaID);
                db.AddInParameter(cmd, "productoID", DbType.String, BE.productoID);
                db.AddInParameter(cmd, "valorMonedaID", DbType.Decimal, BE.valorMonedaID);
                
                
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
