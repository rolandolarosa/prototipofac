using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudRepresentanteBL
   {
       SolicitudRepresentanteDA SolicitudRepresentanteDA = new SolicitudRepresentanteDA();

       public DataSet ProcesarSolicitudRepresentante(SolicitudRepresentanteBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudRepresentanteDA.ProcesarSolicitudRepresentante(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

