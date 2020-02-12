using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.Populate.adeudo
{
    public class RenovacionP
    {
        public static RenovacionBE getRenovacion(IDataReader dr)
        {
            RenovacionBE oRenovacionBE = new RenovacionBE();
            oRenovacionBE.oAdeudoBE = new AdeudoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idRenovacion")))
                oRenovacionBE.idRenovacion = dr.GetString(dr.GetOrdinal("idRenovacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("idAdeudo")))
                oRenovacionBE.idAdeudo = dr.GetString(dr.GetOrdinal("idAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoAdeudo")))
                oRenovacionBE.idTipoAdeudo = dr.GetString(dr.GetOrdinal("idTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoAdeudo")))
                oRenovacionBE.nomTipoAdeudo = dr.GetString(dr.GetOrdinal("nomTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEntidadFinanciera")))
                oRenovacionBE.idEntidadFinanciera = dr.GetString(dr.GetOrdinal("idEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEntidadFinanciera")))
                oRenovacionBE.nomEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoEntidadFinanciera")))
                oRenovacionBE.idTipoEntidadFinanciera = dr.GetDecimal(dr.GetOrdinal("idTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idMoneda")))
                oRenovacionBE.idMoneda = dr.GetDecimal(dr.GetOrdinal("idMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomMoneda")))
                oRenovacionBE.nomMoneda = dr.GetString(dr.GetOrdinal("nomMoneda"));


            if (!dr.IsDBNull(dr.GetOrdinal("tasa")))
                oRenovacionBE.tasa = dr.GetDecimal(dr.GetOrdinal("tasa"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazoRescision")))
                oRenovacionBE.plazo = dr.GetInt32(dr.GetOrdinal("plazoRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasaRescision")))
                oRenovacionBE.tasaRescision = dr.GetDecimal(dr.GetOrdinal("tasaRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazoMinimo")))
                oRenovacionBE.plazoRescision = dr.GetInt32(dr.GetOrdinal("plazoMinimo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoRenovacion")))
                oRenovacionBE.nomTipoRenovacion = dr.GetString(dr.GetOrdinal("nomTipoRenovacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoRenovacion")))
                oRenovacionBE.idTipoRenovacion = Convert.ToInt32(dr.GetString(dr.GetOrdinal("idTipoRenovacion")));


            if (!dr.IsDBNull(dr.GetOrdinal("importe")))
                oRenovacionBE.importe = dr.GetDecimal(dr.GetOrdinal("importe"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEstado")))
                oRenovacionBE.idEstado = dr.GetString(dr.GetOrdinal("idEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEstado")))
                oRenovacionBE.nomEstado = dr.GetString(dr.GetOrdinal("nomEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuCreacion")))
                oRenovacionBE.usuCreacion = dr.GetString(dr.GetOrdinal("usuCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaCreacion")))
                oRenovacionBE.fechaCrecion = dr.GetDateTime(dr.GetOrdinal("fechaCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuUltActualizacion")))
                oRenovacionBE.usuUltActualizacion = dr.GetString(dr.GetOrdinal("usuUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaUltActualizacion")))
                oRenovacionBE.fechaUltActualizacion = dr.GetDateTime(dr.GetOrdinal("fechaUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaRenovacion")))
                oRenovacionBE.fechaRenovacion = dr.GetDateTime(dr.GetOrdinal("fechaRenovacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("porcentaje")))
                oRenovacionBE.porcenImporte = dr.GetDecimal(dr.GetOrdinal("porcentaje"));

            return oRenovacionBE;
        }
    }
}
