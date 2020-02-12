using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess
{
    public class TableBaseDA : ITableBaseD
    {
        private Database _dbFactoring;
        private Database dbFactoring
        {
            get { return (_dbFactoring == null ? _dbFactoring = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBFactoring) : _dbFactoring); }
        }

        public List<TableBaseBE> ProcesarTableBase(TableBaseBE BE)
        {
            List<TableBaseBE> lstTableBaseBE = new List<TableBaseBE>();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbFactoring.GetStoredProcCommand(GetNameStoreProcedure.TableBase_Mnt))
                {
                    //cmd.CommandTimeout = 0;
                    dbFactoring.AddInParameter(cmd, "OPCION", DbType.Int32, BE.OPCION);
                    dbFactoring.AddInParameter(cmd, "USUARIO", DbType.String, BE.USUARIO);
                    dbFactoring.AddInParameter(cmd, "Table_Id", DbType.String, BE.Table_Id);
                    dbFactoring.AddInParameter(cmd, "Table_Parent_Id", DbType.String, BE.Table_Parent_Id);
                    dbFactoring.AddInParameter(cmd, "Table_Name", DbType.String, BE.Table_Name);
                    dbFactoring.AddInParameter(cmd, "Table_Order", DbType.String, BE.Table_Order);
                    dbFactoring.AddInParameter(cmd, "Table_Value", DbType.String, BE.Table_Value);
                    dr = dbFactoring.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        lstTableBaseBE.Add(TableBaseP.ObtenerTableBase(dr));
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return lstTableBaseBE;
        }
    }
}
