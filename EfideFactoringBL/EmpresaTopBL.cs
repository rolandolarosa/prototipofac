using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class EmpresaTopBL
   {
       EmpresaTopDA EmpresaTopDA = new EmpresaTopDA();

       public DataSet ProcesarEmpresaTop(EmpresaTopBE BE)
       {
           return EmpresaTopDA.ProcesarEmpresaTop(BE);
       }
   }
}

