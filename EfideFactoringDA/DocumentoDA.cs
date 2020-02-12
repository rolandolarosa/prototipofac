using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class DocumentoDA
    {

        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarDocumento(DocumentoBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("Documento_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
                db.AddInParameter(cmd, "vDocumento", DbType.String, BE.vDocumento);
                db.AddInParameter(cmd, "cAbreviatura", DbType.String, BE.cAbreviatura);
                db.AddInParameter(cmd, "vMascara", DbType.String, BE.vMascara);
                db.AddInParameter(cmd, "bTituloValor", DbType.Boolean, BE.bTituloValor);
                db.AddInParameter(cmd, "FlgFisicoElectronico", DbType.String, BE.FlgFisicoElectronico);
                db.AddInParameter(cmd, "FlgImportePago", DbType.String, BE.FlgImportePago); 
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
