using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class RobotCobranzasDA
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        Database dbFENIXDB = DatabaseFactory.CreateDatabase("ConexionStrDBFENIXDB");

        public DataSet ProcesarRobotCobranzas(RobotCobranzasBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("RobotCobranzas_Evento01");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "Usuario", DbType.String, BE.Usuario);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "Dias", DbType.Int32, BE.Dias);
                dsResult = db.ExecuteDataSet(cmd);
            }
            catch (Exception ex)
            {   
                throw new Exception(ex.Message);
            }
            return dsResult;
        }

        public DataSet ProcesarRobotCobranzas_Correo(RobotCobranzasBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("RobotCobranzas_Correo");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "Usuario", DbType.String, BE.Usuario);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                db.AddInParameter(cmd, "NombreDocumento", DbType.String, BE.NombreDocumento);
                db.AddInParameter(cmd, "Status", DbType.String, BE.Status); 
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
