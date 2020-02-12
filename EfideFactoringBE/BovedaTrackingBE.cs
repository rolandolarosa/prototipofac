using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class BovedaTrackingBE : TableBaseBE
    {
        public string IdBoveda { get; set; }
        public string IdFormatoDocLegal_tt { get; set; }
        public string IdTracking { get; set; }
        public DateTime dtRegistro { get; set; }
        public string IdEstado_tt { get; set; }
        public string IdEstado_tt_Nuevo { get; set; }
        public string vComentario { get; set; }
    }
}
