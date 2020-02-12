using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class PagadoraDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarPagadora(PagadoraBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("Pagadora_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "vcPagadora", DbType.String, BE.vcPagadora);
               db.AddInParameter(cmd, "vcNComercial", DbType.String, BE.vcNComercial);
               db.AddInParameter(cmd, "vcNombreCPagadora", DbType.String, BE.vcNombreCPagadora);
               db.AddInParameter(cmd, "bNacional", DbType.Boolean, BE.bNacional);
               db.AddInParameter(cmd, "vcRuc", DbType.String, BE.vcRuc);
               db.AddInParameter(cmd, "vcPartida", DbType.String, BE.vcPartida);
               db.AddInParameter(cmd, "IdSector_tt", DbType.String, BE.IdSector_tt);
               db.AddInParameter(cmd, "IdRiesgo_tt", DbType.String, BE.IdRiesgo_tt);
               db.AddInParameter(cmd, "vcDireccion", DbType.String, BE.vcDireccion);
               db.AddInParameter(cmd, "IdUbigeo", DbType.String, BE.IdUbigeo);
               db.AddInParameter(cmd, "vcReferencia", DbType.String, BE.vcReferencia);
               db.AddInParameter(cmd, "FlgIndividualReporte", DbType.String, BE.FlgIndividualReporte);
               db.AddInParameter(cmd, "FlgConvenio", DbType.String, BE.FlgConvenio);
               if (BE.dtFechaInicio != DateTime.MinValue){db.AddInParameter(cmd, "dtFechaInicio", DbType.DateTime, BE.dtFechaInicio);}
               if (BE.dtFechaFin != DateTime.MinValue) { db.AddInParameter(cmd, "dtFechaFin", DbType.DateTime, BE.dtFechaFin); }
               db.AddInParameter(cmd, "FlgInactivo", DbType.Int32, BE.FlgInactivo);
               db.AddInParameter(cmd, "FlgBloqueado", DbType.Int32, BE.FlgBloqueado);
               db.AddInParameter(cmd, "IdEstadoLinea_tt", DbType.String, BE.IdEstadoLinea_tt);
               db.AddInParameter(cmd, "IdGestor", DbType.String, BE.IdGestor);
               db.AddInParameter(cmd, "UsuarioID", DbType.String, BE.UsuarioID);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet PagadoraXcredito(string IdCreditosTM)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("[dbo].uspPagadoraXcreditoID");
               db.AddInParameter(cmd, "@p_IdCreditosTM", DbType.String, IdCreditosTM);
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

