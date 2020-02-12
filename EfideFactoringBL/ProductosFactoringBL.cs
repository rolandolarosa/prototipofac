using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class ProductosFactoringBL
   {
       ProductosFactoringDA ProductosFactoringDA = new ProductosFactoringDA();

       public DataSet ProcesarProductosFactoring(ProductosFactoringBE BE)
       {
           return ProductosFactoringDA.ProcesarProductosFactoring(BE);
       }
   }
}

