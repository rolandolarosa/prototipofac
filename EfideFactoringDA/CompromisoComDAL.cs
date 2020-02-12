using System;
using System.Data;
using System.Data.Common;
using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace EfideFactoringDA
{
   public class CompromisoComDA
   {

       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarCompromisoCom(CompromisoComBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("CompromisoCom_Mnt");
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdCompromiso", DbType.String, BE.IdCompromiso);
               if (BE.sdFechaReg != DateTime.MinValue){ db.AddInParameter(cmd, "sdFechaReg", DbType.DateTime, BE.sdFechaReg);}
               db.AddInParameter(cmd, "IdPagadora", DbType.String, BE.IdPagadora);
               db.AddInParameter(cmd, "RucPagadora", DbType.String, BE.RucPagadora);
               db.AddInParameter(cmd, "vcPagadora", DbType.String, BE.vcPagadora);
               db.AddInParameter(cmd, "Origen", DbType.String, BE.Origen);
               db.AddInParameter(cmd, "idsector_tt", DbType.String, BE.idsector_tt);
               db.AddInParameter(cmd, "IdTipoLin_tt", DbType.String, BE.IdTipoLin_tt);
               db.AddInParameter(cmd, "nLineaDisp", DbType.Decimal, BE.nLineaDisp);
               db.AddInParameter(cmd, "IdTipoSer_tt", DbType.String, BE.IdTipoSer_tt);
               db.AddInParameter(cmd, "vcDescServicio", DbType.String, BE.vcDescServicio);
               db.AddInParameter(cmd, "IdSocio", DbType.String, BE.IdSocio);
               db.AddInParameter(cmd, "IdMoneda_tt", DbType.String, BE.IdMoneda_tt);
               db.AddInParameter(cmd, "nImporteFIn", DbType.Decimal, BE.nImporteFIn);
               if (BE.sdFechaFin != DateTime.MinValue){ db.AddInParameter(cmd, "sdFechaFin", DbType.DateTime, BE.sdFechaFin);}
               db.AddInParameter(cmd, "nImporteAte", DbType.Decimal, BE.nImporteAte);
               db.AddInParameter(cmd, "IdLote", DbType.String, BE.IdLote);
               db.AddInParameter(cmd, "cItem", DbType.String, BE.cItem);
               db.AddInParameter(cmd, "vcContacto", DbType.String, BE.vcContacto);
               db.AddInParameter(cmd, "idcargo_tt", DbType.String, BE.idcargo_tt);
               db.AddInParameter(cmd, "telefonoanx", DbType.String, BE.telefonoanx);
               db.AddInParameter(cmd, "celular", DbType.String, BE.celular);
               db.AddInParameter(cmd, "emailcorp", DbType.String, BE.emailcorp);
               db.AddInParameter(cmd, "IdGestor", DbType.String, BE.IdGestor); 
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

