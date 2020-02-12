using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class CarteraSocioBL
   {
       CarteraSocioDA CarteraSocioDA = new CarteraSocioDA();

       public DataSet ProcesarCarteraSocio(CarteraSocioBE BE)
       {
           return CarteraSocioDA.ProcesarCarteraSocio(BE);
       }
   }
}

