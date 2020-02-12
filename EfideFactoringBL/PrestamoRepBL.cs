using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class PrestamoRepBL
    {
        PrestamoRepDAL oPrestamoRepDAL = new PrestamoRepDAL();

        public DataSet ReporteSocio(PrestamoRepBE BE)
        {
            return oPrestamoRepDAL.ReporteSocio(BE);
        }
    }
}
