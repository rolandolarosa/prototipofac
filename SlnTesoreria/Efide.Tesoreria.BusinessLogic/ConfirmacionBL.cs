using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class ConfirmacionBL : IConfirmacionD
    {
        private ConfirmacionDA _ConfirmacionDA;
        private ConfirmacionDA oConfirmacionDA
        {
            get { return (_ConfirmacionDA == null ? _ConfirmacionDA = new ConfirmacionDA() : _ConfirmacionDA); }
        }

        public string insertConfirmacion(BusinessEntity.ConfirmacionBE pConfirmacionBE)
        {
            return oConfirmacionDA.insertConfirmacion(pConfirmacionBE);
        }
    }
}
