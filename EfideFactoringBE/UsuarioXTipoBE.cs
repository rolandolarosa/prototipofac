
namespace EfideFactoringBE
{
    public class UsuarioXTipoBE : GeneralBE
    {
        private string _UsuarioID = string.Empty;
        public string UsuarioID
        {
            get { return _UsuarioID; }
            set { _UsuarioID = value; }
        }

        private string _Table_Id_Tipo = string.Empty;
        public string Table_Id_Tipo
        {
            get { return _Table_Id_Tipo; }
            set { _Table_Id_Tipo = value; }
        }
    }
}
