using EfideFactoringBE;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace EfideFactoringDA
{
   public class SolicitudRepresentanteDA
   {
       Database db = DatabaseFactory.CreateDatabase("ConexionStrDBEfideFactoring");
       DbCommand cmd = null;

       public DataSet ProcesarSolicitudRepresentante(SolicitudRepresentanteBE BE)
       {
           DataSet dsResult;
           try
           {
               cmd = db.GetStoredProcCommand("SolicitudRepresentante_Mnt");
               cmd.CommandTimeout = 0;
               db.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
               db.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
               db.AddInParameter(cmd, "IdSolicitud", DbType.String, BE.IdSolicitud);
               db.AddInParameter(cmd, "IdTipo_tt", DbType.String, BE.IdTipo_tt);
               db.AddInParameter(cmd, "IdRepresentante", DbType.String, BE.IdRepresentante);
               db.AddInParameter(cmd, "vNombreRepresentante", DbType.String, BE.vNombreRepresentante);
               db.AddInParameter(cmd, "IdCargo_tt", DbType.String, BE.IdCargo_tt);
               db.AddInParameter(cmd, "IdTipoDocumento_tt", DbType.String, BE.IdTipoDocumento_tt);
               db.AddInParameter(cmd, "IdEstadoCivil_tt", DbType.String, BE.IdEstadoCivil_tt);
               db.AddInParameter(cmd, "vObjetoSocial", DbType.String, BE.vObjetoSocial);
               db.AddInParameter(cmd, "vNroDocumento", DbType.String, BE.vNroDocumento);
               db.AddInParameter(cmd, "vDomicilio", DbType.String, BE.vDomicilio);
               db.AddInParameter(cmd, "IdTipoDocumentoApoderado_tt", DbType.String, BE.IdTipoDocumentoApoderado_tt);
               db.AddInParameter(cmd, "vNroDocApoderado", DbType.String, BE.vNroDocApoderado);
               db.AddInParameter(cmd, "vNombreApoderado", DbType.String, BE.vNombreApoderado);
               db.AddInParameter(cmd, "vDomicilioApoderado", DbType.String, BE.vDomicilioApoderado);
               db.AddInParameter(cmd, "IdCargoApoderado_tt", DbType.String, BE.IdCargoApoderado_tt);
               db.AddInParameter(cmd, "IdTipoDocumentoApoderado1_tt", DbType.String, BE.IdTipoDocumentoApoderado1_tt);
               db.AddInParameter(cmd, "vNroDocApoderado1", DbType.String, BE.vNroDocApoderado1);
               db.AddInParameter(cmd, "vNombreApoderado1", DbType.String, BE.vNombreApoderado1);
               db.AddInParameter(cmd, "vDomicilioApoderado1", DbType.String, BE.vDomicilioApoderado1);
               db.AddInParameter(cmd, "IdCargoApoderado1_tt", DbType.String, BE.IdCargoApoderado1_tt);
               db.AddInParameter(cmd, "IdTipoDocumentoConyuge_tt", DbType.String, BE.IdTipoDocumentoConyuge_tt);
               db.AddInParameter(cmd, "vNroDocConguge", DbType.String, BE.vNroDocConguge);
               db.AddInParameter(cmd, "vNombreConyuge", DbType.String, BE.vNombreConyuge);
               db.AddInParameter(cmd, "vDomicilioConyuge", DbType.String, BE.vDomicilioConyuge);
               if (BE.dtVigencia != DateTime.MinValue) { db.AddInParameter(cmd, "dtVigencia", DbType.DateTime, BE.dtVigencia); }
               db.AddInParameter(cmd, "vFirmaAdjunta", DbType.String, BE.vFirmaAdjunta);
               db.AddInParameter(cmd, "vFirmaAdjunta1", DbType.String, BE.vFirmaAdjunta1);
               db.AddInParameter(cmd, "vFirmaAdjunta2", DbType.String, BE.vFirmaAdjunta2);
               db.AddInParameter(cmd, "vObservacion", DbType.String, BE.vObservacion);    
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

