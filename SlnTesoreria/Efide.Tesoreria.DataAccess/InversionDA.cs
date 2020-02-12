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
    public class InversionDA : IInversionD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertInversion(BusinessEntity.InversionBE pInversionBE)
        {
            string idInversion = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertInversion))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "nroCertificado", DbType.String, pInversionBE.nroCertificado);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, pInversionBE.idTipoInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pInversionBE.idTipoEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pInversionBE.idEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pInversionBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pInversionBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pInversionBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Int32, pInversionBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaInicio", DbType.DateTime, pInversionBE.fechaInicio);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaVencimiento", DbType.DateTime, pInversionBE.fechaVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaRescision", DbType.Decimal, pInversionBE.tasaRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "plazoRescision", DbType.Int32, pInversionBE.plazoRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "diasAvisoVencimiento", DbType.Int32, pInversionBE.diasAvisoVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pInversionBE.observaciones);

                dbAdeudosInversiones.AddInParameter(cmd, "IdInversionRenovacion", DbType.String, pInversionBE.IdInversionRenovacion);

                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pInversionBE.idEstado);
                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, pInversionBE.usuCreacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaCreacion", DbType.DateTime, pInversionBE.fechaCreacion);

                dbAdeudosInversiones.AddOutParameter(cmd, "idInversion", DbType.String, 10);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if(dbAdeudosInversiones.GetParameterValue(cmd, "idInversion") != DBNull.Value)
                    idInversion = dbAdeudosInversiones.GetParameterValue(cmd, "idInversion").ToString();

                return idInversion;
            }
        }

        public void updateInversion(BusinessEntity.InversionBE pInversionBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspUpdateInversion))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "nroCertificado", DbType.String, pInversionBE.nroCertificado);
                dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pInversionBE.idInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, pInversionBE.idTipoInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pInversionBE.idTipoEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pInversionBE.idEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pInversionBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pInversionBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pInversionBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Int32, pInversionBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaInicio", DbType.DateTime, pInversionBE.fechaInicio);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaVencimiento", DbType.DateTime, pInversionBE.fechaVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaRescision", DbType.Decimal, pInversionBE.tasaRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "plazoRescision", DbType.Int32, pInversionBE.plazoRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "diasAvisoVencimiento", DbType.Int32, pInversionBE.diasAvisoVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pInversionBE.observaciones);
                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pInversionBE.idEstado);
                dbAdeudosInversiones.AddInParameter(cmd, "usuUltActualizacion", DbType.String, pInversionBE.usuUltActualizacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaUltActualizacion", DbType.DateTime, pInversionBE.fechaUltActualizacion);
                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public void generarCartera(int pAnio, int pMes, string userName)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGeneracionCartera))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "anio", DbType.Int32, pAnio);
                dbAdeudosInversiones.AddInParameter(cmd, "mes", DbType.Int32, pMes);
                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, userName);
                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public List<BusinessEntity.InversionBE> listInversion(BusinessEntity.InversionBE pInversionBE)
        {
            List<BusinessEntity.InversionBE> lstInversionBE = new List<BusinessEntity.InversionBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListInversion))
                {
                    //cmd.CommandTimeout = 0;
                    
                    if(!string.IsNullOrEmpty(pInversionBE.idInversion))
                        dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pInversionBE.idInversion);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, DBNull.Value);

                    if (!string.IsNullOrEmpty(pInversionBE.idTipoInversion))
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, pInversionBE.idTipoInversion);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoInversion", DbType.String, DBNull.Value);

                    if(pInversionBE.idTipoEntidadFinanciera != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pInversionBE.idTipoEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, DBNull.Value);

                    if (!string.IsNullOrEmpty(pInversionBE.idEntidadFinanciera))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pInversionBE.idEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, DBNull.Value);

                    if (pInversionBE.idMoneda != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pInversionBE.idMoneda);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, DBNull.Value);
                    
                    if(pInversionBE.iniciofechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, pInversionBE.iniciofechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, DBNull.Value);

                    if (pInversionBE.finfechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, pInversionBE.finfechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, DBNull.Value);

                    if (pInversionBE.iniciofechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, pInversionBE.iniciofechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (pInversionBE.finfechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, pInversionBE.finfechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (!string.IsNullOrEmpty(pInversionBE.idEstado))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pInversionBE.idEstado);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, DBNull.Value);

                    if (pInversionBE.fechaGlobal != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "fechaGlobal", DbType.DateTime, pInversionBE.fechaGlobal);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "fechaGlobal", DbType.DateTime, DBNull.Value);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstInversionBE.Add(InversionP.getInversion(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstInversionBE;
        }

        public BusinessEntity.InversionBE getInversion(string idInversion, DateTime fechaGlobal)
        {
            BusinessEntity.InversionBE oInversionBE = null;
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetInversion))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, idInversion);
                    dbAdeudosInversiones.AddInParameter(cmd, "fechaGlobal", DbType.DateTime, fechaGlobal);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oInversionBE = InversionP.getInversion(dr);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return oInversionBE;
        }

        public List<BusinessEntity.InversionBE> listCartera(int pAnio, int pMes)
        {
            List<BusinessEntity.InversionBE> lstInversionBE = new List<BusinessEntity.InversionBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListCartera))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "anio", DbType.String, pAnio);
                    dbAdeudosInversiones.AddInParameter(cmd, "mes", DbType.String, pMes);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstInversionBE.Add(InversionP.getProceso(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstInversionBE;
        }

        public List<BusinessEntity.CarteraExportBE> exportCartera(int pAnio, int pMes)
        {
            List<BusinessEntity.CarteraExportBE> lstInversionBE = new List<BusinessEntity.CarteraExportBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetCartera))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "anio", DbType.String, pAnio);
                    dbAdeudosInversiones.AddInParameter(cmd, "mes", DbType.String, pMes);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstInversionBE.Add(InversionP.getCarteraExport(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstInversionBE;
        }
    }
}
