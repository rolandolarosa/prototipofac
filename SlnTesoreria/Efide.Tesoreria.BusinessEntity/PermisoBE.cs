using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity
{
    public class PermisoBE
    {
        public string rolID { get; set; }
        public string usuarioID { get; set; }
        public string plataformaID { get; set; }
        public string moduloID { get; set; }
        public string menNomInterno { get; set; }
        public int perNuevo { get; set; }
        public int perEditar { get; set; }
        public int perConsultar { get; set; }
        public int perEstado { get; set; }
        public string perUsuarioMod { get; set; }
        public DateTime perFechaMod { get; set; }
        public string plataformaNom { get; set; }
        public string moduloNom { get; set; }
        public int plaNumOrden { get; set; }
        public int modNumOrden { get; set; }
    }
}
