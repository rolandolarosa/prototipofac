using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.adeudo
{
    public class DocumentoBE
    {
        public string idDocumento { get; set; }
        public string idAdeudo { get; set; }
        public string ruta { get; set; }
        public string nombre { get; set; }
        public string observaciones { get; set; }

        public string rutaAnterior { get; set; }
    }
}
