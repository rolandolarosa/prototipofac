using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PagadoraAutorizaDocBL
   {
       PagadoraAutorizaDocDAL PagadoraAutorizaDocDA = new PagadoraAutorizaDocDAL();

       public DataSet ProcesarPagadoraAutorizaDoc(PagadoraAutorizaDocBE BE)
       {
           return PagadoraAutorizaDocDA.ProcesarPagadoraAutorizaDoc(BE);
       }
   }
}

