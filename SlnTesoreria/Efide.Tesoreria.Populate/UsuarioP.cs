using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class UsuarioP
    {
        public static UsuarioBE obtenerUsuario(IDataReader dr)
        {
            UsuarioBE oUsuarioBE = new UsuarioBE();

            if (!dr.IsDBNull(dr.GetOrdinal("usuarioID")))
                oUsuarioBE.usuarioID = dr.GetString(dr.GetOrdinal("usuarioID"));

            if (!dr.IsDBNull(dr.GetOrdinal("IdGestor")))
                oUsuarioBE.IdGestor = dr.GetString(dr.GetOrdinal("IdGestor"));

            if (!dr.IsDBNull(dr.GetOrdinal("sesionID")))
                oUsuarioBE.gSesionID = dr.GetString(dr.GetOrdinal("sesionID"));

            if (!dr.IsDBNull(dr.GetOrdinal("ventanillaID")))
                oUsuarioBE.ventanillaID = dr.GetString(dr.GetOrdinal("ventanillaID"));

            if (!dr.IsDBNull(dr.GetOrdinal("rolGlobal")))
                oUsuarioBE.rolGlobal = dr.GetString(dr.GetOrdinal("rolGlobal"));

            if (!dr.IsDBNull(dr.GetOrdinal("rolGlobalName")))
                oUsuarioBE.rolGlobalName = dr.GetString(dr.GetOrdinal("rolGlobalName"));

            return oUsuarioBE;
        }
    }
}
