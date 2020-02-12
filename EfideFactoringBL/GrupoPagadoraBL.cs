using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class GrupoPagadoraBL
   {
       GrupoPagadoraDA GrupoPagadoraDA = new GrupoPagadoraDA();

       public DataSet ProcesarGrupoPagadora(GrupoPagadoraBE BE)
       {
           return GrupoPagadoraDA.ProcesarGrupoPagadora(BE);
       }
   }
}

