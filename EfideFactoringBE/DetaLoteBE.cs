
namespace EfideFactoringBE
{
    public class DetaLoteBE : GeneralBE
    {
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

        private string _IdSocio_Beneficiario = string.Empty;

        public string IdSocio_Beneficiario
        {
            get { return _IdSocio_Beneficiario; }
            set { _IdSocio_Beneficiario = value; }
        }

        private string _IdSocio_BeneficiarioRuc = string.Empty;
        public string IdSocio_BeneficiarioRuc
        {
            get { return _IdSocio_BeneficiarioRuc; }
            set { _IdSocio_BeneficiarioRuc = value; }
        }        

        private string _cNumDoc = string.Empty;

        public string cNumDoc
        {
            get { return _cNumDoc; }
            set { _cNumDoc = value; }
        }

        private System.DateTime _sdRecepcion;

        public System.DateTime sdRecepcion
        {
            get { return _sdRecepcion; }
            set { _sdRecepcion = value; }
        }

        private int _iPlazo = 0;

        public int iPlazo
        {
            get { return _iPlazo; }
            set { _iPlazo = value; }
        }

        private System.DateTime _sdVencimiento;

        public System.DateTime sdVencimiento
        {
            get { return _sdVencimiento; }
            set { _sdVencimiento = value; }
        }

        private decimal _nvNominal = 0;

        public decimal nvNominal
        {
            get { return _nvNominal; }
            set { _nvNominal = value; }
        }

        private string _cNotaCredito = string.Empty;

        public string cNotaCredito
        {
            get { return _cNotaCredito; }
            set { _cNotaCredito = value; }
        }

        private decimal _nNotaCredito = 0;

        public decimal nNotaCredito
        {
            get { return _nNotaCredito; }
            set { _nNotaCredito = value; }
        }

        private decimal _nPorRetencion = 0;

        public decimal nPorRetencion
        {
            get { return _nPorRetencion; }
            set { _nPorRetencion = value; }
        }

        private decimal _nvRetencion = 0;

        public decimal nvRetencion
        {
            get { return _nvRetencion; }
            set { _nvRetencion = value; }
        }

        private decimal _Descuento = 0;

        public decimal Descuento
        {
            get { return _Descuento; }
            set { _Descuento = value; }
        }

        private string _IdSocio = string.Empty;

        public string IdSocio
        {
            get { return _IdSocio; }
            set { _IdSocio = value; }
        }

        private decimal _nvNegociable = 0;

        public decimal nvNegociable
        {
            get { return _nvNegociable; }
            set { _nvNegociable = value; }
        }

        private decimal _nTazaActiva = 0;

        public decimal nTazaActiva
        {
            get { return _nTazaActiva; }
            set { _nTazaActiva = value; }
        }

        private decimal _nFondoGarantia = 0;

        public decimal nFondoGarantia
        {
            get { return _nFondoGarantia; }
            set { _nFondoGarantia = value; }
        }

        private string _IdPagadora_Dsc = string.Empty;

        public string IdPagadora_Dsc
        {
            get { return _IdPagadora_Dsc; }
            set { _IdPagadora_Dsc = value; }
        }

        private string _vDocumento = string.Empty;

        public string vDocumento
        {
            get { return _vDocumento; }
            set { _vDocumento = value; }
        }

        private decimal _nTasaSobregiro = 0;

        public decimal nTasaSobregiro
        {
            get { return _nTasaSobregiro; }
            set { _nTasaSobregiro = value; }
        }

        private string _IdMoneda_tt = string.Empty;
        public string IdMoneda_tt
        {
            get { return _IdMoneda_tt; }
            set { _IdMoneda_tt = value; }
        }

        private string _Tipo = string.Empty;
        public string Tipo
        {
            get { return _Tipo; }
            set { _Tipo = value; }
        }

        private System.DateTime _dtRenovacion = System.DateTime.MinValue;

        public System.DateTime dtRenovacion
        {
            get { return _dtRenovacion; }
            set { _dtRenovacion = value; }
        }

        public bool bNoRequiereProtesto { get; set; }

        private byte[] _ImageDoc;

        public byte[] ImageDoc
        {
            get { return _ImageDoc; }
            set { _ImageDoc = value; }
        }

        private string _FlgEnvioCorreo = string.Empty;
        public string FlgEnvioCorreo
        {
            get { return _FlgEnvioCorreo; }
            set { _FlgEnvioCorreo = value; }
        }

        private System.DateTime _dtEnvioCorreo = System.DateTime.MinValue;
        public System.DateTime dtEnvioCorreo
        {
            get { return _dtEnvioCorreo; }
            set { _dtEnvioCorreo = value; }
        }

        private string _FlgConfirmadoPagadora = string.Empty;
        public string FlgConfirmadoPagadora
        {
            get { return _FlgConfirmadoPagadora; }
            set { _FlgConfirmadoPagadora = value; }
        }

        private System.DateTime _dtConfirmadoPagadora = System.DateTime.MinValue;
        public System.DateTime dtConfirmadoPagadora
        {
            get { return _dtConfirmadoPagadora; }
            set { _dtConfirmadoPagadora = value; }
        }

        private string _IdImageDoc = string.Empty;
        public string IdImageDoc
        {
            get { return _IdImageDoc; }
            set { _IdImageDoc = value; }
        }
    }
}
