using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class IndicadorMensualBL
   {
       IndicadorMensualDA oDa = new IndicadorMensualDA();

       public DataSet ProcesarIndicadorMensual(IndicadorMensualBE BE)
       {
           return oDa.ProcesarIndicadorMensual(BE);
       }
   }
}

