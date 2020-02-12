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
    public class ConfirmacionDetalleDA : IConfirmacionDetalleD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertConfirmacionDetalle(ConfirmacionDetalleBE pConfirmacionDetalleBE)
        {
            string idConfirmacion = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertConfirmacionDetalle))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idConfirmacion", DbType.String, pConfirmacionDetalleBE.idConfirmacion);
                dbAdeudosInversiones.AddInParameter(cmd, "socioBancoID", DbType.String, pConfirmacionDetalleBE.socioBancoID);
                dbAdeudosInversiones.AddOutParameter(cmd, "idConfirmacionDetalle", DbType.String, 10);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if (dbAdeudosInversiones.GetParameterValue(cmd, "idConfirmacionDetalle") != DBNull.Value)
                    idConfirmacion = dbAdeudosInversiones.GetParameterValue(cmd, "idConfirmacionDetalle").ToString();

                return idConfirmacion;
            }
        }
    }
}
