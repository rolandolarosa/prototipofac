using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class BaseNegativaBE : TableBaseBE
    {
        public string IdBaseNegativa { get; set; }
        public string vApePaterno { get; set; }
        public string vApeMaterno { get; set; }
        public string vNombre { get; set; }
        public string IdTipoDocumento_tt { get; set; }
        public string vNroDocumento { get; set; }
        public string Motivo { get; set; }
        public string Observacion { get; set; }
    }
}
