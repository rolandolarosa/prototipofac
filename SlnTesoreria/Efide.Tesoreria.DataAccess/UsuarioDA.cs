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
    public class UsuarioDA
    {
        private Database _dbFactoring;
        private Database dbFactoring
        {
            get { return (_dbFactoring == null ? _dbFactoring = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBFactoring) : _dbFactoring); }
        }

        public List<UsuarioBE> ProcesarUsuario(UsuarioBE pUsuarioBE)
        {
            List<UsuarioBE> lstUsuarioBE = new List<UsuarioBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbFactoring.GetStoredProcCommand(GetNameStoreProcedure.Usuario_Mnt))
                {
                    //cmd.CommandTimeout = 0;
                    dbFactoring.AddInParameter(cmd, "OPCION", DbType.Int32, pUsuarioBE.OPCION);
                    dbFactoring.AddInParameter(cmd, "usuarioID", DbType.String, pUsuarioBE.usuarioID);
                    dbFactoring.AddInParameter(cmd, "usuContrasena", DbType.String, pUsuarioBE.usuContrasena);
                    dbFactoring.AddInParameter(cmd, "gFecha", DbType.String, DBNull.Value);
                    dr = dbFactoring.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstUsuarioBE.Add(UsuarioP.obtenerUsuario(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstUsuarioBE;
        }
    }
}
