
namespace EfideFactoringBE
{
    public class SocioGrupoDetBE : GeneralBE
    {
        private string _IdGrupo = string.Empty;
        public string IdGrupo
        {
            get { return _IdGrupo; }
            set { _IdGrupo = value; }
        }

        private string _IdSocio;
        public string IdSocio
        {
            get { return _IdSocio; }
            set { _IdSocio = value; }
        }

        private string _IdSocio_Dsc;
        public string IdSocio_Dsc
        {
            get { return _IdSocio_Dsc; }
            set { _IdSocio_Dsc = value; }
        }
    }
}
