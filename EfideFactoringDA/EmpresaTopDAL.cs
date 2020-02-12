using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class EmpresaTopDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarEmpresaTop(EmpresaTopBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("EmpresaTop_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "Year", DbType.String, BE.Year);
               db.AddInParameter(cmd, "RUC", DbType.String, BE.RUC);
               db.AddInParameter(cmd, "RazonSocial", DbType.String, BE.RazonSocial);
               db.AddInParameter(cmd, "NombreComercial", DbType.String, BE.NombreComercial);
               db.AddInParameter(cmd, "CIIU", DbType.String, BE.CIIU);
               db.AddInParameter(cmd, "CIIU5", DbType.String, BE.CIIU5);
               db.AddInParameter(cmd, "SectorEsp", DbType.String, BE.SectorEsp);
               db.AddInParameter(cmd, "SectorIng", DbType.String, BE.SectorIng);
               db.AddInParameter(cmd, "SubsectorEsp", DbType.String, BE.SubsectorEsp);
               db.AddInParameter(cmd, "CIIUEspDetalle", DbType.String, BE.CIIUEspDetalle);
               db.AddInParameter(cmd, "CIIUIngDetalle", DbType.String, BE.CIIUIngDetalle);
               db.AddInParameter(cmd, "ProductosServicios", DbType.String, BE.ProductosServicios);
               db.AddInParameter(cmd, "Grupo", DbType.String, BE.Grupo);
               db.AddInParameter(cmd, "Partgrupo", DbType.String, BE.Partgrupo);
               db.AddInParameter(cmd, "ListadaBolsa", DbType.String, BE.ListadaBolsa);
               db.AddInParameter(cmd, "ReguladaSbs", DbType.String, BE.ReguladaSbs);
               db.AddInParameter(cmd, "NTrabajadores", DbType.Decimal, BE.NTrabajadores);
               db.AddInParameter(cmd, "NSucursales", DbType.Decimal, BE.NSucursales);
               db.AddInParameter(cmd, "FechaFundacion", DbType.String, BE.FechaFundacion);
               db.AddInParameter(cmd, "AniosFuncionamiento", DbType.Decimal, BE.AniosFuncionamiento);
               db.AddInParameter(cmd, "TamanoEmpresa", DbType.String, BE.TamanoEmpresa);
               db.AddInParameter(cmd, "Extranjera", DbType.String, BE.Extranjera);
               db.AddInParameter(cmd, "PorcExtranjera", DbType.Decimal, BE.PorcExtranjera);
               db.AddInParameter(cmd, "Estatal", DbType.String, BE.Estatal);
               db.AddInParameter(cmd, "PorcEstatal", DbType.Decimal, BE.PorcEstatal);
               db.AddInParameter(cmd, "Situacion", DbType.String, BE.Situacion);
               db.AddInParameter(cmd, "Direccion", DbType.String, BE.Direccion);
               db.AddInParameter(cmd, "Distrito", DbType.String, BE.Distrito);
               db.AddInParameter(cmd, "Provincia", DbType.String, BE.Provincia);
               db.AddInParameter(cmd, "Departamento", DbType.String, BE.Departamento);
               db.AddInParameter(cmd, "Telefono1", DbType.String, BE.Telefono1);
               db.AddInParameter(cmd, "Telefono2", DbType.String, BE.Telefono2);
               db.AddInParameter(cmd, "Telefono3", DbType.String, BE.Telefono3);
               db.AddInParameter(cmd, "Celular1", DbType.String, BE.Celular1);
               db.AddInParameter(cmd, "Celular2", DbType.String, BE.Celular2);
               db.AddInParameter(cmd, "Fax1", DbType.String, BE.Fax1);
               db.AddInParameter(cmd, "Fax2", DbType.String, BE.Fax2);
               db.AddInParameter(cmd, "EmailCorp", DbType.String, BE.EmailCorp);
               db.AddInParameter(cmd, "PaginaWeb", DbType.String, BE.PaginaWeb);
               db.AddInParameter(cmd, "RankingY", DbType.Decimal, BE.RankingY);
               db.AddInParameter(cmd, "RankingY_1", DbType.Decimal, BE.RankingY_1);
               db.AddInParameter(cmd, "RankingY_2", DbType.Decimal, BE.RankingY_2);
               db.AddInParameter(cmd, "FacturadoMinSolY", DbType.Decimal, BE.FacturadoMinSolY);
               db.AddInParameter(cmd, "FacturadoMaxSolY", DbType.Decimal, BE.FacturadoMaxSolY);
               db.AddInParameter(cmd, "FacturadoMinUsdY", DbType.Decimal, BE.FacturadoMinUsdY);
               db.AddInParameter(cmd, "FacturadoMaxUsdY", DbType.Decimal, BE.FacturadoMaxUsdY);
               db.AddInParameter(cmd, "FacturadoMinSolY_1", DbType.Decimal, BE.FacturadoMinSolY_1);
               db.AddInParameter(cmd, "FacturadoMaxSolY_1", DbType.Decimal, BE.FacturadoMaxSolY_1);
               db.AddInParameter(cmd, "FacturadoMinUsdY_1", DbType.Decimal, BE.FacturadoMinUsdY_1);
               db.AddInParameter(cmd, "FacturadoMaxUsdY_1", DbType.Decimal, BE.FacturadoMaxUsdY_1);
               db.AddInParameter(cmd, "FacturadoMinSolY_2", DbType.Decimal, BE.FacturadoMinSolY_2);
               db.AddInParameter(cmd, "FacturadoMaxSolY_2", DbType.Decimal, BE.FacturadoMaxSolY_2);
               db.AddInParameter(cmd, "FacturadoMinUsdY_2", DbType.Decimal, BE.FacturadoMinUsdY_2);
               db.AddInParameter(cmd, "FacturadoMaxUsdY_2", DbType.Decimal, BE.FacturadoMaxUsdY_2);
               db.AddInParameter(cmd, "TipoPrivadaPublica", DbType.String, BE.TipoPrivadaPublica);
               db.AddInParameter(cmd, "IngresosY", DbType.Decimal, BE.IngresosY);
               db.AddInParameter(cmd, "UtilidadNetaY", DbType.Decimal, BE.UtilidadNetaY);
               db.AddInParameter(cmd, "ActivosY", DbType.Decimal, BE.ActivosY);
               db.AddInParameter(cmd, "PatrimonioY", DbType.Decimal, BE.PatrimonioY);
               db.AddInParameter(cmd, "PasivoTotalY", DbType.Decimal, BE.PasivoTotalY);
               db.AddInParameter(cmd, "IngresosY_1", DbType.Decimal, BE.IngresosY_1);
               db.AddInParameter(cmd, "UtilidadNetaY_1", DbType.Decimal, BE.UtilidadNetaY_1);
               db.AddInParameter(cmd, "ActivosY_1", DbType.Decimal, BE.ActivosY_1);
               db.AddInParameter(cmd, "PatrimonioY_1", DbType.Decimal, BE.PatrimonioY_1);
               db.AddInParameter(cmd, "PasivoTotalY_1", DbType.Decimal, BE.PasivoTotalY_1);
               db.AddInParameter(cmd, "IngresosY_2", DbType.Decimal, BE.IngresosY_2);
               db.AddInParameter(cmd, "UtilidadNetaY_2", DbType.Decimal, BE.UtilidadNetaY_2);
               db.AddInParameter(cmd, "ActivosY_2", DbType.Decimal, BE.ActivosY_2);
               db.AddInParameter(cmd, "PatrimonioY_2", DbType.Decimal, BE.PatrimonioY_2);
               db.AddInParameter(cmd, "PasivoTotalY_2", DbType.Decimal, BE.PasivoTotalY_2);
               db.AddInParameter(cmd, "TipoExportadora", DbType.String, BE.TipoExportadora);
               db.AddInParameter(cmd, "PorExpoVtasY", DbType.Decimal, BE.PorExpoVtasY);
               db.AddInParameter(cmd, "USDExpoY", DbType.Decimal, BE.USDExpoY);
               db.AddInParameter(cmd, "USDExpoY_1", DbType.Decimal, BE.USDExpoY_1);
               db.AddInParameter(cmd, "USDExpoY_2", DbType.Decimal, BE.USDExpoY_2);
               db.AddInParameter(cmd, "USDExpoY_3", DbType.Decimal, BE.USDExpoY_3);
               db.AddInParameter(cmd, "USDExpoY_4", DbType.Decimal, BE.USDExpoY_4);
               db.AddInParameter(cmd, "USDExpoY_5", DbType.Decimal, BE.USDExpoY_5);
               db.AddInParameter(cmd, "USDExpoY_6", DbType.Decimal, BE.USDExpoY_6);
               db.AddInParameter(cmd, "USDImpoY", DbType.Decimal, BE.USDImpoY);
               db.AddInParameter(cmd, "USDImpoY_1", DbType.Decimal, BE.USDImpoY_1);
               db.AddInParameter(cmd, "USDImpoY_2", DbType.Decimal, BE.USDImpoY_2);
               db.AddInParameter(cmd, "USDImpoY_3", DbType.Decimal, BE.USDImpoY_3);
               db.AddInParameter(cmd, "USDImpoY_4", DbType.Decimal, BE.USDImpoY_4);
               db.AddInParameter(cmd, "USDImpoY_5", DbType.Decimal, BE.USDImpoY_5);
               db.AddInParameter(cmd, "USDImpoY_6", DbType.Decimal, BE.USDImpoY_6);
               db.AddInParameter(cmd, "FlgComite", DbType.Decimal, BE.FlgComite);
               db.AddInParameter(cmd, "nLinea", DbType.Decimal, BE.nLinea);
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

