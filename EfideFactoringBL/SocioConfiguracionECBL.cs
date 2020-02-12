using System.Collections.Generic;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class SocioConfiguracionECBL
    {
        SocioConfiguracionECDA SocioConfiguracionECDA = new SocioConfiguracionECDA();

        public DataSet ProcesarSocioConfiguracionEC(SocioConfiguracionECBE BE)
        {
            return SocioConfiguracionECDA.ProcesarSocioConfiguracionEC(BE);
        }
    }
}
