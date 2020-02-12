using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class DetaLoteBL
   {
       DetaLoteDA DetaLoteDA = new DetaLoteDA();

       public DataSet ProcesarDetaLote(DetaLoteBE BE)
       {
           return DetaLoteDA.ProcesarDetaLote(BE);
       }
   }
}

