using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class SolicitudFacultadBL
   {
       SolicitudFacultadDA SolicitudFacultadDA = new SolicitudFacultadDA();

       public DataSet ProcesarSolicitudFacultad(SolicitudFacultadBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = SolicitudFacultadDA.ProcesarSolicitudFacultad(BE);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }
   }
}

