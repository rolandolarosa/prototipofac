
namespace EfideFactoringBE
{
   public class PagadoraLineaBE : GeneralBE
   {
       private string _IdPagadora = string.Empty;
       
       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
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

       private string _IdNivelAutonomia_tt = string.Empty;

       public string IdNivelAutonomia_tt
       {
           get { return _IdNivelAutonomia_tt; }
           set { _IdNivelAutonomia_tt = value; }
       }

       private System.DateTime _dtFechaAprobacion;
       
       public System.DateTime dtFechaAprobacion
       {
           get { return _dtFechaAprobacion; }
           set { _dtFechaAprobacion = value; }
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

       private System.DateTime _dtFechaVencimiento;
       
       public System.DateTime dtFechaVencimiento
       {
           get { return _dtFechaVencimiento; }
           set { _dtFechaVencimiento = value; }
       }

       private string _vcObservaciones = string.Empty;
       
       public string vcObservaciones
       {
           get { return _vcObservaciones; }
           set { _vcObservaciones = value; }
       }

       private decimal _nTipoCambio = 0;
       public decimal nTipoCambio
       {
           get { return _nTipoCambio; }
           set { _nTipoCambio = value; }
       }

       private System.DateTime _dtTipoCambio = System.DateTime.MinValue;
       public System.DateTime dtTipoCambio
       {
           get { return _dtTipoCambio; }
           set { _dtTipoCambio = value; }
       }

       private string _IdEstadoLinea_tt = string.Empty;
       
       public string IdEstadoLinea_tt
       {
           get { return _IdEstadoLinea_tt; }
           set { _IdEstadoLinea_tt = value; }
       }

   }
}
