using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudRegistroBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public string IdTipoRegistro_tt { get; set; }
        public string vTomo { get; set; }
        public string vFicha { get; set; }
        public string vPartida { get; set; }
        public System.DateTime dtRegistro { get; set; }
        public string vLugar { get; set; }
        public string vNroPagina { get; set; }
        public string vCC { get; set; }
        public string vEP { get; set; }
        public string vOtro { get; set; }
    }
}
