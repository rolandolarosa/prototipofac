using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaPagPlazoBL
   {
       SocioLineaPagPlazoDA SocioLineaPagPlazoDA = new SocioLineaPagPlazoDA();

       public DataSet ProcesarSocioLineaPagPlazo(SocioLineaPagPlazoBE BE)
       {
           return SocioLineaPagPlazoDA.ProcesarSocioLineaPagPlazo(BE);
       }
   }
}

