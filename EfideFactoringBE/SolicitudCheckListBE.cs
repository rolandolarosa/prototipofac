using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudCheckListBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public string IdDocumento_tt { get; set; }
        public string IdTipo_tt { get; set; }
        public DateTime dtRegistro { get; set; }
        public string vDocumento { get; set; }
    }
}
