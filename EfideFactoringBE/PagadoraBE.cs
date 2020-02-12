
namespace EfideFactoringBE
{
   public class PagadoraBE : GeneralBE
   {
       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _vcPagadora = string.Empty;
       
       public string vcPagadora
       {
           get { return _vcPagadora; }
           set { _vcPagadora = value; }
       }

       private string _vcNComercial = string.Empty;
       
       public string vcNComercial
       {
           get { return _vcNComercial; }
           set { _vcNComercial = value; }
       }

       private bool _bNacional;
       
       public bool bNacional
       {
           get { return _bNacional; }
           set { _bNacional = value; }
       }

       private string _vcRuc = string.Empty;
       
       public string vcRuc
       {
           get { return _vcRuc; }
           set { _vcRuc = value; }
       }

       private string _vcPartida = string.Empty;
       
       public string vcPartida
       {
           get { return _vcPartida; }
           set { _vcPartida = value; }
       }

       private System.DateTime _dtFechaInicio;
       
       public System.DateTime dtFechaInicio
       {
           get { return _dtFechaInicio; }
           set { _dtFechaInicio = value; }
       }

       private System.DateTime _dtFechaFin;
       public System.DateTime dtFechaFin
       {
           get { return _dtFechaFin; }
           set { _dtFechaFin = value; }
       }

       private string _IdSector_tt = string.Empty;
       
       public string IdSector_tt
       {
           get { return _IdSector_tt; }
           set { _IdSector_tt = value; }
       }

       private string _IdRiesgo_tt = string.Empty;

       public string IdRiesgo_tt
       {
           get { return _IdRiesgo_tt; }
           set { _IdRiesgo_tt = value; }
       }

       private string _vcDireccion = string.Empty;
       
       public string vcDireccion
       {
           get { return _vcDireccion; }
           set { _vcDireccion = value; }
       }

       private string _IdUbigeo = string.Empty;
       
       public string IdUbigeo
       {
           get { return _IdUbigeo; }
           set { _IdUbigeo = value; }
       }

       private string _vcReferencia = string.Empty;
       
       public string vcReferencia
       {
           get { return _vcReferencia; }
           set { _vcReferencia = value; }
       }

       private string _vcNombreCPagadora = string.Empty;

       public string vcNombreCPagadora
       {
           get { return _vcNombreCPagadora; }
           set { _vcNombreCPagadora = value; }
       }

       private string _FlgIndividualReporte = string.Empty;

       public string FlgIndividualReporte
       {
           get { return _FlgIndividualReporte; }
           set { _FlgIndividualReporte = value; }
       }

       private string _FlgConvenio = string.Empty;

       public string FlgConvenio
       {
           get { return _FlgConvenio; }
           set { _FlgConvenio = value; }
       }

       private string _IdEstadoLinea_tt = string.Empty;
       public string IdEstadoLinea_tt
       {
           get { return _IdEstadoLinea_tt; }
           set { _IdEstadoLinea_tt = value; }
       }

       private string _IdGestor = string.Empty;
       public string IdGestor
       {
           get { return _IdGestor; }
           set { _IdGestor = value; }
       }

       private int _FlgInactivo = 0;
       public int FlgInactivo
       {
           get { return _FlgInactivo; }
           set { _FlgInactivo = value; }
       }

       private int _FlgBloqueado = 0;
       public int FlgBloqueado
       {
           get { return _FlgBloqueado; }
           set { _FlgBloqueado = value; }
       }

       private string _UsuarioID = string.Empty;
       public string UsuarioID
       {
           get { return _UsuarioID; }
           set { _UsuarioID = value; }
       }
   }
}
