using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudTrackingBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public string IdTracking { get; set; }
        public string IdTipo_tt { get; set; }
        public DateTime dtRegistro { get; set; }
        public string IdEstado_tt { get; set; }
        public string IdEstado_tt_Nuevo { get; set; }
        public string vComentario { get; set; }
    }
}
