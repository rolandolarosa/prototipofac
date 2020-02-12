using System.Collections.Generic;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class RobotCobranzasBL
    {
        RobotCobranzasDA oDA = new RobotCobranzasDA();

        public DataSet ProcesarRobotCobranzas(RobotCobranzasBE BE)
        {
            return oDA.ProcesarRobotCobranzas(BE);
        }

        public DataSet ProcesarRobotCobranzas_Correo(RobotCobranzasBE BE)
        {
            return oDA.ProcesarRobotCobranzas_Correo(BE);
        }
    }
}
