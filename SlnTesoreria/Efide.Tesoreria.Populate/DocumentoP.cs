using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;

namespace Efide.Tesoreria.Populate
{
    public class DocumentoP
    {
        public static DocumentoBE ObtenerDocumento(IDataReader dr)
        {
            DocumentoBE oDocumentoBE = new DocumentoBE();

            if (!dr.IsDBNull(dr.GetOrdinal("idDocumento")))
                oDocumentoBE.idDocumento = dr.GetString(dr.GetOrdinal("idDocumento"));

            if (!dr.IsDBNull(dr.GetOrdinal("idInversion")))
                oDocumentoBE.idInversion = dr.GetString(dr.GetOrdinal("idInversion"));

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
