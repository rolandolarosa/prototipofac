using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class CuentasxPagarTMBloqueoBL
   {
       CuentasxPagarTMBloqueoDA CuentasxPagarTMBloqueoDA = new CuentasxPagarTMBloqueoDA();

       public DataSet ProcesarCuentasxPagarTMBloqueo(CuentasxPagarTMBloqueoBE BE)
       {
           return CuentasxPagarTMBloqueoDA.ProcesarCuentasxPagarTMBloqueo(BE);
       }
   }
}

