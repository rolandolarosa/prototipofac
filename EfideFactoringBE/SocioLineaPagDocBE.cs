
namespace EfideFactoringBE
{
   public class SocioLineaPagDocBE : GeneralBE
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

       private string _IdDocumento = string.Empty;
       
       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }

       private decimal _nFondoGarantia = 0;
       
       public decimal nFondoGarantia
       {
           get { return _nFondoGarantia; }
           set { _nFondoGarantia = value; }
       }

       private bool _bInteres;
       
       public bool bInteres
       {
           get { return _bInteres; }
           set { _bInteres = value; }
       }

       private string _vDocumento = string.Empty;

       public string vDocumento
       {
           get { return _vDocumento; }
           set { _vDocumento = value; }
       }

       private string _IdTipoConfirmacion = string.Empty;
       public string IdTipoConfirmacion
       {
           get { return _IdTipoConfirmacion; }
           set { _IdTipoConfirmacion = value; }
       }
   }
}
