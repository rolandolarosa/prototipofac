using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaBL
   {
       SocioLineaDA SocioLineaDA = new SocioLineaDA();

       public DataSet ProcesarSocioLinea(SocioLineaBE BE)
       {
           return SocioLineaDA.ProcesarSocioLinea(BE);
       }
   }
}

