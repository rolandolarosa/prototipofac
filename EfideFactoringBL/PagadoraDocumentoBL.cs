using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
   public class PagadoraDocumentoBL
   {
       PagadoraDocumentoDA PagadoraDocumentoDA = new PagadoraDocumentoDA();

       public DataSet ProcesarPagadoraDocumento(PagadoraDocumentoBE BE)
       {
           return PagadoraDocumentoDA.ProcesarPagadoraDocumento(BE);
       }
   }
}

