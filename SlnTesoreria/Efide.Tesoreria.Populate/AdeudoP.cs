using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class AdeudoP
    {
        public static AdeudoBE getAdeudo(IDataReader dr)
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("nroCertificado")))
                oAdeudoBE.nroCertificado = dr.GetString(dr.GetOrdinal("nroCertificado"));

            if (!dr.IsDBNull(dr.GetOrdinal("idAdeudo")))
                oAdeudoBE.idAdeudo = dr.GetString(dr.GetOrdinal("idAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoAdeudo")))
                oAdeudoBE.idTipoAdeudo = dr.GetString(dr.GetOrdinal("idTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoEntidadFinanciera")))
                oAdeudoBE.idTipoEntidadFinanciera = dr.GetDecimal(dr.GetOrdinal("idTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEntidadFinanciera")))
                oAdeudoBE.idEntidadFinanciera = dr.GetString(dr.GetOrdinal("idEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idMoneda")))
                oAdeudoBE.idMoneda = dr.GetDecimal(dr.GetOrdinal("idMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("importe")))
                oAdeudoBE.importe = dr.GetDecimal(dr.GetOrdinal("importe"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasa")))
                oAdeudoBE.tasa = dr.GetDecimal(dr.GetOrdinal("tasa"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazo")))
                oAdeudoBE.plazo = dr.GetInt32(dr.GetOrdinal("plazo"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaInicio")))
                oAdeudoBE.fechaInicio = dr.GetDateTime(dr.GetOrdinal("fechaInicio"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaVencimiento")))
                oAdeudoBE.fechaVencimiento = dr.GetDateTime(dr.GetOrdinal("fechaVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasaRescision")))
                oAdeudoBE.tasaRescision = dr.GetDecimal(dr.GetOrdinal("tasaRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazoRescision")))
                oAdeudoBE.plazoRescision = dr.GetInt32(dr.GetOrdinal("plazoRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("diasAvisoVencimiento")))
                oAdeudoBE.diasAvisoVencimiento = dr.GetInt32(dr.GetOrdinal("diasAvisoVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("observaciones")))
                oAdeudoBE.observaciones = dr.GetString(dr.GetOrdinal("observaciones"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEstado")))
                oAdeudoBE.idEstado = dr.GetString(dr.GetOrdinal("idEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuCreacion")))
                oAdeudoBE.usuCreacion = dr.GetString(dr.GetOrdinal("usuCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaCreacion")))
                oAdeudoBE.fechaCreacion = dr.GetDateTime(dr.GetOrdinal("fechaCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuUltActualizacion")))
                oAdeudoBE.usuUltActualizacion = dr.GetString(dr.GetOrdinal("usuUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaUltActualizacion")))
                oAdeudoBE.fechaUltActualizacion = dr.GetDateTime(dr.GetOrdinal("fechaUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("idContacto")))
                oAdeudoBE.idContacto = dr.GetString(dr.GetOrdinal("idContacto"));

            if (!dr.IsDBNull(dr.GetOrdinal("funcionario")))
                oAdeudoBE.funcionario = dr.GetString(dr.GetOrdinal("funcionario"));

            if (!dr.IsDBNull(dr.GetOrdinal("telefono")))
                oAdeudoBE.telefono = dr.GetString(dr.GetOrdinal("telefono"));

            if (!dr.IsDBNull(dr.GetOrdinal("anexo")))
                oAdeudoBE.anexo = dr.GetString(dr.GetOrdinal("anexo"));

            if (!dr.IsDBNull(dr.GetOrdinal("correo")))
                oAdeudoBE.correo = dr.GetString(dr.GetOrdinal("correo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoAdeudo")))
                oAdeudoBE.nomTipoAdeudo = dr.GetString(dr.GetOrdinal("nomTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoEntidadFinanciera")))
                oAdeudoBE.nomTipoEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEntidadFinanciera")))
                oAdeudoBE.nomEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomMoneda")))
                oAdeudoBE.nomMoneda = dr.GetString(dr.GetOrdinal("nomMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEstado")))
                oAdeudoBE.nomEstado = dr.GetString(dr.GetOrdinal("nomEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("transcurrido")))
                oAdeudoBE.transcurrido = dr.GetInt32(dr.GetOrdinal("transcurrido"));

            if (!dr.IsDBNull(dr.GetOrdinal("faltante")))
                oAdeudoBE.faltante = dr.GetInt32(dr.GetOrdinal("faltante"));

            if (!dr.IsDBNull(dr.GetOrdinal("alVto")))
                oAdeudoBE.alVto = dr.GetDecimal(dr.GetOrdinal("alVto"));

            if (!dr.IsDBNull(dr.GetOrdinal("rescisionHoy")))
                oAdeudoBE.rescisionHoy = dr.GetDecimal(dr.GetOrdinal("rescisionHoy"));

            return oAdeudoBE;
        }


        public static CarteraExportBE getCarteraExport(IDataReader dr)
        {
            CarteraExportBE oCarteraExportBE = new CarteraExportBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idAdeudo")))
                oCarteraExportBE.Cod_Inversion = dr.GetString(dr.GetOrdinal("idAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nroCertificado")))
                oCarteraExportBE.Nro_Certificado = dr.GetString(dr.GetOrdinal("nroCertificado"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoAdeudo")))
                oCarteraExportBE.Tipo_Inversion = dr.GetString(dr.GetOrdinal("nomTipoAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoEntidadFinanciera")))
                oCarteraExportBE.Tipo_Financiera = dr.GetString(dr.GetOrdinal("nomTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEntidadFinanciera")))
                oCarteraExportBE.Financiera = dr.GetString(dr.GetOrdinal("nomEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomMoneda")))
                oCarteraExportBE.Moneda = dr.GetString(dr.GetOrdinal("nomMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("importe")))
                oCarteraExportBE.Importe = dr.GetDecimal(dr.GetOrdinal("importe"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasa")))
                oCarteraExportBE.Tasa = dr.GetDecimal(dr.GetOrdinal("tasa"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazo")))
                oCarteraExportBE.Plazo = dr.GetInt32(dr.GetOrdinal("plazo"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaInicio")))
                oCarteraExportBE.Fecha_Inicio = dr.GetDateTime(dr.GetOrdinal("fechaInicio"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaVencimiento")))
                oCarteraExportBE.Fecha_Vencimiento = dr.GetDateTime(dr.GetOrdinal("fechaVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasaRescision")))
                oCarteraExportBE.Tasa_Rescision = dr.GetDecimal(dr.GetOrdinal("tasaRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazoRescision")))
                oCarteraExportBE.Plazo_Rescision = dr.GetInt32(dr.GetOrdinal("plazoRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("transcurrido")))
                oCarteraExportBE.Transcurrido = dr.GetInt32(dr.GetOrdinal("transcurrido"));

            if (!dr.IsDBNull(dr.GetOrdinal("faltante")))
                oCarteraExportBE.Faltante = dr.GetInt32(dr.GetOrdinal("faltante"));

            if (!dr.IsDBNull(dr.GetOrdinal("observaciones")))
                oCarteraExportBE.Observaciones = dr.GetString(dr.GetOrdinal("observaciones"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEstado")))
                oCarteraExportBE.Estado = dr.GetString(dr.GetOrdinal("nomEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("funcionario")))
                oCarteraExportBE.Funcionario = dr.GetString(dr.GetOrdinal("funcionario"));

            if (!dr.IsDBNull(dr.GetOrdinal("telefono")))
                oCarteraExportBE.Telefono = dr.GetString(dr.GetOrdinal("telefono"));

            if (!dr.IsDBNull(dr.GetOrdinal("anexo")))
                oCarteraExportBE.Anexo = dr.GetString(dr.GetOrdinal("anexo"));

            if (!dr.IsDBNull(dr.GetOrdinal("correo")))
                oCarteraExportBE.Correo = dr.GetString(dr.GetOrdinal("correo"));

            return oCarteraExportBE;
        }

        public static AdeudoBE getProceso(IDataReader dr)
        {
            AdeudoBE oAdeudoBE = new AdeudoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idProceso")))
                oAdeudoBE.idProceso = dr.GetString(dr.GetOrdinal("idProceso"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaProceso")))
                oAdeudoBE.fechaProceso = dr.GetDateTime(dr.GetOrdinal("fechaProceso"));

            if (!dr.IsDBNull(dr.GetOrdinal("anio")))
                oAdeudoBE.anio = dr.GetInt32(dr.GetOrdinal("anio"));

            if (!dr.IsDBNull(dr.GetOrdinal("mes")))
                oAdeudoBE.mes = dr.GetInt32(dr.GetOrdinal("mes"));

            if (!dr.IsDBNull(dr.GetOrdinal("cantAdeudos")))
                oAdeudoBE.cantAdeudos = dr.GetInt32(dr.GetOrdinal("cantAdeudos"));

            return oAdeudoBE;
        }
    }
}
