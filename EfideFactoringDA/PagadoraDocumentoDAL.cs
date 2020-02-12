using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class PagadoraDocumentoDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPagadoraDocumento(PagadoraDocumentoBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("PagadoraDocumento_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "IdItemDoc", DbType.String, BE.IdItemDoc);
               db.AddInParameter(cmd, "IdDocumento", DbType.String, BE.IdDocumento);
               db.AddInParameter(cmd, "IdTipoConfirmacion_tt", DbType.String, BE.IdTipoConfirmacion_tt);
               db.AddInParameter(cmd, "IdTipoTransferencia_tt", DbType.String, BE.IdTipoTransferencia_tt);
               db.AddInParameter(cmd, "IdTipoCartaP_tt", DbType.String, BE.IdTipoCartaP_tt);
               db.AddInParameter(cmd, "IdTipoCartaE_tt", DbType.String, BE.IdTipoCartaE_tt);
               db.AddInParameter(cmd, "vFrecuencia", DbType.String, BE.vFrecuencia);
               db.AddInParameter(cmd, "IdFrecuencia_tt", DbType.String, BE.IdFrecuencia_tt);
               db.AddInParameter(cmd, "IdDiasPagoFrecuencia_tt", DbType.String, BE.IdDiasPagoFrecuencia_tt);
               db.AddInParameter(cmd, "vDia", DbType.String, BE.vDia);
               db.AddInParameter(cmd, "iPlazo", DbType.Int32, BE.iPlazo);
               db.AddInParameter(cmd, "iDiaPago", DbType.Int32, BE.iDiaPago);
               db.AddInParameter(cmd, "IdFormaPago_tt", DbType.String, BE.IdFormaPago_tt);
               db.AddInParameter(cmd, "vcLugardePago", DbType.String, BE.vcLugardePago);
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

