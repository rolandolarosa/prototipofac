using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudCheckListBL
   {
       SolicitudCheckListDA SolicitudCheckListDA = new SolicitudCheckListDA();

       public DataSet ProcesarSolicitudCheckList(SolicitudCheckListBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudCheckListDA.ProcesarSolicitudCheckList(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

