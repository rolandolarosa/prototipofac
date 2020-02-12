
namespace EfideFactoringBE
{
    public class DepositosSABE : GeneralBE
    {
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

        private string _socioBancoID = string.Empty;

        public string socioBancoID
        {
            get { return _socioBancoID; }
            set { _socioBancoID = value; }
        }

        private string _pagar_personaID = string.Empty;

        public string pagar_personaID
        {
            get { return _pagar_personaID; }
            set { _pagar_personaID = value; }
        }

        private int _valorMonedaID = 0;

        public int valorMonedaID
        {
            get { return _valorMonedaID; }
            set { _valorMonedaID = value; }
        }

        private string _valorMonedaID_Dsc = string.Empty;

        public string valorMonedaID_Dsc
        {
            get { return _valorMonedaID_Dsc; }
            set { _valorMonedaID_Dsc = value; }
        }

        private string _ctasBancariaID = string.Empty;

        public string ctasBancariaID
        {
            get { return _ctasBancariaID; }
            set { _ctasBancariaID = value; }
        }

        private string _Saldo = string.Empty;

        public string Saldo
        {
            get { return _Saldo; }
            set { _Saldo = value; }
        }
    }
}
