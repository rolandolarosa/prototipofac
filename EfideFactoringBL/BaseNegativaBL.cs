using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class BaseNegativaBL
   {
       BaseNegativaDA BaseNegativaDA = new BaseNegativaDA();

       public DataSet ProcesarBaseNegativa(BaseNegativaBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = BaseNegativaDA.ProcesarBaseNegativa(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

