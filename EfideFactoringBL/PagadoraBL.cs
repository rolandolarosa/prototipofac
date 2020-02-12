using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PagadoraBL
   {
       PagadoraDA PagadoraDA = new PagadoraDA();

       public DataSet ProcesarPagadora(PagadoraBE BE)
       {
           return PagadoraDA.ProcesarPagadora(BE);
       }

       public DataSet PagadoraXcredito(string IdCreditosTM)
       {
           return PagadoraDA.PagadoraXcredito(IdCreditosTM);
       }
   }
}

