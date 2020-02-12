
namespace EfideFactoringBE
{
   public class EntidadTmpLote : GeneralBE
   {
       private string _IdEntidadSel = string.Empty;

       public string IdEntidadSel
       {
           get { return _IdEntidadSel; }
           set { _IdEntidadSel = value; }
       }

       private string _CodDocumento = string.Empty;

       public string CodDocumento
       {
           get { return _CodDocumento; }
           set { _CodDocumento = value; }
       }

       private string _NumDocumento = string.Empty;

       public string NumDocumento
       {
           get { return _NumDocumento; }
           set { _NumDocumento = value; }
       }

       private string _IdLote = string.Empty;

       public string IdLote
       {
           get { return _IdLote; }
           set { _IdLote = value; }
       }

       private string _cItem = string.Empty;

       public string cItem
       {
           get { return _cItem; }
           set { _cItem = value; }
       }
   }
}
