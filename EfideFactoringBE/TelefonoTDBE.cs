
namespace EfideFactoringBE
{
   public class TelefonoTDBE : GeneralBE
   {
       private string _IdSocio = string.Empty;

       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private int _valorCodigoID = 0;

       public int valorCodigoID
       {
           get { return _valorCodigoID; }
           set { _valorCodigoID = value; }
       }

       private int _valorTipoID = 0;

       public int valorTipoID
       {
           get { return _valorTipoID; }
           set { _valorTipoID = value; }
       }

       private int _valorOrigenTeleID = 0;

       public int valorOrigenTeleID
       {
           get { return _valorOrigenTeleID; }
           set { _valorOrigenTeleID = value; }
       }

       private string _teleTelefono = string.Empty;
       public string teleTelefono
       {
           get { return _teleTelefono; }
           set { _teleTelefono = value; }
       }
   }
}
