using System.Data;
using EfideFactoringBE;
using EfideFactoringDA;

namespace EfideFactoringBL
{
    public class UsuarioXTipoBL
    {
        UsuarioXTipoDAL UsuarioXTipoDAL = new UsuarioXTipoDAL();

        public DataSet ProcesarUsuarioXTipo(UsuarioXTipoBE BE)
        {
            return UsuarioXTipoDAL.ProcesarUsuarioXTipo(BE);
        }
    }
}
