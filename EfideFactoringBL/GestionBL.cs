using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class GestionBL
   {
       GestionDA GestionDA = new GestionDA();

       public DataSet ProcesarGestion(GestionBE BE)
       {
           return GestionDA.ProcesarGestion(BE);
       }
   }
}

