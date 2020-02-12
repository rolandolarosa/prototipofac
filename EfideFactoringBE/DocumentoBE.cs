
namespace EfideFactoringBE
{
    public class DocumentoBE : GeneralBE
    {
        private string _IdDocumento = string.Empty;

        public string IdDocumento
        {
            get { return _IdDocumento; }
            set { _IdDocumento = value; }
        }
        private string _vDocumento = string.Empty;

        public string vDocumento
        {
            get { return _vDocumento; }
            set { _vDocumento = value; }
        }
        private string _cAbreviatura = string.Empty;

        public string cAbreviatura
        {
            get { return _cAbreviatura; }
            set { _cAbreviatura = value; }
        }
        private string _vMascara = string.Empty;

        public string vMascara
        {
            get { return _vMascara; }
            set { _vMascara = value; }
        }

        public bool bTituloValor { get; set; }

        private string _FlgFisicoElectronico = string.Empty;

        public string FlgFisicoElectronico
        {
            get { return _FlgFisicoElectronico; }
            set { _FlgFisicoElectronico = value; }
        }

        private string _FlgImportePago = string.Empty;

        public string FlgImportePago
        {
            get { return _FlgImportePago; }
            set { _FlgImportePago = value; }
        }
    }
}
