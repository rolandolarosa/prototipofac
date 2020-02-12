using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class GrupoPagadoraLogBL
   {
       GrupoPagadoraLogDA GrupoPagadoraLogDA = new GrupoPagadoraLogDA();

       public DataSet ProcesarGrupoPagadoraLog(GrupoPagadoraLogBE BE)
       {
           return GrupoPagadoraLogDA.ProcesarGrupoPagadoraLog(BE);
       }
   }
}

