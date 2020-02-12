
namespace EfideFactoringBE
{
   public class SocioLineaLogBE : GeneralBE
   {
       private string _IdLineaLog = string.Empty;
       
       public string IdLineaLog
       {
           get { return _IdLineaLog; }
           set { _IdLineaLog = value; }
       }

       private string _IdLinea = string.Empty;
       
       public string IdLinea
       {
           get { return _IdLinea; }
           set { _IdLinea = value; }
       }

       private System.DateTime _dtRegistro;
       
       public System.DateTime dtRegistro
       {
           get { return _dtRegistro; }
           set { _dtRegistro = value; }
       }

       private string _IdMoneda_tt = string.Empty;
       
       public string IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private decimal _nImporteAnterior = 0;
       
       public decimal nImporteAnterior
       {
           get { return _nImporteAnterior; }
           set { _nImporteAnterior = value; }
       }

       private decimal _nImporteNuevo = 0;
       
       public decimal nImporteNuevo
       {
           get { return _nImporteNuevo; }
           set { _nImporteNuevo = value; }
       }

   }
}
