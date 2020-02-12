using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class EmpresaTopLineaBL
   {
       EmpresaTopLineaDA EmpresaTopLineaDA = new EmpresaTopLineaDA();

       public DataSet ProcesarEmpresaTopLinea(EmpresaTopLineaBE BE)
       {
           return EmpresaTopLineaDA.ProcesarEmpresaTopLinea(BE);
       }
   }
}

