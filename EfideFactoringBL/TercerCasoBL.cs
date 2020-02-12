using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class TercerCasoBL
    {
        TercerCasoDAL TercerCasoDA = new TercerCasoDAL();

        public DataSet ProcesarTercerCaso(TercercasoBE BE)
        {
            return TercerCasoDA.ProcesarTercercaso(BE);
        }
    }
}
