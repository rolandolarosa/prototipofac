using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class CobranzaDetalleDA
    {

        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarCobranzaDetalle(CobranzaDetalleBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("CobranzaDetalle_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdCobranza", DbType.String, BE.IdCobranza);
                db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
                db.AddInParameter(cmd, "cNumDoc", DbType.String, BE.cNumDoc);
                db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
                db.AddInParameter(cmd, "cItem", DbType.String, BE.cItem);
                db.AddInParameter(cmd, "nVNominal", DbType.Decimal, BE.nvNominal);
                db.AddInParameter(cmd, "nvMontoCobrar", DbType.Decimal, BE.nvMontoCobrar);
                db.AddInParameter(cmd, "nSaldo", DbType.Decimal, BE.nSaldo);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                db.AddInParameter(cmd, "nCapital", DbType.Decimal, BE.nCapital);
                db.AddInParameter(cmd, "nIntereses", DbType.Decimal, BE.nIntereses);
                db.AddInParameter(cmd, "nGarantia", DbType.Decimal, BE.nGarantia);
                db.AddInParameter(cmd, "nDias", DbType.Int32, BE.nDias);
                db.AddInParameter(cmd, "cNumOpe", DbType.String, BE.cNumOpe);
                db.AddInParameter(cmd, "nvImporte", DbType.String, BE.nvImporte);
                if (BE.sdFechaOp != DateTime.MinValue) { db.AddInParameter(cmd, "gFechaOp", DbType.DateTime, BE.sdFechaOp); }
                db.AddInParameter(cmd, "gSesionID", DbType.String, BE.gSesionID);
                db.AddInParameter(cmd, "gPlazaID", DbType.String, BE.gPlazaID);
                db.AddInParameter(cmd, "valorMonedaID", DbType.Int16, BE.valorMonedaID);
                db.AddInParameter(cmd, "socioBancoID", DbType.String, BE.socioBancoID);
                db.AddInParameter(cmd, "ctasBancariaID", DbType.String, BE.ctasBancariaID);
                db.AddInParameter(cmd, "DifCobrada", DbType.Decimal, BE.DifCobrada);
                db.AddInParameter(cmd, "DiasMora", DbType.Int32, BE.DiasMora);
                db.AddInParameter(cmd, "Interes", DbType.Decimal, BE.Interes);
                db.AddInParameter(cmd, "Garantia", DbType.Decimal, BE.Garantia);
                if (BE.sdVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "sdVencimiento", DbType.DateTime, BE.sdVencimiento); }
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

