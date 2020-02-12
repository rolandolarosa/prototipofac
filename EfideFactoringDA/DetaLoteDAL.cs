using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
    public class DetaLoteDA
    {

        Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
        DbCommand cmd = null;

        public DataSet ProcesarDetaLote(DetaLoteBE BE)
        {
            DataSet dsResult;
            try
            {
                cmd = db.GetStoredProcCommand("DetaLote_Mnt");
                db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
                db.AddInParameter(cmd, "cItem", DbType.String, BE.cItem);
                db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
                db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
                db.AddInParameter(cmd, "IdSocio_Beneficiario", DbType.String, BE.IdSocio_Beneficiario);
                db.AddInParameter(cmd, "IdSocio_BeneficiarioRuc", DbType.String, BE.IdSocio_BeneficiarioRuc);
                db.AddInParameter(cmd, "cNumDoc", DbType.String, BE.cNumDoc);
                if (BE.sdRecepcion != DateTime.MinValue) { db.AddInParameter(cmd, "sdRecepcion", DbType.DateTime, BE.sdRecepcion); }
                db.AddInParameter(cmd, "iPlazo", DbType.Int32, BE.iPlazo);
                if (BE.sdVencimiento != DateTime.MinValue) { db.AddInParameter(cmd, "sdVencimiento", DbType.DateTime, BE.sdVencimiento); }
                db.AddInParameter(cmd, "nvNominal", DbType.Decimal, BE.nvNominal);
                db.AddInParameter(cmd, "cNotaCredito", DbType.String, BE.cNotaCredito);
                db.AddInParameter(cmd, "nNotaCredito", DbType.Decimal, BE.nNotaCredito);
                db.AddInParameter(cmd, "nPorRetencion", DbType.Decimal, BE.nPorRetencion);
                db.AddInParameter(cmd, "nvRetencion", DbType.Decimal, BE.nvRetencion);
                db.AddInParameter(cmd, "Descuento", DbType.Decimal, BE.Descuento);
                db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
                db.AddInParameter(cmd, "nvNegociable", DbType.Decimal, BE.nvNegociable);
                db.AddInParameter(cmd, "nTazaActiva", DbType.Decimal, BE.nTazaActiva);
                db.AddInParameter(cmd, "nFondoGarantia", DbType.Decimal, BE.nFondoGarantia);
                db.AddInParameter(cmd, "nTasaSobregiro", DbType.Decimal, BE.nTasaSobregiro);
                db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
                if (BE.dtRenovacion != DateTime.MinValue) { db.AddInParameter(cmd, "dtRenovacion", DbType.DateTime, BE.dtRenovacion); }
                if (BE.FlgEnvioCorreo != string.Empty) { db.AddInParameter(cmd, "FlgEnvioCorreo", DbType.String, BE.FlgEnvioCorreo); }
                if (BE.dtEnvioCorreo != DateTime.MinValue) { db.AddInParameter(cmd, "dtEnvioCorreo", DbType.DateTime, BE.dtEnvioCorreo); }
                if (BE.FlgConfirmadoPagadora != string.Empty) { db.AddInParameter(cmd, "FlgConfirmadoPagadora", DbType.String, BE.FlgConfirmadoPagadora); }
                if (BE.dtConfirmadoPagadora != DateTime.MinValue) { db.AddInParameter(cmd, "dtConfirmadoPagadora", DbType.DateTime, BE.dtConfirmadoPagadora); }
                if (BE.IdImageDoc != string.Empty) { db.AddInParameter(cmd, "IdImageDoc", DbType.String, BE.IdImageDoc); }
                db.AddInParameter(cmd, "bNoRequiereProtesto", DbType.Boolean, BE.bNoRequiereProtesto);
                db.AddInParameter(cmd, "Tipo", DbType.String, BE.Tipo);
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

