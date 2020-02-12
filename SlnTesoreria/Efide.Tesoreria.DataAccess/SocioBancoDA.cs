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
    public class SocioBancoDA : ISocioBancoD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public List<BusinessEntity.SocioBancoBE> listSocioBanco(BusinessEntity.SocioBancoBE pSocioBancoBE)
        {
            List<BusinessEntity.SocioBancoBE> lstSocioBancoBE = new List<BusinessEntity.SocioBancoBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.spSelectBuscadorSocioBanco))
                {
                    cmd.CommandTimeout = 0;
                    //if (pSocioBancoBE.fechaInicio != DateTime.MinValue)
                    //    dbAdeudosInversiones.AddInParameter(cmd, "fechaInicio", DbType.Date, pSocioBancoBE.fechaInicio);
                    //else
                    //    dbAdeudosInversiones.AddInParameter(cmd, "fechaInicio", DbType.Date, DBNull.Value);

                    //if (pSocioBancoBE.fechaFin != DateTime.MinValue)
                    //    dbAdeudosInversiones.AddInParameter(cmd, "fechaFin", DbType.Date, pSocioBancoBE.fechaFin);
                    //else
                    //    dbAdeudosInversiones.AddInParameter(cmd, "fechaFin", DbType.Date, DBNull.Value);

                    if (!string.IsNullOrEmpty(pSocioBancoBE.entFinancieraID))
                        dbAdeudosInversiones.AddInParameter(cmd, "entFinancieraID", DbType.String, pSocioBancoBE.entFinancieraID);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "entFinancieraID", DbType.String, DBNull.Value);

                    if (!string.IsNullOrEmpty(pSocioBancoBE.valorMonedaID))
                        dbAdeudosInversiones.AddInParameter(cmd, "valorMonedaID", DbType.String, pSocioBancoBE.valorMonedaID);
                    else
                        dbAdeudosInversiones.AddInParameter(cmd, "valorMonedaID", DbType.String, DBNull.Value);

                    //if (pSocioBancoBE.valorTipoOperacionID != 0)
                    //    dbAdeudosInversiones.AddInParameter(cmd, "valorTipoOperacionID", DbType.Int32, pSocioBancoBE.valorTipoOperacionID);
                    //else
                    //    dbAdeudosInversiones.AddInParameter(cmd, "valorTipoOperacionID", DbType.Int32, DBNull.Value);

                    //if (pSocioBancoBE.tipoFecha != 0)
                    //    dbAdeudosInversiones.AddInParameter(cmd, "tipoFecha", DbType.Int32, pSocioBancoBE.tipoFecha);
                    //else
                    //    dbAdeudosInversiones.AddInParameter(cmd, "tipoFecha", DbType.Int32, DBNull.Value);

                    //if (!string.IsNullOrEmpty(pSocioBancoBE.numOperaBanco))
                    //    dbAdeudosInversiones.AddInParameter(cmd, "numOperaBanco", DbType.String, pSocioBancoBE.numOperaBanco);
                    //else
                    //    dbAdeudosInversiones.AddInParameter(cmd, "numOperaBanco", DbType.String, DBNull.Value);

                    ////if (pSocioBancoBE.sbVigente == null)
                    //dbAdeudosInversiones.AddInParameter(cmd, "sbVigente", DbType.Boolean, pSocioBancoBE.sbVigente);
                    //else
                    //dbAdeudosInversiones.AddInParameter(cmd, "sbVigente", DbType.Boolean, DBNull.Value);

                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstSocioBancoBE.Add(SocioBancoP.getSocioBanco(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstSocioBancoBE;
        }

        public void insertMovimintoSocio(BusinessEntity.RescisionBE pRescisionBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspMovimientoBancos))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "socioBancoID", DbType.String, pRescisionBE.socioBancoID);
                dbAdeudosInversiones.AddInParameter(cmd, "importe", DbType.Decimal, pRescisionBE.importe);
                dbAdeudosInversiones.AddInParameter(cmd, "dtRegistro", DbType.Date, pRescisionBE.fechaRescision);
                dbAdeudosInversiones.AddInParameter(cmd, "valMonID", DbType.Decimal, pRescisionBE.idMoneda);
                dbAdeudosInversiones.AddInParameter(cmd, "Glosa", DbType.String, pRescisionBE.Glosa);
                dbAdeudosInversiones.AddInParameter(cmd, "gSesionID", DbType.String, pRescisionBE.gSesionID);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }
    }
}
