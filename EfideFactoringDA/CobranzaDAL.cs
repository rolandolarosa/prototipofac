using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class CobranzaDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarCobranza(CobranzaBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Cobranza_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdCobranza", DbType.String, BE.IdCobranza);
               if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
               if (BE.dtValuta != DateTime.MinValue) { db.AddInParameter(cmd, "dtValuta", DbType.DateTime, BE.dtValuta); }
               db.AddInParameter(cmd, "IdTipoCobranza_tt", DbType.String, BE.IdTipoCobranza_tt);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "CtasBancariasID", DbType.String, BE.CtasBancariasID);
               db.AddInParameter(cmd, "nTotal", DbType.Decimal, BE.nTotal);
               db.AddInParameter(cmd, "IdOperacion_tt", DbType.String, BE.IdOperacion_tt);
               db.AddInParameter(cmd, "IdTipoAbono_tt", DbType.String, BE.IdTipoAbono_tt);
               db.AddInParameter(cmd, "DatosAdicionales", DbType.String, BE.DatosAdicionales);
               db.AddInParameter(cmd, "socioBancoID", DbType.String, BE.socioBancoID);
               db.AddInParameter(cmd, "Entidad", DbType.String, BE.Entidad);
               db.AddInParameter(cmd, "Status", DbType.String, BE.Status);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public bool ProcesarCobranza(CobranzaBE BE, BindingList<CobranzaDetalleBE> LstCobranzaDetalle)
       {
           bool bResult = false;
           using (DbConnection conn = db.CreateConnection())
           {
               conn.Open();
               DbTransaction trans = conn.BeginTransaction();
               try
               {
                   cmd = db.GetStoredProcCommand("Cobranza_Mnt");
                   db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                   db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                   db.AddInParameter(cmd, "IdCobranza", DbType.String, BE.IdCobranza);
                   if (BE.dtRegistro != DateTime.MinValue) { db.AddInParameter(cmd, "dtRegistro", DbType.DateTime, BE.dtRegistro); }
                   if (BE.dtValuta != DateTime.MinValue) { db.AddInParameter(cmd, "dtValuta", DbType.DateTime, BE.dtValuta); }
                   db.AddInParameter(cmd, "IdTipoCobranza_tt", DbType.String, BE.IdTipoCobranza_tt);
                   db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
                   db.AddInParameter(cmd, "CtasBancariasID", DbType.String, BE.CtasBancariasID);
                   db.AddInParameter(cmd, "nTotal", DbType.Decimal, BE.nTotal);
                   db.AddInParameter(cmd, "IdOperacion_tt", DbType.String, BE.IdOperacion_tt);
                   db.AddInParameter(cmd, "IdTipoAbono_tt", DbType.String, BE.IdTipoAbono_tt);
                   db.AddInParameter(cmd, "DatosAdicionales", DbType.String, BE.DatosAdicionales);
                   db.AddInParameter(cmd, "socioBancoID", DbType.String, BE.socioBancoID);
                   db.AddInParameter(cmd, "Entidad", DbType.String, BE.Entidad);
                   db.AddInParameter(cmd, "Status", DbType.String, BE.Status);
                   db.ExecuteDataSet(cmd, trans);

                   foreach (var item in LstCobranzaDetalle)
                   {
                       cmd = db.GetStoredProcCommand("CobranzaDetalle_Mnt");
                       db.AddInParameter(cmd, "OPCION", DbType.Int32, 5);
                       db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                       db.AddInParameter(cmd, "IdCobranza", DbType.String, BE.IdCobranza);
                       db.AddInParameter(cmd, "valorMonedaID", DbType.Int16, BE.iMonedaID);
                       db.AddInParameter(cmd, "gSesionID", DbType.String, BE.gSesionID);
                       db.AddInParameter(cmd, "gPlazaID", DbType.String, BE.gPlazaID);
                       db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, BE.gFechaOp);
                       db.AddInParameter(cmd, "socioBancoID", DbType.String, BE.socioBancoID);
                       db.AddInParameter(cmd, "IdLote", DbType.String, item.IdLote);
                       db.AddInParameter(cmd, "cItem", DbType.String, item.cItem);
                       db.AddInParameter(cmd, "IdDocumento", DbType.String, item.IdDocumento);
                       db.AddInParameter(cmd, "IdSocio", DbType.String, item.IdSocio);
                       db.AddInParameter(cmd, "cNumDoc", DbType.String, item.cNumDoc);
                       db.AddInParameter(cmd, "nVNominal", DbType.Decimal, item.nvNominal);
                       //db.AddInParameter(cmd, "nvNegociable", DbType.Decimal, item.nvNegociable);
                       db.AddInParameter(cmd, "nvImporte", DbType.Decimal, item.nvImporte);
                       db.AddInParameter(cmd, "DifCobrada", DbType.Decimal, item.DifCobrada);
                       db.AddInParameter(cmd, "Interes", DbType.Decimal, item.Interes);
                       db.AddInParameter(cmd, "Garantia", DbType.Decimal, item.Garantia);
                       db.AddInParameter(cmd, "IdPagadora", DbType.String, item.IdPagadora);
                       db.ExecuteDataSet(cmd, trans);
                   }
                    // Actualiza Lineas
                   //cmd = db.GetStoredProcCommand("Cobranza_Mnt");
                   //db.AddInParameter(cmd, "OPCION", DbType.Int32, 12);
                   //db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                   //db.AddInParameter(cmd, "IdCobranza", DbType.String, BE.IdCobranza);
                   //db.ExecuteDataSet(cmd, trans);

                   bResult = true;
                   trans.Commit();
               }
               catch (Exception ex)
               {
                   bResult = false;
                   trans.Rollback();
                   
                   throw new Exception(ex.Message);
               }
               finally
               {
                   conn.Close();
               }

           }
           return bResult;
       }
   }
}

