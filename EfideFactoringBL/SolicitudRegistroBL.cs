using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudRegistroBL
   {
       SolicitudRegistroDA SolicitudRegistroDA = new SolicitudRegistroDA();

       public DataSet ProcesarSolicitudRegistro(SolicitudRegistroBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudRegistroDA.ProcesarSolicitudRegistro(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

