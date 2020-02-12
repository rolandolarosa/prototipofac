using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class TelefonoTDBL
   {
       TelefonoTDDA TelefonoTDDA = new TelefonoTDDA();

       public DataSet ProcesarTelefonoTDDA(TelefonoTDBE BE)
       {
           return TelefonoTDDA.ProcesarTelefonoTD(BE);
       }
   }
}

