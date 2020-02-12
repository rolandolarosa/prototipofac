using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class TableBaseBL
   {
       TableBaseDA TableBaseDA = new TableBaseDA();

       public DataSet ProcesarTableBase(TableBaseBE BE)
       {
           return TableBaseDA.ProcesarTableBase(BE);
       }
   }
}

