
namespace EfideFactoringBE
{
   public class SocioLineaPagRetencionBE : GeneralBE
   {
       private string _IdLinea = string.Empty;
       
       public string IdLinea
       {
           get { return _IdLinea; }
           set { _IdLinea = value; }
       }

       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdDocumento = string.Empty;
       
       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }

       private string _IdItem = string.Empty;
       
       public string IdItem
       {
           get { return _IdItem; }
           set { _IdItem = value; }
       }

       private decimal _nRetencion = 0;
       
       public decimal nRetencion
       {
           get { return _nRetencion; }
           set { _nRetencion = value; }
       }

   }
}
