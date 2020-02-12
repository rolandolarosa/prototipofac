
namespace EfideFactoringBE
{
   public class CuentasxCobrarTMBE : GeneralBE
   {
       private string _ctaCobrarID = string.Empty;
       
       public string ctaCobrarID
       {
           get { return _ctaCobrarID; }
           set { _ctaCobrarID = value; }
       }

       private string _clienteID = string.Empty;
       
       public string clienteID
       {
           get { return _clienteID; }
           set { _clienteID = value; }
       }

       private string _tipCxcID = string.Empty;
       
       public string tipCxcID
       {
           get { return _tipCxcID; }
           set { _tipCxcID = value; }
       }

       private string _referenciaID = string.Empty;
       
       public string referenciaID
       {
           get { return _referenciaID; }
           set { _referenciaID = value; }
       }

       private decimal _cxcImpComis = 0;
       
       public decimal cxcImpComis
       {
           get { return _cxcImpComis; }
           set { _cxcImpComis = value; }
       }

       private decimal _cxcImpComp = 0;
       
       public decimal cxcImpComp
       {
           get { return _cxcImpComp; }
           set { _cxcImpComp = value; }
       }

       private int _cxcNumCuotas = 0;
       
       public int cxcNumCuotas
       {
           get { return _cxcNumCuotas; }
           set { _cxcNumCuotas = value; }
       }

       private int _cxcPeriodicidad = 0;
       
       public int cxcPeriodicidad
       {
           get { return _cxcPeriodicidad; }
           set { _cxcPeriodicidad = value; }
       }

       private System.DateTime _cxcFecEmision;
       
       public System.DateTime cxcFecEmision
       {
           get { return _cxcFecEmision; }
           set { _cxcFecEmision = value; }
       }

       private System.DateTime _cxcFecInicio;
       
       public System.DateTime cxcFecInicio
       {
           get { return _cxcFecInicio; }
           set { _cxcFecInicio = value; }
       }

       private System.DateTime _cxcFechaCrea;
       
       public System.DateTime cxcFechaCrea
       {
           get { return _cxcFechaCrea; }
           set { _cxcFechaCrea = value; }
       }

       private System.DateTime _cxcFechaMod;
       
       public System.DateTime cxcFechaMod
       {
           get { return _cxcFechaMod; }
           set { _cxcFechaMod = value; }
       }

       private string _cxcUsuarioCrea = string.Empty;
       
       public string cxcUsuarioCrea
       {
           get { return _cxcUsuarioCrea; }
           set { _cxcUsuarioCrea = value; }
       }

       private string _cxcUsuarioMod = string.Empty;
       
       public string cxcUsuarioMod
       {
           get { return _cxcUsuarioMod; }
           set { _cxcUsuarioMod = value; }
       }

       private bool _cxcEstado;
       
       public bool cxcEstado
       {
           get { return _cxcEstado; }
           set { _cxcEstado = value; }
       }

       private decimal _cxcImpSaldoComp = 0;
       
       public decimal cxcImpSaldoComp
       {
           get { return _cxcImpSaldoComp; }
           set { _cxcImpSaldoComp = value; }
       }

       private decimal _cxcImpSaldoComis = 0;
       
       public decimal cxcImpSaldoComis
       {
           get { return _cxcImpSaldoComis; }
           set { _cxcImpSaldoComis = value; }
       }

       private decimal _valorEstadoCxCID = 0;
       
       public decimal valorEstadoCxCID
       {
           get { return _valorEstadoCxCID; }
           set { _valorEstadoCxCID = value; }
       }

       private System.DateTime _cxcFechaCan;
       
       public System.DateTime cxcFechaCan
       {
           get { return _cxcFechaCan; }
           set { _cxcFechaCan = value; }
       }

       private decimal _valorFormaPagoID = 0;
       
       public decimal valorFormaPagoID
       {
           get { return _valorFormaPagoID; }
           set { _valorFormaPagoID = value; }
       }

       private decimal _cxcImporteDesc = 0;
       
       public decimal cxcImporteDesc
       {
           get { return _cxcImporteDesc; }
           set { _cxcImporteDesc = value; }
       }

       private string _gesCuentaID = string.Empty;
       
       public string gesCuentaID
       {
           get { return _gesCuentaID; }
           set { _gesCuentaID = value; }
       }

       private string _gesCobranzaID = string.Empty;
       
       public string gesCobranzaID
       {
           get { return _gesCobranzaID; }
           set { _gesCobranzaID = value; }
       }

       private decimal _valorTipoDesemID = 0;
       
       public decimal valorTipoDesemID
       {
           get { return _valorTipoDesemID; }
           set { _valorTipoDesemID = value; }
       }

       private string _numOperacion = string.Empty;
       
       public string numOperacion
       {
           get { return _numOperacion; }
           set { _numOperacion = value; }
       }

       private int _cxcDiaPagoFijo = 0;
       
       public int cxcDiaPagoFijo
       {
           get { return _cxcDiaPagoFijo; }
           set { _cxcDiaPagoFijo = value; }
       }

       private string _cxcGlosa = string.Empty;
       
       public string cxcGlosa
       {
           get { return _cxcGlosa; }
           set { _cxcGlosa = value; }
       }

       private string _IdMoneda_tt = string.Empty;

       public string IdMoneda_tt
       {
           get { return _IdMoneda_tt; }
           set { _IdMoneda_tt = value; }
       }

       private string _IdLote = string.Empty;

       public string IdLote
       {
           get { return _IdLote; }
           set { _IdLote = value; }
       }

       private decimal _valorMonedaID = 0;

       public decimal valorMonedaID
       {
           get { return _valorMonedaID; }
           set { _valorMonedaID = value; }
       }

       private string _Tipo = string.Empty;

       public string Tipo
       {
           get { return _Tipo; }
           set { _Tipo = value; }
       }

       private decimal _Monto = 0;

       public decimal Monto
       {
           get { return _Monto; }
           set { _Monto = value; }
       }

       private string _gPlazaID = string.Empty;

       public string gPlazaID
       {
           get { return _gPlazaID; }
           set { _gPlazaID = value; }
       }

       private System.DateTime _gFechaOp = System.DateTime.MinValue;

       public System.DateTime gFechaOp
       {
           get { return _gFechaOp; }
           set { _gFechaOp = value; }
       }
   }
}
