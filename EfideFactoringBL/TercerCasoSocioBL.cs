using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class TercerCasoSocioBL
    {
        TercerCasoSocioDAL TercerCasoSocioDA = new TercerCasoSocioDAL();

        public DataSet ProcesarTercerCasoSocio(TercerCasoSocioBE BE)
        {
            return TercerCasoSocioDA.ProcesarTercerCasoSocio(BE);
        }
    }
}
