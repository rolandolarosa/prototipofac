using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class RepositorioTopBL
   {
       RepositorioTopDA RepositorioTopDA = new RepositorioTopDA();

       public DataSet ProcesarRepositorioTop(RepositorioTopBE BE)
       {
           return RepositorioTopDA.ProcesarRepositorioTop(BE);
       }
   }
}

