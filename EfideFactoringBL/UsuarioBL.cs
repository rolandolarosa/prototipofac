using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class UsuarioBL
    {
        UsuarioDAL UsuarioDAL = new UsuarioDAL();

        public DataSet ProcesarUsuario(UsuarioBE BE)
        {
            return UsuarioDAL.ProcesarUsuario(BE);
        }
    }
}
