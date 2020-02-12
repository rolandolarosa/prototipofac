using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudDocumentoBL
   {
       SolicitudDocumentoDA SolicitudDocumentoDA = new SolicitudDocumentoDA();

       public DataSet ProcesarSolicitudDocumento(SolicitudDocumentoBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudDocumentoDA.ProcesarSolicitudDocumento(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

