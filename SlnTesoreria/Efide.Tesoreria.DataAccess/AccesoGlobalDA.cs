using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess
{
    public class AccesoGlobalDA
    {
        private Database _dbFENIXSEG;
        private Database dbFENIXSEG
        {
            get { return (_dbFENIXSEG == null ? _dbFENIXSEG = DatabaseFactory.CreateDatabase(AppSettings.ConexionStrDBFENIXSEG) : _dbFENIXSEG); }
        }

        public List<AccesoGlobalBE> ListaAccesos(PermisoBE pPermisoBE)
        {
            List<AccesoGlobalBE> lstAccesoGlobalBE = new List<AccesoGlobalBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbFENIXSEG.GetStoredProcCommand(GetNameStoreProcedure.spSelectViewPermisosTM))
                {
                    cmd.CommandTimeout = 0;
                    dbFENIXSEG.AddInParameter(cmd, "@rolID", System.Data.DbType.String, pPermisoBE.rolID);
                    dbFENIXSEG.AddInParameter(cmd, "@usuarioID", System.Data.DbType.String, pPermisoBE.usuarioID);
                    dbFENIXSEG.AddInParameter(cmd, "@plataformaID", System.Data.DbType.String, pPermisoBE.plataformaID);
                    dbFENIXSEG.AddInParameter(cmd, "@moduloID", System.Data.DbType.String, pPermisoBE.moduloID);
                    dr = dbFENIXSEG.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstAccesoGlobalBE.Add(AccesoGlobalP.ObtenerAcceso(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstAccesoGlobalBE;
        }
    }
}
