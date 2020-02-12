using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class SocioConfiguracionECDA
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        Database dbFENIXDB = DatabaseFactory.CreateDatabase("ConexionStrDBFENIXDB");

        public DataSet ProcesarSocioConfiguracionEC(SocioConfiguracionECBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("SocioConfiguracionEC_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                db.AddInParameter(cmd, "IdSocio_Dsc", DbType.String, BE.IdSocio_Dsc);
                if (BE.dtInicioProceso != DateTime.MinValue) { db.AddInParameter(cmd, "dtInicioProceso", DbType.DateTime, BE.dtInicioProceso); }
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
