using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class DocumentoBL
    {
        DocumentoDA DocumentoDA = new DocumentoDA();

        public DataSet ProcesarDocumento(DocumentoBE BE)
        {
            return DocumentoDA.ProcesarDocumento(BE);
        }
    }
}
