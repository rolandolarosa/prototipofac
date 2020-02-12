using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfideFactoringBE
{
    public class CuentaSocioBE : GeneralBE
    {
        public Int32 opcionID { get; set; }
        public Decimal? valorTipoCuentaID { get; set; }
        public Decimal? valorTipoCuentaAhoID { get; set; }
        public Decimal? valorMonedaID { get; set; }
        public string razonSocial { get; set; }
        public string numDoc { get; set; }
        public string comunTipoCliID { get; set; }
        public string numCuentaID { get; set; }
        public string productoID { get; set; }
        public string clienteID { get; set; }
        public string CorporacionID { get; set; }       

    }
}
