
namespace EfideFactoringBE
{
   public class GestionPagadoraBE : GeneralBE
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

       private string _IdGestor = string.Empty;
       public string IdGestor
       {
           get { return _IdGestor; }
           set { _IdGestor = value; }
       }

       private string _vcPagadora = string.Empty;
       public string vcPagadora
       {
           get { return _vcPagadora; }
           set { _vcPagadora = value; }
       }

       private decimal _TipCam = 0;
       public decimal TipCam
       {
           get { return _TipCam; }
           set { _TipCam = value; }
       }

       private string _IdEstadoLinea_tt = string.Empty;
       public string IdEstadoLinea_tt
       {
           get { return _IdEstadoLinea_tt; }
           set { _IdEstadoLinea_tt = value; }
       }

       private int _FlgOrigen = 0;
       public int FlgOrigen
       {
           get { return _FlgOrigen; }
           set { _FlgOrigen = value; }
       }
   }
}
