using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudRepresentanteBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public string IdTipo_tt { get; set; }
        public string IdRepresentante { get; set; }
        public string vNombreRepresentante { get; set; }
        public string IdCargo_tt { get; set; }
        public string IdTipoDocumento_tt { get; set; }
        public string vNroDocumento { get; set; }
        public string IdEstadoCivil_tt { get; set; }
        public string vObjetoSocial { get; set; }
        public string vDomicilio { get; set; }
        public string IdTipoDocumentoApoderado_tt { get; set; }
        public string vNroDocApoderado { get; set; }
        public string vNombreApoderado { get; set; }
        public string vDomicilioApoderado { get; set; }
        public string IdCargoApoderado_tt { get; set; }
        public string IdTipoDocumentoApoderado1_tt { get; set; }
        public string vNroDocApoderado1 { get; set; }
        public string vNombreApoderado1 { get; set; }
        public string vDomicilioApoderado1 { get; set; }
        public string IdCargoApoderado1_tt { get; set; }
        public string IdTipoDocumentoConyuge_tt { get; set; }
        public string vNroDocConguge { get; set; }
        public string vNombreConyuge { get; set; }
        public string vDomicilioConyuge { get; set; }
        public DateTime dtVigencia { get; set; }
        public string vFirmaAdjunta { get; set; }
        public string vFirmaAdjunta1 { get; set; }
        public string vFirmaAdjunta2 { get; set; }
        public string vObservacion { get; set; }
    }
}
