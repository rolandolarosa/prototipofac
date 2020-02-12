using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;
using Efide.Tesoreria.Populate;
using Efide.Tesoreria.Populate.inversion;
using Efide.Tesoreria.Util;
using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Efide.Tesoreria.DataAccess.inversion
{
    public class ContactoDA : IContactoD
    {
        private Database _dbAdeudosInversiones;
        private Database dbAdeudosInversiones
        {
            get { return (_dbAdeudosInversiones == null ? _dbAdeudosInversiones = DatabaseFactory.CreateDatabase(AppSettings.CnxConnectionDBAdeudosInversiones) : _dbAdeudosInversiones); }
        }

        public void insertContato(ContactoBE pContactoBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspInsertContacto))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pContactoBE.idInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "funcionario", DbType.String, pContactoBE.funcionario);
                dbAdeudosInversiones.AddInParameter(cmd, "telefono", DbType.String, pContactoBE.telefono);
                dbAdeudosInversiones.AddInParameter(cmd, "anexo", DbType.String, pContactoBE.anexo);
                dbAdeudosInversiones.AddInParameter(cmd, "correo", DbType.String, pContactoBE.correo);
                dbAdeudosInversiones.AddInParameter(cmd, "celular", DbType.String, pContactoBE.celular);
                if(pContactoBE.cumpleanos == DateTime.MinValue)
                    dbAdeudosInversiones.AddInParameter(cmd, "cumpleanos", DbType.DateTime, DBNull.Value);
                else
                    dbAdeudosInversiones.AddInParameter(cmd, "cumpleanos", DbType.DateTime, pContactoBE.cumpleanos);

                dbAdeudosInversiones.AddInParameter(cmd, "cuentaBancoID", DbType.Int32, pContactoBE.cuentaBancoID);
                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }

        public ContactoBE getContacto(string idInversion)
        {
            ContactoBE oContactoBE = new ContactoBE();
            IDataReader dr = null;
            try
            {
                using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspGetContacto))
                {
                    cmd.CommandTimeout = 0;
                    dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, idInversion);
                    dr = dbAdeudosInversiones.ExecuteReader(cmd);

                    while (dr.Read())
                    {
                        oContactoBE = ContactoP.getContacto(dr);
                    }
                }
            }
            catch (Exception)
            {
                if (dr != null && !dr.IsClosed)
                    dr.Close();
                throw;
            }

            return oContactoBE;
        }

        public void updateContato(ContactoBE pContactoBE)
        {
            using (DbCommand cmd = dbAdeudosInversiones.GetStoredProcCommand(GetNameStoreProcedure.uspUpdateContacto))
            {
                //cmd.CommandTimeout = 0;
                dbAdeudosInversiones.AddInParameter(cmd, "idInversion", DbType.String, pContactoBE.idInversion);
                dbAdeudosInversiones.AddInParameter(cmd, "funcionario", DbType.String, pContactoBE.funcionario);
                dbAdeudosInversiones.AddInParameter(cmd, "telefono", DbType.String, pContactoBE.telefono);
                dbAdeudosInversiones.AddInParameter(cmd, "anexo", DbType.String, pContactoBE.anexo);
                dbAdeudosInversiones.AddInParameter(cmd, "correo", DbType.String, pContactoBE.correo);
                dbAdeudosInversiones.AddInParameter(cmd, "celular", DbType.String, pContactoBE.celular);
                if (pContactoBE.cumpleanos == DateTime.MinValue)
                    dbAdeudosInversiones.AddInParameter(cmd, "cumpleanos", DbType.DateTime, DBNull.Value);
                else
                    dbAdeudosInversiones.AddInParameter(cmd, "cumpleanos", DbType.DateTime, pContactoBE.cumpleanos);
                dbAdeudosInversiones.AddInParameter(cmd, "cuentaBancoID", DbType.Int32, pContactoBE.cuentaBancoID);
                dbAdeudosInversiones.ExecuteNonQuery(cmd);
            }
        }
    }
}
