using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioGrupoDetBL
   {
       SocioGrupoDetDA Entity = new SocioGrupoDetDA();

       public DataSet ProcesarSocioGrupoDet(SocioGrupoDetBE BE)
       {
           return Entity.ProcesarSocioGrupoDet(BE);
       }
   }
}

