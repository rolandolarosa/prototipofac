
namespace EfideFactoringBE
{
   public class EmailTDBE : GeneralBE
   {
       private string _IdSocio = string.Empty;

       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _mailCorreo = string.Empty;

       public string mailCorreo
       {
           get { return _mailCorreo; }
           set { _mailCorreo = value; }
       }
   }
}
