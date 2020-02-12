using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class GestionPagadoraBL
   {
       GestionPagadoraDA GestionPagadoraDA = new GestionPagadoraDA();

       public DataSet ProcesarGestionPagadora(GestionPagadoraBE BE)
       {
           return GestionPagadoraDA.ProcesarGestionPagadora(BE);
       }
   }
}

