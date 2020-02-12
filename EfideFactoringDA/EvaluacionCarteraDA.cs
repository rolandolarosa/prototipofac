using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class EvaluacionCarteraDA
    {
        IDataReader dr = null;
        EvaluacionCarteraBE oEvaluacionCarteraBE = null;
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBFENIXDB");
        DbCommand cmd = null;

        public EvaluacionCarteraBE ObtenerEvaluacionCartera(string creditoID, string anio, string mes)
        {
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand("Cartera.uspGetEvaluacionCartera"))
                {
                    cmd.CommandTimeout = 0;
                    db.AddInParameter(cmd, "p_creditoID", DbType.String, creditoID);
                    db.AddInParameter(cmd, "p_anio", DbType.Int32, Convert.ToInt32(anio));
                    db.AddInParameter(cmd, "p_mes", DbType.Int32, Convert.ToInt32(mes));
                    dr = db.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oEvaluacionCarteraBE = new EvaluacionCarteraBE();

                        if (!dr.IsDBNull(dr.GetOrdinal("RazonSocial")))
                            oEvaluacionCarteraBE.RazonSocial = dr.GetString(dr.GetOrdinal("RazonSocial"));

                        if (!dr.IsDBNull(dr.GetOrdinal("NroCredito")))
                            oEvaluacionCarteraBE.NroCredito = dr.GetString(dr.GetOrdinal("NroCredito"));

                        if (!dr.IsDBNull(dr.GetOrdinal("Categoria")))
                            oEvaluacionCarteraBE.Categoria = dr.GetString(dr.GetOrdinal("Categoria"));

                        if (!dr.IsDBNull(dr.GetOrdinal("Producto")))
                            oEvaluacionCarteraBE.Producto = dr.GetString(dr.GetOrdinal("Producto"));

                        if (!dr.IsDBNull(dr.GetOrdinal("ImporteOriginal")))
                            oEvaluacionCarteraBE.ImporteOriginal = dr.GetDecimal(dr.GetOrdinal("ImporteOriginal"));

                        if (!dr.IsDBNull(dr.GetOrdinal("evaCarteraVigente")))
                            oEvaluacionCarteraBE.evaCarteraVigente = dr.GetDecimal(dr.GetOrdinal("evaCarteraVigente"));

                        if (!dr.IsDBNull(dr.GetOrdinal("evaCarteraVencida")))
                            oEvaluacionCarteraBE.evaCarteraVencida = dr.GetDecimal(dr.GetOrdinal("evaCarteraVencida"));

                        if (!dr.IsDBNull(dr.GetOrdinal("Calificacion")))
                            oEvaluacionCarteraBE.Calificacion = dr.GetString(dr.GetOrdinal("Calificacion"));

                        if (!dr.IsDBNull(dr.GetOrdinal("PorcCalificacion")))
                            oEvaluacionCarteraBE.PorcCalificacion = dr.GetDecimal(dr.GetOrdinal("PorcCalificacion"));

                        if (!dr.IsDBNull(dr.GetOrdinal("provEspecifica")))
                            oEvaluacionCarteraBE.ProvisionEspecifica = dr.GetDecimal(dr.GetOrdinal("provEspecifica"));

                        if (!dr.IsDBNull(dr.GetOrdinal("indAltoRiesgo")))
                            oEvaluacionCarteraBE.indAltoRiesgo = dr.GetBoolean(dr.GetOrdinal("indAltoRiesgo"));
                    }
                }

                return oEvaluacionCarteraBE;
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }
        }

        public void UpdateEvaluacionCartera(EvaluacionCarteraBE pEvaluacionCarteraBE)
        {
            try
            {
                using (DbCommand cmd = db.GetStoredProcCommand("Cartera.uspUpdateEvaluacionCartera"))
                {
                    cmd.CommandTimeout = 0;
                    db.AddInParameter(cmd, "p_creditoID", DbType.String, pEvaluacionCarteraBE.CreditoID);
                    db.AddInParameter(cmd, "p_anio", DbType.Int32, Convert.ToInt32(pEvaluacionCarteraBE.anio));
                    db.AddInParameter(cmd, "p_mes", DbType.Int32, Convert.ToInt32(pEvaluacionCarteraBE.mes));

                    db.AddInParameter(cmd, "evaCarteraVigente", DbType.Decimal, Convert.ToDecimal(pEvaluacionCarteraBE.evaCarteraVigente));
                    db.AddInParameter(cmd, "evaCarteraVencida", DbType.Decimal, Convert.ToDecimal(pEvaluacionCarteraBE.evaCarteraVencida));
                    db.AddInParameter(cmd, "provEspecifica", DbType.Decimal, Convert.ToDecimal(pEvaluacionCarteraBE.ProvisionEspecifica));
                    db.AddInParameter(cmd, "indAltoRiesgo", DbType.Decimal, Convert.ToDecimal(pEvaluacionCarteraBE.indAltoRiesgo)); 

                    db.ExecuteNonQuery(cmd);
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
