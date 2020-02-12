using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class CarteraCandidatoBL
   {
       CarteraCandidatoDA CarteraCandidatoDA = new CarteraCandidatoDA();

       public DataSet ProcesarCarteraCandidato(CarteraCandidatoBE BE)
       {
           return CarteraCandidatoDA.ProcesarCarteraCandidato(BE);
       }
   }
}

