using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class BovedaDetalleBE : TableBaseBE
    {
        public string IdBoveda { get; set; }
        public string IdFormatoDocLegal_tt { get; set; }
        public DateTime dtAdjunto { get; set; }
        public string vArchivoAdjunto { get; set; }
        public bool bFlgRecepcion { get; set; }
        public DateTime dtRecepcion { get; set; }
        public DateTime FechaPago { get; set; }
        public decimal ImportePago { get; set; }
        public string Comentario { get; set; }
    }
}
