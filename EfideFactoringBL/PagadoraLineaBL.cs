using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PagadoraLineaBL
   {
       PagadoraLineaDA PagadoraLineaDA = new PagadoraLineaDA();

       public DataSet ProcesarPagadoraLinea(PagadoraLineaBE BE)
       {
           return PagadoraLineaDA.ProcesarPagadoraLinea(BE);
       }
   }
}

