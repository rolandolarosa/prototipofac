using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class LimiteCreditoLogBL
   {
       LimiteCreditoLogDAL LimiteCreditoLogDA = new LimiteCreditoLogDAL();

       public DataSet ProcesarLimiteCreditoLog(LimiteCreditoLogBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = LimiteCreditoLogDA.ProcesarLimiteCreditoLog(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

