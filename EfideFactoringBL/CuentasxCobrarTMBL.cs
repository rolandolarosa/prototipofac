using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class CuentasxCobrarTMBL
   {
       CuentasxCobrarTMDA CuentasxCobrarTMDA = new CuentasxCobrarTMDA();

       public DataSet ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE BE)
       {
           return CuentasxCobrarTMDA.ProcesarCuentasxCobrarTM(BE);
       }
   }
}

