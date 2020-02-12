
namespace EfideFactoringBE
{
   public class SocioLineaPagadoraBE : GeneralBE
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

       private string _IdGestionCobranza_tt = string.Empty;
       
       public string IdGestionCobranza_tt
       {
           get { return _IdGestionCobranza_tt; }
           set { _IdGestionCobranza_tt = value; }
       }

       private string _vcPagadora = string.Empty;

       public string vcPagadora
       {
           get { return _vcPagadora; }
           set { _vcPagadora = value; }
       }

       private int _Confirmacionl;

       public int Confirmacionl
       {
           get { return _Confirmacionl; }
           set { _Confirmacionl = value; }
        }

   }
}
