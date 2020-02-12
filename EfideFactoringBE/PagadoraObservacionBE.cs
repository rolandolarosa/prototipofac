namespace EfideFactoringBE
{
    public class PagadoraObservacionBE : GeneralBE
    {
        private string _IdPagadora = string.Empty;

        public string IdPagadora
        {
            get { return _IdPagadora; }
            set { _IdPagadora = value; }
        }

        private string _IdObservacion = string.Empty;

        public string IdObservacion
        {
            get { return _IdObservacion; }
            set { _IdObservacion = value; }
        }

        private System.DateTime _dtFecha = System.DateTime.MinValue;

        public System.DateTime dtFecha
        {
            get { return _dtFecha; }
            set { _dtFecha = value; }
        }

        private string _vcComentario = string.Empty;

        public string vcComentario
        {
            get { return _vcComentario; }
            set { _vcComentario = value; }
        }

        private string _vcUsuario = string.Empty;

        public string vcUsuario
        {
            get { return _vcUsuario; }
            set { _vcUsuario = value; }
        }
    }
}
