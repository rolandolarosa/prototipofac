
namespace EfideFactoringBE
{
    public class CobranzaDetalleBE : GeneralBE
    {
        private string _IdCobranza = string.Empty;
        public string IdCobranza
        {
            get { return _IdCobranza; }
            set { _IdCobranza = value; }
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
        
        private decimal _nvNominal = 0;
        public decimal nvNominal
        {
            get { return _nvNominal; }
            set { _nvNominal = value; }
        }

        private decimal _nvMontoCobrar = 0;
        public decimal nvMontoCobrar
        {
            get { return _nvMontoCobrar; }
            set { _nvMontoCobrar = value; }
        }

        private decimal _nSaldo = 0;
        public decimal nSaldo
        {
            get { return _nSaldo; }
            set { _nSaldo = value; }
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

        private decimal _nCapital = 0;
        public decimal nCapital
        {
            get { return _nCapital; }
            set { _nCapital = value; }
        }

        private double _nIntereses = 0;
        public double nIntereses
        {
            get { return _nIntereses; }
            set { _nIntereses = value; }
        }

        private decimal _nGarantia = 0;
        public decimal nGarantia
        {
            get { return _nGarantia; }
            set { _nGarantia = value; }
        }

        private int _nDias = 0;
        public int nDias
        {
            get { return _nDias; }
            set { _nDias = value; }
        }

        private string _cNumOpe = string.Empty;
        public string cNumOpe
        {
            get { return _cNumOpe; }
            set { _cNumOpe = value; }
        }

        private string _IdSocio_Dsc = string.Empty;
        public string IdSocio_Dsc
        {
            get { return _IdSocio_Dsc; }
            set { _IdSocio_Dsc = value; }
        }

        private string _vDocumento = string.Empty;
        public string vDocumento
        {
            get { return _vDocumento; }
            set { _vDocumento = value; }
        }

        private System.DateTime _sdRecepcion = System.DateTime.MinValue;
        public System.DateTime sdRecepcion 
        {
            get { return _sdRecepcion; }
            set { _sdRecepcion = value; }
        }

        private decimal _nvNegociable = 0;
        public decimal nvNegociable
        {
            get { return _nvNegociable; }
            set { _nvNegociable = value; }
        }

        private decimal _nvImporte = 0;
        public decimal nvImporte
        {
            get { return _nvImporte; }
            set { _nvImporte = value; }
        }

        private string _IdPagadora_Dsc = string.Empty;
        public string IdPagadora_Dsc
        {
            get { return _IdPagadora_Dsc; }
            set { _IdPagadora_Dsc = value; }
        }

        private System.DateTime _sdFechaOp = System.DateTime.MinValue;
        public System.DateTime sdFechaOp
        {
            get { return _sdFechaOp; }
            set { _sdFechaOp = value; }
        }

        private string _gSesionID = string.Empty;
        public string gSesionID
        {
            get { return _gSesionID; }
            set { _gSesionID = value; }
        }

        private string _gPlazaID = string.Empty;
        public string gPlazaID
        {
            get { return _gPlazaID; }
            set { _gPlazaID = value; }
        }

        private int _valorMonedaID = 0;
        public int valorMonedaID
        {
            get { return _valorMonedaID; }
            set { _valorMonedaID = value; }
        }

        private string _socioBancoID = string.Empty;
        public string socioBancoID
        {
            get { return _socioBancoID; }
            set { _socioBancoID = value; }
        }

        private string _ctasBancariaID = string.Empty;
        public string ctasBancariaID
        {
            get { return _ctasBancariaID; }
            set { _ctasBancariaID = value; }
        }

        private System.DateTime _sdVencimiento = System.DateTime.MinValue;
        public System.DateTime sdVencimiento
        {
            get { return _sdVencimiento; }
            set { _sdVencimiento = value; }
        }

        private decimal _DifCobrada = 0;
        public decimal DifCobrada
        {
            get { return _DifCobrada; }
            set { _DifCobrada = value; }
        }

        private int _DiasMora = 0;
        public int DiasMora
        {
            get { return _DiasMora; }
            set { _DiasMora = value; }
        }

        private decimal _Interes = 0;
        public decimal Interes
        {
            get { return _Interes; }
            set { _Interes = value; }
        }

        private decimal _Garantia = 0;
        public decimal Garantia
        {
            get { return _Garantia; }
            set { _Garantia = value; }
        }

        private decimal _nTazaActiva = 0;
        public decimal nTazaActiva
        {
            get { return _nTazaActiva; }
            set { _nTazaActiva = value; }
        }

        private decimal _nPorFondoGarantia = 0;
        public decimal nPorFondoGarantia
        {
            get { return _nPorFondoGarantia; }
            set { _nPorFondoGarantia = value; }
        }
    }
}
