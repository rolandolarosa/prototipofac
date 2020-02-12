using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudFacultadBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public string IdTipo_tt { get; set; }
        public string IdItem { get; set; }
        public string IdFacultad_tt { get; set; }
        public string IdRepresentanteF1 { get; set; }
        public string IdRepresentanteF2 { get; set; }
        public string IdMoneda_tt { get; set; }
        public decimal nMontoMaximo { get; set; }
        public string IdPagadora { get; set; }
        public string IdSocio { get; set; }
        public string IdLote { get; set; }
        public Boolean bFirma { get; set; }
    }
}
