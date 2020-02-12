
namespace EfideFactoringBE
{
   public class SocioLineaBE : GeneralBE
   {
       private string _IdLinea = string.Empty;
       
       public string IdLinea
       {
           get { return _IdLinea; }
           set { _IdLinea = value; }
       }

       private string _IdSocio = string.Empty;
       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private string _RUCSocio = string.Empty;
       public string RUCSocio
       {
           get { return _RUCSocio; }
           set { _RUCSocio = value; }
       }

       private string _IdTipoLinea_tt = string.Empty;

       public string IdTipoLinea_tt
       {
           get { return _IdTipoLinea_tt; }
           set { _IdTipoLinea_tt = value; }
       }

       private System.DateTime _dtRegistro;
       
       public System.DateTime dtRegistro
       {
           get { return _dtRegistro; }
           set { _dtRegistro = value; }
       }

       private System.DateTime _dtVencimiento;
       
       public System.DateTime dtVencimiento
       {
           get { return _dtVencimiento; }
           set { _dtVencimiento = value; }
       }

       private string _IdMoneda_tt = string.Empty;
       
       public string IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private decimal _nImporte = 0;
       
       public decimal nImporte
       {
           get { return _nImporte; }
           set { _nImporte = value; }
       }

       private decimal _nUtilizado = 0;
       
       public decimal nUtilizado
       {
           get { return _nUtilizado; }
           set { _nUtilizado = value; }
       }

       private string _IdSocio_Dsc = string.Empty;

       public string IdSocio_Dsc
       {
           get { return _IdSocio_Dsc; }
           set { _IdSocio_Dsc = value; }
       }

       private string _vCodigoAnexo = string.Empty;

       public string vCodigoAnexo
       {
           get { return _vCodigoAnexo; }
           set { _vCodigoAnexo = value; }
       }

       private string _IdPagadora = string.Empty;
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }

       private string _IdPagadora_Dsc = string.Empty;
       public string IdPagadora_Dsc
       {
           get { return _IdPagadora_Dsc; }
           set { _IdPagadora_Dsc = value; }
       }

       private int _FlgVerPagadoras = 0;
       public int FlgVerPagadoras
       {
           get { return _FlgVerPagadoras; }
           set { _FlgVerPagadoras = value; }
       }

       private int _FlgOrigen = 0;
       public int FlgOrigen
       {
           get { return _FlgOrigen; }
           set { _FlgOrigen = value; }
       }
   }
}
