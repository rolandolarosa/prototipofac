using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudBL
   {
       SolicitudDA SolicitudDA = new SolicitudDA();

       public DataSet ProcesarSolicitud(SolicitudBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudDA.ProcesarSolicitud(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

