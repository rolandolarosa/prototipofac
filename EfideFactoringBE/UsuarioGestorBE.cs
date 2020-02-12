
namespace EfideFactoringBE
{
    public class UsuarioGestorBE : GeneralBE
    {
        private string _UsuarioID = string.Empty;
        public string UsuarioID
        {
            get { return _UsuarioID; }
            set { _UsuarioID = value; }
        }

        private string _IdGestor = string.Empty;
        public string IdGestor
        {
            get { return _IdGestor; }
            set { _IdGestor = value; }
        }

        private string _IdTipoGestor_tt = string.Empty;
        public string IdTipoGestor_tt
        {
            get { return _IdTipoGestor_tt; }
            set { _IdTipoGestor_tt = value; }
        }

        public int IndExport { get; set; }
        public int IndPrint { get; set; }
        public bool bAdmLineaPag { get; set; }
        public bool bAdmBloqueoPag { get; set; }
        public bool bAdmContactos { get; set; }
    }
}
