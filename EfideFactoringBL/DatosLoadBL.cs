using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class DatosLoadBL
   {
        DatosLoadDA DatosLoadDA = new DatosLoadDA();

       public DataSet ProcesarDatosLoad(DatosLoadBE BE)
       {
           return DatosLoadDA.ProcesarDatosLoad(BE);
       }
   }
}

