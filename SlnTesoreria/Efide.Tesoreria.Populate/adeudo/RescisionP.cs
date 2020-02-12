using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.Populate.adeudo
{
    public class RescisionP
    {
        public static RescisionBE getRescision(IDataReader dr)
        {
            RescisionBE oRescisionBE = new RescisionBE();
            oRescisionBE.oAdeudoBE = new AdeudoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idRescision")))
                oRescisionBE.idRescision = dr.GetString(dr.GetOrdinal("idRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("nroCertificado")))
                oRescisionBE.nroCertificado = dr.GetString(dr.GetOrdinal("nroCertificado"));

            if (!dr.IsDBNull(dr.GetOrdinal("idAdeudo")))
                oRescisionBE.idAdeudo = dr.GetString(dr.GetOrdinal("idAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoAdeudo")))
                oRescisionBE.idTipoAdeudo = dr.GetString(dr.GetOrdinal("idTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoAdeudo")))
                oRescisionBE.nomTipoAdeudo = dr.GetString(dr.GetOrdinal("nomTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEntidadFinanciera")))
                oRescisionBE.idEntidadFinanciera = dr.GetString(dr.GetOrdinal("idEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEntidadFinanciera")))
                oRescisionBE.nomEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoEntidadFinanciera")))
                oRescisionBE.idTipoEntidadFinanciera = dr.GetDecimal(dr.GetOrdinal("idTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idMoneda")))
                oRescisionBE.idMoneda = dr.GetDecimal(dr.GetOrdinal("idMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomMoneda")))
                oRescisionBE.nomMoneda = dr.GetString(dr.GetOrdinal("nomMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasa")))
                oRescisionBE.tasa = dr.GetDecimal(dr.GetOrdinal("tasa"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazo")))
                oRescisionBE.plazo = dr.GetInt32(dr.GetOrdinal("plazo"));

            if (!dr.IsDBNull(dr.GetOrdinal("importe")))
                oRescisionBE.importe = dr.GetDecimal(dr.GetOrdinal("importe"));

            if (!dr.IsDBNull(dr.GetOrdinal("ImporteAdeudo")))
                oRescisionBE.ImporteAdeudo = dr.GetDecimal(dr.GetOrdinal("ImporteAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("interes")))
                oRescisionBE.interes = dr.GetDecimal(dr.GetOrdinal("interes"));

            if (!dr.IsDBNull(dr.GetOrdinal("itf")))
                oRescisionBE.ITF = dr.GetDecimal(dr.GetOrdinal("itf"));

            if (!dr.IsDBNull(dr.GetOrdinal("total")))
                oRescisionBE.total = dr.GetDecimal(dr.GetOrdinal("total"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasaCerrada")))
                oRescisionBE.tasaCerrada = dr.GetDecimal(dr.GetOrdinal("tasaCerrada"));

            if (!dr.IsDBNull(dr.GetOrdinal("interesCerrado")))
                oRescisionBE.interesCerrado = dr.GetDecimal(dr.GetOrdinal("interesCerrado"));

            if (!dr.IsDBNull(dr.GetOrdinal("observaciones")))
                oRescisionBE.observaciones = dr.GetString(dr.GetOrdinal("observaciones"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEstado")))
                oRescisionBE.idEstado = dr.GetString(dr.GetOrdinal("idEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEstado")))
                oRescisionBE.nomEstado = dr.GetString(dr.GetOrdinal("nomEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuCreacion")))
                oRescisionBE.usuCreacion = dr.GetString(dr.GetOrdinal("usuCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaCrecion")))
                oRescisionBE.fechaCrecion = dr.GetDateTime(dr.GetOrdinal("fechaCrecion"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuUltActualizacion")))
                oRescisionBE.usuUltActualizacion = dr.GetString(dr.GetOrdinal("usuUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaUltActualizacion")))
                oRescisionBE.fechaUltActualizacion = dr.GetDateTime(dr.GetOrdinal("fechaUltActualizacion"));


            if (!dr.IsDBNull(dr.GetOrdinal("diferencia")))
                oRescisionBE.diferencia = dr.GetDecimal(dr.GetOrdinal("diferencia"));

            if (!dr.IsDBNull(dr.GetOrdinal("diasTranscurridos")))
                oRescisionBE.diasTranscurridos = dr.GetInt32(dr.GetOrdinal("diasTranscurridos"));


            if (!dr.IsDBNull(dr.GetOrdinal("plazoRescision")))
                oRescisionBE.plazoRescision = dr.GetInt32(dr.GetOrdinal("plazoRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaInicio")))
                oRescisionBE.fechaInicio = dr.GetDateTime(dr.GetOrdinal("fechaInicio"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaVencimiento")))
                oRescisionBE.fechaVencimiento = dr.GetDateTime(dr.GetOrdinal("fechaVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaRescision")))
                oRescisionBE.fechaRescision = dr.GetDateTime(dr.GetOrdinal("fechaRescision"));

            return oRescisionBE;
        }
    }
}
