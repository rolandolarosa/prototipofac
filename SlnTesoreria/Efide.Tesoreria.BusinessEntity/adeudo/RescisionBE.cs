﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.adeudo
{
    public class RescisionBE
    {
        public string idRescision { get; set; }
        public string idAdeudo { get; set; }
        public decimal tasa { get; set; }
        public int plazo { get; set; }
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

        public AdeudoBE oAdeudoBE { get; set; }

        public DateTime iniciofechaInicio { get; set; }
        public DateTime finfechaInicio { get; set; }
        public DateTime iniciofechaVencimiento { get; set; }
        public DateTime finfechaVencimiento { get; set; }
        public DateTime fechaRescision { get; set; }

        /** Properties de InversionBE */
        public string idTipoAdeudo { get; set; }
        public string nomTipoAdeudo { get; set; }
        public string idEntidadFinanciera { get; set; }
        public string nomEntidadFinanciera { get; set; }
        public decimal ImporteAdeudo { get; set; }
        public decimal idMoneda { get; set; }
        public string nomMoneda { get; set; }
        public string nomEstado { get; set; }
        public decimal idTipoEntidadFinanciera { get; set; }
        public DateTime fechaInicio { get; set; }
        public DateTime fechaVencimiento { get; set; }
        public int plazoRescision { get; set; }
        /** Properties de InversionBE */

        public string nroCertificado { get; set; }
        public string socioBancoID { get; set; }
        public string Glosa { get; set; }
        public string gSesionID { get; set; }

        public decimal interesCerrado { get; set; }

        public decimal diferencia { get; set; }

        public int diasTranscurridos { get; set; }

        public int tipoBusqueda { get; set; }
    }
}
