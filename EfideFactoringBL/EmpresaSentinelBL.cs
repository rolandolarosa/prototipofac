using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class EmpresaSentinelBL
   {
       EmpresaSentinelDA EmpresaSentinelDA = new EmpresaSentinelDA();

       public DataSet ProcesarEmpresaSentinel(EmpresaSentinelBE BE)
       {
           return EmpresaSentinelDA.ProcesarEmpresaSentinel(BE);
       }
   }
}

