using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.ComponentModel;

namespace EfideFactoringBL
{
   public class MovimientoBL
   {
       MovimientoDA MovimientoDA = new MovimientoDA();

       public DataSet ProcesarMovimiento(MovimientoBE BE)
       {
           return MovimientoDA.ProcesarMovimiento(BE);
       }
   }
}


