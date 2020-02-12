
namespace EfideFactoringBE
{
    public class LimiteCreditoLogBE : GeneralBE
    {
        private string _IdLog = string.Empty;
        public string IdLog
        {
            get { return _IdLog; }
            set { _IdLog = value; }
        }

        private System.DateTime _dtRegistro = System.DateTime.MinValue;
        public System.DateTime dtRegistro
        {
            get { return _dtRegistro; }
            set { _dtRegistro = value; }
        }

        private string _IdSocio = string.Empty;
        public string IdSocio
        {
            get { return _IdSocio; }
            set { _IdSocio = value; }
        }

        private string _IdSocio_Dsc = string.Empty;
        public string IdSocio_Dsc
        {
            get { return _IdSocio_Dsc; }
            set { _IdSocio_Dsc = value; }
        }

        private string _IdReferencia = string.Empty;

        public string IdReferencia
        {
            get { return _IdReferencia; }
            set { _IdReferencia = value; }
        }
    }
}
