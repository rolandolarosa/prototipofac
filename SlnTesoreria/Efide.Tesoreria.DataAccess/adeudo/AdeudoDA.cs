using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Populate.adeudo;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess.adeudo
{
    public class AdeudoDA : IAdeudoD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertAdeudo(AdeudoBE pAdeudoBE)
        {
            string idAdeudo = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertAdeudo))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "nroCertificado", DbType.String, pAdeudoBE.nroCertificado);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoAdeudo", DbType.String, pAdeudoBE.idTipoAdeudo);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pAdeudoBE.idTipoEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pAdeudoBE.idEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pAdeudoBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pAdeudoBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pAdeudoBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Int32, pAdeudoBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaInicio", DbType.DateTime, pAdeudoBE.fechaInicio);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaVencimiento", DbType.DateTime, pAdeudoBE.fechaVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaRescision", DbType.Decimal, pAdeudoBE.tasaRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "plazoRescision", DbType.Int32, pAdeudoBE.plazoRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "diasAvisoVencimiento", DbType.Int32, pAdeudoBE.diasAvisoVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pAdeudoBE.observaciones);
                dbAdeudosInversiones.AddInParameter(cmd, "IdAdeudoRenovacion", DbType.String, pAdeudoBE.IdAdeudoRenovacion);
                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pAdeudoBE.idEstado);
                dbAdeudosInversiones.AddInParameter(cmd, "usuCreacion", DbType.String, pAdeudoBE.usuCreacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaCreacion", DbType.DateTime, pAdeudoBE.fechaCreacion);

                dbAdeudosInversiones.AddOutParameter(cmd, "idAdeudo", DbType.String, 10);
                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if (dbAdeudosInversiones.GetParameterValue(cmd, "idAdeudo") != DBNull.Value)
                    idAdeudo = dbAdeudosInversiones.GetParameterValue(cmd, "idAdeudo").ToString();

                return idAdeudo;
            }
        }

        public void updateAdeudo(AdeudoBE pAdeudoBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspUpdateAdeudo))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "nroCertificado", DbType.String, pAdeudoBE.nroCertificado);
                dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, pAdeudoBE.idAdeudo);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoAdeudo", DbType.String, pAdeudoBE.idTipoAdeudo);
                dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pAdeudoBE.idTipoEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pAdeudoBE.idEntidadFinanciera);
                dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pAdeudoBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pAdeudoBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "tasa", DbType.Decimal, pAdeudoBE.tasa);
                dbAdeudosInversiones.AddInParameter(cmd, "plazo", DbType.Int32, pAdeudoBE.plazo);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaInicio", DbType.DateTime, pAdeudoBE.fechaInicio);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaVencimiento", DbType.DateTime, pAdeudoBE.fechaVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "tasaRescision", DbType.Decimal, pAdeudoBE.tasaRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "plazoRescision", DbType.Int32, pAdeudoBE.plazoRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "diasAvisoVencimiento", DbType.Int32, pAdeudoBE.diasAvisoVencimiento);
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pAdeudoBE.observaciones);
                dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pAdeudoBE.idEstado);
                dbAdeudosInversiones.AddInParameter(cmd, "usuUltActualizacion", DbType.String, pAdeudoBE.usuUltActualizacion);
                dbAdeudosInversiones.AddInParameter(cmd, "fechaUltActualizacion", DbType.DateTime, pAdeudoBE.fechaUltActualizacion);
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

        public List<AdeudoBE> listAdeudo(AdeudoBE pAdeudoBE)
        {
            List<AdeudoBE> lstAdeudoBE = new List<AdeudoBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListAdeudo))
                {
                    //cmd.CommandTimeout = 0;

                    if (!string.IsNullOrEmpty(pAdeudoBE.idAdeudo))
                        dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, pAdeudoBE.idAdeudo);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, DBNull.Value);

                    if (!string.IsNullOrEmpty(pAdeudoBE.idTipoAdeudo))
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoAdeudo", DbType.String, pAdeudoBE.idTipoAdeudo);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoAdeudo", DbType.String, DBNull.Value);

                    if (pAdeudoBE.idTipoEntidadFinanciera != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, pAdeudoBE.idTipoEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idTipoEntidadFinanciera", DbType.Int32, DBNull.Value);

                    if (!string.IsNullOrEmpty(pAdeudoBE.idEntidadFinanciera))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, pAdeudoBE.idEntidadFinanciera);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEntidadFinanciera", DbType.String, DBNull.Value);

                    if (pAdeudoBE.idMoneda != 0)
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, pAdeudoBE.idMoneda);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idMoneda", DbType.Int32, DBNull.Value);

                    if (pAdeudoBE.iniciofechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, pAdeudoBE.iniciofechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaInicio", DbType.DateTime, DBNull.Value);

                    if (pAdeudoBE.finfechaInicio != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, pAdeudoBE.finfechaInicio);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaInicio", DbType.DateTime, DBNull.Value);

                    if (pAdeudoBE.iniciofechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, pAdeudoBE.iniciofechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "iniciofechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (pAdeudoBE.finfechaVencimiento != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, pAdeudoBE.finfechaVencimiento);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "finfechaVencimiento", DbType.DateTime, DBNull.Value);

                    if (!string.IsNullOrEmpty(pAdeudoBE.idEstado))
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, pAdeudoBE.idEstado);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "idEstado", DbType.String, DBNull.Value);

                    if (pAdeudoBE.fechaGlobal != DateTime.MinValue)
                        dbAdeudosInversiones.AddInParameter(cmd, "fechaGlobal", DbType.DateTime, pAdeudoBE.fechaGlobal);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "fechaGlobal", DbType.DateTime, DBNull.Value);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstAdeudoBE.Add(AdeudoP.getAdeudo(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstAdeudoBE;
        }

        public AdeudoBE getAdeudo(string idAdeudo, DateTime fechaGlobal)
        {
            AdeudoBE oAdeudoBE = null;
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetAdeudo))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, idAdeudo);
                    dbAdeudosInversiones.AddInParameter(cmd, "fechaGlobal", DbType.DateTime, fechaGlobal);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oAdeudoBE = AdeudoP.getAdeudo(dr);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return oAdeudoBE;
        }

        public List<AdeudoBE> listCartera(int pAnio, int pMes)
        {
            List<AdeudoBE> lstAdeudoBE = new List<AdeudoBE>();
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
                        lstAdeudoBE.Add(AdeudoP.getProceso(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstAdeudoBE;
        }

        public List<CarteraExportBE> exportCartera(int pAnio, int pMes)
        {
            List<CarteraExportBE> lstAdeudoBE = new List<CarteraExportBE>();
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
                        lstAdeudoBE.Add(AdeudoP.getCarteraExport(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstAdeudoBE;
        }
    }
}
