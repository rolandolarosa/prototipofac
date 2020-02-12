
namespace EfideFactoringBE
{
    public class UsuarioBE : GeneralBE
    {
        private string _usuarioID = string.Empty;
        public string usuarioID
        {
            get { return _usuarioID; }
            set { _usuarioID = value; }
        }

        private string _usuContrasena = string.Empty;
        public string usuContrasena
        {
            get { return _usuContrasena; }
            set { _usuContrasena = value; }
        }

        private System.DateTime _pfecha;
        public System.DateTime pfecha
        {
            get { return _pfecha; }
            set { _pfecha = value; }
        }

    }
}
