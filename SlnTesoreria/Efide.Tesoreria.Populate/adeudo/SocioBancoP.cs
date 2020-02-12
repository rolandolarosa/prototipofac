using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.Populate.adeudo
{
    public class SocioBancoP
    {
        public static SocioBancoBE getSocioBanco(IDataReader dr)
        {
            SocioBancoBE oSocioBancoBE = new SocioBancoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("socioBancoID")))
                oSocioBancoBE.socioBancoID = dr.GetString(dr.GetOrdinal("socioBancoID"));

            if (!dr.IsDBNull(dr.GetOrdinal("tipoOperacion")))
                oSocioBancoBE.tipoOperacion = dr.GetString(dr.GetOrdinal("tipoOperacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("sbFechaOperacion")))
                oSocioBancoBE.sbFechaOperacion = dr.GetDateTime(dr.GetOrdinal("sbFechaOperacion"));

            if (!dr.IsDBNull(dr.GetOrdinal("TipoMpago")))
                oSocioBancoBE.TipoMpago = dr.GetString(dr.GetOrdinal("TipoMpago"));

            if (!dr.IsDBNull(dr.GetOrdinal("ent_emprRazonSocial")))
                oSocioBancoBE.ent_emprRazonSocial = dr.GetString(dr.GetOrdinal("ent_emprRazonSocial"));

            if (!dr.IsDBNull(dr.GetOrdinal("ctasBanNumCta")))
                oSocioBancoBE.ctasBanNumCta = dr.GetString(dr.GetOrdinal("ctasBanNumCta"));

            if (!dr.IsDBNull(dr.GetOrdinal("Saldo")))
                oSocioBancoBE.Saldo = dr.GetDecimal(dr.GetOrdinal("Saldo"));

            if (!dr.IsDBNull(dr.GetOrdinal("sbGlosa")))
                oSocioBancoBE.sbGlosa = dr.GetString(dr.GetOrdinal("sbGlosa")); 

            if (!dr.IsDBNull(dr.GetOrdinal("tipoMoneda")))
                oSocioBancoBE.tipoMoneda = dr.GetString(dr.GetOrdinal("tipoMoneda"));

            if (!dr.IsDBNull(dr.GetOrdinal("sbImporte")))
                oSocioBancoBE.sbImporte = dr.GetDecimal(dr.GetOrdinal("sbImporte"));

            //if (!dr.IsDBNull(dr.GetOrdinal("sbNumOperacion")))
            //    oSocioBancoBE.sbNumOperacion = dr.GetString(dr.GetOrdinal("sbNumOperacion"));
            
            //if (!dr.IsDBNull(dr.GetOrdinal("pagar_nombreCompleto")))
            //    oSocioBancoBE.pagar_nombreCompleto = dr.GetString(dr.GetOrdinal("pagar_nombreCompleto"));

            if (!dr.IsDBNull(dr.GetOrdinal("soc_razonSocial")))
                oSocioBancoBE.soc_razonSocial = dr.GetString(dr.GetOrdinal("soc_razonSocial"));

            if (!dr.IsDBNull(dr.GetOrdinal("valorMonedaID_Dsc")))
                oSocioBancoBE.valorMonedaID_Dsc = dr.GetString(dr.GetOrdinal("valorMonedaID_Dsc"));

            //if (!dr.IsDBNull(dr.GetOrdinal("TipoDestino")))
            //    oSocioBancoBE.TipoDestino = dr.GetString(dr.GetOrdinal("TipoDestino")); 
            
            return oSocioBancoBE;
        }
    }
}
