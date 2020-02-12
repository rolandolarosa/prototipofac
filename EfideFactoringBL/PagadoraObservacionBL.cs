using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class PagadoraObservacionBL
    {
        PagadoraObservacionDAL PagadoraObservacionDAL = new PagadoraObservacionDAL();

        public DataSet ProcesarPagadoraObservacion(PagadoraObservacionBE BE)
        {
            return PagadoraObservacionDAL.ProcesarPagadoraObservacion(BE);
        }
    }
}
