using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaLogBL
   {
       SocioLineaLogDA SocioLineaLogDA = new SocioLineaLogDA();

       public DataSet ProcesarSocioLineaLog(SocioLineaLogBE BE)
       {
           return SocioLineaLogDA.ProcesarSocioLineaLog(BE);
       }
   }
}

