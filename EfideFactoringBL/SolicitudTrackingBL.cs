using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudTrackingBL
   {
       SolicitudTrackingDA SolicitudTrackingDA = new SolicitudTrackingDA();

       public DataSet ProcesarSolicitudTracking(SolicitudTrackingBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudTrackingDA.ProcesarSolicitudTracking(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

