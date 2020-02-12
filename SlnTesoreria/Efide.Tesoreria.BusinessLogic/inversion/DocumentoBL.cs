using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;

namespace Efide.Tesoreria.BusinessLogic.inversion
{
    public class DocumentoBL : IDocumentoD
    {
        private DocumentoDA _DocumentoDA;
        private DocumentoDA oDocumentoDA
        {
            get { return (_DocumentoDA == null ? _DocumentoDA = new DocumentoDA() : _DocumentoDA); }
        }

        public string insertDocumento(DocumentoBE pDocumentoBE)
        {
            return oDocumentoDA.insertDocumento(pDocumentoBE);
        }

        public void deleteDocumento(string idDocumento, string idInversion)
        {
            oDocumentoDA.deleteDocumento(idDocumento, idInversion);
        }

        public List<DocumentoBE> listDocumento(string idInversion)
        {
            return oDocumentoDA.listDocumento(idInversion);
        }
    }
}
