using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.adeudo;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.adeudo;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.adeudo;

namespace Efide.Tesoreria.BusinessLogic.adeudo
{
    public class ConfirmacionBL : IConfirmacionD
    {
        private ConfirmacionDA _ConfirmacionDA;
        private ConfirmacionDA oConfirmacionDA
        {
            get { return (_ConfirmacionDA == null ? _ConfirmacionDA = new ConfirmacionDA() : _ConfirmacionDA); }
        }

        public string insertConfirmacion(ConfirmacionBE pConfirmacionBE)
        {
            return oConfirmacionDA.insertConfirmacion(pConfirmacionBE);
        }
    }
}
