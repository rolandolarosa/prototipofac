using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class BitacoraCobranzaInputBE
    {
        public string IdBitacora { get; set; }
        public string IdEntidad { get; set; }
        public string IdTipoBitacora_tt { get; set; }
        public string IdOrigenBitacora_tt { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime FechaAlerta { get; set; }
        public string IdEstado_tt { get; set; }
        public System.DateTime FechaAtendido { get; set; }
        public string IdGestor { get; set; }
        public string IdBitacoraGenerada { get; set; }
        public decimal nMontoCompromiso { get; set; }
        public string USUARIO { get; set; }
        public int OPCION { get; set; }
    }
}
