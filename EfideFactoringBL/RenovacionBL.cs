using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class RenovacionBL
    {
        RenovacionDAL RenovacionDAL = new RenovacionDAL();

        public DataSet ProcesarRenovacion(RenovacionBE BE)
        {
            return RenovacionDAL.ProcesarRenovacion(BE);
        }
    }
}
