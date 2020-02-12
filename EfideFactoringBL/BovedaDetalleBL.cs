using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class BovedaDetalleBL
   {
       BovedaDetalleDA BovedaDA = new BovedaDetalleDA();

       public DataSet ProcesarBovedaDetalle(BovedaDetalleBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = BovedaDA.ProcesarBovedaDetalle(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

