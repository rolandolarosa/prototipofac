using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.inversion
{
    public class ConfirmacionBE
    {
        public string idConfirmacion { get; set; }
        public string idRelacionado { get; set; }
        public int idTipoConfirmacion { get; set; }
        public decimal importeRescision { get; set; }
        public string usuCreacion { get; set; }
        public DateTime fechaCreacion { get; set; }
        public string usuUltActualizacion { get; set; }
        public DateTime fechaUltActualizacion { get; set; }

        public decimal tasa { get; set; }
        public decimal importe { get; set; }
        public decimal interes { get; set; }
        public decimal importeCobrar { get; set; }
    }
}
