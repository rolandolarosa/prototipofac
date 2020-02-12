using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.Populate.inversion
{
    public class EntidadesFinancierasP
    {
        public static EntidadesFinancierasBE obtenerEntidadesFinancieras(IDataReader dr)
        {
            EntidadesFinancierasBE oEntidadesFinancierasBE = new EntidadesFinancierasBE();

            if (!dr.IsDBNull(dr.GetOrdinal("entFinancieraID")))
                oEntidadesFinancierasBE.entFinancieraID = dr.GetString(dr.GetOrdinal("entFinancieraID"));

            if (!dr.IsDBNull(dr.GetOrdinal("codigoEntFin")))
                oEntidadesFinancierasBE.codigoEntFin = dr.GetString(dr.GetOrdinal("codigoEntFin"));

            if (!dr.IsDBNull(dr.GetOrdinal("valorTipoEntFinancID")))
                oEntidadesFinancierasBE.valorTipoEntFinancID = dr.GetDecimal(dr.GetOrdinal("valorTipoEntFinancID"));

            if (!dr.IsDBNull(dr.GetOrdinal("empresaID")))
                oEntidadesFinancierasBE.empresaID = dr.GetString(dr.GetOrdinal("empresaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoEntFin")))
                oEntidadesFinancierasBE.nomTipoEntFin = dr.GetString(dr.GetOrdinal("nomTipoEntFin"));

            if (!dr.IsDBNull(dr.GetOrdinal("emprRazonSocial")))
                oEntidadesFinancierasBE.emprRazonSocial = dr.GetString(dr.GetOrdinal("emprRazonSocial"));

            return oEntidadesFinancierasBE;
        }
    }
}
