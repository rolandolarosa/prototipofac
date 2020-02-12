using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class DocumentoBL : IDocumentoD
    {
        private DocumentoDA _DocumentoDA;
        private DocumentoDA oDocumentoDA
        {
            get { return (_DocumentoDA == null ? _DocumentoDA = new DocumentoDA() : _DocumentoDA); }
        }

        public string insertDocumento(BusinessEntity.DocumentoBE pDocumentoBE)
        {
            return oDocumentoDA.insertDocumento(pDocumentoBE);
        }

        public void deleteDocumento(string idDocumento, string idInversion)
        {
            oDocumentoDA.deleteDocumento(idDocumento, idInversion);
        }

        public List<BusinessEntity.DocumentoBE> listDocumento(string idInversion)
        {
            return oDocumentoDA.listDocumento(idInversion);
        }
    }
}
