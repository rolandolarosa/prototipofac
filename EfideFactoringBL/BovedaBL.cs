using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class BovedaBL
   {
       BovedaDA BovedaDA = new BovedaDA();

       public DataSet ProcesarBoveda(BovedaBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = BovedaDA.ProcesarBoveda(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

