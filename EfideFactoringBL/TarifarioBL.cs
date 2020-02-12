using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class TarifarioBL
   {
       TarifarioDA TarifarioDA = new TarifarioDA();

       public DataSet ProcesarTarifario(TarifarioBE BE)
       {
           return TarifarioDA.ProcesarTarifario(BE);
       }
   }
}

