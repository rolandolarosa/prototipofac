using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class TipoSolicitudFormatoBL
   {
       TipoSolicitudFormatoDA oEntityDA = new TipoSolicitudFormatoDA();

       public DataSet ProcesarTipoSolicitudFormato(TipoSolicitudFormatoBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = oEntityDA.ProcesarTipoSolicitudFormato(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

