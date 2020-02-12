
namespace EfideFactoringBE
{
   public class GrupoPagadoraDetalleBE : GeneralBE
   {
       private string _IdGrupoPagadora = string.Empty;
       
       public string IdGrupoPagadora
       {
           get { return _IdGrupoPagadora; }
           set { _IdGrupoPagadora = value; }
       }

       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

   }
}
