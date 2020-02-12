
namespace EfideFactoringBE
{
    public class SocioGrupoBE : GeneralBE
    {
        private string _IdGrupo = string.Empty;
        public string IdGrupo
        {
            get { return _IdGrupo; }
            set { _IdGrupo = value; }
        }

        private string _vcGrupo;
        public string vcGrupo
        {
            get { return _vcGrupo; }
            set { _vcGrupo = value; }
        }
    }
}
