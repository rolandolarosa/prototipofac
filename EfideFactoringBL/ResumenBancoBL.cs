using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Data;

namespace EfideFactoringBL
{
    public class ResumenBancoBL
    {
        ResumenBancoDA ResumenBancoDA = new ResumenBancoDA();

        public DataSet ProcesarResumenBanco(int OPCION)
        {
            return ResumenBancoDA.ProcesarResumenBanco(OPCION);
        }
    }
}
