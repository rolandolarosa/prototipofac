using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class RenovacionDetBL
    {
        RenovacionDetDAL RenovacionDetDAL = new RenovacionDetDAL();

        public DataSet ProcesarRenovacionDet(RenovacionDetBE BE)
        {
            return RenovacionDetDAL.ProcesarRenovacionDet(BE);
        }
    }
}
