
namespace EfideFactoringBE
{
    public class CarteraSocioBE : GeneralBE
    {
        private string _IdSocio = string.Empty;
        public string IdSocio
        {
            get { return _IdSocio; }
            set { _IdSocio = value; }
        }

        private string _IdPagadora = string.Empty;
        public string IdPagadora
        {
            get { return _IdPagadora; }
            set { _IdPagadora = value; }
        }

        private int _NumDias = 0;
        public int NumDias
        {
            get { return _NumDias; }
            set { _NumDias = value; }
        }

        private string _UsuarioID = string.Empty;

        public string UsuarioID
        {
            get { return _UsuarioID; }
            set { _UsuarioID = value; }
        }

        private string _IdSocio_Dsc = string.Empty;
        public string IdSocio_Dsc
        {
            get { return _IdSocio_Dsc; }
            set { _IdSocio_Dsc = value; }
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

        private string _gestorCuentaID = string.Empty;
        public string gestorCuentaID
        {
            get { return _gestorCuentaID; }
            set { _gestorCuentaID = value; }
        }

        private System.DateTime _FechaInactivo1 = System.DateTime.MinValue;
        public System.DateTime FechaInactivo1
        {
            get { return _FechaInactivo1; }
            set { _FechaInactivo1 = value; }
        }

        private System.DateTime _FechaInactivo2 = System.DateTime.MinValue;
        public System.DateTime FechaInactivo2
        {
            get { return _FechaInactivo2; }
            set { _FechaInactivo2 = value; }
        }
    }
}
