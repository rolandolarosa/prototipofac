using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.DataAccess;

namespace Efide.Tesoreria.BusinessLogic
{
    public class UsuarioBL
    {
        private UsuarioDA _UsuarioDA;
        private UsuarioDA oUsuarioDA
        {
            get { return (_UsuarioDA == null ? _UsuarioDA = new UsuarioDA() : _UsuarioDA); }
        }

        public List<UsuarioBE> ProcesarUsuario(UsuarioBE pUsuarioBE)
        {
            return oUsuarioDA.ProcesarUsuario(pUsuarioBE);
        }
    }
}
