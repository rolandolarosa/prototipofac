using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Efide.Tesoreria.DataAccess;
using Efide.Tesoreria.IntercafeData;

namespace Efide.Tesoreria.BusinessLogic
{
    public class RenovacionBL : IRenovacionD
    {
        private RenovacionDA _RenovacionDA;
        private RenovacionDA oRenovacionDA
        {
            get { return (_RenovacionDA == null ? _RenovacionDA = new RenovacionDA() : _RenovacionDA); }
        }

        public string insertRenovacion(BusinessEntity.RenovacionBE pRenovacionBE)
        {
            return oRenovacionDA.insertRenovacion(pRenovacionBE);
        }

        public void updateRenovacion(BusinessEntity.RenovacionBE pRenovacionBE)
        {
            oRenovacionDA.updateRenovacion(pRenovacionBE);
        }

        public List<BusinessEntity.RenovacionBE> listRenovacion(BusinessEntity.RenovacionBE pRenovacionBE)
        {
            return oRenovacionDA.listRenovacion(pRenovacionBE);
        }

        public BusinessEntity.RenovacionBE getRenovacion(string idRenovacion)
        {
            return oRenovacionDA.getRenovacion(idRenovacion);
        }
    }
}
