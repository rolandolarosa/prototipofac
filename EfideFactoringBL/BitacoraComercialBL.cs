using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class BitacoraComercialBL
   {
       BitacoraComercialDA BitacoraComercialDA = new BitacoraComercialDA();

       public DataSet ProcesarBitacoraComercial(BitacoraComercialBE BE)
       {
           return BitacoraComercialDA.ProcesarBitacoraComercial(BE);
       }
   }
}

