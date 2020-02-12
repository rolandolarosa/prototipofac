using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class AccesoGlobalP
    {
        public static AccesoGlobalBE ObtenerAcceso(IDataReader dr)
        {
            AccesoGlobalBE oAccesoGlobalBE = new AccesoGlobalBE();

            if (!dr.IsDBNull(dr.GetOrdinal("menNomPublico")))
                oAccesoGlobalBE.menNomPublico = dr.GetString(dr.GetOrdinal("menNomPublico"));

            if (!dr.IsDBNull(dr.GetOrdinal("menNomInterno")))
                oAccesoGlobalBE.menNomInterno = dr.GetString(dr.GetOrdinal("menNomInterno"));

            if (!dr.IsDBNull(dr.GetOrdinal("menPadre")))
                oAccesoGlobalBE.menPadre = dr.GetInt32(dr.GetOrdinal("menPadre"));

            if (!dr.IsDBNull(dr.GetOrdinal("menPosicion")))
                oAccesoGlobalBE.menPosicion = dr.GetInt32(dr.GetOrdinal("menPosicion"));

            if (!dr.IsDBNull(dr.GetOrdinal("perEstado")))
                oAccesoGlobalBE.perEstado = dr.GetBoolean(dr.GetOrdinal("perEstado"));

            return oAccesoGlobalBE;
        }
    }
}
