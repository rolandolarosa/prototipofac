using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class BovedaTrackingBL
   {
       BovedaTrackingDA BovedaTrackingDA = new BovedaTrackingDA();

       public DataSet ProcesarBovedaTracking(BovedaTrackingBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = BovedaTrackingDA.ProcesarBovedaTracking(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

