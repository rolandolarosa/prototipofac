using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity
{
    public class AccesoGlobalBE
    {
        public string menNomInterno { get; set; }
        public string menNomPublico { get; set; }
        public int menPadre { get; set; }
        public int menPosicion { get; set; }
        public bool perEstado { get; set; }
    }
}
