using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class GrupoPagadoraDetalleBL
   {
       GrupoPagadoraDetalleDA GrupoPagadoraDetalleDA = new GrupoPagadoraDetalleDA();

       public DataSet ProcesarGrupoPagadoraDetalle(GrupoPagadoraDetalleBE BE)
       {
           return GrupoPagadoraDetalleDA.ProcesarGrupoPagadoraDetalle(BE);
       }
   }
}

