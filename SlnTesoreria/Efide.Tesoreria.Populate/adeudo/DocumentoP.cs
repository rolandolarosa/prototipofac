using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.BusinessEntity.adeudo;

namespace Efide.Tesoreria.Populate.adeudo
{
    public class DocumentoP
    {
        public static DocumentoBE ObtenerDocumento(IDataReader dr)
        {
            DocumentoBE oDocumentoBE = new DocumentoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idDocumento")))
                oDocumentoBE.idDocumento = dr.GetString(dr.GetOrdinal("idDocumento"));

            if (!dr.IsDBNull(dr.GetOrdinal("idAdeudo")))
                oDocumentoBE.idAdeudo = dr.GetString(dr.GetOrdinal("idAdeudo"));

            if (!dr.IsDBNull(dr.GetOrdinal("ruta")))
                oDocumentoBE.ruta = dr.GetString(dr.GetOrdinal("ruta"));

            if (!dr.IsDBNull(dr.GetOrdinal("nombre")))
                oDocumentoBE.nombre = dr.GetString(dr.GetOrdinal("nombre"));

            if (!dr.IsDBNull(dr.GetOrdinal("observaciones")))
                oDocumentoBE.observaciones = dr.GetString(dr.GetOrdinal("observaciones"));

            return oDocumentoBE;
        }
    }
}
