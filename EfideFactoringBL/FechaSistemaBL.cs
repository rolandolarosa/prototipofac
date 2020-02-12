using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class FechaSistemaBL
    {
        FechaSistemaDAL FechaSistemaDAL = new FechaSistemaDAL();
        public DataSet ProcesarFechaSistema(FechaSistemaBE BE)
        {
            return FechaSistemaDAL.ProcesarFechaSistema(BE);
        }


        public static DataSet ProcesarFechaSistema()
        {
            throw new System.NotImplementedException();
        }
    }
}
