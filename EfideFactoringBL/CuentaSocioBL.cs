using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class CuentaSocioBL
    {
        CuentaSocioDAL CuentaSocioData = new CuentaSocioDAL();

        public DataSet BuscarCuentaSocio(CuentaSocioBE BE)
        {
            return CuentaSocioData.BuscarCuentaSocio(BE);
        }
    }
}
