using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class UsuarioGestorBL
    {
        UsuarioGestorDAL UsuarioDAL = new UsuarioGestorDAL();

        public DataSet ProcesarUsuarioGestor(UsuarioGestorBE BE)
        {
            return UsuarioDAL.ProcesarUsuarioGestor(BE);
        }
    }
}
