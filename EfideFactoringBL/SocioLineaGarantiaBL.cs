using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaGarantiaBL
   {
       SocioLineaGarantiaDA SocioLineaGarantiaDA = new SocioLineaGarantiaDA();

       public DataSet ProcesarSocioLineaGarantia(SocioLineaGarantiaBE BE)
       {
           return SocioLineaGarantiaDA.ProcesarSocioLineaGarantia(BE);
       }
   }
}

