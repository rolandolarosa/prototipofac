using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.ComponentModel;

namespace EfideFactoringBL
{
   public class PagadoraEventosBL
   {
       PagadoraEventosDA oDatos = new PagadoraEventosDA();

       public DataSet ProcesarCobranza(PagadoraEventosBE BE)
       {
           return oDatos.ProcesarPagadoraEventos(BE);
       }
   }
}


