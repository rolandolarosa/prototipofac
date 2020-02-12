using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity
{
    public class UsuarioBE : GeneralBE
    {
        public string usuarioID { get; set; }
        public string usuContrasena { get; set; }
        public DateTime pfecha { get; set; }

        public string rolGlobal { get; set; }
        public string rolGlobalName { get; set; }
    }
}
