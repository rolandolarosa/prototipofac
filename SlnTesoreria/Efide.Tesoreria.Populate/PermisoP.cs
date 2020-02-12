using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class PermisoP
    {
        public static PermisoBE getPermiso(IDataReader dr)
        {
            PermisoBE oPermisoBE = new PermisoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.usuarioID = dr.GetString(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.rolID = dr.GetString(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.plataformaID = dr.GetString(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.plataformaNom = dr.GetString(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.moduloID = dr.GetString(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.moduloNom = dr.GetString(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.plaNumOrden = dr.GetInt32(dr.GetOrdinal("plataformaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("plataformaID")))
                oPermisoBE.modNumOrden = dr.GetInt32(dr.GetOrdinal("plataformaID"));

            return oPermisoBE;
        }
    }
}
