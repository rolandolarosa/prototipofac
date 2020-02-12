using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class CuentasxCobrarTMDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarCuentasxCobrarTM(CuentasxCobrarTMBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("CuentasMovimientos_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "gPlazaID", DbType.String, BE.gPlazaID);
               if (BE.gFechaOp != DateTime.MinValue) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, BE.gFechaOp); }
               db.AddInParameter(cmd, "ctaCobrarID", DbType.String, BE.ctaCobrarID);
               db.AddInParameter(cmd, "clienteID", DbType.String, BE.clienteID);
               db.AddInParameter(cmd, "tipCxcID", DbType.String, BE.tipCxcID);
               db.AddInParameter(cmd, "referenciaID", DbType.String, BE.referenciaID);
               db.AddInParameter(cmd, "cxcImpComis", DbType.Decimal, BE.cxcImpComis);
               db.AddInParameter(cmd, "cxcImpComp", DbType.Decimal, BE.cxcImpComp);
               db.AddInParameter(cmd, "cxcNumCuotas", DbType.Int32, BE.cxcNumCuotas);
               db.AddInParameter(cmd, "cxcPeriodicidad", DbType.Int32, BE.cxcPeriodicidad);
               if (BE.cxcFecEmision != DateTime.MinValue){ db.AddInParameter(cmd, "cxcFecEmision", DbType.DateTime, BE.cxcFecEmision);}
               if (BE.cxcFecInicio != DateTime.MinValue){ db.AddInParameter(cmd, "cxcFecInicio", DbType.DateTime, BE.cxcFecInicio);}
               if (BE.cxcFechaCrea != DateTime.MinValue){ db.AddInParameter(cmd, "cxcFechaCrea", DbType.DateTime, BE.cxcFechaCrea);}
               if (BE.cxcFechaMod != DateTime.MinValue){ db.AddInParameter(cmd, "cxcFechaMod", DbType.DateTime, BE.cxcFechaMod);}
               db.AddInParameter(cmd, "cxcUsuarioCrea", DbType.String, BE.cxcUsuarioCrea);
               db.AddInParameter(cmd, "cxcUsuarioMod", DbType.String, BE.cxcUsuarioMod);
               db.AddInParameter(cmd, "cxcEstado", DbType.Boolean, BE.cxcEstado);
               db.AddInParameter(cmd, "cxcImpSaldoComp", DbType.Decimal, BE.cxcImpSaldoComp);
               db.AddInParameter(cmd, "cxcImpSaldoComis", DbType.Decimal, BE.cxcImpSaldoComis);
               db.AddInParameter(cmd, "valorEstadoCxCID", DbType.Decimal, BE.valorEstadoCxCID);
               if (BE.cxcFechaCan != DateTime.MinValue){ db.AddInParameter(cmd, "cxcFechaCan", DbType.DateTime, BE.cxcFechaCan);}
               db.AddInParameter(cmd, "valorFormaPagoID", DbType.Decimal, BE.valorFormaPagoID);
               db.AddInParameter(cmd, "cxcImporteDesc", DbType.Decimal, BE.cxcImporteDesc);
               db.AddInParameter(cmd, "gesCuentaID", DbType.String, BE.gesCuentaID);
               db.AddInParameter(cmd, "gesCobranzaID", DbType.String, BE.gesCobranzaID);
               db.AddInParameter(cmd, "valorTipoDesemID", DbType.Decimal, BE.valorTipoDesemID);
               db.AddInParameter(cmd, "numOperacion", DbType.String, BE.numOperacion);
               db.AddInParameter(cmd, "cxcDiaPagoFijo", DbType.Int32, BE.cxcDiaPagoFijo);
               db.AddInParameter(cmd, "cxcGlosa", DbType.String, BE.cxcGlosa);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
               db.AddInParameter(cmd, "Tipo", DbType.String, BE.Tipo);
               db.AddInParameter(cmd, "valorMonedaID", DbType.Decimal, BE.valorMonedaID);
               db.AddInParameter(cmd, "Monto", DbType.Decimal, BE.Monto);
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

