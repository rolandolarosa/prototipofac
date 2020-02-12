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
    public class RenovacionDA : IRenovacionD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertRenovacion(BusinessEntity.RenovacionBE pRenovacionBE)
        {
            string idRenovacion = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertRenovacion))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pRenovacionBE.idInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pRenovacionBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Decimal, pRenovacionBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoRenovacion", DbType.String, pRenovacionBE.idTipoRenovacion);
                dbAdeudosInversiones.AddInParameter(cmd, "porcentaje", DbType.Decimal, pRenovacionBE.porcenImporte);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaRescision", DbType.Decimal, pRenovacionBE.tasaRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "plazoMinimo", DbType.Decimal, pRenovacionBE.plazoRescision);

                dbAdeudosInversiones.AddInParameter(cmd, "fechaRenovacion", DbType.DateTime, pRenovacionBE.fechaRenovacion); 

                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pRenovacionBE.idEstado);
                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, pRenovacionBE.usuCreacion);
                dbAdeudosInversiones.AddOutParameter(cmd, "idRenovacion", DbType.String, 10);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if (dbAdeudosInversiones.GetParameterValue(cmd, "idRenovacion") != DBNull.Value)
                    idRenovacion = dbAdeudosInversiones.GetParameterValue(cmd, "idRenovacion").ToString();

                return idRenovacion;
            }
        }

        public void updateRenovacion(BusinessEntity.RenovacionBE pRenovacionBE)
        {
            string idRenovacion = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspUpdateRenovacion))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idRenovacion", DbType.String, pRenovacionBE.idRenovacion);
                //dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pRenovacionBE.idInversion);
                //dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pRenovacionBE.tasa);
                //dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Decimal, pRenovacionBE.plazo);
                //dbAdeudosInversiones.AddInParameter(cmd, "idTipoRenovacion", DbType.String, pRenovacionBE.importe);
                //dbAdeudosInversiones.AddInParameter(cmd, "porcentaje", DbType.Decimal, pRenovacionBE.interes);
                //dbAdeudosInversiones.AddInParameter(cmd, "tasaRescision", DbType.Decimal, pRenovacionBE.ITF);
                //dbAdeudosInversiones.AddInParameter(cmd, "plazoMinimo", DbType.Decimal, pRenovacionBE.total);
                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pRenovacionBE.idEstado);
                //dbAdeudosInversiones.AddInParameter(cmd, "fechaRenovacion", DbType.DateTime, pRenovacionBE.fechaRenovacion);
                dbAdeudosInversiones.AddInParameter(cmd, "usuUltActualizacion", DbType.String, pRenovacionBE.usuUltActualizacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaUltActualizacion", DbType.DateTime, pRenovacionBE.fechaUltActualizacion);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public List<BusinessEntity.RenovacionBE> listRenovacion(BusinessEntity.RenovacionBE pRenovacionBE)
        {
            List<BusinessEntity.RenovacionBE> lstRenovacionBE = new List<BusinessEntity.RenovacionBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListRenovacion))
                {
                    //cmd.CommandTimeout = 0;

                    if (!string.IsNullOrEmpty(pRenovacionBE.idRenovacion))
                        dbAdeudosInversiones.AddInParameter(cmd, "idRenovacion", DbType.String, pRenovacionBE.idRenovacion);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idRenovacion", DbType.String, DBNull.Value);

                    if (!string.IsNullOrEmpty(pRenovacionBE.oInversionBE.idTipoInversion))
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, pRenovacionBE.oInversionBE.idTipoInversion);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, DBNull.Value);

                    if (pRenovacionBE.oInversionBE.idTipoEntidadFinanciera != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pRenovacionBE.oInversionBE.idTipoEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, DBNull.Value);

                    if (!string.IsNullOrEmpty(pRenovacionBE.oInversionBE.idEntidadFinanciera))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pRenovacionBE.oInversionBE.idEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, DBNull.Value);

                    if (pRenovacionBE.oInversionBE.idMoneda != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pRenovacionBE.oInversionBE.idMoneda);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, DBNull.Value);

                    if (pRenovacionBE.iniciofechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, pRenovacionBE.iniciofechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, DBNull.Value);

                    if (pRenovacionBE.finfechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, pRenovacionBE.finfechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, DBNull.Value);

                    if (pRenovacionBE.iniciofechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, pRenovacionBE.iniciofechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (pRenovacionBE.finfechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, pRenovacionBE.finfechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (!string.IsNullOrEmpty(pRenovacionBE.idEstado))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pRenovacionBE.idEstado);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, DBNull.Value);

                    if (pRenovacionBE.idTipoRenovacion > 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoRenovacion", DbType.String, pRenovacionBE.idTipoRenovacion);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoRenovacion", DbType.String, DBNull.Value);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstRenovacionBE.Add(RenovacionP.getRenovacion(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstRenovacionBE;
        }

        public BusinessEntity.RenovacionBE getRenovacion(string idRenovacion)
        {
            BusinessEntity.RenovacionBE oRenovacionBE = null;
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetRenovacion))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idRenovacion", DbType.String, idRenovacion);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oRenovacionBE = RenovacionP.getRenovacion(dr);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return oRenovacionBE;
        }
    }
}
