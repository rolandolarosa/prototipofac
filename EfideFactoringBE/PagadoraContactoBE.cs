
namespace EfideFactoringBE
{
   public class PagadoraContactoBE : GeneralBE
   {
       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdItemCtc = string.Empty;
       
       public string IdItemCtc
       {
           get { return _IdItemCtc; }
           set { _IdItemCtc = value; }
       }

       private string _IdCargo_tt = string.Empty;

       public string IdCargo_tt
       {
           get { return _IdCargo_tt; }
           set { _IdCargo_tt = value; }
       }

       private string _vcContacto = string.Empty;
       
       public string vcContacto
       {
           get { return _vcContacto; }
           set { _vcContacto = value; }
       }

       private string _vcTelefono1 = string.Empty;
       
       public string vcTelefono1
       {
           get { return _vcTelefono1; }
           set { _vcTelefono1 = value; }
       }

       private string _vcTelefono2 = string.Empty;
       
       public string vcTelefono2
       {
           get { return _vcTelefono2; }
           set { _vcTelefono2 = value; }
       }

       private string _vcAnexo = string.Empty;
       
       public string vcAnexo
       {
           get { return _vcAnexo; }
           set { _vcAnexo = value; }
       }

       private string _vcCelular = string.Empty;
       
       public string vcCelular
       {
           get { return _vcCelular; }
           set { _vcCelular = value; }
       }

       private string _vcEmail = string.Empty;
       
       public string vcEmail
       {
           get { return _vcEmail; }
           set { _vcEmail = value; }
       }

       private System.DateTime _dtCumpleano;
       
       public System.DateTime dtCumpleano
       {
           get { return _dtCumpleano; }
           set { _dtCumpleano = value; }
       }

       private bool _bEntregaLetra;
       
       public bool bEntregaLetra
       {
           get { return _bEntregaLetra; }
           set { _bEntregaLetra = value; }
       }

       private bool _bEnvioDocumentacion;

       public bool bEnvioDocumentacion
       {
           get { return _bEnvioDocumentacion; }
           set { _bEnvioDocumentacion = value; }
       }

       private bool _bEnvioCobranza;

       public bool bEnvioCobranza
       {
           get { return _bEnvioCobranza; }
           set { _bEnvioCobranza = value; }
       }

       private bool _bFinanzas;
       public bool bFinanzas
       {
           get { return _bFinanzas; }
           set { _bFinanzas = value; }
       }

       private bool _bRealizarLLamada;
       public bool bRealizarLLamada
       {
           get { return _bRealizarLLamada; }
           set { _bRealizarLLamada = value; }
       }
   }
}
