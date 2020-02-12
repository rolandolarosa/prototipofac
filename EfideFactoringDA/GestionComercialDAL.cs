using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class GestionComercialDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarGestionComercial(int Annio, int Mes, string IdGestor, string IdSocio, decimal TipCam, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.GestionComercial");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "Annio", DbType.Int32, Annio);
               db.AddInParameter(cmd, "Mes", DbType.Int32, Mes);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "IdSocio", DbType.String, IdSocio);
               db.AddInParameter(cmd, "TipCam", DbType.Decimal, TipCam);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet ProcesarGestionComercial(int Opcion, string IdGestor, DateTime FechaInicio)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.GestionComercial");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               if (FechaInicio != DateTime.MinValue) { db.AddInParameter(cmd, "FechaInicio", DbType.DateTime, FechaInicio); }
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet ProcesarGestionComercialRpt(DateTime FechaInicio, DateTime FechaFin, string IdGestor, string Mes, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_GestionComercial");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               if (FechaInicio != DateTime.MinValue) { db.AddInParameter(cmd, "FechaIni", DbType.DateTime, FechaInicio); }
               if (FechaFin != DateTime.MinValue) { db.AddInParameter(cmd, "FechaFin", DbType.DateTime, FechaFin); }
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "Mes", DbType.String, Mes);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet ProcesarRptEstadistica(string IdPagadora, string IdSocio, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_Estadistica");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdPagadora", DbType.String, IdPagadora);
               db.AddInParameter(cmd, "IdSocio", DbType.String, IdSocio);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet ProcesarRpt_CreditosVigentesxProducto(int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_CreditosVigentesxProducto");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet ProcesarRpt_PagadoraDesembolsoGC(string Annio, string Mes, string IdGestor, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_PagadoraDesembolsoGC");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "Annio", DbType.String, Annio);
               db.AddInParameter(cmd, "Mes", DbType.String, Mes);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_SocioClasificacionGC(int Annio, int Mes, string Usuario, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Procesar_SocioClasificacionGC");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "Usuario", DbType.String, Usuario);
               db.AddInParameter(cmd, "Annio", DbType.Int32, Annio);
               db.AddInParameter(cmd, "Mes", DbType.Int32, Mes);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_ControlDiario(int Opcion, string IdGestor, string ColumnName)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_ControlDiarioNuevos");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "ColumnName", DbType.String, ColumnName); 
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_ControlDiarioMnt(int Opcion, string IdGestor, string ColumnName)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_ControlDiarioMnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "ColumnName", DbType.String, ColumnName);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_OperacionNoRetornaron(int Opcion, string IdSocio, string IdGestor, int valorDecisionCredID)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_OperacionNoRetornaron");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdSocio", DbType.String, IdSocio);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "valorDecisionCredID", DbType.Int32, valorDecisionCredID); 
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_TableroControlGestionNuevos(int Opcion, string IdGestor)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_TableroControlGestionNuevos");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_TableroControlGestionNuevos_Det(string IdGestor, string Clasificacion, string ColumnName)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_TableroControlGestionNuevos_Det");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "Clasificacion", DbType.String, Clasificacion);
               db.AddInParameter(cmd, "ColumnName", DbType.String, ColumnName);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_TableroControlGestionMnt(int Opcion, string IdGestor)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_TableroControlGestionMnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_TableroControlGestionMnt_Det(string IdGestor, string Clasificacion, string ColumnName)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_TableroControlGestionMnt_Det");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "Clasificacion", DbType.String, Clasificacion);
               db.AddInParameter(cmd, "ColumnName", DbType.String, ColumnName);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_Tuberia(string IdGestor, string IdTipoGestor_tt, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_Tuberia");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "IdTipoGestor_tt", DbType.String, IdTipoGestor_tt);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_ResumenGestionNuevosMnt(string IdGestor, string ColumnName, int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_ResumenGestionNuevosMnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
               db.AddInParameter(cmd, "IdGestor", DbType.String, IdGestor);
               db.AddInParameter(cmd, "ColumnName", DbType.String, ColumnName);
               dsResult = db.ExecuteDataSet(cmd);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsResult;
       }

       public DataSet Procesar_Rpt_ListaSociosPeligroFuga(int Opcion)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("dbo.Rpt_ListaSociosPeligroFuga");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, Opcion);
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

