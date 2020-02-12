using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class BovedaBE : TableBaseBE
    {
        public string IdBoveda { get; set; }
        public string IdSolicitud { get; set; }
        public DateTime dtRegistro { get; set; }
        public string vDescripcion { get; set; }
        public DateTime dtEnvioBoveda { get; set; }
        public DateTime dtCierreBoveda { get; set; }
        public string vRazonSocialSocio { get; set; }
        public int FlgVerHistoricos { get; set; }
        public string IdEstado_tt { get; set; }
        public string IdPersonaSolicitud { get; set; }
    }
}
