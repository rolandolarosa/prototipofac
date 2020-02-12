using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudDocumentoBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public string IdDocumento { get; set; }
        public int iPlazo { get; set; }
        public decimal nTEA { get; set; }
    }
}
