using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Populate.adeudo;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess.adeudo
{
    public class DocumentoDA : IDocumentoD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public string insertDocumento(DocumentoBE pDocumentoBE)
        {
            string idDocumento = string.Empty;
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertDocumento))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, pDocumentoBE.idAdeudo);
                dbAdeudosInversiones.AddInParameter(cmd, "ruta", DbType.String, pDocumentoBE.ruta);
                dbAdeudosInversiones.AddInParameter(cmd, "extension", DbType.String, pDocumentoBE.nombre.Substring(pDocumentoBE.nombre.LastIndexOf("."), pDocumentoBE.nombre.Length - pDocumentoBE.nombre.LastIndexOf(".")));
                dbAdeudosInversiones.AddInParameter(cmd, "observaciones", DbType.String, pDocumentoBE.observaciones);
                dbAdeudosInversiones.AddOutParameter(cmd, "idDocumento", DbType.String, 10);

                dbAdeudosInversiones.ExecuteNonQuery(cmd);

                if (dbAdeudosInversiones.GetParameterValue(cmd, "idDocumento") != DBNull.Value)
                    idDocumento = dbAdeudosInversiones.GetParameterValue(cmd, "idDocumento").ToString();

                return idDocumento;
            }
        }

        public List<DocumentoBE> listDocumento(string idAdeudo)
        {
            List<DocumentoBE> lstDocumentoBE = new List<DocumentoBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspListDocumento))
                {
                    //cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, idAdeudo);
                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstDocumentoBE.Add(DocumentoP.ObtenerDocumento(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstDocumentoBE;
        }

        public void deleteDocumento(string idDocumento, string idAdeudo)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspDeleteDocumento))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idDocumento", DbType.String, idDocumento);
                dbAdeudosInversiones.AddInParameter(cmd, "idAdeudo", DbType.String, idAdeudo);
                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }
    }
}
