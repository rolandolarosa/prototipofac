using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitud(SolicitudBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Solicitud_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               if (BE.dtSolicitud != DateTime.MinValue) { db.AddInParameter(cmd, "dtSolicitud", DbType.DateTime, BE.dtSolicitud); }
               db.AddInParameter(cmd, "IdPersonaSolicitud", DbType.String, BE.IdPersonaSolicitud);
               db.AddInParameter(cmd, "IdArea_tt", DbType.String, BE.IdArea_tt);
               db.AddInParameter(cmd, "IdTipoSolicitud_tt", DbType.String, BE.IdTipoSolicitud_tt);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "cRucSocio", DbType.String, BE.cRucSocio);
               db.AddInParameter(cmd, "vRazonSocialSocio", DbType.String, BE.vRazonSocialSocio);
               db.AddInParameter(cmd, "vConyugue", DbType.String, BE.vConyugue);
               db.AddInParameter(cmd, "vConyugueDNI", DbType.String, BE.vConyugueDNI);
               db.AddInParameter(cmd, "vConyugueDomicilio", DbType.String, BE.vConyugueDomicilio);
               db.AddInParameter(cmd, "NroPartidaSB", DbType.String, BE.NroPartidaSB);
               if (BE.dtVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "dtNroPartidaDB", DbType.DateTime, BE.dtNroPartidaDB); }
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "cRucPagadora", DbType.String, BE.cRucPagadora);
               db.AddInParameter(cmd, "vRazonSocialPagadora", DbType.String, BE.vRazonSocialPagadora);
               db.AddInParameter(cmd, "IdTipoLinea_tt", DbType.String, BE.IdTipoLinea_tt);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nImporte", DbType.Decimal, BE.nImporte);
               db.AddInParameter(cmd, "nTEA", DbType.Decimal, BE.nTEA);
               db.AddInParameter(cmd, "nTEAMinDol", DbType.Decimal, BE.nTEAMinDol);
               db.AddInParameter(cmd, "nTEAMaxSol", DbType.Decimal, BE.nTEAMaxSol);
               db.AddInParameter(cmd, "nTEAMaxDol", DbType.Decimal, BE.nTEAMaxDol);
               db.AddInParameter(cmd, "iPlazo", DbType.Int32, BE.iPlazo);
               db.AddInParameter(cmd, "iPlanPago", DbType.Int32, BE.iPlanPago);
               if (BE.dtVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "dtVencimiento", DbType.DateTime, BE.dtVencimiento); }
               if (BE.dtEnvioLegal != DateTime.MinValue) { db.AddInParameter(cmd, "dtEnvioLegal", DbType.DateTime, BE.dtEnvioLegal); }
               db.AddInParameter(cmd, "vDomicilioRealPag", DbType.String, BE.vDomicilioRealPag);
               db.AddInParameter(cmd, "vDomicilioLegalPag", DbType.String, BE.vDomicilioLegalPag);
               db.AddInParameter(cmd, "vPartidaElectronica", DbType.String, BE.vPartidaElectronica);
               db.AddInParameter(cmd, "vDomicilioRealSoc", DbType.String, BE.vDomicilioRealSoc);
               db.AddInParameter(cmd, "vDomicilioAnexoSoc", DbType.String, BE.vDomicilioAnexoSoc);
               db.AddInParameter(cmd, "vObjetoSocial", DbType.String, BE.vObjetoSocial);
               db.AddInParameter(cmd, "vCapSocialSoc", DbType.String, BE.vCapSocialSoc);
               db.AddInParameter(cmd, "IdPersonaLegal", DbType.String, BE.IdPersonaLegal);
               if (BE.dtEnvioRiego != DateTime.MinValue) { db.AddInParameter(cmd, "dtEnvioRiego", DbType.DateTime, BE.dtEnvioRiego); }
               db.AddInParameter(cmd, "FlgLetraCambio", DbType.Int32, BE.FlgLetraCambio);
               db.AddInParameter(cmd, "FlgVerHistoricos", DbType.Int32, BE.FlgVerHistoricos);
               db.AddInParameter(cmd, "IdEstado_tt", DbType.String, BE.IdEstado_tt);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }
   }
}

