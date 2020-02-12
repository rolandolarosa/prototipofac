using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.Populate.adeudo
{
    public class ContactoP
    {
        public static ContactoBE getContacto(IDataReader dr)
        {
            ContactoBE oContactoBE = new ContactoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idAdeudo")))
                oContactoBE.idAdeudo = dr.GetString(dr.GetOrdinal("idAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("anexo")))
                oContactoBE.anexo = dr.GetString(dr.GetOrdinal("anexo"));

            if (!dr.IsDBNull(dr.GetOrdinal("correo")))
                oContactoBE.correo = dr.GetString(dr.GetOrdinal("correo"));

            if (!dr.IsDBNull(dr.GetOrdinal("funcionario")))
                oContactoBE.funcionario = dr.GetString(dr.GetOrdinal("funcionario"));

            if (!dr.IsDBNull(dr.GetOrdinal("idContacto")))
                oContactoBE.idContacto = dr.GetString(dr.GetOrdinal("idContacto"));

            if (!dr.IsDBNull(dr.GetOrdinal("telefono")))
                oContactoBE.telefono = dr.GetString(dr.GetOrdinal("telefono"));

            if (!dr.IsDBNull(dr.GetOrdinal("cumpleanos")))
                oContactoBE.cumpleanos = dr.GetDateTime(dr.GetOrdinal("cumpleanos"));

            if (!dr.IsDBNull(dr.GetOrdinal("celular")))
                oContactoBE.celular = dr.GetString(dr.GetOrdinal("celular"));

            if (!dr.IsDBNull(dr.GetOrdinal("cuentaBancoID")))
                oContactoBE.cuentaBancoID = dr.GetInt32(dr.GetOrdinal("cuentaBancoID"));

            return oContactoBE;
        }
    }
}
