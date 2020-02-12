using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class UbigeoBL
   {
       UbigeoDA UbigeoDA = new UbigeoDA();

       public DataSet ProcesarUbigeo(UbigeoBE BE)
       {
           return UbigeoDA.ProcesarUbigeo(BE);
       }
   }
}

