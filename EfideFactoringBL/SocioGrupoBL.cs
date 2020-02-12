using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class SocioGrupoBL
   {
       SocioGrupoDA Entity = new SocioGrupoDA();

       public DataSet ProcesarSocioGrupo(SocioGrupoBE BE)
       {
           return Entity.ProcesarSocioGrupo(BE);
       }
   }
}

