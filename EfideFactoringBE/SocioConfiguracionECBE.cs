
namespace EfideFactoringBE
{
    public class SocioConfiguracionECBE : GeneralBE
    {
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

        private System.DateTime _dtInicioProceso = System.DateTime.MinValue;

        public System.DateTime dtInicioProceso
        {
            get { return _dtInicioProceso; }
            set { _dtInicioProceso = value; }
        }
    }   
}
