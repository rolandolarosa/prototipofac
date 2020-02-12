using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class LoteBL
   {
       LoteDA LoteDA = new LoteDA();

       public DataSet ProcesarLote(LoteBE BE)
       {
           DataSet dsRet = new DataSet();
           try
           {
               dsRet = LoteDA.ProcesarLote(BE);
               if (BE.OPCION == 2)
               {
                   String retIdLote = dsRet.Tables[0].Rows[0]["IdLote"].ToString();
                   LoteDA.DesembolsoDet(BE.OPCION, retIdLote, BE.IdFormaDesembolso, BE.jComunCuentaID,
                       BE.jImporteAho, BE.jTipoCambio);
               }
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsRet;
       }

       public string ProcesarLote(LoteBE oEntity, List<DetaLoteBE> LsEntityDet)
       {
           string strResult = string.Empty;
           try
           {
               strResult = LoteDA.ProcesarLote(oEntity, LsEntityDet);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return strResult;
       }

       public bool ProcesarLoteExtornacion(LoteBE BE)
       {
           return LoteDA.ProcesarLoteExtornacion(BE);
       }

       public DataSet ProcesarRptLote(LoteBE BE)
       {
           return LoteDA.ProcesarRptLote(BE);
       }

       public DataTable ProcesarRptLoteCab(String strIdLote)
       {
           return LoteDA.ProcesarRptLoteCab(strIdLote);
       }

       public DataTable ProcesarRptLoteDet(String strIdLote)
       {
           return LoteDA.ProcesarRptLoteDet(strIdLote);
       }

       public string ProcesarLoteEnvioConfirmacion(List<LoteBE> LstEntity)
       {
           return LoteDA.ProcesarLoteEnvioConfirmacion(LstEntity);
       }

       public DataTable ProcesarRptComercial (int Annio, int Mes, decimal TipCam)
       {
           return LoteDA.ProcesarRptComercial(Annio, Mes, TipCam);
       }


   }
}

