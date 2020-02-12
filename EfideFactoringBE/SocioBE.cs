
namespace EfideFactoringBE
{
    public class SocioBE : GeneralBE
    {
        private string _CodSocio = string.Empty;

        public string CodSocio
        {
            get { return _CodSocio; }
            set { _CodSocio = value; }
        }

        private string _RazonSocial = string.Empty;

        public string RazonSocial
        {
            get { return _RazonSocial; }
            set { _RazonSocial = value; }
        }
    }   
}
