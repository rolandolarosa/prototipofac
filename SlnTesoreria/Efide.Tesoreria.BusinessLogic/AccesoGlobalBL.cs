using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity;
using Efide.Tesoreria.DataAccess;

namespace Efide.Tesoreria.BusinessLogic
{
    public class AccesoGlobalBL
    {
        private AccesoGlobalDA _AccesoGlobalDA;
        private AccesoGlobalDA oAccesoGlobalDA
        {
            get { return (_AccesoGlobalDA == null ? _AccesoGlobalDA = new AccesoGlobalDA() : _AccesoGlobalDA); }
        }

        public List<AccesoGlobalBE> ListaAccesos(PermisoBE pPermisoBE)
        {
            return oAccesoGlobalDA.ListaAccesos(pPermisoBE);
        }
    }
}
