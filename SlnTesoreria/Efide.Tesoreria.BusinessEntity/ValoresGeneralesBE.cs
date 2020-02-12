using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity
{
    public class ValoresGeneralesBE
    {
        public decimal valorID { get; set; }
        public decimal varCodigo { get; set; }
        public string varDescripcion { get; set; }
        public string varAux1 { get; set; }
        public decimal varAux2 { get; set; }
        public bool varEstado { get; set; }
    }
}
