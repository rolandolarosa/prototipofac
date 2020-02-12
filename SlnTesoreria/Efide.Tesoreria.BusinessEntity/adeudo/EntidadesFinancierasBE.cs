using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.adeudo
{
    public class EntidadesFinancierasBE
    {
        public string entFinancieraID { get; set; }
        public decimal valorTipoEntFinancID { get; set; }
        public string emprRazonSocial { get; set; }
        public bool entFinEstado { get; set; }
        public string empresaID { get; set; }
        public string codigoEntFin { get; set; }
        public string nomTipoEntFin { get; set; }
    }
}
