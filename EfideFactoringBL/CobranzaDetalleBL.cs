using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class CobranzaDetalleBL
   {
       CobranzaDetalleDA CobranzaDetalleDA = new CobranzaDetalleDA();

       public DataSet ProcesarCobranzaDetalle(CobranzaDetalleBE BE)
       {
           return CobranzaDetalleDA.ProcesarCobranzaDetalle(BE);
       }
   }
}

