
namespace EfideFactoringBE
{
    public class ImportacionLoteBE : GeneralBE
    {
        private string _RucPagadora = string.Empty;

        public string RucPagadora
        {
            get { return _RucPagadora; }
            set { _RucPagadora = value; }
        }

        private string _IdSocio = string.Empty;

        public string IdSocio
        {
            get { return _IdSocio; }
            set { _IdSocio = value; }
        }

        private string _IdLinea = string.Empty;

        public string IdLinea
        {
            get { return _IdLinea; }
            set { _IdLinea = value; }
        }

        private string _IdDocumento = string.Empty;

        public string IdDocumento
        {
            get { return _IdDocumento; }
            set { _IdDocumento = value; }
        }

        private string _IdMoneda_tt = string.Empty;

        public string IdMoneda_tt
        {
            get { return _IdMoneda_tt; }
            set { _IdMoneda_tt = value; }
        }

        private string _cNumDoc = string.Empty;

        public string cNumDoc
        {
            get { return _cNumDoc; }
            set { _cNumDoc = value; }
        }

        private string _Pagadora_Dsc = string.Empty;

        public string Pagadora_Dsc
        {
            get { return _Pagadora_Dsc; }
            set { _Pagadora_Dsc = value; }
        }

        private string _RucGiradorOriginal = string.Empty;

        public string RucGiradorOriginal
        {
            get { return _RucGiradorOriginal; }
            set { _RucGiradorOriginal = value; }
        }
    }
}
