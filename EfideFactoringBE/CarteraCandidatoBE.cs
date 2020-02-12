
namespace EfideFactoringBE
{
    public class CarteraCandidatoBE : GeneralBE
    {
        private string _IdCartera = string.Empty;

        public string IdCartera 
        {
            get { return _IdCartera; }
            set { _IdCartera = value; }
        }

        private string _cRucPagadora = string.Empty;
        public string cRucPagadora
        {
            get { return _cRucPagadora; }
            set { _cRucPagadora = value; }
        }

        private string _vApePaterno = string.Empty;

        public string vApePaterno
        {
            get { return _vApePaterno; }
            set { _vApePaterno = value; }
        }

        private string _vApeMaterno = string.Empty;
        public string vApeMaterno
        {
            get { return _vApeMaterno; }
            set { _vApeMaterno = value; }
        }

        private string _vNombre = string.Empty;
        public string vNombre
        {
            get { return _vNombre; }
            set { _vNombre = value; }
        }

        private string _IdTipoDocumento_tt = string.Empty;
        public string IdTipoDocumento_tt
        {
            get { return _IdTipoDocumento_tt; }
            set { _IdTipoDocumento_tt = value; }
        }

        private string _IdTipoDocumento_tt_Dsc = string.Empty;
        public string IdTipoDocumento_tt_Dsc
        {
            get { return _IdTipoDocumento_tt_Dsc; }
            set { _IdTipoDocumento_tt_Dsc = value; }
        }

        private string _vNroDocumento = string.Empty;
        public string vNroDocumento
        {
            get { return _vNroDocumento; }
            set { _vNroDocumento = value; }
        }

        private string _IdTipoPersona_tt = string.Empty;
        public string IdTipoPersona_tt
        {
            get { return _IdTipoPersona_tt; }
            set { _IdTipoPersona_tt = value; }
        }

        private string _IdTipoPersona_tt_Dsc = string.Empty;
        public string IdTipoPersona_tt_Dsc
        {
            get { return _IdTipoPersona_tt_Dsc; }
            set { _IdTipoPersona_tt_Dsc = value; }
        }

        private int _cGlobal_TipoRiesgo = 0;
        public int cGlobal_TipoRiesgo
        {
            get { return _cGlobal_TipoRiesgo; }
            set { _cGlobal_TipoRiesgo = value; }
        }

        private int _cGlobal_TipoEmpresa = 0;
        public int cGlobal_TipoEmpresa
        {
            get { return _cGlobal_TipoEmpresa; }
            set { _cGlobal_TipoEmpresa = value; }
        }

        private string _vContacto = string.Empty;
        public string vContacto
        {
            get { return _vContacto; }
            set { _vContacto = value; }
        }

        private string _vCargo = string.Empty;
        public string vCargo
        {
            get { return _vCargo; }
            set { _vCargo = value; }
        }

        private string _vTelefono1 = string.Empty;
        public string vTelefono1
        {
            get { return _vTelefono1; }
            set { _vTelefono1 = value; }
        }

        private string _vTelefono2 = string.Empty;
        public string vTelefono2
        {
            get { return _vTelefono2; }
            set { _vTelefono2 = value; }
        }

        private string _vTelefono3 = string.Empty;
        public string vTelefono3
        {
            get { return _vTelefono3; }
            set { _vTelefono3 = value; }
        }

        private string _vCorreo = string.Empty;
        public string vCorreo
        {
            get { return _vCorreo; }
            set { _vCorreo = value; }
        }

        private string _UsuarioID = string.Empty;
        public string UsuarioID
        {
            get { return _UsuarioID; }
            set { _UsuarioID = value; }
        }

        private int _FlgPagadora = 0;
        public int FlgPagadora
        {
            get { return _FlgPagadora; }
            set { _FlgPagadora = value; }
        }
    }
}
