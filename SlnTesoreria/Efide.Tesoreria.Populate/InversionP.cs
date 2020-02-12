using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class InversionP
    {
        public static InversionBE getInversion(IDataReader dr)
        {
            InversionBE oInversionBE = new InversionBE();

            if (!dr.IsDBNull(dr.GetOrdinal("nroCertificado")))
                oInversionBE.nroCertificado = dr.GetString(dr.GetOrdinal("nroCertificado"));

            if (!dr.IsDBNull(dr.GetOrdinal("idInversion")))
                oInversionBE.idInversion = dr.GetString(dr.GetOrdinal("idInversion"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoInversion")))
                oInversionBE.idTipoInversion = dr.GetString(dr.GetOrdinal("idTipoInversion"));

            if (!dr.IsDBNull(dr.GetOrdinal("idTipoEntidadFinanciera")))
                oInversionBE.idTipoEntidadFinanciera = dr.GetDecimal(dr.GetOrdinal("idTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEntidadFinanciera")))
                oInversionBE.idEntidadFinanciera = dr.GetString(dr.GetOrdinal("idEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("idMoneda")))
                oInversionBE.idMoneda = dr.GetDecimal(dr.GetOrdinal("idMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("importe")))
                oInversionBE.importe = dr.GetDecimal(dr.GetOrdinal("importe"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasa")))
                oInversionBE.tasa = dr.GetDecimal(dr.GetOrdinal("tasa"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazo")))
                oInversionBE.plazo = dr.GetInt32(dr.GetOrdinal("plazo"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaInicio")))
                oInversionBE.fechaInicio = dr.GetDateTime(dr.GetOrdinal("fechaInicio"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaVencimiento")))
                oInversionBE.fechaVencimiento = dr.GetDateTime(dr.GetOrdinal("fechaVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("tasaRescision")))
                oInversionBE.tasaRescision = dr.GetDecimal(dr.GetOrdinal("tasaRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("plazoRescision")))
                oInversionBE.plazoRescision = dr.GetInt32(dr.GetOrdinal("plazoRescision"));

            if (!dr.IsDBNull(dr.GetOrdinal("diasAvisoVencimiento")))
                oInversionBE.diasAvisoVencimiento = dr.GetInt32(dr.GetOrdinal("diasAvisoVencimiento"));

            if (!dr.IsDBNull(dr.GetOrdinal("observaciones")))
                oInversionBE.observaciones = dr.GetString(dr.GetOrdinal("observaciones"));

            if (!dr.IsDBNull(dr.GetOrdinal("idEstado")))
                oInversionBE.idEstado = dr.GetString(dr.GetOrdinal("idEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuCreacion")))
                oInversionBE.usuCreacion = dr.GetString(dr.GetOrdinal("usuCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaCreacion")))
                oInversionBE.fechaCreacion = dr.GetDateTime(dr.GetOrdinal("fechaCreacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("usuUltActualizacion")))
                oInversionBE.usuUltActualizacion = dr.GetString(dr.GetOrdinal("usuUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaUltActualizacion")))
                oInversionBE.fechaUltActualizacion = dr.GetDateTime(dr.GetOrdinal("fechaUltActualizacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("idContacto")))
                oInversionBE.idContacto = dr.GetString(dr.GetOrdinal("idContacto"));

            if (!dr.IsDBNull(dr.GetOrdinal("funcionario")))
                oInversionBE.funcionario = dr.GetString(dr.GetOrdinal("funcionario"));

            if (!dr.IsDBNull(dr.GetOrdinal("telefono")))
                oInversionBE.telefono = dr.GetString(dr.GetOrdinal("telefono"));

            if (!dr.IsDBNull(dr.GetOrdinal("anexo")))
                oInversionBE.anexo = dr.GetString(dr.GetOrdinal("anexo"));

            if (!dr.IsDBNull(dr.GetOrdinal("correo")))
                oInversionBE.correo = dr.GetString(dr.GetOrdinal("correo"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoInversion")))
                oInversionBE.nomTipoInversion = dr.GetString(dr.GetOrdinal("nomTipoInversion"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoEntidadFinanciera")))
                oInversionBE.nomTipoEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomTipoEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEntidadFinanciera")))
                oInversionBE.nomEntidadFinanciera = dr.GetString(dr.GetOrdinal("nomEntidadFinanciera"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomMoneda")))
                oInversionBE.nomMoneda = dr.GetString(dr.GetOrdinal("nomMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomEstado")))
                oInversionBE.nomEstado = dr.GetString(dr.GetOrdinal("nomEstado"));

            if (!dr.IsDBNull(dr.GetOrdinal("transcurrido")))
                oInversionBE.transcurrido = dr.GetInt32(dr.GetOrdinal("transcurrido"));

            if (!dr.IsDBNull(dr.GetOrdinal("faltante")))
                oInversionBE.faltante = dr.GetInt32(dr.GetOrdinal("faltante"));

            if (!dr.IsDBNull(dr.GetOrdinal("alVto")))
                oInversionBE.alVto = dr.GetDecimal(dr.GetOrdinal("alVto"));

            if (!dr.IsDBNull(dr.GetOrdinal("rescisionHoy")))
                oInversionBE.rescisionHoy = dr.GetDecimal(dr.GetOrdinal("rescisionHoy"));

            return oInversionBE;
        }


        public static CarteraExportBE getCarteraExport(IDataReader dr)
        {
            CarteraExportBE oCarteraExportBE = new CarteraExportBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idInversion")))
                oCarteraExportBE.Cod_Inversion = dr.GetString(dr.GetOrdinal("idInversion"));

            if (!dr.IsDBNull(dr.GetOrdinal("nroCertificado")))
                oCarteraExportBE.Nro_Certificado = dr.GetString(dr.GetOrdinal("nroCertificado"));

            if (!dr.IsDBNull(dr.GetOrdinal("nomTipoInversion")))
                oCarteraExportBE.Tipo_Inversion = dr.GetString(dr.GetOrdinal("nomTipoInversion"));

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

        public static InversionBE getProceso(IDataReader dr)
        {
            InversionBE oInversionBE = new InversionBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idProceso")))
                oInversionBE.idProceso = dr.GetString(dr.GetOrdinal("idProceso"));

            if (!dr.IsDBNull(dr.GetOrdinal("fechaProceso")))
                oInversionBE.fechaProceso = dr.GetDateTime(dr.GetOrdinal("fechaProceso"));

            if (!dr.IsDBNull(dr.GetOrdinal("anio")))
                oInversionBE.anio = dr.GetInt32(dr.GetOrdinal("anio"));

            if (!dr.IsDBNull(dr.GetOrdinal("mes")))
                oInversionBE.mes = dr.GetInt32(dr.GetOrdinal("mes"));

            if (!dr.IsDBNull(dr.GetOrdinal("cantInversiones")))
                oInversionBE.cantInversiones = dr.GetInt32(dr.GetOrdinal("cantInversiones"));

            return oInversionBE;
        }
    }
}
