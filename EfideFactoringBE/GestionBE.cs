
namespace EfideFactoringBE
{
    public class GestionBE : GeneralBE
    {
        private string _IdGestion = string.Empty;
        public string IdGestion
        {
            get { return _IdGestion; }
            set { _IdGestion = value; }
        }

        private string _IdGestionAtendida = string.Empty;
        public string IdGestionAtendida
        {
            get { return _IdGestionAtendida; }
            set { _IdGestionAtendida = value; }
        }

        private string _IdEntidad = string.Empty;
        public string IdEntidad
        {
            get { return _IdEntidad; }
            set { _IdEntidad = value; }
        }

        private string _Entidad = string.Empty;
        public string Entidad
        {
            get { return _Entidad; }
            set { _Entidad = value; }
        }

        private string _IdAccion_tt = string.Empty;
        public string IdAccion_tt
        {
            get { return _IdAccion_tt; }
            set { _IdAccion_tt = value; }
        }

        private string _IdAccion_tt_Dsc = string.Empty;
        public string IdAccion_tt_Dsc
        {
            get { return _IdAccion_tt_Dsc; }
            set { _IdAccion_tt_Dsc = value; }
        }

        private string _IdTipoCompromiso_tt = string.Empty;
        public string IdTipoCompromiso_tt
        {
            get { return _IdTipoCompromiso_tt; }
            set { _IdTipoCompromiso_tt = value; }
        }

        private string _IdTipoCompromiso_tt_Dsc = string.Empty;
        public string IdTipoCompromiso_tt_Dsc
        {
            get { return _IdTipoCompromiso_tt_Dsc; }
            set { _IdTipoCompromiso_tt_Dsc = value; }
        }

        private System.DateTime _dtFechaCompromiso = System.DateTime.MinValue;
        public System.DateTime dtFechaCompromiso
        {
            get { return _dtFechaCompromiso; }
            set { _dtFechaCompromiso = value; }
        }

        private string _IdMotivo_tt = string.Empty;
        public string IdMotivo_tt
        {
            get { return _IdMotivo_tt; }
            set { _IdMotivo_tt = value; }
        }

        private string _IdMotivo_tt_Dsc = string.Empty;
        public string IdMotivo_tt_Dsc
        {
            get { return _IdMotivo_tt_Dsc; }
            set { _IdMotivo_tt_Dsc = value; }
        }

        private string _Comentario = string.Empty;
        public string Comentario
        {
            get { return _Comentario; }
            set { _Comentario = value; }
        }

        private int _FlgSocio = 0;
        public int FlgSocio
        {
            get { return _FlgSocio; }
            set { _FlgSocio = value; }
        }

        private int _FlgInteresado = 0;
        public int FlgInteresado
        {
            get { return _FlgInteresado; }
            set { _FlgInteresado = value; }
        }

        private string _IdEstado_tt = string.Empty;
        public string IdEstado_tt
        {
            get { return _IdEstado_tt; }
            set { _IdEstado_tt = value; }
        }

        private string _UsuarioID = string.Empty;
        public string UsuarioID
        {
            get { return _UsuarioID; }
            set { _UsuarioID = value; }
        }

        private System.DateTime _FechaInicio = System.DateTime.MinValue;
        public System.DateTime FechaInicio
        {
            get { return _FechaInicio; }
            set { _FechaInicio = value; }
        }

        private System.DateTime _FechaFin = System.DateTime.MinValue;
        public System.DateTime FechaFin
        {
            get { return _FechaFin; }
            set { _FechaFin = value; }
        }
    }
}
