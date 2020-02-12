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
    public class RenovacionBL : IRenovacionD
    {
        private RenovacionDA _RenovacionDA;
        private RenovacionDA oRenovacionDA
        {
            get { return (_RenovacionDA == null ? _RenovacionDA = new RenovacionDA() : _RenovacionDA); }
        }

        public string insertRenovacion(RenovacionBE pRenovacionBE)
        {
            return oRenovacionDA.insertRenovacion(pRenovacionBE);
        }

        public void updateRenovacion(RenovacionBE pRenovacionBE)
        {
            oRenovacionDA.updateRenovacion(pRenovacionBE);
        }

        public List<RenovacionBE> listRenovacion(RenovacionBE pRenovacionBE)
        {
            return oRenovacionDA.listRenovacion(pRenovacionBE);
        }

        public RenovacionBE getRenovacion(string idRenovacion)
        {
            return oRenovacionDA.getRenovacion(idRenovacion);
        }
    }
}
