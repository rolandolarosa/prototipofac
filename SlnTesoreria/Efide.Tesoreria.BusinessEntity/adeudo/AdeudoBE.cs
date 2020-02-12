using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.adeudo
{
    public class AdeudoBE
    {
        public string idAdeudo { get; set; }
        public string idTipoAdeudo { get; set; }
        public decimal idTipoEntidadFinanciera { get; set; }
        public string idEntidadFinanciera { get; set; }
        public decimal idMoneda { get; set; }
        public decimal importe { get; set; }
        public decimal tasa { get; set; }
        public int plazo { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public decimal tasaRescision { get; set; }
        public int plazoRescision { get; set; }
        public int diasAvisoVencimiento { get; set; }
        public string observaciones { get; set; }
        public string idEstado { get; set; }
        public string usuCreacion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuUltActualizacion { get; set; }
        public DateTime fechaUltActualizacion { get; set; }
        public string idContacto { get; set; }
        public string funcionario { get; set; }
        public string telefono { get; set; }
        public string anexo { get; set; }
        public string correo { get; set; }
        public DateTime iniciofechaInicio { get; set; }
        public DateTime finfechaInicio { get; set; }
        public DateTime iniciofechaVencimiento { get; set; }
        public DateTime finfechaVencimiento { get; set; }
        public string nomTipoAdeudo { get; set; }
        public string nomTipoEntidadFinanciera { get; set; }
        public string nomEntidadFinanciera { get; set; }
        public string nomMoneda { get; set; }
        public string nomEstado { get; set; }
        public int transcurrido { get; set; }
        public int faltante { get; set; }
        public decimal rescisionHoy { get; set; }
        public decimal alVto { get; set; }
        public string IdAdeudoRenovacion { get; set; }
        public string nroCertificado { get; set; }
        public int anio { get; set; }
        public int mes { get; set; }
        public DateTime fechaProceso { get; set; }
        public string idProceso { get; set; }
        public int cantAdeudos { get; set; }
        public DateTime fechaGlobal { get; set; }
        public int tipo { get; set; }
    }
}
