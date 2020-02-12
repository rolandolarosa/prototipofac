using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudFacultadGridBE
    {
        public int NroFila { get; set; }
        public string vcPagadora { get; set; }
        public string IdFacultad_tt_Dsc { get; set; }
        public string IdRepresentanteF1_Dsc { get; set; }
        public string IdRepresentanteF2_Dsc { get; set; }
        public byte[] ImageFirma1 { get; set; }
        public byte[] ImageFirma2 { get; set; }
    }
}
