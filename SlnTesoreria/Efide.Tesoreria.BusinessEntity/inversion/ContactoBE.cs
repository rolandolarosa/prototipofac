using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.inversion
{
    public class ContactoBE
    {
        public string idContacto { get; set; }
        public string idInversion { get; set; }
        public string funcionario { get; set; }
        public string telefono { get; set; }
        public string anexo { get; set; }
        public string correo { get; set; }

        public string celular { get; set; }

        public DateTime cumpleanos { get; set; }

        public int cuentaBancoID { get; set; }
    }
}
