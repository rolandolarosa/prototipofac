using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class CuentaBancoBE
    {
        public string CodPersonaSocio { get; set; }
        public string NroDocumentoSocio { get; set; }
        public string TipoDocumentoSocio { get; set; }
        public string NombreSocio { get; set; }

        public string CodPersonaRepresenta { get; set; }
        public string NroDocumentoRepresenta { get; set; }
        public string TipoDocumentoRepresenta { get; set; }
        public string NombreRepresenta { get; set; }

        public string CodPersonaAux { get; set; }
        public string NroDocumentoAux { get; set; }
        public string TipoDocumentoAux { get; set; }
        public string NombreAux { get; set; }

        //public string nomSocio { get; set; }
        //public string nomTercerSocio { get; set; }
        public string TipoOpeBanco { get; set; }
        public string comGlosa { get; set; }
        public string BancoDestino { get; set; }
        public string NroCuenta { get; set; }
        public string Beneficiario { get; set; }
        public string TipoBeneficiario { get; set; }
        //public string TipoDocumento { get; set; }
        //public string NroDocumento { get; set; }

        public int Tipo { get; set; }
        //public string codSocio { get; set; }
        public int origen { get; set; }
        //public string NroDocumentoSocio { get; set; }
        //public string TipoDocumentoSocio { get; set; }

        public string CodPersonaExcel { get; set; }

        public string NroDocumentoExcel { get; set; }

        public string TipoDocumentoExcel { get; set; }

        public string NombreExcel { get; set; }

        public string TipoDocumentoTerceraPersona { get; set; }

        public string NroDocumentoTerceraPersona { get; set; }
    }
}
