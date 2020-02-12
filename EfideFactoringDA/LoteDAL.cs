using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class LoteDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarLote(LoteBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Lote_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               if (BE.gFechaOp != DateTime.MinValue) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, BE.gFechaOp); }
               db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdSocio_Dsc", DbType.String, BE.IdSocio_Dsc);
               db.AddInParameter(cmd, "IdPagadora_Dsc", DbType.String, BE.IdPagadora_Dsc);
               if (BE.sdDesembolso != DateTime.MinValue){ db.AddInParameter(cmd, "sdDesembolso", DbType.DateTime, BE.sdDesembolso);}
               db.AddInParameter(cmd, "IdLinea", DbType.String, BE.IdLinea);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nImporte", DbType.Decimal, BE.nImporte);
               if (BE.sdAprobacion != DateTime.MinValue){ db.AddInParameter(cmd, "sdAprobacion", DbType.DateTime, BE.sdAprobacion);}
               db.AddInParameter(cmd, "nTotal", DbType.Decimal, BE.nTotal);
               db.AddInParameter(cmd, "nAjuste", DbType.Decimal, BE.nAjuste);
               db.AddInParameter(cmd, "nDesembolso", DbType.Decimal, BE.nDesembolso);
               db.AddInParameter(cmd, "IdOperacion_tt", DbType.String, BE.IdOperacion_tt);
               db.AddInParameter(cmd, "IdFormaDesembolso", DbType.Decimal, BE.IdFormaDesembolso);
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
               db.AddInParameter(cmd, "FlgConfimado", DbType.String, BE.FlgConfimado);
               db.AddInParameter(cmd, "FlgEntregado", DbType.String, BE.FlgEntregado);
               db.AddInParameter(cmd, "FlgPendiente", DbType.String, BE.FlgPendiente);
               db.AddInParameter(cmd, "IdFinanciera", DbType.String, BE.IdFinanciera);
               db.AddInParameter(cmd, "iCuota", DbType.Int32, BE.iCuota);
               db.AddInParameter(cmd, "nTotalCuota", DbType.Decimal, BE.nTotalCuota);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public string ProcesarLote(LoteBE oEntity, List<DetaLoteBE> LsEntityDet)
       {
           string strResult = string.Empty;
           DataSet dsResult = new DataSet();
           using (DbConnection conn = db.CreateConnection())
           {
               conn.Open();
               DbTransaction trans = conn.BeginTransaction();
               try
               {
                   cmd = db.GetStoredProcCommand("Lote_Mnt");
                   cmd.CommandTimeout = 0;
                   db.AddInParameter(cmd, "OPCION", DbType.Int32, oEntity.OPCION);
                   db.AddInParameter(cmd, "USUARIO", DbType.String, oEntity.USUARIO);
                   if (oEntity.gFechaOp != DateTime.MinValue) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, oEntity.gFechaOp); }
                   db.AddInParameter(cmd, "IdLote", DbType.String, oEntity.IdLote);
                   db.AddInParameter(cmd, "IdSocio", DbType.String, oEntity.IdSocio);
                   if (oEntity.sdDesembolso != DateTime.MinValue) { db.AddInParameter(cmd, "sdDesembolso", DbType.DateTime, oEntity.sdDesembolso); }
                   db.AddInParameter(cmd, "IdLinea", DbType.String, oEntity.IdLinea);
                   db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, oEntity.IdMoneda_tt);
                   db.AddInParameter(cmd, "nImporte", DbType.Decimal, oEntity.nImporte);
                   if (oEntity.sdAprobacion != DateTime.MinValue) { db.AddInParameter(cmd, "sdAprobacion", DbType.DateTime, oEntity.sdAprobacion); }
                   db.AddInParameter(cmd, "nTotal", DbType.Decimal, oEntity.nTotal);
                   db.AddInParameter(cmd, "nAjuste", DbType.Decimal, oEntity.nAjuste);
                   db.AddInParameter(cmd, "nDesembolso", DbType.Decimal, oEntity.nDesembolso);
                   db.AddInParameter(cmd, "IdOperacion_tt", DbType.String, oEntity.IdOperacion_tt);
                   db.AddInParameter(cmd, "IdFormaDesembolso", DbType.Decimal, oEntity.IdFormaDesembolso);
                   db.AddInParameter(cmd, "IdEstado_tt", DbType.String, oEntity.IdEstado_tt);
                   dsResult = db.ExecuteDataSet(cmd, trans);

                   foreach (DetaLoteBE IEntity in LsEntityDet)
                   {
                       cmd = db.GetStoredProcCommand("DetaLote_Mnt");
                       db.AddInParameter(cmd, "OPCION", DbType.Int32, IEntity.OPCION);
                       db.AddInParameter(cmd, "USUARIO", DbType.String, IEntity.USUARIO);
                       db.AddInParameter(cmd, "IdLote", DbType.String, dsResult.Tables[0].Rows[0]["IdLote"].ToString());
                       db.AddInParameter(cmd, "cItem", DbType.String, IEntity.cItem);
                       db.AddInParameter(cmd, "IdPagadora", DbType.String, IEntity.IdPagadora);
                       db.AddInParameter(cmd, "IdDocumento", DbType.String, IEntity.IdDocumento);
                       db.AddInParameter(cmd, "IdSocio_Beneficiario", DbType.String, IEntity.IdSocio_Beneficiario);
                       db.AddInParameter(cmd, "IdSocio_BeneficiarioRuc", DbType.String, IEntity.IdSocio_BeneficiarioRuc);
                       db.AddInParameter(cmd, "cNumDoc", DbType.String, IEntity.cNumDoc);
                       if (IEntity.sdRecepcion != DateTime.MinValue) { db.AddInParameter(cmd, "sdRecepcion", DbType.DateTime, IEntity.sdRecepcion); }
                       db.AddInParameter(cmd, "iPlazo", DbType.Int32, IEntity.iPlazo);
                       if (IEntity.sdVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "sdVencimiento", DbType.DateTime, IEntity.sdVencimiento); }
                       db.AddInParameter(cmd, "nvNominal", DbType.Decimal, IEntity.nvNominal);
                       db.AddInParameter(cmd, "cNotaCredito", DbType.String, IEntity.cNotaCredito);
                       db.AddInParameter(cmd, "nNotaCredito", DbType.Decimal, IEntity.nNotaCredito);
                       db.AddInParameter(cmd, "nPorRetencion", DbType.Decimal, IEntity.nPorRetencion);
                       db.AddInParameter(cmd, "nvRetencion", DbType.Decimal, IEntity.nvRetencion);
                       db.AddInParameter(cmd, "Descuento", DbType.Decimal, IEntity.Descuento);
                       db.AddInParameter(cmd, "nvNegociable", DbType.Decimal, IEntity.nvNegociable);
                       db.AddInParameter(cmd, "nTazaActiva", DbType.Decimal, IEntity.nTazaActiva);
                       db.AddInParameter(cmd, "nFondoGarantia", DbType.Decimal, IEntity.nFondoGarantia);
                       db.AddInParameter(cmd, "nTasaSobregiro", DbType.Decimal, IEntity.nTasaSobregiro);
                       db.ExecuteDataSet(cmd, trans);
                       strResult = dsResult.Tables[0].Rows[0]["IdLote"].ToString();
                   }
                   trans.Commit();
               }
               catch (Exception ex)
               {
                   strResult = string.Empty;
                   trans.Rollback();
                   throw new Exception(ex.Message);
               }
               finally
               {
                   conn.Close();
               }
           }
           return strResult;
       }

       public bool ProcesarLoteExtornacion(LoteBE BE)
       {
           bool bResult = true;
           using (DbConnection conn = db.CreateConnection())
           {
               conn.Open();
               DbTransaction trans = conn.BeginTransaction();
               try
               {
                   foreach (DataRow dr in BE.dtLote.Rows)
                   {
                       cmd = db.GetStoredProcCommand("Lote_Mnt");
                       cmd.CommandTimeout = 0;
                       db.AddInParameter(cmd, "OPCION", DbType.Int32, dr["OPCION"]);
                       db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                       if (BE.gFechaOp != DateTime.MinValue) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, BE.gFechaOp); }
                       db.AddInParameter(cmd, "IdLote", DbType.String, dr["IdLote"].ToString());
                       db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
                       db.ExecuteNonQuery(cmd, trans);
                       //db.ExecuteNonQuery(cmd);
                       bResult = true;
                   }
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

       public DataSet ProcesarRptLote(LoteBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Rpt_Lote");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               //db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataTable ProcesarRptLoteCab(String strIdLote)
       {
           DataTable dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Rpt_Lote_Cab");
               db.AddInParameter(cmd, "IdLote", DbType.String, strIdLote);
               dsResult = db.ExecuteDataSet(cmd).Tables[0];
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataTable ProcesarRptLoteDet(String strIdLote)
       {
           DataTable dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Rpt_Lote_Det");
               db.AddInParameter(cmd, "IdLote", DbType.String, strIdLote);
               dsResult = db.ExecuteDataSet(cmd).Tables[0];
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet DesembolsoDet (Int32 Opcion,String IdLote,  Decimal IdFormaDesembolso,
           String comunCuentaID, Decimal? importe , Decimal? tipoCambio)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("DesembolsoDet_Mant");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdLote", DbType.String, IdLote);
               db.AddInParameter(cmd, "IdFormaDesembolso", DbType.Decimal, IdFormaDesembolso);
               db.AddInParameter(cmd, "comunCuentaID", DbType.String, comunCuentaID);
               db.AddInParameter(cmd, "importe", DbType.Decimal, importe);               
               db.AddInParameter(cmd, "tipoCambio", DbType.Decimal, tipoCambio);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       /*
        * Enviar Correo de Confirmacion y Confirmar Pagadora
       */
       public string ProcesarLoteEnvioConfirmacion(List<LoteBE> LsEntity)
       {
           string strResult = string.Empty;
           DataSet dsResult;
           using (DbConnection conn = db.CreateConnection())
           {
               conn.Open();
               DbTransaction trans = conn.BeginTransaction();
               try
               {
                   foreach (LoteBE IEntity in LsEntity)
                   {
                       cmd = db.GetStoredProcCommand("Lote_Mnt");
                       cmd.CommandTimeout = 0;
                       db.AddInParameter(cmd, "OPCION", DbType.Int32, IEntity.OPCION);
                       db.AddInParameter(cmd, "USUARIO", DbType.String,IEntity.USUARIO);
                       db.AddInParameter(cmd, "IdLote", DbType.String, IEntity.IdLote);
                       db.AddInParameter(cmd, "cItem", DbType.String, IEntity.cItem);
                       if (IEntity.gFechaOp != DateTime.MinValue) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, IEntity.gFechaOp); }
                       dsResult = db.ExecuteDataSet(cmd, trans);
                     
                       if (dsResult.Tables.Count > 0)
                       {
                           if (dsResult.Tables[0].Columns.Contains("Mensaje"))
                           {
                               strResult = strResult + dsResult.Tables[0].Rows[0]["Mensaje"].ToString() + "; ";
                           }
                       }
                   }
                   trans.Commit();
               }
               catch (Exception ex)
               {
                   strResult = ex.Message;
                   trans.Rollback();
                   throw new Exception(ex.Message);
               }
               finally
               {
                   conn.Close();
               }
           }
           return strResult;
       }


       public DataTable ProcesarRptComercial(int Annio, int Mes, decimal TipCam)
       {
           DataTable dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Rpt_Comercial");
               db.AddInParameter(cmd, "Annio", DbType.Int32, Annio);
               db.AddInParameter(cmd, "Mes", DbType.Int32, Mes);
               db.AddInParameter(cmd, "TipCam", DbType.Decimal, TipCam);
               dsResult = db.ExecuteDataSet(cmd).Tables[0];
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }
   }
}

