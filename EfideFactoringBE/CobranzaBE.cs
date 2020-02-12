
namespace EfideFactoringBE
{
    public class CobranzaBE : GeneralBE
    {
        private string _IdCobranza = string.Empty;
        public string IdCobranza
        {
            get { return _IdCobranza; }
            set { _IdCobranza = value; }
        }

        private System.DateTime _dtRegistro;
        public System.DateTime dtRegistro
        {
            get { return _dtRegistro; }
            set { _dtRegistro = value; }
        }

        private System.DateTime _dtValuta;
        public System.DateTime dtValuta
        {
            get { return _dtValuta; }
            set { _dtValuta = value; }
        }

        private string _IdTipoCobranza_tt = string.Empty;
        public string IdTipoCobranza_tt
        {
            get { return _IdTipoCobranza_tt; }
            set { _IdTipoCobranza_tt = value; }
        }

        private string _IdMoneda_tt = string.Empty;
        public string IdMoneda_tt
        {
            get { return _IdMoneda_tt; }
            set { _IdMoneda_tt = value; }
        }

        private string _CtasBancariasID = string.Empty;
        public string CtasBancariasID
        {
            get { return _CtasBancariasID; }
            set { _CtasBancariasID = value; }
        }

        private decimal _nTotal = 0;
        public decimal nTotal
        {
            get { return _nTotal; }
            set { _nTotal = value; }
        }

        private string _IdOperacion_tt = string.Empty;
        public string IdOperacion_tt
        {
            get { return _IdOperacion_tt; }
            set { _IdOperacion_tt = value; }
        }

        private string _IdTipoAbono_tt = string.Empty;
        public string IdTipoAbono_tt
        {
            get { return _IdTipoAbono_tt; }
            set { _IdTipoAbono_tt = value; }
        }

        private string _DatosAdicionales = string.Empty;
        public string DatosAdicionales
        {
            get { return _DatosAdicionales; }
            set { _DatosAdicionales = value; }
        }

        private string _Entidad = string.Empty;
        public string Entidad
        {
            get { return _Entidad; }
            set { _Entidad = value; }
        }

        private string _socioBancoID = string.Empty;
        public string socioBancoID
        {
            get { return _socioBancoID; }
            set { _socioBancoID = value; }
        }

        private string _Status = string.Empty;
        public string Status
        {
            get { return _Status; }
            set { _Status = value; }
        }

        private int _iMonedaID = 0;
        public int iMonedaID
        {
            get { return _iMonedaID; }
            set { _iMonedaID = value; }
        }
    }
}
