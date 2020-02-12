using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Efide.Tesoreria.BusinessEntity.adeudo
{
    public class CuentaBancosBE
    {
        public int cuentaBancoID { get; set; }
        public int idTipoEntidadFinanciera { get; set; }
        public string idEntidadFinanciera { get; set; }
        public int idMoneda { get; set; }
        public string idTipoCuenta { get; set; }
        public string cuentaLocal { get; set; }
        public string cuentaCCI { get; set; }
        public string usuCreacion { get; set; }

        public string nomTipoEntidadFinanciera { get; set; }
        public string nomMoneda { get; set; }
        public string emprRazonSocial { get; set; }

        public string nomTipoCuenta { get; set; }

        public object usuUltActualizacion { get; set; }
    }
}
