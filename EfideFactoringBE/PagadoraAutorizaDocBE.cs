

namespace EfideFactoringBE
{
    public class PagadoraAutorizaDocBE : GeneralBE
   {
       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdSocio = string.Empty;

       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _IdDocumento = string.Empty;

       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }
   }
}
