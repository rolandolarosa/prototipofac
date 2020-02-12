using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity
{
    public class GeneralBE
    {
        public int OPCION { get; set; }
        public string USUARIO { get; set; }
        public string gSesionID { get; set; }
        public string gPlazaID { get; set; }

        public string IdGestor { get; set; }
        public string ventanillaID { get; set; }
        public string gRol { get; set; }
        public string gRol_Dsc { get; set; }

        public DateTime gFechaOp { get; set; }
    }
}
