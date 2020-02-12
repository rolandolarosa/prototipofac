using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess.inversion
{
    public class ConfirmacionDA : IConfirmacionD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertConfirmacion(ConfirmacionBE pConfirmacionBE)
        {
            string idConfirmacion = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertConfirmacion))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idRelacionado", DbType.String, pConfirmacionBE.idRelacionado);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoConfirmacion", DbType.String, pConfirmacionBE.idTipoConfirmacion);
                dbAdeudosInversiones.AddInParameter(cmd, "importeRescision", DbType.String, pConfirmacionBE.importeRescision);

                dbAdeudosInversiones.AddInParameter(cmd, "interes", DbType.String, pConfirmacionBE.interes);
                dbAdeudosInversiones.AddInParameter(cmd, "importeCobrar", DbType.String, pConfirmacionBE.importeCobrar);

                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, pConfirmacionBE.usuCreacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaCreacion", DbType.DateTime, pConfirmacionBE.fechaCreacion);
                dbAdeudosInversiones.AddOutParameter(cmd, "idConfirmacion", DbType.String, 10);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if (dbAdeudosInversiones.GetParameterValue(cmd, "idConfirmacion") != DBNull.Value)
                    idConfirmacion = dbAdeudosInversiones.GetParameterValue(cmd, "idConfirmacion").ToString();

                return idConfirmacion;
            }
        }
    }
}
