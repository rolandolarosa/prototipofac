using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PagadoraContactoBL
   {
       PagadoraContactoDA PagadoraContactoDA = new PagadoraContactoDA();

       public DataSet ProcesarPagadoraContacto(PagadoraContactoBE BE)
       {
           return PagadoraContactoDA.ProcesarPagadoraContacto(BE);
       }
   }
}

