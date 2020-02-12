using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.ComponentModel;

namespace EfideFactoringBL
{
   public class CobranzaBL
   {
       CobranzaDA CobranzaDA = new CobranzaDA();

       public DataSet ProcesarCobranza(CobranzaBE BE)
       {
           return CobranzaDA.ProcesarCobranza(BE);
       }

       public bool ProcesarCobranza(CobranzaBE BE, BindingList<CobranzaDetalleBE> LstCobranzaDetalle)
       {
           return CobranzaDA.ProcesarCobranza(BE, LstCobranzaDetalle);
       }
   }
}


