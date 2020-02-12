
namespace EfideFactoringBE
{
   public class BitacoraComercialBE : GeneralBE
   {
       private string _IdBitacoraComercial = string.Empty;
       
       public string IdBitacoraComercial
       {
           get { return _IdBitacoraComercial; }
           set { _IdBitacoraComercial = value; }
       }

       private string _IdSocio = string.Empty;
       
       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _IdTipoBitacora_tt = string.Empty;
       
       public string IdTipoBitacora_tt
       {
           get { return _IdTipoBitacora_tt; }
           set { _IdTipoBitacora_tt = value; }
       }

       private string _Descripcion = string.Empty;
       
       public string Descripcion
       {
           get { return _Descripcion; }
           set { _Descripcion = value; }
       }

       private System.DateTime _FechaAlerta;
       
       public System.DateTime FechaAlerta
       {
           get { return _FechaAlerta; }
           set { _FechaAlerta = value; }
       }

       private string _IdEstado_tt = string.Empty;
       
       public string IdEstado_tt
       {
           get { return _IdEstado_tt; }
           set { _IdEstado_tt = value; }
       }

       private System.DateTime _FechaAtendido;
       
       public System.DateTime FechaAtendido
       {
           get { return _FechaAtendido; }
           set { _FechaAtendido = value; }
       }

       private string _IdGestor;
       public string IdGestor
       {
           get { return _IdGestor; }
           set { _IdGestor = value; }
       }

       private string _IdBitacoraComercialGenerada;
       public string IdBitacoraComercialGenerada
       {
           get { return _IdBitacoraComercialGenerada; }
           set { _IdBitacoraComercialGenerada = value; }
       }

       private int _FlgOrigen;
       public int FlgOrigen
       {
           get { return _FlgOrigen; }
           set { _FlgOrigen = value; }
       }
   }
}
