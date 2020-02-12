using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.BusinessEntity.inversion;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.DataAccess.inversion;
using Efide.Tesoreria.IntercafeData;
using Efide.Tesoreria.IntercafeData.inversion;

namespace Efide.Tesoreria.BusinessLogic.inversion
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
