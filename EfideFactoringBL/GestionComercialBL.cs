using System;
using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;
using System.Collections.Generic;

namespace EfideFactoringBL
{
   public class GestionComercialBL
   {
       GestionComercialDA GestionComercialDA = new GestionComercialDA();

       public DataSet ProcesarGestionComercial(int Annio, int Mes, string IdGestor, string IdSocio, decimal TipCam, int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.ProcesarGestionComercial(Annio, Mes, IdGestor, IdSocio, TipCam, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet ProcesarGestionComercial(int Opcion, string IdGestor, DateTime FechaInicio)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.ProcesarGestionComercial(Opcion, IdGestor, FechaInicio);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet ProcesarGestionComercialRpt(DateTime FechaInicio, DateTime FechaFin, string IdGestor, string Mes, int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.ProcesarGestionComercialRpt(FechaInicio, FechaFin, IdGestor, Mes, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet ProcesarRptEstadistica(string IdPagadora, string IdSocio, int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.ProcesarRptEstadistica(IdPagadora, IdSocio, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet ProcesarRpt_CreditosVigentesxProducto(int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.ProcesarRpt_CreditosVigentesxProducto(Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet ProcesarRpt_PagadoraDesembolsoGC(string Annio, string Mes, string IdGestor,int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.ProcesarRpt_PagadoraDesembolsoGC(Annio, Mes, IdGestor, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_SocioClasificacionGC(int Annio, int Mes, string Usuario ,int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_SocioClasificacionGC(Annio, Mes, Usuario, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_ControlDiario(int Opcion, string IdGestor, string ColumnName)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_ControlDiario(Opcion, IdGestor, ColumnName);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_ControlDiarioMnt(int Opcion, string IdGestor, string ColumnName)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_ControlDiarioMnt(Opcion, IdGestor, ColumnName);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_OperacionNoRetornaron(int Opcion, string IdSocio, string IdGestor, int valorDecisionCredID)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_OperacionNoRetornaron(Opcion, IdSocio, IdGestor, valorDecisionCredID);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_TableroControlGestionNuevos(int Opcion, string IdGestor)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_TableroControlGestionNuevos(Opcion, IdGestor);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_TableroControlGestionNuevos_Det(string IdGestor, string Clasificacion, string ColumnName)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_TableroControlGestionNuevos_Det(IdGestor, Clasificacion, ColumnName);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_TableroControlGestionMnt(int Opcion, string IdGestor)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_TableroControlGestionMnt(Opcion, IdGestor);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_TableroControlGestionMnt_Det(string IdGestor, string Clasificacion, string ColumnName)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_TableroControlGestionMnt_Det(IdGestor, Clasificacion, ColumnName);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_Tuberia(string IdGestor, string IdTipoGestor_tt, int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_Tuberia(IdGestor, IdTipoGestor_tt, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_ResumenGestionNuevosMnt(string IdGestor, string ColumnName, int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_ResumenGestionNuevosMnt(IdGestor, ColumnName, Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }

       public DataSet Procesar_Rpt_ListaSociosPeligroFuga(int Opcion)
       {
           DataSet dsGestionComercial = new DataSet();
           try
           {
               dsGestionComercial = GestionComercialDA.Procesar_Rpt_ListaSociosPeligroFuga(Opcion);
           }
           catch (Exception ex)
           {
               throw new Exception(ex.Message);
           }
           return dsGestionComercial;
       }
   }
}