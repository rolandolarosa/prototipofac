using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaPagadoraBL
   {
       SocioLineaPagadoraDA SocioLineaPagadoraDA = new SocioLineaPagadoraDA();

       public DataSet ProcesarSocioLineaPagadora(SocioLineaPagadoraBE BE)
       {
           return SocioLineaPagadoraDA.ProcesarSocioLineaPagadora(BE);
       }
   }
}

