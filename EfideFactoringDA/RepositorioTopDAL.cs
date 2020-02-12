using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class RepositorioTopDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarRepositorioTop(RepositorioTopBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("RepositorioTop_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Year", DbType.String, BE.Year);
               db.AddInParameter(cmd, "cRuc", DbType.String, BE.cRuc);
               db.AddInParameter(cmd, "vSectorEsp", DbType.String, BE.vSectorEsp);
               db.AddInParameter(cmd, "vMagnitudEmpresa", DbType.String, BE.vMagnitudEmpresa);
               db.AddInParameter(cmd, "vRanking", DbType.String, BE.vRanking);
               db.AddInParameter(cmd, "nFacturadoMax", DbType.Decimal, BE.nFacturadoMax);
               db.AddInParameter(cmd, "vTipoEmpresa", DbType.String, BE.vTipoEmpresa);
               db.AddInParameter(cmd, "vPagWeb", DbType.String, BE.vPagWeb);
               db.AddInParameter(cmd, "vNroTrabajador", DbType.String, BE.vNroTrabajador);
               db.AddInParameter(cmd, "vNroSucursales", DbType.String, BE.vNroSucursales);
               db.AddInParameter(cmd, "vResolucionContribuyente", DbType.String, BE.vResolucionContribuyente);
               db.AddInParameter(cmd, "nUtilidadNeta", DbType.Decimal, BE.nUtilidadNeta);
               db.AddInParameter(cmd, "nTotalActivo", DbType.Decimal, BE.nTotalActivo);
               db.AddInParameter(cmd, "nPatrimonio", DbType.Decimal, BE.nPatrimonio);
               db.AddInParameter(cmd, "nTotalPasivo", DbType.Decimal, BE.nTotalPasivo);
               db.AddInParameter(cmd, "nTotalVenta", DbType.Decimal, BE.nTotalVenta);
               db.AddInParameter(cmd, "vFacebook", DbType.String, BE.vFacebook);
               db.AddInParameter(cmd, "vTwitter", DbType.String, BE.vTwitter);
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

