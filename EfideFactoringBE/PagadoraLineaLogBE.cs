
namespace EfideFactoringBE
{
   public class PagadoraLineaLogBE : GeneralBE
   {
       private string _IdLineaLog = string.Empty;

       public string IdLineaLog
       {
           get { return _IdLineaLog; }
           set { _IdLineaLog = value; }
       }

       private string _IdPagadora = string.Empty;

       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
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

       private string _IdNivelAutonomia_tt = string.Empty;

       public string IdNivelAutonomia_tt
       {
           get { return _IdNivelAutonomia_tt; }
           set { _IdNivelAutonomia_tt = value; }
       }

       private string _IdMedio_tt = string.Empty;

       public string IdMedio_tt
       {
           get { return _IdMedio_tt; }
           set { _IdMedio_tt = value; }
       }

       private string _IdAnalistaCredito_tt = string.Empty;

       public string IdAnalistaCredito_tt
       {
           get { return _IdAnalistaCredito_tt; }
           set { _IdAnalistaCredito_tt = value; }
       }

       private int _iPlazo = 0;

       public int iPlazo
       {
           get { return _iPlazo; }
           set { _iPlazo = value; }
       }

       private System.DateTime _dtFechaAprobacion;

       public System.DateTime dtFechaAprobacion
       {
           get { return _dtFechaAprobacion; }
           set { _dtFechaAprobacion = value; }
       }

       private System.DateTime _dtFechaVencimiento;

       public System.DateTime dtFechaVencimiento
       {
           get { return _dtFechaVencimiento; }
           set { _dtFechaVencimiento = value; }
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
