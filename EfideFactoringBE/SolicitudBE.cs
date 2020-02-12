using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class SolicitudBE : TableBaseBE
    {
        public string IdSolicitud { get; set; }
        public DateTime dtSolicitud { get; set; }
        public string IdPersonaSolicitud { get; set; }
        public string IdArea_tt { get; set; }
        public string IdTipoSolicitud_tt { get; set; }
        public string IdSocio { get; set; }
        public string cRucSocio { get; set; }
        public string vRazonSocialSocio { get; set; }
        public string vConyugue { get; set; }
        public string vConyugueDNI { get; set; }
        public string vConyugueDomicilio { get; set; }
        public string NroPartidaSB { get; set; }
        public DateTime dtNroPartidaDB { get; set; }
        public string IdPagadora { get; set; }
        public string cRucPagadora { get; set; }
        public string vRazonSocialPagadora { get; set; }
        public string IdTipoLinea_tt { get; set; }
        public string IdMoneda_tt { get; set; }
        public decimal nImporte { get; set; }
        public decimal nTEA { get; set; }
        public decimal nTEAMinDol { get; set; }
        public decimal nTEAMaxSol { get; set; }
        public decimal nTEAMaxDol { get; set; }
        public int iPlazo { get; set; }
        public int iPlanPago { get; set; }
        public DateTime dtVencimiento { get; set; }
        public DateTime dtEnvioLegal { get; set; }
        public string vDomicilioRealPag { get; set; }
        public string vDomicilioLegalPag { get; set; }
        public string vPartidaElectronica { get; set; }
        public string vDomicilioRealSoc { get; set; }
        public string vDomicilioAnexoSoc { get; set; }
        public string vObjetoSocial { get; set; }
        public string vCapSocialSoc { get; set; }
        public string IdPersonaLegal { get; set; }
        public DateTime dtEnvioRiego { get; set; }
        public int FlgVerHistoricos { get; set; }
        public int FlgLetraCambio { get; set; }
        public string IdEstado_tt { get; set; }
    }
}
