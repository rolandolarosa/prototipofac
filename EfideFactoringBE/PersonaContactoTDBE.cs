
namespace EfideFactoringBE
{
   public class PersonaContactoTDBE : GeneralBE
   {
       private string _IdSocio = string.Empty;

       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _contacCargo = string.Empty;

       public string contacCargo
       {
           get { return _contacCargo; }
           set { _contacCargo = value; }
       }

       private string _contacArea = string.Empty;

       public string contacArea
       {
           get { return _contacArea; }
           set { _contacArea = value; }
       }

       private string _contacNombre = string.Empty;

       public string contacNombre
       {
           get { return _contacNombre; }
           set { _contacNombre = value; }
       }

       private string _contacAnexo = string.Empty;

       public string contacAnexo
       {
           get { return _contacAnexo; }
           set { _contacAnexo = value; }
       }

       private string _contacEmail1 = string.Empty;

       public string contacEmail1
       {
           get { return _contacEmail1; }
           set { _contacEmail1 = value; }
       }

       private string _contacEmail2 = string.Empty;

       public string contacEmail2
       {
           get { return _contacEmail2; }
           set { _contacEmail2 = value; }
       }
   }
}
