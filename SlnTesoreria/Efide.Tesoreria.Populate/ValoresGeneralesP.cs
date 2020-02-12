using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class ValoresGeneralesP
    {
        public static ValoresGeneralesBE obtenerValoresGenerales(IDataReader dr)
        {
            ValoresGeneralesBE oValoresGeneralesBE = new ValoresGeneralesBE();

            if (!dr.IsDBNull(dr.GetOrdinal("valorID")))
                oValoresGeneralesBE.valorID = dr.GetDecimal(dr.GetOrdinal("valorID"));

            if (!dr.IsDBNull(dr.GetOrdinal("varCodigo")))
                oValoresGeneralesBE.varCodigo = dr.GetDecimal(dr.GetOrdinal("varCodigo"));

            if (!dr.IsDBNull(dr.GetOrdinal("varDescripcion")))
                oValoresGeneralesBE.varDescripcion = dr.GetString(dr.GetOrdinal("varDescripcion"));

            if (!dr.IsDBNull(dr.GetOrdinal("varAux1")))
                oValoresGeneralesBE.varAux1 = dr.GetString(dr.GetOrdinal("varAux1"));

            if (!dr.IsDBNull(dr.GetOrdinal("varAux2")))
                oValoresGeneralesBE.varAux2 = dr.GetDecimal(dr.GetOrdinal("varAux2"));

            if (!dr.IsDBNull(dr.GetOrdinal("varEstado")))
                oValoresGeneralesBE.varEstado = dr.GetBoolean(dr.GetOrdinal("varEstado"));

            return oValoresGeneralesBE;
        }

        public static ValueListsBE obtenerCuentasBancarias(IDataReader dr)
        {
            ValueListsBE oValueListsBE = new ValueListsBE();

            if (!dr.IsDBNull(dr.GetOrdinal("ctasBancariasID")))
                oValueListsBE.ID = dr.GetString(dr.GetOrdinal("ctasBancariasID"));

            if ((!dr.IsDBNull(dr.GetOrdinal("ctasBanNumCta"))) && (!dr.IsDBNull(dr.GetOrdinal("emprRazonSocial"))) && (!dr.IsDBNull(dr.GetOrdinal("nomMonedaID"))))
                oValueListsBE.Name = dr.GetString(dr.GetOrdinal("ctasBanNumCta")).Trim() + " - " + dr.GetString(dr.GetOrdinal("emprRazonSocial")) + " (" + dr.GetString(dr.GetOrdinal("nomMonedaID")) + ")";

            return oValueListsBE;
        }
    }
}
