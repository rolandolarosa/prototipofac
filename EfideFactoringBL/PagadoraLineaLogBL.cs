using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PagadoraLineaLogBL
   {
       PagadoraLineaLogDA PagadoraLineaLogDA = new PagadoraLineaLogDA();

       public DataSet ProcesarPagadoraLineaLog(PagadoraLineaLogBE BE)
       {
           return PagadoraLineaLogDA.ProcesarPagadoraLineaLog(BE);
       }
   }
}

