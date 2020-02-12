using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.adeudo
{
    public class SocioBancoBE
    {
        public string socioBancoID { get; set; }
        public string valorTipollamadaID { get; set; }
        public string tipollamada { get; set; }
        public string ctasBancariaID { get; set; }
        public string entFinancieraID { get; set; }
        public string ctasBanNumCta { get; set; }
        public string valorMonedaID { get; set; }
        public string tipoMoneda { get; set; }

        public string ent_EmpresaID { get; set; }
        public string ent_emprRazonSocial { get; set; }
        public string ent_emprRuc { get; set; }
        public string pagar_personaID { get; set; }
        public string pagar_nombreCompleto { get; set; }
        public string pagar_Documento { get; set; }
        public string pagar_NumDoc { get; set; }

        public string clienteID { get; set; }
        public string soc_comunTipoCliID { get; set; }
        public string soc_razonSocial { get; set; }
        public string soc_Documento { get; set; }
        public string soc_numDoc { get; set; }
        public string soc_tipoPersona { get; set; }
        public string soc_TipoCliente { get; set; }
        public string sbNumOperacion { get; set; }

        public decimal sbImporte { get; set; }
        public string sbGlosa { get; set; }
        public bool sbVigente { get; set; }
        public string sbEstado { get; set; }
        public string sbFechaCrea { get; set; }
        public string sbUsuarioCrea { get; set; }
        public string soc_comunTipoPerID { get; set; }
        public string codigoEntFin { get; set; }
        public string PlazaID { get; set; }
        public string plaNombre { get; set; }

        public int valorTipoOperacionID { get; set; }
        public string tipoOperacion { get; set; }
        public DateTime sbFechaOperacion { get; set; }
        public string valorTipoMpagoID { get; set; }
        public string valorDestinoID { get; set; }
        public string TipoDestino { get; set; }
        public string TipoMpago { get; set; }
        public decimal Saldo { get; set; }

        public string numOperaBanco { get; set; }
        public int tipoFecha { get; set; }
        public string ctaBancariaID { get; set; }
        public DateTime fechaFin { get; set; }
        public DateTime fechaInicio { get; set; }

        public string valorMonedaID_Dsc { get; set; }
    }
}
