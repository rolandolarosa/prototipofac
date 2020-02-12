
namespace EfideFactoringBE
{
   public class GrupoPagadoraBE : GeneralBE
   {
       private string _IdGrupoPagadora = string.Empty;
       
       public string IdGrupoPagadora
       {
           get { return _IdGrupoPagadora; }
           set { _IdGrupoPagadora = value; }
       }

       private string _vcGrupo = string.Empty;
       
       public string vcGrupo
       {
           get { return _vcGrupo; }
           set { _vcGrupo = value; }
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

       private string _IdMoneda_tt = string.Empty;
       
       public string IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private decimal _nLinea = 0;
       
       public decimal nLinea
       {
           get { return _nLinea; }
           set { _nLinea = value; }
       }

       private decimal _nUtilizado = 0;
       
       public decimal nUtilizado
       {
           get { return _nUtilizado; }
           set { _nUtilizado = value; }
       }

       private System.DateTime _dtFechaVencimiento;
       
       public System.DateTime dtFechaVencimiento
       {
           get { return _dtFechaVencimiento; }
           set { _dtFechaVencimiento = value; }
       }

       private string _IdPagadora = string.Empty;

       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

   }
}
