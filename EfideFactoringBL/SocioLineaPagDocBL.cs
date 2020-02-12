using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaPagDocBL
   {
       SocioLineaPagDocDA SocioLineaPagDocDA = new SocioLineaPagDocDA();

       public DataSet ProcesarSocioLineaPagDoc(SocioLineaPagDocBE BE)
       {
           return SocioLineaPagDocDA.ProcesarSocioLineaPagDoc(BE);
       }
   }
}

