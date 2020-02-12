using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;

namespace Efide.Tesoreria.IntercafeData.inversion
{
    public interface IDocumentoD
    {
        string insertDocumento(DocumentoBE pDocumentoBE);
        List<DocumentoBE> listDocumento(string idInversion);
        void deleteDocumento(string idDocumento, string idInversion);
    }
}
