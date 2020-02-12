
namespace EfideFactoringBE
{
   public class UbigeoBE : GeneralBE
   {
       private string _IdUbigeo = string.Empty;
       
       public string IdUbigeo
       {
           get { return _IdUbigeo; }
           set { _IdUbigeo = value; }
       }

       private string _ubiDepartamento = string.Empty;
       
       public string ubiDepartamento
       {
           get { return _ubiDepartamento; }
           set { _ubiDepartamento = value; }
       }

       private string _ubiProvincia = string.Empty;
       
       public string ubiProvincia
       {
           get { return _ubiProvincia; }
           set { _ubiProvincia = value; }
       }

       private string _ubiDistrito = string.Empty;
       
       public string ubiDistrito
       {
           get { return _ubiDistrito; }
           set { _ubiDistrito = value; }
       }

       private string _ubiNombre = string.Empty;
       
       public string ubiNombre
       {
           get { return _ubiNombre; }
           set { _ubiNombre = value; }
       }

       private string _ubiAux = string.Empty;
       
       public string ubiAux
       {
           get { return _ubiAux; }
           set { _ubiAux = value; }
       }

       private bool _ubiEstado;
       
       public bool ubiEstado
       {
           get { return _ubiEstado; }
           set { _ubiEstado = value; }
       }

   }
}
