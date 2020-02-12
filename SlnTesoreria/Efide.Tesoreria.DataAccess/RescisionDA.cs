using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess
{
    public class RescisionDA : IRescisionD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertRescision(BusinessEntity.RescisionBE pRescisionBE)
        {
            string idRescision = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertRescision))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pRescisionBE.idInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pRescisionBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Decimal, pRescisionBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pRescisionBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "interes", DbType.Decimal, pRescisionBE.interes);
                dbAdeudosInversiones.AddInParameter(cmd, "itf", DbType.Decimal, pRescisionBE.ITF);
                dbAdeudosInversiones.AddInParameter(cmd, "total", DbType.Decimal, pRescisionBE.total);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaCerrada", DbType.Decimal, pRescisionBE.tasaCerrada);
                dbAdeudosInversiones.AddInParameter(cmd, "interesCerrado", DbType.Decimal, pRescisionBE.interesCerrado);
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pRescisionBE.observaciones);
                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pRescisionBE.idEstado);

                dbAdeudosInversiones.AddInParameter(cmd, "diferencia", DbType.Decimal, pRescisionBE.diferencia);
                dbAdeudosInversiones.AddInParameter(cmd, "diasTranscurridos", DbType.Int32, pRescisionBE.diasTranscurridos);

                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, pRescisionBE.usuCreacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaCrecion", DbType.DateTime, pRescisionBE.fechaCrecion);
                dbAdeudosInversiones.AddOutParameter(cmd, "idRescision", DbType.String, 10);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if (dbAdeudosInversiones.GetParameterValue(cmd, "idRescision") != DBNull.Value)
                    idRescision = dbAdeudosInversiones.GetParameterValue(cmd, "idRescision").ToString();

                return idRescision;
            }
        }

        public void updateRescision(BusinessEntity.RescisionBE pRescisionBE)
        {
            string idRescision = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspUpdateRescision))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idRescision", DbType.String, pRescisionBE.idRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pRescisionBE.idInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pRescisionBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Decimal, pRescisionBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pRescisionBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "interes", DbType.Decimal, pRescisionBE.interes);
                dbAdeudosInversiones.AddInParameter(cmd, "itf", DbType.Decimal, pRescisionBE.ITF);
                dbAdeudosInversiones.AddInParameter(cmd, "total", DbType.Decimal, pRescisionBE.total);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaCerrada", DbType.Decimal, pRescisionBE.tasaCerrada);
                dbAdeudosInversiones.AddInParameter(cmd, "interesCerrado", DbType.Decimal, pRescisionBE.interesCerrado);
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pRescisionBE.observaciones);
                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pRescisionBE.idEstado);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaRescision", DbType.DateTime, pRescisionBE.fechaRescision);

                dbAdeudosInversiones.AddInParameter(cmd, "diferencia", DbType.Decimal, pRescisionBE.diferencia);
                dbAdeudosInversiones.AddInParameter(cmd, "diasTranscurridos", DbType.Int32, pRescisionBE.diasTranscurridos);

                dbAdeudosInversiones.AddInParameter(cmd, "usuUltActualizacion", DbType.String, pRescisionBE.usuUltActualizacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaUltActualizacion", DbType.DateTime, pRescisionBE.fechaUltActualizacion);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public List<BusinessEntity.RescisionBE> listRescision(BusinessEntity.RescisionBE pRescisionBE)
        {
            List<BusinessEntity.RescisionBE> lstRescisionBE = new List<BusinessEntity.RescisionBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListRescision))
                {
                    //cmd.CommandTimeout = 0;

                    if (!string.IsNullOrEmpty(pRescisionBE.idRescision))
                        dbAdeudosInversiones.AddInParameter(cmd, "idRescision", DbType.String, pRescisionBE.idRescision);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idRescision", DbType.String, DBNull.Value);

                    if (!string.IsNullOrEmpty(pRescisionBE.oInversionBE.idTipoInversion))
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, pRescisionBE.oInversionBE.idTipoInversion);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, DBNull.Value);

                    if (pRescisionBE.oInversionBE.idTipoEntidadFinanciera != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pRescisionBE.oInversionBE.idTipoEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, DBNull.Value);

                    if (!string.IsNullOrEmpty(pRescisionBE.oInversionBE.idEntidadFinanciera))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pRescisionBE.oInversionBE.idEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, DBNull.Value);

                    if (pRescisionBE.oInversionBE.idMoneda != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pRescisionBE.oInversionBE.idMoneda);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, DBNull.Value);

                    if (pRescisionBE.iniciofechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, pRescisionBE.iniciofechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, DBNull.Value);

                    if (pRescisionBE.finfechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, pRescisionBE.finfechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, DBNull.Value);

                    if (pRescisionBE.iniciofechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, pRescisionBE.iniciofechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (pRescisionBE.finfechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, pRescisionBE.finfechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (!string.IsNullOrEmpty(pRescisionBE.idEstado))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pRescisionBE.idEstado);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, DBNull.Value);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstRescisionBE.Add(RescisionP.getRescision(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstRescisionBE;
        }

        public BusinessEntity.RescisionBE getRescision(string idRescision)
        {
            BusinessEntity.RescisionBE oRescisionBE = null;
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetRescision))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idRescision", DbType.String, idRescision);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oRescisionBE = RescisionP.getRescision(dr);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return oRescisionBE;
        }
    }
}
