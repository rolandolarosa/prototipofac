
namespace EfideFactoringBE
{
   public class LoteBE : GeneralBE
   {
       private string _IdLote = string.Empty;
       
       public string IdLote
       {
           get { return _IdLote; }
           set { _IdLote = value; }
       }

       private string _IdSocio = string.Empty;
       
       public string IdSocio
       {
           get { return _IdSocio; }
           set { _IdSocio = value; }
       }

       private System.DateTime _sdDesembolso;
       
       public System.DateTime sdDesembolso
       {
           get { return _sdDesembolso; }
           set { _sdDesembolso = value; }
       }

       private string _IdLinea = string.Empty;
       
       public string IdLinea
       {
           get { return _IdLinea; }
           set { _IdLinea = value; }
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

       private System.DateTime _sdAprobacion;
       
       public System.DateTime sdAprobacion
       {
           get { return _sdAprobacion; }
           set { _sdAprobacion = value; }
       }

       private decimal _nDesembolso = 0;
       
       public decimal nDesembolso
       {
           get { return _nDesembolso; }
           set { _nDesembolso = value; }
       }

       private string _IdSocio_Dsc = string.Empty;

       public string IdSocio_Dsc
       {
           get { return _IdSocio_Dsc; }
           set { _IdSocio_Dsc = value; }
       }

       private string _IdEstado_tt = string.Empty;

       public string IdEstado_tt
       {
           get { return _IdEstado_tt; }
           set { _IdEstado_tt = value; }
       }

       private string _IdOperacion_tt = string.Empty;

       public string IdOperacion_tt
       {
           get { return _IdOperacion_tt; }
           set { _IdOperacion_tt = value; }
       }

       private decimal _IdFormaDesembolso = 0;

       public decimal IdFormaDesembolso
       {
           get { return _IdFormaDesembolso; }
           set { _IdFormaDesembolso = value; }
       }

       private decimal _nTotal = 0;

       public decimal nTotal
       {
           get { return _nTotal; }
           set { _nTotal = value; }
       }

       private decimal _nAjuste = 0;

       public decimal nAjuste
       {
           get { return _nAjuste; }
           set { _nAjuste = value; }
       }

       private System.DateTime _gFechaOp;

       public System.DateTime gFechaOp
       {
           get { return _gFechaOp; }
           set { _gFechaOp = value; }
       }

       private System.Data.DataTable _dtLote;

       public System.Data.DataTable dtLote
       {
           get { return _dtLote; }
           set { _dtLote = value; }
       }

       /**************************************/

       private decimal _jImporteAho = 0;

       public decimal jImporteAho
       {
           get { return _jImporteAho; }
           set { _jImporteAho = value; }
       }

       private decimal _jTipoCambio = 0;

       public decimal jTipoCambio
       {
           get { return _jTipoCambio; }
           set { _jTipoCambio = value; }
       }

       private string _jComunCuentaID = string.Empty;

       public string jComunCuentaID
       {
           get { return _jComunCuentaID; }
           set { _jComunCuentaID = value; }
       }

       private System.DateTime _dtFechaConfirmado = System.DateTime.MinValue;
       public System.DateTime dtFechaConfirmado
       {
           get { return _dtFechaConfirmado; }
           set { _dtFechaConfirmado = value; }
       }

       private string _UsuarioConfirmado = string.Empty;
       public string UsuarioConfirmado
       {
           get { return _UsuarioConfirmado; }
           set { _UsuarioConfirmado = value; }
       }

       private System.DateTime _dtEntregado = System.DateTime.MinValue;
       public System.DateTime dtEntregado
       {
           get { return _dtEntregado; }
           set { _dtEntregado = value; }
       }

       private string _UsaurioEntregado = string.Empty;
       public string UsaurioEntregado
       {
           get { return _UsaurioEntregado; }
           set { _UsaurioEntregado = value; }
       }

       private string _FlgConfimado = string.Empty;
       public string FlgConfimado
       {
           get { return _FlgConfimado; }
           set { _FlgConfimado = value; }
       }

       private string _FlgEntregado = string.Empty;
       public string FlgEntregado
       {
           get { return _FlgEntregado; }
           set { _FlgEntregado = value; }
       }

       private string _FlgPendiente = string.Empty;
       public string FlgPendiente
       {
           get { return _FlgPendiente; }
           set { _FlgPendiente = value; }
       }

       private string _IdPagadora_Dsc = string.Empty;
       public string IdPagadora_Dsc
       {
           get { return _IdPagadora_Dsc; }
           set { _IdPagadora_Dsc = value; }
       }

       private string _cItem = string.Empty;
       public string cItem
       {
           get { return _cItem; }
           set { _cItem = value; }
       }

       private string _IdFinanciera = string.Empty;
       public string IdFinanciera
       {
           get { return _IdFinanciera; }
           set { _IdFinanciera = value; }
       }

       private int _iCuota = 0;
       public int iCuota
       {
           get { return _iCuota; }
           set { _iCuota = value; }
       }

       private decimal _nTotalCuota = 0;
       public decimal nTotalCuota
       {
           get { return _nTotalCuota; }
           set { _nTotalCuota = value; }
       }
   }
}
