using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.inversion
{
    public class RenovacionBE
    {
        public string idRenovacion { get; set; }
        public string idInversion { get; set; }
        public decimal tasa { get; set; }
        public decimal plazo { get; set; }
        public decimal importe { get; set; }
        public decimal interes { get; set; }
        public decimal total { get; set; }
        public decimal tasaCerrada { get; set; }
        public string observaciones { get; set; }
        public string idEstado { get; set; }
        public string usuCreacion { get; set; }
        public DateTime fechaCrecion { get; set; }
        public string usuUltActualizacion { get; set; }
        public DateTime fechaUltActualizacion { get; set; }
        public decimal ITF { get; set; }

        public InversionBE oInversionBE { get; set; }

        public DateTime iniciofechaInicio { get; set; }
        public DateTime finfechaInicio { get; set; }
        public DateTime iniciofechaVencimiento { get; set; }
        public DateTime finfechaVencimiento { get; set; }
        public DateTime fechaRenovacion { get; set; }

        public decimal tasaRescision { get; set; }
        public int idTipoRenovacion { get; set; }
        public decimal porcenImporte { get; set; }

        /** Properties de InversionBE */
        public string idTipoInversion { get; set; }
        public string nomTipoInversion { get; set; }
        public string idEntidadFinanciera { get; set; }
        public string nomEntidadFinanciera { get; set; }
        public decimal ImporteInversion { get; set; }
        public decimal idMoneda { get; set; }
        public string nomMoneda { get; set; }
        public string nomEstado { get; set; }
        public decimal idTipoEntidadFinanciera { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int plazoRescision { get; set; }
        /** Properties de InversionBE */

        public string nomTipoRenovacion { get; set; }
    }
}
