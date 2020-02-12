
namespace EfideFactoringBE
{
    public class RenovacionDetBE : GeneralBE
   {
       private string _IdRenovacion = string.Empty;

       public string IdRenovacion
       {
           get { return _IdRenovacion; }
           set { _IdRenovacion = value; }
       }

       private string _IdLote = string.Empty;

       public string IdLote
       {
           get { return _IdLote; }
           set { _IdLote = value; }
       }
       private string _cItem = string.Empty;

       public string cItem
       {
           get { return _cItem; }
           set { _cItem = value; }
       }
       private string _IdDocumento = string.Empty;

       public string IdDocumento
       {
           get { return _IdDocumento; }
           set { _IdDocumento = value; }
       }
       private string _cNumDoc = string.Empty;

       public string cNumDoc
       {
           get { return _cNumDoc; }
           set { _cNumDoc = value; }
       }

       private string _IdPagadora = string.Empty;

       public string IdPagadora
       {
           get { return _IdPagadora; }
           set { _IdPagadora = value; }
       }
       private string _IdSocio = string.Empty;

       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }
       private System.DateTime _sdVencimiento;

       public System.DateTime sdVencimiento
       {
           get { return _sdVencimiento; }
           set { _sdVencimiento = value; }
       }
       private int _iVencimiento = 0;

       public int iVencimiento
       {
           get { return _iVencimiento; }
           set { _iVencimiento = value; }
       }

       private decimal _nvNominal = 0;
       public decimal nvNominal
       {
           get { return _nvNominal; }
           set { _nvNominal = value; }
       }

       private decimal _nPorAmortizacion = 0;
       public decimal nPorAmortizacion
       {
           get { return _nPorAmortizacion; }
           set { _nPorAmortizacion = value; }
       }

        private decimal _nvImporteAm = 0;
        public decimal nvImporteAm
       {
           get { return _nvImporteAm; }
           set { _nvImporteAm = value; }
       }
       private decimal _nvImporteN = 0;

       public decimal nvImporteN
       {
           get { return _nvImporteN; }
           set { _nvImporteN = value; }
       }

       private int _iPlazoVencimientoN = 0;
       public int iPlazoVencimientoN
       {
           get { return _iPlazoVencimientoN; }
           set { _iPlazoVencimientoN = value; }
       }
        
       private System.DateTime _sdVencimientoN;

       public System.DateTime sdVencimientoN
       {
           get { return _sdVencimientoN; }
           set { _sdVencimientoN = value; }
       }
       private decimal _nPorTEA = 0;

       public decimal nPorTEA
       {
           get { return _nPorTEA; }
           set { _nPorTEA = value; }
       }
       private decimal _nGastosAdm = 0;

       public decimal nGastosAdm
       {
           get { return _nGastosAdm; }
           set { _nGastosAdm = value; }
       }
       private decimal _nGastosReno = 0;

       public decimal nGastosReno
       {
           get { return _nGastosReno; }
           set { _nGastosReno = value; }
       }
       private double _nInteresVencidos = 0;

       public double nInteresVencidos
       {
           get { return _nInteresVencidos; }
           set { _nInteresVencidos = value; }
       }
       private double _nInteresReno = 0;

       public double nInteresReno
       {
           get { return _nInteresReno; }
           set { _nInteresReno = value; }
       }
       private decimal _nImporte = 0;

       public decimal nImporte
       {
           get { return _nImporte; }
           set { _nImporte = value; }
       }
       private string _IdEstado_tt = string.Empty;

       public string IdEstado_tt
       {
           get { return _IdEstado_tt; }
           set { _IdEstado_tt = value; }
       }

       private string _IdEntidad_Dsc = string.Empty;

       public string IdEntidad_Dsc
       {
           get { return _IdEntidad_Dsc; }
           set { _IdEntidad_Dsc = value; }
       }
       
       private string _IdEntidad = string.Empty;

       public string IdEntidad
       {
           get { return _IdEntidad; }
           set { _IdEntidad = value; }
       }

      
         private decimal _nFondoGarantia = 0;

       public decimal nFondoGarantia
       {
           get { return _nFondoGarantia; }
           set { _nFondoGarantia = value; }
       }


       private decimal _nvNegociable = 0;
       public decimal nvNegociable
       {
           get { return _nvNegociable; }
           set { _nvNegociable = value; }
       }

       private decimal _TEAOrigen = 0;
       public decimal TEAOrigen
       {
           get { return _TEAOrigen; }
           set { _TEAOrigen = value; }
       }
   }
}
