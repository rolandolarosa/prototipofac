using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class SocioLineaPagRetencionBL
   {
       SocioLineaPagRetencionDA SocioLineaPagRetencionDA = new SocioLineaPagRetencionDA();

       public DataSet ProcesarSocioLineaPagRetencion(SocioLineaPagRetencionBE BE)
       {
           return SocioLineaPagRetencionDA.ProcesarSocioLineaPagRetencion(BE);
       }
   }
}

