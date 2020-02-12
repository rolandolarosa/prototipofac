using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class RenovacionDetDAL
    {
        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarRenovacionDet(RenovacionDetBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("RenovacionDet_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdRenovacion", DbType.String, BE.IdRenovacion);
                db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
                db.AddInParameter(cmd, "cItem", DbType.String, BE.cItem);
                db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
                db.AddInParameter(cmd, "cNumDoc", DbType.String, BE.cNumDoc);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                if (BE.sdVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "sdVencimiento", DbType.DateTime, BE.sdVencimiento); }
                db.AddInParameter(cmd, "iVencimiento", DbType.Int64, BE.iVencimiento);
                db.AddInParameter(cmd, "nvNominal", DbType.Decimal, BE.nvNominal);
                db.AddInParameter(cmd, "nvNegociable", DbType.Decimal, BE.nvNegociable);
                db.AddInParameter(cmd, "nPorAmortizacion", DbType.Decimal, BE.nPorAmortizacion);
                db.AddInParameter(cmd, "nvImporteAm", DbType.Decimal, BE.nvImporteAm);
                db.AddInParameter(cmd, "nvImporteN", DbType.Decimal, BE.nvImporteN);
                db.AddInParameter(cmd, "iPlazoVencimientoN", DbType.Int32, BE.iPlazoVencimientoN);
                if (BE.sdVencimientoN != DateTime.MinValue) { db.AddInParameter(cmd, "sdVencimientoN", DbType.DateTime, BE.sdVencimientoN); }
                db.AddInParameter(cmd, "nPorTEA", DbType.Decimal, BE.nPorTEA);
                db.AddInParameter(cmd, "nGastosAdm", DbType.Decimal, BE.nGastosAdm);
                db.AddInParameter(cmd, "nGastosReno", DbType.Decimal, BE.nGastosReno);
                db.AddInParameter(cmd, "nInteresVencidos", DbType.Decimal, BE.nInteresVencidos);
                db.AddInParameter(cmd, "nInteresReno", DbType.Decimal, BE.nInteresReno);
                db.AddInParameter(cmd, "nImporte", DbType.Decimal, BE.nImporte);
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
